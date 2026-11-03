namespace Mono.Net.Security;

[Token(Token = "0x2000050")]
internal class AsyncReadRequest : AsyncReadOrWriteRequest
{

	[Address(RVA = "0x22BAC70", Offset = "0x22BA070", Length = "0xE")]
	[Token(Token = "0x60000D1")]
	public AsyncReadRequest(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x22BABF0", Offset = "0x22B9FF0", Length = "0x7F")]
	[Token(Token = "0x60000D2")]
	protected virtual AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

