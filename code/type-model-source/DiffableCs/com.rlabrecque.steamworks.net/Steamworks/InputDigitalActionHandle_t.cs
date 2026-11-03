namespace Steamworks;

[Token(Token = "0x20001C8")]
public struct InputDigitalActionHandle_t : IEquatable<InputDigitalActionHandle_t>, IComparable<InputDigitalActionHandle_t>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AF2")]
	public ulong m_InputDigitalActionHandle; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000A70")]
	public InputDigitalActionHandle_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000A79")]
	public override int CompareTo(InputDigitalActionHandle_t other) { }

	[Address(RVA = "0x60D3F0", Offset = "0x60C7F0", Length = "0x81")]
	[Token(Token = "0x6000A72")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000A78")]
	public override bool Equals(InputDigitalActionHandle_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000A73")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000A74")]
	public static bool op_Equality(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A76")]
	public static InputDigitalActionHandle_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A77")]
	public static ulong op_Explicit(InputDigitalActionHandle_t that) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x6000A75")]
	public static bool op_Inequality(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000A71")]
	public virtual string ToString() { }

}

