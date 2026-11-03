namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000172")]
public class XblMultiplayerSessionChangeEventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002D4")]
	private readonly XblMultiplayerSessionReference <SessionReference>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002D5")]
	private readonly string <Branch>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002D6")]
	private readonly ulong <ChangeNumber>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170000DB")]
	public string Branch
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000829")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000DC")]
	public ulong ChangeNumber
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600082A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000DA")]
	public XblMultiplayerSessionReference SessionReference
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000828")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B87DE0", Offset = "0x2B871E0", Length = "0x259")]
	[Token(Token = "0x6000827")]
	internal XblMultiplayerSessionChangeEventArgs(XblMultiplayerSessionChangeEventArgs interopStruct) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000829")]
	public string get_Branch() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600082A")]
	public ulong get_ChangeNumber() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000828")]
	public XblMultiplayerSessionReference get_SessionReference() { }

}

