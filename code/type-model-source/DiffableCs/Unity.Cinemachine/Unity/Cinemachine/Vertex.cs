namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x2000176")]
internal class Vertex
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400063B")]
	public readonly Point64 pt; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400063C")]
	public Vertex next; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400063D")]
	public Vertex prev; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400063E")]
	public VertexFlags flags; //Field offset: 0x30

	[Address(RVA = "0x289D400", Offset = "0x289C800", Length = "0xB14")]
	[Token(Token = "0x6000761")]
	public Vertex(Point64 pt, VertexFlags flags, Vertex prev) { }

}

