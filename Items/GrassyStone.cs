using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Items
{
    public class GrassyStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A special stone, only the bravest can find them...");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
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
            recipe.AddIngredient(mod.ItemType("GrassyStone"));
            recipe.AddTile(ItemID.WorkBench);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("GrassyStone"));
            recipe.AddTile(mod.TileType("YaxilWorkBench"));
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
          
    }
    }

