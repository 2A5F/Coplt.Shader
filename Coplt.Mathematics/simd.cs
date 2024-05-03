#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.Wasm;
using System.Runtime.Intrinsics.X86;
using X86 = System.Runtime.Intrinsics.X86;

namespace Coplt.Mathematics;

public static partial class simd
{
    #region Round

    [MethodImpl(256 | 512)]
    public static Vector64<float> Round(Vector64<float> x)
    {
        if (Sse41.IsSupported)
        {
            return Sse41.RoundToNearestInteger(x.ToVector128()).GetLower();
        }
        if (AdvSimd.IsSupported)
        {
            return AdvSimd.RoundToNearest(x);
        }
        if (PackedSimd.IsSupported)
        {
            return PackedSimd.RoundToNearest(x.ToVector128()).GetLower();
        }
        return Vector64.Create(
            MathF.Round(x.GetElement(0)),
            MathF.Round(x.GetElement(1))
        );
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Round(Vector128<float> x)
    {
        if (Sse41.IsSupported)
        {
            return Sse41.RoundToNearestInteger(x);
        }
        if (AdvSimd.IsSupported)
        {
            return AdvSimd.RoundToNearest(x);
        }
        if (PackedSimd.IsSupported)
        {
            return PackedSimd.RoundToNearest(x);
        }
        return Vector128.Create(
            MathF.Round(x.GetElement(0)),
            MathF.Round(x.GetElement(1)),
            MathF.Round(x.GetElement(2)),
            MathF.Round(x.GetElement(3))
        );
    }

    [MethodImpl(256 | 512)]
    public static Vector128<double> Round(Vector128<double> x)
    {
        if (Sse41.IsSupported)
        {
            return Sse41.RoundToNearestInteger(x);
        }
        if (AdvSimd.Arm64.IsSupported)
        {
            return AdvSimd.Arm64.RoundToNearest(x);
        }
        if (PackedSimd.IsSupported)
        {
            return PackedSimd.RoundToNearest(x);
        }
        return Vector128.Create(
            Math.Round(x.GetElement(0)),
            Math.Round(x.GetElement(1))
        );
    }

    [MethodImpl(256 | 512)]
    public static Vector256<double> Round(Vector256<double> x)
    {
        if (Avx.IsSupported)
        {
            return Avx.RoundToNearestInteger(x);
        }
        if (AdvSimd.Arm64.IsSupported)
        {
            return Vector256.Create(
                AdvSimd.Arm64.RoundToNearest(x.GetLower()),
                AdvSimd.Arm64.RoundToNearest(x.GetUpper())
            );
        }
        if (PackedSimd.IsSupported)
        {
            return Vector256.Create(
                PackedSimd.RoundToNearest(x.GetLower()),
                PackedSimd.RoundToNearest(x.GetUpper())
            );
        }
        return Vector256.Create(
            Math.Round(x.GetElement(0)),
            Math.Round(x.GetElement(1)),
            Math.Round(x.GetElement(2)),
            Math.Round(x.GetElement(3))
        );
    }

    #endregion

    #region Truncate

    [MethodImpl(256 | 512)]
    public static Vector64<float> Truncate(Vector64<float> x)
    {
        if (Sse41.IsSupported)
        {
            return Sse41.RoundToZero(x.ToVector128()).GetLower();
        }
        if (AdvSimd.IsSupported)
        {
            return AdvSimd.RoundToZero(x);
        }
        if (PackedSimd.IsSupported)
        {
            return PackedSimd.Truncate(x.ToVector128()).GetLower();
        }
        return Vector64.Create(
            MathF.Truncate(x.GetElement(0)),
            MathF.Truncate(x.GetElement(1))
        );
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Truncate(Vector128<float> x)
    {
        if (Sse41.IsSupported)
        {
            return Sse41.RoundToZero(x);
        }
        if (AdvSimd.IsSupported)
        {
            return AdvSimd.RoundToZero(x);
        }
        if (PackedSimd.IsSupported)
        {
            return PackedSimd.Truncate(x);
        }
        return Vector128.Create(
            MathF.Truncate(x.GetElement(0)),
            MathF.Truncate(x.GetElement(1)),
            MathF.Truncate(x.GetElement(2)),
            MathF.Truncate(x.GetElement(3))
        );
    }

    [MethodImpl(256 | 512)]
    public static Vector128<double> Truncate(Vector128<double> x)
    {
        if (Sse41.IsSupported)
        {
            return Sse41.RoundToZero(x);
        }
        if (AdvSimd.Arm64.IsSupported)
        {
            return AdvSimd.Arm64.RoundToZero(x);
        }
        if (PackedSimd.IsSupported)
        {
            return PackedSimd.Truncate(x);
        }
        return Vector128.Create(
            Math.Truncate(x.GetElement(0)),
            Math.Truncate(x.GetElement(1))
        );
    }

    [MethodImpl(256 | 512)]
    public static Vector256<double> Truncate(Vector256<double> x)
    {
        if (Avx.IsSupported)
        {
            return Avx.RoundToZero(x);
        }
        if (AdvSimd.Arm64.IsSupported)
        {
            return Vector256.Create(
                AdvSimd.Arm64.RoundToZero(x.GetLower()),
                AdvSimd.Arm64.RoundToZero(x.GetUpper())
            );
        }
        if (PackedSimd.IsSupported)
        {
            return Vector256.Create(
                PackedSimd.Truncate(x.GetLower()),
                PackedSimd.Truncate(x.GetUpper())
            );
        }
        return Vector256.Create(
            Math.Truncate(x.GetElement(0)),
            Math.Truncate(x.GetElement(1)),
            Math.Truncate(x.GetElement(2)),
            Math.Truncate(x.GetElement(3))
        );
    }

    #endregion

    #region Sign

    [MethodImpl(256 | 512)]
    public static Vector64<T> SignInt<T>(Vector64<T> v)
    {
        var pos = Vector64.GreaterThan(v, default) & Vector64<T>.One;
        var neg = Vector64.LessThan(v, default) & -Vector64<T>.One;
        return pos | neg;
    }

    [MethodImpl(256 | 512)]
    public static Vector64<T> SignUInt<T>(Vector64<T> v)
    {
        return Vector64.GreaterThan(v, default) & Vector64<T>.One;
    }

    [MethodImpl(256 | 512)]
    public static Vector64<T> SignFloat<T>(Vector64<T> v)
    {
        var a = v & -Vector64<T>.Zero | Vector64<T>.One;
        var c = Vector64.Equals(v, default);
        return Vector64.AndNot(a, c);
    }

    [MethodImpl(256 | 512)]
    public static unsafe Vector128<T> SignInt<T>(Vector128<T> v)
    {
        var pos = Vector128.GreaterThan(v, default) & Vector128<T>.One;
        var neg = Vector128.LessThan(v, default) & -Vector128<T>.One;
        return pos | neg;
    }

    [MethodImpl(256 | 512)]
    public static unsafe Vector128<T> SignUInt<T>(Vector128<T> v)
    {
        return Vector128.GreaterThan(v, default) & Vector128<T>.One;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<T> SignFloat<T>(Vector128<T> v)
    {
        var a = v & -Vector128<T>.Zero | Vector128<T>.One;
        var c = Vector128.Equals(v, default);
        return Vector128.AndNot(a, c);
    }

    [MethodImpl(256 | 512)]
    public static unsafe Vector256<T> SignInt<T>(Vector256<T> v)
    {
        var pos = Vector256.GreaterThan(v, default) & Vector256<T>.One;
        var neg = Vector256.LessThan(v, default) & -Vector256<T>.One;
        return pos | neg;
    }

    [MethodImpl(256 | 512)]
    public static unsafe Vector256<T> SignUInt<T>(Vector256<T> v)
    {
        return Vector256.GreaterThan(v, default) & Vector256<T>.One;
    }

    [MethodImpl(256 | 512)]
    public static Vector256<T> SignFloat<T>(Vector256<T> v)
    {
        var a = v & -Vector256<T>.Zero | Vector256<T>.One;
        var c = Vector256.Equals(v, default);
        return Vector256.AndNot(a, c);
    }

    #endregion

    #region Fma

    [MethodImpl(256 | 512)]
    public static Vector64<float> Fma(Vector64<float> a, Vector64<float> b, Vector64<float> c)
    {
        if (X86.Fma.IsSupported)
        {
            return X86.Fma.MultiplyAdd(a.ToVector128(), b.ToVector128(), c.ToVector128()).GetLower();
        }
        if (AdvSimd.IsSupported)
        {
            return AdvSimd.FusedMultiplyAdd(c, a, b);
        }
        return a * b + c;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Fma(Vector128<float> a, Vector128<float> b, Vector128<float> c)
    {
        if (X86.Fma.IsSupported)
        {
            return X86.Fma.MultiplyAdd(a, b, c);
        }
        if (AdvSimd.IsSupported)
        {
            return AdvSimd.FusedMultiplyAdd(c, a, b);
        }
        return a * b + c;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<double> Fma(Vector128<double> a, Vector128<double> b, Vector128<double> c)
    {
        if (X86.Fma.IsSupported)
        {
            return X86.Fma.MultiplyAdd(a, b, c);
        }
        return a * b + c;
    }

    [MethodImpl(256 | 512)]
    public static Vector256<float> Fma(Vector256<float> a, Vector256<float> b, Vector256<float> c)
    {
        if (X86.Fma.IsSupported)
        {
            return X86.Fma.MultiplyAdd(a, b, c);
        }
        if (AdvSimd.IsSupported)
        {
            return Vector256.Create(
                AdvSimd.FusedMultiplyAdd(c.GetLower(), a.GetLower(), b.GetLower()),
                AdvSimd.FusedMultiplyAdd(c.GetUpper(), a.GetUpper(), b.GetUpper())
            );
        }
        return a * b + c;
    }

    [MethodImpl(256 | 512)]
    public static Vector256<double> Fma(Vector256<double> a, Vector256<double> b, Vector256<double> c)
    {
        if (X86.Fma.IsSupported)
        {
            return X86.Fma.MultiplyAdd(a, b, c);
        }
        return a * b + c;
    }

    #endregion

    #region IsInfinity

    [MethodImpl(256 | 512)]
    public static Vector64<int> IsInfinity(Vector64<float> f)
    {
        var bits = f.AsInt32();
        return Vector64.Equals(bits & Vector64.Create(int.MaxValue), Vector64.Create(0x7F800000));
    }

    [MethodImpl(256 | 512)]
    public static Vector128<int> IsInfinity(Vector128<float> f)
    {
        var bits = f.AsInt32();
        return Vector128.Equals(bits & Vector128.Create(int.MaxValue), Vector128.Create(0x7F800000));
    }

    [MethodImpl(256 | 512)]
    public static Vector128<long> IsInfinity(Vector128<double> f)
    {
        var bits = f.AsInt64();
        return Vector128.Equals(bits & Vector128.Create(long.MaxValue), Vector128.Create(0x7FF0000000000000L));
    }

    [MethodImpl(256 | 512)]
    public static Vector256<long> IsInfinity(Vector256<double> f)
    {
        var bits = f.AsInt64();
        return Vector256.Equals(bits & Vector256.Create(long.MaxValue), Vector256.Create(0x7FF0000000000000L));
    }

    #endregion

    #region Log

    [MethodImpl(256 | 512)]
    public static Vector64<float> Log(Vector64<float> d)
    {
        if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated)
        {
            return simd_log_float.Log(d.ToVector128()).GetLower();
        }
        return simd_log_float.Log(d);
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Log(Vector128<float> d) => simd_log_float.Log(d);

    [MethodImpl(256 | 512)]
    public static Vector128<double> Log(Vector128<double> d)
    {
        // todo
        return Vector128.Create(d.GetElement(0).log(), d.GetElement(1).log());
    }

    [MethodImpl(256 | 512)]
    public static Vector256<double> Log(Vector256<double> d)
    {
        // todo
        return Vector256.Create(d.GetElement(0).log(), d.GetElement(1).log(), d.GetElement(2).log(), d.GetElement(3).log());
    }

    #endregion
}

#endif
