namespace Mono.Net.Security;

[Token(Token = "0x2000049")]
internal class AsyncProtocolResult
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A4")]
	private readonly int <UserResult>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A5")]
	private readonly ExceptionDispatchInfo <Error>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700001B")]
	public ExceptionDispatchInfo Error
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000B4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001A")]
	public int UserResult
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60000B3")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x60000B5")]
	public AsyncProtocolResult(int result) { }

	[Address(RVA = "0x1F079E0", Offset = "0x1F06DE0", Length = "0x31")]
	[Token(Token = "0x60000B6")]
	public AsyncProtocolResult(ExceptionDispatchInfo error) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000B4")]
	public ExceptionDispatchInfo get_Error() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60000B3")]
	public int get_UserResult() { }

}

