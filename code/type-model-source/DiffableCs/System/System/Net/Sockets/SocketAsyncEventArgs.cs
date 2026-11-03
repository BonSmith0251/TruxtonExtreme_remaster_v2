namespace System.Net.Sockets;

[Token(Token = "0x2000314")]
public class SocketAsyncEventArgs : EventArgs, IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E33")]
	private bool disposed; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000E34")]
	internal int in_progress; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E35")]
	private EndPoint remote_ep; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E36")]
	private Socket current_socket; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E37")]
	internal SocketAsyncResult socket_async_result; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E38")]
	private Exception <ConnectByNameError>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E39")]
	private Socket <AcceptSocket>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E3A")]
	private int <BytesTransferred>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000E3B")]
	private bool <DisconnectReuseSocket>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E3C")]
	private SocketAsyncOperation <LastOperation>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E3D")]
	private IPPacketInformation <ReceiveMessageFromPacketInfo>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E3E")]
	private SendPacketsElement[] <SendPacketsElements>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000E3F")]
	private TransmitFileOptions <SendPacketsFlags>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000E40")]
	private int <SendPacketsSendSize>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000E41")]
	private SocketError <SocketError>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000E42")]
	private SocketFlags <SocketFlags>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000E43")]
	private object <UserToken>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000E44")]
	private EventHandler<SocketAsyncEventArgs> Completed; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000E45")]
	private Memory<Byte> _buffer; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000E46")]
	private int _offset; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000E47")]
	private int _count; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000E48")]
	private bool _bufferIsExplicitArray; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000E49")]
	private IList<ArraySegment`1<Byte>> _bufferList; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000E4A")]
	private List<ArraySegment`1<Byte>> _bufferListInternal; //Field offset: 0xB0

	[Token(Token = "0x17000460")]
	public Socket AcceptSocket
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600148C")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600148D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700046C")]
	public IList<ArraySegment`1<Byte>> BufferList
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x60014A6")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000461")]
	public private int BytesTransferred
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600148E")]
		 get { } //Length: 4
		[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600148F")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700046B")]
	public int Count
	{
		[Address(RVA = "0x25E2B40", Offset = "0x25E1F40", Length = "0x7")]
		[Token(Token = "0x60014A5")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000468")]
	internal Socket CurrentSocket
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600149E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000462")]
	private SocketAsyncOperation LastOperation
	{
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001490")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000469")]
	public Memory<Byte> MemoryBuffer
	{
		[Address(RVA = "0x25E2B50", Offset = "0x25E1F50", Length = "0xE")]
		[Token(Token = "0x60014A3")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700046A")]
	public int Offset
	{
		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[Token(Token = "0x60014A4")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000463")]
	public EndPoint RemoteEndPoint
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6001491")]
		 set { } //Length: 13
	}

	[MonoTODO("unused property")]
	[Token(Token = "0x17000464")]
	public int SendPacketsSendSize
	{
		[Address(RVA = "0xD97670", Offset = "0xD96A70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001492")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000465")]
	public SocketError SocketError
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001493")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001494")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000466")]
	public SocketFlags SocketFlags
	{
		[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001495")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000467")]
	public object UserToken
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001496")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001497")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x25E2AB0", Offset = "0x25E1EB0", Length = "0x87")]
	[Token(Token = "0x6001499")]
	internal SocketAsyncEventArgs(bool flowExecutionContext) { }

	[Address(RVA = "0x25E2A20", Offset = "0x25E1E20", Length = "0x8F")]
	[Token(Token = "0x6001498")]
	public SocketAsyncEventArgs() { }

	[Address(RVA = "0x25E2730", Offset = "0x25E1B30", Length = "0x34")]
	[Token(Token = "0x60014A1")]
	internal void Complete_internal() { }

	[Address(RVA = "0x25E2770", Offset = "0x25E1B70", Length = "0x52")]
	[Token(Token = "0x600149C")]
	public override void Dispose() { }

	[Address(RVA = "0x25E27D0", Offset = "0x25E1BD0", Length = "0xD")]
	[Token(Token = "0x600149B")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x25E27E0", Offset = "0x25E1BE0", Length = "0x36")]
	[Token(Token = "0x600149A")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600148C")]
	public Socket get_AcceptSocket() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x60014A6")]
	public IList<ArraySegment`1<Byte>> get_BufferList() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600148E")]
	public int get_BytesTransferred() { }

	[Address(RVA = "0x25E2B40", Offset = "0x25E1F40", Length = "0x7")]
	[Token(Token = "0x60014A5")]
	public int get_Count() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600149E")]
	internal Socket get_CurrentSocket() { }

	[Address(RVA = "0x25E2B50", Offset = "0x25E1F50", Length = "0xE")]
	[Token(Token = "0x60014A3")]
	public Memory<Byte> get_MemoryBuffer() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[Token(Token = "0x60014A4")]
	public int get_Offset() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001493")]
	public SocketError get_SocketError() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001496")]
	public object get_UserToken() { }

	[Address(RVA = "0x25E2820", Offset = "0x25E1C20", Length = "0x28")]
	[Token(Token = "0x60014A2")]
	protected override void OnCompleted(SocketAsyncEventArgs e) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600148D")]
	public void set_AcceptSocket(Socket value) { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600148F")]
	private void set_BytesTransferred(int value) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001490")]
	private void set_LastOperation(SocketAsyncOperation value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6001491")]
	public void set_RemoteEndPoint(EndPoint value) { }

	[Address(RVA = "0xD97670", Offset = "0xD96A70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001492")]
	public void set_SendPacketsSendSize(int value) { }

	[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001494")]
	public void set_SocketError(SocketError value) { }

	[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001495")]
	public void set_SocketFlags(SocketFlags value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001497")]
	public void set_UserToken(object value) { }

	[Address(RVA = "0x25E2850", Offset = "0x25E1C50", Length = "0xFA")]
	[Token(Token = "0x60014A7")]
	public void SetBuffer(Memory<Byte> buffer) { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[Token(Token = "0x600149D")]
	internal void SetBytesTransferred(int value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x600149F")]
	internal void SetCurrentSocket(Socket socket) { }

	[Address(RVA = "0x25E2950", Offset = "0x25E1D50", Length = "0xCE")]
	[Token(Token = "0x60014A0")]
	internal void SetLastOperation(SocketAsyncOperation op) { }

}

