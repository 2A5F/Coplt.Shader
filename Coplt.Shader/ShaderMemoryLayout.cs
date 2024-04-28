namespace Coplt.Shader.Shaders;

/// <summary>
/// Shader structure memory layout
/// </summary>
public enum ShaderMemoryLayout
{
    /// <summary>
    /// With simd aligned memory layout, c# structures will not be passed directly.
    /// <para>It's the default value when struct is declared in shader</para>
    /// </summary>
    Shader = 0,

    /// <summary>
    /// Same memory layout as c#, no alignment
    /// </summary>
    CSharp = 1,
}
