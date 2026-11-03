namespace System.Text;

[Token(Token = "0x20002AE")]
public abstract class EncodingProvider
{
	[Token(Token = "0x4000B9C")]
	private static object s_InternalSyncObject; //Field offset: 0x0
	[Token(Token = "0x4000B9D")]
	private static EncodingProvider[] s_providers; //Field offset: 0x8

	[Address(RVA = "0x1E8EA60", Offset = "0x1E8DE60", Length = "0x73")]
	[Token(Token = "0x6001600")]
	private static EncodingProvider() { }

	[Token(Token = "0x60015FA")]
	public abstract Encoding GetEncoding(string name) { }

	[Token(Token = "0x60015FB")]
	public abstract Encoding GetEncoding(int codepage) { }

	[Address(RVA = "0x1E8E940", Offset = "0x1E8DD40", Length = "0x118")]
	[Token(Token = "0x60015FC")]
	public override Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	[Address(RVA = "0x1E8E740", Offset = "0x1E8DB40", Length = "0xFA")]
	[Token(Token = "0x60015FD")]
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	[Address(RVA = "0x1E8E840", Offset = "0x1E8DC40", Length = "0xFC")]
	[Token(Token = "0x60015FE")]
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	[Address(RVA = "0x1E8E620", Offset = "0x1E8DA20", Length = "0x11A")]
	[Token(Token = "0x60015FF")]
	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec) { }

}

