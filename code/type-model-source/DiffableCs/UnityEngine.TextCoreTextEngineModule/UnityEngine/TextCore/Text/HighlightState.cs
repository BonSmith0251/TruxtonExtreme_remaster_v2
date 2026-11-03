namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000057")]
internal struct HighlightState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000337")]
	public Color32 color; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000338")]
	public Offset padding; //Field offset: 0x4

	[Address(RVA = "0xAEE2E0", Offset = "0xAED6E0", Length = "0xB")]
	[Token(Token = "0x6000249")]
	public HighlightState(Color32 color, Offset padding) { }

	[Address(RVA = "0x31AFEC0", Offset = "0x31AF2C0", Length = "0x65")]
	[Token(Token = "0x600024D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x31AFF30", Offset = "0x31AF330", Length = "0x55")]
	[Token(Token = "0x600024C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x31AFF90", Offset = "0x31AF390", Length = "0x139")]
	[Token(Token = "0x600024A")]
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	[Address(RVA = "0x31B00D0", Offset = "0x31AF4D0", Length = "0x13C")]
	[Token(Token = "0x600024B")]
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

}

