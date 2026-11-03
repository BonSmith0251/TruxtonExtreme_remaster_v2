namespace KANAI.Kernel;

[Token(Token = "0x2000033")]
public class SimpleSingleton
{
	[Token(Token = "0x40000D8")]
	private static T _instance; //Field offset: 0x0

	[Token(Token = "0x1700002A")]
	public static T GetInstance
	{
		[Address(RVA = "0xD10490", Offset = "0xD0F890", Length = "0x50")]
		[Token(Token = "0x60001A6")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000029")]
	public static T Instance
	{
		[Address(RVA = "0xD10490", Offset = "0xD0F890", Length = "0x50")]
		[Token(Token = "0x60001A5")]
		 get { } //Length: 80
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001AA")]
	public SimpleSingleton`1() { }

	[Address(RVA = "0xF62640", Offset = "0xF61A40", Length = "0x16C")]
	[Token(Token = "0x60001A7")]
	public static T CreateInstance() { }

	[Address(RVA = "0xD10490", Offset = "0xD0F890", Length = "0x50")]
	[Token(Token = "0x60001A6")]
	public static T get_GetInstance() { }

	[Address(RVA = "0xD10490", Offset = "0xD0F890", Length = "0x50")]
	[Token(Token = "0x60001A5")]
	public static T get_Instance() { }

	[Address(RVA = "0xD102F0", Offset = "0xD0F6F0", Length = "0x48")]
	[Token(Token = "0x60001A9")]
	public static bool IsInstanceNull() { }

	[Address(RVA = "0xD103A0", Offset = "0xD0F7A0", Length = "0x46")]
	[Token(Token = "0x60001A8")]
	public static void ResetInstance() { }

}

