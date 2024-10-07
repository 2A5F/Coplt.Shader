namespace Coplt.Mathematics;

internal static partial class BitOps
{
    #region UnsafeAs

    [MethodImpl(256 | 512)]
    public static U UnsafeAs<T, U>(this T v) => Unsafe.As<T, U>(ref v);

    [MethodImpl(256 | 512)]
    public static U BitCast<T, U>(this T v) where T : struct where U : struct
    {
        #if NET8_0_OR_GREATER
        return Unsafe.BitCast<T, U>(v);
        #else
        return v.UnsafeAs<T, U>();
        #endif
    }

    #endregion

    #region Half As

    [MethodImpl(256 | 512)]
    public static ushort AsUInt16(this half v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.HalfToUInt16Bits(v);
        #else
        return Unsafe.As<half, ushort>(ref v);
        #endif
    }
    [MethodImpl(256 | 512)]
    public static short AsInt16(this half v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.HalfToInt16Bits(v);
        #else
        return Unsafe.As<half, short>(ref v);
        #endif
    }
    [MethodImpl(256 | 512)]
    public static half AsHalf(this ushort v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.UInt16BitsToHalf(v);
        #else
        return Unsafe.As<ushort, half>(ref v);
        #endif
    }
    [MethodImpl(256 | 512)]
    public static half AsHalf(this short v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.Int16BitsToHalf(v);
        #else
        return Unsafe.As<short, half>(ref v);
        #endif
    }

    #endregion

    #region Float As

    [MethodImpl(256 | 512)]
    public static uint AsUInt32(this float v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.SingleToUInt32Bits(v);
        #else
        return Unsafe.As<float, uint>(ref v);
        #endif
    }
    [MethodImpl(256 | 512)]
    public static int AsInt16(this float v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.SingleToInt32Bits(v);
        #else
        return Unsafe.As<float, int>(ref v);
        #endif
    }
    [MethodImpl(256 | 512)]
    public static float AsSingle(this uint v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.UInt32BitsToSingle(v);
        #else
        return Unsafe.As<uint, float>(ref v);
        #endif
    }
    [MethodImpl(256 | 512)]
    public static float AsSingle(this int v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.Int32BitsToSingle(v);
        #else
        return Unsafe.As<int, float>(ref v);
        #endif
    }

    #endregion

    #region Double As

    [MethodImpl(256 | 512)]
    public static ulong AsUInt32(this double v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.DoubleToUInt64Bits(v);
        #else
        return Unsafe.As<double, ulong>(ref v);
        #endif
    }
    [MethodImpl(256 | 512)]
    public static long AsInt16(this double v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.DoubleToInt64Bits(v);
        #else
        return Unsafe.As<double, long>(ref v);
        #endif
    }
    [MethodImpl(256 | 512)]
    public static double AsDouble(this ulong v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.UInt64BitsToDouble(v);
        #else
        return Unsafe.As<ulong, double>(ref v);
        #endif
    }
    [MethodImpl(256 | 512)]
    public static double AsDouble(this long v)
    {
        #if NET8_0_OR_GREATER
        return BitConverter.Int64BitsToDouble(v);
        #else
        return Unsafe.As<long, double>(ref v);
        #endif
    }

    #endregion

    #region int Log2

    public static ReadOnlySpan<byte> TrailingZeroCountDeBruijn => new byte[32]
    {
        00, 01, 28, 02, 29, 14, 24, 03,
        30, 22, 20, 15, 25, 17, 04, 08,
        31, 27, 13, 23, 21, 19, 16, 07,
        26, 12, 18, 06, 11, 05, 10, 09
    };

    public static ReadOnlySpan<byte> Log2DeBruijn => new byte[32]
    {
        00, 09, 01, 10, 13, 21, 02, 29,
        11, 14, 16, 18, 22, 25, 03, 30,
        08, 12, 20, 28, 15, 17, 24, 07,
        19, 27, 23, 06, 26, 05, 04, 31
    };

    private static int ReadLog2SoftwareFallback(uint value)
    {
        // uint.MaxValue >> 27 is always in range [0 - 31] so we use Unsafe.AddByteOffset to avoid bounds check
        return Unsafe.AddByteOffset(
            // Using deBruijn sequence, k=2, n=5 (2^5=32) : 0b_0000_0111_1100_0100_1010_1100_1101_1101u
            ref MemoryMarshal.GetReference(Log2DeBruijn),
            // uint|long -> IntPtr cast on 32-bit platforms does expensive overflow checks not needed here
            (IntPtr)(int)((value * 0x07C4ACDDu) >> 27));
    }

    /// <summary>
    /// Returns the integer (floor) log of the specified value, base 2.
    /// Note that by convention, input value 0 returns 0 since Log(0) is undefined.
    /// Does not directly use any hardware intrinsics, nor does it incur branching.
    /// </summary>
    /// <param name="value">The value.</param>
    public static int Log2SoftwareFallback(uint value)
    {
        // No AggressiveInlining due to large method size
        // Has conventional contract 0->0 (Log(0) is undefined)

        // Fill trailing zeros with ones, eg 00010010 becomes 00011111
        value |= value >> 01;
        value |= value >> 02;
        value |= value >> 04;
        value |= value >> 08;
        value |= value >> 16;

        return ReadLog2SoftwareFallback(value);
    }

    #endregion
}
