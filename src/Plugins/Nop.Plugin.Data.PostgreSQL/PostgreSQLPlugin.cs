using Nop.Core.Plugins;
using Nop.Data;

namespace Nop.Plugin.Data.PostgreSQL
{
    /// <summary>
    /// PLugin
    /// </summary>
    public class PostgreSQLPlugin : BasePlugin, IDbPlugin
    {
        /// <summary>
        /// Gets a configuration page URL
        /// </summary>
        public override string GetConfigurationPageUrl()
        {
            return string.Empty;
            //return _webHelper.GetStoreLocation() + "Admin/WidgetsNivoSlider/Configure";
        }

        public string DbProvider()
        {
            return "~/Plugins/Data.PostgreSQL/Views/_DbProvider.cshtml";
        }

        public string DbConnectionInfo()
        {
            return "~/Plugins/Data.PostgreSQL/Views/_DbConnectionInfo.cshtml";
        }
    }
}