using System;

namespace Coplt.Shader.Shaders;

/// <summary>
/// Mark field is Constant Buffer
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class UniformAttribute : Attribute;

/// <summary>
/// Mark field is Storage Buffer
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class StorageAttribute : Attribute;

/// <summary>
/// Mark field is Read Write Storage Buffer, need StorageBufferAttribute
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class ReadWriteAttribute : Attribute;
