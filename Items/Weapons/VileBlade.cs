using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Items.Weapons
{
    public class vileblade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("VileBlade");
            Tooltip.SetDefault("The smaller version of the Leaf Lasher, the sword of legend...");
        }
        public override void SetDefaults()
        {
            item.damage = 20;
            item.melee = true;
            item.width = 20;
            item.height = 20;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 5000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
