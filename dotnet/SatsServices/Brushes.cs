// Decompiled with JetBrains decompiler
// Type: SatsServices.Brushes
// Assembly: SatsServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADB8896D-E563-45A2-B87F-1BE326157560
// Assembly location: C:\Users\dart\Downloads\SatsServices.dll

using SatsServices.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SatsServices
{
  public sealed class Brushes : Dictionary<string, Brush>, IDisposable
  {
    private Dictionary<string, Brush> _brushes;
    private Dictionary<string, Color> _colors;
    private bool _IsDisposed;

    public Brushes()
    {
      this._brushes = ((IEnumerable<string>) new string[7]
      {
        Settings.Default.StrengthLevel0Color,
        Settings.Default.StrengthLevel1Color,
        Settings.Default.StrengthLevel2Color,
        Settings.Default.StrengthLevel3Color,
        Settings.Default.StrengthLevel4Color,
        Settings.Default.StrengthLevel5Color,
        Settings.Default.StrengthLevel6Color
      }).Select<string, string>((Func<string, string>) (k => k.ToLowerInvariant())).Select(k => new
      {
        Key = k,
        Value = new SolidBrush(ColorUtility.ParseColorWithFallback(k, Color.Transparent))
      }).ToDictionary(i => i.Key, i => (Brush) i.Value);
    }

    public Brush Pick(string colorValue)
    {
      string lowerInvariant = colorValue.ToLowerInvariant();
      if (!this._brushes.ContainsKey(lowerInvariant))
        this._brushes.Add(lowerInvariant, (Brush) new SolidBrush(ColorUtility.ParseColorWithFallback(colorValue, Color.Transparent)));
      return this._brushes[lowerInvariant];
    }

    public void Dispose()
    {
      if (this._IsDisposed)
        return;
      foreach (Brush brush in this._brushes.Values)
        brush.Dispose();
      this._brushes.Clear();
      this._IsDisposed = true;
    }
  }
}
