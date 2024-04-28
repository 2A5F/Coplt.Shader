using Coplt.Shader.Mathematics;

namespace Coplt.Shader.Shaders;

/// <summary>
/// Shader semantics
/// </summary>
public enum Semantics
{
    None = 0,

    /// <summary>
    /// type <see cref="float4"/>
    /// </summary>
    Position = 1,

    /// <summary>
    /// type <see cref="float"/>
    /// </summary>
    DepthOutput = 2,

    /// <summary>
    /// type <see cref="uint"/>
    /// </summary>
    VertexId = 3,
    /// <summary>
    /// type <see cref="uint"/>
    /// </summary>
    InstanceId = 4,

    /// <summary>
    /// type <see cref="bool"/>
    /// </summary>
    IsFrontFacing = 5,

    /// <summary>
    /// type <see cref="uint"/>
    /// </summary>
    SampleIndex = 6,
    /// <summary>
    /// type <see cref="uint"/>
    /// </summary>
    SampleMask = 7,

    /// <summary>
    /// type <see cref="uint3"/>
    /// </summary>
    GroupID = 9,
    /// <summary>
    /// type <see cref="uint3"/>
    /// </summary>
    GroupThreadID = 10,
    /// <summary>
    /// type <see cref="uint3"/>
    /// </summary>
    DispatchThreadID = 11,
    /// <summary>
    /// type <see cref="uint"/>
    /// </summary>
    GroupIndex = 12,
}
