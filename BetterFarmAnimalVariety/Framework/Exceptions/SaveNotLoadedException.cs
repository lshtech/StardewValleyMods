﻿// Decompiled with JetBrains decompiler
// Type: BetterFarmAnimalVariety.Framework.Exceptions.SaveNotLoadedException
// Assembly: BetterFarmAnimalVariety, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5915D6B1-6174-4632-A28A-C1734D2C6C57
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Mods\Paritee's Better Farm Animal Variety\BetterFarmAnimalVariety.dll

using System;

namespace BetterFarmAnimalVariety.Framework.Exceptions
{
  [Serializable]
  internal class SaveNotLoadedException : Exception
  {
    public SaveNotLoadedException()
      : base("Save has not been loaded")
    {
    }
  }
}