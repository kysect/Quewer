using System;

using Microsoft.EntityFrameworkCore;

using Quewer.Core.DataAccess;

namespace Quewer.Tests
{
    public class TestDatabaseProvider
    {
        public static QuewerDbContext GetDatabaseContext()
        {
            DbContextOptions<QuewerDbContext> options = new DbContextOptionsBuilder<QuewerDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .UseLazyLoadingProxies()
                .Options;

            var databaseContext = new QuewerDbContext(options);
            databaseContext.Database.EnsureCreated();

            return databaseContext;
        }
    }
}