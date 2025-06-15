using Core.CrossCuttingConcerns.Logging.Configurations;
using Serilog;
using Serilog.Sinks.Elasticsearch;

namespace Core.CrossCuttingConcerns.Logging.Serilog.Elasticsearch;

public class SerilogElasticsearchLogger : SerilogLoggerServiceBase
{
    public SerilogElasticsearchLogger(ElasticSearchConfiguration elasticSearchConfiguration)
        : base(logger: null!)
    {
        Logger = new LoggerConfiguration()
            .WriteTo.Elasticsearch(
                new ElasticsearchSinkOptions(new Uri(elasticSearchConfiguration.ConnectionString))
                {
                    AutoRegisterTemplate = true,
                    IndexFormat = elasticSearchConfiguration.ProjectName + "-logs-{0:yyyy.MM.dd}",
                }
            )
            .CreateLogger();
    }
}
