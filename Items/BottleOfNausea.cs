using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Items
{
    public class BottleOfNausea : ModItem
    {
        public override void SetStaticDefaults() {

             DisplayName.SetDefault("Bottle Of Nausea");
            Tooltip.SetDefault("A deadly poison, one drop of it could kill 100 fully grown men...");
        }

        public override void SetDefaults() {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 100;
            item.rare = 1;
        }
public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("BottleOfNausea"));
            recipe.AddTile(ItemID.WorkBench);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("BottleOfNausea"));
            recipe.AddTile(mod.TileType("YaxilWorkBench"));
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
      
     }
    }
}
