namespace Coplt.Shader.Mir;

public enum MirOp : ushort
{
    /// <summary>
    /// No op
    /// </summary>
    Nop,
    /// <summary>
    /// End function
    /// </summary>
    Ret,
    /// <summary>
    /// Get function parameters
    /// <code>ldarg &lt;u16 index&gt;</code>
    /// </summary>
    LdArg,
}
