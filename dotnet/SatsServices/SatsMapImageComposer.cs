// Decompiled with JetBrains decompiler
// Type: SatsServices.SatsMapImageComposer
// Assembly: SatsServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADB8896D-E563-45A2-B87F-1BE326157560
// Assembly location: C:\Users\dart\Downloads\SatsServices.dll

using SatsServices.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace SatsServices
{
  public class SatsMapImageComposer
  {
    public ImageGenerationParameters Parameters { get; set; }

    public SatsMapImageComposer(ImageGenerationParameters parameters)
    {
      this.Parameters = parameters;
      this.PrepareParameters();
    }

    private void PrepareParameters()
    {
      this.Parameters.Format = FileTypeHelper.SupportedFormats[this.Parameters.RawFormat];
      this.Parameters.BackgroundColor = ColorUtility.ParseColorWithFallback(this.Parameters.RawBackgroundColor, Color.White);
      this.Parameters.ForegroundColor = ColorUtility.ParseColorWithFallback(this.Parameters.RawForegroundColor, Color.Black);
    }

    internal void Save(Stream stream)
    {
      float r = (float) this.Parameters.Dimensions / 10f;
      using (Bitmap bitmap = new Bitmap(this.Parameters.Dimensions, this.Parameters.Dimensions, PixelFormat.Format24bppRgb))
      {
        using (Graphics g = Graphics.FromImage((Image) bitmap))
        {
          using (Font font1 = new Font(Settings.Default.ImageRenderingLabelsFontName, 0.3f * r, FontStyle.Regular, GraphicsUnit.Pixel))
          {
            using (Font font2 = new Font(Settings.Default.ImageRenderingLabelsFontName, 0.3f * r, FontStyle.Bold, GraphicsUnit.Pixel))
            {
              using (Brushes brushes = new Brushes())
              {
                using (Brush brush1 = (Brush) new SolidBrush(this.Parameters.ForegroundColor))
                {
                  using (Pen pen1 = new Pen((Brush) new SolidBrush(this.Parameters.ForegroundColor)))
                  {
                    using (Pen pen2 = new Pen((Brush) new SolidBrush(this.Parameters.ForegroundColor), r * 0.05f))
                    {
                      g.SmoothingMode = SmoothingMode.AntiAlias;
                      g.Clear(this.Parameters.BackgroundColor);
                      this.DrawCrossHairCoords(g, r, pen1);
                      foreach (SatDataItem satDataItem in SattelitesDataConverter.TryParseRawData(this.Parameters.RawData))
                      {
                        float num1 = (float) ((90.0 - (double) satDataItem.Distance) / 90.0);
                        double num2 = (90.0 - (double) satDataItem.Angle) * Math.PI / 180.0;
                        float x = r * (float) (5.0 + 4.0 * (double) num1 * Math.Cos(num2));
                        float num3 = r * (float) (5.0 - 4.0 * (double) num1 * Math.Sin(num2));
                        if (satDataItem.GPSystemType != GeoPosSystemType.Unknown)
                        {
                          Brush brush2 = brushes.Pick(satDataItem.PointColorValue);
                          float num4 = 0.5f * r;
                          if ((satDataItem.Mods & SatUsage.DrawCircleLine) == SatUsage.DrawCircleLine)
                          {
                            Pen pen3 = (satDataItem.Mods & SatUsage.MakeCircleBold) == SatUsage.MakeCircleBold ? pen2 : pen1;
                            g.DrawEllipse(pen3, new RectangleF(x - num4 * 0.5f, num3 - num4 * 0.5f, num4, num4));
                          }
                          g.FillEllipse(brush2, new RectangleF(x - num4 * 0.5f, num3 - num4 * 0.5f, num4, num4));
                          Font font3 = (satDataItem.Mods & SatUsage.MakeTextBold) == SatUsage.MakeTextBold ? font2 : font1;
                          g.DrawString(string.Format("{0}", (object) satDataItem.SatNumber), font3, brush1, new PointF(x, num3 + r * 0.02f), new StringFormat()
                          {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                          });
                        }
                      }
                      bitmap.Save(stream, this.Parameters.Format);
                    }
                  }
                }
              }
            }
          }
        }
      }
    }

    private void DrawCrossHairCoords(Graphics g, float r, Pen pen)
    {
      g.DrawEllipse(pen, new RectangleF(r * 1f, r * 1f, r * 8f, r * 8f));
      g.DrawLine(pen, new PointF(r * 0.5f, r * 5f), new PointF(r * 9.5f, r * 5f));
      g.DrawLine(pen, new PointF(r * 5f, r * 0.5f), new PointF(r * 5f, r * 9.5f));
    }
  }
}
