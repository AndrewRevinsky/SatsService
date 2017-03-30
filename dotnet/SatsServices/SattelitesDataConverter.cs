// Decompiled with JetBrains decompiler
// Type: SatsServices.SattelitesDataConverter
// Assembly: SatsServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADB8896D-E563-45A2-B87F-1BE326157560
// Assembly location: C:\Users\dart\Downloads\SatsServices.dll

using SatsServices.Properties;
using SatsServices.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SatsServices
{
  public class SattelitesDataConverter
  {
    public static readonly int INT_Fields = Settings.Default.NumberOfFieldsInPointStructure;

    public static IEnumerable<SatDataItem> TryParseRawData(string rawData)
    {
      int[] castSequence = SattelitesDataConverter.GetCastSequence(rawData);
      if (!SattelitesDataConverter.IsValid(castSequence))
        return Enumerable.Empty<SatDataItem>();
      return SattelitesDataConverter.ToItemizedArray(castSequence).Select<RawSatDataItem, SatDataItem>((Func<RawSatDataItem, SatDataItem>) (i => SattelitesDataConverter.ParseAndValidateData(i)));
    }

    private static SatDataItem ParseAndValidateData(RawSatDataItem source)
    {
      GeoPosSystemType geoPosSystemType = !source._0.IsBetween(Settings.Default.DataItem1GPSMin, Settings.Default.DataItem1GPSMax, true) ? (!source._0.IsBetween(Settings.Default.DataItem1GLONASSMin, Settings.Default.DataItem1GLONASSMax, true) ? GeoPosSystemType.Unknown : GeoPosSystemType.GLONASS) : GeoPosSystemType.GPS;
      int strength = IntUtility.Restrict(source._3, Settings.Default.DataItem4Min, Settings.Default.DataItem4Max);
      string str = SattelitesDataConverter.PlaceStrengthIntoCategory(strength);
      return new SatDataItem()
      {
        GPSystemType = geoPosSystemType,
        SatNumber = source._0,
        Distance = IntUtility.Restrict(source._1, Settings.Default.DataItem2Min, Settings.Default.DataItem2Max),
        Angle = IntUtility.Restrict(source._2, Settings.Default.DataItem3Min, Settings.Default.DataItem3Max),
        Strength = strength,
        Mods = (SatUsage) IntUtility.Restrict(source._4, Settings.Default.DataItem5Min, Settings.Default.DataItem5Max),
        PointColorValue = str
      };
    }

    private static string PlaceStrengthIntoCategory(int strength)
    {
      if (strength == 0)
        return Settings.Default.StrengthLevel0Color;
      if (strength.IsBetween(Settings.Default.StrengthLevel1Min, Settings.Default.StrengthLevel1Max, false))
        return Settings.Default.StrengthLevel1Color;
      if (strength.IsBetween(Settings.Default.StrengthLevel2Min, Settings.Default.StrengthLevel2Max, false))
        return Settings.Default.StrengthLevel2Color;
      if (strength.IsBetween(Settings.Default.StrengthLevel3Min, Settings.Default.StrengthLevel3Max, false))
        return Settings.Default.StrengthLevel3Color;
      if (strength.IsBetween(Settings.Default.StrengthLevel4Min, Settings.Default.StrengthLevel4Max, false))
        return Settings.Default.StrengthLevel4Color;
      if (strength.IsBetween(Settings.Default.StrengthLevel5Min, Settings.Default.StrengthLevel5Max, false))
        return Settings.Default.StrengthLevel5Color;
      if (strength.IsBetween(Settings.Default.StrengthLevel6Min, Settings.Default.StrengthLevel6Max, false))
        return Settings.Default.StrengthLevel6Color;
      return Settings.Default.StrengthLevel0Color;
    }

    private static IEnumerable<RawSatDataItem> ToItemizedArray(int[] castSequence)
    {
      int i = 0;
      int max = castSequence.Length;
      while (i < max)
      {
        yield return new RawSatDataItem()
        {
          _0 = castSequence[i],
          _1 = castSequence[i + 1],
          _2 = castSequence[i + 2],
          _3 = castSequence[i + 3],
          _4 = castSequence[i + 4]
        };
        i += SattelitesDataConverter.INT_Fields;
      }
    }

    private static bool IsValid(int[] sequence)
    {
      if (sequence != null)
        return sequence.Length % SattelitesDataConverter.INT_Fields == 0;
      return false;
    }

    private static int[] GetCastSequence(string rawData)
    {
      return ((IEnumerable<string>) rawData.Split(new string[1]
      {
        ","
      }, StringSplitOptions.None)).Select<string, string>((Func<string, string>) (m => m.Trim())).Select<string, string>((Func<string, string>) (m =>
      {
        if (!RegularExpressions.Number.IsMatch(m))
          return string.Empty;
        return m;
      })).Select<string, string>((Func<string, string>) (m =>
      {
        if (!string.IsNullOrEmpty(m))
          return m;
        return "0";
      })).Select<string, int>(new Func<string, int>(int.Parse)).ToArray<int>();
    }
  }
}
