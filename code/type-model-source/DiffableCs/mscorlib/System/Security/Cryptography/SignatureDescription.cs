namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200031D")]
public class SignatureDescription
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D3B")]
	private string _strKey; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D3C")]
	private string _strDigest; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D3D")]
	private string _strFormatter; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D3E")]
	private string _strDeformatter; //Field offset: 0x28

	[Token(Token = "0x1700028B")]
	public string DeformatterAlgorithm
	{
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6001956")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000289")]
	public string DigestAlgorithm
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6001954")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700028A")]
	public string FormatterAlgorithm
	{
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6001955")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000288")]
	public string KeyAlgorithm
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6001953")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001952")]
	public SignatureDescription() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6001956")]
	public void set_DeformatterAlgorithm(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6001954")]
	public void set_DigestAlgorithm(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6001955")]
	public void set_FormatterAlgorithm(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6001953")]
	public void set_KeyAlgorithm(string value) { }

}

