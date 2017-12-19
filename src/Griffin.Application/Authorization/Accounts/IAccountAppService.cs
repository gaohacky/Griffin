using System.Threading.Tasks;
using Abp.Application.Services;
using Griffin.Authorization.Accounts.Dto;

namespace Griffin.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
