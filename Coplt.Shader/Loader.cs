using System;
using System.Reflection;
using Coplt.Shader.Shaders;

namespace Coplt.Shader;

public struct ShaderLoader<T>;

public static class ShaderLoader
{
    public static ShaderLoader<T> Of<T>() where T : IShaderModule => default;

    public static ShaderModule Load<T>(
        this ShaderLoader<T> loader,
        [CompileTime] ShaderTarget target,
        [CompileTime] ShaderModuleType type = ShaderModuleType.Unknown
    ) where T : IShaderModule
        => throw new NotSupportedException("This method should be replaced at compile-time");

    public static ShaderModule? DynamicLoad<T>(
        this ShaderLoader<T> loader,
        ShaderTarget target,
        ShaderModuleType type = ShaderModuleType.Unknown,
        Assembly? targetAssembly = null
    ) where T : IShaderModule
        => throw new NotImplementedException("todo");
}
