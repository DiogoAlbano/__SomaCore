using StardewValley;
using System;

namespace __SomaCore.TileActions
{
    public class SetAction
    {
        public static string currentLocation;
        public static int X;
        public static int Y;

        internal static void WarpAndPlaySound(string[] checking)
        {
            currentLocation = Game1.currentLocation.Name;
            X = Game1.player.getTileX();
            Y = Game1.player.getTileY();
            Game1.playSound(checking[5]);
            Game1.warpFarmer(checking[3], Convert.ToInt32(checking[1]), Convert.ToInt32(checking[2]), flip: Convert.ToBoolean(checking[7]));
        }
    }
}
