namespace Steamworks;

[Token(Token = "0x20001ED")]
public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
{
	[Token(Token = "0x4000B61")]
	public static readonly DepotId_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B62")]
	public uint m_DepotId; //Field offset: 0x0

	[Address(RVA = "0x60A040", Offset = "0x609440", Length = "0x39")]
	[Token(Token = "0x6000BA5")]
	private static DepotId_t() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000B9B")]
	public DepotId_t(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000BA4")]
	public override int CompareTo(DepotId_t other) { }

	[Address(RVA = "0x609FA0", Offset = "0x6093A0", Length = "0x97")]
	[Token(Token = "0x6000B9D")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000BA3")]
	public override bool Equals(DepotId_t other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000B9E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000B9F")]
	public static bool op_Equality(DepotId_t x, DepotId_t y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000BA1")]
	public static DepotId_t op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000BA2")]
	public static uint op_Explicit(DepotId_t that) { }

	[Address(RVA = "0x60A080", Offset = "0x609480", Length = "0x4F")]
	[Token(Token = "0x6000BA0")]
	public static bool op_Inequality(DepotId_t x, DepotId_t y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000B9C")]
	public virtual string ToString() { }

}

