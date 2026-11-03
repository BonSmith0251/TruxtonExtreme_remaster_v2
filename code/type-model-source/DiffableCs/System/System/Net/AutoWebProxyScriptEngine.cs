namespace System.Net;

[Token(Token = "0x2000287")]
internal class AutoWebProxyScriptEngine
{

	[Address(RVA = "0x26B34F0", Offset = "0x26B28F0", Length = "0x1C")]
	[Token(Token = "0x600111E")]
	public bool GetProxies(Uri destination, out IList<String>& proxyList) { }

	[Address(RVA = "0x26B34F0", Offset = "0x26B28F0", Length = "0x1C")]
	[Token(Token = "0x600111F")]
	public bool GetProxies(Uri destination, out IList<String>& proxyList, ref int syncStatus) { }

}

