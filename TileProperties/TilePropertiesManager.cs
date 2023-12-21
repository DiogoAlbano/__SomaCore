using StardewModdingAPI.Events;
using StardewModdingAPI;
using StardewValley.Menus;
using StardewValley;
using xTile.ObjectModel;
using xTile.Tiles;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace __SomaCore.TileProperties
{
    public class TilePropertiesManager
    {
        private Vector2 _playerPos;
        internal static GameLocation SourceLocation;
        public Vector2 ClickedTile;
        internal void OnButtonPressed_CheckTileProperty(object sender, ButtonPressedEventArgs e)
        {
            if (!Context.CanPlayerMove)
                return;
            SourceLocation = null;
            _playerPos = Vector2.Zero;
            Vector2 clickedTile = ModEntry.ModHelper.Input.GetCursorPosition().GrabTile;
            IPropertyCollection tileProperty = GetTileProperty(Game1.currentLocation, "Buildings", clickedTile);
            if (tileProperty == null)
                return;
            CheckTileProperty(tileProperty, e);
        }
        internal void OnUpdateTicking_CheckLocationRequested(object sender, UpdateTickingEventArgs e)
        {
            if (SourceLocation != null && (Game1.locationRequest?.Name == "AnimalShop" || Game1.locationRequest?.Name == "WizardHouse" || Game1.locationRequest?.Name == "ScienceHouse"))
            {
                Game1.locationRequest.Location = SourceLocation;
                Game1.locationRequest.IsStructure = SourceLocation.isStructure.Value;
            }
        }
        internal void OnDisplayMenuChanged_RemoveShopOwnerPortrait(object sender, MenuChangedEventArgs e)
        {
            _playerPos = Vector2.Zero;
            if (e.NewMenu == null && _playerPos != Vector2.Zero)
            {
                Game1.player.position.Set(_playerPos);
            }
            if (e.OldMenu is CarpenterMenu || e.OldMenu is PurchaseAnimalsMenu)
            {
                if (e.NewMenu is DialogueBox)
                {
                    Game1.exitActiveMenu();
                    Game1.drawObjectDialogue(ModEntry.ModHelper.Translation.Get("dialogoaqui"));
                }
            }
        }
        public static IPropertyCollection GetTileProperty(GameLocation map, string layer, Vector2 tile)
        {
            if (map == null)
                return null;
            Tile checkTile = map.Map.GetLayer(layer).Tiles[(int)tile.X, (int)tile.Y];
            return checkTile?.Properties;
        }
        public void CallMenu(string menu)
        {
            IClickableMenu whichMenu = GetMenu.WhichMenu(menu, out bool warpingShop);
            if (menu != null)
            {
                if (warpingShop)
                {
                    SourceLocation = Game1.currentLocation;
                    _playerPos = Game1.player.position.Get();
                }
                Game1.activeClickableMenu = whichMenu;
            }
        }
        public static void CheckTileProperty(IPropertyCollection tileProperty, ButtonPressedEventArgs e)
        {
            tileProperty.TryGetValue("nm_Action", out PropertyValue property);
            TilePropertiesManager tilePropertyManager = new();
            if (property != null)
            {
                var checking = (string)property;
                switch (checking)
                {
                    case "Door":
                        {
                               
                            break;
                        }
                }
            }
        }

    }
    public class CreateQuestionDialogues
    {
        public static void CreateQuestionDialogue(string checking, bool noload)
        {
            List<Response> options = new();
            switch (checking)
            {
                case "CarpenterATM":
                    {
                        options.Add(new Response("CarpenterBuilder", "CarpenterBuilder"));
                        options.Add(new Response("Leave", "Leave"));
                        Game1.currentLocation.createQuestionDialogue("QuestionDialoguesTile", options.ToArray(), new GameLocation.afterQuestionBehavior(CreateQuestionDialogue_output));
                        break;
                    }
            }
        }
        public static void CreateQuestionDialogue_output(Farmer farmer, string choice)
        {
            TilePropertiesManager tilePropertyManager = new();
            switch (choice)
            {
                case "CarpenterBuilder":
                    {
                        tilePropertyManager.CallMenu("CarpenterBuilder");
                        break;
                    }
            }
        }
    }
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
    public class SetAction
    {

    }
}
