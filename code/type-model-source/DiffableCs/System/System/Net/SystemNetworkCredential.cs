namespace System.Net;

[Token(Token = "0x2000240")]
internal class SystemNetworkCredential : NetworkCredential
{
	[Token(Token = "0x40008D6")]
	internal static readonly SystemNetworkCredential defaultCredential; //Field offset: 0x0

	[Address(RVA = "0x26ACE80", Offset = "0x26AC280", Length = "0x107")]
	[Token(Token = "0x6000F5E")]
	private static SystemNetworkCredential() { }

	[Address(RVA = "0x26AB590", Offset = "0x26AA990", Length = "0xB5")]
	[Token(Token = "0x6000F5D")]
	private SystemNetworkCredential() { }

}

