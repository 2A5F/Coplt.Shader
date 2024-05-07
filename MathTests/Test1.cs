using System.Runtime.CompilerServices;
using System.Text;
using Coplt.Mathematics;

namespace MathTests;

public class Test1
{
    #if NET8_0_OR_GREATER
    [Test]
    public void Float()
    {
        var a = new float4(-5);
        var b = new float4(2);
        var r = simd_float.Mod(a.UnsafeGetInner(), b.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(-5 % 2);
    }
    [Test]
    public void Double()
    {
        var a = new double4(123.456);
        var b = new double4(456.123);
        var r = simd_double.Mod(a.UnsafeGetInner(), b.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(123.456 % 456.123);
    }
    #endif
}
