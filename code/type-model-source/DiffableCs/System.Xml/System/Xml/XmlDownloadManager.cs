namespace System.Xml;

[Token(Token = "0x20000C8")]
internal class XmlDownloadManager
{
	[CompilerGenerated]
	[Token(Token = "0x20000C9")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000560")]
		public Uri uri; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000AFD")]
		public <>c__DisplayClass4_0() { }

		[Address(RVA = "0x254A440", Offset = "0x2549840", Length = "0x94")]
		[Token(Token = "0x6000AFE")]
		internal Stream <GetStreamAsync>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CA")]
	private struct <GetNonFileStreamAsync>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000561")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000562")]
		public AsyncTaskMethodBuilder<Stream> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000563")]
		public Uri uri; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000564")]
		public ICredentials credentials; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000565")]
		public IWebProxy proxy; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000566")]
		public RequestCachePolicy cachePolicy; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000567")]
		public XmlDownloadManager <>4__this; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000568")]
		private WebRequest <req>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000569")]
		private ConfiguredTaskAwaiter<WebResponse> <>u__1; //Field offset: 0x50

		[Address(RVA = "0x2549C30", Offset = "0x2549030", Length = "0x792")]
		[Token(Token = "0x6000AFF")]
		private override void MoveNext() { }

		[Address(RVA = "0x254A3D0", Offset = "0x25497D0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000B00")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400055F")]
	private Hashtable connections; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000AFC")]
	public XmlDownloadManager() { }

	[Address(RVA = "0x2558FD0", Offset = "0x25583D0", Length = "0x477")]
	[Token(Token = "0x6000AF8")]
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[Address(RVA = "0x2558E60", Offset = "0x2558260", Length = "0x163")]
	[AsyncStateMachine(typeof(<GetNonFileStreamAsync>d__5))]
	[Token(Token = "0x6000AFB")]
	private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[Address(RVA = "0x25596C0", Offset = "0x2558AC0", Length = "0x100")]
	[Token(Token = "0x6000AF7")]
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[Address(RVA = "0x2559450", Offset = "0x2558850", Length = "0x26C")]
	[Token(Token = "0x6000AFA")]
	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[Address(RVA = "0x25597D0", Offset = "0x2558BD0", Length = "0x13B")]
	[Token(Token = "0x6000AF9")]
	internal void Remove(string host) { }

}

