namespace System.Net.NetworkInformation;

[Token(Token = "0x20002DE")]
public abstract class IPGlobalProperties
{

	[Token(Token = "0x17000436")]
	public abstract string DomainName
	{
		[Token(Token = "0x600135C")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600135D")]
	protected IPGlobalProperties() { }

	[Token(Token = "0x600135C")]
	public abstract string get_DomainName() { }

	[Address(RVA = "0x25DE860", Offset = "0x25DDC60", Length = "0x81")]
	[Token(Token = "0x600135A")]
	public static IPGlobalProperties GetIPGlobalProperties() { }

	[Address(RVA = "0x25DE860", Offset = "0x25DDC60", Length = "0x81")]
	[Token(Token = "0x600135B")]
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

}

