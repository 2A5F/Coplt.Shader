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
        var a = new float4(9);
        var r = simd_float.Tan(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(MathF.Tan(9));
    }
    [Test]
    public void Double()
    {
        var a = new double4(9);
        var r = simd_double.Tan(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(Math.Tan(9.0));
    }
    #endif
}
