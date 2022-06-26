using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Quewer.Core.DataAccess;

namespace Quewer.BotClient.Tools;

public static class TestDatabaseProvider
{
    public static IServiceCollection AddQuewerDatabase(this IServiceCollection services)
    {
        return services
            .AddDbContext<QuewerDbContext>(o => o
                .UseLazyLoadingProxies()
                .UseInMemoryDatabase("Data Source=Quewer.db"));
    }
}
