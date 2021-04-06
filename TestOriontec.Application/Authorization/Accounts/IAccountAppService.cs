using System.Threading.Tasks;
using Abp.Application.Services;
using TestOriontec.Authorization.Accounts.Dto;

namespace TestOriontec.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
