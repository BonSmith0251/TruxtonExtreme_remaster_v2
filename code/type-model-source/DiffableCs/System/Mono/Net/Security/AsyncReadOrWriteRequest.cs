namespace Mono.Net.Security;

[Token(Token = "0x200004F")]
internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000C2")]
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000C3")]
	private int <CurrentSize>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x17000021")]
	protected int CurrentSize
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000CD")]
		 get { } //Length: 4
		[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000CE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000020")]
	protected BufferOffsetSize UserBuffer
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000CC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x22BAB50", Offset = "0x22B9F50", Length = "0xA0")]
	[Token(Token = "0x60000CF")]
	public AsyncReadOrWriteRequest(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000CD")]
	protected int get_CurrentSize() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000CC")]
	protected BufferOffsetSize get_UserBuffer() { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000CE")]
	protected void set_CurrentSize(int value) { }

	[Address(RVA = "0x22BAAE0", Offset = "0x22B9EE0", Length = "0x6B")]
	[Token(Token = "0x60000D0")]
	public virtual string ToString() { }

}

