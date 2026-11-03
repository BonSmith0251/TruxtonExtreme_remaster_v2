namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x200017B")]
internal class OutRec
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400064A")]
	public int idx; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400064B")]
	public OutRec owner; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400064C")]
	public List<OutRec> splits; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400064D")]
	public Active frontEdge; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400064E")]
	public Active backEdge; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400064F")]
	public OutPt pts; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000650")]
	public PolyPathBase polypath; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000651")]
	public Rect64 bounds; //Field offset: 0x48
	[FieldOffset(Offset = "0x68")]
	[Nullable(1)]
	[Token(Token = "0x4000652")]
	public List<Point64> path; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000653")]
	public bool isOpen; //Field offset: 0x70

	[Address(RVA = "0x289C740", Offset = "0x289BB40", Length = "0x82")]
	[Token(Token = "0x600076A")]
	public OutRec() { }

}

