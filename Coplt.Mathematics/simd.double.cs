#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.Wasm;
using System.Runtime.Intrinsics.X86;

namespace Coplt.Mathematics;

public static partial class simd_double
{
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
        var r = Exp2(Log2(Vector128.Abs(a)) * b);
        return r;
    }
    
    [MethodImpl(256 | 512)]
    public static Vector128<double> Pow(Vector128<double> a, double b)
    {
        var r = Exp2(Log2(Vector128.Abs(a)) * b);
        return r;
    }

    #endregion

    #region Pow v256

    [MethodImpl(256 | 512)]
    public static Vector256<double> Pow(Vector256<double> a, Vector256<double> b)
    {
        var r = Exp2(Log2(Vector256.Abs(a)) * b);
        return r;
    }
    
    [MethodImpl(256 | 512)]
    public static Vector256<double> Pow(Vector256<double> a, double b)
    {
        var r = Exp2(Log2(Vector256.Abs(a)) * b);
        return r;
    }

    #endregion
}
#endif
