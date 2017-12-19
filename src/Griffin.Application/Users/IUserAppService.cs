using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Griffin.Roles.Dto;
using Griffin.Users.Dto;

namespace Griffin.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}