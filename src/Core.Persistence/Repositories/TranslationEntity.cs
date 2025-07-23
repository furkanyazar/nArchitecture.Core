namespace Core.Persistence.Repositories;

public class TranslationEntity<TEntity, TEntityId> : Entity<Guid>
    where TEntity : Entity<TEntityId>
{
    public TEntityId EntityId { get; set; }
    public string LanguageCode { get; set; } = "tr";

    public virtual TEntity Entity { get; set; } = default!;

    public TranslationEntity()
    {
        EntityId = default!;
    }

    public TranslationEntity(TEntityId entityId, string languageCode)
        : base()
    {
        EntityId = entityId;
        LanguageCode = languageCode;
    }

    public TranslationEntity(Guid id, TEntityId entityId, string languageCode)
        : base(id)
    {
        EntityId = entityId;
        LanguageCode = languageCode;
    }
}
