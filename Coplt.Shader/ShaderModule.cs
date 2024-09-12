using System;

namespace Coplt.Shader;


public enum ShaderTarget
{
    Other,
    DirectX,
    Vulkan,
    WebGpu,
}

public enum ShaderModuleType
{
    Unknown,
    SpirV,
    DxIL,
    Hlsl,
    Wgsl,
}

public abstract class ShaderModule
{
    public abstract ShaderModuleType Type { get; }
    public abstract ShaderTarget Target { get; }

    public abstract ReadOnlySpan<byte> Blob();

    // todo Reflection information
}
