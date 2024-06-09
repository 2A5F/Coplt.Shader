using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Text;
using Coplt.Mathematics;
#if NET8_0_OR_GREATER
using Coplt.Mathematics.Simd;
#endif

namespace MathTests;

public class Test1
{
    #if NET8_0_OR_GREATER
    [Test]
    public void Foo()
    {
        // var a = new double4(1, 2, 3, 4).UnsafeGetInner();
        // var b = new double4(5, 6, 7, 8).UnsafeGetInner();
        // var r = simd_shuffle.Shuffle(a, b, Shuffle42.zx_xz);
        // Console.WriteLine(r);
        var a = new float4(.1f, .2f, .3f, .4f);
        var b = new float4(.5f, .6f, .7f, .8f);
        var c = new float4(.9f, .10f, .11f, .12f);
        var d = new float4(.13f, .14f, .15f, .16f);
        var r = math.inverse(new float4x4(a, b, c, d));
        Console.WriteLine(r.c0);
        Console.WriteLine(r.c1);
        Console.WriteLine(r.c2);
        Console.WriteLine(r.c3);
    }

    [Test]
    public void Float()
    {
        var a = new float4(9);
        var r = simd_float.AsinhAcosh(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(MathF.Acosh(9));
    }
    [Test]
    public void Double()
    {
        var a = new double4(9);
        var r = simd_double.AsinhAcosh(a.UnsafeGetInner());
        Console.WriteLine(r);
        Console.WriteLine(Math.Acosh(9.0));
    }
    #endif
}
