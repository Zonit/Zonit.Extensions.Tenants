namespace Zonit.Extensions.Tenants.Abstractions.Settings;

public interface ISetting
{
    string Key { get; }
    string Name { get; }
    string Description { get; }
}

public interface ISetting<T> : ISetting
{
    T Value { get; set; }
    IReadOnlyCollection<T>? Templates { get; }
}

public abstract class Setting<T> : ISetting<T>
{
    public abstract string Key { get; }
    public abstract string Name { get; }
    public abstract string Description { get; }
    
    public virtual T Value { get; set; } = default!;
    public virtual IReadOnlyCollection<T>? Templates { get; } = null;
}