using Coplt.Mathematics;
using Coplt.Shader.Shaders.Markers;

namespace Coplt.Shader.Shaders;

public static partial class Shader
{
    #region Load

    public static T Load<T>(this ITexture<object, D1, Single, T> tex, int coords) => GpuOnly<T>();
    public static T Load<T>(this ITexture<object, D2, Single, T> tex, int2 coords) => GpuOnly<T>();
    public static T Load<T>(this ITexture<object, D3, Single, T> tex, int3 coords) => GpuOnly<T>();

    public static T Load<T>(this ITexture<object, D1, Single, T> tex, uint coords) => GpuOnly<T>();
    public static T Load<T>(this ITexture<object, D2, Single, T> tex, uint2 coords) => GpuOnly<T>();
    public static T Load<T>(this ITexture<object, D3, Single, T> tex, uint3 coords) => GpuOnly<T>();

    public static T Load<T>(this ITexture<object, D1, Array, T> tex, int coords, int index) => GpuOnly<T>();
    public static T Load<T>(this ITexture<object, D2, Array, T> tex, int2 coords, int index) => GpuOnly<T>();

    public static T Load<T>(this ITexture<object, D1, Array, T> tex, uint coords, uint index) => GpuOnly<T>();
    public static T Load<T>(this ITexture<object, D2, Array, T> tex, uint2 coords, uint index) => GpuOnly<T>();

    public static T Load<T>(this ITexture<object, D1, Array, T> tex, int coords, uint index) => GpuOnly<T>();
    public static T Load<T>(this ITexture<object, D2, Array, T> tex, int2 coords, uint index) => GpuOnly<T>();

    public static T Load<T>(this ITexture<object, D1, Array, T> tex, uint coords, int index) => GpuOnly<T>();
    public static T Load<T>(this ITexture<object, D2, Array, T> tex, uint2 coords, int index) => GpuOnly<T>();

    #endregion
}
