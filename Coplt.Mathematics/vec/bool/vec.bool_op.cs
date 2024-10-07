// generated by template, do not modify manually

namespace Coplt.Mathematics;

#region float2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static float2 select(this b32v2 c, float2 t, float2 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector64.ConditionalSelect(c.vector.AsSingle(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static float2 select(this bool c, float2 t, float2 f) => c ? t : f;
}

#endregion // float2

#region float3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static float3 select(this b32v3 c, float3 t, float3 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsSingle(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static float3 select(this bool c, float3 t, float3 f) => c ? t : f;
}

#endregion // float3

#region float4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static float4 select(this b32v4 c, float4 t, float4 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsSingle(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static float4 select(this bool c, float4 t, float4 f) => c ? t : f;
}

#endregion // float4

#region double2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static double2 select(this b64v2 c, double2 t, double2 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsDouble(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static double2 select(this bool c, double2 t, double2 f) => c ? t : f;
}

#endregion // double2

#region double3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static double3 select(this b64v3 c, double3 t, double3 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector256.ConditionalSelect(c.vector.AsDouble(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static double3 select(this bool c, double3 t, double3 f) => c ? t : f;
}

#endregion // double3

#region double4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static double4 select(this b64v4 c, double4 t, double4 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector256.ConditionalSelect(c.vector.AsDouble(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static double4 select(this bool c, double4 t, double4 f) => c ? t : f;
}

#endregion // double4

#region short2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static short2 select(this b16v2 c, short2 t, short2 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
    }

    [MethodImpl(256 | 512)]
    public static short2 select(this bool c, short2 t, short2 f) => c ? t : f;
}

#endregion // short2

#region short3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static short3 select(this b16v3 c, short3 t, short3 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
    }

    [MethodImpl(256 | 512)]
    public static short3 select(this bool c, short3 t, short3 f) => c ? t : f;
}

#endregion // short3

#region short4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static short4 select(this b16v4 c, short4 t, short4 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
    }

    [MethodImpl(256 | 512)]
    public static short4 select(this bool c, short4 t, short4 f) => c ? t : f;
}

#endregion // short4

#region ushort2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static ushort2 select(this b16v2 c, ushort2 t, ushort2 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
    }

    [MethodImpl(256 | 512)]
    public static ushort2 select(this bool c, ushort2 t, ushort2 f) => c ? t : f;
}

#endregion // ushort2

#region ushort3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static ushort3 select(this b16v3 c, ushort3 t, ushort3 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
    }

    [MethodImpl(256 | 512)]
    public static ushort3 select(this bool c, ushort3 t, ushort3 f) => c ? t : f;
}

#endregion // ushort3

#region ushort4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static ushort4 select(this b16v4 c, ushort4 t, ushort4 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
    }

    [MethodImpl(256 | 512)]
    public static ushort4 select(this bool c, ushort4 t, ushort4 f) => c ? t : f;
}

#endregion // ushort4

#region int2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static int2 select(this b32v2 c, int2 t, int2 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector64.ConditionalSelect(c.vector.AsInt32(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static int2 select(this bool c, int2 t, int2 f) => c ? t : f;
}

#endregion // int2

#region int3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static int3 select(this b32v3 c, int3 t, int3 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsInt32(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static int3 select(this bool c, int3 t, int3 f) => c ? t : f;
}

#endregion // int3

#region int4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static int4 select(this b32v4 c, int4 t, int4 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsInt32(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static int4 select(this bool c, int4 t, int4 f) => c ? t : f;
}

#endregion // int4

#region uint2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static uint2 select(this b32v2 c, uint2 t, uint2 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector64.ConditionalSelect(c.vector.AsUInt32(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static uint2 select(this bool c, uint2 t, uint2 f) => c ? t : f;
}

#endregion // uint2

#region uint3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static uint3 select(this b32v3 c, uint3 t, uint3 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsUInt32(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static uint3 select(this bool c, uint3 t, uint3 f) => c ? t : f;
}

#endregion // uint3

#region uint4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static uint4 select(this b32v4 c, uint4 t, uint4 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsUInt32(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static uint4 select(this bool c, uint4 t, uint4 f) => c ? t : f;
}

#endregion // uint4

#region long2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static long2 select(this b64v2 c, long2 t, long2 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsInt64(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static long2 select(this bool c, long2 t, long2 f) => c ? t : f;
}

#endregion // long2

#region long3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static long3 select(this b64v3 c, long3 t, long3 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector256.ConditionalSelect(c.vector.AsInt64(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static long3 select(this bool c, long3 t, long3 f) => c ? t : f;
}

#endregion // long3

#region long4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static long4 select(this b64v4 c, long4 t, long4 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector256.ConditionalSelect(c.vector.AsInt64(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static long4 select(this bool c, long4 t, long4 f) => c ? t : f;
}

#endregion // long4

#region ulong2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static ulong2 select(this b64v2 c, ulong2 t, ulong2 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsUInt64(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static ulong2 select(this bool c, ulong2 t, ulong2 f) => c ? t : f;
}

#endregion // ulong2

#region ulong3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static ulong3 select(this b64v3 c, ulong3 t, ulong3 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector256.ConditionalSelect(c.vector.AsUInt64(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static ulong3 select(this bool c, ulong3 t, ulong3 f) => c ? t : f;
}

#endregion // ulong3

#region ulong4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static ulong4 select(this b64v4 c, ulong4 t, ulong4 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector256.ConditionalSelect(c.vector.AsUInt64(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static ulong4 select(this bool c, ulong4 t, ulong4 f) => c ? t : f;
}

#endregion // ulong4

#region half2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static half2 select(this b16v2 c, half2 t, half2 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
    }

    [MethodImpl(256 | 512)]
    public static half2 select(this bool c, half2 t, half2 f) => c ? t : f;
}

#endregion // half2

#region half3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static half3 select(this b16v3 c, half3 t, half3 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
    }

    [MethodImpl(256 | 512)]
    public static half3 select(this bool c, half3 t, half3 f) => c ? t : f;
}

#endregion // half3

#region half4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static half4 select(this b16v4 c, half4 t, half4 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
    }

    [MethodImpl(256 | 512)]
    public static half4 select(this bool c, half4 t, half4 f) => c ? t : f;
}

#endregion // half4

#region b16v2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b16v2 select(this b16v2 c, b16v2 t, b16v2 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
    }

    [MethodImpl(256 | 512)]
    public static b16v2 select(this bool c, b16v2 t, b16v2 f) => c ? t : f;
}

#endregion // b16v2

#region b16v3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b16v3 select(this b16v3 c, b16v3 t, b16v3 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
    }

    [MethodImpl(256 | 512)]
    public static b16v3 select(this bool c, b16v3 t, b16v3 f) => c ? t : f;
}

#endregion // b16v3

#region b16v4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b16v4 select(this b16v4 c, b16v4 t, b16v4 f) 
    {
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
    }

    [MethodImpl(256 | 512)]
    public static b16v4 select(this bool c, b16v4 t, b16v4 f) => c ? t : f;
}

#endregion // b16v4

#region b32v2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b32v2 select(this b32v2 c, b32v2 t, b32v2 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector64.ConditionalSelect(c.vector.AsUInt32(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static b32v2 select(this bool c, b32v2 t, b32v2 f) => c ? t : f;
}

#endregion // b32v2

#region b32v3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b32v3 select(this b32v3 c, b32v3 t, b32v3 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsUInt32(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static b32v3 select(this bool c, b32v3 t, b32v3 f) => c ? t : f;
}

#endregion // b32v3

#region b32v4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b32v4 select(this b32v4 c, b32v4 t, b32v4 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsUInt32(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static b32v4 select(this bool c, b32v4 t, b32v4 f) => c ? t : f;
}

#endregion // b32v4

#region b64v2

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b64v2 select(this b64v2 c, b64v2 t, b64v2 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector128.ConditionalSelect(c.vector.AsUInt64(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static b64v2 select(this bool c, b64v2 t, b64v2 f) => c ? t : f;
}

#endregion // b64v2

#region b64v3

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b64v3 select(this b64v3 c, b64v3 t, b64v3 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector256.ConditionalSelect(c.vector.AsUInt64(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static b64v3 select(this bool c, b64v3 t, b64v3 f) => c ? t : f;
}

#endregion // b64v3

#region b64v4

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b64v4 select(this b64v4 c, b64v4 t, b64v4 f) 
    {
        #if NET8_0_OR_GREATER
        return new(Vector256.ConditionalSelect(c.vector.AsUInt64(), t.vector, f.vector));
        #else // NET8_0_OR_GREATER
        return new(c.x ? t.x : f.x, c.y ? t.y : f.y, c.z ? t.z : f.z, c.w ? t.w : f.w);
        #endif // NET8_0_OR_GREATER
    }

    [MethodImpl(256 | 512)]
    public static b64v4 select(this bool c, b64v4 t, b64v4 f) => c ? t : f;
}

#endregion // b64v4
