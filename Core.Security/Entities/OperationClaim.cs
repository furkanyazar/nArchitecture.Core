using NArchitecture.Core.Persistence.Repositories;

namespace NArchitecture.Core.Security.Entities;

public class OperationClaim<TId> : Entity<TId>
{
    public TId ParentId { get; set; }
    public string Name { get; set; }

    public OperationClaim()
    {
        ParentId = default!;
        Name = string.Empty;
    }

    public OperationClaim(TId parentId, string name)
    {
        ParentId = parentId;
        Name = name;
    }

    public OperationClaim(TId id, TId parentId, string name)
        : base(id)
    {
        ParentId = parentId;
        Name = name;
    }
}
