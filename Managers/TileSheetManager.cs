using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace __SomaCore.Managers
{
    public class TileSheetManager
    {
        internal void OnAssetRequested_ConfigDinamicCropsTilesheets(object sender, AssetRequestedEventArgs e)
        {
            if (e.NameWithoutLocale.IsEquivalentTo("Maps/_sc_dinamic_crops"))
            {
                e.Edit(asset =>
                {
                    var editor = asset.AsImage();
                    Texture2D source;
                    if (Game1.currentSeason.Equals("spring"))
                    {
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                        editor.PatchImage(source, sourceArea: new Rectangle(112, 512, 48, 64), targetArea: new Rectangle(208, 0, 48, 64), patchMode: PatchMode.Replace);
                        // Parsnip stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 0, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Parsnip stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 22)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 0, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Parsnip stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 0, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Parsnip stage 4
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 0, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Parsnip harvest
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 0, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Parsnip no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(0, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(0, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Green Bean stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 0, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Green Bean stage 2
                        if (Game1.dayOfMonth == 2)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 0, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Green Bean stage 3
                        if (Game1.dayOfMonth == 3)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 0, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Green Bean stage 4
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 0, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Green Bean stage 5
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 0, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Green Bean harvest
                        if (Game1.dayOfMonth == 11 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 26)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 0, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Green Bean regrowing
                        if (Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(240, 0, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Green Bean no crop
                        if (Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(16, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(16, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Cauliflower stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 32, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cauliflower stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 32, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cauliflower stage 3
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 32, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cauliflower stage 4
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 32, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cauliflower stage 5
                        if (Game1.dayOfMonth == 12 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 32, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cauliflower harvest
                        if (Game1.dayOfMonth == 13 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 32, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cauliflower no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(32, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(32, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Potato stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 32, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Potato stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 20)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 32, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Potato stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 21)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 32, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Potato stage 4
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 32, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Potato stage 5
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 32, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Potato harvest
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 32, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Potato no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(48, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(48, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Garlic stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 64, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Garlic stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 22)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 64, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Garlic stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 64, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Garlic stage 4
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 64, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Garlic harvest
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 64, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Garlic no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(64, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(64, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Kale stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 64, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Kale stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 64, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Kale stage 3
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 64, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Kale stage 4
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 64, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Kale harvest
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 64, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Kale no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(80, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(80, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Rhubarb stage 1
                        if (Game1.dayOfMonth == 1 || Game1.dayOfMonth == 2 || Game1.dayOfMonth == 15)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 96, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Rhubarb stage 2
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 96, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Rhubarb stage 3
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 96, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Rhubarb stage 4
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 96, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Rhubarb stage 5
                        if (Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 96, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Rhubarb harvest
                        if (Game1.dayOfMonth == 14 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 96, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Rhubarb no crop
                        if (Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(96, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(96, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Unmilled Rice stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 544, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Unmilled Rice stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 544, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Unmilled Rice stage 3
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 544, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Unmilled Rice stage 4
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 544, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Unmilled Rice harvest
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 544, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Unmilled Rice no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(112, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(112, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Coffee Bean stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 640, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Coffee Bean stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 640, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Coffee Bean stage 3
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 640, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Coffee Bean stage 4
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 640, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Coffee Bean stage 5
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 640, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Coffee Bean harvest
                        if (Game1.dayOfMonth == 11 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 640, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Coffee Bean regrowing
                        if (Game1.dayOfMonth == 12 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(112, 640, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 576, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 2
                        if (Game1.dayOfMonth == 2)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 576, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 576, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 4
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 576, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 5
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 576, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry harvest
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 576, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry regrowing
                        if (Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(112, 576, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(144, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(144, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 2
                        if (Game1.dayOfMonth == 2)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 4
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 5
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry harvest
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry regrowing
                        if (Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(112, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Rice no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(160, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(160, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 576, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 2
                        if (Game1.dayOfMonth == 2)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 576, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 576, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 4
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 576, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 5
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 576, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry harvest
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 576, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry regrowing
                        if (Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(112, 576, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Rice no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(176, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(176, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 576, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 2
                        if (Game1.dayOfMonth == 2)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 576, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 576, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 4
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 576, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Bean stage 5
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 576, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry harvest
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 576, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry regrowing
                        if (Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(112, 576, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Strawberry Rice no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(192, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(192, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                    }
                    if (Game1.currentSeason.Equals("summer"))
                    {
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                        editor.PatchImage(source, sourceArea: new Rectangle(160, 512, 48, 64), targetArea: new Rectangle(208, 0, 48, 64), patchMode: PatchMode.Replace);
                        // Melon stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 96, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Melon stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 96, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Melon stage 3
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 96, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Melon stage 4
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 96, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Melon stage 5
                        if (Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 96, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Melon harvest
                        if (Game1.dayOfMonth == 13 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 96, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Melon no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(0, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(0, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Tomato stage 1
                        if (Game1.dayOfMonth == 1 || Game1.dayOfMonth == 2)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 128, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Tomato stage 2
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 128, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Tomato stage 3
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 128, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Tomato stage 4
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 128, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Tomato stage 5
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 128, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Tomato harvest
                        if (Game1.dayOfMonth == 12 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 128, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Tomato regrowing
                        if (Game1.dayOfMonth == 13 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(112, 128, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Blueberry stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 128, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Blueberry stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 128, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Blueberry stage 3
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 128, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Blueberry stage 4
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 128, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Blueberry stage 5
                        if (Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 128, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Blueberry harvest
                        if (Game1.dayOfMonth == 14 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 26)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 128, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Blueberry regrowing
                        if (Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(240, 128, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Blueberry no crop
                        if (Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(32, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(32, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Hot Pepper stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 160, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hot Pepper stage 2
                        if (Game1.dayOfMonth == 2)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 160, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hot Pepper stage 3
                        if (Game1.dayOfMonth == 3)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 160, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hot Pepper stage 4
                        if (Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 160, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hot Pepper stage 5
                        if (Game1.dayOfMonth == 5)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 160, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hot Pepper harvest
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 160, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hot Pepper regrowing
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(112, 160, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hot Pepper no crop
                        if (Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(48, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(48, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Wheat stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 160, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Wheat stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 26)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 160, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Wheat stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 160, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Wheat stage 4
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 160, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Wheat harvest
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 160, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Radish stage 1
                        if (Game1.dayOfMonth == 1 || Game1.dayOfMonth == 2 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 20)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 192, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Radish stage 2
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 21)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 192, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Radish stage 3
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 192, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Radish stage 4
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 192, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Radish harvest
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 192, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Radish no crop
                        if (Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(80, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(80, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Red Cabbage stage 1
                        if (Game1.dayOfMonth == 1 || Game1.dayOfMonth == 2 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 20)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 192, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Red Cabbage stage 2
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 21)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 192, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Red Cabbage stage 3
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 192, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Red Cabbage stage 4
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 192, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Red Cabbage stage 5
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 192, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Red Cabbage harvest
                        if (Game1.dayOfMonth == 10 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 192, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Starfruit stage 1
                        if (Game1.dayOfMonth == 1 || Game1.dayOfMonth == 2 || Game1.dayOfMonth == 15)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 224, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Starfruit stage 2
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 224, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Starfruit stage 3
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 224, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Starfruit stage 4
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 224, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Starfruit stage 5
                        if (Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 224, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Starfruit harvest
                        if (Game1.dayOfMonth == 14 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 224, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Starfruit no crop
                        if (Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(112, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(112, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Coffee Bean harvest
                        if (Game1.dayOfMonth == 1 || Game1.dayOfMonth == 3 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 640, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Coffee Bean regrowing
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 4 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(112, 640, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Corn stage 1
                        if (Game1.dayOfMonth == 1 || Game1.dayOfMonth == 2)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 224, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Corn stage 2
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 224, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Corn stage 3
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 224, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Corn stage 4
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 224, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Corn stage 5
                        if (Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 14)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 224, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Corn harvest
                        if (Game1.dayOfMonth == 15 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 224, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Corn regrowing
                        if (Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(240, 224, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hops stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hops stage 2
                        if (Game1.dayOfMonth == 2)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hops stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hops stage 4
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hops stage 5
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Hops harvest
                        if (Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 576, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Sunflower stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 480, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Sunflower stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 480, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Sunflower stage 3
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 480, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Sunflower stage 4
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 480, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Sunflower harvest
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 480, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pineaple stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 672, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pineaple stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 672, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pineaple stage 3
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 672, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pineaple stage 4
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 672, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pineaple stage 5
                        if (Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 14)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 672, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pineaple harvest
                        if (Game1.dayOfMonth == 15 || Game1.dayOfMonth == 22)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 672, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pineaple regrowing
                        if (Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(240, 672, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Blueberry no crop
                        if (Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(192, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(192, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                    }
                    if (Game1.currentSeason.Equals("fall"))
                    {
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                        editor.PatchImage(source, sourceArea: new Rectangle(208, 512, 48, 64), targetArea: new Rectangle(208, 0, 48, 64), patchMode: PatchMode.Replace);
                        // Eggplant stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 256, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Eggplant stage 2
                        if (Game1.dayOfMonth == 2)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 256, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Eggplant stage 3
                        if (Game1.dayOfMonth == 3)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 256, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Eggplant stage 4
                        if (Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 256, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Eggplant stage 5
                        if (Game1.dayOfMonth == 5)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 256, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Eggplant harvest
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 26)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 256, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Eggplant regrowing
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(112, 256, 16, 32), targetArea: new Rectangle(0, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Eggplant no crop
                        if (Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(0, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(0, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Artichoke stage 1
                        if (Game1.dayOfMonth == 1 || Game1.dayOfMonth == 2 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 18)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 256, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Artichoke stage 2
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 256, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Artichoke stage 3
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 21)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 256, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Artichoke stage 4
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 256, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Artichoke stage 5
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 256, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Artichoke harvest
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 256, 16, 32), targetArea: new Rectangle(16, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Artichoke no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(16, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(16, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Pumpkin stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 288, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pumpkin stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 288, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pumpkin stage 3
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 288, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pumpkin stage 4
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 288, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pumpkin stage 5
                        if (Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 288, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pumpkin harvest
                        if (Game1.dayOfMonth == 14 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 288, 16, 32), targetArea: new Rectangle(32, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pumpkin no crop
                        if (Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(32, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(32, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Bok Choy stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 288, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Bok Choy stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 22)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 288, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Bok Choy stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 288, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Bok Choy stage 4
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 288, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Bok Choy harvest
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 288, 16, 32), targetArea: new Rectangle(48, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Pumpkin no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(48, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(48, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Wheat stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 22)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 160, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Wheat stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 23)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 160, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Wheat stage 4
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 160, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Wheat harvest
                        if (Game1.dayOfMonth == 1 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 160, 16, 32), targetArea: new Rectangle(64, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Wheat no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(64, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(64, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Yam stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 320, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Yam stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 14)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 320, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Yam stage 3
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 320, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Yam stage 4
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 320, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Yam harvest
                        if (Game1.dayOfMonth == 11 || Game1.dayOfMonth == 21)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 320, 16, 32), targetArea: new Rectangle(80, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Yam no crop
                        if (Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(80, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(80, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Cranberries stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 320, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 320, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries stage 3
                        if (Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 320, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries stage 4
                        if (Game1.dayOfMonth == 5)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 320, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries stage 5
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 320, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries harvest
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 320, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries regrowing
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(240, 320, 16, 32), targetArea: new Rectangle(96, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Beet stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 352, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Beet stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 20)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 352, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Beet stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 352, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Beet stage 4
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 352, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Beet harvest
                        if (Game1.dayOfMonth == 7 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 352, 16, 32), targetArea: new Rectangle(112, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Beet no crop
                        if (Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(112, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(112, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Cranberries stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 320, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 320, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries stage 3
                        if (Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 320, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries stage 4
                        if (Game1.dayOfMonth == 5)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 320, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries stage 5
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 320, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries harvest
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 320, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Cranberries regrowing
                        if (Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(240, 320, 16, 32), targetArea: new Rectangle(128, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Corn harvest
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 27)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(224, 224, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Corn regrowing
                        if (Game1.dayOfMonth == 1 || Game1.dayOfMonth == 2 || Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(240, 224, 16, 32), targetArea: new Rectangle(144, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Corn no crop
                        if (Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(144, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(144, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Grape Berry stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(16, 608, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Grape Berry stage 2
                        if (Game1.dayOfMonth == 2)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 608, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Grape Berry stage 3
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 608, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Grape Berry stage 4
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 608, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Grape Berry stage 5
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 608, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Grape Berry harvest
                        if (Game1.dayOfMonth == 11 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 26)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(96, 608, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Grape Berry regrowing
                        if (Game1.dayOfMonth == 12 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 21 || Game1.dayOfMonth == 22 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(112, 608, 16, 32), targetArea: new Rectangle(160, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Grape Berry no crop
                        if (Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(160, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(160, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Sunflower stage 2
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 15)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 480, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Sunflower stage 3
                        if (Game1.dayOfMonth == 1 || Game1.dayOfMonth == 2 || Game1.dayOfMonth == 8 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17 || Game1.dayOfMonth == 18)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(48, 480, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Sunflower stage 4
                        if (Game1.dayOfMonth == 3 || Game1.dayOfMonth == 4 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 19 || Game1.dayOfMonth == 20)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(64, 480, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Sunflower harvest
                        if (Game1.dayOfMonth == 5 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 21)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(80, 480, 16, 32), targetArea: new Rectangle(176, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Sunflower no crop
                        if (Game1.dayOfMonth == 22 || Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(176, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(176, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                        // Amaranth stage 1
                        if (Game1.dayOfMonth == 1)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(144, 608, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Amaranth stage 2
                        if (Game1.dayOfMonth == 2 || Game1.dayOfMonth == 3 || Game1.dayOfMonth == 9 || Game1.dayOfMonth == 10 || Game1.dayOfMonth == 16 || Game1.dayOfMonth == 17)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(160, 608, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Amaranth stage 3
                        if (Game1.dayOfMonth == 4 || Game1.dayOfMonth == 5 || Game1.dayOfMonth == 11 || Game1.dayOfMonth == 12 || Game1.dayOfMonth == 18 || Game1.dayOfMonth == 19)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(176, 608, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Amaranth stage 4
                        if (Game1.dayOfMonth == 6 || Game1.dayOfMonth == 7 || Game1.dayOfMonth == 13 || Game1.dayOfMonth == 14 || Game1.dayOfMonth == 20 || Game1.dayOfMonth == 21)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(192, 608, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Amaranth harvest
                        if (Game1.dayOfMonth == 8 || Game1.dayOfMonth == 15 || Game1.dayOfMonth == 22)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/crops");//TerrainFeatures/Flooring
                            editor.PatchImage(source, sourceArea: new Rectangle(208, 608, 16, 32), targetArea: new Rectangle(192, 0, 16, 32), patchMode: PatchMode.Replace);
                        }
                        // Amaranth Berry no crop
                        if (Game1.dayOfMonth == 23 || Game1.dayOfMonth == 24 || Game1.dayOfMonth == 25 || Game1.dayOfMonth == 26 || Game1.dayOfMonth == 27 || Game1.dayOfMonth == 28)
                        {
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring");
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(192, 0, 16, 16), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(192, 16, 16, 16), patchMode: PatchMode.Replace);
                        }
                    }
                    if (Game1.currentSeason.Equals("winter"))
                    {
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/Flooring_winter");
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(0, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(0, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(16, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(16, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(32, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(32, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(48, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(48, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(64, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(64, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(80, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(80, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(96, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(96, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(112, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(112, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(128, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(128, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(144, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(144, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(160, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(160, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(176, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(176, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 192, 16, 16), targetArea: new Rectangle(192, 0, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(128, 64, 16, 16), targetArea: new Rectangle(192, 16, 16, 16), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(144, 64, 48, 64), targetArea: new Rectangle(208, 0, 48, 64), patchMode: PatchMode.Replace);
                        // Static Fruit Trees
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/fruitTrees");
                        editor.PatchImage(source, sourceArea: new Rectangle(336, 0, 48, 720), targetArea: new Rectangle(0, 96, 48, 720), patchMode: PatchMode.Replace);
                        //Static Tree 1
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("Maps/_sc_blank_tilesheet");
                        editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(48, 96, 48, 96), patchMode: PatchMode.Replace);
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/tree1_winter");
                        editor.PatchImage(source, sourceArea: new Rectangle(32, 96, 16, 32), targetArea: new Rectangle(64, 160, 16, 32), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(48, 96, 48, 96), patchMode: PatchMode.Overlay);
                        //Static Tree 2
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("Maps/_sc_blank_tilesheet");
                        editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(48, 192, 48, 96), patchMode: PatchMode.Replace);
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/tree2_winter");
                        editor.PatchImage(source, sourceArea: new Rectangle(32, 96, 16, 32), targetArea: new Rectangle(64, 256, 16, 32), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(48, 192, 48, 96), patchMode: PatchMode.Overlay);
                        //Static Tree 3
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("Maps/_sc_blank_tilesheet");
                        editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(48, 288, 48, 96), patchMode: PatchMode.Replace);
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/tree3_winter");
                        editor.PatchImage(source, sourceArea: new Rectangle(32, 96, 16, 32), targetArea: new Rectangle(64, 352, 16, 32), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(48, 288, 48, 96), patchMode: PatchMode.Overlay);
                        //Static Tree 8
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("Maps/_sc_blank_tilesheet");
                        editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(48, 384, 48, 96), patchMode: PatchMode.Replace);
                        source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/tree8_winter");
                        editor.PatchImage(source, sourceArea: new Rectangle(32, 96, 16, 32), targetArea: new Rectangle(64, 448, 16, 32), patchMode: PatchMode.Replace);
                        editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(48, 384, 48, 96), patchMode: PatchMode.Overlay);
                        //Dinamic Trees
                        if (Utility.doesAnyFarmerHaveMail("nmTreeGrowCounter_4"))
                        {
                            // Fruit Trees
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/fruitTrees");
                            editor.PatchImage(source, sourceArea: new Rectangle(336, 0, 48, 720), targetArea: new Rectangle(144, 96, 48, 720), patchMode: PatchMode.Replace);
                            //Tree 1 
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("Maps/_sc_blank_tilesheet");
                            editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(192, 96, 48, 96), patchMode: PatchMode.Replace);
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/tree1_winter");
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 96, 16, 32), targetArea: new Rectangle(208, 160, 16, 32), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(192, 96, 48, 96), patchMode: PatchMode.Overlay);
                            //Tree2
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("Maps/_sc_blank_tilesheet");
                            editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(192, 192, 48, 96), patchMode: PatchMode.Replace);
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/tree2_winter");
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 96, 16, 32), targetArea: new Rectangle(208, 256, 16, 32), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(192, 192, 48, 96), patchMode: PatchMode.Overlay);
                            //Tree 3
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("Maps/_sc_blank_tilesheet");
                            editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(192, 288, 48, 96), patchMode: PatchMode.Replace);
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/tree3_winter");
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 96, 16, 32), targetArea: new Rectangle(208, 352, 16, 32), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(192, 288, 48, 96), patchMode: PatchMode.Overlay);
                            //Tree 8
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("Maps/_sc_blank_tilesheet");
                            editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(192, 384, 48, 96), patchMode: PatchMode.Replace);
                            source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TerrainFeatures/tree8_winter");
                            editor.PatchImage(source, sourceArea: new Rectangle(32, 96, 16, 32), targetArea: new Rectangle(208, 448, 16, 32), patchMode: PatchMode.Replace);
                            editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 48, 96), targetArea: new Rectangle(192, 384, 48, 96), patchMode: PatchMode.Overlay);
                        }
                    }
                });
            }
        }
        internal void OnAssetRequested_ConfigDinamicInteriorsTilesheets(object sender, AssetRequestedEventArgs e)
        {
            if (e.NameWithoutLocale.IsEquivalentTo("Maps/_sc_dinamic_interiors"))
            {
                e.Edit(asset =>
                {
                    var editor = asset.AsImage();
                    Texture2D source;
                    source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/furniture");
                    //sitter
                    editor.PatchImage(source, sourceArea: new Rectangle(144, 64, 32, 32), targetArea: new Rectangle(256, 0, 32, 32), patchMode: PatchMode.Replace);
                    //chairs
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 256, 32), targetArea: new Rectangle(0, 0, 256, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(256, 0, 256, 32), targetArea: new Rectangle(0, 32, 256, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 32, 256, 32), targetArea: new Rectangle(0, 64, 256, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(256, 32, 256, 32), targetArea: new Rectangle(0, 96, 256, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 64, 144, 32), targetArea: new Rectangle(0, 128, 144, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 64, 144, 32), targetArea: new Rectangle(0, 128, 144, 32), patchMode: PatchMode.Replace);
                    //Small tables
                    editor.PatchImage(source, sourceArea: new Rectangle(240, 688, 112, 32), targetArea: new Rectangle(144, 128, 112, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(352, 688, 64, 32), targetArea: new Rectangle(0, 160, 64, 32), patchMode: PatchMode.Replace);
                    //Medium tables
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 608, 192, 32), targetArea: new Rectangle(64, 160, 192, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 560, 256, 48), targetArea: new Rectangle(0, 192, 256, 48), patchMode: PatchMode.Replace);
                    //Dressers
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 352, 240, 48), targetArea: new Rectangle(0, 240, 240, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(240, 352, 176, 48), targetArea: new Rectangle(0, 288, 176, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 352, 240, 48), targetArea: new Rectangle(0, 240, 240, 48), patchMode: PatchMode.Replace);
                    //Pillars
                    editor.PatchImage(source, sourceArea: new Rectangle(176, 640, 16, 48), targetArea: new Rectangle(240, 240, 16, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(192, 640, 32, 48), targetArea: new Rectangle(176, 288, 32, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(240, 640, 16, 48), targetArea: new Rectangle(208, 288, 16, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(496, 672, 16, 48), targetArea: new Rectangle(224, 288, 16, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(496, 720, 16, 48), targetArea: new Rectangle(240, 288, 16, 48), patchMode: PatchMode.Replace);
                    //Wall decorations
                    //1
                    editor.PatchImage(source, sourceArea: new Rectangle(48, 768, 96, 32), targetArea: new Rectangle(0, 339, 96, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(144, 768, 32, 32), targetArea: new Rectangle(97, 339, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(176, 768, 48, 32), targetArea: new Rectangle(128, 339, 48, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(224, 768, 64, 32), targetArea: new Rectangle(176, 340, 64, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(496, 768, 16, 32), targetArea: new Rectangle(240, 340, 16, 32), patchMode: PatchMode.Replace);
                    //2
                    editor.PatchImage(source, sourceArea: new Rectangle(288, 768, 48, 32), targetArea: new Rectangle(0, 388, 48, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 768, 32, 32), targetArea: new Rectangle(48, 389, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(368, 768, 32, 32), targetArea: new Rectangle(80, 386, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(400, 768, 64, 32), targetArea: new Rectangle(112, 389, 64, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(464, 768, 32, 32), targetArea: new Rectangle(176, 387, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 800, 16, 32), targetArea: new Rectangle(208, 384, 16, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(16, 800, 16, 32), targetArea: new Rectangle(224, 382, 16, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(16, 800, 16, 32), targetArea: new Rectangle(240, 386, 16, 32), patchMode: PatchMode.Replace);
                    //3
                    editor.PatchImage(source, sourceArea: new Rectangle(48, 800, 16, 32), targetArea: new Rectangle(0, 426, 16, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(64, 800, 16, 32), targetArea: new Rectangle(16, 430, 16, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(80, 800, 16, 32), targetArea: new Rectangle(31, 434, 16, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(96, 800, 16, 32), targetArea: new Rectangle(48, 435, 16, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(112, 800, 32, 32), targetArea: new Rectangle(64, 437, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(144, 800, 80, 32), targetArea: new Rectangle(96, 435, 80, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(176, 832, 16, 32), targetArea: new Rectangle(176, 434, 16, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(192, 832, 32, 32), targetArea: new Rectangle(192, 433, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(368, 832, 32, 32), targetArea: new Rectangle(224, 434, 32, 32), patchMode: PatchMode.Replace);
                    //4
                    editor.PatchImage(source, sourceArea: new Rectangle(320, 832, 16, 32), targetArea: new Rectangle(0, 483, 16, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(448, 832, 32, 32), targetArea: new Rectangle(16, 480, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(272, 864, 32, 16), targetArea: new Rectangle(48, 486, 32, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(304, 896, 16, 16), targetArea: new Rectangle(80, 484, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(320, 896, 32, 16), targetArea: new Rectangle(96, 485, 32, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(352, 896, 16, 16), targetArea: new Rectangle(128, 486, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(400, 864, 32, 32), targetArea: new Rectangle(144, 484, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(400, 896, 80, 16), targetArea: new Rectangle(176, 483, 80, 16), patchMode: PatchMode.Replace);
                    //5
                    editor.PatchImage(source, sourceArea: new Rectangle(160, 896, 32, 32), targetArea: new Rectangle(0, 530, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(224, 912, 224, 32), targetArea: new Rectangle(32, 528, 224, 32), patchMode: PatchMode.Replace);
                    //6
                    editor.PatchImage(source, sourceArea: new Rectangle(448, 912, 64, 32), targetArea: new Rectangle(0, 576, 64, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 976, 128, 32), targetArea: new Rectangle(64, 576, 128, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(128, 976, 32, 32), targetArea: new Rectangle(192, 582, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(192, 944, 32, 32), targetArea: new Rectangle(224, 576, 32, 32), patchMode: PatchMode.Replace);
                    //7
                    editor.PatchImage(source, sourceArea: new Rectangle(304, 944, 32, 32), targetArea: new Rectangle(0, 628, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(416, 944, 48, 32), targetArea: new Rectangle(32, 629, 48, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(464, 944, 32, 32), targetArea: new Rectangle(80, 629, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 976, 16, 48), targetArea: new Rectangle(112, 627, 16, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(352, 976, 16, 48), targetArea: new Rectangle(128, 627, 16, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(400, 1152, 32, 32), targetArea: new Rectangle(144, 630, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(480, 1152, 32, 32), targetArea: new Rectangle(176, 630, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(400, 1184, 32, 16), targetArea: new Rectangle(208, 630, 32, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(288, 1200, 16, 32), targetArea: new Rectangle(240, 622, 16, 32), patchMode: PatchMode.Replace);
                    //8
                    editor.PatchImage(source, sourceArea: new Rectangle(304, 1200, 32, 32), targetArea: new Rectangle(0, 677, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 1200, 32, 32), targetArea: new Rectangle(32, 675, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(368, 1200, 32, 32), targetArea: new Rectangle(64, 672, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(400, 1200, 32, 32), targetArea: new Rectangle(96, 675, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(400, 1200, 32, 32), targetArea: new Rectangle(96, 675, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(384, 1280, 64, 32), targetArea: new Rectangle(128, 676, 64, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(48, 1312, 64, 48), targetArea: new Rectangle(192, 675, 64, 48), patchMode: PatchMode.Replace);
                    //9
                    editor.PatchImage(source, sourceArea: new Rectangle(112, 1312, 16, 48), targetArea: new Rectangle(0, 723, 16, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(144, 1312, 16, 48), targetArea: new Rectangle(16, 723, 16, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(176, 1312, 32, 48), targetArea: new Rectangle(32, 720, 32, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(480, 1312, 32, 48), targetArea: new Rectangle(64, 723, 32, 48), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(160, 1360, 32, 32), targetArea: new Rectangle(96, 721, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(192, 1360, 32, 32), targetArea: new Rectangle(128, 726, 32, 32), patchMode: PatchMode.Replace);
                    source = ModEntry.ModHelper.GameContent.Load<Texture2D>("Maps/townInterior");
                    editor.PatchImage(source, sourceArea: new Rectangle(240, 80, 32, 16), targetArea: new Rectangle(160, 725, 32, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(272, 80, 16, 16), targetArea: new Rectangle(192, 722, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(240, 96, 32, 16), targetArea: new Rectangle(208, 726, 32, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(272, 96, 16, 16), targetArea: new Rectangle(240, 721, 16, 16), patchMode: PatchMode.Replace);
                    //10
                    editor.PatchImage(source, sourceArea: new Rectangle(288, 80, 32, 32), targetArea: new Rectangle(0, 789, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(240, 112, 64, 32), targetArea: new Rectangle(32, 789, 64, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(304, 112, 32, 32), targetArea: new Rectangle(96, 786, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(320, 384, 13, 25), targetArea: new Rectangle(129, 787, 13, 25), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(334, 384, 23, 24), targetArea: new Rectangle(149, 787, 23, 24), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(358, 384, 24, 24), targetArea: new Rectangle(180, 786, 24, 24), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(320, 368, 16, 16), targetArea: new Rectangle(208, 785, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 368, 16, 16), targetArea: new Rectangle(224, 790, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(356, 368, 12, 16), targetArea: new Rectangle(242, 785, 12, 16), patchMode: PatchMode.Replace);
                    //11
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 576, 16, 23), targetArea: new Rectangle(0, 833, 16, 23), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(352, 560, 16, 24), targetArea: new Rectangle(16, 832, 16, 24), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(320, 80, 16, 16), targetArea: new Rectangle(32, 835, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 80, 16, 16), targetArea: new Rectangle(48, 837, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(352, 80, 16, 16), targetArea: new Rectangle(64, 838, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(368, 80, 16, 16), targetArea: new Rectangle(80, 837, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(384, 71, 32, 16), targetArea: new Rectangle(96, 838, 32, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(320, 96, 16, 16), targetArea: new Rectangle(128, 835, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 96, 16, 16), targetArea: new Rectangle(144, 831, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(352, 96, 16, 16), targetArea: new Rectangle(158, 835, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(368, 96, 16, 16), targetArea: new Rectangle(174, 838, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 112, 16, 16), targetArea: new Rectangle(192, 833, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(352, 112, 16, 16), targetArea: new Rectangle(208, 835, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(368, 112, 16, 16), targetArea: new Rectangle(224, 836, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(290, 144, 11, 16), targetArea: new Rectangle(242, 837, 11, 16), patchMode: PatchMode.Replace);
                    //12
                    editor.PatchImage(source, sourceArea: new Rectangle(320, 144, 9, 12), targetArea: new Rectangle(3, 870, 9, 12), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(330, 152, 6, 8), targetArea: new Rectangle(21, 870, 6, 8), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 128, 16, 16), targetArea: new Rectangle(31, 870, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(304, 144, 16, 16), targetArea: new Rectangle(48, 868, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 144, 11, 15), targetArea: new Rectangle(66, 870, 11, 15), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(352, 128, 16, 16), targetArea: new Rectangle(80, 867, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(368, 128, 16, 7), targetArea: new Rectangle(96, 870, 16, 7), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(357, 144, 11, 13), targetArea: new Rectangle(114, 870, 11, 13), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(368, 144, 14, 16), targetArea: new Rectangle(129, 870, 14, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(293, 160, 11, 15), targetArea: new Rectangle(146, 870, 11, 15), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(307, 162, 10, 11), targetArea: new Rectangle(163, 870, 10, 11), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(321, 162, 14, 13), targetArea: new Rectangle(177, 870, 14, 13), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(340, 162, 10, 14), targetArea: new Rectangle(195, 870, 10, 14), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(358, 162, 10, 14), targetArea: new Rectangle(211, 870, 10, 14), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(370, 169, 14, 15), targetArea: new Rectangle(225, 870, 14, 15), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(387, 165, 12, 15), targetArea: new Rectangle(242, 870, 12, 15), patchMode: PatchMode.Replace);
                    //13
                    editor.PatchImage(source, sourceArea: new Rectangle(288, 176, 14, 13), targetArea: new Rectangle(1, 902, 14, 13), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(305, 179, 14, 13), targetArea: new Rectangle(17, 902, 14, 13), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(322, 177, 14, 13), targetArea: new Rectangle(33, 902, 14, 13), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(338, 176, 12, 16), targetArea: new Rectangle(50, 902, 12, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(354, 178, 11, 14), targetArea: new Rectangle(67, 902, 11, 14), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(290, 193, 11, 15), targetArea: new Rectangle(82, 902, 11, 15), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(310, 194, 10, 14), targetArea: new Rectangle(99, 902, 10, 14), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(320, 194, 10, 14), targetArea: new Rectangle(115, 902, 10, 14), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(374, 194, 10, 14), targetArea: new Rectangle(131, 902, 10, 14), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(416, 193, 16, 15), targetArea: new Rectangle(144, 902, 16, 15), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(432, 194, 15, 13), targetArea: new Rectangle(160, 902, 15, 13), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(20, 245, 8, 10), targetArea: new Rectangle(180, 902, 8, 10), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(18, 357, 11, 16), targetArea: new Rectangle(194, 902, 11, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(17, 376, 14, 8), targetArea: new Rectangle(209, 902, 14, 8), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(21, 386, 11, 7), targetArea: new Rectangle(227, 902, 11, 7), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(19, 403, 11, 12), targetArea: new Rectangle(242, 902, 11, 12), patchMode: PatchMode.Replace);
                });
            }
        }
        internal void OnAssetRequested_ConfigBuildingSetTilesheets(object sender, AssetRequestedEventArgs e)
        {
            if (e.NameWithoutLocale.IsEquivalentTo("Maps/_sc_building_set"))
            {
                e.Edit(asset =>
                {
                    var editor = asset.AsImage();
                    Texture2D source;
                    //Wallspapers and Floors
                    source = ModEntry.ModHelper.GameContent.Load<Texture2D>("Maps/walls_and_floors");
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 42, 256, 3), targetArea: new Rectangle(0, 176, 256, 3), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 0, 256, 45), targetArea: new Rectangle(0, 179, 256, 45), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 90, 256, 3), targetArea: new Rectangle(0, 240, 256, 3), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 48, 256, 45), targetArea: new Rectangle(0, 243, 256, 45), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 138, 256, 3), targetArea: new Rectangle(0, 304, 256, 3), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 96, 256, 45), targetArea: new Rectangle(0, 307, 256, 45), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 186, 256, 3), targetArea: new Rectangle(0, 368, 256, 3), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 144, 256, 45), targetArea: new Rectangle(0, 371, 256, 45), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 234, 256, 3), targetArea: new Rectangle(0, 432, 256, 3), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 192, 256, 45), targetArea: new Rectangle(0, 435, 256, 45), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 282, 256, 3), targetArea: new Rectangle(0, 496, 256, 3), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 240, 256, 45), targetArea: new Rectangle(0, 499, 256, 45), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 330, 256, 3), targetArea: new Rectangle(0, 560, 256, 3), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 288, 256, 45), targetArea: new Rectangle(0, 563, 256, 45), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(0, 336, 256, 224), targetArea: new Rectangle(0, 624, 256, 224), patchMode: PatchMode.Replace);
                    //Windows
                    source = ModEntry.ModHelper.GameContent.Load<Texture2D>("TileSheets/furniture");
                    editor.PatchImage(source, sourceArea: new Rectangle(224, 803, 32, 29), targetArea: new Rectangle(256, 179, 32, 29), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(256, 802, 32, 29), targetArea: new Rectangle(256, 244, 32, 29), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(288, 832, 32, 32), targetArea: new Rectangle(256, 310, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 864, 32, 32), targetArea: new Rectangle(256, 370, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(144, 832, 32, 32), targetArea: new Rectangle(256, 434, 32, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(224, 832, 32, 32), targetArea: new Rectangle(256, 691, 32, 32), patchMode: PatchMode.Replace);
                    source = ModEntry.ModHelper.GameContent.Load<Texture2D>("Maps/townInterior");
                    editor.PatchImage(source, sourceArea: new Rectangle(128, 608, 16, 16), targetArea: new Rectangle(256, 502, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(64, 624, 16, 16), targetArea: new Rectangle(272, 502, 16, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 192, 32, 16), targetArea: new Rectangle(256, 564, 32, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(64, 608, 32, 16), targetArea: new Rectangle(256, 628, 32, 16), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(336, 224, 16, 32), targetArea: new Rectangle(256, 662, 16, 32), patchMode: PatchMode.Replace);
                    editor.PatchImage(source, sourceArea: new Rectangle(48, 608, 16, 32), targetArea: new Rectangle(272, 662, 16, 32), patchMode: PatchMode.Replace);
                });
            }
        }
        internal void OnDayStarted_ReloadTilesheets(object sender, DayStartedEventArgs e)
        {
            ModEntry.ModHelper.GameContent.InvalidateCache("Maps/_sc_dinamic_crops");
            ModEntry.ModHelper.GameContent.InvalidateCache("Maps/_sc_dinamic_interiors");
            ModEntry.ModHelper.GameContent.InvalidateCache("Maps/_sc_building_set");
        }
        
    }
}
