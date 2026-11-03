namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000095")]
internal class DecalCulledChunk : DecalChunk
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002F3")]
	public Vector3 cameraPosition; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002F4")]
	public ulong sceneCullingMask; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002F5")]
	public int cullingMask; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002F6")]
	public CullingGroup cullingGroups; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002F7")]
	public Int32[] visibleDecalIndexArray; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002F8")]
	public NativeArray<Int32> visibleDecalIndices; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002F9")]
	public int visibleDecalCount; //Field offset: 0x68

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600036A")]
	public DecalCulledChunk() { }

	[Address(RVA = "0x2D74D70", Offset = "0x2D74170", Length = "0x84")]
	[Token(Token = "0x6000369")]
	public virtual void Dispose() { }

	[Address(RVA = "0x2D74E00", Offset = "0x2D74200", Length = "0x83")]
	[Token(Token = "0x6000367")]
	public virtual void RemoveAtSwapBack(int entityIndex) { }

	[Address(RVA = "0x2D74E90", Offset = "0x2D74290", Length = "0xAF")]
	[Token(Token = "0x6000368")]
	public virtual void SetCapacity(int newCapacity) { }

}

