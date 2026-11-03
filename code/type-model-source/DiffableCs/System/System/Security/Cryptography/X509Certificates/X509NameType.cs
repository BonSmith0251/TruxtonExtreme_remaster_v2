namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000124")]
public enum X509NameType : int
{
	SimpleName = 0,
	EmailName = 1,
	UpnName = 2,
	DnsName = 3,
	DnsFromAlternativeName = 4,
	UrlName = 5,
}

