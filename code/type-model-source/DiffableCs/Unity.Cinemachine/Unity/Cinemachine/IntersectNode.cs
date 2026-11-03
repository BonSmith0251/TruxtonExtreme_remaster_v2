namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000178")]
internal struct IntersectNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000642")]
	public readonly Point64 pt; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000643")]
	public readonly Active edge1; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000644")]
	public readonly Active edge2; //Field offset: 0x18

	[Address(RVA = "0x289C3C0", Offset = "0x289B7C0", Length = "0x40")]
	[Token(Token = "0x6000767")]
	public IntersectNode(Point64 pt, Active edge1, Active edge2) { }

}

