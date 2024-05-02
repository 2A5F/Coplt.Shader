namespace Coplt.Mathematics;

public static partial class scalar
{
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
}
