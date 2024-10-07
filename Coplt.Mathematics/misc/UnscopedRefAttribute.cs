#if NETSTANDARD

namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property, Inherited = false)]
internal sealed class UnscopedRefAttribute : Attribute;

#endif
