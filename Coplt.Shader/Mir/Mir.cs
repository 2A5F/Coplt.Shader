using System;

namespace Coplt.Shader.Mir;

/// <summary>
/// Intermediate information extracted from the source, Do not use manually
/// </summary>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class ShaderMirInfoAttribute(Type target, string? method, Type[] types, string[] strings, byte[] data) : Attribute
{
    public Type Target => target;
    public string? Method => method;
    public Type[] Types => types;
    public string[] Strings => strings;
    public byte[] Data => data;
}
