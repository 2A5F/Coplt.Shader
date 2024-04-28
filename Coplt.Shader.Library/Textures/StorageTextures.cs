namespace Coplt.Shader.Shaders;

public struct StorageTexture1d<T>;
public struct StorageTexture2d<T>;
public struct StorageTexture3d<T>;
public struct StorageTexture1dArray<T>;
public struct StorageTexture2dArray<T>;

public static partial class ShaderOp
{
    #region Load

    public static T Load<T, C>(this StorageTexture1d<T> tex, C coords) => GpuOnly<T>();
    public static T Load<T, C>(this StorageTexture2d<T> tex, C coords) => GpuOnly<T>();
    public static T Load<T, C>(this StorageTexture3d<T> tex, C coords) => GpuOnly<T>();

    public static T Load<T, C, I>(this StorageTexture1dArray<T> tex, C coords, I index) => GpuOnly<T>();
    public static T Load<T, C, I>(this StorageTexture2dArray<T> tex, C coords, I index) => GpuOnly<T>();

    #endregion

    #region Store

    public static void Store<T, C>(this StorageTexture1d<T> tex, C coords, T value) => GpuOnly();
    public static void Store<T, C>(this StorageTexture2d<T> tex, C coords, T value) => GpuOnly();
    public static void Store<T, C>(this StorageTexture3d<T> tex, C coords, T value) => GpuOnly();

    public static void Store<T, C, I>(this StorageTexture1dArray<T> tex, C coords, I index, T value) => GpuOnly();
    public static void Store<T, C, I>(this StorageTexture2dArray<T> tex, C coords, I index, T value) => GpuOnly();

    #endregion
}
