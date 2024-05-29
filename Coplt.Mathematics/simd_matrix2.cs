#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;

namespace Coplt.Mathematics;

public static partial class simd_matrix
{
    #region Transpose 3x3

    [MethodImpl(256 | 512)]
    public static (Vector128<float> c0, Vector128<float> c1, Vector128<float> c2) Transpose3x3(
        Vector128<float> c0, Vector128<float> c1, Vector128<float> c2
    )
    {
        if (Sse.IsSupported)
        {
            var a = Sse.Shuffle(c0, c1, 0x44); // a0 a1 b0 b1 => (c0.xy, c1.xy)
            var c = Sse.Shuffle(c0, c1, 0xEE); // a2 a3 b2 b3 => (c0.yz, c1.yz)
            var oc0 = Sse.Shuffle(a, c2, 0xC8); // a0 a2 b0 b3 => (a.xz, c2.xw) => (c0.x, c1.x, c2.x, 0)         
            var oc1 = Sse.Shuffle(a, c2, 0xDD); // a1 a3 a1 a3 => (a.yw, c2.yw) => (c0.y, c1.y, c2.y, 0)            
            var oc2 = Sse.Shuffle(c, c2, 0xE8); // a0 a2 b2 b3 => (c.xz, c2.zw) => (c0.z, c1.z, c2.z, 0)
            return (oc0, oc1, oc2);
        }
        {
            var oc0 = Vector128.Create(c0.GetElement(0), c1.GetElement(0), c2.GetElement(0), 0);
            var oc1 = Vector128.Create(c0.GetElement(1), c1.GetElement(1), c2.GetElement(1), 0);
            var oc2 = Vector128.Create(c0.GetElement(2), c1.GetElement(2), c2.GetElement(2), 0);
            return (oc0, oc1, oc2);
        }
    }

    #endregion

    #region Transpose 4x2 To 2x4

    [MethodImpl(256 | 512)]
    public static (Vector64<float> c0, Vector64<float> c1, Vector64<float> c2, Vector64<float> c3) Transpose4x2To2x4(
        Vector128<float> c0, Vector128<float> c1
    )
    {
        if (Sse.IsSupported)
        {
            var a = Sse.UnpackLow(c0, c1); // (c0.x, c1.x, c0.y, c1.y)
            var b = Sse.UnpackHigh(c0, c1); // (c0.z, c1.z, c0.w, c1.w)
            return (a.GetLower(), a.GetUpper(), b.GetLower(), b.GetUpper());
        }
        {
            var oc0 = Vector64.Create(c0.GetElement(0), c1.GetElement(0));
            var oc1 = Vector64.Create(c0.GetElement(1), c1.GetElement(1));
            var oc2 = Vector64.Create(c0.GetElement(2), c1.GetElement(2));
            var oc3 = Vector64.Create(c0.GetElement(3), c1.GetElement(3));
            return (oc0, oc1, oc2, oc3);
        }
    }

    #endregion

    #region Transpose 2x4 To 4x2

    [MethodImpl(256 | 512)]
    public static (Vector128<float> c0, Vector128<float> c1) Transpose2x4To4x2(
        Vector64<float> c0, Vector64<float> c1, Vector64<float> c2, Vector64<float> c3
    )
    {
        if (Sse.IsSupported)
        {
            var a = Vector128.Create(c0, c1);
            var b = Vector128.Create(c2, c3);
            var oc0 = Sse.Shuffle(a, b, 0x88); // a0 a2 b0 b2 => (c0.x, c1.x, c2.x, c3.x)
            var oc1 = Sse.Shuffle(a, b, 0xDD); // a1 a3 b1 b3 => (c0.y, c1.y, c2.y, c3.y)
            return (oc0, oc1);
        }
        {
            var oc0 = Vector128.Create(c0.GetElement(0), c1.GetElement(0), c2.GetElement(0), c3.GetElement(0));
            var oc1 = Vector128.Create(c0.GetElement(1), c1.GetElement(1), c2.GetElement(1), c3.GetElement(1));
            return (oc0, oc1);
        }
    }

    #endregion

    #region Transpose 4x2 To 2x4 double

    [MethodImpl(256 | 512)]
    public static (Vector128<double> c0, Vector128<double> c1, Vector128<double> c2, Vector128<double> c3) Transpose4x2To2x4(
        Vector256<double> c0, Vector256<double> c1
    )
    {
        if (Avx.IsSupported)
        {
            var a = Avx.Shuffle(c0, c1, 0x0); // a0 b0 a2 b2  => (c0.x, c1.x, c0.z, c1.z)
            var c = Avx.Shuffle(c0, c1, 0xF); // a1 b1 a3 b3  => (c0.y, c1.y, c0.w, c1.w)
            return (a.GetLower(), c.GetLower(), a.GetUpper(), c.GetUpper());
        }
        {
            var oc0 = Vector128.Create(c0.GetElement(0), c1.GetElement(0));
            var oc1 = Vector128.Create(c0.GetElement(1), c1.GetElement(1));
            var oc2 = Vector128.Create(c0.GetElement(2), c1.GetElement(2));
            var oc3 = Vector128.Create(c0.GetElement(3), c1.GetElement(3));
            return (oc0, oc1, oc2, oc3);
        }
    }

    #endregion

    #region Transpose 2x4 To 4x2 double

    [MethodImpl(256 | 512)]
    public static (Vector256<double> c0, Vector256<double> c1) Transpose2x4To4x2(
        Vector128<double> c0, Vector128<double> c1, Vector128<double> c2, Vector128<double> c3
    )
    {
        if (Avx.IsSupported)
        {
            var a = Vector256.Create(c0, c2);
            var b = Vector256.Create(c1, c3);
            var oc0 = Avx.Shuffle(a, b, 0x0); // a0 b0 a2 b2 => (c0.x, c1.x, c2.x, c3.x)
            var oc1 = Avx.Shuffle(a, b, 0xF); // a1 b1 a3 b3 => (c0.y, c1.y, c2.y, c3.y)
            return (oc0, oc1);
        }
        {
            var oc0 = Vector256.Create(c0.GetElement(0), c1.GetElement(0), c2.GetElement(0), c3.GetElement(0));
            var oc1 = Vector256.Create(c0.GetElement(1), c1.GetElement(1), c2.GetElement(1), c3.GetElement(1));
            return (oc0, oc1);
        }
    }

    #endregion
}

#endif
