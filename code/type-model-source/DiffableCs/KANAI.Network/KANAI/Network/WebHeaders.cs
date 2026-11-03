namespace KANAI.Network;

[Token(Token = "0x2000019")]
public static class WebHeaders
{
	[Token(Token = "0x4000072")]
	public static readonly string ContentType; //Field offset: 0x0
	[Token(Token = "0x4000073")]
	public static readonly string Authorization; //Field offset: 0x8
	[Token(Token = "0x4000074")]
	public static readonly string Platform; //Field offset: 0x10
	[Token(Token = "0x4000075")]
	public static readonly string Version; //Field offset: 0x18
	[Token(Token = "0x4000076")]
	public static readonly string UnityVersion; //Field offset: 0x20
	[Token(Token = "0x4000077")]
	public static readonly string DeviceName; //Field offset: 0x28
	[Token(Token = "0x4000078")]
	public static readonly string UserID; //Field offset: 0x30

	[Address(RVA = "0x1E037B0", Offset = "0x1E02BB0", Length = "0x1F4")]
	[Token(Token = "0x600008C")]
	private static WebHeaders() { }

	[Address(RVA = "0x1E034B0", Offset = "0x1E028B0", Length = "0x7")]
	[Token(Token = "0x6000089")]
	public static string GetDeviceName() { }

	[Address(RVA = "0x1E034C0", Offset = "0x1E028C0", Length = "0x2C")]
	[Token(Token = "0x6000088")]
	public static string GetPlatformID() { }

	[Address(RVA = "0x1E034F0", Offset = "0x1E028F0", Length = "0x2C")]
	[Token(Token = "0x600008A")]
	public static string GetToken() { }

	[Address(RVA = "0x1E03520", Offset = "0x1E02920", Length = "0x2C")]
	[Token(Token = "0x600008B")]
	public static string GetUserID() { }

	[Address(RVA = "0x1E03550", Offset = "0x1E02950", Length = "0x250")]
	[Token(Token = "0x6000087")]
	public static Dictionary<String, String> Headers() { }

}

