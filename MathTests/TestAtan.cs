﻿using System.Runtime.Intrinsics;
using Coplt.Mathematics;

#if NET8_0_OR_GREATER
using Coplt.Mathematics.Simd;

namespace MathTests;

[Parallelizable]
public class TestAtan
{
    [Test]
    [Parallelizable]
    public void FloatTestATan([Random(-12f, 12f, 1000)] float x)
    {
        var a = simd_math.Atan(new float4(x).UnsafeGetInner()).GetElement(0);
        var b = MathF.Atan(x);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(b, Is.EqualTo(a).Within(2).Ulps);
    }
    
    [Test]
    [Parallelizable]
    public void DoubleTestATan([Random(-12f, 12f, 1000)] double x)
    {
        var a = simd_math.Atan(new double4(x).UnsafeGetInner()).GetElement(0);
        var b = Math.Atan(x);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Assert.That(b, Is.EqualTo(a).Within(2).Ulps);
    }
}

#endif
