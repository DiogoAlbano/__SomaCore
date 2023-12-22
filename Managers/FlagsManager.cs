using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Locations;
using System;
using System.Collections.Generic;

namespace __SomaCore.Managers
{
    public class FlagsManager
    {
        internal void OnAssetRequested_CreateFlags(object sender, AssetRequestedEventArgs e)
        {
            if (e.NameWithoutLocale.IsEquivalentTo("Data/mail"))
            {
                e.Edit(asset =>
                {
                    var data = asset.AsDictionary<string, string>().Data;
                    data.Add(new KeyValuePair<string, string>("nmTreesCured", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_1", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_2", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_3", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_4", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_5", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_6", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_7", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_8", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_9", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_10", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_11", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_12", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_13", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_14", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_15", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_16", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_17", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_18", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_19", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_20", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_21", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_22", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_23", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_24", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_25", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_26", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_27", "none"));
                    data.Add(new KeyValuePair<string, string>("nmTreeGrowCounter_28", "none"));

                });
            }
        }
        internal void OnDayStarted_SetFlagsAndEvents(object sender, DayStartedEventArgs e)
        {
            if (Utility.doesAnyFarmerHaveMail("nmTreesCured") && !Utility.doesAnyFarmerHaveOrWillReceiveMail("nmTreeGrowCounter_28"))
            {
                if (!Utility.doesAnyFarmerHaveMail("nmTreeGrowCounter_1"))
                {
                    Game1.addMailForTomorrow("nmTreeGrowCounter_1", true);
                }
                for (int i = 1; i < 28; i++)
                {
                    if (Utility.doesAnyFarmerHaveMail("nmTreeGrowCounter_" + Convert.ToString(i)) && !Utility.doesAnyFarmerHaveMail("nmTreeGrowCounter_" + Convert.ToString(i+1)))
                    {
                        Game1.addMailForTomorrow("nmTreeGrowCounter_" + Convert.ToString(i + 1), true);
                    }
                }
            }
        }
    }
}
