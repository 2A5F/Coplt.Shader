using System;
using System.Diagnostics.CodeAnalysis;

namespace Coplt.Shader.Shaders;

public static partial class ShaderOp
{
    public static bool IsOnGpu => false;
    
    [DoesNotReturn]
    public static T GpuOnly<T>() => throw new NotSupportedException("This does not support running on cpu");
    [DoesNotReturn]
    public static void GpuOnly() => throw new NotSupportedException("This does not support running on cpu");
}
