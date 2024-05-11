using System.Runtime.Intrinsics;
using Coplt.Mathematics;

#if NET8_0_OR_GREATER
namespace MathTests;

public class TestAsinhAcosh
{
    [Test]
    [Parallelizable]
    public void FloatTestAsinh([Random(-10f, 10.0f, 100)] float x)
    {
        var a = simd_float.Asinh(new float4(x).UnsafeGetInner()).GetElement(0);
        var b = MathF.Asinh(x);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(b, Is.EqualTo(a).Within(0.001f).Percent);
    }

    [Test]
    [Parallelizable]
    public void DoubleTestAsinh([Random(-10, 10.0, 100)] double x)
    {
        var a = simd_double.Asinh(new double4(x).UnsafeGetInner()).GetElement(0);
        var b = Math.Asinh(x);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(b, Is.EqualTo(a).Within(0.000_000_000_1f).Percent);
    }
    
    [Test]
    [Parallelizable]
    public void FloatTestAcosh([Random(1, 10.0f, 100)] float x)
    {
        var a = simd_float.Acosh(new float4(x).UnsafeGetInner()).GetElement(0);
        var b = MathF.Acosh(x);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(b, Is.EqualTo(a).Within(0.001f).Percent);
    }

    [Test]
    [Parallelizable]
    public void DoubleTestAcosh([Random(1, 10.0, 100)] double x)
    {
        var a = simd_double.Acosh(new double4(x).UnsafeGetInner()).GetElement(0);
        var b = Math.Acosh(x);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(b, Is.EqualTo(a).Within(0.000_000_000_1f).Percent);
    }
}

#endif
