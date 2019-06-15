using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace mitsuasiamod.Items.Tiles
{
    public class Bonsai : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = false;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16 };
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 8;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(153, 102, 51));
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int item = 0;
            switch (frameX / 54)
            {
                case 0:
                    item = mod.ItemType("DynastyBonsai");
                    break;
            }
            if (item > 0)
            {
                Item.NewItem(i * 16, j * 16, 48, 48, item);
            }
        }
    }
}
