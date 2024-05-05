#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.Wasm;
using System.Runtime.Intrinsics.X86;

namespace Coplt.Mathematics;

// log fast : https://stackoverflow.com/questions/39821367/very-fast-approximate-logarithm-natural-log-function-in-c
// log fast2 : https://stackoverflow.com/questions/9411823/fast-log2float-x-implementation-c

public static partial class simd_log_float
{
    #region Log 64

    [MethodImpl(256 | 512)]
    public static Vector64<float> Log(Vector64<float> a) => Log2(a) * 0.6931471805599453094172321214581766f;

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

    #region Log 128

    [MethodImpl(256 | 512)]
    public static Vector128<float> Log(Vector128<float> a) => Log2(a) * 0.6931471805599453094172321214581766f;

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
}
#endif
