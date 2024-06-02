namespace Coplt.Mathematics;

public static partial class BitOps
{
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
}
