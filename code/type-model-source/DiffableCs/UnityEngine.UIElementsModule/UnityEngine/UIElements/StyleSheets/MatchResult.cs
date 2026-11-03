namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000642")]
internal struct MatchResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400177E")]
	public MatchResultErrorCode errorCode; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400177F")]
	public string errorValue; //Field offset: 0x8

	[Token(Token = "0x17000B54")]
	public bool success
	{
		[Address(RVA = "0x3362BC0", Offset = "0x3361FC0", Length = "0x9")]
		[Token(Token = "0x6002C70")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x3362BC0", Offset = "0x3361FC0", Length = "0x9")]
	[Token(Token = "0x6002C70")]
	public bool get_success() { }

}

