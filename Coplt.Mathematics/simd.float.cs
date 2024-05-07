﻿#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.Wasm;
using System.Runtime.Intrinsics.X86;

namespace Coplt.Mathematics;

// log fast : https://stackoverflow.com/questions/39821367/very-fast-approximate-logarithm-natural-log-function-in-c
// log fast2 : https://stackoverflow.com/questions/9411823/fast-log2float-x-implementation-c

public static partial class simd_float
{
    #region Mod v64

    [MethodImpl(256 | 512)]
    public static Vector64<float> Mod(Vector64<float> x, Vector64<float> y)
    {
        var div = x / y;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, y, x);
    }

    [MethodImpl(256 | 512)]
    public static Vector64<float> Mod(Vector64<float> x, float y)
    {
        var div = x / y;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector64.Create(y), x);
    }

    #endregion

    #region Mod v128

    [MethodImpl(256 | 512)]
    public static Vector128<float> Mod(Vector128<float> x, Vector128<float> y)
    {
        var div = x / y;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, y, x);
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Mod(Vector128<float> x, float y)
    {
        var div = x / y;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector128.Create(y), x);
    }

    #endregion

    #region Log v64

    [MethodImpl(256 | 512)]
    public static Vector64<float> Log(Vector64<float> a) => Log2(a) * math.F_Log2;

    [MethodImpl(256 | 512)]
    public static Vector64<float> Log10(Vector64<float> a) => Log2(a) * (math.F_Log2 / math.F_Log10);

    [MethodImpl(256 | 512)]
    public static Vector64<float> Log2(Vector64<float> a)
    {
        var xl = Vector64.Max(a, Vector64<float>.Zero).AsInt32();
        var mantissa = (xl >>> 23) - Vector64.Create(0x7F);
        var r = Vector64.ConvertToSingle(mantissa);

        xl = (xl & Vector64.Create(0x7FFFFF)) | Vector64.Create(0x7F << 23);

        var d = (xl.AsSingle() | Vector64<float>.One) * Vector64.Create(2.0f / 3.0f);

        #region Approx

        // A Taylor Series approximation of ln(x) that relies on the identity that ln(x) = 2*atan((x-1)/(x+1)).
        d = (d - Vector64<float>.One) / (d + Vector64<float>.One);
        var sq = d * d;

        var rx = simd.Fma(sq, Vector64.Create(0.2371599674224853515625f), Vector64.Create(0.285279005765914916992188f));
        rx = simd.Fma(rx, sq, Vector64.Create(0.400005519390106201171875f));
        rx = simd.Fma(rx, sq, Vector64.Create(0.666666567325592041015625f));
        rx = simd.Fma(rx, sq, Vector64.Create(2.0f));

        d *= rx;

        #endregion

        r += simd.Fma(d, Vector64.Create(1.4426950408889634f), Vector64.Create(0.58496250072115619f));

        r = Vector64.ConditionalSelect(
            Vector64.GreaterThan(a, Vector64<float>.Zero),
            r, Vector64.Create(float.NaN)
        );
        r = Vector64.ConditionalSelect(
            Vector64.Equals(a, Vector64.Create(float.PositiveInfinity)),
            Vector64.Create(float.PositiveInfinity), r
        );
        r = Vector64.ConditionalSelect(
            Vector64.Equals(a, Vector64<float>.Zero),
            Vector64.Create(float.NegativeInfinity), r
        );

        return r;
    }

    /// <summary>
    /// natural log on [0x1.f7a5ecp-127, 0x1.fffffep127]. Maximum relative error 9.4529e-5
    /// </summary>
    [MethodImpl(256 | 512)]
    public static Vector64<float> LogFast(Vector64<float> a)
    {
        var e = (a.AsInt32() - Vector64.Create(0x3f2aaaab)) & Vector64.Create(0xff800000).AsInt32();
        var m = (a.AsInt32() - e).AsSingle();
        var i = Vector64.ConvertToSingle(e) * 1.19209290e-7f; // 0x1.0p-23
        /* m in [2/3, 4/3] */
        var f = m - Vector64<float>.One;
        var s = f * f;
        /* Compute log1p(f) for f in [-1/3, 1/3] */
        var r = simd.Fma(Vector64.Create(0.230836749f), f, Vector64.Create(-0.279208571f)); // 0x1.d8c0f0p-3, -0x1.1de8dap-2
        var t = simd.Fma(Vector64.Create(0.331826031f), f, Vector64.Create(-0.498910338f)); // 0x1.53ca34p-2, -0x1.fee25ap-2
        r = simd.Fma(r, s, t);
        r = simd.Fma(r, s, f);
        r = simd.Fma(i, Vector64.Create(0.693147182f), r); // 0x1.62e430p-1 // log(2) 
        return r;
    }

    [MethodImpl(256 | 512)]
    public static Vector64<float> LogFastFast(Vector64<float> a)
    {
        var x = a.AsInt32();
        var log2 = Vector64.ConvertToSingle(((x >> 23) & Vector64.Create(255)) - Vector64.Create(128));
        x &= Vector64.Create(-2139095041); // ~(255 << 23)
        x += Vector64.Create(1065353216); // 127 << 23
        log2 += simd.Fma(
            simd.Fma(Vector64.Create(-0.34484843f), x.AsSingle(), Vector64.Create(2.02466578f)),
            x.AsSingle(), Vector64.Create(-0.67487759f)
        );
        return log2 * 0.69314718f;
    }

    #endregion

    #region Log v128

    [MethodImpl(256 | 512)]
    public static Vector128<float> Log(Vector128<float> a) => Log2(a) * math.F_Log2;

    [MethodImpl(256 | 512)]
    public static Vector128<float> Log10(Vector128<float> a) => Log2(a) * (math.F_Log2 / math.F_Log10);

    [MethodImpl(256 | 512)]
    public static Vector128<float> Log2(Vector128<float> a)
    {
        var xl = Vector128.Max(a, Vector128<float>.Zero).AsInt32();
        var mantissa = (xl >>> 23) - Vector128.Create(0x7F);
        var r = Vector128.ConvertToSingle(mantissa);

        xl = (xl & Vector128.Create(0x7FFFFF)) | Vector128.Create(0x7F << 23);

        var d = (xl.AsSingle() | Vector128<float>.One) * Vector128.Create(2.0f / 3.0f);

        #region Approx

        // A Taylor Series approximation of ln(x) that relies on the identity that ln(x) = 2*atan((x-1)/(x+1)).
        d = (d - Vector128<float>.One) / (d + Vector128<float>.One);
        var sq = d * d;

        var rx = simd.Fma(sq, Vector128.Create(0.2371599674224853515625f), Vector128.Create(0.285279005765914916992188f));
        rx = simd.Fma(rx, sq, Vector128.Create(0.400005519390106201171875f));
        rx = simd.Fma(rx, sq, Vector128.Create(0.666666567325592041015625f));
        rx = simd.Fma(rx, sq, Vector128.Create(2.0f));

        d *= rx;

        #endregion

        r += simd.Fma(d, Vector128.Create(1.4426950408889634f), Vector128.Create(0.58496250072115619f));

        r = Vector128.ConditionalSelect(
            Vector128.GreaterThan(a, Vector128<float>.Zero),
            r, Vector128.Create(float.NaN)
        );
        r = Vector128.ConditionalSelect(
            Vector128.Equals(a, Vector128.Create(float.PositiveInfinity)),
            Vector128.Create(float.PositiveInfinity), r
        );
        r = Vector128.ConditionalSelect(
            Vector128.Equals(a, Vector128<float>.Zero),
            Vector128.Create(float.NegativeInfinity), r
        );

        return r;
    }

    /// <summary>
    /// natural log on [0x1.f7a5ecp-127, 0x1.fffffep127]. Maximum relative error 9.4529e-5
    /// </summary>
    [MethodImpl(256 | 512)]
    public static Vector128<float> LogFast(Vector128<float> a)
    {
        var e = (a.AsInt32() - Vector128.Create(0x3f2aaaab)) & Vector128.Create(0xff800000).AsInt32();
        var m = (a.AsInt32() - e).AsSingle();
        var i = Vector128.ConvertToSingle(e) * 1.19209290e-7f; // 0x1.0p-23
        /* m in [2/3, 4/3] */
        var f = m - Vector128<float>.One;
        var s = f * f;
        /* Compute log1p(f) for f in [-1/3, 1/3] */
        var r = simd.Fma(Vector128.Create(0.230836749f), f, Vector128.Create(-0.279208571f)); // 0x1.d8c0f0p-3, -0x1.1de8dap-2
        var t = simd.Fma(Vector128.Create(0.331826031f), f, Vector128.Create(-0.498910338f)); // 0x1.53ca34p-2, -0x1.fee25ap-2
        r = simd.Fma(r, s, t);
        r = simd.Fma(r, s, f);
        r = simd.Fma(i, Vector128.Create(0.693147182f), r); // 0x1.62e430p-1 // log(2) 
        return r;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> LogFastFast(Vector128<float> a)
    {
        var x = a.AsInt32();
        var log2 = Vector128.ConvertToSingle(((x >> 23) & Vector128.Create(255)) - Vector128.Create(128));
        x &= Vector128.Create(-2139095041); // ~(255 << 23)
        x += Vector128.Create(1065353216); // 127 << 23
        log2 += simd.Fma(
            simd.Fma(Vector128.Create(-0.34484843f), x.AsSingle(), Vector128.Create(2.02466578f)),
            x.AsSingle(), Vector128.Create(-0.67487759f)
        );
        return log2 * 0.69314718f;
    }

    #endregion

    #region Exp v64

    [MethodImpl(256 | 512)]
    public static Vector64<float> Exp(Vector64<float> x) => Exp2(x * math.F_1_Div_Log2);

    [MethodImpl(256 | 512)]
    public static Vector64<float> Exp10(Vector64<float> x) => Exp(x * 2.302585092994045684f);

    [MethodImpl(256 | 512)]
    public static Vector64<float> Exp2(Vector64<float> x)
    {
        var e = Vector64.GreaterThanOrEqual(x, Vector64.Create(88.3762626647949f)) & Vector64.Create(float.PositiveInfinity);
        e += simd.Ne(x, x);

        var xx = Vector64.Max(
            Vector64.Min(x, Vector64.Create(81.0f * math.F_1_Div_Log2)),
            Vector64.Create(-81.0f * math.F_1_Div_Log2)
        );

        var fx = simd.Round(xx);

        xx -= fx;
        var r = simd.Fma(xx, Vector64.Create(1.530610536076361E-05f), Vector64.Create(0.000154631026827329f));
        r = simd.Fma(r, xx, Vector64.Create(0.0013333465742372899f));
        r = simd.Fma(r, xx, Vector64.Create(0.00961804886829518f));
        r = simd.Fma(r, xx, Vector64.Create(0.05550410925060949f));
        r = simd.Fma(r, xx, Vector64.Create(0.240226509999339f));
        r = simd.Fma(r, xx, Vector64.Create(0.6931471805500692f));
        r = simd.Fma(r, xx, Vector64.Create(1.0f));

        fx = ((Vector64.ConvertToInt32(fx) + Vector64.Create(127)) << 23).AsSingle();

        r = simd.Fma(r, fx, e);
        r = Vector64.AndNot(r, Vector64.Equals(x, Vector64.Create(float.NegativeInfinity)));

        return r;
    }

    #endregion

    #region Exp v128

    [MethodImpl(256 | 512)]
    public static Vector128<float> Exp(Vector128<float> x) => Exp2(x * math.F_1_Div_Log2);

    [MethodImpl(256 | 512)]
    public static Vector128<float> Exp10(Vector128<float> x) => Exp(x * 2.302585092994045684f);

    [MethodImpl(256 | 512)]
    public static Vector128<float> Exp2(Vector128<float> x)
    {
        var e = Vector128.GreaterThanOrEqual(x, Vector128.Create(89f)) & Vector128.Create(float.PositiveInfinity);
        e += simd.Ne(x, x);

        var xx = Vector128.Max(
            Vector128.Min(x, Vector128.Create(81.0f * math.F_1_Div_Log2)),
            Vector128.Create(-81.0f * math.F_1_Div_Log2)
        );

        var fx = simd.Round(xx);

        xx -= fx;
        var r = simd.Fma(xx, Vector128.Create(1.530610536076361E-05f), Vector128.Create(0.000154631026827329f));
        r = simd.Fma(r, xx, Vector128.Create(0.0013333465742372899f));
        r = simd.Fma(r, xx, Vector128.Create(0.00961804886829518f));
        r = simd.Fma(r, xx, Vector128.Create(0.05550410925060949f));
        r = simd.Fma(r, xx, Vector128.Create(0.240226509999339f));
        r = simd.Fma(r, xx, Vector128.Create(0.6931471805500692f));
        r = simd.Fma(r, xx, Vector128.Create(1.0f));

        fx = ((Vector128.ConvertToInt32(fx) + Vector128.Create(127)) << 23).AsSingle();

        r = simd.Fma(r, fx, e);
        r = Vector128.AndNot(r, Vector128.Equals(x, Vector128.Create(float.NegativeInfinity)));

        return r;
    }

    #endregion

    #region Pow v64

    [MethodImpl(256 | 512)]
    public static Vector64<float> Pow(Vector64<float> a, Vector64<float> b)
    {
        var sig = Vector64.LessThan(a, default)
                  & simd.Ne(Mod(b, Vector64.Create(2.0f)), default)
                  & Vector64.Create(0x8000_0000).AsSingle();
        var r = Exp2(Log2(Vector64.Abs(a)) * b);
        return r | sig;
    }

    [MethodImpl(256 | 512)]
    public static Vector64<float> Pow(Vector64<float> a, float b) => Pow(a, Vector64.Create(b));

    #endregion

    #region Pow v128

    [MethodImpl(256 | 512)]
    public static Vector128<float> Pow(Vector128<float> a, Vector128<float> b)
    {
        var sig = Vector128.LessThan(a, default)
                  & simd.Ne(Mod(b, Vector128.Create(2.0f)), default)
                  & Vector128.Create(0x8000_0000).AsSingle();
        var r = Exp2(Log2(Vector128.Abs(a)) * b);
        return r | sig;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Pow(Vector128<float> a, float b) => Pow(a, Vector128.Create(b));

    #endregion
}
#endif
