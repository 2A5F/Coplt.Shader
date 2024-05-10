namespace Coplt.Mathematics;

public struct plane
{
    public float4 normal_and_distance;

    public float3 normal
    {
        [MethodImpl(256 | 512)]
        get => normal_and_distance.xyz;
        [MethodImpl(256 | 512)]
        set => normal_and_distance.xyz = value;
    }
    
    public float distance
    {
        [MethodImpl(256 | 512)]
        get => normal_and_distance.w;
        [MethodImpl(256 | 512)]
        set => normal_and_distance.w = value;
    }
}
