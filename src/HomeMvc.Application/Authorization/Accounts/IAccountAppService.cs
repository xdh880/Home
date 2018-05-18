using System.Threading.Tasks;
using Abp.Application.Services;
using HomeMvc.Authorization.Accounts.Dto;

namespace HomeMvc.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
