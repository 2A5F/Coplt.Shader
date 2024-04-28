using System;

namespace Coplt.Shader;

/// <summary>
/// Shader module
/// </summary>
public interface IShaderModule { }

public enum ShaderModuleType
{
    Unknown,
    SpirV,
    DxIL,
    Hlsl,
    Wgsl,
}

public record struct ShaderModuleConfig
{
    public ShaderModuleType RequiredType { get; set; }
}

public abstract class ShaderModule
{
    public abstract ShaderModuleType Type { get; }

    public abstract ReadOnlySpan<byte> Blob();

    // todo Reflection information
}
