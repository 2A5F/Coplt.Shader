using System.Runtime.Intrinsics;
using Coplt.Mathematics;

#if NET8_0_OR_GREATER
using Coplt.Mathematics.Simd;

namespace MathTests;

[Parallelizable]
public class TestAtan2
{
    [Test]
    [Parallelizable]
    public void FloatTestATan2([Random(-10f, 10f, 50)] float x, [Random(-10f, 10f, 50)] float y)
    {
        var a = simd_math.Atan2(new float4(x).UnsafeGetInner(), new float4(y).UnsafeGetInner()).GetElement(0);
        var b = MathF.Atan2(x, y);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(b, Is.EqualTo(a).Within(2).Ulps);
    }

    [Test]
    [Parallelizable]
    [TestCase(0f, -0f, float.Pi)]
    [TestCase(0f, 0f, 0f)]
    [TestCase(float.PositiveInfinity, 0f, float.Pi / 2)]
    [TestCase(float.PositiveInfinity, float.NegativeInfinity, 3 * float.Pi / 4)]
    [TestCase(float.PositiveInfinity, float.PositiveInfinity, float.Pi / 4)]
    [TestCase(-1f, 0f, -float.Pi / 2)]
    [TestCase(1f, 0f, float.Pi / 2)]
    [TestCase(1f, float.NegativeInfinity, float.Pi)]
    [TestCase(-1f, float.NegativeInfinity, -float.Pi)]
    [TestCase(1f, float.PositiveInfinity, 0)]
    [TestCase(-1f, float.PositiveInfinity, -0)]
    [TestCase(float.NaN, float.NaN, float.NaN)]
    public void FloatTestATan2Error1(float y, float x, float r)
    {
        var a = simd_math.Atan2(new float4(y).UnsafeGetInner(), new float4(x).UnsafeGetInner()).GetElement(0);
        Console.WriteLine($"{a}");
        Assert.That(a, Is.EqualTo(r));
    }

    // [Test]
    // [Parallelizable]
    // public void DoubleTestATan([Random(-12f, 12f, 1000)] double x)
    // {
    //     var a = simd_math.Atan(new double4(x).UnsafeGetInner()).GetElement(0);
    //     var b = Math.Atan(x);
    //     Console.WriteLine($"{a}");
    //     Console.WriteLine($"{b}");
    //     Assert.That(b, Is.EqualTo(a).Within(2).Ulps);
    // }
}

#endif
