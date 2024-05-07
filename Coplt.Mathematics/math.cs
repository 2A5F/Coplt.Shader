﻿namespace Coplt.Mathematics;

public static partial class math
{
    public const float F_E = 2.7182818284590452353602874713526624977572470936999595749669676277f;
    public const float F_PI = 3.1415926535897932384626433832795028841971693993751058209749445923f;
    public const float F_Log2 = 0.6931471805599453094172321214581765680755001343602552541206800094f;
    public const float F_Tau = 6.2831853071795862f;
    public const float F_Log10 = 2.3025850929940456840179914546843642076011014886287729760333279009f;
    public const float F_1_Div_Log2 = 1.4426950408889634073599246810018921374266459541529859341354494069f;
    public const float F_RadToDeg = 57.295779513082320876798154814105170332405472466564321549160243861f;
    public const float F_DegToRad = 0.0174532925199432957692369076848861271344287188854172545609719144f;

    public const double D_E = 2.7182818284590452353602874713526624977572470936999595749669676277;
    public const double D_PI = 3.1415926535897932384626433832795028841971693993751058209749445923;
    public const double D_Tau = 6.2831853071795862;
    public const double D_Log2 = 0.6931471805599453094172321214581765680755001343602552541206800094;
    public const double D_Log10 = 2.3025850929940456840179914546843642076011014886287729760333279009;
    public const double D_RadToDeg = 57.295779513082320876798154814105170332405472466564321549160243861;
    public const double D_1_Div_Log2 = 1.4426950408889634073599246810018921374266459541529859341354494069;
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
