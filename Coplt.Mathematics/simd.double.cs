#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.Wasm;
using System.Runtime.Intrinsics.X86;

namespace Coplt.Mathematics;

public static partial class simd_log_double
{
    #region Log 256

    [MethodImpl(256 | 512)]
    public static Vector256<double> Log(Vector256<double> d)
    {
        // todo
        return default;
    }
    
    #endregion
}
#endif
