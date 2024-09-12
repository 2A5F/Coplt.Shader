using Coplt.Mathematics;
using Coplt.Shader.Shaders.Markers;

namespace Coplt.Shader.Shaders;

public static partial class Shader
{
    #region Sample

    public static T Sample<T>(this ITexture<Sampled, D1, Single, T> tex, SamplerState ss, float coords) => GpuOnly<T>();
    public static T Sample<T>(this ITexture<Sampled, D2, Single, T> tex, SamplerState ss, float2 coords) => GpuOnly<T>();
    public static T Sample<T>(this ITexture<Sampled, D3, Single, T> tex, SamplerState ss, float3 coords) => GpuOnly<T>();
    public static T Sample<T>(this ITexture<Sampled, Cube, Single, T> tex, SamplerState ss, float3 coords) => GpuOnly<T>();

    public static T Sample<T>(this ITexture<Sampled, D1, Array, T> tex, SamplerState ss, float coords, int index) => GpuOnly<T>();
    public static T Sample<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerState ss, float2 coords, int index) => GpuOnly<T>();
    public static T Sample<T>(this ITexture<Sampled, Cube, Array, T> tex, SamplerState ss, float3 coords, int index) => GpuOnly<T>();

    public static T Sample<T>(this ITexture<Sampled, D1, Array, T> tex, SamplerState ss, float coords, uint index) => GpuOnly<T>();
    public static T Sample<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerState ss, float2 coords, uint index) => GpuOnly<T>();
    public static T Sample<T>(this ITexture<Sampled, Cube, Array, T> tex, SamplerState ss, float3 coords, uint index) => GpuOnly<T>();

    #endregion

    #region SampleBias

    public static T SampleBias<T>(this ITexture<Sampled, D2, Single, T> tex, SamplerState ss, float2 coords, float bias) => GpuOnly<T>();
    public static T SampleBias<T>(this ITexture<Sampled, D2, Single, T> tex, SamplerState ss, float2 coords, float bias, int2 offset) => GpuOnly<T>();

    public static T SampleBias<T>(this ITexture<Sampled, D3, Single, T> tex, SamplerState ss, float3 coords, float bias) => GpuOnly<T>();
    public static T SampleBias<T>(this ITexture<Sampled, Cube, Single, T> tex, SamplerState ss, float3 coords, float bias) => GpuOnly<T>();

    public static T SampleBias<T>(this ITexture<Sampled, D3, Single, T> tex, SamplerState ss, float3 coords, float bias, int3 offset) => GpuOnly<T>();

    public static T SampleBias<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerState ss, float2 coords, int index, float bias) => GpuOnly<T>();
    public static T SampleBias<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerState ss, float2 coords, int index, float bias, int2 offset) => GpuOnly<T>();

    public static T SampleBias<T>(this ITexture<Sampled, Cube, Array, T> tex, SamplerState ss, float3 coords, int index, float bias) => GpuOnly<T>();

    #endregion

    #region SampleCompare

    public static float SampleCmp<T>(this ITexture<Sampled, D2, Single, T> tex, SamplerComparisonState ss, float2 coord, float depth_ref) => GpuOnly<float>();
    public static float SampleCmp<T>(this ITexture<Sampled, D2, Single, T> tex, SamplerComparisonState ss, float2 coord, float depth_ref, int2 offset) => GpuOnly<float>();

    public static float SampleCmp<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerComparisonState ss, float2 coord, int index, float depth_ref) => GpuOnly<float>();
    public static float SampleCmp<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerComparisonState ss, float2 coord, int index, float depth_ref, int2 offset) =>
        GpuOnly<float>();

    public static float SampleCmp<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerComparisonState ss, float2 coord, uint index, float depth_ref) => GpuOnly<float>();
    public static float SampleCmp<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerComparisonState ss, float2 coord, uint index, float depth_ref, int2 offset) =>
        GpuOnly<float>();

    public static float SampleCmp<T>(this ITexture<Sampled, Cube, Single, T> tex, SamplerComparisonState ss, float3 coord, float depth_ref) => GpuOnly<float>();

    public static float SampleCmp<T>(this ITexture<Sampled, Cube, Array, T> tex, SamplerComparisonState ss, float3 coord, int index, float depth_ref) => GpuOnly<float>();
    public static float SampleCmp<T>(this ITexture<Sampled, Cube, Array, T> tex, SamplerComparisonState ss, float3 coord, uint index, float depth_ref) => GpuOnly<float>();

    #endregion

    #region SampleCompareLevel0

    public static float SampleCmpLevel0<T>(this ITexture<Sampled, D2, Single, T> tex, SamplerComparisonState ss, float2 coord, float depth_ref) => GpuOnly<float>();
    public static float SampleCmpLevel0<T>(this ITexture<Sampled, D2, Single, T> tex, SamplerComparisonState ss, float2 coord, float depth_ref, int2 offset) => GpuOnly<float>();

    public static float SampleCmpLevel0<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerComparisonState ss, float2 coord, int index, float depth_ref) => GpuOnly<float>();
    public static float SampleCmpLevel0<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerComparisonState ss, float2 coord, int index, float depth_ref, int2 offset) =>
        GpuOnly<float>();

    public static float SampleCmpLevel0<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerComparisonState ss, float2 coord, uint index, float depth_ref) => GpuOnly<float>();
    public static float SampleCmpLevel0<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerComparisonState ss, float2 coord, uint index, float depth_ref, int2 offset) =>
        GpuOnly<float>();

    public static float SampleCmpLevel0<T>(this ITexture<Sampled, Cube, Single, T> tex, SamplerComparisonState ss, float3 coord, float depth_ref) => GpuOnly<float>();

    public static float SampleCmpLevel0<T>(this ITexture<Sampled, Cube, Array, T> tex, SamplerComparisonState ss, float3 coord, int index, float depth_ref) => GpuOnly<float>();
    public static float SampleCmpLevel0<T>(this ITexture<Sampled, Cube, Array, T> tex, SamplerComparisonState ss, float3 coord, uint index, float depth_ref) => GpuOnly<float>();

    #endregion

    #region SampleGrad

    public static T SampleGrad<T>(this ITexture<Sampled, D2, Single, T> tex, SamplerState ss, float2 coords, float2 ddx, float2 ddy) => GpuOnly<T>();
    public static T SampleGrad<T>(this ITexture<Sampled, D3, Single, T> tex, SamplerState ss, float3 coords, float3 ddx, float3 ddy) => GpuOnly<T>();
    public static T SampleGrad<T>(this ITexture<Sampled, Cube, Single, T> tex, SamplerState ss, float3 coords, float3 ddx, float3 ddy) => GpuOnly<T>();

    public static T SampleGrad<T>(this ITexture<Sampled, D2, Single, T> tex, SamplerState ss, float2 coords, float2 ddx, float2 ddy, int2 offset) => GpuOnly<T>();
    public static T SampleGrad<T>(this ITexture<Sampled, D3, Single, T> tex, SamplerState ss, float3 coords, float3 ddx, float3 ddy, int3 offset) => GpuOnly<T>();

    public static T SampleGrad<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerState ss, float2 coords, int index, float2 ddx, float2 ddy) => GpuOnly<T>();
    public static T SampleGrad<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerState ss, float2 coords, uint index, float2 ddx, float2 ddy) => GpuOnly<T>();

    public static T SampleGrad<T>(this ITexture<Sampled, Cube, Array, T> tex, SamplerState ss, float3 coords, int index, float3 ddx, float3 ddy) => GpuOnly<T>();
    public static T SampleGrad<T>(this ITexture<Sampled, Cube, Array, T> tex, SamplerState ss, float3 coords, uint index, float3 ddx, float3 ddy) => GpuOnly<T>();

    #endregion

    #region SampleLevel

    public static T SampleLevel<T>(this ITexture<Sampled, D2, Single, T> tex, SamplerState ss, float2 coords, float level) => GpuOnly<T>();
    public static T SampleLevel<T>(this ITexture<Sampled, D3, Single, T> tex, SamplerState ss, float3 coords, float level) => GpuOnly<T>();
    public static T SampleLevel<T>(this ITexture<Sampled, Cube, Single, T> tex, SamplerState ss, float3 coords, float level) => GpuOnly<T>();

    public static T SampleLevel<T>(this ITexture<Sampled, D2, Single, T> tex, SamplerState ss, float2 coords, float level, int2 offset) => GpuOnly<T>();
    public static T SampleLevel<T>(this ITexture<Sampled, D3, Single, T> tex, SamplerState ss, float3 coords, float level, int3 offset) => GpuOnly<T>();

    public static T SampleLevel<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerState ss, float2 coords, int index, float level) => GpuOnly<T>();
    public static T SampleLevel<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerState ss, float2 coords, uint index, float level) => GpuOnly<T>();

    public static T SampleLevel<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerState ss, float2 coords, int index, float level, int2 offset) => GpuOnly<T>();
    public static T SampleLevel<T>(this ITexture<Sampled, D2, Array, T> tex, SamplerState ss, float2 coords, uint index, float level, int2 offset) => GpuOnly<T>();

    public static T SampleLevel<T>(this ITexture<Sampled, Cube, Array, T> tex, SamplerState ss, float3 coords, int index, float level) => GpuOnly<T>();
    public static T SampleLevel<T>(this ITexture<Sampled, Cube, Array, T> tex, SamplerState ss, float3 coords, uint index, float level) => GpuOnly<T>();

    #endregion
}
