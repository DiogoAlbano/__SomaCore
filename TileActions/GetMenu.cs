using StardewValley.Menus;
using StardewValley;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using __SomaCore.Managers;
using StardewValley.BellsAndWhistles;
using StardewValley.GameData.HomeRenovations;

namespace __SomaCore.TileActions
{
    public class GetMenu
    {
        public static void PutPlayerOnMap(int x, int y, int width, int height, string nameToShow, string locationName)
        {
            MapPage mp = null;
            foreach (IClickableMenu page in ModEntry.ModHelper.Reflection.GetField<List<IClickableMenu>>(Game1.activeClickableMenu, "pages").GetValue())
            {
                if (page is not MapPage)
                    continue;
                mp = page as MapPage;
                break;
            }
            if (mp == null)
                return;
            int mapX = ModEntry.ModHelper.Reflection.GetField<int>(mp, "mapX").GetValue();
            int mapY = ModEntry.ModHelper.Reflection.GetField<int>(mp, "mapY").GetValue();
            Rectangle locationOnMap = new(mapX + x, mapY + y, width, height);
            mp.points.Add(new ClickableComponent(locationOnMap, nameToShow));
            foreach (ClickableComponent cc in mp.points)
            {
                if (cc.myID != 1030)
                    continue;

                cc.bounds.Width -= 64;
                break;
            }
            if (Game1.currentLocation == Game1.getLocationFromName(locationName))
            {
                ModEntry.ModHelper.Reflection.GetField<string>(mp, "playerLocationName").SetValue(nameToShow);
            }
        }
        public static IClickableMenu WhichMenu(string menu, out bool warpingShop)
        {
            warpingShop = false;
            switch (menu)
            {
                case "CarpenterMenu":
                    {
                        warpingShop = true;
                        return new CarpenterMenu();
                    }
            }
            return null;
        }
    }
}
