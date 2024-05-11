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
        var r = simd_float.Sinh(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(MathF.Sinh(9));
    }
    [Test]
    public void Double()
    {
        var a = new double4(9);
        var r = simd_double.Sinh(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(Math.Sinh(9.0));
    }
    #endif
}
