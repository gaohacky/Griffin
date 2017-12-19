using System.Threading.Tasks;
using Abp.Application.Services;
using Griffin.Sessions.Dto;

namespace Griffin.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
