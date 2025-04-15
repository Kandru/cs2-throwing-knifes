using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Extensions;
using System.Text.Json.Serialization;

namespace ThrowingKnifes
{
    public class PlayerPermissions
    {
        // amount knifes
        [JsonPropertyName("amount_knifes")] public int AmountKnifes { get; set; } = 2;
    }

    public class PluginConfig : BasePluginConfig
    {
        // Enabled or disabled
        [JsonPropertyName("enabled")] public bool Enabled { get; set; } = true;
        // debug prints
        [JsonPropertyName("debug")] public bool Debug { get; set; } = false;
        // allow only players with this permission(s) to have throwing knifes. Overrides definitions below
        [JsonPropertyName("permissions")] public Dictionary<string, PlayerPermissions> Permissions { get; set; } = new Dictionary<string, PlayerPermissions>();
        // whether or not only players with the permission can use throwing knifes
        [JsonPropertyName("permissions_is_whitelist")] public bool PermissionsIsWhitelist { get; set; } = false;
        // amount knifes
        [JsonPropertyName("amount_knifes")] public int AmountKnifes { get; set; } = 2;
    }

    public partial class ThrowingKnifes : BasePlugin, IPluginConfig<PluginConfig>
    {
        public required PluginConfig Config { get; set; }

        public void OnConfigParsed(PluginConfig config)
        {
            Config = config;
            // update config and write new values from plugin to config file if changed after update
            Config.Update();
            Console.WriteLine(Localizer["core.config"]);
        }
    }
}
