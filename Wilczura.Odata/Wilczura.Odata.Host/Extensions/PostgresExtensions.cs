using Microsoft.EntityFrameworkCore;
using Npgsql;
using Wilczura.Odata.Adapters.Postgres;

namespace Wilczura.Odata.Host.Extensions;

public static class PostgresExtensions
{
    public static IHostApplicationBuilder AddPostgres(
        this IHostApplicationBuilder app, string connectionName, ILogger logger)
    {
        var connectionString = app.Configuration.GetConnectionString(connectionName);
        if (string.IsNullOrEmpty(connectionString))
        {
            logger?.LogError($"Connection string '${connectionName}' is empty");
        }
        else
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
            var dataSource = dataSourceBuilder.Build();

            app.Services.AddDbContextPool<TestDbContext>(opt =>
                opt.UseNpgsql(dataSource, x => x.MigrationsHistoryTable("__ef_migrations_history"))
                    .UseSnakeCaseNamingConvention());
        }

        return app;
    }
}
