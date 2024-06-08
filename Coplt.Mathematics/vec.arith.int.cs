// generated by template, do not modify manually

namespace Coplt.Mathematics;

#region short2

public partial struct short2
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b16v2 isPow2(this short2 a)
    {
        return ((a & (a - short2.One)) == default) & (a > default(short2));
    }
}

#endregion // short2

#region short3

public partial struct short3
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b16v3 isPow2(this short3 a)
    {
        return ((a & (a - short3.One)) == default) & (a > default(short3));
    }
}

#endregion // short3

#region short4

public partial struct short4
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b16v4 isPow2(this short4 a)
    {
        return ((a & (a - short4.One)) == default) & (a > default(short4));
    }
}

#endregion // short4

#region ushort2

public partial struct ushort2
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b16v2 isPow2(this ushort2 a)
    {
        return ((a & (a - ushort2.One)) == default) & (a != default);
    }

    [MethodImpl(256 | 512)]
    public static ushort2 up2pow2(this ushort2 a)
    {
        --a;
        a |= a >> 1;
        a |= a >> 2;
        a |= a >> 4;
        a |= a >> 8;
        return a + ushort2.One;
    }
}

#endregion // ushort2

#region ushort3

public partial struct ushort3
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b16v3 isPow2(this ushort3 a)
    {
        return ((a & (a - ushort3.One)) == default) & (a != default);
    }

    [MethodImpl(256 | 512)]
    public static ushort3 up2pow2(this ushort3 a)
    {
        --a;
        a |= a >> 1;
        a |= a >> 2;
        a |= a >> 4;
        a |= a >> 8;
        return a + ushort3.One;
    }
}

#endregion // ushort3

#region ushort4

public partial struct ushort4
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b16v4 isPow2(this ushort4 a)
    {
        return ((a & (a - ushort4.One)) == default) & (a != default);
    }

    [MethodImpl(256 | 512)]
    public static ushort4 up2pow2(this ushort4 a)
    {
        --a;
        a |= a >> 1;
        a |= a >> 2;
        a |= a >> 4;
        a |= a >> 8;
        return a + ushort4.One;
    }
}

#endregion // ushort4

#region int2

public partial struct int2
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b32v2 isPow2(this int2 a)
    {
        return ((a & (a - int2.One)) == default) & (a > default(int2));
    }
}

#endregion // int2

#region int3

public partial struct int3
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b32v3 isPow2(this int3 a)
    {
        return ((a & (a - int3.One)) == default) & (a > default(int3));
    }
}

#endregion // int3

#region int4

public partial struct int4
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b32v4 isPow2(this int4 a)
    {
        return ((a & (a - int4.One)) == default) & (a > default(int4));
    }
}

#endregion // int4

#region uint2

public partial struct uint2
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b32v2 isPow2(this uint2 a)
    {
        return ((a & (a - uint2.One)) == default) & (a != default);
    }

    [MethodImpl(256 | 512)]
    public static uint2 up2pow2(this uint2 a)
    {
        --a;
        a |= a >> 1;
        a |= a >> 2;
        a |= a >> 4;
        a |= a >> 8;
        a |= a >> 16;
        return a + uint2.One;
    }
}

#endregion // uint2

#region uint3

public partial struct uint3
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b32v3 isPow2(this uint3 a)
    {
        return ((a & (a - uint3.One)) == default) & (a != default);
    }

    [MethodImpl(256 | 512)]
    public static uint3 up2pow2(this uint3 a)
    {
        --a;
        a |= a >> 1;
        a |= a >> 2;
        a |= a >> 4;
        a |= a >> 8;
        a |= a >> 16;
        return a + uint3.One;
    }
}

#endregion // uint3

#region uint4

public partial struct uint4
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b32v4 isPow2(this uint4 a)
    {
        return ((a & (a - uint4.One)) == default) & (a != default);
    }

    [MethodImpl(256 | 512)]
    public static uint4 up2pow2(this uint4 a)
    {
        --a;
        a |= a >> 1;
        a |= a >> 2;
        a |= a >> 4;
        a |= a >> 8;
        a |= a >> 16;
        return a + uint4.One;
    }
}

#endregion // uint4

#region long2

public partial struct long2
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b64v2 isPow2(this long2 a)
    {
        return ((a & (a - long2.One)) == default) & (a > default(long2));
    }
}

#endregion // long2

#region long3

public partial struct long3
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b64v3 isPow2(this long3 a)
    {
        return ((a & (a - long3.One)) == default) & (a > default(long3));
    }
}

#endregion // long3

#region long4

public partial struct long4
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b64v4 isPow2(this long4 a)
    {
        return ((a & (a - long4.One)) == default) & (a > default(long4));
    }
}

#endregion // long4

#region ulong2

public partial struct ulong2
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b64v2 isPow2(this ulong2 a)
    {
        return ((a & (a - ulong2.One)) == default) & (a != default);
    }

    [MethodImpl(256 | 512)]
    public static ulong2 up2pow2(this ulong2 a)
    {
        --a;
        a |= a >> 1;
        a |= a >> 2;
        a |= a >> 4;
        a |= a >> 8;
        a |= a >> 16;
        a |= a >> 32;
        return a + ulong2.One;
    }
}

#endregion // ulong2

#region ulong3

public partial struct ulong3
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b64v3 isPow2(this ulong3 a)
    {
        return ((a & (a - ulong3.One)) == default) & (a != default);
    }

    [MethodImpl(256 | 512)]
    public static ulong3 up2pow2(this ulong3 a)
    {
        --a;
        a |= a >> 1;
        a |= a >> 2;
        a |= a >> 4;
        a |= a >> 8;
        a |= a >> 16;
        a |= a >> 32;
        return a + ulong3.One;
    }
}

#endregion // ulong3

#region ulong4

public partial struct ulong4
{
}

public static partial class math
{
    [MethodImpl(256 | 512)]
    public static b64v4 isPow2(this ulong4 a)
    {
        return ((a & (a - ulong4.One)) == default) & (a != default);
    }

    [MethodImpl(256 | 512)]
    public static ulong4 up2pow2(this ulong4 a)
    {
        --a;
        a |= a >> 1;
        a |= a >> 2;
        a |= a >> 4;
        a |= a >> 8;
        a |= a >> 16;
        a |= a >> 32;
        return a + ulong4.One;
    }
}

#endregion // ulong4
