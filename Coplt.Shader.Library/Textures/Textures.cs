using Coplt.Mathematics;

namespace Coplt.Shader.Shaders;

public struct Texture1d<T>;
public struct Texture2d<T>;
public struct Texture3d<T>;
public struct Texture1dArray<T>;
public struct Texture2dArray<T>;
public struct TextureCube<T>;
public struct TextureCubeArray<T>;

public static partial class ShaderOp
{
    #region Load

    public static T Load<T, C>(this Texture1d<T> tex, C coords) => GpuOnly<T>();
    public static T Load<T, C>(this Texture2d<T> tex, C coords) => GpuOnly<T>();
    public static T Load<T, C>(this Texture3d<T> tex, C coords) => GpuOnly<T>();

    public static T Load<T, C, I>(this Texture1dArray<T> tex, C coords, I index) => GpuOnly<T>();
    public static T Load<T, C, I>(this Texture2dArray<T> tex, C coords, I index) => GpuOnly<T>();

    #endregion

    #region Sample

    public static T Sample<T>(this Texture1d<T> tex, SamplerState ss, float coords) => GpuOnly<T>();
    public static T Sample<T>(this Texture2d<T> tex, SamplerState ss, float2 coords) => GpuOnly<T>();
    public static T Sample<T>(this Texture3d<T> tex, SamplerState ss, float3 coords) => GpuOnly<T>();
    public static T Sample<T>(this TextureCube<T> tex, SamplerState ss, float3 coords) => GpuOnly<T>();

    public static T Sample<T, I>(this Texture1dArray<T> tex, SamplerState ss, float coords, I index) => GpuOnly<T>();
    public static T Sample<T, I>(this Texture2dArray<T> tex, SamplerState ss, float2 coords, I index) => GpuOnly<T>();
    public static T Sample<T, I>(this TextureCubeArray<T> tex, SamplerState ss, float3 coords, I index) => GpuOnly<T>();

    #endregion

    #region SampleLod

    public static T SampleLod<T, L>(this Texture1d<T> tex, SamplerState ss, float coords, L lod) => GpuOnly<T>();
    public static T SampleLod<T, L>(this Texture2d<T> tex, SamplerState ss, float2 coords, L lod) => GpuOnly<T>();
    public static T SampleLod<T, L>(this Texture3d<T> tex, SamplerState ss, float3 coords, L lod) => GpuOnly<T>();
    public static T SampleLod<T, L>(this TextureCube<T> tex, SamplerState ss, float3 coords, L lod) => GpuOnly<T>();

    public static T SampleLod<T, I, L>(this Texture1dArray<T> tex, SamplerState ss, float coords, I index, L lod) => GpuOnly<T>();
    public static T SampleLod<T, I, L>(this Texture2dArray<T> tex, SamplerState ss, float2 coords, I index, L lod) => GpuOnly<T>();
    public static T SampleLod<T, I, L>(this TextureCubeArray<T> tex, SamplerState ss, float3 coords, I index, L lod) => GpuOnly<T>();

    #endregion

    #region SampleBias

    public static T SampleBias<T>(this Texture1d<T> tex, SamplerState ss, float coords, float bias) => GpuOnly<T>();
    public static T SampleBias<T>(this Texture2d<T> tex, SamplerState ss, float2 coords, float bias) => GpuOnly<T>();
    public static T SampleBias<T>(this Texture3d<T> tex, SamplerState ss, float3 coords, float bias) => GpuOnly<T>();
    public static T SampleBias<T>(this TextureCube<T> tex, SamplerState ss, float3 coords, float bias) => GpuOnly<T>();

    public static T SampleBias<T, I>(this Texture1dArray<T> tex, SamplerState ss, float coords, I index, float bias) => GpuOnly<T>();
    public static T SampleBias<T, I>(this Texture2dArray<T> tex, SamplerState ss, float2 coords, I index, float bias) => GpuOnly<T>();
    public static T SampleBias<T, I>(this TextureCubeArray<T> tex, SamplerState ss, float3 coords, I index, float bias) => GpuOnly<T>();

    #endregion

    #region SampleGrad

    public static T SampleGrad<T>(this Texture1d<T> tex, SamplerState ss, float coords, float ddx, float ddy) => GpuOnly<T>();
    public static T SampleGrad<T>(this Texture2d<T> tex, SamplerState ss, float2 coords, float2 ddx, float2 ddy) => GpuOnly<T>();
    public static T SampleGrad<T>(this Texture3d<T> tex, SamplerState ss, float3 coords, float3 ddx, float3 ddy) => GpuOnly<T>();
    public static T SampleGrad<T>(this TextureCube<T> tex, SamplerState ss, float3 coords, float3 ddx, float3 ddy) => GpuOnly<T>();

    public static T SampleGrad<T, I>(this Texture1dArray<T> tex, SamplerState ss, float coords, I index, float ddx, float ddy) => GpuOnly<T>();
    public static T SampleGrad<T, I>(this Texture2dArray<T> tex, SamplerState ss, float2 coords, I index, float2 ddx, float2 ddy) => GpuOnly<T>();
    public static T SampleGrad<T, I>(this TextureCubeArray<T> tex, SamplerState ss, float3 coords, I index, float3 ddx, float3 ddy) => GpuOnly<T>();

    #endregion

    #region SampleDepth

    public static T SampleDepth<T>(this Texture2d<T> tex, SamplerState ss, float2 coords) => GpuOnly<T>();

    #endregion

    #region SampleDepthLod

    public static T SampleDepthLod<T, L>(this Texture2d<T> tex, SamplerState ss, float2 coords, L lod) => GpuOnly<T>();

    #endregion
}
