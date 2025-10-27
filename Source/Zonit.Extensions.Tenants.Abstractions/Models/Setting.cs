namespace Zonit.Extensions.Tenants.Abstractions.Models;

public interface ISetting
{
    string Key { get; }
    string Name { get; }
    string Description { get; }
    object Value { get; }
}

public interface ISetting<T> : ISetting
{
    new T Value { get; set; }
    IReadOnlyCollection<T>? Templates { get; }
    object ISetting.Value => Value!;
}

public abstract class Setting<T> : ISetting<T>
{
    public abstract string Key { get; }
    public abstract string Name { get; }
    public abstract string Description { get; }

    public virtual T Value { get; set; } = default!;
    public virtual IReadOnlyCollection<T>? Templates { get; } = null;
}