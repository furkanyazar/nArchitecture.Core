namespace Core.CrossCuttingConcerns.Logging.Configurations;

public class ElasticSearchConfiguration
{
    public string ProjectName { get; set; }
    public string ConnectionString { get; set; }

    public ElasticSearchConfiguration()
    {
        ProjectName = string.Empty;
        ConnectionString = string.Empty;
    }

    public ElasticSearchConfiguration(string projectName, string connectionString)
    {
        ProjectName = projectName;
        ConnectionString = connectionString;
    }
}
