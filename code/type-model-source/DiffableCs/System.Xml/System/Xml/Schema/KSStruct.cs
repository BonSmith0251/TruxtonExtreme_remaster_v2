namespace System.Xml.Schema;

[Token(Token = "0x2000159")]
internal class KSStruct
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000741")]
	public int depth; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000742")]
	public KeySequence ks; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000743")]
	public LocatedActiveAxis[] fields; //Field offset: 0x20

	[Address(RVA = "0x2583550", Offset = "0x2582950", Length = "0x7B")]
	[Token(Token = "0x6000ED7")]
	public KSStruct(KeySequence ks, int dim) { }

}

