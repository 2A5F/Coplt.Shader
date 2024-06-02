using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Text;
using Coplt.Mathematics;

namespace MathTests;

public class Test1
{
    #if NET8_0_OR_GREATER
    [Test]
    public void Foo()
    {
        var a = new double3(1, 1, 1);
        var r = double4x4.AxisAngle(a, 45);
        Console.WriteLine(r.c0);
        Console.WriteLine(r.c1);
        Console.WriteLine(r.c2);
        Console.WriteLine(r.c3);

        var rr = Matrix4x4.CreateFromAxisAngle(new Vector3(1, 1, 1), 45);
        Console.WriteLine(rr);
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
