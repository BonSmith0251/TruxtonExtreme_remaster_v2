namespace Mono;

[Token(Token = "0x200002E")]
internal interface ISystemDependencyProvider
{

	[Token(Token = "0x17000004")]
	public ISystemCertificateProvider CertificateProvider
	{
		[Token(Token = "0x6000047")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000047")]
	public ISystemCertificateProvider get_CertificateProvider() { }

}

