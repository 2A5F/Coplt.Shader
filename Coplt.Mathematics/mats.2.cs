using System;

namespace Coplt.Mathematics;

public static partial class math
{
    public static float4 mul(float4x4 mat, float4 vec) => throw new NotImplementedException();
    
    [MethodImpl(256 | 512)]
    public static float4x4 inverse2(float4x4 m)
    {
        var (c0, c1, c2, c3) = m;
        
        return default;
    }
}
