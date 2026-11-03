namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200013C")]
public struct X509ChainStatus
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005B9")]
	private X509ChainStatusFlags status; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005BA")]
	private string info; //Field offset: 0x8

	[Token(Token = "0x1700016F")]
	public X509ChainStatusFlags Status
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60007D0")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60007D1")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000170")]
	public string StatusInformation
	{
		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[Token(Token = "0x60007D2")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2657410", Offset = "0x2656810", Length = "0x2B")]
	[Token(Token = "0x60007CF")]
	internal X509ChainStatus(X509ChainStatusFlags flag) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60007D0")]
	public X509ChainStatusFlags get_Status() { }

	[Address(RVA = "0x2657290", Offset = "0x2656690", Length = "0x150")]
	[Token(Token = "0x60007D3")]
	internal static string GetInformation(X509ChainStatusFlags flags) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x60007D1")]
	public void set_Status(X509ChainStatusFlags value) { }

	[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
	[Token(Token = "0x60007D2")]
	public void set_StatusInformation(string value) { }

}

