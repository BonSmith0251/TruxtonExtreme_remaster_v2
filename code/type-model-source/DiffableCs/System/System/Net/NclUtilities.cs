namespace System.Net;

[Token(Token = "0x200024A")]
internal static class NclUtilities
{
	[Token(Token = "0x400092B")]
	private static IPAddress[] _LocalAddresses; //Field offset: 0x0
	[Token(Token = "0x400092C")]
	private static object _LocalAddressesLock; //Field offset: 0x8
	[Token(Token = "0x400092D")]
	internal static string _LocalDomainName; //Field offset: 0x10

	[Token(Token = "0x1700032B")]
	internal static IPAddress[] LocalAddresses
	{
		[Address(RVA = "0x26AB070", Offset = "0x26AA470", Length = "0x50B")]
		[Token(Token = "0x6000F73")]
		internal get { } //Length: 1291
	}

	[Token(Token = "0x1700032C")]
	private static object LocalAddressesLock
	{
		[Address(RVA = "0x26AAFD0", Offset = "0x26AA3D0", Length = "0x9B")]
		[Token(Token = "0x6000F74")]
		private get { } //Length: 155
	}

	[Address(RVA = "0x26AB070", Offset = "0x26AA470", Length = "0x50B")]
	[Token(Token = "0x6000F73")]
	internal static IPAddress[] get_LocalAddresses() { }

	[Address(RVA = "0x26AAFD0", Offset = "0x26AA3D0", Length = "0x9B")]
	[Token(Token = "0x6000F74")]
	private static object get_LocalAddressesLock() { }

	[Address(RVA = "0x26AAE70", Offset = "0x26AA270", Length = "0x19")]
	[Token(Token = "0x6000F72")]
	private static IPHostEntry GetLocalHost() { }

	[Address(RVA = "0x26AAE90", Offset = "0x26AA290", Length = "0x84")]
	[Token(Token = "0x6000F71")]
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	[Address(RVA = "0x26AAF20", Offset = "0x26AA320", Length = "0xA8")]
	[Token(Token = "0x6000F70")]
	internal static bool IsFatal(Exception exception) { }

}

