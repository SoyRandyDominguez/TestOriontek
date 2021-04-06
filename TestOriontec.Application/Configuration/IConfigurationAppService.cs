using System.Threading.Tasks;
using Abp.Application.Services;
using TestOriontec.Configuration.Dto;

namespace TestOriontec.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}