using System.Threading.Tasks;
using Abp.Application.Services;
using HomeMvc.Sessions.Dto;

namespace HomeMvc.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
