namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000175")]
public class XblMultiplayerSessionHandleId
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002E4")]
	private readonly string <Value>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000DE")]
	public string Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000830")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B88D60", Offset = "0x2B88160", Length = "0x36")]
	[Token(Token = "0x600082F")]
	internal XblMultiplayerSessionHandleId(XblMultiplayerSessionHandleId interopHandle) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000830")]
	public string get_Value() { }

}

