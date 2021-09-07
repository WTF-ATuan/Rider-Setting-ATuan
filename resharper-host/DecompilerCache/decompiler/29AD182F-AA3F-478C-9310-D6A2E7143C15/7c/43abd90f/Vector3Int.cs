// Decompiled with JetBrains decompiler
// Type: UnityEngine.Vector3Int
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Representation of 3D vectors and points using integers.</para>
  /// </summary>
  [UsedByNativeCode]
  public struct Vector3Int : IEquatable<Vector3Int>
  {
    private int m_X;
    private int m_Y;
    private int m_Z;
    private static readonly Vector3Int s_Zero = new Vector3Int(0, 0, 0);
    private static readonly Vector3Int s_One = new Vector3Int(1, 1, 1);
    private static readonly Vector3Int s_Up = new Vector3Int(0, 1, 0);
    private static readonly Vector3Int s_Down = new Vector3Int(0, -1, 0);
    private static readonly Vector3Int s_Left = new Vector3Int(-1, 0, 0);
    private static readonly Vector3Int s_Right = new Vector3Int(1, 0, 0);

    /// <summary>
    ///   <para>X component of the vector.</para>
    /// </summary>
    public int x
    {
      get => this.m_X;
      set => this.m_X = value;
    }

    /// <summary>
    ///   <para>Y component of the vector.</para>
    /// </summary>
    public int y
    {
      get => this.m_Y;
      set => this.m_Y = value;
    }

    /// <summary>
    ///   <para>Z component of the vector.</para>
    /// </summary>
    public int z
    {
      get => this.m_Z;
      set => this.m_Z = value;
    }

    public Vector3Int(int x, int y, int z)
    {
      this.m_X = x;
      this.m_Y = y;
      this.m_Z = z;
    }

    /// <summary>
    ///   <para>Set x, y and z components of an existing Vector3Int.</para>
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    public void Set(int x, int y, int z)
    {
      this.m_X = x;
      this.m_Y = y;
      this.m_Z = z;
    }

    public int this[int index]
    {
      get
      {
        switch (index)
        {
          case 0:
            return this.x;
          case 1:
            return this.y;
          case 2:
            return this.z;
          default:
            throw new IndexOutOfRangeException(UnityString.Format("Invalid Vector3Int index addressed: {0}!", (object) index));
        }
      }
      set
      {
        switch (index)
        {
          case 0:
            this.x = value;
            break;
          case 1:
            this.y = value;
            break;
          case 2:
            this.z = value;
            break;
          default:
            throw new IndexOutOfRangeException(UnityString.Format("Invalid Vector3Int index addressed: {0}!", (object) index));
        }
      }
    }

    /// <summary>
    ///   <para>Returns the length of this vector (Read Only).</para>
    /// </summary>
    public float magnitude => Mathf.Sqrt((float) (this.x * this.x + this.y * this.y + this.z * this.z));

    /// <summary>
    ///   <para>Returns the squared length of this vector (Read Only).</para>
    /// </summary>
    public int sqrMagnitude => this.x * this.x + this.y * this.y + this.z * this.z;

    /// <summary>
    ///   <para>Returns the distance between a and b.</para>
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public static float Distance(Vector3Int a, Vector3Int b) => (a - b).magnitude;

    /// <summary>
    ///   <para>Returns a vector that is made from the smallest components of two vectors.</para>
    /// </summary>
    /// <param name="lhs"></param>
    /// <param name="rhs"></param>
    public static Vector3Int Min(Vector3Int lhs, Vector3Int rhs) => new Vector3Int(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z));

    /// <summary>
    ///   <para>Returns a vector that is made from the largest components of two vectors.</para>
    /// </summary>
    /// <param name="lhs"></param>
    /// <param name="rhs"></param>
    public static Vector3Int Max(Vector3Int lhs, Vector3Int rhs) => new Vector3Int(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z));

    /// <summary>
    ///   <para>Multiplies two vectors component-wise.</para>
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public static Vector3Int Scale(Vector3Int a, Vector3Int b) => new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z);

    /// <summary>
    ///   <para>Multiplies every component of this vector by the same component of scale.</para>
    /// </summary>
    /// <param name="scale"></param>
    public void Scale(Vector3Int scale)
    {
      this.x *= scale.x;
      this.y *= scale.y;
      this.z *= scale.z;
    }

    /// <summary>
    ///   <para>Clamps the Vector3Int to the bounds given by min and max.</para>
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    public void Clamp(Vector3Int min, Vector3Int max)
    {
      this.x = Math.Max(min.x, this.x);
      this.x = Math.Min(max.x, this.x);
      this.y = Math.Max(min.y, this.y);
      this.y = Math.Min(max.y, this.y);
      this.z = Math.Max(min.z, this.z);
      this.z = Math.Min(max.z, this.z);
    }

    public static implicit operator Vector3(Vector3Int v) => new Vector3((float) v.x, (float) v.y, (float) v.z);

    public static explicit operator Vector2Int(Vector3Int v) => new Vector2Int(v.x, v.y);

    /// <summary>
    ///   <para>Converts a  Vector3 to a Vector3Int by doing a Floor to each value.</para>
    /// </summary>
    /// <param name="v"></param>
    public static Vector3Int FloorToInt(Vector3 v) => new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z));

    /// <summary>
    ///   <para>Converts a  Vector3 to a Vector3Int by doing a Ceiling to each value.</para>
    /// </summary>
    /// <param name="v"></param>
    public static Vector3Int CeilToInt(Vector3 v) => new Vector3Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y), Mathf.CeilToInt(v.z));

    /// <summary>
    ///   <para>Converts a  Vector3 to a Vector3Int by doing a Round to each value.</para>
    /// </summary>
    /// <param name="v"></param>
    public static Vector3Int RoundToInt(Vector3 v) => new Vector3Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z));

    public static Vector3Int operator +(Vector3Int a, Vector3Int b) => new Vector3Int(a.x + b.x, a.y + b.y, a.z + b.z);

    public static Vector3Int operator -(Vector3Int a, Vector3Int b) => new Vector3Int(a.x - b.x, a.y - b.y, a.z - b.z);

    public static Vector3Int operator *(Vector3Int a, Vector3Int b) => new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z);

    public static Vector3Int operator -(Vector3Int a) => new Vector3Int(-a.x, -a.y, -a.z);

    public static Vector3Int operator *(Vector3Int a, int b) => new Vector3Int(a.x * b, a.y * b, a.z * b);

    public static Vector3Int operator *(int a, Vector3Int b) => new Vector3Int(a * b.x, a * b.y, a * b.z);

    public static Vector3Int operator /(Vector3Int a, int b) => new Vector3Int(a.x / b, a.y / b, a.z / b);

    public static bool operator ==(Vector3Int lhs, Vector3Int rhs) => lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z;

    public static bool operator !=(Vector3Int lhs, Vector3Int rhs) => !(lhs == rhs);

    /// <summary>
    ///   <para>Returns true if the objects are equal.</para>
    /// </summary>
    /// <param name="other"></param>
    public override bool Equals(object other) => other is Vector3Int other1 && this.Equals(other1);

    public bool Equals(Vector3Int other) => this == other;

    /// <summary>
    ///   <para>Gets the hash code for the Vector3Int.</para>
    /// </summary>
    /// <returns>
    ///   <para>The hash code of the Vector3Int.</para>
    /// </returns>
    public override int GetHashCode()
    {
      int hashCode1 = this.y.GetHashCode();
      int hashCode2 = this.z.GetHashCode();
      return this.x.GetHashCode() ^ hashCode1 << 4 ^ hashCode1 >> 28 ^ hashCode2 >> 4 ^ hashCode2 << 28;
    }

    /// <summary>
    ///   <para>Returns a nicely formatted string for this vector.</para>
    /// </summary>
    /// <param name="format"></param>
    public override string ToString() => UnityString.Format("({0}, {1}, {2})", (object) this.x, (object) this.y, (object) this.z);

    /// <summary>
    ///   <para>Returns a nicely formatted string for this vector.</para>
    /// </summary>
    /// <param name="format"></param>
    public string ToString(string format) => UnityString.Format("({0}, {1}, {2})", (object) this.x.ToString(format), (object) this.y.ToString(format), (object) this.z.ToString(format));

    /// <summary>
    ///   <para>Shorthand for writing Vector3Int (0, 0, 0).</para>
    /// </summary>
    public static Vector3Int zero => Vector3Int.s_Zero;

    /// <summary>
    ///   <para>Shorthand for writing Vector3Int (1, 1, 1).</para>
    /// </summary>
    public static Vector3Int one => Vector3Int.s_One;

    /// <summary>
    ///   <para>Shorthand for writing Vector3Int (0, 1, 0).</para>
    /// </summary>
    public static Vector3Int up => Vector3Int.s_Up;

    /// <summary>
    ///   <para>Shorthand for writing Vector3Int (0, -1, 0).</para>
    /// </summary>
    public static Vector3Int down => Vector3Int.s_Down;

    /// <summary>
    ///   <para>Shorthand for writing Vector3Int (-1, 0, 0).</para>
    /// </summary>
    public static Vector3Int left => Vector3Int.s_Left;

    /// <summary>
    ///   <para>Shorthand for writing Vector3Int (1, 0, 0).</para>
    /// </summary>
    public static Vector3Int right => Vector3Int.s_Right;
  }
}
