// Decompiled with JetBrains decompiler
// Type: System.NullReferenceException
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 8F9A7EA3-47A4-4FFD-AD6C-91B550598CCD
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll

using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
  /// <summary>當嘗試對 Null 物件取值時，所擲回的例外狀況。</summary>
  [ComVisible(true)]
  [__DynamicallyInvokable]
  [Serializable]
  public class NullReferenceException : SystemException
  {
    /// <summary>
    ///   初始化的新執行個體<see cref="T:System.NullReferenceException" />類別，設定<see cref="P:System.Exception.Message" />屬性的新執行個體的系統提供的訊息描述錯誤，例如"值 'null' 找不到物件的執行個體所需的位置。"
    ///    此訊息會考量目前的系統文化特性。
    /// </summary>
    [__DynamicallyInvokable]
    public NullReferenceException()
      : base(Environment.GetResourceString("Arg_NullReferenceException"))
      => this.SetErrorCode(-2147467261);

    /// <summary>
    ///   使用指定的錯誤訊息，初始化 <see cref="T:System.NullReferenceException" /> 類別的新執行個體。
    /// </summary>
    /// <param name="message">
    ///   描述錯誤的 <see cref="T:System.String" />。
    ///   <paramref name="message" /> 的內容必須能讓人了解。
    ///    這個建構函式的呼叫端必須確保這個字串已經被當地語系化 (為了目前系統的文化特性)。
    /// </param>
    [__DynamicallyInvokable]
    public NullReferenceException(string message)
      : base(message)
      => this.SetErrorCode(-2147467261);

    /// <summary>
    ///   使用指定的錯誤訊息以及造成此例外狀況的內部例外狀況的參考，初始化 <see cref="T:System.NullReferenceException" /> 類別的新執行個體。
    /// </summary>
    /// <param name="message">解釋例外狀況原因的錯誤訊息。</param>
    /// <param name="innerException">
    ///   做為目前例外狀況發生原因的例外狀況。
    ///    如果 <paramref name="innerException" /> 參數不是 <see langword="null" />，則目前的例外狀況會在處理內部例外的 <see langword="catch" /> 區塊中引發。
    /// </param>
    [__DynamicallyInvokable]
    public NullReferenceException(string message, Exception innerException)
      : base(message, innerException)
      => this.SetErrorCode(-2147467261);

    /// <summary>
    ///   使用序列化資料，初始化 <see cref="T:System.NullReferenceException" /> 類別的新執行個體。
    /// </summary>
    /// <param name="info">存放序列物件資料的物件。</param>
    /// <param name="context">關於來源或目的端的內容資訊。</param>
    protected NullReferenceException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }
  }
}
