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
    private static Vector64<int> LogBp1(Vector64<float> d)
    {
        var m = Vector64.LessThan(d, Vector64.Create(5.421010862427522E-20f));
        var r = Vector64.ConditionalSelect(m, 1.8446744073709552E19f * d, d);
        var q = (r.AsInt32() >>> 23) & Vector64.Create(0xff);
        q -= Vector64.ConditionalSelect(m.AsInt32(), Vector64.Create(64 + 0x7e), Vector64.Create(0x7e));
        return q;
    }

    [MethodImpl(256 | 512)]
    private static Vector64<float> Ldexp(Vector64<float> x, Vector64<int> q)
    {
        var m = q >> 31;
        m = (((m + q) >> 6) - m) << 4;
        var t = q - (m << 2);
        m += Vector64.Create(0x7f);
        m = Vector64.GreaterThan(m, default) & m;
        var n = Vector64.GreaterThan(m, Vector64.Create(0xff));
        m = Vector64.AndNot(m, n) | (n & Vector64.Create(0xff));
        var u = (m << 23).AsSingle();
        var r = x * u * u * u * u;
        u = ((t + Vector64.Create(0x7f)) << 23).AsSingle();
        return r * u;
    }

    [MethodImpl(256 | 512)]
    public static Vector64<float> Log(Vector64<float> d)
    {
        var x = d * 0.707106781186547524f;
        var e = LogBp1(x);
        var m = Ldexp(d, -e);
        var r = x;

        x = (-Vector64<float>.One + m) / (Vector64<float>.One + m);
        var x2 = x * x;

        var t = Vector64.Create(0.2371599674224853515625f);
        t = simd.Fma(t, x2, Vector64.Create(0.285279005765914916992188f));
        t = simd.Fma(t, x2, Vector64.Create(0.400005519390106201171875f));
        t = simd.Fma(t, x2, Vector64.Create(0.666666567325592041015625f));
        t = simd.Fma(t, x2, Vector64.Create(2.0f));

        x = simd.Fma(x, t, Vector64.Create(0.693147180559945286226764f) * Vector64.ConvertToSingle(e));
        x = Vector64.ConditionalSelect(
            Vector64.Equals(r, Vector64.Create(float.PositiveInfinity)),
            Vector64.Create(float.PositiveInfinity),
            x
        );

        x = Vector64.GreaterThan(default, r) | x;
        x = Vector64.ConditionalSelect(
            Vector64.Equals(r, default),
            Vector64.Create(float.NegativeInfinity),
            x
        );

        return x;
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
    public static Vector64<float> LogFast2(Vector64<float> a)
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
    private static Vector128<int> LogBp1(Vector128<float> d)
    {
        var m = Vector128.LessThan(d, Vector128.Create(5.421010862427522E-20f));
        var r = Vector128.ConditionalSelect(m, 1.8446744073709552E19f * d, d);
        var q = (r.AsInt32() >>> 23) & Vector128.Create(0xff);
        q -= Vector128.ConditionalSelect(m.AsInt32(), Vector128.Create(64 + 0x7e), Vector128.Create(0x7e));
        return q;
    }

    [MethodImpl(256 | 512)]
    private static Vector128<float> Ldexp(Vector128<float> x, Vector128<int> q)
    {
        var m = q >> 31;
        m = (((m + q) >> 6) - m) << 4;
        var t = q - (m << 2);
        m += Vector128.Create(0x7f);
        m = Vector128.GreaterThan(m, default) & m;
        var n = Vector128.GreaterThan(m, Vector128.Create(0xff));
        m = Vector128.AndNot(m, n) | (n & Vector128.Create(0xff));
        var u = (m << 23).AsSingle();
        var r = x * u * u * u * u;
        u = ((t + Vector128.Create(0x7f)) << 23).AsSingle();
        return r * u;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Log(Vector128<float> d)
    {
        var x = d * 0.707106781186547524f;
        var e = LogBp1(x);
        var m = Ldexp(d, -e);
        var r = x;

        x = (-Vector128<float>.One + m) / (Vector128<float>.One + m);
        var x2 = x * x;

        var t = Vector128.Create(0.2371599674224853515625f);
        t = simd.Fma(t, x2, Vector128.Create(0.285279005765914916992188f));
        t = simd.Fma(t, x2, Vector128.Create(0.400005519390106201171875f));
        t = simd.Fma(t, x2, Vector128.Create(0.666666567325592041015625f));
        t = simd.Fma(t, x2, Vector128.Create(2.0f));

        x = simd.Fma(x, t, Vector128.Create(0.693147180559945286226764f) * Vector128.ConvertToSingle(e));
        x = Vector128.ConditionalSelect(
            Vector128.Equals(r, Vector128.Create(float.PositiveInfinity)),
            Vector128.Create(float.PositiveInfinity),
            x
        );

        x = Vector128.GreaterThan(default, r) | x;
        x = Vector128.ConditionalSelect(
            Vector128.Equals(r, default),
            Vector128.Create(float.NegativeInfinity),
            x
        );

        return x;
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
    public static Vector128<float> LogFast2(Vector128<float> a)
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
