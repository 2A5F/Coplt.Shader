using System;

namespace Coplt.Shader.Mathematics;

public struct float4x4
{
    public static float4 operator *(float4x4 mat, float4 vec) => throw new NotImplementedException();
}

public static partial class math
{
    public static float4 mul(float4x4 mat, float4 vec) => throw new NotImplementedException();
}
