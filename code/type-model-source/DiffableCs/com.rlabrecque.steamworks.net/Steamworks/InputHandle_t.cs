namespace Steamworks;

[Token(Token = "0x20001C9")]
public struct InputHandle_t : IEquatable<InputHandle_t>, IComparable<InputHandle_t>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AF3")]
	public ulong m_InputHandle; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000A7A")]
	public InputHandle_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000A83")]
	public override int CompareTo(InputHandle_t other) { }

	[Address(RVA = "0x60D480", Offset = "0x60C880", Length = "0x81")]
	[Token(Token = "0x6000A7C")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000A82")]
	public override bool Equals(InputHandle_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000A7D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000A7E")]
	public static bool op_Equality(InputHandle_t x, InputHandle_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A80")]
	public static InputHandle_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A81")]
	public static ulong op_Explicit(InputHandle_t that) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x6000A7F")]
	public static bool op_Inequality(InputHandle_t x, InputHandle_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000A7B")]
	public virtual string ToString() { }

}

