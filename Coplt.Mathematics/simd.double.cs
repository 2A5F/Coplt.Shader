#if NET8_0_OR_GREATER
namespace Coplt.Mathematics;

public static partial class simd_double
{
    #region Mod v128

    [MethodImpl(256 | 512)]
    public static Vector128<double> Mod(Vector128<double> x, Vector128<double> y)
    {
        var div = x / y;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, y, x);
    }

    [MethodImpl(256 | 512)]
    public static Vector128<double> Mod(Vector128<double> x, double y)
    {
        var div = x / y;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector128.Create(y), x);
    }

    #endregion

    #region Mod v256

    [MethodImpl(256 | 512)]
    public static Vector256<double> Mod(Vector256<double> x, Vector256<double> y)
    {
        var div = x / y;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, y, x);
    }

    [MethodImpl(256 | 512)]
    public static Vector256<double> Mod(Vector256<double> x, double y)
    {
        var div = x / y;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector256.Create(y), x);
    }

    #endregion

    #region Wrap v128

    [MethodImpl(256 | 512)]
    public static Vector128<double> Wrap(Vector128<double> x, Vector128<double> min, Vector128<double> max)
    {
        var add = Vector128.ConditionalSelect(Vector128.GreaterThanOrEqual(x, default), min, max);
        var off = Mod(x, max - min);
        return add + off;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<double> Wrap(Vector128<double> x, double min, double max)
    {
        var add = Vector128.ConditionalSelect(Vector128.GreaterThanOrEqual(x, default), Vector128.Create(min), Vector128.Create(max));
        var off = Mod(x, max - min);
        return add + off;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<double> Wrap0ToPi(Vector128<double> x)
    {
        var add = x + (Vector128.LessThan(x, default) & Vector128.Create(math.D_PI));
        var div = x * math.D_1_Div_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector128.Create(math.D_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector128<double> Wrap0To2Pi(Vector128<double> x)
    {
        var add = x + (Vector128.LessThan(x, default) & Vector128.Create(math.D_2_PI));
        var div = x * math.D_1_Div_2_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector128.Create(math.D_2_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector128<double> Wrap0To4Pi(Vector128<double> x)
    {
        var add = x + (Vector128.LessThan(x, default) & Vector128.Create(math.D_4_PI));
        var div = x * math.D_1_Div_4_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector128.Create(math.D_4_PI), add);
    }

    #endregion
    
    #region Wrap v256

    [MethodImpl(256 | 512)]
    public static Vector256<double> Wrap(Vector256<double> x, Vector256<double> min, Vector256<double> max)
    {
        var add = Vector256.ConditionalSelect(Vector256.GreaterThanOrEqual(x, default), min, max);
        var off = Mod(x, max - min);
        return add + off;
    }

    [MethodImpl(256 | 512)]
    public static Vector256<double> Wrap(Vector256<double> x, double min, double max)
    {
        var add = Vector256.ConditionalSelect(Vector256.GreaterThanOrEqual(x, default), Vector256.Create(min), Vector256.Create(max));
        var off = Mod(x, max - min);
        return add + off;
    }

    [MethodImpl(256 | 512)]
    public static Vector256<double> Wrap0ToPi(Vector256<double> x)
    {
        var add = x + (Vector256.LessThan(x, default) & Vector256.Create(math.D_PI));
        var div = x * math.D_1_Div_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector256.Create(math.D_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector256<double> Wrap0To2Pi(Vector256<double> x)
    {
        var add = x + (Vector256.LessThan(x, default) & Vector256.Create(math.D_2_PI));
        var div = x * math.D_1_Div_2_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector256.Create(math.D_2_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector256<double> Wrap0To4Pi(Vector256<double> x)
    {
        var add = x + (Vector256.LessThan(x, default) & Vector256.Create(math.D_4_PI));
        var div = x * math.D_1_Div_4_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector256.Create(math.D_4_PI), add);
    }

    #endregion
    
    #region Wrap v512

    [MethodImpl(256 | 512)]
    public static Vector512<double> Wrap0ToPi(Vector512<double> x)
    {
        var add = x + (Vector512.LessThan(x, default) & Vector512.Create(math.D_PI));
        var div = x * math.D_1_Div_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector512.Create(math.D_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector512<double> Wrap0To2Pi(Vector512<double> x)
    {
        var add = x + (Vector512.LessThan(x, default) & Vector512.Create(math.D_2_PI));
        var div = x * math.D_1_Div_2_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector512.Create(math.D_2_PI), add);
    }

    [MethodImpl(256 | 512)]
    public static Vector512<double> Wrap0To4Pi(Vector512<double> x)
    {
        var add = x + (Vector512.LessThan(x, default) & Vector512.Create(math.D_4_PI));
        var div = x * math.D_1_Div_4_PI;
        var flr = simd.RoundToZero(div);
        return simd.Fnma(flr, Vector512.Create(math.D_4_PI), add);
    }

    #endregion

    #region Log v128

    [MethodImpl(256 | 512)]
    public static Vector128<double> Log(Vector128<double> a) => Log2(a) * math.D_Log2;

    [MethodImpl(256 | 512)]
    public static Vector128<double> Log10(Vector128<double> a) => Log2(a) * (math.D_Log2 / math.D_Log10);

    [MethodImpl(256 | 512)]
    public static Vector128<double> Log2(Vector128<double> a)
    {
        var xl = Vector128.Max(a, Vector128<double>.Zero).AsInt64();
        var mantissa = (xl >>> 52) - Vector128.Create(0x3FFL);
        var r = Vector128.ConvertToDouble(mantissa);

        xl = (xl & Vector128.Create(0xFFFFFFFFFFFFFL)) | Vector128.Create(0x3FFL << 52);

        var d = (xl.AsDouble() | Vector128<double>.One) * Vector128.Create(2.0 / 3.0);

        #region Approx

        // A Taylor Series approximation of ln(x) that relies on the identity that ln(x) = 2*atan((x-1)/(x+1)).
        d = (d - Vector128<double>.One) / (d + Vector128<double>.One);
        var sq = d * d;

        var rx = simd.Fma(sq, Vector128.Create(0.148197055177935105296783), Vector128.Create(0.153108178020442575739679));
        rx = simd.Fma(rx, sq, Vector128.Create(0.181837339521549679055568));
        rx = simd.Fma(rx, sq, Vector128.Create(0.22222194152736701733275));
        rx = simd.Fma(rx, sq, Vector128.Create(0.285714288030134544449368));
        rx = simd.Fma(rx, sq, Vector128.Create(0.399999999989941956712869));
        rx = simd.Fma(rx, sq, Vector128.Create(0.666666666666685503450651));
        rx = simd.Fma(rx, sq, Vector128.Create(2.0));

        d *= rx;

        #endregion

        r += simd.Fma(d, Vector128.Create(1.4426950408889634), Vector128.Create(0.58496250072115619));

        r = Vector128.ConditionalSelect(
            Vector128.GreaterThan(a, Vector128<double>.Zero),
            r, Vector128.Create(double.NaN)
        );
        r = Vector128.ConditionalSelect(
            Vector128.Equals(a, Vector128.Create(double.PositiveInfinity)),
            Vector128.Create(double.PositiveInfinity), r
        );
        r = Vector128.ConditionalSelect(
            Vector128.Equals(a, Vector128<double>.Zero),
            Vector128.Create(double.NegativeInfinity), r
        );

        return r;
    }

    #endregion

    #region Log v256

    [MethodImpl(256 | 512)]
    public static Vector256<double> Log(Vector256<double> a) => Log2(a) * math.D_Log2;

    [MethodImpl(256 | 512)]
    public static Vector256<double> Log10(Vector256<double> a) => Log2(a) * (math.D_Log2 / math.D_Log10);

    [MethodImpl(256 | 512)]
    public static Vector256<double> Log2(Vector256<double> a)
    {
        var xl = Vector256.Max(a, Vector256<double>.Zero).AsInt64();
        var mantissa = (xl >>> 52) - Vector256.Create(0x3ffL);
        var r = Vector256.ConvertToDouble(mantissa);

        xl = (xl & Vector256.Create(0xfffffffffffffL)) | Vector256.Create(1023L << 52);

        var d = (xl.AsDouble() | Vector256<double>.One) * Vector256.Create(2.0 / 3.0);

        #region Approx

        // A Taylor Series approximation of ln(x) that relies on the identity that ln(x) = 2*atan((x-1)/(x+1)).
        d = (d - Vector256<double>.One) / (d + Vector256<double>.One);
        var sq = d * d;

        var rx = simd.Fma(sq, Vector256.Create(0.148197055177935105296783), Vector256.Create(0.153108178020442575739679));
        rx = simd.Fma(rx, sq, Vector256.Create(0.181837339521549679055568));
        rx = simd.Fma(rx, sq, Vector256.Create(0.22222194152736701733275));
        rx = simd.Fma(rx, sq, Vector256.Create(0.285714288030134544449368));
        rx = simd.Fma(rx, sq, Vector256.Create(0.399999999989941956712869));
        rx = simd.Fma(rx, sq, Vector256.Create(0.666666666666685503450651));
        rx = simd.Fma(rx, sq, Vector256.Create(2.0));

        d *= rx;

        #endregion

        r += simd.Fma(d, Vector256.Create(1.4426950408889634), Vector256.Create(0.58496250072115619));

        r = Vector256.ConditionalSelect(
            Vector256.GreaterThan(a, Vector256<double>.Zero),
            r, Vector256.Create(double.NaN)
        );
        r = Vector256.ConditionalSelect(
            Vector256.Equals(a, Vector256.Create(double.PositiveInfinity)),
            Vector256.Create(double.PositiveInfinity), r
        );
        r = Vector256.ConditionalSelect(
            Vector256.Equals(a, Vector256<double>.Zero),
            Vector256.Create(double.NegativeInfinity), r
        );

        return r;
    }

    #endregion

    #region Exp v128

    [MethodImpl(256 | 512)]
    public static Vector128<double> Exp(Vector128<double> a) => Exp2(a * math.D_1_Div_Log2);

    [MethodImpl(256 | 512)]
    public static Vector128<double> Exp10(Vector128<double> x) => Exp(x * 2.302585092994045684);

    [MethodImpl(256 | 512)]
    public static Vector128<double> Exp2(Vector128<double> x)
    {
        var e = Vector128.GreaterThanOrEqual(x, Vector128.Create(709.0 * 1.4426950408889634)) & Vector128.Create(double.PositiveInfinity);
        e += simd.Ne(x, x);

        var xx = Vector128.Max(
            Vector128.Min(x, Vector128.Create(709.0 * 1.4426950408889634)),
            Vector128.Create(-709.0 * 1.4426950408889634)
        );
        var fx = simd.Round(xx);

        xx -= fx;
        var sq = xx * xx;
        var r = simd.Fma(sq, Vector128.Create(0.00000000044560630323), Vector128.Create(0.00000010178055034703));
        r = simd.Fma(r, sq, Vector128.Create(0.000015252733847608224));
        r = simd.Fma(r, sq, Vector128.Create(0.0013333558146398846396));
        r = simd.Fma(r, sq, Vector128.Create(0.05550410866482166557484));
        r = simd.Fma(r, sq, Vector128.Create(0.6931471805599453087156032));
        var ro = simd.Fma(sq, Vector128.Create(0.000000007073075504998510), Vector128.Create(0.000001321543919937730177));
        ro = simd.Fma(ro, sq, Vector128.Create(0.0001540353044975008196326));
        ro = simd.Fma(ro, sq, Vector128.Create(0.00961812910759946061829085));
        ro = simd.Fma(ro, sq, Vector128.Create(0.240226506959101195979507231));
        ro = simd.Fma(ro, sq, Vector128<double>.One);
        r = simd.Fma(r, xx, ro);

        fx += Vector128.Create(6755399441055744.0);
        fx = ((fx.AsInt64() + Vector128.Create(0x3ffL)) << 52).AsDouble();

        r = simd.Fma(r, fx, e);

        return r;
    }

    #endregion

    #region Exp v256

    [MethodImpl(256 | 512)]
    public static Vector256<double> Exp(Vector256<double> a) => Exp2(a * math.D_1_Div_Log2);

    [MethodImpl(256 | 512)]
    public static Vector256<double> Exp10(Vector256<double> x) => Exp(x * 2.302585092994045684);

    [MethodImpl(256 | 512)]
    public static Vector256<double> Exp2(Vector256<double> x)
    {
        var e = Vector256.GreaterThanOrEqual(x, Vector256.Create(709.0 * 1.4426950408889634)) & Vector256.Create(double.PositiveInfinity);
        e += simd.Ne(x, x);

        var xx = Vector256.Max(
            Vector256.Min(x, Vector256.Create(709.0 * 1.4426950408889634)),
            Vector256.Create(-709.0 * 1.4426950408889634)
        );
        var fx = simd.Round(xx);

        xx -= fx;
        var sq = xx * xx;
        var r = simd.Fma(sq, Vector256.Create(0.00000000044560630323), Vector256.Create(0.00000010178055034703));
        r = simd.Fma(r, sq, Vector256.Create(0.000015252733847608224));
        r = simd.Fma(r, sq, Vector256.Create(0.0013333558146398846396));
        r = simd.Fma(r, sq, Vector256.Create(0.05550410866482166557484));
        r = simd.Fma(r, sq, Vector256.Create(0.6931471805599453087156032));
        var ro = simd.Fma(sq, Vector256.Create(0.000000007073075504998510), Vector256.Create(0.000001321543919937730177));
        ro = simd.Fma(ro, sq, Vector256.Create(0.0001540353044975008196326));
        ro = simd.Fma(ro, sq, Vector256.Create(0.00961812910759946061829085));
        ro = simd.Fma(ro, sq, Vector256.Create(0.240226506959101195979507231));
        ro = simd.Fma(ro, sq, Vector256<double>.One);
        r = simd.Fma(r, xx, ro);

        fx += Vector256.Create(6755399441055744.0);
        fx = ((fx.AsInt64() + Vector256.Create(0x3ffL)) << 52).AsDouble();

        r = simd.Fma(r, fx, e);

        return r;
    }

    #endregion

    #region Pow v128

    [MethodImpl(256 | 512)]
    public static Vector128<double> Pow(Vector128<double> a, Vector128<double> b)
    {
        var sig = Vector128.LessThan(a, default)
                  & simd.Ne(Mod(b, Vector128.Create(2.0)), default)
                  & Vector128.Create(0x8000_0000_0000_0000).AsDouble();
        var r = Exp2(Log2(Vector128.Abs(a)) * b);
        return r | sig;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<double> Pow(Vector128<double> a, double b) => Pow(a, Vector128.Create(b));

    #endregion

    #region Pow v256

    [MethodImpl(256 | 512)]
    public static Vector256<double> Pow(Vector256<double> a, Vector256<double> b)
    {
        var sig = Vector256.LessThan(a, default)
                  & simd.Ne(Mod(b, Vector256.Create(2.0)), default)
                  & Vector256.Create(0x8000_0000_0000_0000).AsDouble();
        var r = Exp2(Log2(Vector256.Abs(a)) * b);
        return r | sig;
    }

    [MethodImpl(256 | 512)]
    public static Vector256<double> Pow(Vector256<double> a, double b) => Pow(a, Vector256.Create(b));

    #endregion

    #region Sin Cos v128

    [MethodImpl(256 | 512)]
    public static Vector128<double> Cos(Vector128<double> x) => Sin(x + Vector128.Create(math.D_Half_PI));

    [MethodImpl(256 | 512)]
    public static Vector128<double> Sin(Vector128<double> x)
    {
        // Since sin() is periodic around 2pi, this converts x into the range of [0, 2pi]
        var xt = Wrap0To2Pi(x);

        // Since sin() in [0, 2pi] is an odd function around pi, this converts the range to [0, pi], then stores whether or not the result needs to be negated in is_neg.
        var is_neg = Vector128.GreaterThan(xt, Vector128.Create(math.D_PI));
        xt -= is_neg & Vector128.Create(math.D_PI);

        is_neg &= Vector128.Create(-2.0);
        is_neg += Vector128<double>.One;

        var is_nan = simd.Ne(x, x);
        is_nan += Vector128.GreaterThan(x, Vector128.Create(double.MaxValue));
        is_nan += Vector128.LessThan(x, Vector128.Create(double.MinValue));

        // Since sin() on [0, pi] is an even function around pi/2, this "folds" the range into [0, pi/2]. I.e. 3pi/5 becomes 2pi/5.
        xt = Vector128.Create(math.D_Half_PI) - Vector128.Abs(xt - Vector128.Create(math.D_Half_PI));

        var sq = xt * xt;
        var r = simd.Fma(sq, Vector128.Create(-0.0000000000007384998082865), Vector128.Create(0.000000000160490521296459));
        r = simd.Fma(r, sq, Vector128.Create(-0.00000002505191090496049));
        r = simd.Fma(r, sq, Vector128.Create(0.00000275573170815073144));
        r = simd.Fma(r, sq, Vector128.Create(-0.00019841269828860068271));
        r = simd.Fma(r, sq, Vector128.Create(0.008333333333299304989001));
        r = simd.Fma(r, sq, Vector128.Create(-0.166666666666663509013977));
        r = simd.Fma(r, sq, Vector128<double>.One);

        r *= xt;

        r = simd.Fma(r, is_neg, is_nan);

        return r;
    }

    #endregion

    #region Sin Cos v256

    [MethodImpl(256 | 512)]
    public static Vector256<double> SinCos(Vector256<double> x) => Sin(x + Vector256.Create(0.0, 0.0, math.D_Half_PI, math.D_Half_PI));

    [MethodImpl(256 | 512)]
    public static Vector256<double> Cos(Vector256<double> x) => Sin(x + Vector256.Create(math.D_Half_PI));

    [MethodImpl(256 | 512)]
    public static Vector256<double> Sin(Vector256<double> x)
    {
        // Since sin() is periodic around 2pi, this converts x into the range of [0, 2pi]
        var xt = Wrap0To2Pi(x);

        // Since sin() in [0, 2pi] is an odd function around pi, this converts the range to [0, pi], then stores whether or not the result needs to be negated in is_neg.
        var is_neg = Vector256.GreaterThan(xt, Vector256.Create(math.D_PI));
        xt -= is_neg & Vector256.Create(math.D_PI);

        is_neg &= Vector256.Create(-2.0);
        is_neg += Vector256<double>.One;

        var is_nan = simd.Ne(x, x);
        is_nan += Vector256.GreaterThan(x, Vector256.Create(double.MaxValue));
        is_nan += Vector256.LessThan(x, Vector256.Create(double.MinValue));

        // Since sin() on [0, pi] is an even function around pi/2, this "folds" the range into [0, pi/2]. I.e. 3pi/5 becomes 2pi/5.
        xt = Vector256.Create(math.D_Half_PI) - Vector256.Abs(xt - Vector256.Create(math.D_Half_PI));

        var sq = xt * xt;
        var r = simd.Fma(sq, Vector256.Create(-0.0000000000007384998082865), Vector256.Create(0.000000000160490521296459));
        r = simd.Fma(r, sq, Vector256.Create(-0.00000002505191090496049));
        r = simd.Fma(r, sq, Vector256.Create(0.00000275573170815073144));
        r = simd.Fma(r, sq, Vector256.Create(-0.00019841269828860068271));
        r = simd.Fma(r, sq, Vector256.Create(0.008333333333299304989001));
        r = simd.Fma(r, sq, Vector256.Create(-0.166666666666663509013977));
        r = simd.Fma(r, sq, Vector256<double>.One);

        r *= xt;

        r = simd.Fma(r, is_neg, is_nan);

        return r;
    }

    #endregion

    #region Sin Cos v512

    [MethodImpl(256 | 512)]
    public static Vector512<double> SinCos(Vector512<double> x) =>
        Sin(x + Vector512.Create(0.0, 0.0, 0.0, 0.0, math.D_Half_PI, math.D_Half_PI, math.D_Half_PI, math.D_Half_PI));

    [MethodImpl(256 | 512)]
    public static Vector512<double> Cos(Vector512<double> x) => Sin(x + Vector512.Create(math.D_Half_PI));

    [MethodImpl(256 | 512)]
    public static Vector512<double> Sin(Vector512<double> x)
    {
        // Since sin() is periodic around 2pi, this converts x into the range of [0, 2pi]
        var xt = Wrap0To2Pi(x);

        // Since sin() in [0, 2pi] is an odd function around pi, this converts the range to [0, pi], then stores whether or not the result needs to be negated in is_neg.
        var is_neg = Vector512.GreaterThan(xt, Vector512.Create(math.D_PI));
        xt -= is_neg & Vector512.Create(math.D_PI);

        is_neg &= Vector512.Create(-2.0);
        is_neg += Vector512<double>.One;

        var is_nan = simd.Ne(x, x);
        is_nan += Vector512.GreaterThan(x, Vector512.Create(double.MaxValue));
        is_nan += Vector512.LessThan(x, Vector512.Create(double.MinValue));

        // Since sin() on [0, pi] is an even function around pi/2, this "folds" the range into [0, pi/2]. I.e. 3pi/5 becomes 2pi/5.
        xt = Vector512.Create(math.D_Half_PI) - Vector512.Abs(xt - Vector512.Create(math.D_Half_PI));

        var sq = xt * xt;
        var r = simd.Fma(sq, Vector512.Create(-0.0000000000007384998082865), Vector512.Create(0.000000000160490521296459));
        r = simd.Fma(r, sq, Vector512.Create(-0.00000002505191090496049));
        r = simd.Fma(r, sq, Vector512.Create(0.00000275573170815073144));
        r = simd.Fma(r, sq, Vector512.Create(-0.00019841269828860068271));
        r = simd.Fma(r, sq, Vector512.Create(0.008333333333299304989001));
        r = simd.Fma(r, sq, Vector512.Create(-0.166666666666663509013977));
        r = simd.Fma(r, sq, Vector512<double>.One);

        r *= xt;

        r = simd.Fma(r, is_neg, is_nan);

        return r;
    }

    #endregion

    #region Tan v128

    /// <summary>
    /// Computes sines in [0,pi/4]
    /// </summary>
    [MethodImpl(256 | 512)]
    public static Vector128<double> SinIn0P4(Vector128<double> x)
    {
        var sq = x * x;

        // This is an odd-only Taylor series approximation of sin() on [0, pi/4]. 
        var r = simd.Fma(sq, Vector128.Create(0.0000000001590238118466), Vector128.Create(-0.0000000250508528135474));
        r = simd.Fma(r, sq, Vector128.Create(0.0000027557314284120030));
        r = simd.Fma(r, sq, Vector128.Create(-0.00019841269831470328245));
        r = simd.Fma(r, sq, Vector128.Create(0.008333333333324419158220));
        r = simd.Fma(r, sq, Vector128.Create(-0.1666666666666663969165095));
        r = simd.Fma(r, sq, Vector128<double>.One);
        r *= x;

        return r;
    }

    [MethodImpl(256 | 512)]
    public static Vector128<double> Tan(Vector128<double> x)
    {
        // Since tan() is periodic around pi, this converts x into the range of [0, pi]
        var xt = Wrap0ToPi(x);

        // Since tan() in [0, pi] is an odd function around pi/2, this converts the range to [0, pi/2], then stores whether or not the result needs to be negated in is_neg.
        var is_neg = Vector128.GreaterThan(xt, Vector128.Create(math.D_Half_PI));
        xt += is_neg & ((xt - Vector128.Create(math.D_Half_PI)) * -2);

        is_neg &= Vector128.Create(-2.0);
        is_neg += Vector128<double>.One;

        var is_nan = simd.Ne(x, x);
        is_nan += Vector128.GreaterThan(x, Vector128.Create(double.MaxValue));
        is_nan += Vector128.LessThan(x, Vector128.Create(double.MinValue));

        // Since tan() on [0, pi/2] is an inversed function around pi/4, this "folds" the range into [0, pi/4]. I.e. 3pi/10 becomes 2pi/10.
        var do_inv_mask = Vector128.GreaterThan(xt, Vector128.Create(math.D_Quarter_PI));
        var no_inv_mask = Vector128.LessThanOrEqual(xt, Vector128.Create(math.D_Quarter_PI));
        xt = Vector128.Create(math.D_Quarter_PI) - Vector128.Abs(xt - Vector128.Create(math.D_Quarter_PI));

        var xx = SinIn0P4(xt);

        xt = Vector128.Sqrt(Vector128<double>.One - xx * xx);

        xx = (do_inv_mask & (xt / xx)) + (no_inv_mask & (xx / xt));

        xx = simd.Fma(xx, is_neg, is_nan);
        return xx;
    }

    #endregion

    #region Tan v256

    /// <summary>
    /// Computes sines in [0,pi/4]
    /// </summary>
    [MethodImpl(256 | 512)]
    public static Vector256<double> SinIn0P4(Vector256<double> x)
    {
        var sq = x * x;

        // This is an odd-only Taylor series approximation of sin() on [0, pi/4]. 
        var r = simd.Fma(sq, Vector256.Create(0.0000000001590238118466), Vector256.Create(-0.0000000250508528135474));
        r = simd.Fma(r, sq, Vector256.Create(0.0000027557314284120030));
        r = simd.Fma(r, sq, Vector256.Create(-0.00019841269831470328245));
        r = simd.Fma(r, sq, Vector256.Create(0.008333333333324419158220));
        r = simd.Fma(r, sq, Vector256.Create(-0.1666666666666663969165095));
        r = simd.Fma(r, sq, Vector256<double>.One);
        r *= x;

        return r;
    }

    [MethodImpl(256 | 512)]
    public static Vector256<double> Tan(Vector256<double> x)
    {
        // Since tan() is periodic around pi, this converts x into the range of [0, pi]
        var xt = Wrap0ToPi(x);

        // Since tan() in [0, pi] is an odd function around pi/2, this converts the range to [0, pi/2], then stores whether or not the result needs to be negated in is_neg.
        var is_neg = Vector256.GreaterThan(xt, Vector256.Create(math.D_Half_PI));
        xt += is_neg & ((xt - Vector256.Create(math.D_Half_PI)) * -2);

        is_neg &= Vector256.Create(-2.0);
        is_neg += Vector256<double>.One;

        var is_nan = simd.Ne(x, x);
        is_nan += Vector256.GreaterThan(x, Vector256.Create(double.MaxValue));
        is_nan += Vector256.LessThan(x, Vector256.Create(double.MinValue));

        // Since tan() on [0, pi/2] is an inversed function around pi/4, this "folds" the range into [0, pi/4]. I.e. 3pi/10 becomes 2pi/10.
        var do_inv_mask = Vector256.GreaterThan(xt, Vector256.Create(math.D_Quarter_PI));
        var no_inv_mask = Vector256.LessThanOrEqual(xt, Vector256.Create(math.D_Quarter_PI));
        xt = Vector256.Create(math.D_Quarter_PI) - Vector256.Abs(xt - Vector256.Create(math.D_Quarter_PI));

        var xx = SinIn0P4(xt);

        xt = Vector256.Sqrt(Vector256<double>.One - xx * xx);

        xx = (do_inv_mask & (xt / xx)) + (no_inv_mask & (xx / xt));

        xx = simd.Fma(xx, is_neg, is_nan);
        return xx;
    }

    #endregion
}
#endif
