using StardewModdingAPI;
using HarmonyLib;
using __SomaCore.TileSheets;
using __SomaCore.TileProperties;
using StardewValley;
using __SomaCore.Flags;
using __SomaCore.ModConfigs;

namespace __SomaCore
{
    public class ModEntry : Mod
    {
        internal static IModHelper ModHelper;
        internal static IMonitor ModMonitor;
        internal static IManifest Manifest;
        internal static ModConfig Config = new();
        internal static Harmony harmony;
        internal static SetGMCMMenu setGMCM = new();
        internal static TileSheetManager tileSheets = new();
        internal static TilePropertiesManager tileProperties = new();
        internal static FlagsManager flags = new();

        public override void Entry(IModHelper helper)
        {
            ModHelper = helper;
            ModMonitor = Monitor;
            harmony = new(helper.ModRegistry.ModID);

            helper.Events.GameLoop.GameLaunched += setGMCM.OnGameLaunched_InicializeGMCM;

            helper.Events.Content.AssetRequested += tileSheets.OnAssetRequested_ConfigPlantsTilesheets;
            helper.Events.Content.AssetRequested += tileSheets.OnAssetRequested_ConfigInteriorsTilesheets;
            helper.Events.GameLoop.DayStarted += tileSheets.OnDayStarted_ReloadTilesheets;

            helper.Events.Input.ButtonPressed += tileProperties.OnButtonPressed_CheckTileProperty;
            helper.Events.GameLoop.UpdateTicking += tileProperties.OnUpdateTicking_CheckLocationRequested;
            helper.Events.Display.MenuChanged += tileProperties.OnDisplayMenuChanged_RemoveShopOwnerPortrait;

            helper.Events.Content.AssetRequested += flags.OnAssetRequested_CreateFlags;
            helper.Events.GameLoop.DayStarted += flags.OnDayStarted_SetFlagsAndEvents;

            helper.ConsoleCommands.Add("test", "teleport", WarpTestRoom);
            helper.ConsoleCommands.Add("npc", "teleport", WarpNPCRoom);
            helper.ConsoleCommands.Add("house", "teleport", WarpFarmHouse);
        }
        public static void WarpTestRoom(string command, string[] args)
        {
            Game1.warpFarmer("Custom_nmtestroom", 1, 1, false);
            ModMonitor.Log("Warp to Custom_nmtestroom", LogLevel.Info);
        }
        public static void WarpNPCRoom(string command, string[] args)
        {
            Game1.warpFarmer("Custom_nmnpcroom", 8, 8, false);
            ModMonitor.Log("Warp to Custom_nmtestroom", LogLevel.Info);
        }
        public static void WarpFarmHouse(string command, string[] args)
        {
            Game1.warpFarmer("FarmHouse", 3, 9, false);
            ModMonitor.Log("Warp to FarmHouse", LogLevel.Info);
        }
    }
    
}
