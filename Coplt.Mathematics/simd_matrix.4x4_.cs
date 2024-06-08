#if NET8_0_OR_GREATER
namespace Coplt.Mathematics.Simd;

public partial class simd_matrix
{
    [MethodImpl(256 | 512)]
    public static (Vector128<float> c0, Vector128<float> c1, Vector128<float> c2, Vector128<float> c3) Inverse4x4(
        Vector128<float> c0, Vector128<float> c1, Vector128<float> c2, Vector128<float> c3
    )
    {
        var r0y_r1y_r0x_r1x = simd.MoveLowToHigh(c1, c0); // (x1, y1, x0, y0)
        var r0z_r1z_r0w_r1w = simd.MoveLowToHigh(c2, c3); // (x2, y2, x3, y3)
        var r2y_r3y_r2x_r3x = simd.MoveHighToLow(c0, c1); // (z1, w1, z0, w0)
        var r2z_r3z_r2w_r3w = simd.MoveHighToLow(c3, c2); // (z2, w2, z3, w3)

        var r0_wzyx = simd_shuffle.Shuffle(r0z_r1z_r0w_r1w, r0y_r1y_r0x_r1x, Shuffle42.zx_xz); // x3 x2 x1 x0
        var r1_wzyx = simd_shuffle.Shuffle(r0z_r1z_r0w_r1w, r0y_r1y_r0x_r1x, Shuffle42.wy_yw); // y3 y2 y1 y0
        var r2_wzyx = simd_shuffle.Shuffle(r2z_r3z_r2w_r3w, r2y_r3y_r2x_r3x, Shuffle42.zx_xz); // z3 z2 z1 z0
        var r3_wzyx = simd_shuffle.Shuffle(r2z_r3z_r2w_r3w, r2y_r3y_r2x_r3x, Shuffle42.wy_yw); // w3 w2 w1 w0
        var r0_xyzw = Vector128.Shuffle(r0_wzyx, Vector128.Create(3, 2, 1, 0)); // x0 x1 x2 x3

        var r1y_r2y_r1x_r2x = simd_shuffle.Shuffle(c1, c0, Shuffle42.yz_yz); // (y1, z1, y0, z0)
        var r1z_r2z_r1w_r2w = simd_shuffle.Shuffle(c2, c3, Shuffle42.yz_yz); // (y2, z2, y3, z3)
        var r3y_r0y_r3x_r0x = simd_shuffle.Shuffle(c1, c0, Shuffle42.wx_wx); // (w1, x1, w0, x0)
        var r3z_r0z_r3w_r0w = simd_shuffle.Shuffle(c2, c3, Shuffle42.wx_wx); // (w2, x2, w3, x3)

        // Calculate remaining inner term pairs. inner terms have zw=-xy, so we only have to calculate xy and can pack two pairs per vector
        var inner12_23 = r1y_r2y_r1x_r2x * r2z_r3z_r2w_r3w - r1z_r2z_r1w_r2w * r2y_r3y_r2x_r3x;
        var inner02_13 = r0y_r1y_r0x_r1x * r2z_r3z_r2w_r3w - r0z_r1z_r0w_r1w * r2y_r3y_r2x_r3x;
        var inner30_01 = r3z_r0z_r3w_r0w * r0y_r1y_r0x_r1x - r3y_r0y_r3x_r0x * r0z_r1z_r0w_r1w;

        // Expand inner terms back to 4 components. zw signs still need to be flipped
        var inner12 = Vector128.Shuffle(inner12_23, Vector128.Create(0, 2, 2, 0));
        var inner23 = Vector128.Shuffle(inner12_23, Vector128.Create(1, 3, 3, 1));

        var inner02 = Vector128.Shuffle(inner02_13, Vector128.Create(0, 2, 2, 0));
        var inner13 = Vector128.Shuffle(inner02_13, Vector128.Create(1, 3, 3, 1));

        // Calculate minors
        var minors0 = r3_wzyx * inner12 - r2_wzyx * inner13 + r1_wzyx * inner23;

        var denom = r0_xyzw * minors0;

        // Horizontal sum of denominator. Free sign flip of z and w compensates for missing flip in inner terms
        denom += Vector128.Shuffle(denom, Vector128.Create(1, 0, 3, 2)); // x+y        x+y            z+w            z+w
        denom -= Vector128.Shuffle(denom, Vector128.Create(2, 2, 0, 0)); // x+y-z-w  x+y-z-w        z+w-x-y        z+w-x-y

        var rcp_denom_ppnn = Vector128.Create(1.0f) / denom;
        var rc0 = minors0 * rcp_denom_ppnn;

        var inner30 = Vector128.Shuffle(inner30_01, Vector128.Create(0, 2, 2, 0));
        var inner01 = Vector128.Shuffle(inner30_01, Vector128.Create(1, 3, 3, 1));

        var minors1 = r2_wzyx * inner30 - r0_wzyx * inner23 - r3_wzyx * inner02;
        var rc1 = minors1 * rcp_denom_ppnn;

        var minors2 = r0_wzyx * inner13 - r1_wzyx * inner30 - r3_wzyx * inner01;
        var rc2 = minors2 * rcp_denom_ppnn;

        var minors3 = r1_wzyx * inner02 - r0_wzyx * inner12 + r2_wzyx * inner01;
        var rc3 = minors3 * rcp_denom_ppnn;

        return (rc0, rc1, rc2, rc3);
    }
}

#endif
