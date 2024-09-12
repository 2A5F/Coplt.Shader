using Coplt.Mathematics;
using Coplt.Shader.Shaders.Markers;

namespace Coplt.Shader.Shaders;

public static partial class Shader
{
    #region Dimensions

    public static uint Dimensions<T>(this ITexture<object, D1, object, T> tex) => throw GpuOnlyErr();

    public static uint2 Dimensions<T>(this ITexture<object, D2, object, T> tex) => throw GpuOnlyErr();
    public static uint2 Dimensions<T>(this ITexture<object, Cube, object, T> tex) => throw GpuOnlyErr();

    public static uint3 Dimensions<T>(this ITexture<object, D3, object, T> tex) => throw GpuOnlyErr();

    public static uint Dimensions<T>(this ITexture<Sampled, D1, object, T> tex, int level) => throw GpuOnlyErr();
    public static uint Dimensions<T>(this ITexture<Sampled, D1, object, T> tex, uint level) => throw GpuOnlyErr();

    public static uint2 Dimensions<T>(this ITexture<Sampled, D2, object, T> tex, int level) => throw GpuOnlyErr();
    public static uint2 Dimensions<T>(this ITexture<Sampled, D2, object, T> tex, uint level) => throw GpuOnlyErr();
    public static uint2 Dimensions<T>(this ITexture<Sampled, Cube, object, T> tex, int level) => throw GpuOnlyErr();
    public static uint2 Dimensions<T>(this ITexture<Sampled, Cube, object, T> tex, uint level) => throw GpuOnlyErr();

    public static uint3 Dimensions<T>(this ITexture<Sampled, D3, object, T> tex, int level) => throw GpuOnlyErr();
    public static uint3 Dimensions<T>(this ITexture<Sampled, D3, object, T> tex, uint level) => throw GpuOnlyErr();

    #endregion

    #region Length

    public static uint Length<T>(this ITexture<object, object, Array, T> tex) => throw GpuOnlyErr();

    #endregion

    #region Levels

    public static uint NumLevels<T>(this ITexture<Sampled, object, object, T> tex) => throw GpuOnlyErr();

    #endregion

    #region Levels

    public static uint NumSamples<T>(this ITexture<MultiSampled, object, object, T> tex) => throw GpuOnlyErr();

    #endregion
}
