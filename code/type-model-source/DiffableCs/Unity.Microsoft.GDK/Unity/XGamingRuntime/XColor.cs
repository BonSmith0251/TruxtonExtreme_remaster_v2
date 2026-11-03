namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20000F0")]
public class XColor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001B3")]
	internal XColor _interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001B4")]
	internal ARGB _argb; //Field offset: 0x18

	[Token(Token = "0x17000010")]
	public ARGB Argb
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000581")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000582")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000F")]
	internal XColor interop
	{
		[Address(RVA = "0x2B7CC70", Offset = "0x2B7C070", Length = "0x1D")]
		[Token(Token = "0x6000580")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x17000011")]
	public uint Value
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000583")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000584")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B7CBF0", Offset = "0x2B7BFF0", Length = "0x79")]
	[Token(Token = "0x600057E")]
	internal XColor(XColor interop) { }

	[Address(RVA = "0x2B6DFE0", Offset = "0x2B6D3E0", Length = "0x1B")]
	[Token(Token = "0x600057F")]
	public XColor() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000581")]
	public ARGB get_Argb() { }

	[Address(RVA = "0x2B7CC70", Offset = "0x2B7C070", Length = "0x1D")]
	[Token(Token = "0x6000580")]
	internal XColor get_interop() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000583")]
	public uint get_Value() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000582")]
	public void set_Argb(ARGB value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000584")]
	public void set_Value(uint value) { }

}

