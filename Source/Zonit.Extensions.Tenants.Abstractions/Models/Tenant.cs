namespace Zonit.Extensions.Tenants;

public class Tenant
{
    public required Guid Id { get; init; }
    public required string Domain { get; init; }
    public IReadOnlyCollection<Variable> Variables { get; set; } = [];
}
