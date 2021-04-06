using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TestOriontec.MultiTenancy.Dto;

namespace TestOriontec.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
