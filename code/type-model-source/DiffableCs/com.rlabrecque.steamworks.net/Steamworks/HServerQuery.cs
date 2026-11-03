namespace Steamworks;

[Token(Token = "0x20001D4")]
public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
{
	[Token(Token = "0x4000B06")]
	public static readonly HServerQuery Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B07")]
	public int m_HServerQuery; //Field offset: 0x0

	[Address(RVA = "0x60B570", Offset = "0x60A970", Length = "0x39")]
	[Token(Token = "0x6000AC7")]
	private static HServerQuery() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000ABD")]
	public HServerQuery(int value) { }

	[Address(RVA = "0x60B4B0", Offset = "0x60A8B0", Length = "0x8")]
	[Token(Token = "0x6000AC6")]
	public override int CompareTo(HServerQuery other) { }

	[Address(RVA = "0x60B4C0", Offset = "0x60A8C0", Length = "0x97")]
	[Token(Token = "0x6000ABF")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000AC5")]
	public override bool Equals(HServerQuery other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000AC0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000AC1")]
	public static bool op_Equality(HServerQuery x, HServerQuery y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000AC3")]
	public static HServerQuery op_Explicit(int value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000AC4")]
	public static int op_Explicit(HServerQuery that) { }

	[Address(RVA = "0x60B5B0", Offset = "0x60A9B0", Length = "0x4F")]
	[Token(Token = "0x6000AC2")]
	public static bool op_Inequality(HServerQuery x, HServerQuery y) { }

	[Address(RVA = "0x60B560", Offset = "0x60A960", Length = "0x7")]
	[Token(Token = "0x6000ABE")]
	public virtual string ToString() { }

}

