namespace Coplt.Mathematics;

public static partial class math
{
    /// <summary>
    /// <code>e</code>
    /// </summary>
    public const float F_E = 2.7182818284590452353602874713526624977572470936999595749669676277f;
    /// <summary>
    /// <code>log(2)</code>
    /// </summary>
    public const float F_Log2 = 0.6931471805599453094172321214581765680755001343602552541206800094f;
    /// <summary>
    /// <code>log(10)</code>
    /// </summary>
    public const float F_Log10 = 2.3025850929940456840179914546843642076011014886287729760333279009f;
    /// <summary>
    /// <code>1 / log(2)</code>
    /// </summary>
    public const float F_1_Div_Log2 = 1.4426950408889634073599246810018921374266459541529859341354494069f;
    /// <summary>
    /// <code>π</code>
    /// </summary>
    public const float F_PI = 3.1415926535897932384626433832795028841971693993751058209749445923f;
    /// <summary>
    /// <code>τ = 2 * π</code>
    /// </summary>
    public const float F_Tau = F_2_PI;
    /// <summary>
    /// <code>2 * π</code>
    /// </summary>
    public const float F_2_PI = 6.2831853071795864769252867665590057683943387987502116419498891846f;
    /// <summary>
    /// <code>4 * π</code>
    /// </summary>
    public const float F_4_PI = 12.566370614359172953850573533118011536788677597500423283899778369f;
    /// <summary>
    /// <code>π / 2</code>
    /// </summary>
    public const float F_Half_PI = 1.5707963267948966192313216916397514420985846996875529104874722961f;
    /// <summary>
    /// <code>π / 4</code>
    /// </summary>
    public const float F_Quarter_PI = 0.7853981633974483096156608458198757210492923498437764552437361480f;
    /// <summary>
    /// <code>1 / π</code>
    /// </summary>
    public const float F_1_Div_PI = 0.3183098861837906715377675267450287240689192914809128974953346881f;
    /// <summary>
    /// <code>1 / (2 * π)</code>
    /// </summary>
    public const float F_1_Div_2_PI = 0.1591549430918953357688837633725143620344596457404564487476673440f;
    /// <summary>
    /// <code>1 / (4 * π)</code>
    /// </summary>
    public const float F_1_Div_4_PI = 0.0795774715459476678844418816862571810172298228702282243738336720f;
    /// <summary>
    /// <code>360 / τ</code>
    /// </summary>
    public const float F_RadToDeg = 57.295779513082320876798154814105170332405472466564321549160243861f;
    /// <summary>
    /// <code>τ / 360</code>
    /// </summary>
    public const float F_DegToRad = 0.0174532925199432957692369076848861271344287188854172545609719144f;

    /// <summary>
    /// <code>e</code>
    /// </summary>
    public const double D_E = 2.7182818284590452353602874713526624977572470936999595749669676277;
    /// <summary>
    /// <code>log(2)</code>
    /// </summary>
    public const double D_Log2 = 0.6931471805599453094172321214581765680755001343602552541206800094;
    /// <summary>
    /// <code>log(10)</code>
    /// </summary>
    public const double D_Log10 = 2.3025850929940456840179914546843642076011014886287729760333279009;
    /// <summary>
    /// <code>1 / log(2)</code>
    /// </summary>
    public const double D_1_Div_Log2 = 1.4426950408889634073599246810018921374266459541529859341354494069;
    /// <summary>
    /// <code>π</code>
    /// </summary>
    public const double D_PI = 3.1415926535897932384626433832795028841971693993751058209749445923;
    /// <summary>
    /// <code>τ = 2 * π</code>
    /// </summary>
    public const double D_Tau = D_2_PI;
    /// <summary>
    /// <code>2 * π</code>
    /// </summary>
    public const double D_2_PI = 6.2831853071795864769252867665590057683943387987502116419498891846;
    /// <summary>
    /// <code>4 * π</code>
    /// </summary>
    public const double D_4_PI = 12.566370614359172953850573533118011536788677597500423283899778369;
    /// <summary>
    /// <code>π / 2</code>
    /// </summary>
    public const double D_Half_PI = 1.5707963267948966192313216916397514420985846996875529104874722961;
    /// <summary>
    /// <code>π / 4</code>
    /// </summary>
    public const double D_Quarter_PI = 0.7853981633974483096156608458198757210492923498437764552437361480;
    /// <summary>
    /// <code>1 / π</code>
    /// </summary>
    public const double D_1_Div_PI = 0.3183098861837906715377675267450287240689192914809128974953346881;
    /// <summary>
    /// <code>1 / (2 * π)</code>
    /// </summary>
    public const double D_1_Div_2_PI = 0.1591549430918953357688837633725143620344596457404564487476673440;
    /// <summary>
    /// <code>1 / (4 * π)</code>
    /// </summary>
    public const double D_1_Div_4_PI = 0.0795774715459476678844418816862571810172298228702282243738336720;
    /// <summary>
    /// <code>360 / τ</code>
    /// </summary>
    public const double D_RadToDeg = 57.295779513082320876798154814105170332405472466564321549160243861;
    /// <summary>
    /// <code>τ / 360</code>
    /// </summary>
    public const double D_DegToRad = 0.0174532925199432957692369076848861271344287188854172545609719144;

    #region rcp fast

    [MethodImpl(256 | 512)]
    public static float2 rcp_fast(this float2 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.Rcp(v.vector));
        #else
        return rcp(v);
        #endif
    }

    [MethodImpl(256 | 512)]
    public static float3 rcp_fast(this float3 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.Rcp(v.vector));
        #else
        return rcp(v);
        #endif
    }

    [MethodImpl(256 | 512)]
    public static float4 rcp_fast(this float4 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.Rcp(v.vector));
        #else
        return rcp(v);
        #endif
    }

    [MethodImpl(256 | 512)]
    public static double2 rcp_fast(this double2 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.Rcp(v.vector));
        #else
        return rcp(v);
        #endif
    }

    [MethodImpl(256 | 512)]
    public static double3 rcp_fast(this double3 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.Rcp(v.vector));
        #else
        return rcp(v);
        #endif
    }

    [MethodImpl(256 | 512)]
    public static double4 rcp_fast(this double4 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.Rcp(v.vector));
        #else
        return rcp(v);
        #endif
    }

    #endregion

    #region rsqrt fast

    [MethodImpl(256 | 512)]
    public static float2 rsqrt_fast(this float2 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.RSqrt(v.vector));
        #else
        return rsqrt(v);
        #endif
    }

    [MethodImpl(256 | 512)]
    public static float3 rsqrt_fast(this float3 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.RSqrt(v.vector));
        #else
        return rsqrt(v);
        #endif
    }

    [MethodImpl(256 | 512)]
    public static float4 rsqrt_fast(this float4 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.RSqrt(v.vector));
        #else
        return rsqrt(v);
        #endif
    }

    [MethodImpl(256 | 512)]
    public static double2 rsqrt_fast(this double2 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.RSqrt(v.vector));
        #else
        return rsqrt(v);
        #endif
    }

    [MethodImpl(256 | 512)]
    public static double3 rsqrt_fast(this double3 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.RSqrt(v.vector));
        #else
        return rsqrt(v);
        #endif
    }

    [MethodImpl(256 | 512)]
    public static double4 rsqrt_fast(this double4 v)
    {
        #if NET8_0_OR_GREATER
        return new(simd.RSqrt(v.vector));
        #else
        return rsqrt(v);
        #endif
    }

    #endregion
}

public static partial class ctor
{
    [MethodImpl(256 | 512)]
    public static half half(this float v) => (half)v;
}
