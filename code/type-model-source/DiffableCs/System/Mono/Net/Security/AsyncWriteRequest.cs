namespace Mono.Net.Security;

[Token(Token = "0x2000051")]
internal class AsyncWriteRequest : AsyncReadOrWriteRequest
{

	[Address(RVA = "0x22BAC70", Offset = "0x22BA070", Length = "0xE")]
	[Token(Token = "0x60000D3")]
	public AsyncWriteRequest(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x22BAC80", Offset = "0x22BA080", Length = "0x9C")]
	[Token(Token = "0x60000D4")]
	protected virtual AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

