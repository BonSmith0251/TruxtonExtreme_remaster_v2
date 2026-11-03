namespace System.Net;

[Token(Token = "0x2000286")]
public class WebProxy : IWebProxy, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A5C")]
	private bool _UseRegistry; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000A5D")]
	private bool _BypassOnLocal; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000A5E")]
	private bool m_EnableAutoproxy; //Field offset: 0x12
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A5F")]
	private Uri _ProxyAddress; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A60")]
	private ArrayList _BypassList; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A61")]
	private ICredentials _Credentials; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A62")]
	private Regex[] _RegExBypassList; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A63")]
	private Hashtable _ProxyHostAddresses; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A64")]
	private AutoWebProxyScriptEngine m_ScriptEngine; //Field offset: 0x40

	[Token(Token = "0x17000398")]
	public override ICredentials Credentials
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001109")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700039A")]
	internal AutoWebProxyScriptEngine ScriptEngine
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001116")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000399")]
	public bool UseDefaultCredentials
	{
		[Address(RVA = "0x26D1460", Offset = "0x26D0860", Length = "0x69")]
		[Token(Token = "0x600110A")]
		 get { } //Length: 105
		[Address(RVA = "0x26D14D0", Offset = "0x26D08D0", Length = "0x343")]
		[Token(Token = "0x600110B")]
		 set { } //Length: 835
	}

	[Address(RVA = "0x26D0FE0", Offset = "0x26D03E0", Length = "0x63")]
	[Token(Token = "0x6001107")]
	public WebProxy() { }

	[Address(RVA = "0x26D1050", Offset = "0x26D0450", Length = "0xC5")]
	[Token(Token = "0x6001108")]
	public WebProxy(Uri Address, bool BypassOnLocal, String[] BypassList, ICredentials Credentials) { }

	[Address(RVA = "0x26D0FB0", Offset = "0x26D03B0", Length = "0x29")]
	[Token(Token = "0x6001118")]
	internal WebProxy(bool enableAutoproxy) { }

	[Address(RVA = "0x26D1120", Offset = "0x26D0520", Length = "0x33F")]
	[Token(Token = "0x6001113")]
	protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26CFFA0", Offset = "0x26CF3A0", Length = "0x17E")]
	[Token(Token = "0x600111C")]
	private static bool AreAllBypassed(IEnumerable<String> proxies, bool checkFirstOnly) { }

	[Address(RVA = "0x26D0120", Offset = "0x26CF520", Length = "0x4C")]
	[Token(Token = "0x6001117")]
	public static IWebProxy CreateDefaultProxy() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001109")]
	public override ICredentials get_Credentials() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001116")]
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	[Address(RVA = "0x26D1460", Offset = "0x26D0860", Length = "0x69")]
	[Token(Token = "0x600110A")]
	public bool get_UseDefaultCredentials() { }

	[Address(RVA = "0x26D0170", Offset = "0x26CF570", Length = "0x14C")]
	[Token(Token = "0x6001115")]
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26D0340", Offset = "0x26CF740", Length = "0x1DC")]
	[Token(Token = "0x600110C")]
	public override Uri GetProxy(Uri destination) { }

	[Address(RVA = "0x26D02C0", Offset = "0x26CF6C0", Length = "0x7B")]
	[Token(Token = "0x600111A")]
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	[Address(RVA = "0x26D0850", Offset = "0x26CFC50", Length = "0xE9")]
	[Token(Token = "0x6001111")]
	public override bool IsBypassed(Uri host) { }

	[Address(RVA = "0x26D0520", Offset = "0x26CF920", Length = "0x58")]
	[Token(Token = "0x600111B")]
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	[Address(RVA = "0x26D0580", Offset = "0x26CF980", Length = "0x2CF")]
	[Token(Token = "0x6001112")]
	private bool IsBypassedManual(Uri host) { }

	[Address(RVA = "0x26D0A30", Offset = "0x26CFE30", Length = "0x178")]
	[Token(Token = "0x600110F")]
	private bool IsLocal(Uri host) { }

	[Address(RVA = "0x26D0940", Offset = "0x26CFD40", Length = "0xE9")]
	[Token(Token = "0x6001110")]
	private bool IsLocalInProxyHash(Uri host) { }

	[Address(RVA = "0x26D0BB0", Offset = "0x26CFFB0", Length = "0x183")]
	[Token(Token = "0x600110E")]
	private bool IsMatchInBypassList(Uri input) { }

	[Address(RVA = "0x26D0D40", Offset = "0x26D0140", Length = "0x89")]
	[Token(Token = "0x600111D")]
	private static Uri ProxyUri(string proxyName) { }

	[Address(RVA = "0x26D14D0", Offset = "0x26D08D0", Length = "0x343")]
	[Token(Token = "0x600110B")]
	public void set_UseDefaultCredentials(bool value) { }

	[Address(RVA = "0x25C7480", Offset = "0x25C6880", Length = "0x2A")]
	[Token(Token = "0x6001114")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0xE0B640", Offset = "0xE0AA40", Length = "0x5")]
	[Token(Token = "0x6001119")]
	internal void UnsafeUpdateFromRegistry() { }

	[Address(RVA = "0x26D0DD0", Offset = "0x26D01D0", Length = "0x1DC")]
	[Token(Token = "0x600110D")]
	private void UpdateRegExList(bool canThrow) { }

}

