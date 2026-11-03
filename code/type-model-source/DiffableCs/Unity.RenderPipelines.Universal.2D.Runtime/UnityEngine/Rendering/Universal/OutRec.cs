namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200001F")]
internal class OutRec
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000065")]
	internal int Idx; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000066")]
	internal bool IsHole; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x4000067")]
	internal bool IsOpen; //Field offset: 0x15
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000068")]
	internal OutRec FirstLeft; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000069")]
	internal OutPt Pts; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400006A")]
	internal OutPt BottomPt; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400006B")]
	internal PolyNode PolyNode; //Field offset: 0x30

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600003B")]
	public OutRec() { }

}

