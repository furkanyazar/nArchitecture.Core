using NArchitecture.Core.Persistence.Repositories;

namespace NArchitecture.Core.Security.Entities;

public class UserGroup<TId> : Entity<TId>
{
    public TId ParentId { get; set; }
    public string Name { get; set; }

    public UserGroup()
    {
        ParentId = default!;
        Name = string.Empty;
    }

    public UserGroup(TId parentId, string name)
    {
        ParentId = parentId;
        Name = name;
    }

    public UserGroup(TId id, TId parentId, string name)
        : base(id)
    {
        ParentId = parentId;
        Name = name;
    }
}
