using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Items
{
    public class grassystone : ModItem
    {
        public override void SetStaticDefaults() {
            Tooltip.SetDefault("A special stone, only the bravest can find them...");
        }

        public override void SetDefaults() {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 100;
            item.rare = 1;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.SetResult(this, 999);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("ExampleMod:ExampleItem");
            recipe.SetResult(this, 999);
            recipe.AddRecipe();
                   }
    }
}
