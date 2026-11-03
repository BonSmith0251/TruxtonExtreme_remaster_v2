namespace Steamworks;

[Token(Token = "0x20001D6")]
public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B09")]
	public uint m_SNetSocket; //Field offset: 0x0

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000AD2")]
	public SNetSocket_t(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000ADB")]
	public override int CompareTo(SNetSocket_t other) { }

	[Address(RVA = "0x639DD0", Offset = "0x6391D0", Length = "0x7F")]
	[Token(Token = "0x6000AD4")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000ADA")]
	public override bool Equals(SNetSocket_t other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000AD5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000AD6")]
	public static bool op_Equality(SNetSocket_t x, SNetSocket_t y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000AD8")]
	public static SNetSocket_t op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000AD9")]
	public static uint op_Explicit(SNetSocket_t that) { }

	[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
	[Token(Token = "0x6000AD7")]
	public static bool op_Inequality(SNetSocket_t x, SNetSocket_t y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000AD3")]
	public virtual string ToString() { }

}

