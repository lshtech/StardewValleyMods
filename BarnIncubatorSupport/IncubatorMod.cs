using System;
using Harmony;
using StardewModdingAPI;
using Object = StardewValley.Object;



namespace BarnIncubatorSupport
{
  public class IncubatorMod : Mod
  {
    public override void Entry(IModHelper helper)
    {
      try
      {
        CreateHarmonyPatch();
      }
      catch (Exception ex)
      {
        Monitor.Log(ex.Message, LogLevel.Error);
      }
    }

    private void CreateHarmonyPatch()
    {
      var harmonyInstance = HarmonyInstance.Create("elbe.BarnIncubatorSupport");
      Monitor.Log("Applying Harmony patches...");
      harmonyInstance.Patch(AccessTools.Method(typeof(Object), "performObjectDropInAction"),
        new HarmonyMethod(typeof(performObjectDropInAction), "Prefix"));
    }
  }
}