using Terraria;
using Terraria.ModLoader;

namespace mitsuasiamod.Items.Weaponry
{
    public class GuanBao : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(507);

            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = 1;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.aiStyle = 1;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Guan Bao");
        }
    }
}