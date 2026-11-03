namespace System.Net.Security;

[Token(Token = "0x2000319")]
public abstract class AuthenticatedStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E72")]
	private Stream _InnerStream; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E73")]
	private bool _LeaveStreamOpen; //Field offset: 0x30

	[Token(Token = "0x17000475")]
	protected Stream InnerStream
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60014C4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000476")]
	public abstract bool IsAuthenticated
	{
		[Token(Token = "0x60014C6")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x25DD190", Offset = "0x25DC590", Length = "0x1B1")]
	[Token(Token = "0x60014C3")]
	protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen) { }

	[Address(RVA = "0x25DD0C0", Offset = "0x25DC4C0", Length = "0xC9")]
	[Token(Token = "0x60014C5")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60014C4")]
	protected Stream get_InnerStream() { }

	[Token(Token = "0x60014C6")]
	public abstract bool get_IsAuthenticated() { }

}

