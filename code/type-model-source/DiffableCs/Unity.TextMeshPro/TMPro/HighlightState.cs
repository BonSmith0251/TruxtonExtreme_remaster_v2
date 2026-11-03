namespace TMPro;

[Token(Token = "0x200002F")]
public struct HighlightState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000140")]
	public Color32 color; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000141")]
	public TMP_Offset padding; //Field offset: 0x4

	[Address(RVA = "0xAEE2E0", Offset = "0xAED6E0", Length = "0xB")]
	[Token(Token = "0x6000170")]
	public HighlightState(Color32 color, TMP_Offset padding) { }

	[Address(RVA = "0x2EAEDF0", Offset = "0x2EAE1F0", Length = "0x65")]
	[Token(Token = "0x6000174")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2EAEE60", Offset = "0x2EAE260", Length = "0x88")]
	[Token(Token = "0x6000175")]
	public bool Equals(HighlightState other) { }

	[Address(RVA = "0x2EAEEF0", Offset = "0x2EAE2F0", Length = "0x55")]
	[Token(Token = "0x6000173")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2EAEF50", Offset = "0x2EAE350", Length = "0x13B")]
	[Token(Token = "0x6000171")]
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	[Address(RVA = "0x2EAF090", Offset = "0x2EAE490", Length = "0x141")]
	[Token(Token = "0x6000172")]
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

}

