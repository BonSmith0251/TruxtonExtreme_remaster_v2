namespace Steamworks;

[Token(Token = "0x20001C6")]
public struct InputActionSetHandle_t : IEquatable<InputActionSetHandle_t>, IComparable<InputActionSetHandle_t>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AF0")]
	public ulong m_InputActionSetHandle; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000A5C")]
	public InputActionSetHandle_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000A65")]
	public override int CompareTo(InputActionSetHandle_t other) { }

	[Address(RVA = "0x60D2D0", Offset = "0x60C6D0", Length = "0x81")]
	[Token(Token = "0x6000A5E")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000A64")]
	public override bool Equals(InputActionSetHandle_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000A5F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000A60")]
	public static bool op_Equality(InputActionSetHandle_t x, InputActionSetHandle_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A62")]
	public static InputActionSetHandle_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A63")]
	public static ulong op_Explicit(InputActionSetHandle_t that) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x6000A61")]
	public static bool op_Inequality(InputActionSetHandle_t x, InputActionSetHandle_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000A5D")]
	public virtual string ToString() { }

}

