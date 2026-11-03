namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200029E")]
public class XUserGetTokenAndSignatureUtf16Data
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000723")]
	internal XUserGetTokenAndSignatureUtf16Data interop; //Field offset: 0x10

	[Token(Token = "0x170002F9")]
	public string Signature
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000D9F")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000DA0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002F7")]
	public ulong SignatureSize
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000D9B")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000D9C")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170002F8")]
	public string Token
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000D9D")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000D9E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002F6")]
	public ulong TokenSize
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D99")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000D9A")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x2B84D20", Offset = "0x2B84120", Length = "0x3B")]
	[Token(Token = "0x6000D97")]
	internal XUserGetTokenAndSignatureUtf16Data(XUserGetTokenAndSignatureUtf16Data interop) { }

	[Address(RVA = "0x2B82130", Offset = "0x2B81530", Length = "0x21")]
	[Token(Token = "0x6000D98")]
	public XUserGetTokenAndSignatureUtf16Data() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000D9F")]
	public string get_Signature() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000D9B")]
	public ulong get_SignatureSize() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000D9D")]
	public string get_Token() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D99")]
	public ulong get_TokenSize() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000DA0")]
	public void set_Signature(string value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000D9C")]
	public void set_SignatureSize(ulong value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000D9E")]
	public void set_Token(string value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000D9A")]
	public void set_TokenSize(ulong value) { }

}

