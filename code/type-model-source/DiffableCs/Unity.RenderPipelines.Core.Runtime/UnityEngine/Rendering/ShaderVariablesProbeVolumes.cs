namespace UnityEngine.Rendering;

[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\Lighting\\ProbeVolume\\ShaderVariablesProbeVolumes.cs", needAccessors = False, generateCBuffer = True, constantRegister = 6)]
[Token(Token = "0x2000148")]
internal struct ShaderVariablesProbeVolumes
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000629")]
	public Vector4 _Offset_LayerCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400062A")]
	public Vector4 _MinLoadedCellInEntries_IndirectionEntryDim; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400062B")]
	public Vector4 _MaxLoadedCellInEntries_RcpIndirectionEntryDim; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400062C")]
	public Vector4 _PoolDim_MinBrickSize; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400062D")]
	public Vector4 _RcpPoolDim_XY; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400062E")]
	public Vector4 _MinEntryPos_Noise; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400062F")]
	public uint4 _EntryCount_X_XY_LeakReduction; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000630")]
	public Vector4 _Biases_NormalizationClamp; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000631")]
	public Vector4 _FrameIndex_Weights; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000632")]
	public uint4 _ProbeVolumeLayerMask; //Field offset: 0x90

}

