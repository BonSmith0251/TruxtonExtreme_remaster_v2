namespace System.Net.Sockets;

[Token(Token = "0x2000311")]
public class TcpClient : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E21")]
	private Socket m_ClientSocket; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E22")]
	private bool m_Active; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E23")]
	private NetworkStream m_DataStream; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E24")]
	private AddressFamily m_Family; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000E25")]
	private bool m_CleanedUp; //Field offset: 0x2C

	[Token(Token = "0x1700045F")]
	public Socket Client
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600147A")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x600147B")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x25F04B0", Offset = "0x25EF8B0", Length = "0xB3")]
	[Token(Token = "0x6001478")]
	public TcpClient() { }

	[Address(RVA = "0x25F0570", Offset = "0x25EF970", Length = "0x169")]
	[Token(Token = "0x6001479")]
	public TcpClient(AddressFamily family) { }

	[Address(RVA = "0x25EF830", Offset = "0x25EEC30", Length = "0x78")]
	[Token(Token = "0x600147E")]
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	[Address(RVA = "0x25EFB30", Offset = "0x25EEF30", Length = "0x666")]
	[Token(Token = "0x600147C")]
	public void Connect(string hostname, int port) { }

	[Address(RVA = "0x25EFA20", Offset = "0x25EEE20", Length = "0x103")]
	[Token(Token = "0x600147D")]
	public void Connect(IPEndPoint remoteEP) { }

	[Address(RVA = "0x25EF8B0", Offset = "0x25EECB0", Length = "0x166")]
	[Token(Token = "0x6001480")]
	public Task ConnectAsync(string host, int port) { }

	[Address(RVA = "0x25F01C0", Offset = "0x25EF5C0", Length = "0x113")]
	[Token(Token = "0x6001482")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x25F01A0", Offset = "0x25EF5A0", Length = "0x16")]
	[Token(Token = "0x6001483")]
	public override void Dispose() { }

	[Address(RVA = "0x25F02E0", Offset = "0x25EF6E0", Length = "0x45")]
	[Token(Token = "0x600147F")]
	public void EndConnect(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x6001484")]
	protected virtual void Finalize() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600147A")]
	public Socket get_Client() { }

	[Address(RVA = "0x25F0330", Offset = "0x25EF730", Length = "0x171")]
	[Token(Token = "0x6001481")]
	public NetworkStream GetStream() { }

	[Address(RVA = "0x25F06E0", Offset = "0x25EFAE0", Length = "0x83")]
	[Token(Token = "0x6001485")]
	private void initialize() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x600147B")]
	public void set_Client(Socket value) { }

}

