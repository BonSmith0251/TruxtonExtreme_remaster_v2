namespace Steamworks;

[Token(Token = "0x20001D5")]
public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B08")]
	public uint m_SNetListenSocket; //Field offset: 0x0

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000AC8")]
	public SNetListenSocket_t(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000AD1")]
	public override int CompareTo(SNetListenSocket_t other) { }

	[Address(RVA = "0x639D50", Offset = "0x639150", Length = "0x7F")]
	[Token(Token = "0x6000ACA")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000AD0")]
	public override bool Equals(SNetListenSocket_t other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000ACB")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000ACC")]
	public static bool op_Equality(SNetListenSocket_t x, SNetListenSocket_t y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000ACE")]
	public static SNetListenSocket_t op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000ACF")]
	public static uint op_Explicit(SNetListenSocket_t that) { }

	[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
	[Token(Token = "0x6000ACD")]
	public static bool op_Inequality(SNetListenSocket_t x, SNetListenSocket_t y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000AC9")]
	public virtual string ToString() { }

}

