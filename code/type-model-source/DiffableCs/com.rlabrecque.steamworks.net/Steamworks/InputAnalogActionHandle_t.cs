namespace Steamworks;

[Token(Token = "0x20001C7")]
public struct InputAnalogActionHandle_t : IEquatable<InputAnalogActionHandle_t>, IComparable<InputAnalogActionHandle_t>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AF1")]
	public ulong m_InputAnalogActionHandle; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000A66")]
	public InputAnalogActionHandle_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000A6F")]
	public override int CompareTo(InputAnalogActionHandle_t other) { }

	[Address(RVA = "0x60D360", Offset = "0x60C760", Length = "0x81")]
	[Token(Token = "0x6000A68")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000A6E")]
	public override bool Equals(InputAnalogActionHandle_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000A69")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000A6A")]
	public static bool op_Equality(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A6C")]
	public static InputAnalogActionHandle_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A6D")]
	public static ulong op_Explicit(InputAnalogActionHandle_t that) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x6000A6B")]
	public static bool op_Inequality(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000A67")]
	public virtual string ToString() { }

}

