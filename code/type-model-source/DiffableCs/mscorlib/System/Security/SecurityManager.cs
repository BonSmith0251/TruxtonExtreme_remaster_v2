namespace System.Security;

[ComVisible(True)]
[Token(Token = "0x20002D5")]
public static class SecurityManager
{

	[Obsolete("The security manager cannot be turned off on MS runtime")]
	[Token(Token = "0x17000259")]
	public static bool SecurityEnabled
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017D2")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60017D3")]
	internal static void EnsureElevatedPermissions() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60017D2")]
	public static bool get_SecurityEnabled() { }

}

