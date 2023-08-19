using BetterAutoReuse.Common.Configs;
using Terraria;
using Terraria.ModLoader;

namespace BetterAutoReuse.Common.GlobalItems
{
    public class BetterAutoReuse : GlobalItem
    {
        public override bool? CanAutoReuseItem(Item item, Player player)
        {
            if (ModContent.GetInstance<BetterAutoReuseConfig>().AutoReuseValue)
            {
                if (item.netID != 113 && item.netID != 218 && item.netID != 495)
                {
                    return true;
                }
            }
            return base.CanAutoReuseItem(item, player);
        }
    }
}