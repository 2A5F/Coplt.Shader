# Coplt.Mathematics

hlsl-style linear algebra library

- bool (b16 b32 b64)、half、float、double、short、ushort、int、uint、long、ulong、decimal
- Vector2~4 (float3 double4 int2 ...)
- Matrix2x2~4x4 (float3x3 double4x2 int2x3 ...)
- Hlsl-like cartesian product swizzle (.yzx .abgr ...)
- Full simd support (net8 only)
- Simd accelerated log, exp, pow, fmod, trigonometry (Lower precision than C# standard library)

## Todo
- [ ] quaternion
- [ ] simd impl of asin acos atan atan2 atanh
- [ ] higher precision single float trigonometric functions impl
