namespace System.Net.Sockets;

[Token(Token = "0x2000315")]
internal sealed class SocketAsyncResult : IOAsyncResult
{
	[CompilerGenerated]
	[Token(Token = "0x2000316")]
	private sealed class <>c
	{
		[Token(Token = "0x4000E5D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000E5E")]
		public static WaitCallback <>9__27_0; //Field offset: 0x8

		[Address(RVA = "0x25F61D0", Offset = "0x25F55D0", Length = "0x67")]
		[Token(Token = "0x60014B6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60014B7")]
		public <>c() { }

		[Address(RVA = "0x25F2C70", Offset = "0x25F2070", Length = "0x82")]
		[Token(Token = "0x60014B8")]
		internal void <Complete>b__27_0(object state) { }

	}

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E4B")]
	public Socket socket; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E4C")]
	public SocketOperation operation; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E4D")]
	private Exception DelayedException; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E4E")]
	public EndPoint EndPoint; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E4F")]
	public Memory<Byte> Buffer; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E50")]
	public int Offset; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000E51")]
	public int Size; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000E52")]
	public SocketFlags SockFlags; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000E53")]
	public Socket AcceptSocket; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000E54")]
	public IPAddress[] Addresses; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000E55")]
	public int Port; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000E56")]
	public IList<ArraySegment`1<Byte>> Buffers; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000E57")]
	public bool ReuseSocket; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000E58")]
	public int CurrentAddress; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000E59")]
	public Socket AcceptedSocket; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000E5A")]
	public int Total; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000E5B")]
	internal int error; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000E5C")]
	public int EndCalled; //Field offset: 0xA8

	[Token(Token = "0x1700046E")]
	public SocketError ErrorCode
	{
		[Address(RVA = "0x25E30D0", Offset = "0x25E24D0", Length = "0x83")]
		[Token(Token = "0x60014AC")]
		 get { } //Length: 131
	}

	[Token(Token = "0x1700046D")]
	public IntPtr Handle
	{
		[Address(RVA = "0x25E3160", Offset = "0x25E2560", Length = "0x2D")]
		[Token(Token = "0x60014A8")]
		 get { } //Length: 45
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60014A9")]
	public SocketAsyncResult() { }

	[Address(RVA = "0x25E3080", Offset = "0x25E2480", Length = "0x46")]
	[Token(Token = "0x60014AB")]
	public SocketAsyncResult(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	[Address(RVA = "0x25E2B60", Offset = "0x25E1F60", Length = "0xA5")]
	[Token(Token = "0x60014AD")]
	public void CheckIfThrowDelayedException() { }

	[Address(RVA = "0x25E2D20", Offset = "0x25E2120", Length = "0x1B8")]
	[Token(Token = "0x60014AF")]
	public void Complete() { }

	[Address(RVA = "0x25E2C20", Offset = "0x25E2020", Length = "0xA")]
	[Token(Token = "0x60014B0")]
	public void Complete(bool synch) { }

	[Address(RVA = "0x25E2CE0", Offset = "0x25E20E0", Length = "0xD")]
	[Token(Token = "0x60014B1")]
	public void Complete(int total) { }

	[Address(RVA = "0x25E2C60", Offset = "0x25E2060", Length = "0x35")]
	[Token(Token = "0x60014B2")]
	public void Complete(Exception e, bool synch) { }

	[Address(RVA = "0x25E2C30", Offset = "0x25E2030", Length = "0x25")]
	[Token(Token = "0x60014B3")]
	public void Complete(Exception e) { }

	[Address(RVA = "0x25E2CF0", Offset = "0x25E20F0", Length = "0x2B")]
	[Token(Token = "0x60014B4")]
	public void Complete(Socket s) { }

	[Address(RVA = "0x25E2CA0", Offset = "0x25E20A0", Length = "0x3D")]
	[Token(Token = "0x60014B5")]
	public void Complete(Socket s, int total) { }

	[Address(RVA = "0x25E2C10", Offset = "0x25E2010", Length = "0x7")]
	[Token(Token = "0x60014AE")]
	internal virtual void CompleteDisposed() { }

	[Address(RVA = "0x25E30D0", Offset = "0x25E24D0", Length = "0x83")]
	[Token(Token = "0x60014AC")]
	public SocketError get_ErrorCode() { }

	[Address(RVA = "0x25E3160", Offset = "0x25E2560", Length = "0x2D")]
	[Token(Token = "0x60014A8")]
	public IntPtr get_Handle() { }

	[Address(RVA = "0x25E2F50", Offset = "0x25E2350", Length = "0x12F")]
	[Token(Token = "0x60014AA")]
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

}

