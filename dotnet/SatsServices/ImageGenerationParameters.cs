// Decompiled with JetBrains decompiler
// Type: SatsServices.ImageGenerationParameters
// Assembly: SatsServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADB8896D-E563-45A2-B87F-1BE326157560
// Assembly location: C:\Users\dart\Downloads\SatsServices.dll

using System.Drawing;
using System.Drawing.Imaging;

namespace SatsServices
{
  public class ImageGenerationParameters
  {
    public string RawFormat { get; set; }

    public ImageFormat Format { get; set; }

    public int Dimensions { get; set; }

    public string RawBackgroundColor { get; set; }

    public string RawForegroundColor { get; set; }

    public string RawData { get; set; }

    public int[] Data { get; set; }

    public Color BackgroundColor { get; set; }

    public Color ForegroundColor { get; set; }
  }
}
