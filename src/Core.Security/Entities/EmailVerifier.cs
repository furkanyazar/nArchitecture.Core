using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class EmailVerifier<TId, TUserId> : Entity<TId>
{
    public TUserId UserId { get; set; }
    public string? ActivationKey { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public bool IsVerified { get; set; }

    public EmailVerifier()
    {
        UserId = default!;
    }

    public EmailVerifier(TUserId userId, string? activationKey, DateTime? expirationDate, bool isVerified)
    {
        UserId = userId;
        ActivationKey = activationKey;
        ExpirationDate = expirationDate;
        IsVerified = isVerified;
    }

    public EmailVerifier(TId id, TUserId userId, string? activationKey, DateTime? expirationDate, bool isVerified)
        : base(id)
    {
        UserId = userId;
        ActivationKey = activationKey;
        ExpirationDate = expirationDate;
        IsVerified = isVerified;
    }
}
