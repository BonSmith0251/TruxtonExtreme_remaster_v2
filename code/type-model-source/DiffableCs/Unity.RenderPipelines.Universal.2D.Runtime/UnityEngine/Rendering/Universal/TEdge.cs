namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000019")]
internal class TEdge
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000047")]
	internal IntPoint Bot; //Field offset: 0x10
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000048")]
	internal IntPoint Curr; //Field offset: 0x40
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000049")]
	internal IntPoint Top; //Field offset: 0x70
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400004A")]
	internal IntPoint Delta; //Field offset: 0xA0
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400004B")]
	internal double Dx; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400004C")]
	internal PolyTypes PolyTyp; //Field offset: 0xD8
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x400004D")]
	internal EdgeSides Side; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400004E")]
	internal int WindDelta; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x400004F")]
	internal int WindCnt; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000050")]
	internal int WindCnt2; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000051")]
	internal int OutIdx; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000052")]
	internal TEdge Next; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000053")]
	internal TEdge Prev; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000054")]
	internal TEdge NextInLML; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000055")]
	internal TEdge NextInAEL; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000056")]
	internal TEdge PrevInAEL; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000057")]
	internal TEdge NextInSEL; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000058")]
	internal TEdge PrevInSEL; //Field offset: 0x120

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000034")]
	public TEdge() { }

}

