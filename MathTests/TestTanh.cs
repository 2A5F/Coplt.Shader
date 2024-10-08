using System.Runtime.Intrinsics;
using Coplt.Mathematics;

#if NET8_0_OR_GREATER
using Coplt.Mathematics.Simd;
namespace MathTests;

public class TestTanh
{
    [Test]
    [Parallelizable]
    public void FloatTestTanh([Random(-10f, 10.0f, 100)] float x)
    {
        var a = simd_math.Tanh(new float4(x).UnsafeGetInner()).GetElement(0);
        var b = MathF.Tanh(x);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(b, Is.EqualTo(a).Within(0.001f).Percent);
    }

    [Test]
    [Parallelizable]
    public void DoubleTestTanh([Random(-10, 10.0, 100)] double x)
    {
        var a = simd_math.Tanh(new double4(x).UnsafeGetInner()).GetElement(0);
        var b = Math.Tanh(x);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(b, Is.EqualTo(a).Within(0.000_000_000_1f).Percent);
    }
}

#endif
