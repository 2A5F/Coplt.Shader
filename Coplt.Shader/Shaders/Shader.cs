using System;
using System.Diagnostics.CodeAnalysis;

namespace Coplt.Shader.Shaders;

[GpuOnly]
public static partial class Shader
{
    public static bool IsOnGpu => false;

    public static ShaderModuleType CurrentShaderModuleType => GpuOnly<ShaderModuleType>();
    public static ShaderTarget CurrentShaderTarget => GpuOnly<ShaderTarget>();

    public static NotSupportedException GpuOnlyErr() => throw new NotSupportedException("This does not support running on cpu");

    [DoesNotReturn]
    public static T GpuOnly<T>() => throw GpuOnlyErr();
    [DoesNotReturn]
    public static T GpuOnly<T>(T value) => throw GpuOnlyErr();
    [DoesNotReturn]
    public static void GpuOnly() => throw GpuOnlyErr();

    /// <summary>
    /// Static branches
    /// </summary>
    public static bool IfDef(string defines) => false;

    /// <summary>
    /// Mark the following loop to be unrolled
    /// </summary>
    public static void Unroll() { }
    /// <summary>
    /// Mark the following loop to be unrolled
    /// </summary>
    public static void Unroll(int maxCount) { }
    /// <summary>
    /// Mark the following loop is loop
    /// </summary>
    public static void Loop() { }
    /// <summary>
    /// Allows a compute shader loop termination condition to be based off of a UAV read. The loop must not contain synchronization intrinsics.
    /// </summary>
    public static void AllowUavCondition() { }
    /// <summary>
    /// Mark the following branch is branch
    /// </summary>
    public static void Branch() { }
    /// <summary>
    /// Mark the following branch is flatten
    /// </summary>
    public static void Flatten() { }
    /// <summary>
    /// Mark the following switch is switch 
    /// </summary>
    public static void ForceCase() { }
    /// <summary>
    /// Mark the following switch is call 
    /// </summary>
    public static void Call() { }
}
