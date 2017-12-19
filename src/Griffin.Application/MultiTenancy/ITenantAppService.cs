using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Griffin.MultiTenancy.Dto;

namespace Griffin.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
