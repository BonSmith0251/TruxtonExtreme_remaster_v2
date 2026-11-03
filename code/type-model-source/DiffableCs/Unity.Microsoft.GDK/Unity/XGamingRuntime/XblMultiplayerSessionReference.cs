namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001A1")]
public class XblMultiplayerSessionReference
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000402")]
	private readonly string <Scid>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000403")]
	private readonly string <SessionTemplateName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000404")]
	private readonly string <SessionName>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000177")]
	public string Scid
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600090F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000179")]
	public string SessionName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000911")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000178")]
	public string SessionTemplateName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000910")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B8A5D0", Offset = "0x2B899D0", Length = "0x70")]
	[Token(Token = "0x600090E")]
	internal XblMultiplayerSessionReference(XblMultiplayerSessionReference interopStruct) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600090F")]
	public string get_Scid() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000911")]
	public string get_SessionName() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000910")]
	public string get_SessionTemplateName() { }

}

