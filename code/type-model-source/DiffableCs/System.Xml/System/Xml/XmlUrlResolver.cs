namespace System.Xml;

[Token(Token = "0x20000E3")]
public class XmlUrlResolver : XmlResolver
{
	[CompilerGenerated]
	[Token(Token = "0x20000E4")]
	private struct <GetEntityAsync>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005A6")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40005A8")]
		public Type ofObjectToReturn; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40005A9")]
		public Uri absoluteUri; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40005AA")]
		public XmlUrlResolver <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40005AB")]
		private ConfiguredTaskAwaiter<Stream> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x2549880", Offset = "0x2548C80", Length = "0x333")]
		[Token(Token = "0x6000B99")]
		private override void MoveNext() { }

		[Address(RVA = "0x2549BC0", Offset = "0x2548FC0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000B9A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x40005A2")]
	private static object s_DownloadManager; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A3")]
	private ICredentials _credentials; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005A4")]
	private IWebProxy _proxy; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005A5")]
	private RequestCachePolicy _cachePolicy; //Field offset: 0x20

	[Token(Token = "0x170002E1")]
	private static XmlDownloadManager DownloadManager
	{
		[Address(RVA = "0x255E400", Offset = "0x255D800", Length = "0xD8")]
		[Token(Token = "0x6000B94")]
		private get { } //Length: 216
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B95")]
	public XmlUrlResolver() { }

	[Address(RVA = "0x255E400", Offset = "0x255D800", Length = "0xD8")]
	[Token(Token = "0x6000B94")]
	private static XmlDownloadManager get_DownloadManager() { }

	[Address(RVA = "0x255E1B0", Offset = "0x255D5B0", Length = "0x236")]
	[Token(Token = "0x6000B96")]
	public virtual object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	[Address(RVA = "0x255E060", Offset = "0x255D460", Length = "0x148")]
	[AsyncStateMachine(typeof(<GetEntityAsync>d__15))]
	[Token(Token = "0x6000B98")]
	public virtual Task<Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	[Address(RVA = "0x255E3F0", Offset = "0x255D7F0", Length = "0x8")]
	[Token(Token = "0x6000B97")]
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

}

