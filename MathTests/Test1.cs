using System.Runtime.CompilerServices;
using System.Text;
using Coplt.Mathematics;

namespace MathTests;

public class Test1
{
    #if NET8_0_OR_GREATER
    [Test]
    public void Foo()
    {
        var a = new float4(123, -1, 0, float.PositiveInfinity);
        var r = simd_log_float.Log2(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(MathF.Log2(123));
    }
    [Test]
    public void Foo2()
    {
        var a = new double4(123, -1, 0, double.PositiveInfinity);
        var r = simd_log_double.Log2(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(Math.Log2(123));
    }
    #endif
}
