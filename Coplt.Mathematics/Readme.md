# Coplt.Mathematics

[![Nuget](https://img.shields.io/nuget/v/Coplt.Mathematics)](https://www.nuget.org/packages/Coplt.Mathematics/)

hlsl-style linear algebra library

- bool (b16 b32 b64)、half、float、double、short、ushort、int、uint、long、ulong、decimal
- Vector2~4 (float3 double4 int2 ...)
- Matrix2x2~4x4 (float3x3 double4x2 int2x3 ...)
- Hlsl-like cartesian product swizzle (.yzx .abgr ...)
- Full simd support (net8 only)
- Simd accelerated log, exp, pow, fmod, trigonometry (Lower precision than C# standard library)

## Function ULPs

| function | float | double |
|----------|-------|--------|
| log      |   1   |   2    |
| asin     |   2   |   2    |
| acos     |   2   |   2    |

- The function that needs to be rewritten due to insufficient precision is not in the table

## Todo

- [ ] tests
- [ ] simd impl of atan atan2 atanh
- [ ] rewrite the function with too low precision
