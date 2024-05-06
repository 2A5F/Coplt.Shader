using System.Runtime.CompilerServices;
using System.Text;
using Coplt.Mathematics;

namespace MathTests;

public class Test1
{
    #if NET8_0_OR_GREATER
    [Test]
    public void LogFloat()
    {
        var a = new float4(123, -1, 0, float.PositiveInfinity);
        var r = simd_float.Log2(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(MathF.Log2(123));
    }
    [Test]
    public void LogDouble()
    {
        var a = new double4(123, -1, 0, double.PositiveInfinity);
        var r = simd_double.Log2(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(Math.Log2(123));
    }
    [Test]
    public void ExpFloat()
    {
        var a = new float4(3, float.NaN, float.NegativeInfinity, float.PositiveInfinity);
        var r = simd_float.Exp(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine($"<{MathF.Exp(3)}, {MathF.Exp(float.NaN)}, {MathF.Exp(float.NegativeInfinity)}, {MathF.Exp(float.PositiveInfinity)}>");
    }
    [Test]
    public void ExpDouble()
    {
        var a = new double4(3, double.NaN, double.NegativeInfinity, double.PositiveInfinity);
        var r = simd_double.Exp(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine($"<{Math.Exp(3)}, {Math.Exp(double.NaN)}, {Math.Exp(double.NegativeInfinity)}, {Math.Exp(double.PositiveInfinity)}>");
    }
    #endif
}
