#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;

namespace Coplt.Mathematics.Simd;

public static partial class simd_shuffle
{
    [MethodImpl(256 | 512)]
    public static Vector128<T> Shuffle<T>(Vector128<T> a, Vector128<T> b, Shuffle42 lh) =>
        Shuffle(a.As<T, float>(), b.As<T, float>(), lh).As<float, T>();
}

#endif
