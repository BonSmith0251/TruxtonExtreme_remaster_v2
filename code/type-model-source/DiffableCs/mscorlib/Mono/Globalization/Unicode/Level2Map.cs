namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000052")]
internal class Level2Map
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400015E")]
	public byte Source; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400015F")]
	public byte Replace; //Field offset: 0x11

	[Address(RVA = "0x1E60110", Offset = "0x1E5F510", Length = "0x37")]
	[Token(Token = "0x60000B5")]
	public Level2Map(byte source, byte replace) { }

}

