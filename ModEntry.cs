using StardewModdingAPI;
using HarmonyLib;
using StardewValley;
using __SomaCore.Managers;

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
        internal static TileSheetManager tileSheetsManager = new();
        internal static FlagsManager flagsManager = new();
        internal static TilePropertyManager tilePropertyManager = new();

        public override void Entry(IModHelper helper)
        {
            ModHelper = helper;
            ModMonitor = Monitor;
            harmony = new(helper.ModRegistry.ModID);

            helper.Events.GameLoop.GameLaunched += setGMCM.OnGameLaunched_InicializeGMCM;

            helper.Events.Content.AssetRequested += tileSheetsManager.OnAssetRequested_ConfigPlantsTilesheets;
            helper.Events.Content.AssetRequested += tileSheetsManager.OnAssetRequested_ConfigInteriorsTilesheets;
            helper.Events.GameLoop.DayStarted += tileSheetsManager.OnDayStarted_ReloadTilesheets;

            helper.Events.Content.AssetRequested += flagsManager.OnAssetRequested_CreateFlags;
            helper.Events.GameLoop.DayStarted += flagsManager.OnDayStarted_SetFlagsAndEvents;

            helper.Events.Input.ButtonPressed += tilePropertyManager.OnButtonPressed_CheckTileProperty;
            helper.Events.GameLoop.UpdateTicking += tilePropertyManager.OnUpdateTicking_CheckLocationRequested;
            helper.Events.Display.MenuChanged += tilePropertyManager.OnDisplayMenuChanged_RemoveShopOwnerPortrait;

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
