namespace System.Net.Security;

[Token(Token = "0x2000321")]
public class SslStream : AuthenticatedStream
{
	[CompilerGenerated]
	[Token(Token = "0x2000322")]
	private sealed class <>c__DisplayClass21_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E87")]
		public LocalCertificateSelectionCallback callback; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E88")]
		public SslStream <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60014F5")]
		public <>c__DisplayClass21_0() { }

		[Address(RVA = "0x25F5E20", Offset = "0x25F5220", Length = "0x44")]
		[Token(Token = "0x60014F6")]
		internal X509Certificate <SetAndVerifySelectionCallback>b__0(string t, X509CertificateCollection lc, X509Certificate rc, String[] ai) { }

	}

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E81")]
	private MobileTlsProvider provider; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E82")]
	private MonoTlsSettings settings; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E83")]
	private RemoteCertificateValidationCallback validationCallback; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E84")]
	private LocalCertificateSelectionCallback selectionCallback; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000E85")]
	private MobileAuthenticatedStream impl; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E86")]
	private bool explicitSettings; //Field offset: 0x60

	[Token(Token = "0x1700047C")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x25EF2A0", Offset = "0x25EE6A0", Length = "0x22")]
		[Token(Token = "0x60014DE")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700047B")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60014DD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700047D")]
	public virtual bool CanTimeout
	{
		[Address(RVA = "0x22BED80", Offset = "0x22BE180", Length = "0x2A")]
		[Token(Token = "0x60014DF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700047E")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x25EF2D0", Offset = "0x25EE6D0", Length = "0x22")]
		[Token(Token = "0x60014E0")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000477")]
	internal MobileAuthenticatedStream Impl
	{
		[Address(RVA = "0x25EF300", Offset = "0x25EE700", Length = "0x66")]
		[Token(Token = "0x60014CF")]
		internal get { } //Length: 102
	}

	[Token(Token = "0x17000478")]
	internal string InternalTargetHost
	{
		[Address(RVA = "0x25EF370", Offset = "0x25EE770", Length = "0x6D")]
		[Token(Token = "0x60014D0")]
		internal get { } //Length: 109
	}

	[Token(Token = "0x17000479")]
	public virtual bool IsAuthenticated
	{
		[Address(RVA = "0x25EF3E0", Offset = "0x25EE7E0", Length = "0x79")]
		[Token(Token = "0x60014DB")]
		 get { } //Length: 121
	}

	[Token(Token = "0x17000481")]
	public virtual long Length
	{
		[Address(RVA = "0x25EF460", Offset = "0x25EE860", Length = "0x79")]
		[Token(Token = "0x60014E5")]
		 get { } //Length: 121
	}

	[Token(Token = "0x1700047A")]
	public override X509Certificate LocalCertificate
	{
		[Address(RVA = "0x25EF4E0", Offset = "0x25EE8E0", Length = "0x6C")]
		[Token(Token = "0x60014DC")]
		 get { } //Length: 108
	}

	[Token(Token = "0x17000482")]
	public virtual long Position
	{
		[Address(RVA = "0x25EF550", Offset = "0x25EE950", Length = "0x79")]
		[Token(Token = "0x60014E6")]
		 get { } //Length: 121
		[Address(RVA = "0x25EF6D0", Offset = "0x25EEAD0", Length = "0x5F")]
		[Token(Token = "0x60014E7")]
		 set { } //Length: 95
	}

	[Token(Token = "0x1700047F")]
	public virtual int ReadTimeout
	{
		[Address(RVA = "0x25EF5D0", Offset = "0x25EE9D0", Length = "0x79")]
		[Token(Token = "0x60014E1")]
		 get { } //Length: 121
		[Address(RVA = "0x25EF730", Offset = "0x25EEB30", Length = "0x79")]
		[Token(Token = "0x60014E2")]
		 set { } //Length: 121
	}

	[Token(Token = "0x17000480")]
	public virtual int WriteTimeout
	{
		[Address(RVA = "0x25EF650", Offset = "0x25EEA50", Length = "0x79")]
		[Token(Token = "0x60014E3")]
		 get { } //Length: 121
		[Address(RVA = "0x25EF7B0", Offset = "0x25EEBB0", Length = "0x79")]
		[Token(Token = "0x60014E4")]
		 set { } //Length: 121
	}

	[Address(RVA = "0x25EF060", Offset = "0x25EE460", Length = "0x1A")]
	[Token(Token = "0x60014D2")]
	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	[Address(RVA = "0x25EF080", Offset = "0x25EE480", Length = "0x21F")]
	[Token(Token = "0x60014D3")]
	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	[Address(RVA = "0x25EEEF0", Offset = "0x25EE2F0", Length = "0x164")]
	[Token(Token = "0x60014D4")]
	internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	[Address(RVA = "0x25EE5B0", Offset = "0x25ED9B0", Length = "0x7C")]
	[Token(Token = "0x60014D7")]
	public override void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	[Address(RVA = "0x25EE530", Offset = "0x25ED930", Length = "0x7C")]
	[Token(Token = "0x60014DA")]
	public override Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	[Address(RVA = "0x25EE630", Offset = "0x25EDA30", Length = "0x91")]
	[Token(Token = "0x60014D8")]
	public override IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	[Address(RVA = "0x25EE6D0", Offset = "0x25EDAD0", Length = "0x88")]
	[Token(Token = "0x60014F1")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x25EE760", Offset = "0x25EDB60", Length = "0x88")]
	[Token(Token = "0x60014F3")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x25EE7F0", Offset = "0x25EDBF0", Length = "0x62")]
	[Token(Token = "0x60014EB")]
	private void CheckDisposed() { }

	[Address(RVA = "0x25EE860", Offset = "0x25EDC60", Length = "0xAE")]
	[Token(Token = "0x60014EC")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1E9E750", Offset = "0x1E9DB50", Length = "0xA")]
	[Token(Token = "0x60014D9")]
	public override void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	[Address(RVA = "0x25EE910", Offset = "0x25EDD10", Length = "0x39")]
	[Token(Token = "0x60014F2")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1E9E750", Offset = "0x1E9DB50", Length = "0xA")]
	[Token(Token = "0x60014F4")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x22BD1F0", Offset = "0x22BC5F0", Length = "0x2A")]
	[Token(Token = "0x60014EA")]
	public virtual void Flush() { }

	[Address(RVA = "0x25EE950", Offset = "0x25EDD50", Length = "0x2A")]
	[Token(Token = "0x60014E9")]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x25EF2A0", Offset = "0x25EE6A0", Length = "0x22")]
	[Token(Token = "0x60014DE")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60014DD")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x22BED80", Offset = "0x22BE180", Length = "0x2A")]
	[Token(Token = "0x60014DF")]
	public virtual bool get_CanTimeout() { }

	[Address(RVA = "0x25EF2D0", Offset = "0x25EE6D0", Length = "0x22")]
	[Token(Token = "0x60014E0")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x25EF300", Offset = "0x25EE700", Length = "0x66")]
	[Token(Token = "0x60014CF")]
	internal MobileAuthenticatedStream get_Impl() { }

	[Address(RVA = "0x25EF370", Offset = "0x25EE770", Length = "0x6D")]
	[Token(Token = "0x60014D0")]
	internal string get_InternalTargetHost() { }

	[Address(RVA = "0x25EF3E0", Offset = "0x25EE7E0", Length = "0x79")]
	[Token(Token = "0x60014DB")]
	public virtual bool get_IsAuthenticated() { }

	[Address(RVA = "0x25EF460", Offset = "0x25EE860", Length = "0x79")]
	[Token(Token = "0x60014E5")]
	public virtual long get_Length() { }

	[Address(RVA = "0x25EF4E0", Offset = "0x25EE8E0", Length = "0x6C")]
	[Token(Token = "0x60014DC")]
	public override X509Certificate get_LocalCertificate() { }

	[Address(RVA = "0x25EF550", Offset = "0x25EE950", Length = "0x79")]
	[Token(Token = "0x60014E6")]
	public virtual long get_Position() { }

	[Address(RVA = "0x25EF5D0", Offset = "0x25EE9D0", Length = "0x79")]
	[Token(Token = "0x60014E1")]
	public virtual int get_ReadTimeout() { }

	[Address(RVA = "0x25EF650", Offset = "0x25EEA50", Length = "0x79")]
	[Token(Token = "0x60014E3")]
	public virtual int get_WriteTimeout() { }

	[Address(RVA = "0x25EE980", Offset = "0x25EDD80", Length = "0x68")]
	[Token(Token = "0x60014D1")]
	private static MobileTlsProvider GetProvider() { }

	[Address(RVA = "0x25EEA70", Offset = "0x25EDE70", Length = "0x7E")]
	[Token(Token = "0x60014ED")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x25EE9F0", Offset = "0x25EDDF0", Length = "0x7E")]
	[Token(Token = "0x60014EF")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25EEAF0", Offset = "0x25EDEF0", Length = "0x5F")]
	[Token(Token = "0x60014E8")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x25EF6D0", Offset = "0x25EEAD0", Length = "0x5F")]
	[Token(Token = "0x60014E7")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x25EF730", Offset = "0x25EEB30", Length = "0x79")]
	[Token(Token = "0x60014E2")]
	public virtual void set_ReadTimeout(int value) { }

	[Address(RVA = "0x25EF7B0", Offset = "0x25EEBB0", Length = "0x79")]
	[Token(Token = "0x60014E4")]
	public virtual void set_WriteTimeout(int value) { }

	[Address(RVA = "0x25EEB50", Offset = "0x25EDF50", Length = "0x1AB")]
	[Token(Token = "0x60014D6")]
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	[Address(RVA = "0x25EED00", Offset = "0x25EE100", Length = "0xEE")]
	[Token(Token = "0x60014D5")]
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	[Address(RVA = "0x25EEE70", Offset = "0x25EE270", Length = "0x7E")]
	[Token(Token = "0x60014EE")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x25EEDF0", Offset = "0x25EE1F0", Length = "0x7E")]
	[Token(Token = "0x60014F0")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

