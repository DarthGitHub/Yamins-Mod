using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Items
{
    public class leaflasher : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leaf Lasher");
            Tooltip.SetDefault("This is the leaf lasher, a powerful sword only wielded by those who are filled with pure courage...");
        }
        public override void SetDefaults()
        {
            item.damage = 45;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("leaflasherprojectile");
            item.shootSpeed = 10f;
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