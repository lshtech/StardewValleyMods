// Decompiled with JetBrains decompiler
// Type: BetterFarmAnimalVariety.Framework.Patches.Coop.DayUpdate
// Assembly: BetterFarmAnimalVariety, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5915D6B1-6174-4632-A28A-C1734D2C6C57
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Mods\Paritee's Better Farm Animal Variety\BetterFarmAnimalVariety.dll

namespace BetterFarmAnimalVariety.Framework.Patches.Barn
{
  internal class DayUpdate
  {
    public static bool Prefix(ref StardewValley.Buildings.Barn __instance, ref int dayOfMonth)
    {
      var animalHouse = new Decorators.AnimalHouse(new Decorators.Barn(__instance).GetIndoors());
      if (!animalHouse.IsEggReadyToHatch())
        return true;
      animalHouse.ResetIncubator();
      return true;
    }
  }
}