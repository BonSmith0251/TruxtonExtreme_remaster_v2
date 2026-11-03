namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000020")]
internal class OutPt
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400006C")]
	internal int Idx; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400006D")]
	internal IntPoint Pt; //Field offset: 0x18
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400006E")]
	internal OutPt Next; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400006F")]
	internal OutPt Prev; //Field offset: 0x50

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600003C")]
	public OutPt() { }

}

