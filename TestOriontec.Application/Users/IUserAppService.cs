using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TestOriontec.Roles.Dto;
using TestOriontec.Users.Dto;

namespace TestOriontec.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}