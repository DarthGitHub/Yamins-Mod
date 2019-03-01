using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Items
{
    public class YaxilWorkBench : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yaxil Work Bench");
            Tooltip.SetDefault("A work bench crafted with the rarest of furs");
        }
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 14;
            item.maxStack = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 150;
            item.createTile = mod.TileType("YaxilWorkBenchTile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
