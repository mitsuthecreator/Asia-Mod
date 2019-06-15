using Terraria.ID;
using Terraria.ModLoader;

namespace mitsuasiamod.Items.Items
{
    public class DynastyBonsai : ModItem
    {
        public override void SetDefaults()
        {

            item.width = 34;
            item.height = 34;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useStyle = 1;
            item.rare = 1;
            item.consumable = true;
            item.value = 2000;
            item.placeStyle = 0;
            item.createTile = mod.TileType("Bonsai");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DynastyWood, 15);
            recipe.AddIngredient(ItemID.ClayPot, 1);
            recipe.SetResult(this);
            recipe.AddTile(17);
            recipe.AddRecipe();
        }
    }
}
