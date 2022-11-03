using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestModSword.Items.Sword
{
    public class WeaponOffsetPlayer : ModPlayer
    {
        public void SetItemLocationHand()
        {
            Item heldItem = Player.HeldItem;
            var originLocation = new Vector2(Player.position.X + ((Player.getRect().Width / 3) * 2) + 1, Player.position.Y + ((Player.getRect().Height / 5) * 2) + 1.5f);
            Player.itemLocation = originLocation;
        }
    }
}
