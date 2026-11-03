namespace System.Net;

[Token(Token = "0x2000220")]
internal class TlsStream : NetworkStream
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007CC")]
	private SslStream _sslStream; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007CD")]
	private string _host; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40007CE")]
	private X509CertificateCollection _clientCertificates; //Field offset: 0x58

	[Address(RVA = "0x26AD3D0", Offset = "0x26AC7D0", Length = "0xF0")]
	[Token(Token = "0x6000E4B")]
	public TlsStream(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	[Address(RVA = "0x26ACFB0", Offset = "0x26AC3B0", Length = "0x12D")]
	[Token(Token = "0x6000E4C")]
	public void AuthenticateAsClient() { }

	[Address(RVA = "0x26AD0E0", Offset = "0x26AC4E0", Length = "0x13B")]
	[Token(Token = "0x6000E4D")]
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	[Address(RVA = "0x26AD220", Offset = "0x26AC620", Length = "0x32")]
	[Token(Token = "0x6000E53")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x26AD260", Offset = "0x26AC660", Length = "0x32")]
	[Token(Token = "0x6000E4F")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x26AD2A0", Offset = "0x26AC6A0", Length = "0x3A")]
	[Token(Token = "0x6000E55")]
	public virtual void Close() { }

	[Address(RVA = "0x26AD2E0", Offset = "0x26AC6E0", Length = "0x2A")]
	[Token(Token = "0x6000E4E")]
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26AD310", Offset = "0x26AC710", Length = "0x2A")]
	[Token(Token = "0x6000E54")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26AD340", Offset = "0x26AC740", Length = "0x2A")]
	[Token(Token = "0x6000E50")]
	public virtual void EndWrite(IAsyncResult result) { }

	[Address(RVA = "0x26AD370", Offset = "0x26AC770", Length = "0x2F")]
	[Token(Token = "0x6000E52")]
	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x26AD3A0", Offset = "0x26AC7A0", Length = "0x2F")]
	[Token(Token = "0x6000E51")]
	public virtual void Write(Byte[] buffer, int offset, int size) { }

}

