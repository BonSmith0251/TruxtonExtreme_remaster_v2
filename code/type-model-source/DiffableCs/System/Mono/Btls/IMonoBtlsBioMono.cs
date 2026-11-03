namespace Mono.Btls;

[Token(Token = "0x200006E")]
internal interface IMonoBtlsBioMono
{

	[Token(Token = "0x600018E")]
	public void Close() { }

	[Token(Token = "0x600018D")]
	public void Flush() { }

	[Token(Token = "0x600018B")]
	public int Read(Byte[] buffer, int offset, int size, out bool wantMore) { }

	[Token(Token = "0x600018C")]
	public bool Write(Byte[] buffer, int offset, int size) { }

}

