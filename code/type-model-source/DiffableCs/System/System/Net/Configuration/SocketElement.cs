namespace System.Net.Configuration;

[Token(Token = "0x200033B")]
public sealed class SocketElement : ConfigurationElement
{

	[Token(Token = "0x1700048B")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x25E31C0", Offset = "0x25E25C0", Length = "0x2C")]
		[Token(Token = "0x600150D")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25E3190", Offset = "0x25E2590", Length = "0x2C")]
	[Token(Token = "0x600150C")]
	public SocketElement() { }

	[Address(RVA = "0x25E31C0", Offset = "0x25E25C0", Length = "0x2C")]
	[Token(Token = "0x600150D")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

