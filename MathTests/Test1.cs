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
        var a = new float4(1);
        var r = simd_float.Sin(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(MathF.Sin(1));
    }
    [Test]
    public void Double()
    {
        var a = new double4(1);
        var r = simd_double.Sin(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(Math.Sin(1.0));
    }
    #endif
}
