using System;

namespace Coplt.Shader.Shaders;

/// <summary>
/// Marker type is shader
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public sealed class ShaderAttribute : Attribute;

/// <summary>
/// Marker type is shader library
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public sealed class ShaderLibraryAttribute : Attribute;

/// <summary>
/// Vertex shader
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class VertexShaderAttribute : Attribute;

/// <summary>
/// Pixel (Fragment) shader
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class PixelShaderAttribute : Attribute;

/// <summary>
/// Compute shader
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class ComputeShaderAttribute : Attribute;

/// <summary>
/// Task (Amplification) shader
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class TaskShaderAttribute : Attribute;

/// <summary>
/// Mesh shader
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class MeshShaderAttribute : Attribute;

/// <summary>
/// Thread group size
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class ThreadGroupSizeAttribute(int x, int y = 1, int z = 1) : Attribute
{
    public int X { get; } = x;
    public int Y { get; } = y;
    public int Z { get; } = z;
}

/// <summary>
/// Shader structure memory layout
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
public sealed class ShaderMemoryLayoutAttribute(ShaderMemoryLayout layout = ShaderMemoryLayout.Shader) : Attribute
{
    /// <inheritdoc cref="ShaderMemoryLayout"/>
    public ShaderMemoryLayout Layout => layout;
}

/// <summary>
/// Specify shader semantics
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class BuiltinAttribute(Semantics semantic) : Attribute
{
    /// <inheritdoc cref="Semantics"/>
    public Semantics Semantic => semantic;
}

/// <summary>
/// Specify custom semantics
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class SemanticAttribute(string semantic) : Attribute
{
    /// <inheritdoc cref="Semantics"/>
    public string Semantic => semantic;
}

/// <summary>
/// Manually specify binding location
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class BindAttribute(uint at, uint group = 0) : Attribute
{
    public uint At => at;
    public uint Group => group;
}

/// <summary>
/// Manually specify semantics location
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class LocationAttribute(uint at) : Attribute
{
    public uint At => at;
}

/// <summary>
/// Mark uniform buffer
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class UniformAttribute : Attribute;

/// <summary>
/// Mark storage buffer
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class StorageAttribute : Attribute;

/// <summary>
/// Specify the interpolation method for variables
/// </summary>
public enum Interpolate
{
    /// <summary>
    /// Values are interpolated in a linear, non-perspective correct manner.
    /// </summary>
    Linear,
    /// <summary>
    /// Values are interpolated in a perspective correct manner.
    /// </summary>
    Perspective,
    /// <summary>
    /// Values are not interpolated. Interpolation sampling is not used with flat interpolation.
    /// </summary>
    Flat,
}

/// <summary>
/// Specify the interpolation method for variables
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class InterpolateAttribute(Interpolate interpolate) : Attribute
{
    /// <summary>
    /// Specify the interpolation method for variables
    /// </summary>
    public Interpolate Interpolate => interpolate;
}
