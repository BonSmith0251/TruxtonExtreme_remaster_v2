namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200008C")]
internal class DecalEntityChunk : DecalChunk
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002AE")]
	public Material material; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002AF")]
	public NativeArray<DecalEntity> decalEntities; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002B0")]
	public DecalProjector[] decalProjectors; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002B1")]
	public TransformAccessArray transformAccessArray; //Field offset: 0x48

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000346")]
	public DecalEntityChunk() { }

	[Address(RVA = "0x2D76D00", Offset = "0x2D76100", Length = "0x67")]
	[Token(Token = "0x6000345")]
	public virtual void Dispose() { }

	[Address(RVA = "0xF4D7B0", Offset = "0xF4CBB0", Length = "0x4")]
	[Token(Token = "0x6000342")]
	public virtual void Push() { }

	[Address(RVA = "0x2D76D70", Offset = "0x2D76170", Length = "0x91")]
	[Token(Token = "0x6000343")]
	public virtual void RemoveAtSwapBack(int entityIndex) { }

	[Address(RVA = "0x2D76E10", Offset = "0x2D76210", Length = "0x138")]
	[Token(Token = "0x6000344")]
	public virtual void SetCapacity(int newCapacity) { }

}

