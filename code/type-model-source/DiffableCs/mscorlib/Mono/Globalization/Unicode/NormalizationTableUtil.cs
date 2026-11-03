namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000056")]
internal class NormalizationTableUtil
{
	[Token(Token = "0x400017C")]
	public static readonly CodePointIndexer Prop; //Field offset: 0x0
	[Token(Token = "0x400017D")]
	public static readonly CodePointIndexer Map; //Field offset: 0x8
	[Token(Token = "0x400017E")]
	public static readonly CodePointIndexer Combining; //Field offset: 0x10
	[Token(Token = "0x400017F")]
	public static readonly CodePointIndexer Composite; //Field offset: 0x18
	[Token(Token = "0x4000180")]
	public static readonly CodePointIndexer Helper; //Field offset: 0x20

	[Address(RVA = "0x1E63680", Offset = "0x1E62A80", Length = "0x419")]
	[Token(Token = "0x60000CF")]
	private static NormalizationTableUtil() { }

	[Address(RVA = "0x1E635A0", Offset = "0x1E629A0", Length = "0x67")]
	[Token(Token = "0x60000D1")]
	public static int MapIdx(int cp) { }

	[Address(RVA = "0x1E63610", Offset = "0x1E62A10", Length = "0x66")]
	[Token(Token = "0x60000D0")]
	public static int PropIdx(int cp) { }

}

