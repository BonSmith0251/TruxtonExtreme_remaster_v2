namespace Steamworks;

[Token(Token = "0x20001EF")]
public struct RTime32 : IEquatable<RTime32>, IComparable<RTime32>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B65")]
	public uint m_RTime32; //Field offset: 0x0

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000BB1")]
	public RTime32(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000BBA")]
	public override int CompareTo(RTime32 other) { }

	[Address(RVA = "0x646B90", Offset = "0x645F90", Length = "0x7F")]
	[Token(Token = "0x6000BB3")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000BB9")]
	public override bool Equals(RTime32 other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000BB4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000BB5")]
	public static bool op_Equality(RTime32 x, RTime32 y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000BB7")]
	public static RTime32 op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000BB8")]
	public static uint op_Explicit(RTime32 that) { }

	[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
	[Token(Token = "0x6000BB6")]
	public static bool op_Inequality(RTime32 x, RTime32 y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000BB2")]
	public virtual string ToString() { }

}

