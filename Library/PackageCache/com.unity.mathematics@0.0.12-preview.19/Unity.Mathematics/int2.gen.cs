// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(int2.DebuggerProxy))]
    [System.Serializable]
    public partial struct int2 : System.IEquatable<int2>, IFormattable
    {
        public int x;
        public int y;

        /// <summary>int2 zero value.</summary>
        public static readonly int2 zero = new int2(0,   0);


        /// <summary>Constructs a int2 vector from two int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int x, int y)
        { 
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a int2 vector from an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int2 xy)
        { 
            this.x = xy.x;
            this.y = xy.y;
        }

        /// <summary>Constructs a int2 vector from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>Constructs a int2 vector from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(bool v)
        {
            this.x = v ? 1 : 0;
            this.y = v ? 1 : 0;
        }

        /// <summary>Constructs a int2 vector from a bool2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(bool2 v)
        {
            this.x = v.x ? 1 : 0;
            this.y = v.y ? 1 : 0;
        }

        /// <summary>Constructs a int2 vector from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(uint v)
        {
            this.x = (int)v;
            this.y = (int)v;
        }

        /// <summary>Constructs a int2 vector from a uint2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(uint2 v)
        {
            this.x = (int)v.x;
            this.y = (int)v.y;
        }

        /// <summary>Constructs a int2 vector from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(float v)
        {
            this.x = (int)v;
            this.y = (int)v;
        }

        /// <summary>Constructs a int2 vector from a float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(float2 v)
        {
            this.x = (int)v.x;
            this.y = (int)v.y;
        }

        /// <summary>Constructs a int2 vector from a single double value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(double v)
        {
            this.x = (int)v;
            this.y = (int)v;
        }

        /// <summary>Constructs a int2 vector from a double2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(double2 v)
        {
            this.x = (int)v.x;
            this.y = (int)v.y;
        }


        /// <summary>Implicitly converts a single int value to a int2 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(int v) { return new int2(v); }

        /// <summary>Explicitly converts a single bool value to a int2 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(bool v) { return new int2(v); }

        /// <summary>Explicitly converts a bool2 vector to a int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(bool2 v) { return new int2(v); }

        /// <summary>Explicitly converts a single uint value to a int2 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(uint v) { return new int2(v); }

        /// <summary>Explicitly converts a uint2 vector to a int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(uint2 v) { return new int2(v); }

        /// <summary>Explicitly converts a single float value to a int2 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(float v) { return new int2(v); }

        /// <summary>Explicitly converts a float2 vector to a int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(float2 v) { return new int2(v); }

        /// <summary>Explicitly converts a single double value to a int2 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(double v) { return new int2(v); }

        /// <summary>Explicitly converts a double2 vector to a int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(double2 v) { return new int2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator * (int2 lhs, int2 rhs) { return new int2 (lhs.x * rhs.x, lhs.y * rhs.y); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator * (int2 lhs, int rhs) { return new int2 (lhs.x * rhs, lhs.y * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator * (int lhs, int2 rhs) { return new int2 (lhs * rhs.x, lhs * rhs.y); }


        /// <summary>Returns the result of a componentwise addition operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int2 lhs, int2 rhs) { return new int2 (lhs.x + rhs.x, lhs.y + rhs.y); }

        /// <summary>Returns the result of a componentwise addition operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int2 lhs, int rhs) { return new int2 (lhs.x + rhs, lhs.y + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int lhs, int2 rhs) { return new int2 (lhs + rhs.x, lhs + rhs.y); }


        /// <summary>Returns the result of a componentwise subtraction operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int2 lhs, int2 rhs) { return new int2 (lhs.x - rhs.x, lhs.y - rhs.y); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int2 lhs, int rhs) { return new int2 (lhs.x - rhs, lhs.y - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int lhs, int2 rhs) { return new int2 (lhs - rhs.x, lhs - rhs.y); }


        /// <summary>Returns the result of a componentwise division operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator / (int2 lhs, int2 rhs) { return new int2 (lhs.x / rhs.x, lhs.y / rhs.y); }

        /// <summary>Returns the result of a componentwise division operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator / (int2 lhs, int rhs) { return new int2 (lhs.x / rhs, lhs.y / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator / (int lhs, int2 rhs) { return new int2 (lhs / rhs.x, lhs / rhs.y); }


        /// <summary>Returns the result of a componentwise modulus operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator % (int2 lhs, int2 rhs) { return new int2 (lhs.x % rhs.x, lhs.y % rhs.y); }

        /// <summary>Returns the result of a componentwise modulus operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator % (int2 lhs, int rhs) { return new int2 (lhs.x % rhs, lhs.y % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator % (int lhs, int2 rhs) { return new int2 (lhs % rhs.x, lhs % rhs.y); }


        /// <summary>Returns the result of a componentwise increment operation on an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ++ (int2 val) { return new int2 (++val.x, ++val.y); }


        /// <summary>Returns the result of a componentwise decrement operation on an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator -- (int2 val) { return new int2 (--val.x, --val.y); }


        /// <summary>Returns the result of a componentwise less than operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (int2 lhs, int2 rhs) { return new bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }

        /// <summary>Returns the result of a componentwise less than operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (int2 lhs, int rhs) { return new bool2 (lhs.x < rhs, lhs.y < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (int lhs, int2 rhs) { return new bool2 (lhs < rhs.x, lhs < rhs.y); }


        /// <summary>Returns the result of a componentwise less or equal operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (int2 lhs, int2 rhs) { return new bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (int2 lhs, int rhs) { return new bool2 (lhs.x <= rhs, lhs.y <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (int lhs, int2 rhs) { return new bool2 (lhs <= rhs.x, lhs <= rhs.y); }


        /// <summary>Returns the result of a componentwise greater than operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (int2 lhs, int2 rhs) { return new bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }

        /// <summary>Returns the result of a componentwise greater than operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (int2 lhs, int rhs) { return new bool2 (lhs.x > rhs, lhs.y > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (int lhs, int2 rhs) { return new bool2 (lhs > rhs.x, lhs > rhs.y); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (int2 lhs, int2 rhs) { return new bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (int2 lhs, int rhs) { return new bool2 (lhs.x >= rhs, lhs.y >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (int lhs, int2 rhs) { return new bool2 (lhs >= rhs.x, lhs >= rhs.y); }


        /// <summary>Returns the result of a componentwise unary minus operation on an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int2 val) { return new int2 (-val.x, -val.y); }


        /// <summary>Returns the result of a componentwise unary plus operation on an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int2 val) { return new int2 (+val.x, +val.y); }


        /// <summary>Returns the result of a componentwise left shift operation on an int2 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator << (int2 x, int n) { return new int2 (x.x << n, x.y << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an int2 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator >> (int2 x, int n) { return new int2 (x.x >> n, x.y >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (int2 lhs, int2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }

        /// <summary>Returns the result of a componentwise equality operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (int2 lhs, int rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (int lhs, int2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }


        /// <summary>Returns the result of a componentwise not equal operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (int2 lhs, int2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }

        /// <summary>Returns the result of a componentwise not equal operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (int2 lhs, int rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (int lhs, int2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ~ (int2 val) { return new int2 (~val.x, ~val.y); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator & (int2 lhs, int2 rhs) { return new int2 (lhs.x & rhs.x, lhs.y & rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator & (int2 lhs, int rhs) { return new int2 (lhs.x & rhs, lhs.y & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator & (int lhs, int2 rhs) { return new int2 (lhs & rhs.x, lhs & rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator | (int2 lhs, int2 rhs) { return new int2 (lhs.x | rhs.x, lhs.y | rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator | (int2 lhs, int rhs) { return new int2 (lhs.x | rhs, lhs.y | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator | (int lhs, int2 rhs) { return new int2 (lhs | rhs.x, lhs | rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^ (int2 lhs, int2 rhs) { return new int2 (lhs.x ^ rhs.x, lhs.y ^ rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^ (int2 lhs, int rhs) { return new int2 (lhs.x ^ rhs, lhs.y ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^ (int lhs, int2 rhs) { return new int2 (lhs ^ rhs.x, lhs ^ rhs.y); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(y, y); }
        }



        /// <summary>Returns the int element at a specified index.</summary>
        unsafe public int this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int2* array = &this) { return ((int*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the int2 is equal to a given int2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(int2 rhs) { return x == rhs.x && y == rhs.y; }

        /// <summary>Returns true if the int2 is equal to a given int2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((int2)o); }


        /// <summary>Returns a hash code for the int2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the int2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int2({0}, {1})", x, y);
        }

        /// <summary>Returns a string representation of the int2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int2({0}, {1})", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public int x;
            public int y;
            public DebuggerProxy(int2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a int2 vector constructed from two int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(int x, int y) { return new int2(x, y); }

        /// <summary>Returns a int2 vector constructed from an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(int2 xy) { return new int2(xy); }

        /// <summary>Returns a int2 vector constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(int v) { return new int2(v); }

        /// <summary>Returns a int2 vector constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(bool v) { return new int2(v); }

        /// <summary>Return a int2 vector constructed from a bool2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(bool2 v) { return new int2(v); }

        /// <summary>Returns a int2 vector constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(uint v) { return new int2(v); }

        /// <summary>Return a int2 vector constructed from a uint2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(uint2 v) { return new int2(v); }

        /// <summary>Returns a int2 vector constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(float v) { return new int2(v); }

        /// <summary>Return a int2 vector constructed from a float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(float2 v) { return new int2(v); }

        /// <summary>Returns a int2 vector constructed from a single double value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(double v) { return new int2(v); }

        /// <summary>Return a int2 vector constructed from a double2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(double2 v) { return new int2(v); }

        /// <summary>Returns a uint hash code of a int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int2 v)
        {
            return csum(asuint(v) * uint2(0x5F17300Du, 0x670D6809u)) + 0x7AF32C49u;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a int2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(int2 v)
        {
            return (asuint(v) * uint2(0xAE131389u, 0x5D1B165Bu)) + 0x87096CD7u;
        }

        /// <summary>Returns the result of specified shuffling of the components from two int2 vectors into an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int shuffle(int2 a, int2 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two int2 vectors into an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 shuffle(int2 a, int2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return int2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two int2 vectors into an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 shuffle(int2 a, int2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return int3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two int2 vectors into an int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 shuffle(int2 a, int2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return int4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int select_shuffle_component(int2 a, int2 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }

    }
}
