namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000091")]
internal class DecalCachedChunk : DecalChunk
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002CB")]
	public MaterialPropertyBlock propertyBlock; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002CC")]
	public int passIndexDBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40002CD")]
	public int passIndexEmissive; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002CE")]
	public int passIndexScreenSpace; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40002CF")]
	public int passIndexGBuffer; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002D0")]
	public int drawOrder; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40002D1")]
	public bool isCreated; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002D2")]
	public NativeArray<float4x4> decalToWorlds; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002D3")]
	public NativeArray<float4x4> normalToWorlds; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002D4")]
	public NativeArray<float4x4> sizeOffsets; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002D5")]
	public NativeArray<float2> drawDistances; //Field offset: 0x78
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40002D6")]
	public NativeArray<float2> angleFades; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40002D7")]
	public NativeArray<float4> uvScaleBias; //Field offset: 0x98
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40002D8")]
	public NativeArray<Int32> layerMasks; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40002D9")]
	public NativeArray<UInt64> sceneLayerMasks; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40002DA")]
	public NativeArray<Single> fadeFactors; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40002DB")]
	public NativeArray<BoundingSphere> boundingSpheres; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40002DC")]
	public NativeArray<DecalScaleMode> scaleModes; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40002DD")]
	public NativeArray<UInt32> renderingLayerMasks; //Field offset: 0xF8
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40002DE")]
	public NativeArray<float3> positions; //Field offset: 0x108
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40002DF")]
	public NativeArray<quaternion> rotation; //Field offset: 0x118
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40002E0")]
	public NativeArray<float3> scales; //Field offset: 0x128
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40002E1")]
	public NativeArray<Boolean> dirty; //Field offset: 0x138
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40002E2")]
	public BoundingSphere[] boundingSphereArray; //Field offset: 0x148

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600035C")]
	public DecalCachedChunk() { }

	[Address(RVA = "0x2D73E80", Offset = "0x2D73280", Length = "0x1E7")]
	[Token(Token = "0x600035B")]
	public virtual void Dispose() { }

	[Address(RVA = "0x2D74070", Offset = "0x2D73470", Length = "0x303")]
	[Token(Token = "0x6000359")]
	public virtual void RemoveAtSwapBack(int entityIndex) { }

	[Address(RVA = "0x2D74380", Offset = "0x2D73780", Length = "0x226")]
	[Token(Token = "0x600035A")]
	public virtual void SetCapacity(int newCapacity) { }

}

