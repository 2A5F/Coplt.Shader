#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.Wasm;
using System.Runtime.Intrinsics.X86;

namespace Coplt.Mathematics;

public static partial class simd_log_double
{
    #region Log v128

    [MethodImpl(256 | 512)]
    public static Vector128<double> Log(Vector128<double> a) => Log2(a) * 0.6931471805599453094172321214581766;

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
        rx = simd.Fma(sq, rx, Vector128.Create(0.181837339521549679055568));
        rx = simd.Fma(sq, rx, Vector128.Create(0.22222194152736701733275));
        rx = simd.Fma(sq, rx, Vector128.Create(0.285714288030134544449368));
        rx = simd.Fma(sq, rx, Vector128.Create(0.399999999989941956712869));
        rx = simd.Fma(sq, rx, Vector128.Create(0.666666666666685503450651));
        rx = simd.Fma(sq, rx, Vector128.Create(2.0));

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
    public static Vector256<double> Log(Vector256<double> a) => Log2(a) * 0.6931471805599453094172321214581766;

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
        rx = simd.Fma(sq, rx, Vector256.Create(0.181837339521549679055568));
        rx = simd.Fma(sq, rx, Vector256.Create(0.22222194152736701733275));
        rx = simd.Fma(sq, rx, Vector256.Create(0.285714288030134544449368));
        rx = simd.Fma(sq, rx, Vector256.Create(0.399999999989941956712869));
        rx = simd.Fma(sq, rx, Vector256.Create(0.666666666666685503450651));
        rx = simd.Fma(sq, rx, Vector256.Create(2.0));

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
}
#endif
