using System.ComponentModel;
using Terraria.ModLoader.Config;


namespace BetterAutoReuse.Common.Configs
{
    public class BetterAutoReuseConfig : ModConfig
    {
        public override ConfigScope Mode
        {
            get
            {
                return 0;
            }
        }
        [Header("Config")]
        [DefaultValue(true)]
        public bool AutoReuseValue;
    }
}