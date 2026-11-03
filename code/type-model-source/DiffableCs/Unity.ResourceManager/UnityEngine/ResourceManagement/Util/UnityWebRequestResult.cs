namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000044")]
public class UnityWebRequestResult
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AA")]
	private string <Error>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000AB")]
	private readonly long <ResponseCode>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000AC")]
	private readonly Result <Result>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000AD")]
	private readonly string <Method>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000AE")]
	private readonly string <Url>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x17000032")]
	public string Error
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000181")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000182")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000035")]
	public string Method
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000185")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000033")]
	public long ResponseCode
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000183")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000034")]
	public Result Result
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000184")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000036")]
	public string Url
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000186")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2E50EB0", Offset = "0x2E502B0", Length = "0x117")]
	[Token(Token = "0x600017F")]
	public UnityWebRequestResult(UnityWebRequest request) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000181")]
	public string get_Error() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000185")]
	public string get_Method() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000183")]
	public long get_ResponseCode() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000184")]
	public Result get_Result() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000186")]
	public string get_Url() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000182")]
	public void set_Error(string value) { }

	[Address(RVA = "0x2E50A90", Offset = "0x2E4FE90", Length = "0x2C6")]
	[Token(Token = "0x6000187")]
	public bool ShouldRetryDownloadError() { }

	[Address(RVA = "0x2E50D60", Offset = "0x2E50160", Length = "0x143")]
	[Token(Token = "0x6000180")]
	public virtual string ToString() { }

}

