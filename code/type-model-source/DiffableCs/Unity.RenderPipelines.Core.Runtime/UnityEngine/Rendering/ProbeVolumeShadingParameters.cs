namespace UnityEngine.Rendering;

[Token(Token = "0x2000119")]
internal struct ProbeVolumeShadingParameters
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004EF")]
	public float normalBias; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40004F0")]
	public float viewBias; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004F1")]
	public bool scaleBiasByMinDistanceBetweenProbes; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40004F2")]
	public float samplingNoise; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004F3")]
	public float weight; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004F4")]
	public APVLeakReductionMode leakReductionMode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004F5")]
	public int frameIndexForNoise; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004F6")]
	public float reflNormalizationLowerClamp; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004F7")]
	public float reflNormalizationUpperClamp; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004F8")]
	public float skyOcclusionIntensity; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004F9")]
	public bool skyOcclusionShadingDirection; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40004FA")]
	public int regionCount; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004FB")]
	public uint4 regionLayerMasks; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004FC")]
	public Vector3 worldOffset; //Field offset: 0x40

}

