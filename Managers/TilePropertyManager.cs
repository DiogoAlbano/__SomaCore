using StardewValley;
using StardewValley.Menus;
using xTile.ObjectModel;
using xTile.Tiles;
using Microsoft.Xna.Framework;
using StardewModdingAPI.Events;
using StardewModdingAPI;
using __SomaCore.TileActions;
using System;
using xTile.Layers;
using xTile;
using StardewValley.Objects;

namespace __SomaCore.Managers
{
    public class TilePropertyManager
    {
        private Vector2 _playerPos;
        internal static GameLocation SourceLocation;
        internal static int X;

        internal void OnButtonPressed_CheckTileProperty(object sender, ButtonPressedEventArgs e)
        {
            if (!Context.CanPlayerMove)
                return;
            SourceLocation = null;
            _playerPos = Vector2.Zero;
            if (Constants.TargetPlatform == GamePlatform.Android)
            {
                if (e.Button != SButton.MouseLeft)
                {
                    return;
                }                  
                if (e.Cursor.GrabTile != e.Cursor.Tile)
                {
                    return;
                }
                    
            }
            else if (!e.Button.IsActionButton())
            {
                return;
            }               
            Vector2 clickedTile = ModEntry.ModHelper.Input.GetCursorPosition().GrabTile;
            IPropertyCollection tileProperty = GetTileProperty(Game1.currentLocation, "Buildings", clickedTile);
            if (tileProperty == null)
            {
                return;
            }                
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
        internal static IPropertyCollection GetTileProperty(GameLocation map, string layer, Vector2 tile)
        {
            if (map == null)
            {
                return null;
            }                
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
        internal static void CheckTileProperty(IPropertyCollection tileProperty, ButtonPressedEventArgs e)
        {
            tileProperty.TryGetValue("Action", out PropertyValue property);
            TilePropertyManager tilePropertyManager = new();
            if (property != null)
            {
                var text = property.ToString();
                string[] checking = text.Split(' ');
                switch (checking[0])
                {
                    case "scWarp":
                        {
                            SetAction.WarpAndPlaySound(checking);
                            break;
                        }
                }
            }
                  
        }
    }
}