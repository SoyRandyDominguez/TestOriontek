using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TestOriontec.EntityFramework;

namespace TestOriontec.Migrator
{
    [DependsOn(typeof(TestOriontecDataModule))]
    public class TestOriontecMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TestOriontecDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}