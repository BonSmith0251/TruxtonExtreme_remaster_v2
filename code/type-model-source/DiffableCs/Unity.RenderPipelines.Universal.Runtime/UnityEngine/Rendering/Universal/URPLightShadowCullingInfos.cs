namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001A8")]
internal struct URPLightShadowCullingInfos
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400093B")]
	public NativeArray<ShadowSliceData> slices; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400093C")]
	public uint slicesValidMask; //Field offset: 0x10

	[Address(RVA = "0x2DFB210", Offset = "0x2DFA610", Length = "0x1E")]
	[IsReadOnly]
	[Token(Token = "0x600091B")]
	public bool IsSliceValid(int i) { }

}

