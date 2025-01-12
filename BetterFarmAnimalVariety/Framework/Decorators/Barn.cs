﻿// Decompiled with JetBrains decompiler
// Type: BetterFarmAnimalVariety.Framework.Decorators.Coop
// Assembly: BetterFarmAnimalVariety, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5915D6B1-6174-4632-A28A-C1734D2C6C57
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Mods\Paritee's Better Farm Animal Variety\BetterFarmAnimalVariety.dll

namespace BetterFarmAnimalVariety.Framework.Decorators
{
  internal class Barn : Decorator
  {
    public Barn(StardewValley.Buildings.Barn original)
      : base(original)
    {
    }

    public StardewValley.Buildings.Barn GetOriginal()
    {
      return GetOriginal<StardewValley.Buildings.Barn>();
    }

    public StardewValley.AnimalHouse GetIndoors()
    {
      return Paritee.StardewValley.Core.Locations.AnimalHouse.GetIndoors(GetOriginal());
    }
  }
}