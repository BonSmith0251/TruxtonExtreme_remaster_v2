namespace Unity.XGamingRuntime;

[Token(Token = "0x200029C")]
public class XUserGetTokenAndSignatureData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000721")]
	internal XUserGetTokenAndSignatureData interop; //Field offset: 0x10

	[Token(Token = "0x170002F3")]
	public string Signature
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000D8F")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000D90")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002F1")]
	public ulong SignatureSize
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000D8B")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000D8C")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170002F2")]
	public string Token
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000D8D")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000D8E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002F0")]
	public ulong TokenSize
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D89")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000D8A")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x2B84D20", Offset = "0x2B84120", Length = "0x3B")]
	[Token(Token = "0x6000D87")]
	internal XUserGetTokenAndSignatureData(XUserGetTokenAndSignatureData interop) { }

	[Address(RVA = "0x2B82130", Offset = "0x2B81530", Length = "0x21")]
	[Token(Token = "0x6000D88")]
	public XUserGetTokenAndSignatureData() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000D8F")]
	public string get_Signature() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000D8B")]
	public ulong get_SignatureSize() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000D8D")]
	public string get_Token() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D89")]
	public ulong get_TokenSize() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000D90")]
	public void set_Signature(string value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000D8C")]
	public void set_SignatureSize(ulong value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000D8E")]
	public void set_Token(string value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000D8A")]
	public void set_TokenSize(ulong value) { }

}

