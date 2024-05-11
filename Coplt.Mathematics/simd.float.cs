#if NET8_0_OR_GREATER
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

    #region Wrap v64

    [MethodImpl(256 | 512)]
    public static Vector64<float> Wrap(Vector64<float> x, Vector64<float> min, Vector64<float> max)
    {
        var add = Vector64.ConditionalSelect(Vector64.GreaterThanOrEqual(x, default), min, max);
        var off = Mod(x, max - min);
        return add + off;
    }

    [MethodImpl(256 | 512)]
    public static Vector64<float> Wrap(Vector64<float> x, float min, float max)
    {
        var add = Vector64.ConditionalSelect(Vector64.GreaterThanOrEqual(x, default), Vector64.Create(min), Vector64.Create(max));
        var off = Mod(x, max - min);
        return add + off;
    }

    [MethodImpl(256 | 512)]
    public static Vector64<float> Wrap0ToPi(Vector64<float> x)
    {
        var add = x + (Vector64.LessThan(x, default) & Vector64.Create(math.F_PI));
        var div = x * math.F_1_Div_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector64.Create(math.F_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector64<float> Wrap0To2Pi(Vector64<float> x)
    {
        var add = x + (Vector64.LessThan(x, default) & Vector64.Create(math.F_2_PI));
        var div = x * math.F_1_Div_2_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector64.Create(math.F_2_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector64<float> Wrap0To4Pi(Vector64<float> x)
    {
        var add = x + (Vector64.LessThan(x, default) & Vector64.Create(math.F_4_PI));
        var div = x * math.F_1_Div_4_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector64.Create(math.F_4_PI), add);
    }

    #endregion

    #region Wrap v128

    [MethodImpl(256 | 512)]
    public static Vector128<float> Wrap(Vector128<float> x, Vector128<float> min, Vector128<float> max)
    {
        var add = Vector128.ConditionalSelect(Vector128.GreaterThanOrEqual(x, default), min, max);
        var off = Mod(x, max - min);
        return add + off;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Wrap(Vector128<float> x, float min, float max)
    {
        var add = Vector128.ConditionalSelect(Vector128.GreaterThanOrEqual(x, default), Vector128.Create(min), Vector128.Create(max));
        var off = Mod(x, max - min);
        return add + off;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Wrap0ToPi(Vector128<float> x)
    {
        var add = x + (Vector128.LessThan(x, default) & Vector128.Create(math.F_PI));
        var div = x * math.F_1_Div_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector128.Create(math.F_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Wrap0To2Pi(Vector128<float> x)
    {
        var add = x + (Vector128.LessThan(x, default) & Vector128.Create(math.F_2_PI));
        var div = x * math.F_1_Div_2_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector128.Create(math.F_2_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Wrap0To4Pi(Vector128<float> x)
    {
        var add = x + (Vector128.LessThan(x, default) & Vector128.Create(math.F_4_PI));
        var div = x * math.F_1_Div_4_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector128.Create(math.F_4_PI), add);
    }

    #endregion

    #region Wrap v256

    [MethodImpl(256 | 512)]
    public static Vector256<float> Wrap0ToPi(Vector256<float> x)
    {
        var add = x + (Vector256.LessThan(x, default) & Vector256.Create(math.F_PI));
        var div = x * math.F_1_Div_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector256.Create(math.F_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector256<float> Wrap0To2Pi(Vector256<float> x)
    {
        var add = x + (Vector256.LessThan(x, default) & Vector256.Create(math.F_2_PI));
        var div = x * math.F_1_Div_2_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector256.Create(math.F_2_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector256<float> Wrap0To4Pi(Vector256<float> x)
    {
        var add = x + (Vector256.LessThan(x, default) & Vector256.Create(math.F_4_PI));
        var div = x * math.F_1_Div_4_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector256.Create(math.F_4_PI), add);
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

    #region Log v256

    [MethodImpl(256 | 512)]
    public static Vector256<float> Log(Vector256<float> a) => Log2(a) * math.F_Log2;

    [MethodImpl(256 | 512)]
    public static Vector256<float> Log10(Vector256<float> a) => Log2(a) * (math.F_Log2 / math.F_Log10);

    [MethodImpl(256 | 512)]
    public static Vector256<float> Log2(Vector256<float> a)
    {
        var xl = Vector256.Max(a, Vector256<float>.Zero).AsInt32();
        var mantissa = (xl >>> 23) - Vector256.Create(0x7F);
        var r = Vector256.ConvertToSingle(mantissa);

        xl = (xl & Vector256.Create(0x7FFFFF)) | Vector256.Create(0x7F << 23);

        var d = (xl.AsSingle() | Vector256<float>.One) * Vector256.Create(2.0f / 3.0f);

        #region Approx

        // A Taylor Series approximation of ln(x) that relies on the identity that ln(x) = 2*atan((x-1)/(x+1)).
        d = (d - Vector256<float>.One) / (d + Vector256<float>.One);
        var sq = d * d;

        var rx = simd.Fma(sq, Vector256.Create(0.2371599674224853515625f), Vector256.Create(0.285279005765914916992188f));
        rx = simd.Fma(rx, sq, Vector256.Create(0.400005519390106201171875f));
        rx = simd.Fma(rx, sq, Vector256.Create(0.666666567325592041015625f));
        rx = simd.Fma(rx, sq, Vector256.Create(2.0f));

        d *= rx;

        #endregion

        r += simd.Fma(d, Vector256.Create(1.4426950408889634f), Vector256.Create(0.58496250072115619f));

        r = Vector256.ConditionalSelect(
            Vector256.GreaterThan(a, Vector256<float>.Zero),
            r, Vector256.Create(float.NaN)
        );
        r = Vector256.ConditionalSelect(
            Vector256.Equals(a, Vector256.Create(float.PositiveInfinity)),
            Vector256.Create(float.PositiveInfinity), r
        );
        r = Vector256.ConditionalSelect(
            Vector256.Equals(a, Vector256<float>.Zero),
            Vector256.Create(float.NegativeInfinity), r
        );

        return r;
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

    #region Exp v256

    [MethodImpl(256 | 512)]
    public static Vector256<float> Exp(Vector256<float> x) => Exp2(x * math.F_1_Div_Log2);

    [MethodImpl(256 | 512)]
    public static Vector256<float> Exp10(Vector256<float> x) => Exp(x * 2.302585092994045684f);

    [MethodImpl(256 | 512)]
    public static Vector256<float> Exp2(Vector256<float> x)
    {
        var e = Vector256.GreaterThanOrEqual(x, Vector256.Create(89f)) & Vector256.Create(float.PositiveInfinity);
        e += simd.Ne(x, x);

        var xx = Vector256.Max(
            Vector256.Min(x, Vector256.Create(81.0f * math.F_1_Div_Log2)),
            Vector256.Create(-81.0f * math.F_1_Div_Log2)
        );

        var fx = simd.Round(xx);

        xx -= fx;
        var r = simd.Fma(xx, Vector256.Create(1.530610536076361E-05f), Vector256.Create(0.000154631026827329f));
        r = simd.Fma(r, xx, Vector256.Create(0.0013333465742372899f));
        r = simd.Fma(r, xx, Vector256.Create(0.00961804886829518f));
        r = simd.Fma(r, xx, Vector256.Create(0.05550410925060949f));
        r = simd.Fma(r, xx, Vector256.Create(0.240226509999339f));
        r = simd.Fma(r, xx, Vector256.Create(0.6931471805500692f));
        r = simd.Fma(r, xx, Vector256.Create(1.0f));

        fx = ((Vector256.ConvertToInt32(fx) + Vector256.Create(127)) << 23).AsSingle();

        r = simd.Fma(r, fx, e);
        r = Vector256.AndNot(r, Vector256.Equals(x, Vector256.Create(float.NegativeInfinity)));

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

    #region Sin Cos v64

    [MethodImpl(256 | 512)]
    public static Vector64<float> Cos(Vector64<float> x) => Sin(x + Vector64.Create(math.F_Half_PI));

    [MethodImpl(256 | 512)]
    public static Vector64<float> Sin(Vector64<float> x)
    {
        // Since sin() is periodic around 2pi, this converts x into the range of [0, 2pi]
        var xt = Wrap0To2Pi(x);

        // Since sin() in [0, 2pi] is an odd function around pi, this converts the range to [0, pi], then stores whether or not the result needs to be negated in is_neg.
        var is_neg = Vector64.GreaterThan(xt, Vector64.Create(math.F_PI));
        xt -= is_neg & Vector64.Create(math.F_PI);

        is_neg &= Vector64.Create(-2.0f);
        is_neg += Vector64<float>.One;

        var is_nan = simd.Ne(x, x);
        is_nan += Vector64.GreaterThan(x, Vector64.Create(float.MaxValue));
        is_nan += Vector64.LessThan(x, Vector64.Create(float.MinValue));

        // Since sin() on [0, pi] is an even function around pi/2, this "folds" the range into [0, pi/2]. I.e. 3pi/5 becomes 2pi/5.
        xt = Vector64.Create(math.F_Half_PI) - Vector64.Abs(xt - Vector64.Create(math.F_Half_PI));

        var sq = xt * xt;
        var r = simd.Fma(sq, Vector64.Create(-0.0000000000007384998082865f), Vector64.Create(0.000000000160490521296459f));
        r = simd.Fma(r, sq, Vector64.Create(-0.00000002505191090496049f));
        r = simd.Fma(r, sq, Vector64.Create(0.00000275573170815073144f));
        r = simd.Fma(r, sq, Vector64.Create(-0.00019841269828860068271f));
        r = simd.Fma(r, sq, Vector64.Create(0.008333333333299304989001f));
        r = simd.Fma(r, sq, Vector64.Create(-0.166666666666663509013977f));
        r = simd.Fma(r, sq, Vector64<float>.One);

        r *= xt;

        r = simd.Fma(r, is_neg, is_nan);

        return r;
    }

    #endregion

    #region Sin Cos v128

    [MethodImpl(256 | 512)]
    public static Vector128<float> SinCos(Vector128<float> x) => Sin(x + Vector128.Create(0.0f, 0.0f, math.F_Half_PI, math.F_Half_PI));

    [MethodImpl(256 | 512)]
    public static Vector128<float> Cos(Vector128<float> x) => Sin(x + Vector128.Create(math.F_Half_PI));

    [MethodImpl(256 | 512)]
    public static Vector128<float> Sin(Vector128<float> x)
    {
        // Since sin() is periodic around 2pi, this converts x into the range of [0, 2pi]
        var xt = Wrap0To2Pi(x);

        // Since sin() in [0, 2pi] is an odd function around pi, this converts the range to [0, pi], then stores whether or not the result needs to be negated in is_neg.
        var is_neg = Vector128.GreaterThan(xt, Vector128.Create(math.F_PI));
        xt -= is_neg & Vector128.Create(math.F_PI);

        is_neg &= Vector128.Create(-2.0f);
        is_neg += Vector128<float>.One;

        var is_nan = simd.Ne(x, x);
        is_nan += Vector128.GreaterThan(x, Vector128.Create(float.MaxValue));
        is_nan += Vector128.LessThan(x, Vector128.Create(float.MinValue));

        // Since sin() on [0, pi] is an even function around pi/2, this "folds" the range into [0, pi/2]. I.e. 3pi/5 becomes 2pi/5.
        xt = Vector128.Create(math.F_Half_PI) - Vector128.Abs(xt - Vector128.Create(math.F_Half_PI));

        var sq = xt * xt;
        var r = simd.Fma(sq, Vector128.Create(-0.0000000000007384998082865f), Vector128.Create(0.000000000160490521296459f));
        r = simd.Fma(r, sq, Vector128.Create(-0.00000002505191090496049f));
        r = simd.Fma(r, sq, Vector128.Create(0.00000275573170815073144f));
        r = simd.Fma(r, sq, Vector128.Create(-0.00019841269828860068271f));
        r = simd.Fma(r, sq, Vector128.Create(0.008333333333299304989001f));
        r = simd.Fma(r, sq, Vector128.Create(-0.166666666666663509013977f));
        r = simd.Fma(r, sq, Vector128<float>.One);

        r *= xt;

        r = simd.Fma(r, is_neg, is_nan);

        return r;
    }

    #endregion

    #region Sin Cos v256

    [MethodImpl(256 | 512)]
    public static Vector256<float> SinCos(Vector256<float> x) =>
        Sin(x + Vector256.Create(0.0f, 0.0f, 0.0f, 0.0f, math.F_Half_PI, math.F_Half_PI, math.F_Half_PI, math.F_Half_PI));

    [MethodImpl(256 | 512)]
    public static Vector256<float> Cos(Vector256<float> x) => Sin(x + Vector256.Create(math.F_Half_PI));

    [MethodImpl(256 | 512)]
    public static Vector256<float> Sin(Vector256<float> x)
    {
        // Since sin() is periodic around 2pi, this converts x into the range of [0, 2pi]
        var xt = Wrap0To2Pi(x);

        // Since sin() in [0, 2pi] is an odd function around pi, this converts the range to [0, pi], then stores whether or not the result needs to be negated in is_neg.
        var is_neg = Vector256.GreaterThan(xt, Vector256.Create(math.F_PI));
        xt -= is_neg & Vector256.Create(math.F_PI);

        is_neg &= Vector256.Create(-2.0f);
        is_neg += Vector256<float>.One;

        var is_nan = simd.Ne(x, x);
        is_nan += Vector256.GreaterThan(x, Vector256.Create(float.MaxValue));
        is_nan += Vector256.LessThan(x, Vector256.Create(float.MinValue));

        // Since sin() on [0, pi] is an even function around pi/2, this "folds" the range into [0, pi/2]. I.e. 3pi/5 becomes 2pi/5.
        xt = Vector256.Create(math.F_Half_PI) - Vector256.Abs(xt - Vector256.Create(math.F_Half_PI));

        var sq = xt * xt;
        var r = simd.Fma(sq, Vector256.Create(-0.0000000000007384998082865f), Vector256.Create(0.000000000160490521296459f));
        r = simd.Fma(r, sq, Vector256.Create(-0.00000002505191090496049f));
        r = simd.Fma(r, sq, Vector256.Create(0.00000275573170815073144f));
        r = simd.Fma(r, sq, Vector256.Create(-0.00019841269828860068271f));
        r = simd.Fma(r, sq, Vector256.Create(0.008333333333299304989001f));
        r = simd.Fma(r, sq, Vector256.Create(-0.166666666666663509013977f));
        r = simd.Fma(r, sq, Vector256<float>.One);

        r *= xt;

        r = simd.Fma(r, is_neg, is_nan);

        return r;
    }

    #endregion

    #region Tan v64

    /// <summary>
    /// Computes sines in [0,pi/4]
    /// </summary>
    [MethodImpl(256 | 512)]
    public static Vector64<float> SinIn0P4(Vector64<float> x)
    {
        var sq = x * x;

        // This is an odd-only Taylor series approximation of sin() on [0, pi/4]. 
        var r = simd.Fma(sq, Vector64.Create(0.0000000001590238118466f), Vector64.Create(-0.0000000250508528135474f));
        r = simd.Fma(r, sq, Vector64.Create(0.0000027557314284120030f));
        r = simd.Fma(r, sq, Vector64.Create(-0.00019841269831470328245f));
        r = simd.Fma(r, sq, Vector64.Create(0.008333333333324419158220f));
        r = simd.Fma(r, sq, Vector64.Create(-0.1666666666666663969165095f));
        r = simd.Fma(r, sq, Vector64<float>.One);
        r *= x;

        return r;
    }

    [MethodImpl(256 | 512)]
    public static Vector64<float> Tan(Vector64<float> x)
    {
        // Since tan() is periodic around pi, this converts x into the range of [0, pi]
        var xt = Wrap0ToPi(x);

        // Since tan() in [0, pi] is an odd function around pi/2, this converts the range to [0, pi/2], then stores whether or not the result needs to be negated in is_neg.
        var is_neg = Vector64.GreaterThan(xt, Vector64.Create(math.F_Half_PI));
        xt += is_neg & ((xt - Vector64.Create(math.F_Half_PI)) * -2);

        is_neg &= Vector64.Create(-2.0f);
        is_neg += Vector64<float>.One;

        var is_nan = simd.Ne(x, x);
        is_nan += Vector64.GreaterThan(x, Vector64.Create(float.MaxValue));
        is_nan += Vector64.LessThan(x, Vector64.Create(float.MinValue));

        // Since tan() on [0, pi/2] is an inversed function around pi/4, this "folds" the range into [0, pi/4]. I.e. 3pi/10 becomes 2pi/10.
        var do_inv_mask = Vector64.GreaterThan(xt, Vector64.Create(math.F_Quarter_PI));
        var no_inv_mask = Vector64.LessThanOrEqual(xt, Vector64.Create(math.F_Quarter_PI));
        xt = Vector64.Create(math.F_Quarter_PI) - Vector64.Abs(xt - Vector64.Create(math.F_Quarter_PI));

        var xx = SinIn0P4(xt);

        xt = Vector64.Sqrt(Vector64<float>.One - xx * xx);

        xx = (do_inv_mask & (xt / xx)) + (no_inv_mask & (xx / xt));

        xx = simd.Fma(xx, is_neg, is_nan);
        return xx;
    }

    #endregion

    #region Tan v128

    /// <summary>
    /// Computes sines in [0,pi/4]
    /// </summary>
    [MethodImpl(256 | 512)]
    public static Vector128<float> SinIn0P4(Vector128<float> x)
    {
        var sq = x * x;

        // This is an odd-only Taylor series approximation of sin() on [0, pi/4]. 
        var r = simd.Fma(sq, Vector128.Create(0.0000000001590238118466f), Vector128.Create(-0.0000000250508528135474f));
        r = simd.Fma(r, sq, Vector128.Create(0.0000027557314284120030f));
        r = simd.Fma(r, sq, Vector128.Create(-0.00019841269831470328245f));
        r = simd.Fma(r, sq, Vector128.Create(0.008333333333324419158220f));
        r = simd.Fma(r, sq, Vector128.Create(-0.1666666666666663969165095f));
        r = simd.Fma(r, sq, Vector128<float>.One);
        r *= x;

        return r;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Tan(Vector128<float> x)
    {
        // Since tan() is periodic around pi, this converts x into the range of [0, pi]
        var xt = Wrap0ToPi(x);

        // Since tan() in [0, pi] is an odd function around pi/2, this converts the range to [0, pi/2], then stores whether or not the result needs to be negated in is_neg.
        var is_neg = Vector128.GreaterThan(xt, Vector128.Create(math.F_Half_PI));
        xt += is_neg & ((xt - Vector128.Create(math.F_Half_PI)) * -2);

        is_neg &= Vector128.Create(-2.0f);
        is_neg += Vector128<float>.One;

        var is_nan = simd.Ne(x, x);
        is_nan += Vector128.GreaterThan(x, Vector128.Create(float.MaxValue));
        is_nan += Vector128.LessThan(x, Vector128.Create(float.MinValue));

        // Since tan() on [0, pi/2] is an inversed function around pi/4, this "folds" the range into [0, pi/4]. I.e. 3pi/10 becomes 2pi/10.
        var do_inv_mask = Vector128.GreaterThan(xt, Vector128.Create(math.F_Quarter_PI));
        var no_inv_mask = Vector128.LessThanOrEqual(xt, Vector128.Create(math.F_Quarter_PI));
        xt = Vector128.Create(math.F_Quarter_PI) - Vector128.Abs(xt - Vector128.Create(math.F_Quarter_PI));

        var xx = SinIn0P4(xt);

        xt = Vector128.Sqrt(Vector128<float>.One - xx * xx);

        xx = (do_inv_mask & (xt / xx)) + (no_inv_mask & (xx / xt));

        xx = simd.Fma(xx, is_neg, is_nan);
        return xx;
    }

    #endregion

    #region Sinh Cosh v64

    [MethodImpl(256 | 512)]
    public static Vector64<float> Sinh(Vector64<float> x)
    {
        var r = Exp(x);
        var rr = Vector64<float>.One / r;
        return (r - rr) * 0.5f;
    }

    [MethodImpl(256 | 512)]
    public static Vector64<float> Cosh(Vector64<float> x)
    {
        var r = Exp(x);
        var rr = Vector64<float>.One / r;
        return (r + rr) * 0.5f;
    }

    #endregion

    #region Sinh Cosh v128

    [MethodImpl(256 | 512)]
    public static Vector128<float> Sinh(Vector128<float> x)
    {
        var r = Exp(x);
        var rr = Vector128<float>.One / r;
        return (r - rr) * 0.5f;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Cosh(Vector128<float> x)
    {
        var r = Exp(x);
        var rr = Vector128<float>.One / r;
        return (r + rr) * 0.5f;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> SinhCosh(Vector128<float> x)
    {
        var r = Exp(x);
        var rr = Vector128<float>.One / r;
        var rrr = simd.Fma(rr, Vector128.Create(1.0f, 1.0f, -1.0f, -1.0f), r);
        return rrr * 0.5f;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> SinhCoshF64To128(Vector64<float> x)
    {
        var r = Exp(x);
        var r256 = Vector128.Create(r, r);
        var rr = Vector128<float>.One / r256;
        var rrr = simd.Fma(rr, Vector128.Create(1.0f, 1.0f, -1.0f, -1.0f), r256);
        return rrr * 0.5f;
    }

    #endregion

    #region Sinh Cosh v256

    [MethodImpl(256 | 512)]
    public static Vector256<float> SinhCosh(Vector256<float> x)
    {
        var r = Exp(x);
        var rr = Vector256<float>.One / r;
        var rrr = simd.Fma(rr, Vector256.Create(1.0f, 1.0f, 1.0f, 1.0f, -1.0f, -1.0f, -1.0f, -1.0f), r);
        return rrr * 0.5f;
    }

    [MethodImpl(256 | 512)]
    public static Vector256<float> SinhCoshF128To256(Vector128<float> x)
    {
        var r = Exp(x);
        var r256 = Vector256.Create(r, r);
        var rr = Vector256<float>.One / r256;
        var rrr = simd.Fma(rr, Vector256.Create(1.0f, 1.0f, 1.0f, 1.0f, -1.0f, -1.0f, -1.0f, -1.0f), r256);
        return rrr * 0.5f;
    }

    #endregion

    #region Tanh v64

    [MethodImpl(256 | 512)]
    public static Vector64<float> Tanh(Vector64<float> x)
    {
        var r = Exp(x);
        var rr = Vector64<float>.One / r;
        return (r - rr) / (r + rr);
    }

    #endregion

    #region Tanh v128

    [MethodImpl(256 | 512)]
    public static Vector128<float> Tanh(Vector128<float> x)
    {
        var r = Exp(x);
        var rr = Vector128<float>.One / r;
        return (r - rr) / (r + rr);
    }

    #endregion

    #region ASinh ACosh v64

    [MethodImpl(256 | 512)]
    public static Vector64<float> Asinh(Vector64<float> x)
    {
        var r = simd.Fma(x, x, Vector64<float>.One);
        r = Vector64.Sqrt(r);
        r += x;
        r = Log(r);
        return r;
    }

    [MethodImpl(256 | 512)]
    public static Vector64<float> Acosh(Vector64<float> x)
    {
        var r = simd.Fma(x, x, -Vector64<float>.One);
        r = Vector64.Sqrt(r);
        r += x;
        r = Log(r);
        return r;
    }

    #endregion

    #region ASinh ACosh v128

    [MethodImpl(256 | 512)]
    public static Vector128<float> Asinh(Vector128<float> x)
    {
        var r = simd.Fma(x, x, Vector128<float>.One);
        r = Vector128.Sqrt(r);
        r += x;
        r = Log(r);
        return r;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> Acosh(Vector128<float> x)
    {
        var r = simd.Fma(x, x, -Vector128<float>.One);
        r = Vector128.Sqrt(r);
        r += x;
        r = Log(r);
        return r;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<float> AsinhAcosh(Vector128<float> x)
    {
        var r = simd.Fma(x, x, Vector128.Create(1.0f, 1.0f, -1.0f, -1.0f));
        r = Vector128.Sqrt(r);
        r += x;
        r = Log(r);
        return r;
    }

    #endregion

    #region ASinh ACosh v256

    [MethodImpl(256 | 512)]
    public static Vector256<float> AsinhAcosh(Vector256<float> x)
    {
        var r = simd.Fma(x, x, Vector256.Create(1.0f, 1.0f, 1.0f, 1.0f, -1.0f, -1.0f, -1.0f, -1.0f));
        r = Vector256.Sqrt(r);
        r += x;
        r = Log(r);
        return r;
    }

    #endregion
}
#endif
