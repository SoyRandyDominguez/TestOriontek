using System.Threading.Tasks;
using Abp.Application.Services;
using TestOriontec.Sessions.Dto;

namespace TestOriontec.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
