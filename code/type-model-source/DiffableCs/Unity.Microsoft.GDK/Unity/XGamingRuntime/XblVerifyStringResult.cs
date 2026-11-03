namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001EB")]
public class XblVerifyStringResult
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000546")]
	private XblVerifyStringResultCode <ResultCode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000547")]
	private string <FirstOffendingSubstring>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170001D3")]
	public private string FirstOffendingSubstring
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A36")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A37")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001D2")]
	public private XblVerifyStringResultCode ResultCode
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000A34")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A35")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2B8CEB0", Offset = "0x2B8C2B0", Length = "0x55")]
	[Token(Token = "0x6000A33")]
	internal XblVerifyStringResult(XblVerifyStringResult interopStruct) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A36")]
	public string get_FirstOffendingSubstring() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000A34")]
	public XblVerifyStringResultCode get_ResultCode() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A37")]
	private void set_FirstOffendingSubstring(string value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A35")]
	private void set_ResultCode(XblVerifyStringResultCode value) { }

}

