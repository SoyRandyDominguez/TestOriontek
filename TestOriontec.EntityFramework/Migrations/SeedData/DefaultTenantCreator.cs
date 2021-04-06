using System.Linq;
using TestOriontec.EntityFramework;
using TestOriontec.MultiTenancy;

namespace TestOriontec.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly TestOriontecDbContext _context;

        public DefaultTenantCreator(TestOriontecDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
