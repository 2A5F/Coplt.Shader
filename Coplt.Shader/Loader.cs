using System;

namespace Coplt.Shader;

public static class ShaderLoader
{
    public static ShaderModule Load<T>(ShaderModuleConfig config) where T : IShaderModule
        => throw new NotSupportedException("This method should be replaced at compile-time");
}
