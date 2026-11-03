namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200016F")]
public class XblMultiplayerInviteHandle
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002CE")]
	private readonly string <Data>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000D3")]
	public string Data
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600081C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B861F0", Offset = "0x2B855F0", Length = "0x3C")]
	[Token(Token = "0x600081B")]
	internal XblMultiplayerInviteHandle(XblMultiplayerInviteHandle interopStruct) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600081C")]
	public string get_Data() { }

}

