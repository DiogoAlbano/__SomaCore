using __SomaCore.Managers;
using StardewValley;
using System.Collections.Generic;

namespace __SomaCore.TileActions
{
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
            TilePropertyManager tilePropertyManager = new();
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
}
