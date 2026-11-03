namespace System.Net;

[Token(Token = "0x2000294")]
internal class ContentDecodeStream : WebReadStream
{
	[Token(Token = "0x2000295")]
	public enum Mode : int
	{
		GZip = 0,
		Deflate = 1,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A7A")]
	private readonly Stream <OriginalInnerStream>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x1700039E")]
	private Stream OriginalInnerStream
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600113E")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x26B3CE0", Offset = "0x26B30E0", Length = "0x32")]
	[Token(Token = "0x600113F")]
	private ContentDecodeStream(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	[Address(RVA = "0x26B3FC0", Offset = "0x26B33C0", Length = "0xDF")]
	[Token(Token = "0x600113D")]
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode) { }

	[Address(RVA = "0x26B40A0", Offset = "0x26B34A0", Length = "0xEE")]
	[Token(Token = "0x6001141")]
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600113E")]
	private Stream get_OriginalInnerStream() { }

	[Address(RVA = "0x26ABA60", Offset = "0x26AAE60", Length = "0x2F")]
	[Token(Token = "0x6001140")]
	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

