using TestOriontec.EntityFramework;
using EntityFramework.DynamicFilters;

namespace TestOriontec.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TestOriontecDbContext _context;

        public InitialHostDbBuilder(TestOriontecDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
