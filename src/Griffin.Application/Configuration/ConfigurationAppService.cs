using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Griffin.Configuration.Dto;

namespace Griffin.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GriffinAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
