namespace Mono.Net.Security;

[Token(Token = "0x200004E")]
internal class AsyncHandshakeRequest : AsyncProtocolRequest
{

	[Address(RVA = "0x22BA570", Offset = "0x22B9970", Length = "0x8")]
	[Token(Token = "0x60000CA")]
	public AsyncHandshakeRequest(MobileAuthenticatedStream parent, bool sync) { }

	[Address(RVA = "0x22BA540", Offset = "0x22B9940", Length = "0x21")]
	[Token(Token = "0x60000CB")]
	protected virtual AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

