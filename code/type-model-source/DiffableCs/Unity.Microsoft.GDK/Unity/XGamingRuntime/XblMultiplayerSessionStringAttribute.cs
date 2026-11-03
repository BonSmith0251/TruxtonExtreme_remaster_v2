namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000182")]
public class XblMultiplayerSessionStringAttribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400033E")]
	private readonly string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400033F")]
	private readonly string <Value>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000128")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600089B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000129")]
	public string Value
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600089C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000899")]
	public XblMultiplayerSessionStringAttribute(string name, string value) { }

	[Address(RVA = "0x2B8A640", Offset = "0x2B89A40", Length = "0x56")]
	[Token(Token = "0x600089A")]
	internal XblMultiplayerSessionStringAttribute(XblMultiplayerSessionStringAttribute interopStruct) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600089B")]
	public string get_Name() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600089C")]
	public string get_Value() { }

}

