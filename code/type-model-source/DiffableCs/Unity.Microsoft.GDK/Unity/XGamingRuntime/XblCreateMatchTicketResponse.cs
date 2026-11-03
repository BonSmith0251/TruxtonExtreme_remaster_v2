namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200016C")]
public class XblCreateMatchTicketResponse
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002BB")]
	private readonly string <MatchTicketId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002BC")]
	private readonly long <EstimatedWaitTime>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000C8")]
	public long EstimatedWaitTime
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600080F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C7")]
	public string MatchTicketId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600080E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B861A0", Offset = "0x2B855A0", Length = "0x44")]
	[Token(Token = "0x600080D")]
	internal XblCreateMatchTicketResponse(XblCreateMatchTicketResponse interopHandle) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600080F")]
	public long get_EstimatedWaitTime() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600080E")]
	public string get_MatchTicketId() { }

}

