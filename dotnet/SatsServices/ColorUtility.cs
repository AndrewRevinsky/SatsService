// Decompiled with JetBrains decompiler
// Type: SatsServices.ColorUtility
// Assembly: SatsServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADB8896D-E563-45A2-B87F-1BE326157560
// Assembly location: C:\Users\dart\Downloads\SatsServices.dll

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SatsServices
{
  public static class ColorUtility
  {
    private static readonly Dictionary<string, Color> _colors = new Dictionary<string, Color>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);

    public static Color ParseColorWithFallback(string value, Color defaultValue)
    {
      string key = value;
      if (!ColorUtility._colors.ContainsKey(key))
      {
        try
        {
          if (value.Length == 3 || value.Length == 4)
            value = string.Join(string.Empty, ((IEnumerable<char>) value.ToCharArray()).Select<char, string>((Func<char, string>) (c => new string(c, 2))).ToArray<string>());
          ColorUtility._colors[key] = ColorTranslator.FromHtml("#" + value);
        }
        catch
        {
          return defaultValue;
        }
      }
      return ColorUtility._colors[key];
    }
  }
}
