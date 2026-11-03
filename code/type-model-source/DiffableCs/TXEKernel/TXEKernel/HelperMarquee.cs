namespace TXEKernel;

[Token(Token = "0x200003B")]
public static class HelperMarquee
{

	[Address(RVA = "0x26DA020", Offset = "0x26D9420", Length = "0x95")]
	[Token(Token = "0x60001AB")]
	public static void Clear() { }

	[Address(RVA = "0x26D9F90", Offset = "0x26D9390", Length = "0x89")]
	[Token(Token = "0x60001AC")]
	public static void ClearString() { }

	[Address(RVA = "0x26DA0C0", Offset = "0x26D94C0", Length = "0xC3")]
	[Token(Token = "0x60001AD")]
	public static void Set(string skey, bool isDirect = false) { }

}

