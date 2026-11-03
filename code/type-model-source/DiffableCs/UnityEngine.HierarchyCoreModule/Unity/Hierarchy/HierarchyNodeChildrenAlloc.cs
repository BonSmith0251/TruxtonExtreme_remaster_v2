namespace Unity.Hierarchy;

[Token(Token = "0x2000008")]
internal struct HierarchyNodeChildrenAlloc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000F")]
	public HierarchyNode* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000010")]
	public int Size; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000011")]
	public int Capacity; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000012")]
	public int ControlBit; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000013")]
	public int NullCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000014")]
	public int Reserved0; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000015")]
	public int Reserved1; //Field offset: 0x1C

}

