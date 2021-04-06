using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using TestOriontec.EntityFramework;

namespace TestOriontec
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(TestOriontecCoreModule))]
    public class TestOriontecDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TestOriontecDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
