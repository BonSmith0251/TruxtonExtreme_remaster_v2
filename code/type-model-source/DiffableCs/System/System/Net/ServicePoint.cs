namespace System.Net;

[Token(Token = "0x20002B1")]
public class ServicePoint
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B39")]
	private readonly Uri uri; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B3A")]
	private DateTime lastDnsResolve; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B3B")]
	private Version protocolVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B3C")]
	private IPHostEntry host; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B3D")]
	private bool usesProxy; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000B3E")]
	private bool sendContinue; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4000B3F")]
	private bool useConnect; //Field offset: 0x32
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B40")]
	private object hostE; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B41")]
	private bool useNagle; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B42")]
	private BindIPEndPoint endPointCallback; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B43")]
	private bool tcp_keepalive; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000B44")]
	private int tcp_keepalive_time; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B45")]
	private int tcp_keepalive_interval; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000B46")]
	private bool disposed; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B47")]
	private int connectionLeaseTimeout; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000B48")]
	private int receiveBufferSize; //Field offset: 0x64
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B49")]
	private readonly SPKey <Key>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B4A")]
	private ServicePointScheduler <Scheduler>k__BackingField; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B4B")]
	private int connectionLimit; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000B4C")]
	private int maxIdleTime; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B4D")]
	private object m_ServerCertificateOrBytes; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000B4E")]
	private object m_ClientCertificateOrBytes; //Field offset: 0x88

	[Token(Token = "0x170003E3")]
	public Uri Address
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001216")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003E4")]
	public int ConnectionLimit
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x6001217")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003E6")]
	public bool Expect100Continue
	{
		[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
		[Token(Token = "0x6001219")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003EB")]
	private bool HasTimedOut
	{
		[Address(RVA = "0x25CBE90", Offset = "0x25CB290", Length = "0x11A")]
		[Token(Token = "0x6001225")]
		private get { } //Length: 282
	}

	[Token(Token = "0x170003EC")]
	internal IPHostEntry HostEntry
	{
		[Address(RVA = "0x25CBFB0", Offset = "0x25CB3B0", Length = "0x454")]
		[Token(Token = "0x6001226")]
		internal get { } //Length: 1108
	}

	[Token(Token = "0x170003E1")]
	internal SPKey Key
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001213")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003E5")]
	public override Version ProtocolVersion
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001218")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003E2")]
	private ServicePointScheduler Scheduler
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001214")]
		private get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001215")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170003E8")]
	internal bool SendContinue
	{
		[Address(RVA = "0x25CC410", Offset = "0x25CB810", Length = "0x8B")]
		[Token(Token = "0x600121C")]
		internal get { } //Length: 139
		[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
		[Token(Token = "0x600121D")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170003EA")]
	internal bool UseConnect
	{
		[Address(RVA = "0x1E075C0", Offset = "0x1E069C0", Length = "0x5")]
		[Token(Token = "0x6001223")]
		internal get { } //Length: 5
		[Address(RVA = "0x1E075F0", Offset = "0x1E069F0", Length = "0x4")]
		[Token(Token = "0x6001224")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170003E7")]
	public bool UseNagleAlgorithm
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x600121A")]
		 get { } //Length: 5
		[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
		[Token(Token = "0x600121B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003E9")]
	internal bool UsesProxy
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6001221")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[Token(Token = "0x6001222")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x25CBD80", Offset = "0x25CB180", Length = "0x10A")]
	[Token(Token = "0x6001212")]
	internal ServicePoint(SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	[Address(RVA = "0x25CBD50", Offset = "0x25CB150", Length = "0x2C")]
	[Token(Token = "0x600122D")]
	internal ServicePoint() { }

	[Address(RVA = "0x25CB7C0", Offset = "0x25CABC0", Length = "0xD0")]
	[Token(Token = "0x600122C")]
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	[Address(RVA = "0x25CB8A0", Offset = "0x25CACA0", Length = "0x17")]
	[Token(Token = "0x6001229")]
	internal void FreeServicePoint() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001216")]
	public Uri get_Address() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x6001217")]
	public int get_ConnectionLimit() { }

	[Address(RVA = "0x25CBE90", Offset = "0x25CB290", Length = "0x11A")]
	[Token(Token = "0x6001225")]
	private bool get_HasTimedOut() { }

	[Address(RVA = "0x25CBFB0", Offset = "0x25CB3B0", Length = "0x454")]
	[Token(Token = "0x6001226")]
	internal IPHostEntry get_HostEntry() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001213")]
	internal SPKey get_Key() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001218")]
	public override Version get_ProtocolVersion() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001214")]
	private ServicePointScheduler get_Scheduler() { }

	[Address(RVA = "0x25CC410", Offset = "0x25CB810", Length = "0x8B")]
	[Token(Token = "0x600121C")]
	internal bool get_SendContinue() { }

	[Address(RVA = "0x1E075C0", Offset = "0x1E069C0", Length = "0x5")]
	[Token(Token = "0x6001223")]
	internal bool get_UseConnect() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x600121A")]
	public bool get_UseNagleAlgorithm() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6001221")]
	internal bool get_UsesProxy() { }

	[Address(RVA = "0x25CB8C0", Offset = "0x25CACC0", Length = "0x146")]
	[Token(Token = "0x600121F")]
	internal void KeepAliveSetup(Socket socket) { }

	[Address(RVA = "0x25CBA10", Offset = "0x25CAE10", Length = "0x66")]
	[Token(Token = "0x6001220")]
	private static void PutBytes(Byte[] bytes, uint v, int offset) { }

	[Address(RVA = "0x25CBA80", Offset = "0x25CAE80", Length = "0x136")]
	[Token(Token = "0x6001228")]
	internal void SendRequest(WebOperation operation, string groupName) { }

	[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
	[Token(Token = "0x6001219")]
	public void set_Expect100Continue(bool value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001215")]
	private void set_Scheduler(ServicePointScheduler value) { }

	[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
	[Token(Token = "0x600121D")]
	internal void set_SendContinue(bool value) { }

	[Address(RVA = "0x1E075F0", Offset = "0x1E069F0", Length = "0x4")]
	[Token(Token = "0x6001224")]
	internal void set_UseConnect(bool value) { }

	[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
	[Token(Token = "0x600121B")]
	public void set_UseNagleAlgorithm(bool value) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[Token(Token = "0x6001222")]
	internal void set_UsesProxy(bool value) { }

	[Address(RVA = "0x25CBBC0", Offset = "0x25CAFC0", Length = "0xE3")]
	[Token(Token = "0x600121E")]
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6001227")]
	internal void SetVersion(Version version) { }

	[Address(RVA = "0x25CBCB0", Offset = "0x25CB0B0", Length = "0x49")]
	[Token(Token = "0x600122B")]
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	[Address(RVA = "0x25CBD00", Offset = "0x25CB100", Length = "0x49")]
	[Token(Token = "0x600122A")]
	internal void UpdateServerCertificate(X509Certificate certificate) { }

}

