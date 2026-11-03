namespace System.Xml;

[Token(Token = "0x20000CD")]
internal class XmlCachedStream : MemoryStream
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400056E")]
	private Uri uri; //Field offset: 0x50

	[Address(RVA = "0x254FFD0", Offset = "0x254F3D0", Length = "0x15A")]
	[Token(Token = "0x6000B15")]
	internal XmlCachedStream(Uri uri, Stream stream) { }

}

