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

        if (variable is not null)
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

                        // Sprawdź czy właściwość ma setter
                        if (valueProperty.SetMethod != null)
                        {
                            valueProperty.SetValue(setting, deserializedValue);
                        }
                        else if (setting is ISetting<object> genericSetting)
                        {
                            // Próbujemy dostępu przez generyczny interfejs, który ma setter
                            typeof(ISetting<>).MakeGenericType(valueType)
                                .GetProperty("Value")?.SetValue(setting, deserializedValue);
                        }
                    }
                }
                catch (Exception)
                {
                    // Jeśli deserializacja się nie powiedzie, pozostaw domyślną wartość
                }
            }
        }
        else
        {
            // Jeśli nie znaleziono zmiennej, spróbuj ustawić domyślną wartość
            var valueProperty = typeof(T).GetProperties()
                .FirstOrDefault(p => p.Name == "Value");

            if (valueProperty != null && valueProperty.SetMethod != null)
            {
                // Próbujemy ustawić domyślną wartość tylko jeśli property ma setter
                valueProperty.SetValue(setting, Activator.CreateInstance(valueProperty.PropertyType));
            }
            else if (setting is ISetting<object> genericSetting && valueProperty is not null)
            {
                // Próbujemy dostępu przez generyczny interfejs
                var valueType = valueProperty.PropertyType;
                var genericInterface = typeof(ISetting<>).MakeGenericType(valueType);
                var genericProperty = genericInterface.GetProperty("Value");

                if (genericProperty?.SetMethod != null)
                {
                    genericProperty.SetValue(setting, Activator.CreateInstance(valueType));
                }
            }
            // W przeciwnym razie pozostawiamy wartość domyślną
        }

        return setting;
    }
}