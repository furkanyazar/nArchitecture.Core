using NArchitecture.Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class UserGroupOperationClaim<TUserGroupId, TOperationClaimId> : Entity<TUserGroupId>
{
    public TUserGroupId UserGroupId { get; set; }
    public TOperationClaimId OperationClaimId { get; set; }

    public UserGroupOperationClaim()
    {
        UserGroupId = default!;
        OperationClaimId = default!;
    }

    public UserGroupOperationClaim(TUserGroupId userGroupId, TOperationClaimId operationClaimId)
    {
        UserGroupId = userGroupId;
        OperationClaimId = operationClaimId;
    }

    public UserGroupOperationClaim(TUserGroupId id, TUserGroupId userGroupId, TOperationClaimId operationClaimId)
        : base(id)
    {
        UserGroupId = userGroupId;
        OperationClaimId = operationClaimId;
    }
}
