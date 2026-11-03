namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005C4")]
internal struct DepthOrderedDirtyTracking
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001498")]
	public RenderTree owner; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001499")]
	public List<RenderData> heads; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400149A")]
	public List<RenderData> tails; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400149B")]
	public Int32[] minDepths; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400149C")]
	public Int32[] maxDepths; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400149D")]
	public uint dirtyID; //Field offset: 0x28

	[Address(RVA = "0x3302F50", Offset = "0x3302350", Length = "0x1C3")]
	[Token(Token = "0x600296D")]
	public void ClearDirty(RenderData renderData, RenderDataDirtyTypes dirtyTypesInverse) { }

	[Address(RVA = "0x3303120", Offset = "0x3302520", Length = "0x14A")]
	[Token(Token = "0x600296B")]
	public void EnsureFits(int maxDepth) { }

	[Address(RVA = "0x3303270", Offset = "0x3302670", Length = "0x1E1")]
	[Token(Token = "0x600296C")]
	public void RegisterDirty(RenderData renderData, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass) { }

	[Address(RVA = "0x3303460", Offset = "0x3302860", Length = "0x74")]
	[Token(Token = "0x600296E")]
	public void Reset() { }

}

