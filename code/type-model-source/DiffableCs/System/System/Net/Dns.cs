namespace System.Net;

[Token(Token = "0x200029B")]
public static class Dns
{
	[Token(Token = "0x200029C")]
	private sealed class GetHostAddressesCallback : MulticastDelegate
	{

		[Address(RVA = "0x10DF120", Offset = "0x10DE520", Length = "0xB4")]
		[Token(Token = "0x6001171")]
		public GetHostAddressesCallback(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x6001173")]
		public override IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6001174")]
		public override IPAddress[] EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001172")]
		public override IPAddress[] Invoke(string hostName) { }

	}


	[Address(RVA = "0x26BFE80", Offset = "0x26BF280", Length = "0x21A")]
	[Token(Token = "0x6001163")]
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	[Address(RVA = "0x26C00A0", Offset = "0x26BF4A0", Length = "0x105")]
	[Token(Token = "0x6001164")]
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26C01B0", Offset = "0x26BF5B0", Length = "0x6B")]
	[Token(Token = "0x6001168")]
	private static void Error_11001(string hostName) { }

	[Address(RVA = "0x26C0330", Offset = "0x26BF730", Length = "0x20B")]
	[Token(Token = "0x600116D")]
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	[Address(RVA = "0x26C0220", Offset = "0x26BF620", Length = "0x109")]
	[Token(Token = "0x6001170")]
	public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { }

	[Address(RVA = "0x26C0540", Offset = "0x26BF940", Length = "0x5")]
	[Token(Token = "0x6001166")]
	private static bool GetHostByAddr_icall(string addr, out string h_name, out String[] h_aliases, out String[] h_addr_list, int hint) { }

	[Address(RVA = "0x26C0550", Offset = "0x26BF950", Length = "0x125")]
	[Token(Token = "0x600116A")]
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	[Address(RVA = "0x26C0690", Offset = "0x26BFA90", Length = "0xF0")]
	[Obsolete("Use GetHostEntry instead")]
	[Token(Token = "0x600116E")]
	public static IPHostEntry GetHostByName(string hostName) { }

	[Address(RVA = "0x26C0680", Offset = "0x26BFA80", Length = "0x5")]
	[Token(Token = "0x6001165")]
	private static bool GetHostByName_icall(string host, out string h_name, out String[] h_aliases, out String[] h_addr_list, int hint) { }

	[Address(RVA = "0x26C0790", Offset = "0x26BFB90", Length = "0x32A")]
	[Token(Token = "0x600116B")]
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	[Address(RVA = "0x26C0AC0", Offset = "0x26BFEC0", Length = "0x157")]
	[Token(Token = "0x600116C")]
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	[Address(RVA = "0x26C0C30", Offset = "0x26C0030", Length = "0x31")]
	[Token(Token = "0x600116F")]
	public static string GetHostName() { }

	[Address(RVA = "0x26C0C20", Offset = "0x26C0020", Length = "0x5")]
	[Token(Token = "0x6001167")]
	private static bool GetHostName_icall(out string h_name) { }

	[Address(RVA = "0x26C0C70", Offset = "0x26C0070", Length = "0x2CC")]
	[Token(Token = "0x6001169")]
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, String[] h_aliases, String[] h_addrlist) { }

}

