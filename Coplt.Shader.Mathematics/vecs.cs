#if NET8_0_OR_GREATER
using System.Numerics;
using System.Runtime.Intrinsics;
#endif

namespace Coplt.Shader.Mathematics;

public struct float2
{
#if NET8_0_OR_GREATER
    public Vector64<float> inner;

    public float x => inner.GetElement(0);
    public float y => inner.GetElement(1);
#else
    public float x { get; set; }
    public float y { get; set; }
#endif
}

public struct float3
{
#if NET8_0_OR_GREATER
    public Vector128<float> inner;

    public float x => inner.GetElement(0);
    public float y => inner.GetElement(1);
    public float z => inner.GetElement(2);
#endif
}

public struct float4
{
#if NET8_0_OR_GREATER
    public Vector128<float> inner;

    public float x => inner.GetElement(0);
    public float y => inner.GetElement(1);
    public float z => inner.GetElement(2);
    public float w => inner.GetElement(3);
#endif
}

public struct int2
{
#if NET8_0_OR_GREATER
    public Vector64<int> inner;
#endif
}

public struct int3
{
#if NET8_0_OR_GREATER
    public Vector128<int> inner;
#endif
}

public struct int4
{
#if NET8_0_OR_GREATER
    public Vector128<int> inner;
#endif
}


public struct uint2
{
#if NET8_0_OR_GREATER
    public Vector64<int> inner;
#endif
}

public struct uint3
{
#if NET8_0_OR_GREATER
    public Vector128<int> inner;
#endif
}

public struct uint4
{
#if NET8_0_OR_GREATER
    public Vector128<int> inner;
#endif
}
