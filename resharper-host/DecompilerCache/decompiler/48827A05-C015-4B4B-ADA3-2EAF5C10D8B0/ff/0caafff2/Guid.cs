// Decompiled with JetBrains decompiler
// Type: System.Guid
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 48827A05-C015-4B4B-ADA3-2EAF5C10D8B0
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll

using Microsoft.Win32;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
  /// <summary>
  ///   表示全域唯一識別項 (GUID)。
  /// 
  ///   若要瀏覽此類型的.NET Framework 原始程式碼，請參閱 Reference Source。
  /// </summary>
  [ComVisible(true)]
  [NonVersionable]
  [__DynamicallyInvokable]
  [Serializable]
  public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>
  {
    /// <summary>
    ///   唯讀執行個體 <see cref="T:System.Guid" /> 結構，其值會全部為零。
    /// </summary>
    [__DynamicallyInvokable]
    public static readonly Guid Empty;
    private int _a;
    private short _b;
    private short _c;
    private byte _d;
    private byte _e;
    private byte _f;
    private byte _g;
    private byte _h;
    private byte _i;
    private byte _j;
    private byte _k;

    /// <summary>
    ///   初始化的新執行個體<see cref="T:System.Guid" />結構，使用指定的位元組陣列。
    /// </summary>
    /// <param name="b">16 個元素位元組陣列，包含要用來初始化 GUID 的值。</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="b" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="b" />不是 16 個位元組長。
    /// </exception>
    [__DynamicallyInvokable]
    public Guid(byte[] b)
    {
      if (b == null)
        throw new ArgumentNullException(nameof (b));
      if (b.Length != 16)
        throw new ArgumentException(Environment.GetResourceString("Arg_GuidArrayCtor", (object) "16"));
      this._a = (int) b[3] << 24 | (int) b[2] << 16 | (int) b[1] << 8 | (int) b[0];
      this._b = (short) ((int) b[5] << 8 | (int) b[4]);
      this._c = (short) ((int) b[7] << 8 | (int) b[6]);
      this._d = b[8];
      this._e = b[9];
      this._f = b[10];
      this._g = b[11];
      this._h = b[12];
      this._i = b[13];
      this._j = b[14];
      this._k = b[15];
    }

    /// <summary>
    ///   初始化的新執行個體<see cref="T:System.Guid" />使用指定的結構不帶正負號的整數和位元組。
    /// </summary>
    /// <param name="a">GUID 的前 4 個位元組。</param>
    /// <param name="b">GUID 接下來的 2 個位元組。</param>
    /// <param name="c">GUID 接下來的 2 個位元組。</param>
    /// <param name="d">GUID 的下一個位元組。</param>
    /// <param name="e">GUID 的下一個位元組。</param>
    /// <param name="f">GUID 的下一個位元組。</param>
    /// <param name="g">GUID 的下一個位元組。</param>
    /// <param name="h">GUID 的下一個位元組。</param>
    /// <param name="i">GUID 的下一個位元組。</param>
    /// <param name="j">GUID 的下一個位元組。</param>
    /// <param name="k">GUID 的下一個位元組。</param>
    [CLSCompliant(false)]
    [__DynamicallyInvokable]
    public Guid(
      uint a,
      ushort b,
      ushort c,
      byte d,
      byte e,
      byte f,
      byte g,
      byte h,
      byte i,
      byte j,
      byte k)
    {
      this._a = (int) a;
      this._b = (short) b;
      this._c = (short) c;
      this._d = d;
      this._e = e;
      this._f = f;
      this._g = g;
      this._h = h;
      this._i = i;
      this._j = j;
      this._k = k;
    }

    /// <summary>
    ///   初始化的新執行個體<see cref="T:System.Guid" />結構，使用指定的整數和位元組陣列。
    /// </summary>
    /// <param name="a">GUID 的前 4 個位元組。</param>
    /// <param name="b">GUID 接下來的 2 個位元組。</param>
    /// <param name="c">GUID 接下來的 2 個位元組。</param>
    /// <param name="d">GUID 剩餘的 8 個位元組。</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="d" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="d" />不是 8 個位元組長。
    /// </exception>
    [__DynamicallyInvokable]
    public Guid(int a, short b, short c, byte[] d)
    {
      if (d == null)
        throw new ArgumentNullException(nameof (d));
      if (d.Length != 8)
        throw new ArgumentException(Environment.GetResourceString("Arg_GuidArrayCtor", (object) "8"));
      this._a = a;
      this._b = b;
      this._c = c;
      this._d = d[0];
      this._e = d[1];
      this._f = d[2];
      this._g = d[3];
      this._h = d[4];
      this._i = d[5];
      this._j = d[6];
      this._k = d[7];
    }

    /// <summary>
    ///   初始化的新執行個體<see cref="T:System.Guid" />使用指定的整數和位元組結構。
    /// </summary>
    /// <param name="a">GUID 的前 4 個位元組。</param>
    /// <param name="b">GUID 接下來的 2 個位元組。</param>
    /// <param name="c">GUID 接下來的 2 個位元組。</param>
    /// <param name="d">GUID 的下一個位元組。</param>
    /// <param name="e">GUID 的下一個位元組。</param>
    /// <param name="f">GUID 的下一個位元組。</param>
    /// <param name="g">GUID 的下一個位元組。</param>
    /// <param name="h">GUID 的下一個位元組。</param>
    /// <param name="i">GUID 的下一個位元組。</param>
    /// <param name="j">GUID 的下一個位元組。</param>
    /// <param name="k">GUID 的下一個位元組。</param>
    [__DynamicallyInvokable]
    public Guid(
      int a,
      short b,
      short c,
      byte d,
      byte e,
      byte f,
      byte g,
      byte h,
      byte i,
      byte j,
      byte k)
    {
      this._a = a;
      this._b = b;
      this._c = c;
      this._d = d;
      this._e = e;
      this._f = f;
      this._g = g;
      this._h = h;
      this._i = i;
      this._j = j;
      this._k = k;
    }

    /// <summary>
    ///   初始化的新執行個體<see cref="T:System.Guid" />結構使用所指定的字串表示的值。
    /// </summary>
    /// <param name="g">
    ///   字串，包含下列格式之一的 GUID ("d" 代表十六進位數字，忽略大小寫)：
    /// 
    ///   32 個連續數字：
    /// 
    ///   dddddddddddddddddddddddddddddddd
    /// 
    ///   -或-
    /// 
    ///   8、4、4、4 和 12 個數字的群組，其間以短破折號相隔。
    ///    整個 GUID 可以選擇性地用對稱的大括號或括號括起來：
    /// 
    ///   dddddddd-dddd-dddd-dddd-dddddddddddd
    /// 
    ///   -或-
    /// 
    ///   {dddddddd-dddd-dddd-dddd-dddddddddddd}
    /// 
    ///   -或-
    /// 
    ///   (dddddddd-dddd-dddd-dddd-dddddddddddd)
    /// 
    ///   -或-
    /// 
    ///   8、4 和 4 個數字的群組，與一個 2 個數字形成之八個群組的子集，而每個群組都以 "0x" 或 "0X" 做為字首，並且以逗號分隔。
    ///    整個 GUID 和子集都用對稱的大括號括起來︰
    /// 
    ///   {0xdddddddd, 0xdddd, 0xdddd,{0xdd,0xdd,0xdd,0xdd,0xdd,0xdd,0xdd,0xdd}}
    /// 
    ///   所有的大括號、逗號和 "0x" 都是必要的。
    ///    所有內嵌的空白都會被忽略。
    ///    群組中所有前置的零都會被忽略。
    /// 
    ///   群組中所顯示的數字是可以出現在群組中有意義的數字數目上限。
    ///    您可以指定從 1 到群組所顯示的數字數目。
    ///    所指定的數字會假設為群組的低序位數字。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="g" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.FormatException">
    ///   格式<paramref name="g" />無效。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   格式<paramref name="g" />無效。
    /// </exception>
    [__DynamicallyInvokable]
    public Guid(string g)
    {
      if (g == null)
        throw new ArgumentNullException(nameof (g));
      this = Guid.Empty;
      Guid.GuidResult result = new Guid.GuidResult();
      result.Init(Guid.GuidParseThrowStyle.All);
      this = Guid.TryParseGuid(g, Guid.GuidStyles.Any, ref result) ? result.parsedGuid : throw result.GetGuidParseException();
    }

    /// <summary>
    ///   將 GUID 的字串表示轉換為對等項目<see cref="T:System.Guid" />結構。
    /// </summary>
    /// <param name="input">要轉換的字串。</param>
    /// <returns>包含所剖析之值的結構。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="input" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.FormatException">
    ///   <paramref name="input" />不是可辨識的格式。
    /// </exception>
    [__DynamicallyInvokable]
    public static Guid Parse(string input)
    {
      if (input == null)
        throw new ArgumentNullException(nameof (input));
      Guid.GuidResult result = new Guid.GuidResult();
      result.Init(Guid.GuidParseThrowStyle.AllButOverflow);
      return Guid.TryParseGuid(input, Guid.GuidStyles.Any, ref result) ? result.parsedGuid : throw result.GetGuidParseException();
    }

    /// <summary>
    ///   將 GUID 的字串表示轉換為對等項目<see cref="T:System.Guid" />結構。
    /// </summary>
    /// <param name="input">要轉換的 GUID。</param>
    /// <param name="result">
    ///   要包含所剖析之值的結構。
    ///    如果此方法會傳回<see langword="true" />，<paramref name="result" />包含有效<see cref="T:System.Guid" />。
    ///    如果此方法會傳回<see langword="false" />，<paramref name="result" />等於<see cref="F:System.Guid.Empty" />。
    /// </param>
    /// <returns>
    ///   <see langword="true" />如果剖析作業成功。否則， <see langword="false" />。
    /// </returns>
    [__DynamicallyInvokable]
    public static bool TryParse(string input, out Guid result)
    {
      Guid.GuidResult result1 = new Guid.GuidResult();
      result1.Init(Guid.GuidParseThrowStyle.None);
      if (Guid.TryParseGuid(input, Guid.GuidStyles.Any, ref result1))
      {
        result = result1.parsedGuid;
        return true;
      }
      result = Guid.Empty;
      return false;
    }

    /// <summary>
    ///   將 GUID 的字串表示轉換為對等項目<see cref="T:System.Guid" />結構，假設字串位於指定的格式。
    /// </summary>
    /// <param name="input">要轉換的 GUID。</param>
    /// <param name="format">
    ///   下列格式規範會指出要解譯時所使用之確切格式的其中一個<paramref name="input" />:"N"、"D"、"B"、"P"或"X"。
    /// </param>
    /// <returns>包含所剖析之值的結構。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="input" /> 或 <paramref name="format" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.FormatException">
    ///   <paramref name="input" />不在指定的格式<paramref name="format" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Guid ParseExact(string input, string format)
    {
      if (input == null)
        throw new ArgumentNullException(nameof (input));
      if (format == null)
        throw new ArgumentNullException(nameof (format));
      if (format.Length != 1)
        throw new FormatException(Environment.GetResourceString("Format_InvalidGuidFormatSpecification"));
      Guid.GuidStyles flags;
      switch (format[0])
      {
        case 'B':
        case 'b':
          flags = Guid.GuidStyles.BraceFormat;
          break;
        case 'D':
        case 'd':
          flags = Guid.GuidStyles.RequireDashes;
          break;
        case 'N':
        case 'n':
          flags = Guid.GuidStyles.None;
          break;
        case 'P':
        case 'p':
          flags = Guid.GuidStyles.ParenthesisFormat;
          break;
        case 'X':
        case 'x':
          flags = Guid.GuidStyles.HexFormat;
          break;
        default:
          throw new FormatException(Environment.GetResourceString("Format_InvalidGuidFormatSpecification"));
      }
      Guid.GuidResult result = new Guid.GuidResult();
      result.Init(Guid.GuidParseThrowStyle.AllButOverflow);
      if (Guid.TryParseGuid(input, flags, ref result))
        return result.parsedGuid;
      throw result.GetGuidParseException();
    }

    /// <summary>
    ///   將 GUID 的字串表示轉換為對等項目<see cref="T:System.Guid" />結構，假設字串位於指定的格式。
    /// </summary>
    /// <param name="input">要轉換的 GUID。</param>
    /// <param name="format">
    ///   下列格式規範會指出要解譯時所使用之確切格式的其中一個<paramref name="input" />:"N"、"D"、"B"、"P"或"X"。
    /// </param>
    /// <param name="result">
    ///   要包含所剖析之值的結構。
    ///    如果此方法會傳回<see langword="true" />，<paramref name="result" />包含有效<see cref="T:System.Guid" />。
    ///    如果此方法會傳回<see langword="false" />，<paramref name="result" />等於<see cref="F:System.Guid.Empty" />。
    /// </param>
    /// <returns>
    ///   <see langword="true" />如果剖析作業成功。否則， <see langword="false" />。
    /// </returns>
    [__DynamicallyInvokable]
    public static bool TryParseExact(string input, string format, out Guid result)
    {
      if (format == null || format.Length != 1)
      {
        result = Guid.Empty;
        return false;
      }
      Guid.GuidStyles flags;
      switch (format[0])
      {
        case 'B':
        case 'b':
          flags = Guid.GuidStyles.BraceFormat;
          break;
        case 'D':
        case 'd':
          flags = Guid.GuidStyles.RequireDashes;
          break;
        case 'N':
        case 'n':
          flags = Guid.GuidStyles.None;
          break;
        case 'P':
        case 'p':
          flags = Guid.GuidStyles.ParenthesisFormat;
          break;
        case 'X':
        case 'x':
          flags = Guid.GuidStyles.HexFormat;
          break;
        default:
          result = Guid.Empty;
          return false;
      }
      Guid.GuidResult result1 = new Guid.GuidResult();
      result1.Init(Guid.GuidParseThrowStyle.None);
      if (Guid.TryParseGuid(input, flags, ref result1))
      {
        result = result1.parsedGuid;
        return true;
      }
      result = Guid.Empty;
      return false;
    }

    private static bool TryParseGuid(string g, Guid.GuidStyles flags, ref Guid.GuidResult result)
    {
      if (g == null)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidUnrecognized");
        return false;
      }
      string guidString = g.Trim();
      if (guidString.Length == 0)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidUnrecognized");
        return false;
      }
      bool flag1 = guidString.IndexOf('-', 0) >= 0;
      if (flag1)
      {
        if ((flags & (Guid.GuidStyles.AllowDashes | Guid.GuidStyles.RequireDashes)) == Guid.GuidStyles.None)
        {
          result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidUnrecognized");
          return false;
        }
      }
      else if ((flags & Guid.GuidStyles.RequireDashes) != Guid.GuidStyles.None)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidUnrecognized");
        return false;
      }
      bool flag2 = guidString.IndexOf('{', 0) >= 0;
      if (flag2)
      {
        if ((flags & (Guid.GuidStyles.AllowBraces | Guid.GuidStyles.RequireBraces)) == Guid.GuidStyles.None)
        {
          result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidUnrecognized");
          return false;
        }
      }
      else if ((flags & Guid.GuidStyles.RequireBraces) != Guid.GuidStyles.None)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidUnrecognized");
        return false;
      }
      if (guidString.IndexOf('(', 0) >= 0)
      {
        if ((flags & (Guid.GuidStyles.AllowParenthesis | Guid.GuidStyles.RequireParenthesis)) == Guid.GuidStyles.None)
        {
          result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidUnrecognized");
          return false;
        }
      }
      else if ((flags & Guid.GuidStyles.RequireParenthesis) != Guid.GuidStyles.None)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidUnrecognized");
        return false;
      }
      try
      {
        if (flag1)
          return Guid.TryParseGuidWithDashes(guidString, ref result);
        return flag2 ? Guid.TryParseGuidWithHexPrefix(guidString, ref result) : Guid.TryParseGuidWithNoStyle(guidString, ref result);
      }
      catch (IndexOutOfRangeException ex)
      {
        result.SetFailure(Guid.ParseFailureKind.FormatWithInnerException, "Format_GuidUnrecognized", (object) null, (string) null, (Exception) ex);
        return false;
      }
      catch (ArgumentException ex)
      {
        result.SetFailure(Guid.ParseFailureKind.FormatWithInnerException, "Format_GuidUnrecognized", (object) null, (string) null, (Exception) ex);
        return false;
      }
    }

    private static bool TryParseGuidWithHexPrefix(string guidString, ref Guid.GuidResult result)
    {
      guidString = Guid.EatAllWhitespace(guidString);
      if (string.IsNullOrEmpty(guidString) || guidString[0] != '{')
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidBrace");
        return false;
      }
      if (!Guid.IsHexPrefix(guidString, 1))
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidHexPrefix", (object) "{0xdddddddd, etc}");
        return false;
      }
      int startIndex1 = 3;
      int length1 = guidString.IndexOf(',', startIndex1) - startIndex1;
      if (length1 <= 0)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidComma");
        return false;
      }
      if (!Guid.StringToInt(guidString.Substring(startIndex1, length1), -1, 4096, out result.parsedGuid._a, ref result))
        return false;
      if (!Guid.IsHexPrefix(guidString, startIndex1 + length1 + 1))
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidHexPrefix", (object) "{0xdddddddd, 0xdddd, etc}");
        return false;
      }
      int startIndex2 = startIndex1 + length1 + 3;
      int length2 = guidString.IndexOf(',', startIndex2) - startIndex2;
      if (length2 <= 0)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidComma");
        return false;
      }
      if (!Guid.StringToShort(guidString.Substring(startIndex2, length2), -1, 4096, out result.parsedGuid._b, ref result))
        return false;
      if (!Guid.IsHexPrefix(guidString, startIndex2 + length2 + 1))
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidHexPrefix", (object) "{0xdddddddd, 0xdddd, 0xdddd, etc}");
        return false;
      }
      int startIndex3 = startIndex2 + length2 + 3;
      int length3 = guidString.IndexOf(',', startIndex3) - startIndex3;
      if (length3 <= 0)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidComma");
        return false;
      }
      if (!Guid.StringToShort(guidString.Substring(startIndex3, length3), -1, 4096, out result.parsedGuid._c, ref result))
        return false;
      if (guidString.Length <= startIndex3 + length3 + 1 || guidString[startIndex3 + length3 + 1] != '{')
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidBrace");
        return false;
      }
      int length4 = length3 + 1;
      byte[] numArray = new byte[8];
      for (int index = 0; index < 8; ++index)
      {
        if (!Guid.IsHexPrefix(guidString, startIndex3 + length4 + 1))
        {
          result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidHexPrefix", (object) "{... { ... 0xdd, ...}}");
          return false;
        }
        startIndex3 = startIndex3 + length4 + 3;
        if (index < 7)
        {
          length4 = guidString.IndexOf(',', startIndex3) - startIndex3;
          if (length4 <= 0)
          {
            result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidComma");
            return false;
          }
        }
        else
        {
          length4 = guidString.IndexOf('}', startIndex3) - startIndex3;
          if (length4 <= 0)
          {
            result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidBraceAfterLastNumber");
            return false;
          }
        }
        uint int32 = (uint) Convert.ToInt32(guidString.Substring(startIndex3, length4), 16);
        if (int32 > (uint) byte.MaxValue)
        {
          result.SetFailure(Guid.ParseFailureKind.Format, "Overflow_Byte");
          return false;
        }
        numArray[index] = (byte) int32;
      }
      result.parsedGuid._d = numArray[0];
      result.parsedGuid._e = numArray[1];
      result.parsedGuid._f = numArray[2];
      result.parsedGuid._g = numArray[3];
      result.parsedGuid._h = numArray[4];
      result.parsedGuid._i = numArray[5];
      result.parsedGuid._j = numArray[6];
      result.parsedGuid._k = numArray[7];
      if (startIndex3 + length4 + 1 >= guidString.Length || guidString[startIndex3 + length4 + 1] != '}')
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidEndBrace");
        return false;
      }
      if (startIndex3 + length4 + 1 == guidString.Length - 1)
        return true;
      result.SetFailure(Guid.ParseFailureKind.Format, "Format_ExtraJunkAtEnd");
      return false;
    }

    private static bool TryParseGuidWithNoStyle(string guidString, ref Guid.GuidResult result)
    {
      int startIndex1 = 0;
      if (guidString.Length != 32)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidInvLen");
        return false;
      }
      for (int index = 0; index < guidString.Length; ++index)
      {
        char c = guidString[index];
        if (c < '0' || c > '9')
        {
          char upper = char.ToUpper(c, CultureInfo.InvariantCulture);
          if (upper < 'A' || upper > 'F')
          {
            result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidInvalidChar");
            return false;
          }
        }
      }
      if (!Guid.StringToInt(guidString.Substring(startIndex1, 8), -1, 4096, out result.parsedGuid._a, ref result))
        return false;
      int startIndex2 = startIndex1 + 8;
      if (!Guid.StringToShort(guidString.Substring(startIndex2, 4), -1, 4096, out result.parsedGuid._b, ref result))
        return false;
      int startIndex3 = startIndex2 + 4;
      if (!Guid.StringToShort(guidString.Substring(startIndex3, 4), -1, 4096, out result.parsedGuid._c, ref result))
        return false;
      int startIndex4 = startIndex3 + 4;
      int result1;
      if (!Guid.StringToInt(guidString.Substring(startIndex4, 4), -1, 4096, out result1, ref result))
        return false;
      int flags = startIndex4 + 4;
      int parsePos = flags;
      long result2;
      if (!Guid.StringToLong(guidString, ref parsePos, flags, out result2, ref result))
        return false;
      if (parsePos - flags != 12)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidInvLen");
        return false;
      }
      result.parsedGuid._d = (byte) (result1 >> 8);
      result.parsedGuid._e = (byte) result1;
      int num1 = (int) (result2 >> 32);
      result.parsedGuid._f = (byte) (num1 >> 8);
      result.parsedGuid._g = (byte) num1;
      int num2 = (int) result2;
      result.parsedGuid._h = (byte) (num2 >> 24);
      result.parsedGuid._i = (byte) (num2 >> 16);
      result.parsedGuid._j = (byte) (num2 >> 8);
      result.parsedGuid._k = (byte) num2;
      return true;
    }

    private static bool TryParseGuidWithDashes(string guidString, ref Guid.GuidResult result)
    {
      int num1 = 0;
      if (guidString[0] == '{')
      {
        if (guidString.Length != 38 || guidString[37] != '}')
        {
          result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidInvLen");
          return false;
        }
        num1 = 1;
      }
      else if (guidString[0] == '(')
      {
        if (guidString.Length != 38 || guidString[37] != ')')
        {
          result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidInvLen");
          return false;
        }
        num1 = 1;
      }
      else if (guidString.Length != 36)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidInvLen");
        return false;
      }
      if (guidString[8 + num1] != '-' || guidString[13 + num1] != '-' || (guidString[18 + num1] != '-' || guidString[23 + num1] != '-'))
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidDashes");
        return false;
      }
      int parsePos = num1;
      int result1;
      if (!Guid.StringToInt(guidString, ref parsePos, 8, 8192, out result1, ref result))
        return false;
      result.parsedGuid._a = result1;
      ++parsePos;
      if (!Guid.StringToInt(guidString, ref parsePos, 4, 8192, out result1, ref result))
        return false;
      result.parsedGuid._b = (short) result1;
      ++parsePos;
      if (!Guid.StringToInt(guidString, ref parsePos, 4, 8192, out result1, ref result))
        return false;
      result.parsedGuid._c = (short) result1;
      ++parsePos;
      if (!Guid.StringToInt(guidString, ref parsePos, 4, 8192, out result1, ref result))
        return false;
      ++parsePos;
      int num2 = parsePos;
      long result2;
      if (!Guid.StringToLong(guidString, ref parsePos, 8192, out result2, ref result))
        return false;
      if (parsePos - num2 != 12)
      {
        result.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidInvLen");
        return false;
      }
      result.parsedGuid._d = (byte) (result1 >> 8);
      result.parsedGuid._e = (byte) result1;
      result1 = (int) (result2 >> 32);
      result.parsedGuid._f = (byte) (result1 >> 8);
      result.parsedGuid._g = (byte) result1;
      result1 = (int) result2;
      result.parsedGuid._h = (byte) (result1 >> 24);
      result.parsedGuid._i = (byte) (result1 >> 16);
      result.parsedGuid._j = (byte) (result1 >> 8);
      result.parsedGuid._k = (byte) result1;
      return true;
    }

    [SecuritySafeCritical]
    private static unsafe bool StringToShort(
      string str,
      int requiredLength,
      int flags,
      out short result,
      ref Guid.GuidResult parseResult)
    {
      return Guid.StringToShort(str, (int*) null, requiredLength, flags, out result, ref parseResult);
    }

    [SecuritySafeCritical]
    private static unsafe bool StringToShort(
      string str,
      ref int parsePos,
      int requiredLength,
      int flags,
      out short result,
      ref Guid.GuidResult parseResult)
    {
      fixed (int* parsePos1 = &parsePos)
        return Guid.StringToShort(str, parsePos1, requiredLength, flags, out result, ref parseResult);
    }

    [SecurityCritical]
    private static unsafe bool StringToShort(
      string str,
      int* parsePos,
      int requiredLength,
      int flags,
      out short result,
      ref Guid.GuidResult parseResult)
    {
      result = (short) 0;
      int result1;
      bool flag = Guid.StringToInt(str, parsePos, requiredLength, flags, out result1, ref parseResult);
      result = (short) result1;
      return flag;
    }

    [SecuritySafeCritical]
    private static unsafe bool StringToInt(
      string str,
      int requiredLength,
      int flags,
      out int result,
      ref Guid.GuidResult parseResult)
    {
      return Guid.StringToInt(str, (int*) null, requiredLength, flags, out result, ref parseResult);
    }

    [SecuritySafeCritical]
    private static unsafe bool StringToInt(
      string str,
      ref int parsePos,
      int requiredLength,
      int flags,
      out int result,
      ref Guid.GuidResult parseResult)
    {
      fixed (int* parsePos1 = &parsePos)
        return Guid.StringToInt(str, parsePos1, requiredLength, flags, out result, ref parseResult);
    }

    [SecurityCritical]
    private static unsafe bool StringToInt(
      string str,
      int* parsePos,
      int requiredLength,
      int flags,
      out int result,
      ref Guid.GuidResult parseResult)
    {
      result = 0;
      int num = (IntPtr) parsePos == IntPtr.Zero ? 0 : *parsePos;
      try
      {
        result = ParseNumbers.StringToInt(str, 16, flags, parsePos);
      }
      catch (OverflowException ex)
      {
        if (parseResult.throwStyle == Guid.GuidParseThrowStyle.All)
        {
          throw;
        }
        else
        {
          if (parseResult.throwStyle == Guid.GuidParseThrowStyle.AllButOverflow)
            throw new FormatException(Environment.GetResourceString("Format_GuidUnrecognized"), (Exception) ex);
          parseResult.SetFailure((Exception) ex);
          return false;
        }
      }
      catch (Exception ex)
      {
        if (parseResult.throwStyle == Guid.GuidParseThrowStyle.None)
        {
          parseResult.SetFailure(ex);
          return false;
        }
        throw;
      }
      if (requiredLength == -1 || (IntPtr) parsePos == IntPtr.Zero || *parsePos - num == requiredLength)
        return true;
      parseResult.SetFailure(Guid.ParseFailureKind.Format, "Format_GuidInvalidChar");
      return false;
    }

    [SecuritySafeCritical]
    private static unsafe bool StringToLong(
      string str,
      int flags,
      out long result,
      ref Guid.GuidResult parseResult)
    {
      return Guid.StringToLong(str, (int*) null, flags, out result, ref parseResult);
    }

    [SecuritySafeCritical]
    private static unsafe bool StringToLong(
      string str,
      ref int parsePos,
      int flags,
      out long result,
      ref Guid.GuidResult parseResult)
    {
      fixed (int* parsePos1 = &parsePos)
        return Guid.StringToLong(str, parsePos1, flags, out result, ref parseResult);
    }

    [SecuritySafeCritical]
    private static unsafe bool StringToLong(
      string str,
      int* parsePos,
      int flags,
      out long result,
      ref Guid.GuidResult parseResult)
    {
      result = 0L;
      try
      {
        result = ParseNumbers.StringToLong(str, 16, flags, parsePos);
      }
      catch (OverflowException ex)
      {
        if (parseResult.throwStyle == Guid.GuidParseThrowStyle.All)
        {
          throw;
        }
        else
        {
          if (parseResult.throwStyle == Guid.GuidParseThrowStyle.AllButOverflow)
            throw new FormatException(Environment.GetResourceString("Format_GuidUnrecognized"), (Exception) ex);
          parseResult.SetFailure((Exception) ex);
          return false;
        }
      }
      catch (Exception ex)
      {
        if (parseResult.throwStyle == Guid.GuidParseThrowStyle.None)
        {
          parseResult.SetFailure(ex);
          return false;
        }
        throw;
      }
      return true;
    }

    private static string EatAllWhitespace(string str)
    {
      int length = 0;
      char[] chArray = new char[str.Length];
      for (int index = 0; index < str.Length; ++index)
      {
        char c = str[index];
        if (!char.IsWhiteSpace(c))
          chArray[length++] = c;
      }
      return new string(chArray, 0, length);
    }

    private static bool IsHexPrefix(string str, int i) => str.Length > i + 1 && str[i] == '0' && char.ToLower(str[i + 1], CultureInfo.InvariantCulture) == 'x';

    /// <summary>傳回 16 個元素的位元組陣列，位元組陣列會包含這個執行個體的值。</summary>
    /// <returns>16 個元素的位元組陣列。</returns>
    [__DynamicallyInvokable]
    public byte[] ToByteArray() => new byte[16]
    {
      (byte) this._a,
      (byte) (this._a >> 8),
      (byte) (this._a >> 16),
      (byte) (this._a >> 24),
      (byte) this._b,
      (byte) ((uint) this._b >> 8),
      (byte) this._c,
      (byte) ((uint) this._c >> 8),
      this._d,
      this._e,
      this._f,
      this._g,
      this._h,
      this._i,
      this._j,
      this._k
    };

    /// <summary>以登錄格式傳回這個執行個體的值的字串表示。</summary>
    /// <returns>
    ///   這個值<see cref="T:System.Guid" />，其格式使用"D"格式規範，如下所示︰
    /// 
    ///   xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx
    /// 
    ///   其中的 GUID 值是以一系列小寫的十六進位數字表示，按照 8、4、4、4 和 12 位數分組，以連字號分開。
    ///    傳回值的範例是 "382c74c3-721d-4f34-80e5-57657b6cbc27"。
    ///    若要將十六進位數字轉換成大寫字母 a 到 f，呼叫<see cref="M:System.String.ToUpper" />方法傳回的字串。
    /// </returns>
    [__DynamicallyInvokable]
    public override string ToString() => this.ToString("D", (IFormatProvider) null);

    /// <summary>傳回這個執行個體的雜湊碼。</summary>
    /// <returns>這個執行個體的雜湊碼。</returns>
    [__DynamicallyInvokable]
    public override int GetHashCode() => this._a ^ ((int) this._b << 16 | (int) (ushort) this._c) ^ ((int) this._f << 24 | (int) this._k);

    /// <summary>傳回值，這個值指出此執行個體是否與指定的物件相等。</summary>
    /// <param name="o">與這個執行個體相互比較的物件。</param>
    /// <returns>
    ///   <see langword="true" /> 如果 <paramref name="o" /> 是 <see cref="T:System.Guid" /> 擁有相同的值與這個執行個體; 否則 <see langword="false" />。
    /// </returns>
    [__DynamicallyInvokable]
    public override bool Equals(object o) => o != null && o is Guid guid && (guid._a == this._a && (int) guid._b == (int) this._b) && ((int) guid._c == (int) this._c && (int) guid._d == (int) this._d && ((int) guid._e == (int) this._e && (int) guid._f == (int) this._f)) && ((int) guid._g == (int) this._g && (int) guid._h == (int) this._h && ((int) guid._i == (int) this._i && (int) guid._j == (int) this._j) && (int) guid._k == (int) this._k);

    /// <summary>
    ///   傳回數值，指示這個執行個體和指定的 <see cref="T:System.Guid" /> 物件是否表示相同的值。
    /// </summary>
    /// <param name="g">與這個執行個體相比較的物件。</param>
    /// <returns>
    ///   如果 <see langword="true" /> 等於這個執行個體則為 <paramref name="g" />，否則為 <see langword="false" />。
    /// </returns>
    [__DynamicallyInvokable]
    public bool Equals(Guid g) => g._a == this._a && (int) g._b == (int) this._b && ((int) g._c == (int) this._c && (int) g._d == (int) this._d) && ((int) g._e == (int) this._e && (int) g._f == (int) this._f && ((int) g._g == (int) this._g && (int) g._h == (int) this._h)) && ((int) g._i == (int) this._i && (int) g._j == (int) this._j && (int) g._k == (int) this._k);

    private int GetResult(uint me, uint them) => me < them ? -1 : 1;

    /// <summary>將這個執行個體與指定的物件相比較，並傳回它們的相對值指示。</summary>
    /// <param name="value">
    ///   要比較的物件或 <see langword="null" />。
    /// </param>
    /// <returns>
    /// 帶正負號的數字，指出這個執行個體與 <paramref name="value" /> 的相對值。
    /// 
    ///         傳回值
    /// 
    ///         描述
    /// 
    ///         負整數
    /// 
    ///         這個執行個體小於 <paramref name="value" />。
    /// 
    ///         零
    /// 
    ///         這個執行個體等於 <paramref name="value" />。
    /// 
    ///         正整數
    /// 
    ///         這個執行個體大於<paramref name="value" />，或<paramref name="value" />是<see langword="null" />。
    ///       </returns>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="value" /> 不是 <see cref="T:System.Guid" />。
    /// </exception>
    public int CompareTo(object value)
    {
      if (value == null)
        return 1;
      if (!(value is Guid guid))
        throw new ArgumentException(Environment.GetResourceString("Arg_MustBeGuid"));
      if (guid._a != this._a)
        return this.GetResult((uint) this._a, (uint) guid._a);
      if ((int) guid._b != (int) this._b)
        return this.GetResult((uint) this._b, (uint) guid._b);
      if ((int) guid._c != (int) this._c)
        return this.GetResult((uint) this._c, (uint) guid._c);
      if ((int) guid._d != (int) this._d)
        return this.GetResult((uint) this._d, (uint) guid._d);
      if ((int) guid._e != (int) this._e)
        return this.GetResult((uint) this._e, (uint) guid._e);
      if ((int) guid._f != (int) this._f)
        return this.GetResult((uint) this._f, (uint) guid._f);
      if ((int) guid._g != (int) this._g)
        return this.GetResult((uint) this._g, (uint) guid._g);
      if ((int) guid._h != (int) this._h)
        return this.GetResult((uint) this._h, (uint) guid._h);
      if ((int) guid._i != (int) this._i)
        return this.GetResult((uint) this._i, (uint) guid._i);
      if ((int) guid._j != (int) this._j)
        return this.GetResult((uint) this._j, (uint) guid._j);
      return (int) guid._k != (int) this._k ? this.GetResult((uint) this._k, (uint) guid._k) : 0;
    }

    /// <summary>
    ///   將這個執行個體與指定的 <see cref="T:System.Guid" /> 物件相比較，並傳回它們的相對值指示。
    /// </summary>
    /// <param name="value">與這個執行個體相比較的物件。</param>
    /// <returns>
    /// 帶正負號的數字，指出這個執行個體與 <paramref name="value" /> 的相對值。
    /// 
    ///         傳回值
    /// 
    ///         描述
    /// 
    ///         負整數
    /// 
    ///         這個執行個體小於 <paramref name="value" />。
    /// 
    ///         零
    /// 
    ///         這個執行個體等於 <paramref name="value" />。
    /// 
    ///         正整數
    /// 
    ///         這個執行個體大於 <paramref name="value" />。
    ///       </returns>
    [__DynamicallyInvokable]
    public int CompareTo(Guid value)
    {
      if (value._a != this._a)
        return this.GetResult((uint) this._a, (uint) value._a);
      if ((int) value._b != (int) this._b)
        return this.GetResult((uint) this._b, (uint) value._b);
      if ((int) value._c != (int) this._c)
        return this.GetResult((uint) this._c, (uint) value._c);
      if ((int) value._d != (int) this._d)
        return this.GetResult((uint) this._d, (uint) value._d);
      if ((int) value._e != (int) this._e)
        return this.GetResult((uint) this._e, (uint) value._e);
      if ((int) value._f != (int) this._f)
        return this.GetResult((uint) this._f, (uint) value._f);
      if ((int) value._g != (int) this._g)
        return this.GetResult((uint) this._g, (uint) value._g);
      if ((int) value._h != (int) this._h)
        return this.GetResult((uint) this._h, (uint) value._h);
      if ((int) value._i != (int) this._i)
        return this.GetResult((uint) this._i, (uint) value._i);
      if ((int) value._j != (int) this._j)
        return this.GetResult((uint) this._j, (uint) value._j);
      return (int) value._k != (int) this._k ? this.GetResult((uint) this._k, (uint) value._k) : 0;
    }

    /// <summary>
    ///   表示兩個值是否指定 <see cref="T:System.Guid" /> 物件是否相等。
    /// </summary>
    /// <param name="a">要比較的第一個物件。</param>
    /// <param name="b">要比較的第二個物件。</param>
    /// <returns>
    ///   如果 <paramref name="a" /> 和 <paramref name="b" /> 相等，則為 <see langword="true" />；否則為 <see langword="false" />。
    /// </returns>
    [__DynamicallyInvokable]
    public static bool operator ==(Guid a, Guid b) => a._a == b._a && (int) a._b == (int) b._b && ((int) a._c == (int) b._c && (int) a._d == (int) b._d) && ((int) a._e == (int) b._e && (int) a._f == (int) b._f && ((int) a._g == (int) b._g && (int) a._h == (int) b._h)) && ((int) a._i == (int) b._i && (int) a._j == (int) b._j && (int) a._k == (int) b._k);

    /// <summary>
    ///   表示兩個值是否指定 <see cref="T:System.Guid" /> 物件是否不相等。
    /// </summary>
    /// <param name="a">要比較的第一個物件。</param>
    /// <param name="b">要比較的第二個物件。</param>
    /// <returns>
    ///   如果 <paramref name="a" /> 和 <paramref name="b" /> 不相等，則為 <see langword="true" />；否則為 <see langword="false" />。
    /// </returns>
    [__DynamicallyInvokable]
    public static bool operator !=(Guid a, Guid b) => !(a == b);

    /// <summary>
    ///   初始化 <see cref="T:System.Guid" /> 結構的新執行個體。
    /// </summary>
    /// <returns>新的 GUID 物件。</returns>
    [SecuritySafeCritical]
    [__DynamicallyInvokable]
    public static Guid NewGuid()
    {
      Guid guid;
      Marshal.ThrowExceptionForHR(Win32Native.CoCreateGuid(out guid), new IntPtr(-1));
      return guid;
    }

    /// <summary>
    ///   傳回這個值的字串表示<see cref="T:System.Guid" />執行個體，根據提供的格式規範。
    /// </summary>
    /// <param name="format">
    ///   單一格式規範，指出如何格式化這個 <see cref="T:System.Guid" /> 值。
    ///   <paramref name="format" /> 參數可能是 "N"、"D"、"B"、"P" 或 "X"。
    ///    如果 <paramref name="format" /> 是 <see langword="null" /> 或空字串 ("")，則使用 "D"。
    /// </param>
    /// <returns>
    ///   這個 <see cref="T:System.Guid" /> 值，其按照指定的格式，以一系列小寫的十六進位數字來表示。
    /// </returns>
    /// <exception cref="T:System.FormatException">
    ///   <paramref name="format" /> 值不是 <see langword="null" />、空字串 ("")、"N"、"D"、"B"、"P" 或 "X"。
    /// </exception>
    [__DynamicallyInvokable]
    public string ToString(string format) => this.ToString(format, (IFormatProvider) null);

    private static char HexToChar(int a)
    {
      a &= 15;
      return a > 9 ? (char) (a - 10 + 97) : (char) (a + 48);
    }

    [SecurityCritical]
    private static unsafe int HexsToChars(char* guidChars, int offset, int a, int b) => Guid.HexsToChars(guidChars, offset, a, b, false);

    [SecurityCritical]
    private static unsafe int HexsToChars(char* guidChars, int offset, int a, int b, bool hex)
    {
      if (hex)
      {
        guidChars[offset++] = '0';
        guidChars[offset++] = 'x';
      }
      guidChars[offset++] = Guid.HexToChar(a >> 4);
      guidChars[offset++] = Guid.HexToChar(a);
      if (hex)
      {
        guidChars[offset++] = ',';
        guidChars[offset++] = '0';
        guidChars[offset++] = 'x';
      }
      guidChars[offset++] = Guid.HexToChar(b >> 4);
      guidChars[offset++] = Guid.HexToChar(b);
      return offset;
    }

    /// <summary>
    ///   根據提供的格式規範和特定文化特性格式資訊，傳回這個 <see cref="T:System.Guid" /> 類別執行個體值的字串表示。
    /// </summary>
    /// <param name="format">
    ///   單一格式規範，指出如何格式化這個 <see cref="T:System.Guid" /> 值。
    ///   <paramref name="format" /> 參數可能是 "N"、"D"、"B"、"P" 或 "X"。
    ///    如果 <paramref name="format" /> 是 <see langword="null" /> 或空字串 ("")，則使用 "D"。
    /// </param>
    /// <param name="provider">(保留) 物件，提供特定文化特性格式資訊。</param>
    /// <returns>
    ///   這個 <see cref="T:System.Guid" /> 值，其按照指定的格式，以一系列小寫的十六進位數字來表示。
    /// </returns>
    /// <exception cref="T:System.FormatException">
    ///   <paramref name="format" /> 值不是 <see langword="null" />、空字串 ("")、"N"、"D"、"B"、"P" 或 "X"。
    /// </exception>
    [SecuritySafeCritical]
    public unsafe string ToString(string format, IFormatProvider provider)
    {
      switch (format)
      {
        case "":
        case null:
          format = "D";
          break;
      }
      int offset1 = 0;
      bool flag1 = true;
      bool flag2 = false;
      if (format.Length != 1)
        throw new FormatException(Environment.GetResourceString("Format_InvalidGuidFormatSpecification"));
      string str1;
      switch (format[0])
      {
        case 'B':
        case 'b':
          str1 = string.FastAllocateString(38);
          string str2 = str1;
          char* chPtr1 = (char*) str2;
          if ((IntPtr) chPtr1 != IntPtr.Zero)
            chPtr1 += RuntimeHelpers.OffsetToStringData;
          chPtr1[offset1++] = '{';
          chPtr1[37] = '}';
          str2 = (string) null;
          break;
        case 'D':
        case 'd':
          str1 = string.FastAllocateString(36);
          break;
        case 'N':
        case 'n':
          str1 = string.FastAllocateString(32);
          flag1 = false;
          break;
        case 'P':
        case 'p':
          str1 = string.FastAllocateString(38);
          string str3 = str1;
          char* chPtr2 = (char*) str3;
          if ((IntPtr) chPtr2 != IntPtr.Zero)
            chPtr2 += RuntimeHelpers.OffsetToStringData;
          chPtr2[offset1++] = '(';
          chPtr2[37] = ')';
          str3 = (string) null;
          break;
        case 'X':
        case 'x':
          str1 = string.FastAllocateString(68);
          string str4 = str1;
          char* chPtr3 = (char*) str4;
          if ((IntPtr) chPtr3 != IntPtr.Zero)
            chPtr3 += RuntimeHelpers.OffsetToStringData;
          chPtr3[offset1++] = '{';
          chPtr3[67] = '}';
          str4 = (string) null;
          flag1 = false;
          flag2 = true;
          break;
        default:
          throw new FormatException(Environment.GetResourceString("Format_InvalidGuidFormatSpecification"));
      }
      string str5 = str1;
      char* guidChars = (char*) str5;
      if ((IntPtr) guidChars != IntPtr.Zero)
        guidChars += RuntimeHelpers.OffsetToStringData;
      int num1;
      if (flag2)
      {
        char* chPtr4 = guidChars;
        int num2 = offset1;
        int num3 = num2 + 1;
        IntPtr num4 = (IntPtr) num2 * 2;
        *(short*) ((IntPtr) chPtr4 + num4) = (short) 48;
        char* chPtr5 = guidChars;
        int num5 = num3;
        int offset2 = num5 + 1;
        IntPtr num6 = (IntPtr) num5 * 2;
        *(short*) ((IntPtr) chPtr5 + num6) = (short) 120;
        int chars1 = Guid.HexsToChars(guidChars, offset2, this._a >> 24, this._a >> 16);
        int chars2 = Guid.HexsToChars(guidChars, chars1, this._a >> 8, this._a);
        char* chPtr6 = guidChars;
        int num7 = chars2;
        int num8 = num7 + 1;
        IntPtr num9 = (IntPtr) num7 * 2;
        *(short*) ((IntPtr) chPtr6 + num9) = (short) 44;
        char* chPtr7 = guidChars;
        int num10 = num8;
        int num11 = num10 + 1;
        IntPtr num12 = (IntPtr) num10 * 2;
        *(short*) ((IntPtr) chPtr7 + num12) = (short) 48;
        char* chPtr8 = guidChars;
        int num13 = num11;
        int offset3 = num13 + 1;
        IntPtr num14 = (IntPtr) num13 * 2;
        *(short*) ((IntPtr) chPtr8 + num14) = (short) 120;
        int chars3 = Guid.HexsToChars(guidChars, offset3, (int) this._b >> 8, (int) this._b);
        char* chPtr9 = guidChars;
        int num15 = chars3;
        int num16 = num15 + 1;
        IntPtr num17 = (IntPtr) num15 * 2;
        *(short*) ((IntPtr) chPtr9 + num17) = (short) 44;
        char* chPtr10 = guidChars;
        int num18 = num16;
        int num19 = num18 + 1;
        IntPtr num20 = (IntPtr) num18 * 2;
        *(short*) ((IntPtr) chPtr10 + num20) = (short) 48;
        char* chPtr11 = guidChars;
        int num21 = num19;
        int offset4 = num21 + 1;
        IntPtr num22 = (IntPtr) num21 * 2;
        *(short*) ((IntPtr) chPtr11 + num22) = (short) 120;
        int chars4 = Guid.HexsToChars(guidChars, offset4, (int) this._c >> 8, (int) this._c);
        char* chPtr12 = guidChars;
        int num23 = chars4;
        int num24 = num23 + 1;
        IntPtr num25 = (IntPtr) num23 * 2;
        *(short*) ((IntPtr) chPtr12 + num25) = (short) 44;
        char* chPtr13 = guidChars;
        int num26 = num24;
        int offset5 = num26 + 1;
        IntPtr num27 = (IntPtr) num26 * 2;
        *(short*) ((IntPtr) chPtr13 + num27) = (short) 123;
        int chars5 = Guid.HexsToChars(guidChars, offset5, (int) this._d, (int) this._e, true);
        char* chPtr14 = guidChars;
        int num28 = chars5;
        int offset6 = num28 + 1;
        IntPtr num29 = (IntPtr) num28 * 2;
        *(short*) ((IntPtr) chPtr14 + num29) = (short) 44;
        int chars6 = Guid.HexsToChars(guidChars, offset6, (int) this._f, (int) this._g, true);
        char* chPtr15 = guidChars;
        int num30 = chars6;
        int offset7 = num30 + 1;
        IntPtr num31 = (IntPtr) num30 * 2;
        *(short*) ((IntPtr) chPtr15 + num31) = (short) 44;
        int chars7 = Guid.HexsToChars(guidChars, offset7, (int) this._h, (int) this._i, true);
        char* chPtr16 = guidChars;
        int num32 = chars7;
        int offset8 = num32 + 1;
        IntPtr num33 = (IntPtr) num32 * 2;
        *(short*) ((IntPtr) chPtr16 + num33) = (short) 44;
        int chars8 = Guid.HexsToChars(guidChars, offset8, (int) this._j, (int) this._k, true);
        char* chPtr17 = guidChars;
        int num34 = chars8;
        num1 = num34 + 1;
        IntPtr num35 = (IntPtr) num34 * 2;
        *(short*) ((IntPtr) chPtr17 + num35) = (short) 125;
      }
      else
      {
        int chars1 = Guid.HexsToChars(guidChars, offset1, this._a >> 24, this._a >> 16);
        int chars2 = Guid.HexsToChars(guidChars, chars1, this._a >> 8, this._a);
        if (flag1)
          guidChars[chars2++] = '-';
        int chars3 = Guid.HexsToChars(guidChars, chars2, (int) this._b >> 8, (int) this._b);
        if (flag1)
          guidChars[chars3++] = '-';
        int chars4 = Guid.HexsToChars(guidChars, chars3, (int) this._c >> 8, (int) this._c);
        if (flag1)
          guidChars[chars4++] = '-';
        int chars5 = Guid.HexsToChars(guidChars, chars4, (int) this._d, (int) this._e);
        if (flag1)
          guidChars[chars5++] = '-';
        int chars6 = Guid.HexsToChars(guidChars, chars5, (int) this._f, (int) this._g);
        int chars7 = Guid.HexsToChars(guidChars, chars6, (int) this._h, (int) this._i);
        num1 = Guid.HexsToChars(guidChars, chars7, (int) this._j, (int) this._k);
      }
      str5 = (string) null;
      return str1;
    }

    [Flags]
    private enum GuidStyles
    {
      None = 0,
      AllowParenthesis = 1,
      AllowBraces = 2,
      AllowDashes = 4,
      AllowHexPrefix = 8,
      RequireParenthesis = 16, // 0x00000010
      RequireBraces = 32, // 0x00000020
      RequireDashes = 64, // 0x00000040
      RequireHexPrefix = 128, // 0x00000080
      HexFormat = RequireHexPrefix | RequireBraces, // 0x000000A0
      NumberFormat = 0,
      DigitFormat = RequireDashes, // 0x00000040
      BraceFormat = DigitFormat | RequireBraces, // 0x00000060
      ParenthesisFormat = DigitFormat | RequireParenthesis, // 0x00000050
      Any = AllowHexPrefix | AllowDashes | AllowBraces | AllowParenthesis, // 0x0000000F
    }

    private enum GuidParseThrowStyle
    {
      None,
      All,
      AllButOverflow,
    }

    private enum ParseFailureKind
    {
      None,
      ArgumentNull,
      Format,
      FormatWithParameter,
      NativeException,
      FormatWithInnerException,
    }

    private struct GuidResult
    {
      internal Guid parsedGuid;
      internal Guid.GuidParseThrowStyle throwStyle;
      internal Guid.ParseFailureKind m_failure;
      internal string m_failureMessageID;
      internal object m_failureMessageFormatArgument;
      internal string m_failureArgumentName;
      internal Exception m_innerException;

      internal void Init(Guid.GuidParseThrowStyle canThrow)
      {
        this.parsedGuid = Guid.Empty;
        this.throwStyle = canThrow;
      }

      internal void SetFailure(Exception nativeException)
      {
        this.m_failure = Guid.ParseFailureKind.NativeException;
        this.m_innerException = nativeException;
      }

      internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID) => this.SetFailure(failure, failureMessageID, (object) null, (string) null, (Exception) null);

      internal void SetFailure(
        Guid.ParseFailureKind failure,
        string failureMessageID,
        object failureMessageFormatArgument)
      {
        this.SetFailure(failure, failureMessageID, failureMessageFormatArgument, (string) null, (Exception) null);
      }

      internal void SetFailure(
        Guid.ParseFailureKind failure,
        string failureMessageID,
        object failureMessageFormatArgument,
        string failureArgumentName,
        Exception innerException)
      {
        this.m_failure = failure;
        this.m_failureMessageID = failureMessageID;
        this.m_failureMessageFormatArgument = failureMessageFormatArgument;
        this.m_failureArgumentName = failureArgumentName;
        this.m_innerException = innerException;
        if (this.throwStyle != Guid.GuidParseThrowStyle.None)
          throw this.GetGuidParseException();
      }

      internal Exception GetGuidParseException()
      {
        switch (this.m_failure)
        {
          case Guid.ParseFailureKind.ArgumentNull:
            return (Exception) new ArgumentNullException(this.m_failureArgumentName, Environment.GetResourceString(this.m_failureMessageID));
          case Guid.ParseFailureKind.Format:
            return (Exception) new FormatException(Environment.GetResourceString(this.m_failureMessageID));
          case Guid.ParseFailureKind.FormatWithParameter:
            return (Exception) new FormatException(Environment.GetResourceString(this.m_failureMessageID, this.m_failureMessageFormatArgument));
          case Guid.ParseFailureKind.NativeException:
            return this.m_innerException;
          case Guid.ParseFailureKind.FormatWithInnerException:
            return (Exception) new FormatException(Environment.GetResourceString(this.m_failureMessageID), this.m_innerException);
          default:
            return (Exception) new FormatException(Environment.GetResourceString("Format_GuidUnrecognized"));
        }
      }
    }
  }
}
