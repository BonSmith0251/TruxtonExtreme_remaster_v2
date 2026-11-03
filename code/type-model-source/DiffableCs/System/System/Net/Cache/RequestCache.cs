namespace System.Net.Cache;

[Token(Token = "0x20002EE")]
internal abstract class RequestCache
{
	[Token(Token = "0x4000CBE")]
	internal static readonly Char[] LineSplits; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CBF")]
	private bool _IsPrivateCache; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000CC0")]
	private bool _CanWrite; //Field offset: 0x11

	[Address(RVA = "0x25E1B50", Offset = "0x25E0F50", Length = "0x90")]
	[Token(Token = "0x6001371")]
	private static RequestCache() { }

}

