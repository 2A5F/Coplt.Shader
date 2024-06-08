using System.Runtime.Intrinsics;
using Coplt.Mathematics;

#if NET8_0_OR_GREATER
using Coplt.Mathematics.Simd;
namespace MathTests;

public class TestLog
{
    [Test]
    [Parallelizable]
    public void FloatTestLog2([Random(0.000_1f, 1_000_000.0f, 1000)] float v)
    {
        var a = simd_float.Log2(new float4(v).UnsafeGetInner()).GetElement(0);
        var b = MathF.Log2(v);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(a, Is.EqualTo(b).Within(0.000_1f).Percent);
    }
    
    [Test]
    [Parallelizable]
    public void FloatTestLog2_vec_2_4([Random(0.000_1f, 1_000_000.0f, 1000)] float v)
    {
        var a = simd_float.Log2(new float4(v).UnsafeGetInner()).GetElement(0);
        var b = simd_float.Log2(new float2(v).UnsafeGetInner()).GetElement(0);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(a, Is.EqualTo(b));
    }
    
    [Test]
    [Parallelizable]
    public void FloatTestLog2Err([Values(0, float.NaN, float.NegativeInfinity, float.PositiveInfinity)] float v)
    {
        var a = simd_float.Log2(new float4(v).UnsafeGetInner()).GetElement(0);
        var b = MathF.Log2(v);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(b, Is.EqualTo(a));
    }
    
    [Test]
    [Parallelizable]
    public void DoubleTestLog2([Random(0.000_1f, 1_000_000.0f, 1000)] double v)
    {
        var a = simd_double.Log2(new double4(v).UnsafeGetInner()).GetElement(0);
        var b = Math.Log2(v);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(a, Is.EqualTo(b).Within(0.000_000_000_1f).Percent);
    }
    
    [Test]
    [Parallelizable]
    public void DoubleTestLog2_vec_2_4([Random(0.000_1f, 1_000_000.0f, 1000)] double v)
    {
        var a = simd_double.Log2(new double4(v).UnsafeGetInner()).GetElement(0);
        var b = simd_double.Log2(new double2(v).UnsafeGetInner()).GetElement(0);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(a, Is.EqualTo(b));
    }
    
    [Test]
    [Parallelizable]
    public void DoubleTestLog2Err([Values(0, double.NaN, double.NegativeInfinity, double.PositiveInfinity)] double v)
    {
        var a = simd_double.Log2(new double4(v).UnsafeGetInner()).GetElement(0);
        var b = Math.Log2(v);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(b, Is.EqualTo(a));
    }
}

#endif
