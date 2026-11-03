namespace Mono;

[Token(Token = "0x2000004")]
internal static class X509Pal
{

	[Token(Token = "0x17000006")]
	public static X509PalImpl Instance
	{
		[Address(RVA = "0x22D3560", Offset = "0x22D2960", Length = "0xDE")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 222
	}

	[Address(RVA = "0x22D3560", Offset = "0x22D2960", Length = "0xDE")]
	[Token(Token = "0x6000012")]
	public static X509PalImpl get_Instance() { }

}

