namespace Coplt.Shader.Shaders;

public static partial class ShaderOp
{
    public static T Ddx<T>(T v) => GpuOnly<T>();
    public static T Ddy<T>(T v) => GpuOnly<T>();

    public static T DdxCoarse<T>(T v) => GpuOnly<T>();
    public static T DdyCoarse<T>(T v) => GpuOnly<T>();

    public static T DdxFine<T>(T v) => GpuOnly<T>();
    public static T DdyFine<T>(T v) => GpuOnly<T>();

    public static T FWidth<T>(T v) => GpuOnly<T>();
    public static T FWidthCoarse<T>(T v) => GpuOnly<T>();
    public static T FWidthFine<T>(T v) => GpuOnly<T>();
}
