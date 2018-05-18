using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HomeMvc.MultiTenancy.Dto;

namespace HomeMvc.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
