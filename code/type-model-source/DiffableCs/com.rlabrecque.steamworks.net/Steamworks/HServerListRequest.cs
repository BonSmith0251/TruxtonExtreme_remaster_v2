namespace Steamworks;

[Token(Token = "0x20001D3")]
public struct HServerListRequest : IEquatable<HServerListRequest>
{
	[Token(Token = "0x4000B04")]
	public static readonly HServerListRequest Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B05")]
	public IntPtr m_HServerListRequest; //Field offset: 0x0

	[Address(RVA = "0x60B410", Offset = "0x60A810", Length = "0x3A")]
	[Token(Token = "0x6000ABC")]
	private static HServerListRequest() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000AB3")]
	public HServerListRequest(IntPtr value) { }

	[Address(RVA = "0x60B360", Offset = "0x60A760", Length = "0x99")]
	[Token(Token = "0x6000AB5")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000ABB")]
	public override bool Equals(HServerListRequest other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000AB6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000AB7")]
	public static bool op_Equality(HServerListRequest x, HServerListRequest y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000AB9")]
	public static HServerListRequest op_Explicit(IntPtr value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000ABA")]
	public static IntPtr op_Explicit(HServerListRequest that) { }

	[Address(RVA = "0x60B450", Offset = "0x60A850", Length = "0x52")]
	[Token(Token = "0x6000AB8")]
	public static bool op_Inequality(HServerListRequest x, HServerListRequest y) { }

	[Address(RVA = "0x60B400", Offset = "0x60A800", Length = "0x7")]
	[Token(Token = "0x6000AB4")]
	public virtual string ToString() { }

}

