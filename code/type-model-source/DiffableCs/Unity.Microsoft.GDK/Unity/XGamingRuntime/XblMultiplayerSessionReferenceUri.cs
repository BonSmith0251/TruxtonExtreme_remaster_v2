namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001A2")]
public class XblMultiplayerSessionReferenceUri
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000405")]
	private readonly string <Value>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700017A")]
	public string Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000913")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B8A590", Offset = "0x2B89990", Length = "0x3C")]
	[Token(Token = "0x6000912")]
	internal XblMultiplayerSessionReferenceUri(XblMultiplayerSessionReferenceUri interopStruct) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000913")]
	public string get_Value() { }

}

