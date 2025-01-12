﻿// Decompiled with JetBrains decompiler
// Type: BetterFarmAnimalVariety.Framework.Patches.AnimalHouse.ResetSharedState
// Assembly: BetterFarmAnimalVariety, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5915D6B1-6174-4632-A28A-C1734D2C6C57
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Mods\Paritee's Better Farm Animal Variety\BetterFarmAnimalVariety.dll

namespace BetterFarmAnimalVariety.Framework.Patches.AnimalHouse
{
  internal class ResetSharedState
  {
    public static void Postfix(ref StardewValley.AnimalHouse __instance)
    {
      var animalHouse = new Decorators.AnimalHouse(__instance);
      if (animalHouse.IsFull() || animalHouse.GetIncubatorWithEggReadyToHatch() == null)
        return;
      animalHouse.SetIncubatorHatchEvent();
    }
  }
}