namespace System.Net;

[Token(Token = "0x20002AA")]
internal class MonoChunkParser
{
	[Token(Token = "0x20002AC")]
	private class Chunk
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B24")]
		public Byte[] Bytes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B25")]
		public int Offset; //Field offset: 0x18

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6001202")]
		public Chunk(Byte[] chunk) { }

		[Address(RVA = "0x25C6620", Offset = "0x25C5A20", Length = "0x62")]
		[Token(Token = "0x6001203")]
		public int Read(Byte[] buffer, int offset, int size) { }

	}

	[Token(Token = "0x20002AB")]
	private enum State : int
	{
		None = 0,
		PartialSize = 1,
		Body = 2,
		BodyFinished = 3,
		Trailer = 4,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B14")]
	private WebHeaderCollection headers; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B15")]
	private int chunkSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000B16")]
	private int chunkRead; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B17")]
	private int totalWritten; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000B18")]
	private State state; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B19")]
	private StringBuilder saved; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B1A")]
	private bool sawCR; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000B1B")]
	private bool gotit; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000B1C")]
	private int trailerState; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B1D")]
	private ArrayList chunks; //Field offset: 0x38

	[Token(Token = "0x170003DE")]
	public int ChunkLeft
	{
		[Address(RVA = "0x25C8BF0", Offset = "0x25C7FF0", Length = "0x7")]
		[Token(Token = "0x60011FB")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170003DD")]
	public bool DataAvailable
	{
		[Address(RVA = "0x25C8C00", Offset = "0x25C8000", Length = "0x10D")]
		[Token(Token = "0x60011FA")]
		 get { } //Length: 269
	}

	[Token(Token = "0x170003DC")]
	public bool WantMore
	{
		[Address(RVA = "0x25C8D10", Offset = "0x25C8110", Length = "0x17")]
		[Token(Token = "0x60011F9")]
		 get { } //Length: 23
	}

	[Address(RVA = "0x25C8B30", Offset = "0x25C7F30", Length = "0xBD")]
	[Token(Token = "0x60011F4")]
	public MonoChunkParser(WebHeaderCollection headers) { }

	[Address(RVA = "0x25C8BF0", Offset = "0x25C7FF0", Length = "0x7")]
	[Token(Token = "0x60011FB")]
	public int get_ChunkLeft() { }

	[Address(RVA = "0x25C8C00", Offset = "0x25C8000", Length = "0x10D")]
	[Token(Token = "0x60011FA")]
	public bool get_DataAvailable() { }

	[Address(RVA = "0x25C8D10", Offset = "0x25C8110", Length = "0x17")]
	[Token(Token = "0x60011F9")]
	public bool get_WantMore() { }

	[Address(RVA = "0x25C7D10", Offset = "0x25C7110", Length = "0x2E1")]
	[Token(Token = "0x60011FD")]
	private State GetChunkSize(Byte[] buffer, ref int offset, int size) { }

	[Address(RVA = "0x25C8000", Offset = "0x25C7400", Length = "0x2C0")]
	[Token(Token = "0x60011F8")]
	private void InternalWrite(Byte[] buffer, ref int offset, int size) { }

	[Address(RVA = "0x25C8A40", Offset = "0x25C7E40", Length = "0xE")]
	[Token(Token = "0x60011F5")]
	public int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x25C82D0", Offset = "0x25C76D0", Length = "0x13A")]
	[Token(Token = "0x60011FC")]
	private State ReadBody(Byte[] buffer, ref int offset, int size) { }

	[Address(RVA = "0x25C8410", Offset = "0x25C7810", Length = "0xD5")]
	[Token(Token = "0x60011FF")]
	private State ReadCRLF(Byte[] buffer, ref int offset, int size) { }

	[Address(RVA = "0x25C84F0", Offset = "0x25C78F0", Length = "0x2E5")]
	[Token(Token = "0x60011F6")]
	private int ReadFromChunks(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x25C87E0", Offset = "0x25C7BE0", Length = "0x25E")]
	[Token(Token = "0x6001200")]
	private State ReadTrailer(Byte[] buffer, ref int offset, int size) { }

	[Address(RVA = "0x25C8A50", Offset = "0x25C7E50", Length = "0x43")]
	[Token(Token = "0x60011FE")]
	private static string RemoveChunkExtension(string input) { }

	[Address(RVA = "0x25C8AA0", Offset = "0x25C7EA0", Length = "0x5B")]
	[Token(Token = "0x6001201")]
	private static void ThrowProtocolViolation(string message) { }

	[Address(RVA = "0x25C8B00", Offset = "0x25C7F00", Length = "0x26")]
	[Token(Token = "0x60011F7")]
	public void Write(Byte[] buffer, int offset, int size) { }

}

