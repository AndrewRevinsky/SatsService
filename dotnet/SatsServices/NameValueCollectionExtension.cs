// Decompiled with JetBrains decompiler
// Type: SatsServices.NameValueCollectionExtension
// Assembly: SatsServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADB8896D-E563-45A2-B87F-1BE326157560
// Assembly location: C:\Users\dart\Downloads\SatsServices.dll

using System;
using System.Collections.Specialized;
using System.ComponentModel;

namespace SatsServices
{
  public static class NameValueCollectionExtension
  {
    public static T Get<T>(this NameValueCollection collection, string key, Func<string, bool> preValidator, T defaultValue, Func<T, bool> postValidator = null)
    {
      string text = collection[key];
      if (string.IsNullOrEmpty(text))
        return defaultValue;
      if (preValidator != null)
      {
        if (!preValidator(text))
          return defaultValue;
      }
      try
      {
        T obj = (T) TypeDescriptor.GetConverter(typeof (T)).ConvertFromInvariantString(text);
        if (postValidator != null && !postValidator(obj))
          return defaultValue;
        return obj;
      }
      catch
      {
        return defaultValue;
      }
    }
  }
}
