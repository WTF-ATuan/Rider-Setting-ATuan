// Decompiled with JetBrains decompiler
// Type: System.Attribute
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 48827A05-C015-4B4B-ADA3-2EAF5C10D8B0
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll

using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace System
{
  /// <summary>代表自訂屬性的基底類別。</summary>
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
  [ClassInterface(ClassInterfaceType.None)]
  [ComDefaultInterface(typeof (_Attribute))]
  [ComVisible(true)]
  [__DynamicallyInvokable]
  [Serializable]
  public abstract class Attribute : _Attribute
  {
    private static Attribute[] InternalGetCustomAttributes(
      PropertyInfo element,
      Type type,
      bool inherit)
    {
      Attribute[] customAttributes1 = (Attribute[]) element.GetCustomAttributes(type, inherit);
      if (!inherit)
        return customAttributes1;
      Dictionary<Type, AttributeUsageAttribute> types = new Dictionary<Type, AttributeUsageAttribute>(11);
      List<Attribute> attributeList = new List<Attribute>();
      Attribute.CopyToArrayList(attributeList, customAttributes1, types);
      Type[] indexParameterTypes = Attribute.GetIndexParameterTypes(element);
      for (PropertyInfo parentDefinition = Attribute.GetParentDefinition(element, indexParameterTypes); parentDefinition != (PropertyInfo) null; parentDefinition = Attribute.GetParentDefinition(parentDefinition, indexParameterTypes))
      {
        Attribute[] customAttributes2 = Attribute.GetCustomAttributes((MemberInfo) parentDefinition, type, false);
        Attribute.AddAttributesToList(attributeList, customAttributes2, types);
      }
      Array attributeArrayHelper = (Array) Attribute.CreateAttributeArrayHelper(type, attributeList.Count);
      Array.Copy((Array) attributeList.ToArray(), 0, attributeArrayHelper, 0, attributeList.Count);
      return (Attribute[]) attributeArrayHelper;
    }

    private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit)
    {
      if (element.IsDefined(attributeType, inherit))
        return true;
      if (inherit && Attribute.InternalGetAttributeUsage(attributeType).Inherited)
      {
        Type[] indexParameterTypes = Attribute.GetIndexParameterTypes(element);
        for (PropertyInfo parentDefinition = Attribute.GetParentDefinition(element, indexParameterTypes); parentDefinition != (PropertyInfo) null; parentDefinition = Attribute.GetParentDefinition(parentDefinition, indexParameterTypes))
        {
          if (parentDefinition.IsDefined(attributeType, false))
            return true;
        }
      }
      return false;
    }

    private static PropertyInfo GetParentDefinition(
      PropertyInfo property,
      Type[] propertyParameters)
    {
      MethodInfo methodInfo = property.GetGetMethod(true);
      if (methodInfo == (MethodInfo) null)
        methodInfo = property.GetSetMethod(true);
      RuntimeMethodInfo runtimeMethodInfo = methodInfo as RuntimeMethodInfo;
      if ((MethodInfo) runtimeMethodInfo != (MethodInfo) null)
      {
        RuntimeMethodInfo parentDefinition = runtimeMethodInfo.GetParentDefinition();
        if ((MethodInfo) parentDefinition != (MethodInfo) null)
          return parentDefinition.DeclaringType.GetProperty(property.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, property.PropertyType, propertyParameters, (ParameterModifier[]) null);
      }
      return (PropertyInfo) null;
    }

    private static Attribute[] InternalGetCustomAttributes(
      EventInfo element,
      Type type,
      bool inherit)
    {
      Attribute[] customAttributes1 = (Attribute[]) element.GetCustomAttributes(type, inherit);
      if (!inherit)
        return customAttributes1;
      Dictionary<Type, AttributeUsageAttribute> types = new Dictionary<Type, AttributeUsageAttribute>(11);
      List<Attribute> attributeList = new List<Attribute>();
      Attribute.CopyToArrayList(attributeList, customAttributes1, types);
      for (EventInfo parentDefinition = Attribute.GetParentDefinition(element); parentDefinition != (EventInfo) null; parentDefinition = Attribute.GetParentDefinition(parentDefinition))
      {
        Attribute[] customAttributes2 = Attribute.GetCustomAttributes((MemberInfo) parentDefinition, type, false);
        Attribute.AddAttributesToList(attributeList, customAttributes2, types);
      }
      Array attributeArrayHelper = (Array) Attribute.CreateAttributeArrayHelper(type, attributeList.Count);
      Array.Copy((Array) attributeList.ToArray(), 0, attributeArrayHelper, 0, attributeList.Count);
      return (Attribute[]) attributeArrayHelper;
    }

    private static EventInfo GetParentDefinition(EventInfo ev)
    {
      RuntimeMethodInfo addMethod = ev.GetAddMethod(true) as RuntimeMethodInfo;
      if ((MethodInfo) addMethod != (MethodInfo) null)
      {
        RuntimeMethodInfo parentDefinition = addMethod.GetParentDefinition();
        if ((MethodInfo) parentDefinition != (MethodInfo) null)
          return parentDefinition.DeclaringType.GetEvent(ev.Name);
      }
      return (EventInfo) null;
    }

    private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit)
    {
      if (element.IsDefined(attributeType, inherit))
        return true;
      if (inherit && Attribute.InternalGetAttributeUsage(attributeType).Inherited)
      {
        for (EventInfo parentDefinition = Attribute.GetParentDefinition(element); parentDefinition != (EventInfo) null; parentDefinition = Attribute.GetParentDefinition(parentDefinition))
        {
          if (parentDefinition.IsDefined(attributeType, false))
            return true;
        }
      }
      return false;
    }

    private static ParameterInfo GetParentDefinition(ParameterInfo param)
    {
      RuntimeMethodInfo member = param.Member as RuntimeMethodInfo;
      if ((MethodInfo) member != (MethodInfo) null)
      {
        RuntimeMethodInfo parentDefinition = member.GetParentDefinition();
        if ((MethodInfo) parentDefinition != (MethodInfo) null)
          return parentDefinition.GetParameters()[param.Position];
      }
      return (ParameterInfo) null;
    }

    private static Attribute[] InternalParamGetCustomAttributes(
      ParameterInfo param,
      Type type,
      bool inherit)
    {
      List<Type> typeList = new List<Type>();
      if (type == (Type) null)
        type = typeof (Attribute);
      object[] customAttributes1 = param.GetCustomAttributes(type, false);
      for (int index = 0; index < customAttributes1.Length; ++index)
      {
        Type type1 = customAttributes1[index].GetType();
        if (!Attribute.InternalGetAttributeUsage(type1).AllowMultiple)
          typeList.Add(type1);
      }
      Attribute[] attributeArray1 = customAttributes1.Length != 0 ? (Attribute[]) customAttributes1 : Attribute.CreateAttributeArrayHelper(type, 0);
      if (param.Member.DeclaringType == (Type) null || !inherit)
        return attributeArray1;
      for (ParameterInfo parentDefinition = Attribute.GetParentDefinition(param); parentDefinition != null; parentDefinition = Attribute.GetParentDefinition(parentDefinition))
      {
        object[] customAttributes2 = parentDefinition.GetCustomAttributes(type, false);
        int elementCount = 0;
        for (int index = 0; index < customAttributes2.Length; ++index)
        {
          Type type1 = customAttributes2[index].GetType();
          AttributeUsageAttribute attributeUsage = Attribute.InternalGetAttributeUsage(type1);
          if (attributeUsage.Inherited && !typeList.Contains(type1))
          {
            if (!attributeUsage.AllowMultiple)
              typeList.Add(type1);
            ++elementCount;
          }
          else
            customAttributes2[index] = (object) null;
        }
        Attribute[] attributeArrayHelper = Attribute.CreateAttributeArrayHelper(type, elementCount);
        int index1 = 0;
        for (int index2 = 0; index2 < customAttributes2.Length; ++index2)
        {
          if (customAttributes2[index2] != null)
          {
            attributeArrayHelper[index1] = (Attribute) customAttributes2[index2];
            ++index1;
          }
        }
        Attribute[] attributeArray2 = attributeArray1;
        attributeArray1 = Attribute.CreateAttributeArrayHelper(type, attributeArray2.Length + index1);
        Array.Copy((Array) attributeArray2, (Array) attributeArray1, attributeArray2.Length);
        int length = attributeArray2.Length;
        for (int index2 = 0; index2 < attributeArrayHelper.Length; ++index2)
          attributeArray1[length + index2] = attributeArrayHelper[index2];
      }
      return attributeArray1;
    }

    private static bool InternalParamIsDefined(ParameterInfo param, Type type, bool inherit)
    {
      if (param.IsDefined(type, false))
        return true;
      if (param.Member.DeclaringType == (Type) null || !inherit)
        return false;
      for (ParameterInfo parentDefinition = Attribute.GetParentDefinition(param); parentDefinition != null; parentDefinition = Attribute.GetParentDefinition(parentDefinition))
      {
        object[] customAttributes = parentDefinition.GetCustomAttributes(type, false);
        for (int index = 0; index < customAttributes.Length; ++index)
        {
          AttributeUsageAttribute attributeUsage = Attribute.InternalGetAttributeUsage(customAttributes[index].GetType());
          if (customAttributes[index] is Attribute && attributeUsage.Inherited)
            return true;
        }
      }
      return false;
    }

    private static void CopyToArrayList(
      List<Attribute> attributeList,
      Attribute[] attributes,
      Dictionary<Type, AttributeUsageAttribute> types)
    {
      for (int index = 0; index < attributes.Length; ++index)
      {
        attributeList.Add(attributes[index]);
        Type type = attributes[index].GetType();
        if (!types.ContainsKey(type))
          types[type] = Attribute.InternalGetAttributeUsage(type);
      }
    }

    private static Type[] GetIndexParameterTypes(PropertyInfo element)
    {
      ParameterInfo[] indexParameters = element.GetIndexParameters();
      if (indexParameters.Length == 0)
        return Array.Empty<Type>();
      Type[] typeArray = new Type[indexParameters.Length];
      for (int index = 0; index < indexParameters.Length; ++index)
        typeArray[index] = indexParameters[index].ParameterType;
      return typeArray;
    }

    private static void AddAttributesToList(
      List<Attribute> attributeList,
      Attribute[] attributes,
      Dictionary<Type, AttributeUsageAttribute> types)
    {
      for (int index = 0; index < attributes.Length; ++index)
      {
        Type type = attributes[index].GetType();
        AttributeUsageAttribute attributeUsageAttribute = (AttributeUsageAttribute) null;
        types.TryGetValue(type, out attributeUsageAttribute);
        if (attributeUsageAttribute == null)
        {
          attributeUsageAttribute = Attribute.InternalGetAttributeUsage(type);
          types[type] = attributeUsageAttribute;
          if (attributeUsageAttribute.Inherited)
            attributeList.Add(attributes[index]);
        }
        else if (attributeUsageAttribute.Inherited && attributeUsageAttribute.AllowMultiple)
          attributeList.Add(attributes[index]);
      }
    }

    private static AttributeUsageAttribute InternalGetAttributeUsage(
      Type type)
    {
      object[] customAttributes = type.GetCustomAttributes(typeof (AttributeUsageAttribute), false);
      if (customAttributes.Length == 1)
        return (AttributeUsageAttribute) customAttributes[0];
      if (customAttributes.Length == 0)
        return AttributeUsageAttribute.Default;
      throw new FormatException(Environment.GetResourceString("Format_AttributeUsage", (object) type));
    }

    [SecuritySafeCritical]
    private static Attribute[] CreateAttributeArrayHelper(
      Type elementType,
      int elementCount)
    {
      return (Attribute[]) Array.UnsafeCreateInstance(elementType, elementCount);
    }

    /// <summary>
    ///   擷取自訂屬性套用至類型成員的陣列。
    ///    參數會指定搜尋的成員和自訂屬性的型別。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自<see cref="T:System.Reflection.MemberInfo" />類別，描述類別的建構函式、 事件、 欄位、 方法或屬性的成員。
    /// </param>
    /// <param name="type">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <returns>
    ///   <see cref="T:System.Attribute" />陣列，其中包含之自訂屬性的型別<paramref name="type" />套用至<paramref name="element" />，或這類自訂屬性不存在則為空白陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="type" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="type" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   <paramref name="element" />不是建構函式、 方法、 屬性、 事件、 類型或欄位。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute[] GetCustomAttributes(MemberInfo element, Type type) => Attribute.GetCustomAttributes(element, type, true);

    /// <summary>
    ///   擷取自訂屬性套用至類型成員的陣列。
    ///    參數會指定成員、 自訂屬性來搜尋，以及是否要搜尋之成員的上階的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自<see cref="T:System.Reflection.MemberInfo" />類別，描述類別的建構函式、 事件、 欄位、 方法或屬性的成員。
    /// </param>
    /// <param name="type">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <param name="inherit">
    ///   如果<see langword="true" />，也會搜尋指定的上階<paramref name="element" />自訂屬性。
    /// </param>
    /// <returns>
    ///   <see cref="T:System.Attribute" />陣列，其中包含之自訂屬性的型別<paramref name="type" />套用至<paramref name="element" />，或這類自訂屬性不存在則為空白陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="type" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="type" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   <paramref name="element" />不是建構函式、 方法、 屬性、 事件、 類型或欄位。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute[] GetCustomAttributes(
      MemberInfo element,
      Type type,
      bool inherit)
    {
      if (element == (MemberInfo) null)
        throw new ArgumentNullException(nameof (element));
      if (type == (Type) null)
        throw new ArgumentNullException(nameof (type));
      if (!type.IsSubclassOf(typeof (Attribute)) && type != typeof (Attribute))
        throw new ArgumentException(Environment.GetResourceString("Argument_MustHaveAttributeBaseClass"));
      switch (element.MemberType)
      {
        case MemberTypes.Event:
          return Attribute.InternalGetCustomAttributes((EventInfo) element, type, inherit);
        case MemberTypes.Property:
          return Attribute.InternalGetCustomAttributes((PropertyInfo) element, type, inherit);
        default:
          return element.GetCustomAttributes(type, inherit) as Attribute[];
      }
    }

    /// <summary>
    ///   擷取自訂屬性套用至類型成員的陣列。
    ///    參數指定的成員。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自<see cref="T:System.Reflection.MemberInfo" />類別，描述類別的建構函式、 事件、 欄位、 方法或屬性的成員。
    /// </param>
    /// <returns>
    ///   包含套用至 <paramref name="element" /> 之自訂屬性的 <see cref="T:System.Attribute" /> 陣列；如果不存在這類自訂屬性，則為空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   <paramref name="element" />不是建構函式、 方法、 屬性、 事件、 類型或欄位。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute[] GetCustomAttributes(MemberInfo element) => Attribute.GetCustomAttributes(element, true);

    /// <summary>
    ///   擷取自訂屬性套用至類型成員的陣列。
    ///    參數會指定成員、 自訂屬性來搜尋，以及是否要搜尋之成員的上階的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自<see cref="T:System.Reflection.MemberInfo" />類別，描述類別的建構函式、 事件、 欄位、 方法或屬性的成員。
    /// </param>
    /// <param name="inherit">
    ///   如果<see langword="true" />，也會搜尋指定的上階<paramref name="element" />自訂屬性。
    /// </param>
    /// <returns>
    ///   包含套用至 <paramref name="element" /> 之自訂屬性的 <see cref="T:System.Attribute" /> 陣列；如果不存在這類自訂屬性，則為空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   <paramref name="element" />不是建構函式、 方法、 屬性、 事件、 類型或欄位。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit)
    {
      if (element == (MemberInfo) null)
        throw new ArgumentNullException(nameof (element));
      switch (element.MemberType)
      {
        case MemberTypes.Event:
          return Attribute.InternalGetCustomAttributes((EventInfo) element, typeof (Attribute), inherit);
        case MemberTypes.Property:
          return Attribute.InternalGetCustomAttributes((PropertyInfo) element, typeof (Attribute), inherit);
        default:
          return element.GetCustomAttributes(typeof (Attribute), inherit) as Attribute[];
      }
    }

    /// <summary>
    ///   決定是否要將任何自訂的屬性套用至型別的成員。
    ///    指定要搜尋的成員和自訂屬性的型別參數。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.MemberInfo" /> 類別，描述類別的建構函式、 事件、 欄位、 方法、 類型或屬性的成員。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <returns>
    ///   <see langword="true" /> 如果自訂屬性的型別 <paramref name="attributeType" /> 套用至 <paramref name="element" />，否則 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   <paramref name="element" /> 不是建構函式、 方法、 屬性、 事件、 類型或欄位。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool IsDefined(MemberInfo element, Type attributeType) => Attribute.IsDefined(element, attributeType, true);

    /// <summary>
    ///   判斷是否任何自訂屬性套用至型別的成員。
    ///    參數會指定成員、 自訂屬性來搜尋，以及是否要搜尋之成員的上階的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自<see cref="T:System.Reflection.MemberInfo" />類別，描述類別的建構函式、 事件、 欄位、 方法、 類型或屬性的成員。
    /// </param>
    /// <param name="attributeType">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <param name="inherit">
    ///   如果<see langword="true" />，也會搜尋指定的上階<paramref name="element" />自訂屬性。
    /// </param>
    /// <returns>
    ///   <see langword="true" />如果自訂屬性的型別<paramref name="attributeType" />套用至<paramref name="element" />，否則<see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   <paramref name="element" />不是建構函式、 方法、 屬性、 事件、 類型或欄位。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit)
    {
      if (element == (MemberInfo) null)
        throw new ArgumentNullException(nameof (element));
      if (attributeType == (Type) null)
        throw new ArgumentNullException(nameof (attributeType));
      if (!attributeType.IsSubclassOf(typeof (Attribute)) && attributeType != typeof (Attribute))
        throw new ArgumentException(Environment.GetResourceString("Argument_MustHaveAttributeBaseClass"));
      switch (element.MemberType)
      {
        case MemberTypes.Event:
          return Attribute.InternalIsDefined((EventInfo) element, attributeType, inherit);
        case MemberTypes.Property:
          return Attribute.InternalIsDefined((PropertyInfo) element, attributeType, inherit);
        default:
          return element.IsDefined(attributeType, inherit);
      }
    }

    /// <summary>
    ///   擷取套用至類型成員的自訂屬性。
    ///    參數會指定搜尋的成員和自訂屬性的型別。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自<see cref="T:System.Reflection.MemberInfo" />類別，描述類別的建構函式、 事件、 欄位、 方法或屬性的成員。
    /// </param>
    /// <param name="attributeType">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <returns>
    ///   類型的單一的自訂屬性的參考<paramref name="attributeType" />套用至<paramref name="element" />，或<see langword="null" />如果沒有這類屬性。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   <paramref name="element" />不是建構函式、 方法、 屬性、 事件、 類型或欄位。
    /// </exception>
    /// <exception cref="T:System.Reflection.AmbiguousMatchException">
    ///   找不到一個以上的要求的屬性。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) => Attribute.GetCustomAttribute(element, attributeType, true);

    /// <summary>
    ///   擷取套用至類型成員的自訂屬性。
    ///    參數會指定成員、 自訂屬性來搜尋，以及是否要搜尋之成員的上階的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自<see cref="T:System.Reflection.MemberInfo" />類別，描述類別的建構函式、 事件、 欄位、 方法或屬性的成員。
    /// </param>
    /// <param name="attributeType">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <param name="inherit">
    ///   如果<see langword="true" />，也會搜尋指定的上階<paramref name="element" />自訂屬性。
    /// </param>
    /// <returns>
    ///   類型的單一的自訂屬性的參考<paramref name="attributeType" />套用至<paramref name="element" />，或<see langword="null" />如果沒有這類屬性。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   <paramref name="element" />不是建構函式、 方法、 屬性、 事件、 類型或欄位。
    /// </exception>
    /// <exception cref="T:System.Reflection.AmbiguousMatchException">
    ///   找不到一個以上的要求的屬性。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute GetCustomAttribute(
      MemberInfo element,
      Type attributeType,
      bool inherit)
    {
      Attribute[] customAttributes = Attribute.GetCustomAttributes(element, attributeType, inherit);
      if (customAttributes == null || customAttributes.Length == 0)
        return (Attribute) null;
      return customAttributes.Length == 1 ? customAttributes[0] : throw new AmbiguousMatchException(Environment.GetResourceString("RFLCT.AmbigCust"));
    }

    /// <summary>
    ///   擷取自訂屬性套用至方法參數的陣列。
    ///    參數會指定方法參數。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自<see cref="T:System.Reflection.ParameterInfo" />類別，描述類別成員的參數。
    /// </param>
    /// <returns>
    ///   包含套用至 <paramref name="element" /> 之自訂屬性的 <see cref="T:System.Attribute" /> 陣列；如果不存在這類自訂屬性，則為空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute[] GetCustomAttributes(ParameterInfo element) => Attribute.GetCustomAttributes(element, true);

    /// <summary>
    ///   擷取自訂屬性套用至方法參數的陣列。
    ///    參數會指定方法參數，以及要搜尋的自訂屬性的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.ParameterInfo" /> 類別，描述類別成員的參數。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <returns>
    ///   <see cref="T:System.Attribute" /> 陣列，其中包含之自訂屬性的型別 <paramref name="attributeType" /> 套用至 <paramref name="element" />, ，或如果沒有這類的自訂屬性存在的空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性的型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute[] GetCustomAttributes(
      ParameterInfo element,
      Type attributeType)
    {
      return Attribute.GetCustomAttributes(element, attributeType, true);
    }

    /// <summary>
    ///   擷取自訂屬性套用至方法參數的陣列。
    ///    參數會指定在方法參數、 要搜尋的自訂屬性，以及是否要搜尋的方法參數的祖系型別。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.ParameterInfo" /> 類別，描述類別成員的參數。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <param name="inherit">
    ///   如果 <see langword="true" />, ，也會搜尋指定的上階 <paramref name="element" /> 自訂屬性。
    /// </param>
    /// <returns>
    ///   <see cref="T:System.Attribute" /> 陣列，其中包含之自訂屬性的型別 <paramref name="attributeType" /> 套用至 <paramref name="element" />, ，或如果沒有這類的自訂屬性存在的空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性的型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute[] GetCustomAttributes(
      ParameterInfo element,
      Type attributeType,
      bool inherit)
    {
      if (element == null)
        throw new ArgumentNullException(nameof (element));
      if (attributeType == (Type) null)
        throw new ArgumentNullException(nameof (attributeType));
      if (!attributeType.IsSubclassOf(typeof (Attribute)) && attributeType != typeof (Attribute))
        throw new ArgumentException(Environment.GetResourceString("Argument_MustHaveAttributeBaseClass"));
      if (element.Member == (MemberInfo) null)
        throw new ArgumentException(Environment.GetResourceString("Argument_InvalidParameterInfo"), nameof (element));
      return element.Member.MemberType == MemberTypes.Method & inherit ? Attribute.InternalParamGetCustomAttributes(element, attributeType, inherit) : element.GetCustomAttributes(attributeType, inherit) as Attribute[];
    }

    /// <summary>
    ///   擷取自訂屬性套用至方法參數的陣列。
    ///    參數會指定方法參數，以及是否要搜尋的方法參數上階。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.ParameterInfo" /> 類別，描述類別成員的參數。
    /// </param>
    /// <param name="inherit">
    ///   如果 <see langword="true" />, ，也會搜尋指定的上階 <paramref name="element" /> 自訂屬性。
    /// </param>
    /// <returns>
    ///   包含套用至 <paramref name="element" /> 之自訂屬性的 <see cref="T:System.Attribute" /> 陣列；如果不存在這類自訂屬性，則為空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentException">
    ///   <see cref="P:System.Reflection.ParameterInfo.Member" /> 屬性 <paramref name="element" /> 是 <see langword="null." /><see langword="" />
    /// </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性的型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit)
    {
      if (element == null)
        throw new ArgumentNullException(nameof (element));
      if (element.Member == (MemberInfo) null)
        throw new ArgumentException(Environment.GetResourceString("Argument_InvalidParameterInfo"), nameof (element));
      return element.Member.MemberType == MemberTypes.Method & inherit ? Attribute.InternalParamGetCustomAttributes(element, (Type) null, inherit) : element.GetCustomAttributes(typeof (Attribute), inherit) as Attribute[];
    }

    /// <summary>
    ///   決定是否將任何自訂屬性套用至方法參數。
    ///    參數會指定方法參數，以及要搜尋的自訂屬性的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.ParameterInfo" /> 類別，描述類別成員的參數。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <returns>
    ///   <see langword="true" /> 如果自訂屬性的型別 <paramref name="attributeType" /> 套用至 <paramref name="element" />，否則 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool IsDefined(ParameterInfo element, Type attributeType) => Attribute.IsDefined(element, attributeType, true);

    /// <summary>
    ///   決定是否將任何自訂屬性套用至方法參數。
    ///    參數會指定在方法參數、 要搜尋的自訂屬性，以及是否要搜尋的方法參數的祖系型別。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.ParameterInfo" /> 類別，描述類別成員的參數。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <param name="inherit">
    ///   如果 <see langword="true" />, ，也會搜尋指定的上階 <paramref name="element" /> 自訂屬性。
    /// </param>
    /// <returns>
    ///   <see langword="true" /> 如果自訂屬性的型別 <paramref name="attributeType" /> 套用至 <paramref name="element" />，否則 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.ExecutionEngineException">
    ///   <paramref name="element" /> 方法、 建構函式或類型不是。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool IsDefined(ParameterInfo element, Type attributeType, bool inherit)
    {
      if (element == null)
        throw new ArgumentNullException(nameof (element));
      if (attributeType == (Type) null)
        throw new ArgumentNullException(nameof (attributeType));
      if (!attributeType.IsSubclassOf(typeof (Attribute)) && attributeType != typeof (Attribute))
        throw new ArgumentException(Environment.GetResourceString("Argument_MustHaveAttributeBaseClass"));
      switch (element.Member.MemberType)
      {
        case MemberTypes.Constructor:
          return element.IsDefined(attributeType, false);
        case MemberTypes.Method:
          return Attribute.InternalParamIsDefined(element, attributeType, inherit);
        case MemberTypes.Property:
          return element.IsDefined(attributeType, false);
        default:
          throw new ArgumentException(Environment.GetResourceString("Argument_InvalidParamInfo"));
      }
    }

    /// <summary>
    ///   擷取套用至方法參數的自訂屬性。
    ///    參數會指定方法參數，以及要搜尋的自訂屬性的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自<see cref="T:System.Reflection.ParameterInfo" />類別，描述類別成員的參數。
    /// </param>
    /// <param name="attributeType">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <returns>
    ///   類型的單一的自訂屬性的參考<paramref name="attributeType" />套用至<paramref name="element" />，或<see langword="null" />如果沒有這類屬性。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.Reflection.AmbiguousMatchException">
    ///   找不到一個以上的要求的屬性。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType) => Attribute.GetCustomAttribute(element, attributeType, true);

    /// <summary>
    ///   擷取套用至方法參數的自訂屬性。
    ///    參數會指定方法參數，輸入来搜尋的自訂屬性，以及是否要搜尋的方法參數的祖系。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自<see cref="T:System.Reflection.ParameterInfo" />類別，描述類別成員的參數。
    /// </param>
    /// <param name="attributeType">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <param name="inherit">
    ///   如果<see langword="true" />，也會搜尋指定的上階<paramref name="element" />自訂屬性。
    /// </param>
    /// <returns>
    ///   類型的單一的自訂屬性的參考<paramref name="attributeType" />套用至<paramref name="element" />，或<see langword="null" />如果沒有這類屬性。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.Reflection.AmbiguousMatchException">
    ///   找不到一個以上的要求的屬性。
    /// </exception>
    /// <exception cref="T:System.TypeLoadException">
    ///   無法載入自訂屬性型別。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute GetCustomAttribute(
      ParameterInfo element,
      Type attributeType,
      bool inherit)
    {
      Attribute[] customAttributes = Attribute.GetCustomAttributes(element, attributeType, inherit);
      if (customAttributes == null || customAttributes.Length == 0)
        return (Attribute) null;
      if (customAttributes.Length == 0)
        return (Attribute) null;
      return customAttributes.Length == 1 ? customAttributes[0] : throw new AmbiguousMatchException(Environment.GetResourceString("RFLCT.AmbigCust"));
    }

    /// <summary>
    ///   擷取自訂屬性套用至模組的陣列。
    ///    參數會指定模組，以及要搜尋的自訂屬性的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.Module" /> 類別，描述可移植執行檔。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <returns>
    ///   <see cref="T:System.Attribute" /> 陣列，其中包含之自訂屬性的型別 <paramref name="attributeType" /> 套用至 <paramref name="element" />, ，或如果沒有這類的自訂屬性存在的空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    public static Attribute[] GetCustomAttributes(Module element, Type attributeType) => Attribute.GetCustomAttributes(element, attributeType, true);

    /// <summary>
    ///   擷取自訂屬性套用至模組的陣列。
    ///    參數會指定模組。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.Module" /> 類別，描述可移植執行檔。
    /// </param>
    /// <returns>
    ///   包含套用至 <paramref name="element" /> 之自訂屬性的 <see cref="T:System.Attribute" /> 陣列；如果不存在這類自訂屬性，則為空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 為 <see langword="null" />。
    /// </exception>
    public static Attribute[] GetCustomAttributes(Module element) => Attribute.GetCustomAttributes(element, true);

    /// <summary>
    ///   擷取自訂屬性套用至模組的陣列。
    ///    參數會指定模組，並忽略的搜尋選項。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.Module" /> 類別，描述可移植執行檔。
    /// </param>
    /// <param name="inherit">這個參數會被忽略，且不影響此方法的作業。</param>
    /// <returns>
    ///   包含套用至 <paramref name="element" /> 之自訂屬性的 <see cref="T:System.Attribute" /> 陣列；如果不存在這類自訂屬性，則為空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    public static Attribute[] GetCustomAttributes(Module element, bool inherit) => !(element == (Module) null) ? (Attribute[]) element.GetCustomAttributes(typeof (Attribute), inherit) : throw new ArgumentNullException(nameof (element));

    /// <summary>
    ///   擷取自訂屬性套用至模組的陣列。
    ///    參數會指定模組、 自訂屬性來搜尋，並忽略的搜尋選項的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.Module" /> 類別，描述可移植執行檔。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <param name="inherit">這個參數會被忽略，且不影響此方法的作業。</param>
    /// <returns>
    ///   <see cref="T:System.Attribute" /> 陣列，其中包含之自訂屬性的型別 <paramref name="attributeType" /> 套用至 <paramref name="element" />, ，或如果沒有這類的自訂屬性存在的空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    public static Attribute[] GetCustomAttributes(
      Module element,
      Type attributeType,
      bool inherit)
    {
      if (element == (Module) null)
        throw new ArgumentNullException(nameof (element));
      if (attributeType == (Type) null)
        throw new ArgumentNullException(nameof (attributeType));
      if (!attributeType.IsSubclassOf(typeof (Attribute)) && attributeType != typeof (Attribute))
        throw new ArgumentException(Environment.GetResourceString("Argument_MustHaveAttributeBaseClass"));
      return (Attribute[]) element.GetCustomAttributes(attributeType, inherit);
    }

    /// <summary>
    ///   決定是否將指定之型別的任何自訂屬性套用至模組。
    ///    參數會指定模組，以及要搜尋的自訂屬性的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.Module" /> 類別，描述可移植執行檔。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <returns>
    ///   <see langword="true" /> 如果自訂屬性的型別 <paramref name="attributeType" /> 套用至 <paramref name="element" />，否則 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    public static bool IsDefined(Module element, Type attributeType) => Attribute.IsDefined(element, attributeType, false);

    /// <summary>
    ///   決定是否將任何自訂屬性套用至模組。
    ///    參數會指定模組、 自訂屬性來搜尋，並忽略的搜尋選項的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.Module" /> 類別，描述可移植執行檔。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <param name="inherit">這個參數會被忽略，且不影響此方法的作業。</param>
    /// <returns>
    ///   <see langword="true" /> 如果自訂屬性的型別 <paramref name="attributeType" /> 套用至 <paramref name="element" />，否則 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    public static bool IsDefined(Module element, Type attributeType, bool inherit)
    {
      if (element == (Module) null)
        throw new ArgumentNullException(nameof (element));
      if (attributeType == (Type) null)
        throw new ArgumentNullException(nameof (attributeType));
      return attributeType.IsSubclassOf(typeof (Attribute)) || !(attributeType != typeof (Attribute)) ? element.IsDefined(attributeType, false) : throw new ArgumentException(Environment.GetResourceString("Argument_MustHaveAttributeBaseClass"));
    }

    /// <summary>
    ///   擷取套用至模組的自訂屬性。
    ///    參數會指定模組，以及要搜尋的自訂屬性的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自 <see cref="T:System.Reflection.Module" /> 類別，描述可移植執行檔。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <returns>
    ///   型別的單一的自訂屬性的參考 <paramref name="attributeType" /> 套用到 <paramref name="element" />, ，或 <see langword="null" /> 如果沒有這類屬性。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.Reflection.AmbiguousMatchException">
    ///   找不到一個以上的要求的屬性。
    /// </exception>
    public static Attribute GetCustomAttribute(Module element, Type attributeType) => Attribute.GetCustomAttribute(element, attributeType, true);

    /// <summary>
    ///   擷取套用至模組的自訂屬性。
    ///    參數會指定模組、 要搜尋的自訂屬性以及略過的搜尋選項的類型。
    /// </summary>
    /// <param name="element">
    ///   物件衍生自<see cref="T:System.Reflection.Module" />類別，描述可移植執行檔。
    /// </param>
    /// <param name="attributeType">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <param name="inherit">這個參數會被忽略，不會影響此方法的作業。</param>
    /// <returns>
    ///   類型的單一的自訂屬性的參考<paramref name="attributeType" />套用至<paramref name="element" />，或<see langword="null" />如果沒有這類屬性。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.Reflection.AmbiguousMatchException">
    ///   找不到一個以上的要求的屬性。
    /// </exception>
    public static Attribute GetCustomAttribute(
      Module element,
      Type attributeType,
      bool inherit)
    {
      Attribute[] customAttributes = Attribute.GetCustomAttributes(element, attributeType, inherit);
      if (customAttributes == null || customAttributes.Length == 0)
        return (Attribute) null;
      return customAttributes.Length == 1 ? customAttributes[0] : throw new AmbiguousMatchException(Environment.GetResourceString("RFLCT.AmbigCust"));
    }

    /// <summary>
    ///   擷取套用至組件的自訂屬性陣列。
    ///    參數會指定組件和自訂屬性的型別來搜尋。
    /// </summary>
    /// <param name="element">
    ///   衍生自 <see cref="T:System.Reflection.Assembly" /> 類別的物件，描述可重複使用的模組集合。
    /// </param>
    /// <param name="attributeType">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <returns>
    ///   <see cref="T:System.Attribute" />陣列，其中包含之自訂屬性的型別<paramref name="attributeType" />套用至<paramref name="element" />，或這類自訂屬性不存在則為空白陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType) => Attribute.GetCustomAttributes(element, attributeType, true);

    /// <summary>
    ///   擷取套用至組件的自訂屬性陣列。
    ///    參數會指定組件、 要搜尋的自訂屬性以及略過的搜尋選項的類型。
    /// </summary>
    /// <param name="element">
    ///   衍生自 <see cref="T:System.Reflection.Assembly" /> 類別的物件，描述可重複使用的模組集合。
    /// </param>
    /// <param name="attributeType">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <param name="inherit">這個參數會被忽略，不會影響此方法的作業。</param>
    /// <returns>
    ///   <see cref="T:System.Attribute" />陣列，其中包含之自訂屬性的型別<paramref name="attributeType" />套用至<paramref name="element" />，或這類自訂屬性不存在則為空白陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    public static Attribute[] GetCustomAttributes(
      Assembly element,
      Type attributeType,
      bool inherit)
    {
      if (element == (Assembly) null)
        throw new ArgumentNullException(nameof (element));
      if (attributeType == (Type) null)
        throw new ArgumentNullException(nameof (attributeType));
      if (!attributeType.IsSubclassOf(typeof (Attribute)) && attributeType != typeof (Attribute))
        throw new ArgumentException(Environment.GetResourceString("Argument_MustHaveAttributeBaseClass"));
      return (Attribute[]) element.GetCustomAttributes(attributeType, inherit);
    }

    /// <summary>
    ///   擷取套用至組件的自訂屬性陣列。
    ///    參數會指定組件。
    /// </summary>
    /// <param name="element">
    ///   衍生自 <see cref="T:System.Reflection.Assembly" /> 類別的物件，描述可重複使用的模組集合。
    /// </param>
    /// <returns>
    ///   包含套用至 <paramref name="element" /> 之自訂屬性的 <see cref="T:System.Attribute" /> 陣列；如果不存在這類自訂屬性，則為空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute[] GetCustomAttributes(Assembly element) => Attribute.GetCustomAttributes(element, true);

    /// <summary>
    ///   擷取套用至組件的自訂屬性陣列。
    ///    參數會指定組件，並忽略的搜尋選項。
    /// </summary>
    /// <param name="element">
    ///   衍生自 <see cref="T:System.Reflection.Assembly" /> 類別的物件，描述可重複使用的模組集合。
    /// </param>
    /// <param name="inherit">這個參數會被忽略，不會影響此方法的作業。</param>
    /// <returns>
    ///   包含套用至 <paramref name="element" /> 之自訂屬性的 <see cref="T:System.Attribute" /> 陣列；如果不存在這類自訂屬性，則為空陣列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    public static Attribute[] GetCustomAttributes(Assembly element, bool inherit) => !(element == (Assembly) null) ? (Attribute[]) element.GetCustomAttributes(typeof (Attribute), inherit) : throw new ArgumentNullException(nameof (element));

    /// <summary>
    ///   判斷是否任何自訂屬性套用至組件。
    ///    參數會指定組件和自訂屬性的型別來搜尋。
    /// </summary>
    /// <param name="element">
    ///   衍生自 <see cref="T:System.Reflection.Assembly" /> 類別的物件，描述可重複使用的模組集合。
    /// </param>
    /// <param name="attributeType">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <returns>
    ///   <see langword="true" />如果自訂屬性的型別<paramref name="attributeType" />套用至<paramref name="element" />，否則<see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool IsDefined(Assembly element, Type attributeType) => Attribute.IsDefined(element, attributeType, true);

    /// <summary>
    ///   決定是否要將任何自訂的屬性套用至組件。
    ///    參數會指定組件、 自訂屬性來搜尋，並忽略的搜尋選項的類型。
    /// </summary>
    /// <param name="element">
    ///   衍生自 <see cref="T:System.Reflection.Assembly" /> 類別的物件，描述可重複使用的模組集合。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <param name="inherit">這個參數會被忽略，且不影響此方法的作業。</param>
    /// <returns>
    ///   <see langword="true" /> 如果自訂屬性的型別 <paramref name="attributeType" /> 套用至 <paramref name="element" />，否則 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    public static bool IsDefined(Assembly element, Type attributeType, bool inherit)
    {
      if (element == (Assembly) null)
        throw new ArgumentNullException(nameof (element));
      if (attributeType == (Type) null)
        throw new ArgumentNullException(nameof (attributeType));
      return attributeType.IsSubclassOf(typeof (Attribute)) || !(attributeType != typeof (Attribute)) ? element.IsDefined(attributeType, false) : throw new ArgumentException(Environment.GetResourceString("Argument_MustHaveAttributeBaseClass"));
    }

    /// <summary>
    ///   擷取套用至指定的組件的自訂屬性。
    ///    參數會指定要搜尋的組件和自訂屬性的型別。
    /// </summary>
    /// <param name="element">
    ///   衍生自 <see cref="T:System.Reflection.Assembly" /> 類別的物件，描述可重複使用的模組集合。
    /// </param>
    /// <param name="attributeType">型別或要搜尋的自訂屬性的基底類型。</param>
    /// <returns>
    ///   類型的單一的自訂屬性的參考<paramref name="attributeType" />套用至<paramref name="element" />，或<see langword="null" />如果沒有這類屬性。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" />不衍生自<see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.Reflection.AmbiguousMatchException">
    ///   找不到一個以上的要求的屬性。
    /// </exception>
    [__DynamicallyInvokable]
    public static Attribute GetCustomAttribute(Assembly element, Type attributeType) => Attribute.GetCustomAttribute(element, attributeType, true);

    /// <summary>
    ///   擷取自訂屬性套用至組件。
    ///    參數會指定組件、 自訂屬性來搜尋，並忽略的搜尋選項的類型。
    /// </summary>
    /// <param name="element">
    ///   衍生自 <see cref="T:System.Reflection.Assembly" /> 類別的物件，描述可重複使用的模組集合。
    /// </param>
    /// <param name="attributeType">型別或基底型別，要搜尋的自訂屬性。</param>
    /// <param name="inherit">這個參數會被忽略，且不影響此方法的作業。</param>
    /// <returns>
    ///   型別的單一的自訂屬性的參考 <paramref name="attributeType" /> 套用到 <paramref name="element" />, ，或 <see langword="null" /> 如果沒有這類屬性。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="element" /> 或 <paramref name="attributeType" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="attributeType" /> 不衍生自 <see cref="T:System.Attribute" />。
    /// </exception>
    /// <exception cref="T:System.Reflection.AmbiguousMatchException">
    ///   找不到一個以上的要求的屬性。
    /// </exception>
    public static Attribute GetCustomAttribute(
      Assembly element,
      Type attributeType,
      bool inherit)
    {
      Attribute[] customAttributes = Attribute.GetCustomAttributes(element, attributeType, inherit);
      if (customAttributes == null || customAttributes.Length == 0)
        return (Attribute) null;
      return customAttributes.Length == 1 ? customAttributes[0] : throw new AmbiguousMatchException(Environment.GetResourceString("RFLCT.AmbigCust"));
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Attribute" /> 類別的新執行個體。
    /// </summary>
    [__DynamicallyInvokable]
    protected Attribute()
    {
    }

    /// <summary>傳回值，這個值指出此執行個體是否與指定的物件相等。</summary>
    /// <param name="obj">
    ///   <see cref="T:System.Object" /> 要與這個執行個體比較或 <see langword="null" />。
    /// </param>
    /// <returns>
    ///   如果 <see langword="true" /> 和這個執行個體具有相同的類型和值，則為 <paramref name="obj" />否則為 <see langword="false" />。
    /// </returns>
    [SecuritySafeCritical]
    [__DynamicallyInvokable]
    public override bool Equals(object obj)
    {
      if (obj == null)
        return false;
      RuntimeType type = (RuntimeType) this.GetType();
      if ((RuntimeType) obj.GetType() != type)
        return false;
      object obj1 = (object) this;
      FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
      for (int index = 0; index < fields.Length; ++index)
      {
        if (!Attribute.AreFieldValuesEqual(((RtFieldInfo) fields[index]).UnsafeGetValue(obj1), ((RtFieldInfo) fields[index]).UnsafeGetValue(obj)))
          return false;
      }
      return true;
    }

    private static bool AreFieldValuesEqual(object thisValue, object thatValue)
    {
      if (thisValue == null && thatValue == null)
        return true;
      if (thisValue == null || thatValue == null)
        return false;
      if (thisValue.GetType().IsArray)
      {
        if (!thisValue.GetType().Equals(thatValue.GetType()))
          return false;
        Array array1 = thisValue as Array;
        Array array2 = thatValue as Array;
        if (array1.Length != array2.Length)
          return false;
        for (int index = 0; index < array1.Length; ++index)
        {
          if (!Attribute.AreFieldValuesEqual(array1.GetValue(index), array2.GetValue(index)))
            return false;
        }
      }
      else if (!thisValue.Equals(thatValue))
        return false;
      return true;
    }

    /// <summary>傳回這個執行個體的雜湊碼。</summary>
    /// <returns>32 位元帶正負號的整數雜湊碼。</returns>
    [SecuritySafeCritical]
    [__DynamicallyInvokable]
    public override int GetHashCode()
    {
      Type type = this.GetType();
      FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
      object obj1 = (object) null;
      for (int index = 0; index < fields.Length; ++index)
      {
        object obj2 = ((RtFieldInfo) fields[index]).UnsafeGetValue((object) this);
        if (obj2 != null && !obj2.GetType().IsArray)
          obj1 = obj2;
        if (obj1 != null)
          break;
      }
      return obj1 != null ? obj1.GetHashCode() : type.GetHashCode();
    }

    /// <summary>
    ///   在衍生類別中實作時，取得這個 <see cref="T:System.Attribute" /> 的唯一識別碼。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.Object" />也就是屬性的唯一識別碼。
    /// </returns>
    public virtual object TypeId => (object) this.GetType();

    /// <summary>當在衍生類別中覆寫時，傳回值，指出這個執行個體是否等於指定的物件。</summary>
    /// <param name="obj">
    ///   <see cref="T:System.Object" />要與這個執行個體的比較<see cref="T:System.Attribute" />。
    /// </param>
    /// <returns>
    ///   <see langword="true" />如果這個執行個體等於<paramref name="obj" />，否則<see langword="false" />。
    /// </returns>
    public virtual bool Match(object obj) => this.Equals(obj);

    /// <summary>在衍生類別中覆寫時，表示這個執行個體的值是衍生類別的預設值。</summary>
    /// <returns>
    ///   如果這個執行個體為預設屬性的類別，則為 <see langword="true" />；否則為 <see langword="false" />。
    /// </returns>
    public virtual bool IsDefaultAttribute() => false;

    void _Attribute.GetTypeInfoCount(out uint pcTInfo) => throw new NotImplementedException();

    void _Attribute.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo) => throw new NotImplementedException();

    void _Attribute.GetIDsOfNames(
      [In] ref Guid riid,
      IntPtr rgszNames,
      uint cNames,
      uint lcid,
      IntPtr rgDispId)
    {
      throw new NotImplementedException();
    }

    void _Attribute.Invoke(
      uint dispIdMember,
      [In] ref Guid riid,
      uint lcid,
      short wFlags,
      IntPtr pDispParams,
      IntPtr pVarResult,
      IntPtr pExcepInfo,
      IntPtr puArgErr)
    {
      throw new NotImplementedException();
    }
  }
}
