namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000085")]
internal class DecalDrawCallChunk : DecalChunk
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000282")]
	public NativeArray<float4x4> decalToWorlds; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000283")]
	public NativeArray<float4x4> normalToDecals; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000284")]
	public NativeArray<Single> renderingLayerMasks; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000285")]
	public NativeArray<DecalSubDrawCall> subCalls; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000286")]
	public NativeArray<Int32> subCallCounts; //Field offset: 0x68

	[Token(Token = "0x170000DC")]
	public int subCallCount
	{
		[Address(RVA = "0x2D75160", Offset = "0x2D74560", Length = "0x7")]
		[Token(Token = "0x6000320")]
		 get { } //Length: 7
		[Address(RVA = "0x2D75170", Offset = "0x2D74570", Length = "0x7")]
		[Token(Token = "0x600031F")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000324")]
	public DecalDrawCallChunk() { }

	[Address(RVA = "0x2D74F40", Offset = "0x2D74340", Length = "0xAB")]
	[Token(Token = "0x6000323")]
	public virtual void Dispose() { }

	[Address(RVA = "0x2D75160", Offset = "0x2D74560", Length = "0x7")]
	[Token(Token = "0x6000320")]
	public int get_subCallCount() { }

	[Address(RVA = "0x2D74FF0", Offset = "0x2D743F0", Length = "0xCD")]
	[Token(Token = "0x6000321")]
	public virtual void RemoveAtSwapBack(int entityIndex) { }

	[Address(RVA = "0x2D75170", Offset = "0x2D74570", Length = "0x7")]
	[Token(Token = "0x600031F")]
	public void set_subCallCount(int value) { }

	[Address(RVA = "0x2D750C0", Offset = "0x2D744C0", Length = "0x99")]
	[Token(Token = "0x6000322")]
	public virtual void SetCapacity(int newCapacity) { }

}

