namespace System.Net;

[Token(Token = "0x20002C0")]
internal class WebConnection : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20002C1")]
	private sealed class <>c
	{
		[Token(Token = "0x4000BA7")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000BA8")]
		public static Func<IPEndPoint, AsyncCallback, Object, IAsyncResult> <>9__16_0; //Field offset: 0x8
		[Token(Token = "0x4000BA9")]
		public static Action<IAsyncResult> <>9__16_1; //Field offset: 0x10

		[Address(RVA = "0x25D54E0", Offset = "0x25D48E0", Length = "0x67")]
		[Token(Token = "0x6001292")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001293")]
		public <>c() { }

		[Address(RVA = "0x25D5310", Offset = "0x25D4710", Length = "0x9B")]
		[Token(Token = "0x6001294")]
		internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state) { }

		[Address(RVA = "0x25D53B0", Offset = "0x25D47B0", Length = "0x9C")]
		[Token(Token = "0x6001295")]
		internal void <Connect>b__16_1(IAsyncResult asyncResult) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002C2")]
	private struct <Connect>d__16 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BAA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BAB")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BAC")]
		public WebConnection <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BAD")]
		public WebOperation operation; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BAE")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BAF")]
		private Exception <connectException>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BB0")]
		private IPAddress[] <>7__wrap2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BB1")]
		private int <>7__wrap3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BB2")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50

		[Address(RVA = "0x25CC4A0", Offset = "0x25CB8A0", Length = "0x846")]
		[Token(Token = "0x6001296")]
		private override void MoveNext() { }

		[Address(RVA = "0x25CCCF0", Offset = "0x25CC0F0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6001297")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002C3")]
	private struct <CreateStream>d__18 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BB4")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BB5")]
		public WebConnection <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BB6")]
		public WebOperation operation; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BB7")]
		public bool reused; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BB8")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BB9")]
		private NetworkStream <stream>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BBA")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000BBB")]
		private ConfiguredTaskAwaiter<Stream> <>u__2; //Field offset: 0x58

		[Address(RVA = "0x25CCD50", Offset = "0x25CC150", Length = "0x7B7")]
		[Token(Token = "0x6001298")]
		private override void MoveNext() { }

		[Address(RVA = "0x25CD510", Offset = "0x25CC910", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6001299")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002C4")]
	private struct <InitConnection>d__19 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BBC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BBD")]
		public AsyncTaskMethodBuilder<WebRequestStream> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BBE")]
		public WebOperation operation; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BBF")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BC0")]
		public WebConnection <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BC1")]
		private bool <reused>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BC2")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BC3")]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x50

		[Address(RVA = "0x25CEB30", Offset = "0x25CDF30", Length = "0x6E6")]
		[Token(Token = "0x600129A")]
		private override void MoveNext() { }

		[Address(RVA = "0x25CF220", Offset = "0x25CE620", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600129B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B9B")]
	private NetworkCredential ntlm_credentials; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B9C")]
	private bool ntlm_authenticated; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000B9D")]
	private bool unsafe_sharing; //Field offset: 0x19
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B9E")]
	private Stream networkStream; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B9F")]
	private Socket socket; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BA0")]
	private MonoTlsStream monoTlsStream; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BA1")]
	private WebConnectionTunnel tunnel; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BA2")]
	private int disposed; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BA3")]
	private readonly ServicePoint <ServicePoint>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BA4")]
	internal readonly int ID; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BA5")]
	private DateTime idleSince; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BA6")]
	private WebOperation currentOperation; //Field offset: 0x60

	[Token(Token = "0x170003FD")]
	public bool Closed
	{
		[Address(RVA = "0x25D9390", Offset = "0x25D8790", Length = "0x8")]
		[Token(Token = "0x6001285")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003FE")]
	public DateTime IdleSince
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6001286")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003FF")]
	internal bool NtlmAuthenticated
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x600128C")]
		internal get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x600128D")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000400")]
	internal NetworkCredential NtlmCredential
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600128E")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x600128F")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170003FC")]
	public ServicePoint ServicePoint
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001277")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000401")]
	internal bool UnsafeAuthenticatedConnectionSharing
	{
		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[Token(Token = "0x6001290")]
		internal get { } //Length: 5
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[Token(Token = "0x6001291")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x25D9350", Offset = "0x25D8750", Length = "0x31")]
	[Token(Token = "0x6001278")]
	public WebConnection(ServicePoint sPoint) { }

	[Address(RVA = "0x25D8300", Offset = "0x25D7700", Length = "0x26")]
	[Token(Token = "0x6001279")]
	private bool CanReuse() { }

	[Address(RVA = "0x25D7FA0", Offset = "0x25D73A0", Length = "0x351")]
	[Token(Token = "0x6001280")]
	internal bool CanReuseConnection(WebOperation operation) { }

	[Address(RVA = "0x25D8330", Offset = "0x25D7730", Length = "0x45")]
	[Token(Token = "0x600127A")]
	private bool CheckReusable() { }

	[Address(RVA = "0x25D84E0", Offset = "0x25D78E0", Length = "0x9F")]
	[Token(Token = "0x6001283")]
	private void Close(bool reset) { }

	[Address(RVA = "0x25D8380", Offset = "0x25D7780", Length = "0x15A")]
	[Token(Token = "0x6001284")]
	private void CloseSocket() { }

	[Address(RVA = "0x25D8580", Offset = "0x25D7980", Length = "0x11E")]
	[AsyncStateMachine(typeof(<Connect>d__16))]
	[Token(Token = "0x600127B")]
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25D86A0", Offset = "0x25D7AA0", Length = "0x15B")]
	[Token(Token = "0x6001288")]
	public bool Continue(WebOperation next) { }

	[Address(RVA = "0x25D8800", Offset = "0x25D7C00", Length = "0x14C")]
	[AsyncStateMachine(typeof(<CreateStream>d__18))]
	[Token(Token = "0x600127C")]
	private Task<Boolean> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25D8950", Offset = "0x25D7D50", Length = "0x39")]
	[Token(Token = "0x600128A")]
	public override void Dispose() { }

	[Address(RVA = "0x25D8950", Offset = "0x25D7D50", Length = "0x39")]
	[Token(Token = "0x6001289")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x25D9390", Offset = "0x25D8790", Length = "0x8")]
	[Token(Token = "0x6001285")]
	public bool get_Closed() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6001286")]
	public DateTime get_IdleSince() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x600128C")]
	internal bool get_NtlmAuthenticated() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600128E")]
	internal NetworkCredential get_NtlmCredential() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001277")]
	public ServicePoint get_ServicePoint() { }

	[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
	[Token(Token = "0x6001290")]
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	[Address(RVA = "0x25D8990", Offset = "0x25D7D90", Length = "0x16E")]
	[Token(Token = "0x600127E")]
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	[Address(RVA = "0x25D8B00", Offset = "0x25D7F00", Length = "0x143")]
	[AsyncStateMachine(typeof(<InitConnection>d__19))]
	[Token(Token = "0x600127D")]
	internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25D8C50", Offset = "0x25D8050", Length = "0x24B")]
	[Token(Token = "0x6001281")]
	private bool PrepareSharingNtlm(WebOperation operation) { }

	[Address(RVA = "0x25D8EA0", Offset = "0x25D82A0", Length = "0x1E2")]
	[Token(Token = "0x600127F")]
	internal static bool ReadLine(Byte[] buffer, ref int start, int max, ref string output) { }

	[Address(RVA = "0x25D90C0", Offset = "0x25D84C0", Length = "0xA7")]
	[Token(Token = "0x6001282")]
	private void Reset() { }

	[Address(RVA = "0x25D9090", Offset = "0x25D8490", Length = "0x2A")]
	[Token(Token = "0x600128B")]
	private void ResetNtlm() { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x600128D")]
	internal void set_NtlmAuthenticated(bool value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x600128F")]
	internal void set_NtlmCredential(NetworkCredential value) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[Token(Token = "0x6001291")]
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[Address(RVA = "0x25D9170", Offset = "0x25D8570", Length = "0x1D8")]
	[Token(Token = "0x6001287")]
	public bool StartOperation(WebOperation operation, bool reused) { }

}

