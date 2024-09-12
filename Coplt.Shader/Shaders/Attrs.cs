using System;

namespace Coplt.Shader.Shaders;

/// <summary>
/// Marker type or method is shader library or a shader module
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
public sealed class ShaderLibraryAttribute : Attribute
{
    /// <summary>
    /// Supported target types, empty is All
    /// </summary>
    public ShaderModuleType[] Types { get; } = [];
}

/// <summary>
/// Marker type or method exclude from shader library or shader module
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
public sealed class ShaderExcludeAttribute : Attribute
{
    /// <summary>
    /// Excluded target types
    /// </summary>
    public ShaderModuleType[] Types { get; } = [];
}

/// <summary>
/// Marks a method as an entry point
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class ShaderAttribute(string type) : Attribute
{
    /// <summary>
    /// Marks a method as an entry point
    /// </summary>
    public string Type => type;
}

/// <summary>
/// Thread group size
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class NumThreadsAttribute(int x, int y = 1, int z = 1) : Attribute
{
    public int X { get; } = x;
    public int Y { get; } = y;
    public int Z { get; } = z;
}
