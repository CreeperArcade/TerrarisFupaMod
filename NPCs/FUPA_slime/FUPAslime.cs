using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using Terraria.GameContent.ItemDropRules;

namespace TestModSword.NPCs.FUPA_slime
{
    public class FUPAslime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("FUPA");
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[2];
        }

        public override void SetDefaults()
        {
            NPC.width = 51;
            NPC.height = 41;
            NPC.damage = 10;
            NPC.lifeMax = 20;
            NPC.defense = 3;
            NPC.value = 50f;
            NPC.aiStyle = 1;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            AIType = NPCID.GreenSlime;
            AnimationType = NPCID.GreenSlime;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.75f; 
        }

        public override void FindFrame(int frameHeight)
        {
            NPC.frameCounter++;
            if(NPC.frameCounter >= 20)
            {
                NPC.frameCounter = 0;
            }
            NPC.frame.Y = (int)NPC.frameCounter / 10 * frameHeight;
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ItemID.Zenith, 1, 1, 5));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.ForFUPAboss.FUPAbossSummon>(), 1, 1));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.Sword.DickSword>(), 5));
        }
    }
}
