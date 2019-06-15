using Terraria.ID;
using Terraria.ModLoader;

namespace mitsuasiamod.Items.Weaponry
{
	public class HookSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hook Sword");
			Tooltip.SetDefault("Deadly in the right hands.");
		}
		public override void SetDefaults()
		{
			item.damage = 24;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 14000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 14);
            recipe.AddIngredient(ItemID.Meteorite, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
