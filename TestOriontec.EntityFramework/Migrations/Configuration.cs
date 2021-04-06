using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using TestOriontec.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace TestOriontec.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<TestOriontec.EntityFramework.TestOriontecDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TestOriontec";
        }

        protected override void Seed(TestOriontec.EntityFramework.TestOriontecDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
