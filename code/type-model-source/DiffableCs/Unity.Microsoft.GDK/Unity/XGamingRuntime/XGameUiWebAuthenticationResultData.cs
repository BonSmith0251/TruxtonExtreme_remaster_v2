namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000234")]
public class XGameUiWebAuthenticationResultData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400061F")]
	internal XGameUiWebAuthenticationResultData data; //Field offset: 0x10

	[Obsolete("Please use ResponseCompletionUri instead, (UnityUpgradable) -> ResponseCompletionUri", True)]
	[Token(Token = "0x17000228")]
	public string responseCompletionUri
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000B6B")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000B6C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000225")]
	public string ResponseCompletionUri
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000B65")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000B66")]
		 set { } //Length: 13
	}

	[Obsolete("Please use ResponseCompletionUriSize instead, (UnityUpgradable) -> ResponseCompletionUriSize", True)]
	[Token(Token = "0x17000227")]
	public ulong responseCompletionUriSize
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000B69")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000B6A")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000224")]
	public ulong ResponseCompletionUriSize
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000B63")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000B64")]
		 set { } //Length: 5
	}

	[Obsolete("Please use ResponseStatus instead, (UnityUpgradable) -> ResponseStatus", True)]
	[Token(Token = "0x17000226")]
	public uint responseStatus
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B67")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000B68")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000223")]
	public uint ResponseStatus
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B61")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000B62")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B81720", Offset = "0x2B80B20", Length = "0x3D")]
	[Token(Token = "0x6000B5F")]
	internal XGameUiWebAuthenticationResultData(XGameUiWebAuthenticationResultData interop) { }

	[Address(RVA = "0x2B7C180", Offset = "0x2B7B580", Length = "0x23")]
	[Token(Token = "0x6000B60")]
	public XGameUiWebAuthenticationResultData() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000B6B")]
	public string get_responseCompletionUri() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000B65")]
	public string get_ResponseCompletionUri() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000B69")]
	public ulong get_responseCompletionUriSize() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000B63")]
	public ulong get_ResponseCompletionUriSize() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B67")]
	public uint get_responseStatus() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B61")]
	public uint get_ResponseStatus() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000B6C")]
	public void set_responseCompletionUri(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000B66")]
	public void set_ResponseCompletionUri(string value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000B6A")]
	public void set_responseCompletionUriSize(ulong value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000B64")]
	public void set_ResponseCompletionUriSize(ulong value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000B68")]
	public void set_responseStatus(uint value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000B62")]
	public void set_ResponseStatus(uint value) { }

}

