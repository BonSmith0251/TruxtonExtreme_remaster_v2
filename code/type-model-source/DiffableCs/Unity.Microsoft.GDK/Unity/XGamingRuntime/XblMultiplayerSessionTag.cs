namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000183")]
public class XblMultiplayerSessionTag
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000340")]
	private readonly string <Value>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700012A")]
	public string Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600089F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x600089D")]
	public XblMultiplayerSessionTag(string value) { }

	[Address(RVA = "0x2B8A6A0", Offset = "0x2B89AA0", Length = "0x3C")]
	[Token(Token = "0x600089E")]
	internal XblMultiplayerSessionTag(XblMultiplayerSessionTag interopStruct) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600089F")]
	public string get_Value() { }

}

