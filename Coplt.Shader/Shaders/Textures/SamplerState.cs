namespace Coplt.Shader.Shaders;

[GpuOnly]
public struct SamplerState
{
    public static implicit operator SamplerState(AnySampler _) => throw Shader.GpuOnlyErr();
}

[GpuOnly]
public struct SamplerComparisonState
{
    public static implicit operator SamplerComparisonState(AnySampler _) => throw Shader.GpuOnlyErr();
}
