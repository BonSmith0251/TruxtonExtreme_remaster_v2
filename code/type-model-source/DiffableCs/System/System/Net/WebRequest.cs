namespace System.Net;

[Token(Token = "0x200025C")]
public abstract class WebRequest : MarshalByRefObject, ISerializable
{
	[CompilerGenerated]
	[Token(Token = "0x200025E")]
	private sealed class <>c__DisplayClass79_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009AA")]
		public WindowsIdentity currentUser; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009AB")]
		public WebRequest <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001002")]
		public <>c__DisplayClass79_0() { }

		[Address(RVA = "0x26AD870", Offset = "0x26ACC70", Length = "0x22F")]
		[Token(Token = "0x6001003")]
		internal Task<WebResponse> <GetResponseAsync>b__1() { }

	}

	[Token(Token = "0x200025D")]
	public class DesignerWebRequestCreate : IWebRequestCreate
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001001")]
		public DesignerWebRequestCreate() { }

		[Address(RVA = "0x269A7A0", Offset = "0x2699BA0", Length = "0xF7")]
		[Token(Token = "0x6001000")]
		public override WebRequest Create(Uri uri) { }

	}

	[Token(Token = "0x400099E")]
	internal const int DefaultTimeout = 100000; //Field offset: 0x0
	[Token(Token = "0x400099F")]
	private static ArrayList s_PrefixList; //Field offset: 0x0
	[Token(Token = "0x40009A0")]
	private static object s_InternalSyncObject; //Field offset: 0x8
	[Token(Token = "0x40009A1")]
	private static Queue s_DefaultTimerQueue; //Field offset: 0x10
	[Token(Token = "0x40009A7")]
	private static DesignerWebRequestCreate webRequestCreate; //Field offset: 0x18
	[Token(Token = "0x40009A8")]
	private static IWebProxy s_DefaultWebProxy; //Field offset: 0x20
	[Token(Token = "0x40009A9")]
	private static bool s_DefaultWebProxyInitialized; //Field offset: 0x28
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009A2")]
	private AuthenticationLevel m_AuthenticationLevel; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40009A3")]
	private TokenImpersonationLevel m_ImpersonationLevel; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009A4")]
	private RequestCachePolicy m_CachePolicy; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009A5")]
	private RequestCacheProtocol m_CacheProtocol; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009A6")]
	private RequestCacheBinding m_CacheBinding; //Field offset: 0x30

	[Token(Token = "0x17000341")]
	public override RequestCachePolicy CachePolicy
	{
		[Address(RVA = "0x26B1940", Offset = "0x26B0D40", Length = "0xD8")]
		[Token(Token = "0x6000FE3")]
		 set { } //Length: 216
	}

	[Token(Token = "0x1700034B")]
	internal RequestCacheProtocol CacheProtocol
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000FFB")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000FFC")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000345")]
	public override long ContentLength
	{
		[Address(RVA = "0x26B1F30", Offset = "0x26B1330", Length = "0x27")]
		[Token(Token = "0x6000FE9")]
		 get { } //Length: 39
		[Address(RVA = "0x26B2540", Offset = "0x26B1940", Length = "0x27")]
		[Token(Token = "0x6000FEA")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000346")]
	public override string ContentType
	{
		[Address(RVA = "0x26B2570", Offset = "0x26B1970", Length = "0x27")]
		[Token(Token = "0x6000FEB")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000347")]
	public override ICredentials Credentials
	{
		[Address(RVA = "0x26B1F60", Offset = "0x26B1360", Length = "0x27")]
		[Token(Token = "0x6000FEC")]
		 get { } //Length: 39
		[Address(RVA = "0x26B25A0", Offset = "0x26B19A0", Length = "0x27")]
		[Token(Token = "0x6000FED")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000344")]
	public override WebHeaderCollection Headers
	{
		[Address(RVA = "0x26B1F90", Offset = "0x26B1390", Length = "0x27")]
		[Token(Token = "0x6000FE8")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700034C")]
	internal static IWebProxy InternalDefaultWebProxy
	{
		[Address(RVA = "0x26B1FC0", Offset = "0x26B13C0", Length = "0x1E4")]
		[Token(Token = "0x6000FFD")]
		internal get { } //Length: 484
	}

	[Token(Token = "0x1700033F")]
	private static object InternalSyncObject
	{
		[Address(RVA = "0x26B21B0", Offset = "0x26B15B0", Length = "0xEA")]
		[Token(Token = "0x6000FD9")]
		private get { } //Length: 234
	}

	[Token(Token = "0x17000342")]
	public override string Method
	{
		[Address(RVA = "0x26B22A0", Offset = "0x26B16A0", Length = "0x27")]
		[Token(Token = "0x6000FE5")]
		 get { } //Length: 39
		[Address(RVA = "0x26B25D0", Offset = "0x26B19D0", Length = "0x27")]
		[Token(Token = "0x6000FE6")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000340")]
	internal static ArrayList PrefixList
	{
		[Address(RVA = "0x26B22D0", Offset = "0x26B16D0", Length = "0x1A7")]
		[Token(Token = "0x6000FDD")]
		internal get { } //Length: 423
	}

	[Token(Token = "0x17000349")]
	public override IWebProxy Proxy
	{
		[Address(RVA = "0x26B2480", Offset = "0x26B1880", Length = "0x27")]
		[Token(Token = "0x6000FF0")]
		 get { } //Length: 39
		[Address(RVA = "0x26B2600", Offset = "0x26B1A00", Length = "0x27")]
		[Token(Token = "0x6000FF1")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000343")]
	public override Uri RequestUri
	{
		[Address(RVA = "0x26B24B0", Offset = "0x26B18B0", Length = "0x27")]
		[Token(Token = "0x6000FE7")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700034A")]
	public override int Timeout
	{
		[Address(RVA = "0x26B24E0", Offset = "0x26B18E0", Length = "0x27")]
		[Token(Token = "0x6000FF2")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000348")]
	public override bool UseDefaultCredentials
	{
		[Address(RVA = "0x26B2510", Offset = "0x26B1910", Length = "0x27")]
		[Token(Token = "0x6000FEE")]
		 get { } //Length: 39
		[Address(RVA = "0x26B2630", Offset = "0x26B1A30", Length = "0x27")]
		[Token(Token = "0x6000FEF")]
		 set { } //Length: 39
	}

	[Address(RVA = "0x26B1E20", Offset = "0x26B1220", Length = "0xD1")]
	[Token(Token = "0x6000FFE")]
	private static WebRequest() { }

	[Address(RVA = "0x26B1F00", Offset = "0x26B1300", Length = "0x24")]
	[Token(Token = "0x6000FDF")]
	protected WebRequest() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000FE0")]
	protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26B1D20", Offset = "0x26B1120", Length = "0xF5")]
	[CompilerGenerated]
	[Token(Token = "0x6000FFF")]
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }

	[Address(RVA = "0x26B1160", Offset = "0x26B0560", Length = "0x27")]
	[Token(Token = "0x6000FFA")]
	public override void Abort() { }

	[Address(RVA = "0x26B1190", Offset = "0x26B0590", Length = "0x27")]
	[Token(Token = "0x6000FF6")]
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	[Address(RVA = "0x26B11C0", Offset = "0x26B05C0", Length = "0x27")]
	[Token(Token = "0x6000FF4")]
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	[Address(RVA = "0x26B11F0", Offset = "0x26B05F0", Length = "0x2B2")]
	[Token(Token = "0x6000FDA")]
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	[Address(RVA = "0x26B1580", Offset = "0x26B0980", Length = "0xCC")]
	[Token(Token = "0x6000FDB")]
	public static WebRequest Create(string requestUriString) { }

	[Address(RVA = "0x26B14B0", Offset = "0x26B08B0", Length = "0xC6")]
	[Token(Token = "0x6000FDC")]
	public static WebRequest Create(Uri requestUri) { }

	[Address(RVA = "0x26B1650", Offset = "0x26B0A50", Length = "0x27")]
	[Token(Token = "0x6000FF7")]
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26B1680", Offset = "0x26B0A80", Length = "0x27")]
	[Token(Token = "0x6000FF5")]
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000FFB")]
	internal RequestCacheProtocol get_CacheProtocol() { }

	[Address(RVA = "0x26B1F30", Offset = "0x26B1330", Length = "0x27")]
	[Token(Token = "0x6000FE9")]
	public override long get_ContentLength() { }

	[Address(RVA = "0x26B1F60", Offset = "0x26B1360", Length = "0x27")]
	[Token(Token = "0x6000FEC")]
	public override ICredentials get_Credentials() { }

	[Address(RVA = "0x26B1F90", Offset = "0x26B1390", Length = "0x27")]
	[Token(Token = "0x6000FE8")]
	public override WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x26B1FC0", Offset = "0x26B13C0", Length = "0x1E4")]
	[Token(Token = "0x6000FFD")]
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	[Address(RVA = "0x26B21B0", Offset = "0x26B15B0", Length = "0xEA")]
	[Token(Token = "0x6000FD9")]
	private static object get_InternalSyncObject() { }

	[Address(RVA = "0x26B22A0", Offset = "0x26B16A0", Length = "0x27")]
	[Token(Token = "0x6000FE5")]
	public override string get_Method() { }

	[Address(RVA = "0x26B22D0", Offset = "0x26B16D0", Length = "0x1A7")]
	[Token(Token = "0x6000FDD")]
	internal static ArrayList get_PrefixList() { }

	[Address(RVA = "0x26B2480", Offset = "0x26B1880", Length = "0x27")]
	[Token(Token = "0x6000FF0")]
	public override IWebProxy get_Proxy() { }

	[Address(RVA = "0x26B24B0", Offset = "0x26B18B0", Length = "0x27")]
	[Token(Token = "0x6000FE7")]
	public override Uri get_RequestUri() { }

	[Address(RVA = "0x26B24E0", Offset = "0x26B18E0", Length = "0x27")]
	[Token(Token = "0x6000FF2")]
	public override int get_Timeout() { }

	[Address(RVA = "0x26B2510", Offset = "0x26B1910", Length = "0x27")]
	[Token(Token = "0x6000FEE")]
	public override bool get_UseDefaultCredentials() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000FE2")]
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26B1910", Offset = "0x26B0D10", Length = "0x27")]
	[Token(Token = "0x6000FF3")]
	public override WebResponse GetResponse() { }

	[Address(RVA = "0x26B16B0", Offset = "0x26B0AB0", Length = "0x257")]
	[Token(Token = "0x6000FF8")]
	public override Task<WebResponse> GetResponseAsync() { }

	[Address(RVA = "0x26B1940", Offset = "0x26B0D40", Length = "0xD8")]
	[Token(Token = "0x6000FE4")]
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	[Address(RVA = "0x26B1A20", Offset = "0x26B0E20", Length = "0x280")]
	[Token(Token = "0x6000FDE")]
	private static ArrayList PopulatePrefixList() { }

	[Address(RVA = "0x26B1CB0", Offset = "0x26B10B0", Length = "0x40")]
	[Token(Token = "0x6000FF9")]
	private WindowsIdentity SafeCaptureIdenity() { }

	[Address(RVA = "0x26B1940", Offset = "0x26B0D40", Length = "0xD8")]
	[Token(Token = "0x6000FE3")]
	public override void set_CachePolicy(RequestCachePolicy value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000FFC")]
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	[Address(RVA = "0x26B2540", Offset = "0x26B1940", Length = "0x27")]
	[Token(Token = "0x6000FEA")]
	public override void set_ContentLength(long value) { }

	[Address(RVA = "0x26B2570", Offset = "0x26B1970", Length = "0x27")]
	[Token(Token = "0x6000FEB")]
	public override void set_ContentType(string value) { }

	[Address(RVA = "0x26B25A0", Offset = "0x26B19A0", Length = "0x27")]
	[Token(Token = "0x6000FED")]
	public override void set_Credentials(ICredentials value) { }

	[Address(RVA = "0x26B25D0", Offset = "0x26B19D0", Length = "0x27")]
	[Token(Token = "0x6000FE6")]
	public override void set_Method(string value) { }

	[Address(RVA = "0x26B2600", Offset = "0x26B1A00", Length = "0x27")]
	[Token(Token = "0x6000FF1")]
	public override void set_Proxy(IWebProxy value) { }

	[Address(RVA = "0x26B2630", Offset = "0x26B1A30", Length = "0x27")]
	[Token(Token = "0x6000FEF")]
	public override void set_UseDefaultCredentials(bool value) { }

	[Address(RVA = "0x26B1CF0", Offset = "0x26B10F0", Length = "0x2A")]
	[Token(Token = "0x6000FE1")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

