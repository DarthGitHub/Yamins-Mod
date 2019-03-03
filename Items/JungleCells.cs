using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Items
{
    public class JungleCells : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jungle Cells");
            Tooltip.SetDefault("Bring this to the jungle crafting table and have some fun");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("YaxilMod:JungleCells", 1);
			recipe.AddTile(ItemID.WorkBench);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(YaxilMod, "JungleCells", 1);
			recipe.AddTile(mod.TileType("YaxilWorkBench"));
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
        }
    }
}