namespace System.Net;

[Token(Token = "0x20002CA")]
internal class WebOperation
{
	[CompilerGenerated]
	[Token(Token = "0x20002CB")]
	private struct <GetRequestStream>d__50 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C01")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C02")]
		public AsyncTaskMethodBuilder<Stream> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C03")]
		public WebOperation <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C04")]
		private ConfiguredTaskAwaiter<WebRequestStream> <>u__1; //Field offset: 0x28

		[Address(RVA = "0x25CDF90", Offset = "0x25CD390", Length = "0x205")]
		[Token(Token = "0x60012F1")]
		private override void MoveNext() { }

		[Address(RVA = "0x25CE1A0", Offset = "0x25CD5A0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60012F2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002CC")]
	private struct <Run>d__58 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C05")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C06")]
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C07")]
		public WebOperation <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C08")]
		private WebRequestStream <requestStream>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C09")]
		private WebResponseStream <stream>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C0A")]
		private ConfiguredTaskAwaiter<WebRequestStream> <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C0B")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x25D4030", Offset = "0x25D3430", Length = "0x7E6")]
		[Token(Token = "0x60012F3")]
		private override void MoveNext() { }

		[Address(RVA = "0x220A510", Offset = "0x2209910", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60012F4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BEF")]
	private readonly HttpWebRequest <Request>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BF0")]
	private WebConnection <Connection>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BF1")]
	private ServicePoint <ServicePoint>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BF2")]
	private readonly BufferOffsetSize <WriteBuffer>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BF3")]
	private readonly bool <IsNtlmChallenge>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000BF4")]
	internal readonly int ID; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BF5")]
	private CancellationTokenSource cts; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BF6")]
	private WebCompletionSource<WebRequestStream> requestTask; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BF7")]
	private WebCompletionSource<WebRequestStream> requestWrittenTask; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BF8")]
	private WebCompletionSource<WebResponseStream> responseTask; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BF9")]
	private WebCompletionSource<ValueTuple`2<Boolean, WebOperation>> finishedTask; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BFA")]
	private WebRequestStream writeStream; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000BFB")]
	private WebResponseStream responseStream; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000BFC")]
	private ExceptionDispatchInfo disposedInfo; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000BFD")]
	private ExceptionDispatchInfo closedInfo; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000BFE")]
	private WebOperation priorityRequest; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000BFF")]
	private int requestSent; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000C00")]
	private int finished; //Field offset: 0x8C

	[Token(Token = "0x1700041B")]
	public bool Aborted
	{
		[Address(RVA = "0x25DA5E0", Offset = "0x25D99E0", Length = "0x4F")]
		[Token(Token = "0x60012D9")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700041C")]
	public bool Closed
	{
		[Address(RVA = "0x25DA630", Offset = "0x25D9A30", Length = "0x55")]
		[Token(Token = "0x60012DA")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000417")]
	public private WebConnection Connection
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012D2")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60012D3")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700041E")]
	internal WebCompletionSource<ValueTuple`2<Boolean, WebOperation>> Finished
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60012EC")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700041A")]
	public bool IsNtlmChallenge
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012D7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000416")]
	public HttpWebRequest Request
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012D1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000418")]
	public private ServicePoint ServicePoint
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012D4")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60012D5")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000419")]
	public BufferOffsetSize WriteBuffer
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012D6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700041D")]
	public WebRequestStream WriteStream
	{
		[Address(RVA = "0x25DA690", Offset = "0x25D9A90", Length = "0x59")]
		[Token(Token = "0x60012EA")]
		 get { } //Length: 89
	}

	[Address(RVA = "0x25DA420", Offset = "0x25D9820", Length = "0x1B8")]
	[Token(Token = "0x60012D8")]
	public WebOperation(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DA3E0", Offset = "0x25D97E0", Length = "0x32")]
	[CompilerGenerated]
	[Token(Token = "0x60012F0")]
	private void <RegisterRequest>b__48_0() { }

	[Address(RVA = "0x25D93A0", Offset = "0x25D87A0", Length = "0x52")]
	[Token(Token = "0x60012DB")]
	public void Abort() { }

	[Address(RVA = "0x25D9400", Offset = "0x25D8800", Length = "0xD4")]
	[Token(Token = "0x60012E0")]
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	[Address(RVA = "0x25D94E0", Offset = "0x25D88E0", Length = "0x6B")]
	[Token(Token = "0x60012E5")]
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field) { }

	[Address(RVA = "0x25D9550", Offset = "0x25D8950", Length = "0x52")]
	[Token(Token = "0x60012DC")]
	public void Close() { }

	[Address(RVA = "0x25D95B0", Offset = "0x25D89B0", Length = "0x82")]
	[Token(Token = "0x60012EE")]
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error = null) { }

	[Address(RVA = "0x25D9640", Offset = "0x25D8A40", Length = "0x28B")]
	[Token(Token = "0x60012EF")]
	internal void Finish(bool ok, Exception error = null) { }

	[Address(RVA = "0x25DA5E0", Offset = "0x25D99E0", Length = "0x4F")]
	[Token(Token = "0x60012D9")]
	public bool get_Aborted() { }

	[Address(RVA = "0x25DA630", Offset = "0x25D9A30", Length = "0x55")]
	[Token(Token = "0x60012DA")]
	public bool get_Closed() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012D2")]
	public WebConnection get_Connection() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60012EC")]
	internal WebCompletionSource<ValueTuple`2<Boolean, WebOperation>> get_Finished() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012D7")]
	public bool get_IsNtlmChallenge() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012D1")]
	public HttpWebRequest get_Request() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012D4")]
	public ServicePoint get_ServicePoint() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012D6")]
	public BufferOffsetSize get_WriteBuffer() { }

	[Address(RVA = "0x25DA690", Offset = "0x25D9A90", Length = "0x59")]
	[Token(Token = "0x60012EA")]
	public WebRequestStream get_WriteStream() { }

	[Address(RVA = "0x25D9920", Offset = "0x25D8D20", Length = "0xF6")]
	[AsyncStateMachine(typeof(<GetRequestStream>d__50))]
	[Token(Token = "0x60012E8")]
	public Task<Stream> GetRequestStream() { }

	[Address(RVA = "0x25D98D0", Offset = "0x25D8CD0", Length = "0x44")]
	[Token(Token = "0x60012E9")]
	internal Task<WebRequestStream> GetRequestStreamInternal() { }

	[Address(RVA = "0x25D9A20", Offset = "0x25D8E20", Length = "0x44")]
	[Token(Token = "0x60012EB")]
	public Task<WebResponseStream> GetResponseStream() { }

	[Address(RVA = "0x25D9A70", Offset = "0x25D8E70", Length = "0x276")]
	[Token(Token = "0x60012E6")]
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	[Address(RVA = "0x25D9CF0", Offset = "0x25D90F0", Length = "0xB1")]
	[AsyncStateMachine(typeof(<Run>d__58))]
	[Token(Token = "0x60012ED")]
	internal void Run() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60012D3")]
	private void set_Connection(WebConnection value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60012D5")]
	private void set_ServicePoint(ServicePoint value) { }

	[Address(RVA = "0x25D9DB0", Offset = "0x25D91B0", Length = "0xC1")]
	[Token(Token = "0x60012DD")]
	private void SetCanceled() { }

	[Address(RVA = "0x25D9E80", Offset = "0x25D9280", Length = "0xD8")]
	[Token(Token = "0x60012DF")]
	private ValueTuple<ExceptionDispatchInfo, Boolean> SetDisposed(ref ExceptionDispatchInfo field) { }

	[Address(RVA = "0x25D9F60", Offset = "0x25D9360", Length = "0x9F")]
	[Token(Token = "0x60012DE")]
	private void SetError(Exception error) { }

	[Address(RVA = "0x25DA000", Offset = "0x25D9400", Length = "0x156")]
	[Token(Token = "0x60012E7")]
	public void SetPriorityRequest(WebOperation operation) { }

	[Address(RVA = "0x25DA1C0", Offset = "0x25D95C0", Length = "0xD9")]
	[Token(Token = "0x60012E4")]
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DA160", Offset = "0x25D9560", Length = "0x54")]
	[Token(Token = "0x60012E3")]
	internal void ThrowIfClosedOrDisposed() { }

	[Address(RVA = "0x25DA380", Offset = "0x25D9780", Length = "0x54")]
	[Token(Token = "0x60012E1")]
	internal void ThrowIfDisposed() { }

	[Address(RVA = "0x25DA2A0", Offset = "0x25D96A0", Length = "0xD2")]
	[Token(Token = "0x60012E2")]
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

}

