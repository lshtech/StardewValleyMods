﻿// Decompiled with JetBrains decompiler
// Type: BetterFarmAnimalVariety.Framework.SaveData.FarmAnimal
// Assembly: BetterFarmAnimalVariety, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5915D6B1-6174-4632-A28A-C1734D2C6C57
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Mods\Paritee's Better Farm Animal Variety\BetterFarmAnimalVariety.dll

namespace BetterFarmAnimalVariety.Framework.SaveData
{
  public class FarmAnimal
  {
    public readonly long Id;
    public TypeLog TypeLog;

    public FarmAnimal(long id, TypeLog typeLog)
    {
      Id = id;
      TypeLog = typeLog;
    }

    public string GetSavedType()
    {
      return TypeLog.Saved;
    }
  }
}