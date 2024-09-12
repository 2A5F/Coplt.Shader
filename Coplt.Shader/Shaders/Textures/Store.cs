using Coplt.Mathematics;
using Coplt.Shader.Shaders.Markers;

namespace Coplt.Shader.Shaders;

public static partial class Shader
{
    #region Store

    public static void Store<T>(this ITexture<Storage, D1, Single, T> tex, int coords, T value) => GpuOnly();
    public static void Store<T>(this ITexture<Storage, D2, Single, T> tex, int2 coords, T value) => GpuOnly();
    public static void Store<T>(this ITexture<Storage, D3, Single, T> tex, int3 coords, T value) => GpuOnly();

    public static void Store<T>(this ITexture<Storage, D1, Single, T> tex, uint coords, T value) => GpuOnly();
    public static void Store<T>(this ITexture<Storage, D2, Single, T> tex, uint2 coords, T value) => GpuOnly();
    public static void Store<T>(this ITexture<Storage, D3, Single, T> tex, uint3 coords, T value) => GpuOnly();

    public static void Store<T>(this ITexture<Storage, D1, Array, T> tex, int coords, int index, T value) => GpuOnly();
    public static void Store<T>(this ITexture<Storage, D2, Array, T> tex, int2 coords, int index, T value) => GpuOnly();

    public static void Store<T>(this ITexture<Storage, D1, Array, T> tex, uint coords, uint index, T value) => GpuOnly();
    public static void Store<T>(this ITexture<Storage, D2, Array, T> tex, uint2 coords, uint index, T value) => GpuOnly();

    public static void Store<T>(this ITexture<Storage, D1, Array, T> tex, uint coords, int index, T value) => GpuOnly();
    public static void Store<T>(this ITexture<Storage, D2, Array, T> tex, uint2 coords, int index, T value) => GpuOnly();

    public static void Store<T>(this ITexture<Storage, D1, Array, T> tex, int coords, uint index, T value) => GpuOnly();
    public static void Store<T>(this ITexture<Storage, D2, Array, T> tex, int2 coords, uint index, T value) => GpuOnly();

    #endregion
}
