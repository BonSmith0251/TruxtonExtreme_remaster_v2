namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200000B")]
internal struct IntPoint
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000013")]
	public long N; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000014")]
	public long X; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000015")]
	public long Y; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000016")]
	public long D; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000017")]
	public double NX; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000018")]
	public double NY; //Field offset: 0x28

	[Address(RVA = "0x2D18690", Offset = "0x2D17A90", Length = "0x1E")]
	[Token(Token = "0x600002B")]
	public IntPoint(long X, long Y) { }

	[Address(RVA = "0x2D18660", Offset = "0x2D17A60", Length = "0x28")]
	[Token(Token = "0x600002C")]
	public IntPoint(double x, double y) { }

	[Address(RVA = "0x2D186B0", Offset = "0x2D17AB0", Length = "0x2F")]
	[Token(Token = "0x600002D")]
	public IntPoint(IntPoint pt) { }

	[Address(RVA = "0x2D18570", Offset = "0x2D17970", Length = "0x8D")]
	[Token(Token = "0x6000030")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2D18600", Offset = "0x2D17A00", Length = "0x60")]
	[Token(Token = "0x6000031")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2D186E0", Offset = "0x2D17AE0", Length = "0x25")]
	[Token(Token = "0x600002E")]
	public static bool op_Equality(IntPoint a, IntPoint b) { }

	[Address(RVA = "0x2D18710", Offset = "0x2D17B10", Length = "0x25")]
	[Token(Token = "0x600002F")]
	public static bool op_Inequality(IntPoint a, IntPoint b) { }

}

