using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HomeMvc.Roles.Dto;
using HomeMvc.Users.Dto;

namespace HomeMvc.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
