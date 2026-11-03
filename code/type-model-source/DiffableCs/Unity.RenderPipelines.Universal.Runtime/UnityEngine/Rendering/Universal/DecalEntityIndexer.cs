namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000089")]
internal class DecalEntityIndexer
{
	[Token(Token = "0x200008A")]
	internal struct DecalEntityItem
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A9")]
		public int chunkIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40002AA")]
		public int arrayIndex; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002AB")]
		public int version; //Field offset: 0x8

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A7")]
	private List<DecalEntityItem> m_Entities; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002A8")]
	private Queue<Int32> m_FreeIndices; //Field offset: 0x18

	[Address(RVA = "0x2D77590", Offset = "0x2D76990", Length = "0xBD")]
	[Token(Token = "0x6000341")]
	public DecalEntityIndexer() { }

	[Address(RVA = "0x2D76F50", Offset = "0x2D76350", Length = "0x63")]
	[Token(Token = "0x6000340")]
	public void Clear() { }

	[Address(RVA = "0x2D76FC0", Offset = "0x2D763C0", Length = "0x1ED")]
	[Token(Token = "0x600033B")]
	public DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex) { }

	[Address(RVA = "0x2D771B0", Offset = "0x2D765B0", Length = "0xBE")]
	[Token(Token = "0x600033C")]
	public void DestroyDecalEntity(DecalEntity decalEntity) { }

	[Address(RVA = "0x2D77270", Offset = "0x2D76670", Length = "0x7A")]
	[Token(Token = "0x600033D")]
	public DecalEntityItem GetItem(DecalEntity decalEntity) { }

	[Address(RVA = "0x2D772F0", Offset = "0x2D766F0", Length = "0x8A")]
	[Token(Token = "0x600033A")]
	public bool IsValid(DecalEntity decalEntity) { }

	[Address(RVA = "0x2D77380", Offset = "0x2D76780", Length = "0x144")]
	[Token(Token = "0x600033F")]
	public void RemapChunkIndices(List<Int32> remaper) { }

	[Address(RVA = "0x2D774D0", Offset = "0x2D768D0", Length = "0xB7")]
	[Token(Token = "0x600033E")]
	public void UpdateIndex(DecalEntity decalEntity, int newArrayIndex) { }

}

