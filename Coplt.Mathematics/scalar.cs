namespace Coplt.Mathematics;

public static partial class math
{
    #region select

    [MethodImpl(256 | 512)]
    public static byte select(this bool c, byte t, byte f) => c ? t : f;
    [MethodImpl(256 | 512)]
    public static sbyte select(this bool c, sbyte t, sbyte f) => c ? t : f;
    [MethodImpl(256 | 512)]
    public static ushort select(this bool c, ushort t, ushort f) => c ? t : f;
    [MethodImpl(256 | 512)]
    public static short select(this bool c, short t, short f) => c ? t : f;
    [MethodImpl(256 | 512)]
    public static uint select(this bool c, uint t, uint f) => c ? t : f;
    [MethodImpl(256 | 512)]
    public static int select(this bool c, int t, int f) => c ? t : f;
    [MethodImpl(256 | 512)]
    public static ulong select(this bool c, ulong t, ulong f) => c ? t : f;
    [MethodImpl(256 | 512)]
    public static long select(this bool c, long t, long f) => c ? t : f;
    [MethodImpl(256 | 512)]
    public static half select(this bool c, half t, half f) => c ? t : f;
    [MethodImpl(256 | 512)]
    public static float select(this bool c, float t, float f) => c ? t : f;
    [MethodImpl(256 | 512)]
    public static double select(this bool c, double t, double f) => c ? t : f;
    [MethodImpl(256 | 512)]
    public static decimal select(this bool c, decimal t, decimal f) => c ? t : f;

    #endregion

    #region BitNot

    [MethodImpl(256 | 512)]
    public static b16 BitNot(this b16 v) => ~v;
    [MethodImpl(256 | 512)]
    public static b32 BitNot(this b32 v) => ~v;
    [MethodImpl(256 | 512)]
    public static b64 BitNot(this b64 v) => ~v;

    [MethodImpl(256 | 512)]
    public static byte BitNot(this byte v) => (byte)~(uint)v;
    [MethodImpl(256 | 512)]
    public static sbyte BitNot(this sbyte v) => (sbyte)~(uint)v;
    [MethodImpl(256 | 512)]
    public static ushort BitNot(this ushort v) => (ushort)~v;
    [MethodImpl(256 | 512)]
    public static short BitNot(this short v) => (short)~v;
    [MethodImpl(256 | 512)]
    public static uint BitNot(this uint v) => ~v;
    [MethodImpl(256 | 512)]
    public static int BitNot(this int v) => ~v;
    [MethodImpl(256 | 512)]
    public static ulong BitNot(this ulong v) => ~v;
    [MethodImpl(256 | 512)]
    public static long BitNot(this long v) => ~v;
    [MethodImpl(256 | 512)]
    public static half BitNot(this half v) => ((ushort)~v.AsUInt16()).AsHalf();
    [MethodImpl(256 | 512)]
    public static float BitNot(this float v) => (~v.AsUInt32()).AsSingle();
    [MethodImpl(256 | 512)]
    public static double BitNot(this double v) => (~v.AsUInt32()).AsDouble();

    #endregion

    #region BitOr

    [MethodImpl(256 | 512)]
    public static b16 BitOr(this b16 a, b16 b) => a | b;
    [MethodImpl(256 | 512)]
    public static b32 BitOr(this b32 a, b32 b) => a | b;
    [MethodImpl(256 | 512)]
    public static b64 BitOr(this b64 a, b64 b) => a | b;

    [MethodImpl(256 | 512)]
    public static byte BitOr(this byte a, byte b) => (byte)(a | b);
    [MethodImpl(256 | 512)]
    public static sbyte BitOr(this sbyte a, sbyte b) => (sbyte)(a | b);
    [MethodImpl(256 | 512)]
    public static ushort BitOr(this ushort a, ushort b) => (ushort)(a | b);
    [MethodImpl(256 | 512)]
    public static short BitOr(this short a, short b) => (short)(a | b);
    [MethodImpl(256 | 512)]
    public static uint BitOr(this uint a, uint b) => a | b;
    [MethodImpl(256 | 512)]
    public static int BitOr(this int a, int b) => a | b;
    [MethodImpl(256 | 512)]
    public static ulong BitOr(this ulong a, ulong b) => a | b;
    [MethodImpl(256 | 512)]
    public static long BitOr(this long a, long b) => a | b;
    [MethodImpl(256 | 512)]
    public static half BitOr(this half a, half b) => ((ushort)(a.AsUInt16() | b.AsUInt16())).AsHalf();
    [MethodImpl(256 | 512)]
    public static float BitOr(this float a, float b) => (a.AsUInt32() | b.AsUInt32()).AsSingle();
    [MethodImpl(256 | 512)]
    public static double BitOr(this double a, double b) => (a.AsUInt32() | b.AsUInt32()).AsDouble();

    #endregion

    #region BitAnd

    [MethodImpl(256 | 512)]
    public static b16 BitAnd(this b16 a, b16 b) => a & b;
    [MethodImpl(256 | 512)]
    public static b32 BitAnd(this b32 a, b32 b) => a & b;
    [MethodImpl(256 | 512)]
    public static b64 BitAnd(this b64 a, b64 b) => a & b;

    [MethodImpl(256 | 512)]
    public static byte BitAnd(this byte a, byte b) => (byte)(a & b);
    [MethodImpl(256 | 512)]
    public static sbyte BitAnd(this sbyte a, sbyte b) => (sbyte)(a & b);
    [MethodImpl(256 | 512)]
    public static ushort BitAnd(this ushort a, ushort b) => (ushort)(a & b);
    [MethodImpl(256 | 512)]
    public static short BitAnd(this short a, short b) => (short)(a & b);
    [MethodImpl(256 | 512)]
    public static uint BitAnd(this uint a, uint b) => a & b;
    [MethodImpl(256 | 512)]
    public static int BitAnd(this int a, int b) => a & b;
    [MethodImpl(256 | 512)]
    public static ulong BitAnd(this ulong a, ulong b) => a & b;
    [MethodImpl(256 | 512)]
    public static long BitAnd(this long a, long b) => a & b;
    [MethodImpl(256 | 512)]
    public static half BitAnd(this half a, half b) => ((ushort)(a.AsUInt16() & b.AsUInt16())).AsHalf();
    [MethodImpl(256 | 512)]
    public static float BitAnd(this float a, float b) => (a.AsUInt32() & b.AsUInt32()).AsSingle();
    [MethodImpl(256 | 512)]
    public static double BitAnd(this double a, double b) => (a.AsUInt32() & b.AsUInt32()).AsDouble();

    #endregion

    #region BitXor

    [MethodImpl(256 | 512)]
    public static b16 BitXor(this b16 a, b16 b) => a ^ b;
    [MethodImpl(256 | 512)]
    public static b32 BitXor(this b32 a, b32 b) => a ^ b;
    [MethodImpl(256 | 512)]
    public static b64 BitXor(this b64 a, b64 b) => a ^ b;

    [MethodImpl(256 | 512)]
    public static byte BitXor(this byte a, byte b) => (byte)(a ^ b);
    [MethodImpl(256 | 512)]
    public static sbyte BitXor(this sbyte a, sbyte b) => (sbyte)(a ^ b);
    [MethodImpl(256 | 512)]
    public static ushort BitXor(this ushort a, ushort b) => (ushort)(a ^ b);
    [MethodImpl(256 | 512)]
    public static short BitXor(this short a, short b) => (short)(a ^ b);
    [MethodImpl(256 | 512)]
    public static uint BitXor(this uint a, uint b) => a ^ b;
    [MethodImpl(256 | 512)]
    public static int BitXor(this int a, int b) => a ^ b;
    [MethodImpl(256 | 512)]
    public static ulong BitXor(this ulong a, ulong b) => a ^ b;
    [MethodImpl(256 | 512)]
    public static long BitXor(this long a, long b) => a ^ b;
    [MethodImpl(256 | 512)]
    public static half BitXor(this half a, half b) => ((ushort)(a.AsUInt16() ^ b.AsUInt16())).AsHalf();
    [MethodImpl(256 | 512)]
    public static float BitXor(this float a, float b) => (a.AsUInt32() ^ b.AsUInt32()).AsSingle();
    [MethodImpl(256 | 512)]
    public static double BitXor(this double a, double b) => (a.AsUInt32() ^ b.AsUInt32()).AsDouble();

    #endregion

    #region BitAndNot

    [MethodImpl(256 | 512)]
    public static b16 BitAndNot(this b16 a, b16 b) => a & ~b;
    [MethodImpl(256 | 512)]
    public static b32 BitAndNot(this b32 a, b32 b) => a & ~b;
    [MethodImpl(256 | 512)]
    public static b64 BitAndNot(this b64 a, b64 b) => a & ~b;

    [MethodImpl(256 | 512)]
    public static byte BitAndNot(this byte a, byte b) => (byte)(a & ~b);
    [MethodImpl(256 | 512)]
    public static sbyte BitAndNot(this sbyte a, sbyte b) => (sbyte)(a & ~b);
    [MethodImpl(256 | 512)]
    public static ushort BitAndNot(this ushort a, ushort b) => (ushort)(a & ~b);
    [MethodImpl(256 | 512)]
    public static short BitAndNot(this short a, short b) => (short)(a & ~b);
    [MethodImpl(256 | 512)]
    public static uint BitAndNot(this uint a, uint b) => a & ~b;
    [MethodImpl(256 | 512)]
    public static int BitAndNot(this int a, int b) => a & ~b;
    [MethodImpl(256 | 512)]
    public static ulong BitAndNot(this ulong a, ulong b) => a & ~b;
    [MethodImpl(256 | 512)]
    public static long BitAndNot(this long a, long b) => a & ~b;
    [MethodImpl(256 | 512)]
    public static half BitAndNot(this half a, half b) => ((ushort)(a.AsUInt16() & ~b.AsUInt16())).AsHalf();
    [MethodImpl(256 | 512)]
    public static float BitAndNot(this float a, float b) => (a.AsUInt32() & ~b.AsUInt32()).AsSingle();
    [MethodImpl(256 | 512)]
    public static double BitAndNot(this double a, double b) => (a.AsUInt32() & ~b.AsUInt32()).AsDouble();

    #endregion

    #region BitShiftLeft

    [MethodImpl(256 | 512)]
    public static byte BitShiftLeft(this byte a, int b) => (byte)(a << b);
    [MethodImpl(256 | 512)]
    public static sbyte BitShiftLeft(this sbyte a, int b) => (sbyte)(a << b);
    [MethodImpl(256 | 512)]
    public static ushort BitShiftLeft(this ushort a, int b) => (ushort)(a << b);
    [MethodImpl(256 | 512)]
    public static short BitShiftLeft(this short a, int b) => (short)(a << b);
    [MethodImpl(256 | 512)]
    public static uint BitShiftLeft(this uint a, int b) => a << b;
    [MethodImpl(256 | 512)]
    public static int BitShiftLeft(this int a, int b) => a << b;
    [MethodImpl(256 | 512)]
    public static ulong BitShiftLeft(this ulong a, int b) => a << b;
    [MethodImpl(256 | 512)]
    public static long BitShiftLeft(this long a, int b) => a << b;
    [MethodImpl(256 | 512)]
    public static half BitShiftLeft(this half a, int b) => ((ushort)(a.AsUInt16() << b)).AsHalf();
    [MethodImpl(256 | 512)]
    public static float BitShiftLeft(this float a, int b) => (a.AsUInt32() << b).AsSingle();
    [MethodImpl(256 | 512)]
    public static double BitShiftLeft(this double a, int b) => (a.AsUInt32() << b).AsDouble();

    #endregion

    #region BitShiftRight

    [MethodImpl(256 | 512)]
    public static byte BitShiftRight(this byte a, int b) => (byte)(a >> b);
    [MethodImpl(256 | 512)]
    public static sbyte BitShiftRight(this sbyte a, int b) => (sbyte)(a >> b);
    [MethodImpl(256 | 512)]
    public static ushort BitShiftRight(this ushort a, int b) => (ushort)(a >> b);
    [MethodImpl(256 | 512)]
    public static short BitShiftRight(this short a, int b) => (short)(a >> b);
    [MethodImpl(256 | 512)]
    public static uint BitShiftRight(this uint a, int b) => a >> b;
    [MethodImpl(256 | 512)]
    public static int BitShiftRight(this int a, int b) => a >> b;
    [MethodImpl(256 | 512)]
    public static ulong BitShiftRight(this ulong a, int b) => a >> b;
    [MethodImpl(256 | 512)]
    public static long BitShiftRight(this long a, int b) => a >> b;
    [MethodImpl(256 | 512)]
    public static half BitShiftRight(this half a, int b) => ((ushort)(a.AsUInt16() >> b)).AsHalf();
    [MethodImpl(256 | 512)]
    public static float BitShiftRight(this float a, int b) => (a.AsUInt32() >> b).AsSingle();
    [MethodImpl(256 | 512)]
    public static double BitShiftRight(this double a, int b) => (a.AsUInt32() >> b).AsDouble();

    #endregion

    #region BitShiftRightUnsigned

    [MethodImpl(256 | 512)]
    public static byte BitShiftRightUnsigned(this byte a, int b) => (byte)(a >>> b);
    [MethodImpl(256 | 512)]
    public static sbyte BitShiftRightUnsigned(this sbyte a, int b) => (sbyte)(a >>> b);
    [MethodImpl(256 | 512)]
    public static ushort BitShiftRightUnsigned(this ushort a, int b) => (ushort)(a >>> b);
    [MethodImpl(256 | 512)]
    public static short BitShiftRightUnsigned(this short a, int b) => (short)(a >>> b);
    [MethodImpl(256 | 512)]
    public static uint BitShiftRightUnsigned(this uint a, int b) => a >>> b;
    [MethodImpl(256 | 512)]
    public static int BitShiftRightUnsigned(this int a, int b) => a >>> b;
    [MethodImpl(256 | 512)]
    public static ulong BitShiftRightUnsigned(this ulong a, int b) => a >>> b;
    [MethodImpl(256 | 512)]
    public static long BitShiftRightUnsigned(this long a, int b) => a >>> b;
    [MethodImpl(256 | 512)]
    public static half BitShiftRightUnsigned(this half a, int b) => ((ushort)(a.AsUInt16() >>> b)).AsHalf();
    [MethodImpl(256 | 512)]
    public static float BitShiftRightUnsigned(this float a, int b) => (a.AsUInt32() >>> b).AsSingle();
    [MethodImpl(256 | 512)]
    public static double BitShiftRightUnsigned(this double a, int b) => (a.AsUInt32() >>> b).AsDouble();

    #endregion

    #region Abs

    [MethodImpl(256 | 512)]
    public static byte abs(this byte v) => v;
    [MethodImpl(256 | 512)]
    public static sbyte abs(this sbyte v) => Math.Abs(v);
    [MethodImpl(256 | 512)]
    public static ushort abs(this ushort v) => v;
    [MethodImpl(256 | 512)]
    public static short abs(this short v) => Math.Abs(v);
    [MethodImpl(256 | 512)]
    public static uint abs(this uint v) => v;
    [MethodImpl(256 | 512)]
    public static int abs(this int v) => Math.Abs(v);
    [MethodImpl(256 | 512)]
    public static ulong abs(this ulong v) => v;
    [MethodImpl(256 | 512)]
    public static long abs(this long v) => Math.Abs(v);
    [MethodImpl(256 | 512)]
    public static half abs(this half v) => (half)Math.Abs((float)v);
    [MethodImpl(256 | 512)]
    public static float abs(this float v) => Math.Abs(v);
    [MethodImpl(256 | 512)]
    public static double abs(this double v) => Math.Abs(v);
    [MethodImpl(256 | 512)]
    public static decimal abs(this decimal v) => Math.Abs(v);

    #endregion

    #region Sign

    [MethodImpl(256 | 512)]
    public static byte sign(this byte v) => (byte)(v == 0 ? 0 : 1);
    [MethodImpl(256 | 512)]
    public static sbyte sign(this sbyte v) => (sbyte)Math.Sign(v);
    [MethodImpl(256 | 512)]
    public static ushort sign(this ushort v) => (ushort)(v == 0 ? 0 : 1);
    [MethodImpl(256 | 512)]
    public static short sign(this short v) => (short)Math.Sign(v);
    [MethodImpl(256 | 512)]
    public static uint sign(this uint v) => v == 0u ? 0u : 1u;
    [MethodImpl(256 | 512)]
    public static int sign(this int v) => Math.Sign(v);
    [MethodImpl(256 | 512)]
    public static ulong sign(this ulong v) => v == 0ul ? 0ul : 1ul;
    [MethodImpl(256 | 512)]
    public static long sign(this long v) => Math.Sign(v);
    [MethodImpl(256 | 512)]
    public static half sign(this half v) => (half)Math.Sign((float)v);
    [MethodImpl(256 | 512)]
    public static float sign(this float v) => Math.Sign(v);
    [MethodImpl(256 | 512)]
    public static double sign(this double v) => Math.Sign(v);
    [MethodImpl(256 | 512)]
    public static decimal sign(this decimal v) => Math.Sign(v);

    #endregion

    #region Ceil

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half ceil(this half v) => half.Ceiling(v);
    #else
    public static half ceil(this half v) => (half)MathF.Ceiling(v);
    #endif
    [MethodImpl(256 | 512)]
    public static float ceil(this float v) => MathF.Ceiling(v);
    [MethodImpl(256 | 512)]
    public static double ceil(this double v) => Math.Ceiling(v);
    [MethodImpl(256 | 512)]
    public static decimal ceil(this decimal v) => Math.Ceiling(v);

    #endregion

    #region Floor

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half floor(this half v) => half.Floor(v);
    #else
    public static half floor(this half v) => (half)MathF.Floor(v);
    #endif
    [MethodImpl(256 | 512)]
    public static float floor(this float v) => MathF.Floor(v);
    [MethodImpl(256 | 512)]
    public static double floor(this double v) => Math.Floor(v);
    [MethodImpl(256 | 512)]
    public static decimal floor(this decimal v) => Math.Floor(v);

    #endregion

    #region Round

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half round(this half v) => half.Round(v);
    #else
    public static half round(this half v) => (half)MathF.Round(v);
    #endif
    [MethodImpl(256 | 512)]
    public static float round(this float v) => MathF.Round(v);
    [MethodImpl(256 | 512)]
    public static double round(this double v) => Math.Round(v);
    [MethodImpl(256 | 512)]
    public static decimal round(this decimal v) => Math.Round(v);

    #endregion

    #region Trunc

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half trunc(this half v) => half.Truncate(v);
    #else
    public static half trunc(this half v) => (half)MathF.Truncate(v);
    #endif
    [MethodImpl(256 | 512)]
    public static float trunc(this float v) => MathF.Truncate(v);
    [MethodImpl(256 | 512)]
    public static double trunc(this double v) => Math.Truncate(v);
    [MethodImpl(256 | 512)]
    public static decimal trunc(this decimal v) => Math.Truncate(v);

    #endregion

    #region Frac

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half frac(this half v) => v - half.Floor(v);
    #else
    public static half frac(this half v) => (half)(v - MathF.Floor(v));
    #endif
    [MethodImpl(256 | 512)]
    public static float frac(this float v) => v - MathF.Floor(v);
    [MethodImpl(256 | 512)]
    public static double frac(this double v) => v - Math.Floor(v);
    [MethodImpl(256 | 512)]
    public static decimal frac(this decimal v) => v - Math.Floor(v);

    #endregion

    #region Modf

    [MethodImpl(256 | 512)]
    public static half modf(this half v, out half i)
    {
        i = trunc(v);
        return (half)(v - i);
    }
    [MethodImpl(256 | 512)]
    public static float modf(this float v, out float i)
    {
        i = trunc(v);
        return v - i;
    }
    [MethodImpl(256 | 512)]
    public static double modf(this double v, out double i)
    {
        i = trunc(v);
        return v - i;
    }
    [MethodImpl(256 | 512)]
    public static decimal modf(this decimal v, out decimal i)
    {
        i = trunc(v);
        return v - i;
    }

    #endregion

    #region Min

    [MethodImpl(256 | 512)]
    public static byte min(this byte a, byte b) => Math.Min(a, b);
    [MethodImpl(256 | 512)]
    public static sbyte min(this sbyte a, sbyte b) => Math.Min(a, b);
    [MethodImpl(256 | 512)]
    public static ushort min(this ushort a, ushort b) => Math.Min(a, b);
    [MethodImpl(256 | 512)]
    public static short min(this short a, short b) => Math.Min(a, b);
    [MethodImpl(256 | 512)]
    public static uint min(this uint a, uint b) => Math.Min(a, b);
    [MethodImpl(256 | 512)]
    public static int min(this int a, int b) => Math.Min(a, b);
    [MethodImpl(256 | 512)]
    public static ulong min(this ulong a, ulong b) => Math.Min(a, b);
    [MethodImpl(256 | 512)]
    public static long min(this long a, long b) => Math.Min(a, b);
    #if NET8_0_OR_GREATER
    [MethodImpl(256 | 512)]
    public static half min(this half a, half b) => half.Min(a, b);
    #else
    [MethodImpl(256 | 512)]
    public static half min(this half a, half b) => (half)Math.Min(a, b);
    #endif
    [MethodImpl(256 | 512)]
    public static float min(this float a, float b) => Math.Min(a, b);
    [MethodImpl(256 | 512)]
    public static double min(this double a, double b) => Math.Min(a, b);
    [MethodImpl(256 | 512)]
    public static decimal min(this decimal a, decimal b) => Math.Min(a, b);

    #endregion

    #region Max

    [MethodImpl(256 | 512)]
    public static byte max(this byte a, byte b) => Math.Max(a, b);
    [MethodImpl(256 | 512)]
    public static sbyte max(this sbyte a, sbyte b) => Math.Max(a, b);
    [MethodImpl(256 | 512)]
    public static ushort max(this ushort a, ushort b) => Math.Max(a, b);
    [MethodImpl(256 | 512)]
    public static short max(this short a, short b) => Math.Max(a, b);
    [MethodImpl(256 | 512)]
    public static uint max(this uint a, uint b) => Math.Max(a, b);
    [MethodImpl(256 | 512)]
    public static int max(this int a, int b) => Math.Max(a, b);
    [MethodImpl(256 | 512)]
    public static ulong max(this ulong a, ulong b) => Math.Max(a, b);
    [MethodImpl(256 | 512)]
    public static long max(this long a, long b) => Math.Max(a, b);
    #if NET8_0_OR_GREATER
    [MethodImpl(256 | 512)]
    public static half max(this half a, half b) => half.Max(a, b);
    #else
    [MethodImpl(256 | 512)]
    public static half max(this half a, half b) => (half)Math.Max(a, b);
    #endif
    [MethodImpl(256 | 512)]
    public static float max(this float a, float b) => Math.Max(a, b);
    [MethodImpl(256 | 512)]
    public static double max(this double a, double b) => Math.Max(a, b);
    [MethodImpl(256 | 512)]
    public static decimal max(this decimal a, decimal b) => Math.Max(a, b);

    #endregion

    #region Clamp

    [MethodImpl(256 | 512)]
    public static byte clamp(this byte v, byte min, byte max) => Math.Max(min, Math.Min(max, v));
    [MethodImpl(256 | 512)]
    public static sbyte clamp(this sbyte v, sbyte min, sbyte max) => Math.Max(min, Math.Min(max, v));
    [MethodImpl(256 | 512)]
    public static ushort clamp(this ushort v, ushort min, ushort max) => Math.Max(min, Math.Min(max, v));
    [MethodImpl(256 | 512)]
    public static short clamp(this short v, short min, short max) => Math.Max(min, Math.Min(max, v));
    [MethodImpl(256 | 512)]
    public static uint clamp(this uint v, uint min, uint max) => Math.Max(min, Math.Min(max, v));
    [MethodImpl(256 | 512)]
    public static int clamp(this int v, int min, int max) => Math.Max(min, Math.Min(max, v));
    [MethodImpl(256 | 512)]
    public static ulong clamp(this ulong v, ulong min, ulong max) => Math.Max(min, Math.Min(max, v));
    [MethodImpl(256 | 512)]
    public static long clamp(this long v, long min, long max) => Math.Max(min, Math.Min(max, v));
    #if NET8_0_OR_GREATER
    [MethodImpl(256 | 512)]
    public static half clamp(this half v, half min, half max) => half.Max(min, half.Min(max, v));
    #else
    [MethodImpl(256 | 512)]
    public static half clamp(this half v, half min, half max) => (half)Math.Max(min, Math.Min(max, v));
    #endif
    [MethodImpl(256 | 512)]
    public static float clamp(this float v, float min, float max) => Math.Max(min, Math.Min(max, v));
    [MethodImpl(256 | 512)]
    public static double clamp(this double v, double min, double max) => Math.Max(min, Math.Min(max, v));
    [MethodImpl(256 | 512)]
    public static decimal clamp(this decimal v, decimal min, decimal max) => Math.Max(min, Math.Min(max, v));

    #endregion

    #region rcp

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half rcp(this half v) => half.One / v;
    #else
    public static half rcp(this half v) => (half)(1 / v);
    #endif
    [MethodImpl(256 | 512)]
    public static float rcp(this float v) => 1.0f / v;
    [MethodImpl(256 | 512)]
    public static double rcp(this double v) => 1.0 / v;
    [MethodImpl(256 | 512)]
    public static decimal rcp(this decimal v) => 1.0m / v;

    #endregion

    #region Fma

    #if NET8_0_OR_GREATER
    [MethodImpl(256 | 512)]
    public static half fma(this half a, half b, half c) => half.FusedMultiplyAdd(a, b, c);
    [MethodImpl(256 | 512)]
    public static float fma(this float a, float b, float c) => MathF.FusedMultiplyAdd(a, b, c);
    [MethodImpl(256 | 512)]
    public static double fma(this double a, double b, double c) => Math.FusedMultiplyAdd(a, b, c);
    #else
    [MethodImpl(256 | 512)]
    public static half fma(this half a, half b, half c) => (half)(a * b + c);
    [MethodImpl(256 | 512)]
    public static float fma(this float a, float b, float c) => a * b + c;
    [MethodImpl(256 | 512)]
    public static double fma(this double a, double b, double c) => a * b + c;
    #endif

    #endregion

    #region Log

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half log(this half a) => half.Log(a);
    #else
    public static half log(this half a) => (half)MathF.Log(a);
    #endif
    [MethodImpl(256 | 512)]
    public static float log(this float a) => MathF.Log(a);
    [MethodImpl(256 | 512)]
    public static double log(this double a) => Math.Log(a);

    #endregion

    #region Log2

    #if NET8_0_OR_GREATER
    [MethodImpl(256 | 512)]
    public static half log2(this half a) => half.Log2(a);
    [MethodImpl(256 | 512)]
    public static float log2(this float a) => MathF.Log2(a);
    [MethodImpl(256 | 512)]
    public static double log2(this double a) => Math.Log2(a);
    #else
    [MethodImpl(256 | 512)]
    public static half log2(this half a) => (half)(MathF.Log(a) / math.F_Log2);
    [MethodImpl(256 | 512)]
    public static float log2(this float a) => MathF.Log(a) / math.F_Log2;
    [MethodImpl(256 | 512)]
    public static double log2(this double a) => Math.Log(a) / math.D_Log2;
    #endif

    #endregion

    #region Log10

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half log10(this half a) => half.Log10(a);
    #else
    public static half log10(this half a) => (half)MathF.Log10(a);
    #endif
    [MethodImpl(256 | 512)]
    public static float log10(this float a) => MathF.Log10(a);
    [MethodImpl(256 | 512)]
    public static double log10(this double a) => Math.Log10(a);

    #endregion

    #region Log N

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half log(this half a, half b) => half.Log(a, b);
    #else
    public static half log(this half a, half b) => (half)MathF.Log(a, b);
    #endif
    [MethodImpl(256 | 512)]
    public static float log(this float a, float b) => MathF.Log(a, b);
    [MethodImpl(256 | 512)]
    public static double log(this double a, double b) => Math.Log(a, b);

    #endregion

    #region Exp

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half exp(this half a) => half.Exp(a);
    #else
    public static half exp(this half a) => (half)MathF.Exp(a);
    #endif
    [MethodImpl(256 | 512)]
    public static float exp(this float a) => MathF.Exp(a);
    [MethodImpl(256 | 512)]
    public static double exp(this double a) => Math.Exp(a);

    #endregion

    #region Exp2

    [MethodImpl(256 | 512)]
    public static half exp2(this half a) => (half)MathF.Exp((float)a * 0.693147180559945309f);
    [MethodImpl(256 | 512)]
    public static float exp2(this float a) => MathF.Exp(a * 0.693147180559945309f);
    [MethodImpl(256 | 512)]
    public static double exp2(this double a) => Math.Exp(a * 0.693147180559945309);

    #endregion

    #region Exp10

    [MethodImpl(256 | 512)]
    public static half exp10(this half a) => (half)MathF.Exp((float)a * 2.302585092994045684f);
    [MethodImpl(256 | 512)]
    public static float exp10(this float a) => MathF.Exp(a * 2.302585092994045684f);
    [MethodImpl(256 | 512)]
    public static double exp10(this double a) => Math.Exp(a * 2.302585092994045684);

    #endregion

    #region Pow

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half pow(this half a, half b) => half.Pow(a, b);
    #else
    public static half pow(this half a, half b) => (half)MathF.Pow(a, b);
    #endif
    [MethodImpl(256 | 512)]
    public static float pow(this float a, float b) => MathF.Pow(a, b);
    [MethodImpl(256 | 512)]
    public static double pow(this double a, double b) => Math.Pow(a, b);

    #endregion

    #region IsInf

    [MethodImpl(256 | 512)]
    public static bool isInf(this half a) => half.IsInfinity(a);
    [MethodImpl(256 | 512)]
    public static bool isInf(this float a) => float.IsInfinity(a);
    [MethodImpl(256 | 512)]
    public static bool isInf(this double a) => double.IsInfinity(a);

    #endregion

    #region IsPInf

    [MethodImpl(256 | 512)]
    public static bool isPosInf(this half a) => half.IsPositiveInfinity(a);
    [MethodImpl(256 | 512)]
    public static bool isPosInf(this float a) => float.IsPositiveInfinity(a);
    [MethodImpl(256 | 512)]
    public static bool isPosInf(this double a) => double.IsPositiveInfinity(a);

    #endregion

    #region IsNegInf

    [MethodImpl(256 | 512)]
    public static bool isNegInf(this half a) => half.IsNegativeInfinity(a);
    [MethodImpl(256 | 512)]
    public static bool isNegInf(this float a) => float.IsNegativeInfinity(a);
    [MethodImpl(256 | 512)]
    public static bool isNegInf(this double a) => double.IsNegativeInfinity(a);

    #endregion

    #region Saturate

    [MethodImpl(256 | 512)]
    public static half saturate(this half v) => v.clamp((half)0f, (half)1f);
    [MethodImpl(256 | 512)]
    public static float saturate(this float v) => v.clamp(0f, 1f);
    [MethodImpl(256 | 512)]
    public static double saturate(this double v) => v.clamp(0, 1);
    [MethodImpl(256 | 512)]
    public static decimal saturate(this decimal v) => v.clamp(0m, 1m);

    #endregion

    #region Dot

    [MethodImpl(256 | 512)]
    public static byte dot(this byte a, byte b) => (byte)(a * b);
    [MethodImpl(256 | 512)]
    public static sbyte dot(this sbyte a, sbyte b) => (sbyte)(a * b);
    [MethodImpl(256 | 512)]
    public static ushort dot(this ushort a, ushort b) => (ushort)(a * b);
    [MethodImpl(256 | 512)]
    public static short dot(this short a, short b) => (short)(a * b);
    [MethodImpl(256 | 512)]
    public static uint dot(this uint a, uint b) => a * b;
    [MethodImpl(256 | 512)]
    public static int dot(this int a, int b) => a * b;
    [MethodImpl(256 | 512)]
    public static ulong dot(this ulong a, ulong b) => a * b;
    [MethodImpl(256 | 512)]
    public static long dot(this long a, long b) => a * b;
    #if NET8_0_OR_GREATER
    [MethodImpl(256 | 512)]
    public static half dot(this half a, half b) => a * b;
    #else
    [MethodImpl(256 | 512)]
    public static half dot(this half a, half b) => (half)(a * b);
    #endif
    [MethodImpl(256 | 512)]
    public static float dot(this float a, float b) => a * b;
    [MethodImpl(256 | 512)]
    public static double dot(this double a, double b) => a * b;
    [MethodImpl(256 | 512)]
    public static decimal dot(this decimal a, decimal b) => a * b;

    #endregion

    #region Sqrt

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half sqrt(this half v) => half.Sqrt(v);
    #else
    public static half sqrt(this half v) => (half)MathF.Sqrt(v);
    #endif
    [MethodImpl(256 | 512)]
    public static float sqrt(this float v) => MathF.Sqrt(v);
    [MethodImpl(256 | 512)]
    public static double sqrt(this double v) => Math.Sqrt(v);

    #endregion

    #region RSqrt

    [MethodImpl(256 | 512)]
    public static half rsqrt(this half v) => (half)(1 / sqrt((float)v));
    [MethodImpl(256 | 512)]
    public static float rsqrt(this float v) => 1 / sqrt(v);
    [MethodImpl(256 | 512)]
    public static double rsqrt(this double v) => 1 / sqrt(v);

    #endregion

    #region LengthSq

    [MethodImpl(256 | 512)]
    public static byte lengthsq(this byte v) => dot(v, v);
    [MethodImpl(256 | 512)]
    public static sbyte lengthsq(this sbyte v) => dot(v, v);
    [MethodImpl(256 | 512)]
    public static ushort lengthsq(this ushort v) => dot(v, v);
    [MethodImpl(256 | 512)]
    public static short lengthsq(this short v) => dot(v, v);
    [MethodImpl(256 | 512)]
    public static uint lengthsq(this uint v) => dot(v, v);
    [MethodImpl(256 | 512)]
    public static int lengthsq(this int v) => dot(v, v);
    [MethodImpl(256 | 512)]
    public static ulong lengthsq(this ulong v) => dot(v, v);
    [MethodImpl(256 | 512)]
    public static long lengthsq(this long v) => dot(v, v);
    [MethodImpl(256 | 512)]
    public static half lengthsq(this half v) => dot(v, v);
    [MethodImpl(256 | 512)]
    public static float lengthsq(this float v) => dot(v, v);
    [MethodImpl(256 | 512)]
    public static double lengthsq(this double v) => dot(v, v);
    [MethodImpl(256 | 512)]
    public static decimal lengthsq(this decimal v) => dot(v, v);

    #endregion

    #region Length

    [MethodImpl(256 | 512)]
    public static byte length(this byte v) => abs(v);
    [MethodImpl(256 | 512)]
    public static sbyte length(this sbyte v) => abs(v);
    [MethodImpl(256 | 512)]
    public static ushort length(this ushort v) => abs(v);
    [MethodImpl(256 | 512)]
    public static short length(this short v) => abs(v);
    [MethodImpl(256 | 512)]
    public static uint length(this uint v) => abs(v);
    [MethodImpl(256 | 512)]
    public static int length(this int v) => abs(v);
    [MethodImpl(256 | 512)]
    public static ulong length(this ulong v) => abs(v);
    [MethodImpl(256 | 512)]
    public static long length(this long v) => abs(v);
    [MethodImpl(256 | 512)]
    public static half length(this half v) => abs(v);
    [MethodImpl(256 | 512)]
    public static float length(this float v) => abs(v);
    [MethodImpl(256 | 512)]
    public static double length(this double v) => abs(v);
    [MethodImpl(256 | 512)]
    public static decimal length(this decimal v) => abs(v);

    #endregion

    #region DistanceSq

    [MethodImpl(256 | 512)]
    public static byte distancesq(this byte a, byte b) => (byte)lengthsq(b - a);
    [MethodImpl(256 | 512)]
    public static sbyte distancesq(this sbyte a, sbyte b) => (sbyte)lengthsq(b - a);
    [MethodImpl(256 | 512)]
    public static ushort distancesq(this ushort a, ushort b) => (ushort)lengthsq(b - a);
    [MethodImpl(256 | 512)]
    public static short distancesq(this short a, short b) => (short)lengthsq(b - a);
    [MethodImpl(256 | 512)]
    public static uint distancesq(this uint a, uint b) => lengthsq(b - a);
    [MethodImpl(256 | 512)]
    public static int distancesq(this int a, int b) => lengthsq(b - a);
    [MethodImpl(256 | 512)]
    public static ulong distancesq(this ulong a, ulong b) => lengthsq(b - a);
    [MethodImpl(256 | 512)]
    public static long distancesq(this long a, long b) => lengthsq(b - a);
    [MethodImpl(256 | 512)]
    public static half distancesq(this half a, half b) => (half)lengthsq(b - a);
    [MethodImpl(256 | 512)]
    public static float distancesq(this float a, float b) => lengthsq(b - a);
    [MethodImpl(256 | 512)]
    public static double distancesq(this double a, double b) => lengthsq(b - a);
    [MethodImpl(256 | 512)]
    public static decimal distancesq(this decimal a, decimal b) => lengthsq(b - a);

    #endregion

    #region Distance

    [MethodImpl(256 | 512)]
    public static byte distance(this byte a, byte b) => (byte)abs(b - a);
    [MethodImpl(256 | 512)]
    public static sbyte distance(this sbyte a, sbyte b) => (sbyte)abs(b - a);
    [MethodImpl(256 | 512)]
    public static ushort distance(this ushort a, ushort b) => (ushort)abs(b - a);
    [MethodImpl(256 | 512)]
    public static short distance(this short a, short b) => (short)abs(b - a);
    [MethodImpl(256 | 512)]
    public static uint distance(this uint a, uint b) => abs(b - a);
    [MethodImpl(256 | 512)]
    public static int distance(this int a, int b) => abs(b - a);
    [MethodImpl(256 | 512)]
    public static ulong distance(this ulong a, ulong b) => abs(b - a);
    [MethodImpl(256 | 512)]
    public static long distance(this long a, long b) => abs(b - a);
    [MethodImpl(256 | 512)]
    public static half distance(this half a, half b) => (half)abs(b - a);
    [MethodImpl(256 | 512)]
    public static float distance(this float a, float b) => abs(b - a);
    [MethodImpl(256 | 512)]
    public static double distance(this double a, double b) => abs(b - a);
    [MethodImpl(256 | 512)]
    public static decimal distance(this decimal a, decimal b) => abs(b - a);

    #endregion

    #region Sin

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half sin(this half a) => half.Sin(a);
    #else
    public static half sin(this half a) => (half)MathF.Sin(a);
    #endif
    [MethodImpl(256 | 512)]
    public static float sin(this float a) => MathF.Sin(a);
    [MethodImpl(256 | 512)]
    public static double sin(this double a) => Math.Sin(a);

    #endregion

    #region Cos

    [MethodImpl(256 | 512)]
    #if NET8_0_OR_GREATER
    public static half cos(this half a) => half.Cos(a);
    #else
    public static half cos(this half a) => (half)MathF.Cos(a);
    #endif
    [MethodImpl(256 | 512)]
    public static float cos(this float a) => MathF.Cos(a);
    [MethodImpl(256 | 512)]
    public static double cos(this double a) => Math.Cos(a);

    #endregion

    #region SinCos

    #if NET8_0_OR_GREATER
    [MethodImpl(256 | 512)]
    public static (half sin, half cos) sincos(this half a) => half.SinCos(a);
    [MethodImpl(256 | 512)]
    public static (float sin, float cos) sincos(this float a) => MathF.SinCos(a);
    [MethodImpl(256 | 512)]
    public static (double sin, double cos) sincos(this double a) => Math.SinCos(a);
    #else
    [MethodImpl(256 | 512)]
    public static (half sin, half cos) sincos(this half a) => ((half)MathF.Sin(a), (half)MathF.Cos(a));
    [MethodImpl(256 | 512)]
    public static (float sin, float cos) sincos(this float a) => (MathF.Sin(a), MathF.Cos(a));
    [MethodImpl(256 | 512)]
    public static (double sin, double cos) sincos(this double a) => (Math.Sin(a), Math.Cos(a));
    #endif

    #endregion

    #region SinCos out

    [MethodImpl(256 | 512)]
    public static void sincos(this half a, out half sin, out half cos) => (sin, cos) = sincos(a);
    [MethodImpl(256 | 512)]
    public static void sincos(this float a, out float sin, out float cos) => (sin, cos) = sincos(a);
    [MethodImpl(256 | 512)]
    public static void sincos(this double a, out double sin, out double cos) => (sin, cos) = sincos(a);

    #endregion
}
