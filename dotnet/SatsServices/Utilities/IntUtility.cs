// Decompiled with JetBrains decompiler
// Type: SatsServices.Utilities.IntUtility
// Assembly: SatsServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADB8896D-E563-45A2-B87F-1BE326157560
// Assembly location: C:\Users\dart\Downloads\SatsServices.dll

using System;

namespace SatsServices.Utilities
{
  public static class IntUtility
  {
    public static Func<int, bool> GetBetweenComparer(int minValue, int maxValue)
    {
      return (Func<int, bool>) (x =>
      {
        if (x >= minValue)
          return x < maxValue;
        return false;
      });
    }

    public static int Restrict(int input, int minValue, int maxValue)
    {
      if (maxValue < minValue)
      {
        int num = minValue;
        minValue = maxValue;
        maxValue = num;
      }
      return Math.Min(Math.Max(minValue, input), maxValue);
    }

    public static bool IsBetween(this int input, int minValue, int maxValue, bool includeMax)
    {
      if (maxValue < minValue)
      {
        int num = minValue;
        minValue = maxValue;
        maxValue = num;
      }
      if (includeMax)
      {
        if (input >= minValue)
          return input < maxValue + 1;
        return false;
      }
      if (input >= minValue)
        return input < maxValue;
      return false;
    }
  }
}
