using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Text;
using Coplt.Mathematics;

namespace MathTests;

public class Test1
{
    #if NET8_0_OR_GREATER
    [Test]
    public void Float()
    {
        var a = new float4(9);
        var r = simd_float.SinCos(Vector256.Create(a.UnsafeGetInner(), a.UnsafeGetInner()));
        Console.WriteLine(r);
        Console.WriteLine(MathF.SinCos(9));
    }
    [Test]
    public void Double()
    {
        var a = new double4(9);
        var r = simd_double.SinCos(Vector512.Create(a.UnsafeGetInner(), a.UnsafeGetInner()));
        Console.WriteLine(r);
        Console.WriteLine(Math.SinCos(9.0));
    }
    #endif
}
