using Microsoft.Xna.Framework;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TestModSword.Items;

namespace TestModSword.Items.Sword
{
	public class SwordItemGlobalMod : GlobalItem
	{
        public override bool AppliesToEntity(Item item, bool lateInstantiation)
        {
            return item.type == ModContent.ItemType<DickSword>();
        }

        public override void UseStyle(Item item, Player player, Rectangle heldItemFrame)
        {
            WeaponOffsetPlayer modPlayer = player.GetModPlayer<WeaponOffsetPlayer>();
            modPlayer.SetItemLocationHand();

        }
    }
}