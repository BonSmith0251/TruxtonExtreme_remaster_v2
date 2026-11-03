namespace System.Net.NetworkInformation;

[Token(Token = "0x20002E2")]
internal class Win32IPGlobalProperties : IPGlobalProperties
{

	[Token(Token = "0x17000437")]
	public virtual string DomainName
	{
		[Address(RVA = "0x25F8680", Offset = "0x25F7A80", Length = "0x1F")]
		[Token(Token = "0x600135F")]
		 get { } //Length: 31
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001360")]
	public Win32IPGlobalProperties() { }

	[Address(RVA = "0x25F8680", Offset = "0x25F7A80", Length = "0x1F")]
	[Token(Token = "0x600135F")]
	public virtual string get_DomainName() { }

}

