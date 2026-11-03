namespace UnityEngine.Rendering;

[Token(Token = "0x200003B")]
internal struct DrawKey : IEquatable<DrawKey>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C7")]
	public BatchMeshID meshID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000C8")]
	public int submeshIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000C9")]
	public int activeMeshLod; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000CA")]
	public BatchMaterialID materialID; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000CB")]
	public BatchDrawCommandFlags flags; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000CC")]
	public int transparentInstanceId; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000CD")]
	public uint overridenComponents; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000CE")]
	public RangeKey range; //Field offset: 0x1C
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000CF")]
	public int lightmapIndex; //Field offset: 0x38

	[Address(RVA = "0x2CC6500", Offset = "0x2CC5900", Length = "0x1E5")]
	[Token(Token = "0x600012B")]
	public override bool Equals(DrawKey other) { }

	[Address(RVA = "0x2CC66F0", Offset = "0x2CC5AF0", Length = "0x91")]
	[Token(Token = "0x600012C")]
	public virtual int GetHashCode() { }

}

