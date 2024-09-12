using System;

namespace Coplt.Shader.Shaders;

/// <summary>
/// Mark can only be used on GPU
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class GpuOnlyAttribute : Attribute;

/// <summary>
/// Mark can only be used on CPU
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class CpuOnlyAttribute : Attribute;

/// <summary>
/// Mark can be used on both gpu and cpu
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class CpuGpuAttribute : Attribute;

/// <summary>
/// Tag values need to be determined at compile time
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class CompileTimeAttribute : Attribute;
