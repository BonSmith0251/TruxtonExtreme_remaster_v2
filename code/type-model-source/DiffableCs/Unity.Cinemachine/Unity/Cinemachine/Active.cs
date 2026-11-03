namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x200017D")]
internal class Active
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400065A")]
	public Point64 bot; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400065B")]
	public Point64 top; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400065C")]
	public long curX; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400065D")]
	public double dx; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400065E")]
	public int windDx; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400065F")]
	public int windCount; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000660")]
	public int windCount2; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000661")]
	public OutRec outrec; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000662")]
	public Active prevInAEL; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000663")]
	public Active nextInAEL; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000664")]
	public Active prevInSEL; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000665")]
	public Active nextInSEL; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000666")]
	public Active jump; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000667")]
	public Vertex vertexTop; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000668")]
	public LocalMinima localMin; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000669")]
	internal bool isLeftBound; //Field offset: 0x98

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600076C")]
	public Active() { }

}

