using System.Threading.Tasks;
using Griffin.Configuration.Dto;

namespace Griffin.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}