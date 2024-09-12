namespace Coplt.Shader.Shaders;

[GpuOnly]
public struct AnyResource;

[GpuOnly]
public struct AnySampler;


[GpuOnly]
public static class ResourceDescriptorHeap
{
    public static T Get<T>(uint index) => Shader.GpuOnly<T>();
    public static AnyResource Get(uint index) => Shader.GpuOnly<AnyResource>();
}

[GpuOnly]
public static class SamplerDescriptorHeap
{
    public static T Get<T>(uint index) => Shader.GpuOnly<T>();
    public static AnySampler Get(uint index) => Shader.GpuOnly<AnySampler>();
}
