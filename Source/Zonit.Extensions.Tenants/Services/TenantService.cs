using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Reflection;
using Zonit.Extensions.Tenants.Abstractions.Settings;

namespace Zonit.Extensions.Tenants.Services;

internal class TenantService(IHttpContextAccessor _httpContextAccessor) : ITenantProvider
{
    private Tenant? CurrentTenant
    {
        get
        {
            var context = _httpContextAccessor.HttpContext;
            if (context != null && context.Items.TryGetValue("tenant", out var tenantObj))
            {
                return tenantObj as Tenant;
            }
            return null;
        }
    }

    public T GetSetting<T>() where T : class, ISetting, new()
    {
        var tenant = CurrentTenant;

        if (tenant == null)
            return new T();

        var setting = new T();
        var variable = tenant.Variables.FirstOrDefault(v => v.Key == setting.Key);

        if (variable != null)
        {
            var valueProperty = typeof(T).GetProperties()
                .FirstOrDefault(p => p.Name == "Value");

            if (valueProperty != null)
            {
                try
                {
                    var valueType = valueProperty.PropertyType;
                    var jsonValue = variable.Value;

                    // Wybierz konkretne przeciążenie metody Deserialize
                    var deserializeMethod = typeof(JsonSerializer).GetMethod(
                        nameof(JsonSerializer.Deserialize),
                        BindingFlags.Public | BindingFlags.Static,
                        null,
                        [typeof(string), typeof(JsonSerializerOptions)],
                        null
                    );

                    if (deserializeMethod != null)
                    {
                        // Stwórz typowaną generyczną wersję metody
                        var genericMethod = deserializeMethod.MakeGenericMethod(valueType);

                        // Wywołaj metodę z odpowiednimi parametrami
                        var deserializedValue = genericMethod.Invoke(
                            null,
                            [jsonValue, null]
                        );

                        valueProperty.SetValue(setting, deserializedValue);
                    }
                }
                catch (Exception)
                {
                    // Jeśli deserializacja się nie powiedzie, pozostaw domyślną wartość
                }
            }
        }

        return setting;
    }
}