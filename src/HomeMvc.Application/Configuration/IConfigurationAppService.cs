using System.Threading.Tasks;
using HomeMvc.Configuration.Dto;

namespace HomeMvc.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
