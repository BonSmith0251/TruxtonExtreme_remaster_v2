namespace KANAI.Network;

[Token(Token = "0x2000006")]
public class ConnectionManager : MonoBehaviourSingleton<ConnectionManager>
{
	[CompilerGenerated]
	[Token(Token = "0x2000009")]
	private sealed class <RequestWait>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001E")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001F")]
		private object <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000020")]
		public HTTPRequest request; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000021")]
		public string forceJson; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000022")]
		public Action<TResult> iResponceFunc; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000023")]
		public Action<ConnectionError> iErrorFunc; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000024")]
		public ConnectionManager <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000025")]
		private int <retryCount>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000026")]
		private int <i>5__3; //Field offset: 0x0

		[Token(Token = "0x17000005")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000026")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000006")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000028")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000023")]
		public <RequestWait>d__21`1(int <>1__state) { }

		[Address(RVA = "0x1978D40", Offset = "0x1978140", Length = "0x2FB")]
		[Token(Token = "0x6000025")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000026")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000028")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000027")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000024")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000008")]
	internal class ConnectionError
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001B")]
		public int ErrorCode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400001C")]
		public int RetryCount; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001D")]
		public Dialog ErrorData; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000022")]
		public ConnectionError() { }

	}

	[Token(Token = "0x2000007")]
	internal sealed class RequestParameter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000017")]
		public string method; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000018")]
		public T args; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000019")]
		public EntryPoint entryPoint; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001A")]
		public Method requestType; //Field offset: 0x0

		[Address(RVA = "0xF52ED0", Offset = "0xF522D0", Length = "0xB3")]
		[Token(Token = "0x6000021")]
		public RequestParameter`1() { }

	}

	[Token(Token = "0x400000D")]
	private const int ICON_HIDDEN_SEC = 60; //Field offset: 0x0
	[Token(Token = "0x400000E")]
	private const float WAIT_RETRY_SEC = 2; //Field offset: 0x0
	[Token(Token = "0x400000F")]
	private const int TIME_OUT = 5000; //Field offset: 0x0
	[Token(Token = "0x4000010")]
	private const int MAX_RETRY = 2; //Field offset: 0x0
	[Token(Token = "0x4000011")]
	private static DateTime nextLoginDate; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000009")]
	public bool IsChangeDate; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x400000A")]
	public bool IsUpdateAsset; //Field offset: 0x21
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x400000B")]
	public bool IsUpdateMaster; //Field offset: 0x22
	[FieldOffset(Offset = "0x23")]
	[Token(Token = "0x400000C")]
	public bool IsUpdateClient; //Field offset: 0x23
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000012")]
	private List<String> connectionLists; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000013")]
	private RequestCryptor <Encrypt>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000014")]
	private string <rootURL>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000015")]
	private string <rpcURL>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000016")]
	private string <authURL>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x17000004")]
	public private string authURL
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000018")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000019")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000001")]
	public private RequestCryptor Encrypt
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000007")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000008")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000002")]
	public private string rootURL
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000014")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000015")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000003")]
	public private string rpcURL
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000016")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000017")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1DFF1D0", Offset = "0x1DFE5D0", Length = "0x1D7")]
	[Token(Token = "0x6000010")]
	private HTTPRequest _createHTTPRequest(string url, Method requestType = 2) { }

	[Address(RVA = "0x7A9610", Offset = "0x7A8A10", Length = "0x170")]
	[Token(Token = "0x6000011")]
	private static string _createJsonRequest(string method, T args, string request_id = "") { }

	[Address(RVA = "0x1DFF5B0", Offset = "0x1DFE9B0", Length = "0x20")]
	[Token(Token = "0x6000012")]
	private void _onFinishCallback(HTTPRequest request, HTTPResponse response) { }

	[Address(RVA = "0x1DFF610", Offset = "0x1DFEA10", Length = "0xFC")]
	[Token(Token = "0x6000013")]
	private void _setRawData(HTTPRequest request, string jsonRaw, string label) { }

	[Address(RVA = "0x1DFF160", Offset = "0x1DFE560", Length = "0x6C")]
	[Token(Token = "0x6000020")]
	private static ConnectionManager() { }

	[Address(RVA = "0x1DFF3B0", Offset = "0x1DFE7B0", Length = "0x1F9")]
	[Token(Token = "0x600001F")]
	public ConnectionManager() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000018")]
	public string get_authURL() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000007")]
	public RequestCryptor get_Encrypt() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000014")]
	public string get_rootURL() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000016")]
	public string get_rpcURL() { }

	[Address(RVA = "0x1DFECE0", Offset = "0x1DFE0E0", Length = "0x10")]
	[Token(Token = "0x600001C")]
	public string GetAuthURL() { }

	[Address(RVA = "0x1DFECF0", Offset = "0x1DFE0F0", Length = "0x10")]
	[Token(Token = "0x600001D")]
	public string GetRpcURL() { }

	[Address(RVA = "0x1DFED00", Offset = "0x1DFE100", Length = "0x150")]
	[Token(Token = "0x6000009")]
	public bool IsConnection() { }

	[Address(RVA = "0x1DFEE60", Offset = "0x1DFE260", Length = "0x1A")]
	[Token(Token = "0x600000A")]
	public bool IsReboot() { }

	[Address(RVA = "0x1DFEE80", Offset = "0x1DFE280", Length = "0x4E")]
	[Token(Token = "0x600000D")]
	public DateTime NextLoginDate() { }

	[Address(RVA = "0x7A8E00", Offset = "0x7A8200", Length = "0x4E0")]
	[Token(Token = "0x600000E")]
	public HTTPRequest RequestEntry(RequestParameter<T> parameter) { }

	[Address(RVA = "0x7A9520", Offset = "0x7A8920", Length = "0xE6")]
	[IteratorStateMachine(typeof(<RequestWait>d__21`1))]
	[Token(Token = "0x600000F")]
	public IEnumerator RequestWait(HTTPRequest request, Action<TResult> iResponceFunc, Action<ConnectionError> iErrorFunc, string forceJson = null) { }

	[Address(RVA = "0x1DFEED0", Offset = "0x1DFE2D0", Length = "0x94")]
	[Token(Token = "0x600000C")]
	public void ResetNextLoginDate() { }

	[Address(RVA = "0x1DFEF70", Offset = "0x1DFE370", Length = "0x68")]
	[Token(Token = "0x600001A")]
	public void ResetURL() { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000019")]
	private void set_authURL(string value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000008")]
	private void set_Encrypt(RequestCryptor value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000015")]
	private void set_rootURL(string value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000017")]
	private void set_rpcURL(string value) { }

	[Address(RVA = "0x1DFEFE0", Offset = "0x1DFE3E0", Length = "0x89")]
	[Token(Token = "0x600001E")]
	public ConnectionError SetError(int iErrorCode, int iRetryCount, Dialog errorData) { }

	[Address(RVA = "0x1DFF070", Offset = "0x1DFE470", Length = "0x8F")]
	[Token(Token = "0x600000B")]
	public void SetNextLoginDate(string dateValue) { }

	[Address(RVA = "0x1DFF100", Offset = "0x1DFE500", Length = "0x54")]
	[Token(Token = "0x600001B")]
	public void SetRootURL(string url, string rpc = "", string auth = "") { }

}

