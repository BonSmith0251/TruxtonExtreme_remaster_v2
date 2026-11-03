namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200017A")]
internal class OutPt
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000645")]
	public Point64 pt; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Nullable(2)]
	[Token(Token = "0x4000646")]
	public OutPt next; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000647")]
	public OutPt prev; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000648")]
	public OutRec outrec; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Nullable(2)]
	[Token(Token = "0x4000649")]
	public Joiner joiner; //Field offset: 0x38

	[Address(RVA = "0x289C6C0", Offset = "0x289BAC0", Length = "0x78")]
	[Token(Token = "0x6000769")]
	public OutPt(Point64 pt, OutRec outrec) { }

}

