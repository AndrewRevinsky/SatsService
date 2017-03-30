// Decompiled with JetBrains decompiler
// Type: SatsServices.SatsMapHandler
// Assembly: SatsServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADB8896D-E563-45A2-B87F-1BE326157560
// Assembly location: C:\Users\dart\Downloads\SatsServices.dll

using SatsServices.Properties;
using SatsServices.Utilities;
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace SatsServices
{
  public class SatsMapHandler : IHttpHandler
  {
    public bool IsReusable
    {
      get
      {
        return Settings.Default.IsHandlerReusable;
      }
    }

    public void ProcessRequest(HttpContext context)
    {
      HttpCachePolicy cache = context.Response.Cache;
      cache.SetCacheability(HttpCacheability.Public);
      cache.VaryByParams[Settings.Default.ImageFormatRequestKey] = true;
      cache.VaryByParams[Settings.Default.ImageDimensionsRequestKey] = true;
      cache.VaryByParams[Settings.Default.ImageBackgroundColorRequestKey] = true;
      cache.VaryByParams[Settings.Default.ImageForegroundColorRequestKey] = true;
      cache.VaryByParams[Settings.Default.ImageDataRequestKey] = true;
      TimeSpan delta = TimeSpan.FromHours(1.0);
      cache.SetExpires(DateTime.Now.Add(delta));
      cache.SetMaxAge(delta);
      context.Response.Cache.SetValidUntilExpires(true);
      ImageGenerationParameters generationParameters = this.GetImageGenerationParameters(context.Request);
      context.Response.ContentType = FileTypeHelper.GetContentType(generationParameters.RawFormat);
      string str = string.Format("inline; filename=satsmap-{0}.{1}", (object) generationParameters.Dimensions, (object) generationParameters.RawFormat);
      context.Response.AddHeader("Content-Disposition", str);
      new SatsMapImageComposer(generationParameters).Save(context.Response.OutputStream);
    }

    private ImageGenerationParameters GetImageGenerationParameters(HttpRequest request)
    {
      NameValueCollection collection = request.Params;
      return new ImageGenerationParameters()
      {
        RawFormat = collection.Get<string>(Settings.Default.ImageFormatRequestKey, new Func<string, bool>(RegularExpressions.Letters.IsMatch), Settings.Default.DefaultImageResponseFormat, new Func<string, bool>(((Enumerable) FileTypeHelper.SupportedFormats.Keys).Contains<string>)),
        Dimensions = collection.Get<int>(Settings.Default.ImageDimensionsRequestKey, new Func<string, bool>(RegularExpressions.Number.IsMatch), Settings.Default.DefaultImageResponseDimensions, IntUtility.GetBetweenComparer(Settings.Default.ImageDimensionsMin, Settings.Default.ImageDimensionsMax)),
        RawBackgroundColor = collection.Get<string>(Settings.Default.ImageBackgroundColorRequestKey, new Func<string, bool>(RegularExpressions.Color.IsMatch), Settings.Default.DefaultImageResponseBackgroundColor, (Func<string, bool>) null),
        RawForegroundColor = collection.Get<string>(Settings.Default.ImageForegroundColorRequestKey, new Func<string, bool>(RegularExpressions.Color.IsMatch), Settings.Default.DefaultImageResponseForegroundColor, (Func<string, bool>) null),
        RawData = collection.Get<string>(Settings.Default.ImageDataRequestKey, (Func<string, bool>) null, string.Empty, (Func<string, bool>) null)
      };
    }
  }
}
