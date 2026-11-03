namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001DA")]
public class XblPreferredColor
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004FE")]
	private string <PrimaryColor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004FF")]
	private string <SecondaryColor>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000500")]
	private string <TertiaryColor>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170001AE")]
	public private string PrimaryColor
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009D3")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60009D4")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001AF")]
	public private string SecondaryColor
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009D5")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60009D6")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001B0")]
	public private string TertiaryColor
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009D7")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60009D8")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2B8A860", Offset = "0x2B89C60", Length = "0x71")]
	[Token(Token = "0x60009D2")]
	internal XblPreferredColor(XblPreferredColor interopPreferredColor) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009D3")]
	public string get_PrimaryColor() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009D5")]
	public string get_SecondaryColor() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009D7")]
	public string get_TertiaryColor() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60009D4")]
	private void set_PrimaryColor(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60009D6")]
	private void set_SecondaryColor(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60009D8")]
	private void set_TertiaryColor(string value) { }

}

