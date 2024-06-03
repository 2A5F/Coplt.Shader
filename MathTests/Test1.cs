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
        var a = new float3(1, 1, 1);
        var r = quaternion.AxisAngle(a, 45);
        var m = new float3x3(r);
        Console.WriteLine(m);

        var r2 = Quaternion.CreateFromAxisAngle(new Vector3(1, 1, 1), 45);
        var m2 = Matrix4x4.CreateFromQuaternion(r2);
        Console.WriteLine(m2);
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
