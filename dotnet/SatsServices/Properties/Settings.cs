// Decompiled with JetBrains decompiler
// Type: SatsServices.Properties.Settings
// Assembly: SatsServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADB8896D-E563-45A2-B87F-1BE326157560
// Assembly location: C:\Users\dart\Downloads\SatsServices.dll

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SatsServices.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        return Settings.defaultInstance;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("png")]
    [ApplicationScopedSetting]
    public string DefaultImageResponseFormat
    {
      get
      {
        return (string) this["DefaultImageResponseFormat"];
      }
    }

    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("fmt")]
    public string ImageFormatRequestKey
    {
      get
      {
        return (string) this["ImageFormatRequestKey"];
      }
    }

    [DefaultSettingValue("dim")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    public string ImageDimensionsRequestKey
    {
      get
      {
        return (string) this["ImageDimensionsRequestKey"];
      }
    }

    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("500")]
    public int DefaultImageResponseDimensions
    {
      get
      {
        return (int) this["DefaultImageResponseDimensions"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("32")]
    public int ImageDimensionsMin
    {
      get
      {
        return (int) this["ImageDimensionsMin"];
      }
    }

    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("4096")]
    public int ImageDimensionsMax
    {
      get
      {
        return (int) this["ImageDimensionsMax"];
      }
    }

    [ApplicationScopedSetting]
    [DefaultSettingValue("bgc")]
    [DebuggerNonUserCode]
    public string ImageBackgroundColorRequestKey
    {
      get
      {
        return (string) this["ImageBackgroundColorRequestKey"];
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("fgc")]
    [ApplicationScopedSetting]
    public string ImageForegroundColorRequestKey
    {
      get
      {
        return (string) this["ImageForegroundColorRequestKey"];
      }
    }

    [DefaultSettingValue("fff")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    public string DefaultImageResponseBackgroundColor
    {
      get
      {
        return (string) this["DefaultImageResponseBackgroundColor"];
      }
    }

    [DefaultSettingValue("000")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    public string DefaultImageResponseForegroundColor
    {
      get
      {
        return (string) this["DefaultImageResponseForegroundColor"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("data")]
    public string ImageDataRequestKey
    {
      get
      {
        return (string) this["ImageDataRequestKey"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("Tahoma")]
    public string ImageRenderingLabelsFontName
    {
      get
      {
        return (string) this["ImageRenderingLabelsFontName"];
      }
    }

    [ApplicationScopedSetting]
    [DefaultSettingValue("1")]
    [DebuggerNonUserCode]
    public int DataItem1GPSMin
    {
      get
      {
        return (int) this["DataItem1GPSMin"];
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("32")]
    [ApplicationScopedSetting]
    public int DataItem1GPSMax
    {
      get
      {
        return (int) this["DataItem1GPSMax"];
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("65")]
    [ApplicationScopedSetting]
    public int DataItem1GLONASSMin
    {
      get
      {
        return (int) this["DataItem1GLONASSMin"];
      }
    }

    [DefaultSettingValue("88")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    public int DataItem1GLONASSMax
    {
      get
      {
        return (int) this["DataItem1GLONASSMax"];
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("5")]
    [ApplicationScopedSetting]
    public int NumberOfFieldsInPointStructure
    {
      get
      {
        return (int) this["NumberOfFieldsInPointStructure"];
      }
    }

    [ApplicationScopedSetting]
    [DefaultSettingValue("0")]
    [DebuggerNonUserCode]
    public int DataItem2Min
    {
      get
      {
        return (int) this["DataItem2Min"];
      }
    }

    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("90")]
    public int DataItem2Max
    {
      get
      {
        return (int) this["DataItem2Max"];
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    [ApplicationScopedSetting]
    public int DataItem3Min
    {
      get
      {
        return (int) this["DataItem3Min"];
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("360")]
    [ApplicationScopedSetting]
    public int DataItem3Max
    {
      get
      {
        return (int) this["DataItem3Max"];
      }
    }

    [DefaultSettingValue("0")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    public int DataItem4Min
    {
      get
      {
        return (int) this["DataItem4Min"];
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("70")]
    [ApplicationScopedSetting]
    public int DataItem4Max
    {
      get
      {
        return (int) this["DataItem4Max"];
      }
    }

    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("0")]
    public int DataItem5Min
    {
      get
      {
        return (int) this["DataItem5Min"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("7")]
    public int DataItem5Max
    {
      get
      {
        return (int) this["DataItem5Max"];
      }
    }

    [DefaultSettingValue("ddfafafa")]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    public string StrengthLevel0Color
    {
      get
      {
        return (string) this["StrengthLevel0Color"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("1")]
    public int StrengthLevel1Min
    {
      get
      {
        return (int) this["StrengthLevel1Min"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("20")]
    public int StrengthLevel1Max
    {
      get
      {
        return (int) this["StrengthLevel1Max"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("dd83e69a")]
    public string StrengthLevel1Color
    {
      get
      {
        return (string) this["StrengthLevel1Color"];
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("20")]
    [ApplicationScopedSetting]
    public int StrengthLevel2Min
    {
      get
      {
        return (int) this["StrengthLevel2Min"];
      }
    }

    [DefaultSettingValue("25")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    public int StrengthLevel2Max
    {
      get
      {
        return (int) this["StrengthLevel2Max"];
      }
    }

    [DefaultSettingValue("dd4db365")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    public string StrengthLevel2Color
    {
      get
      {
        return (string) this["StrengthLevel2Color"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("25")]
    public int StrengthLevel3Min
    {
      get
      {
        return (int) this["StrengthLevel3Min"];
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("30")]
    [ApplicationScopedSetting]
    public int StrengthLevel3Max
    {
      get
      {
        return (int) this["StrengthLevel3Max"];
      }
    }

    [DefaultSettingValue("dd328f48")]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    public string StrengthLevel3Color
    {
      get
      {
        return (string) this["StrengthLevel3Color"];
      }
    }

    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("30")]
    public int StrengthLevel4Min
    {
      get
      {
        return (int) this["StrengthLevel4Min"];
      }
    }

    [DefaultSettingValue("35")]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    public int StrengthLevel4Max
    {
      get
      {
        return (int) this["StrengthLevel4Max"];
      }
    }

    [DefaultSettingValue("dd19752e")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    public string StrengthLevel4Color
    {
      get
      {
        return (string) this["StrengthLevel4Color"];
      }
    }

    [DefaultSettingValue("35")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    public int StrengthLevel5Min
    {
      get
      {
        return (int) this["StrengthLevel5Min"];
      }
    }

    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("40")]
    public int StrengthLevel5Max
    {
      get
      {
        return (int) this["StrengthLevel5Max"];
      }
    }

    [ApplicationScopedSetting]
    [DefaultSettingValue("dd0c571e")]
    [DebuggerNonUserCode]
    public string StrengthLevel5Color
    {
      get
      {
        return (string) this["StrengthLevel5Color"];
      }
    }

    [DefaultSettingValue("40")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    public int StrengthLevel6Min
    {
      get
      {
        return (int) this["StrengthLevel6Min"];
      }
    }

    [ApplicationScopedSetting]
    [DefaultSettingValue("71")]
    [DebuggerNonUserCode]
    public int StrengthLevel6Max
    {
      get
      {
        return (int) this["StrengthLevel6Max"];
      }
    }

    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("dd034011")]
    public string StrengthLevel6Color
    {
      get
      {
        return (string) this["StrengthLevel6Color"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    public bool IsHandlerReusable
    {
      get
      {
        return (bool) this["IsHandlerReusable"];
      }
    }
  }
}
