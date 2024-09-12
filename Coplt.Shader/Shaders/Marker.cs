using System;

namespace Coplt.Shader.Shaders;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.Method)]
public sealed class NoInterpolationAttribute : Attribute;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.Method)]
public sealed class GroupSharedAttribute : Attribute;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.Method)]
public sealed class PackOffsetAttribute(string target, string components = "auto") : Attribute
{
    public string Target => target;
    public string Components => components;
}

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class BitFieldAttribute(int bits) : Attribute
{
    public int Bits => bits;
}

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class ArraySizeAttribute(int size) : Attribute
{
    public int Size => size;
}
