// Decompiled with JetBrains decompiler
// Type: SatsServices.RegularExpressions
// Assembly: SatsServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADB8896D-E563-45A2-B87F-1BE326157560
// Assembly location: C:\Users\dart\Downloads\SatsServices.dll

using System.Text.RegularExpressions;

namespace SatsServices
{
  public class RegularExpressions
  {
    private static readonly SatsServices.RegularExpressions _instance = new SatsServices.RegularExpressions();
    private Regex color;
    private Regex number;
    private Regex letters;

    public static Regex Color
    {
      get
      {
        if (SatsServices.RegularExpressions._instance.color == null)
          SatsServices.RegularExpressions._instance.color = new Regex("^\t\t #start of the line\n #\t\t #  must constains a \"#\" symbols\n (\t\t #  start of group #1\n  [A-Fa-f0-9]{8} #    any strings in the list, with length of 8\n  |\t\t #    ..or\n  [A-Fa-f0-9]{6} #    any strings in the list, with length of 6\n  |\t\t #    ..or\n  [A-Fa-f0-9]{4} #    any strings in the list, with length of 4\n  |\t\t #    ..or\n  [A-Fa-f0-9]{3} #    any strings in the list, with length of 3\n )\t\t #  end of group #1 \n$\t\t #end of the line", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace);
        return SatsServices.RegularExpressions._instance.color;
      }
    }

    public static Regex Number
    {
      get
      {
        if (SatsServices.RegularExpressions._instance.number == null)
          SatsServices.RegularExpressions._instance.number = new Regex("^[0-9]+$", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace);
        return SatsServices.RegularExpressions._instance.number;
      }
    }

    public static Regex Letters
    {
      get
      {
        if (SatsServices.RegularExpressions._instance.letters == null)
          SatsServices.RegularExpressions._instance.letters = new Regex("^[A-Za-z]+$", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace);
        return SatsServices.RegularExpressions._instance.letters;
      }
    }

    private RegularExpressions()
    {
    }
  }
}
