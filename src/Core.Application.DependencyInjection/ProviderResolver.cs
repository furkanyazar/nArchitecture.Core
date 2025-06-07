namespace Core.Application.DependencyInjection;

public class ProviderResolver<T>
    where T : Provider
{
    private readonly IEnumerable<T> _providers;

    public ProviderResolver(IEnumerable<T> providers)
    {
        _providers = providers;
    }

    public T GetProvider(string name)
    {
        T? provider = _providers.Where(provider => provider.Name == name).FirstOrDefault();
        return provider ?? throw new InvalidOperationException($"Provider with name '{name}' not found.");
    }
}
