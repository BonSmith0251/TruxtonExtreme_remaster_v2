namespace System.Net;

[Token(Token = "0x2000245")]
public interface ICertificatePolicy
{

	[Token(Token = "0x6000F66")]
	public bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem) { }

}

