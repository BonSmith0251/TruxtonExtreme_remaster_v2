namespace UnityEngine.Rendering;

[Token(Token = "0x2000120")]
internal class ProbeVolumeDebug : IDebugData
{
	[Token(Token = "0x400053A")]
	public static Vector3 currentOffset; //Field offset: 0x0
	[Token(Token = "0x400053B")]
	internal static int s_ActiveAdjustmentVolumes; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400051E")]
	public bool drawProbes; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400051F")]
	public bool drawBricks; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000520")]
	public bool drawCells; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x4000521")]
	public bool realtimeSubdivision; //Field offset: 0x13
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000522")]
	public int subdivisionCellUpdatePerFrame; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000523")]
	public float subdivisionDelayInSeconds; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000524")]
	public DebugProbeShadingMode probeShading; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000525")]
	public float probeSize; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000526")]
	public float subdivisionViewCullingDistance; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000527")]
	public float probeCullingDistance; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000528")]
	public int maxSubdivToVisualize; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000529")]
	public int minSubdivToVisualize; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400052A")]
	public float exposureCompensation; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400052B")]
	public bool drawProbeSamplingDebug; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400052C")]
	public float probeSamplingDebugSize; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400052D")]
	public bool debugWithSamplingNoise; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400052E")]
	public uint samplingRenderingLayer; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400052F")]
	public bool drawVirtualOffsetPush; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000530")]
	public float offsetSize; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000531")]
	public bool freezeStreaming; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x4000532")]
	public bool displayCellStreamingScore; //Field offset: 0x51
	[FieldOffset(Offset = "0x52")]
	[Token(Token = "0x4000533")]
	public bool displayIndexFragmentation; //Field offset: 0x52
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000534")]
	public int otherStateIndex; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000535")]
	public bool verboseStreamingLog; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000536")]
	public bool debugStreaming; //Field offset: 0x59
	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x4000537")]
	public bool autoDrawProbes; //Field offset: 0x5A
	[FieldOffset(Offset = "0x5B")]
	[Token(Token = "0x4000538")]
	public bool isolationProbeDebug; //Field offset: 0x5B
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000539")]
	public byte visibleLayers; //Field offset: 0x5C

	[Address(RVA = "0x2C1B4C0", Offset = "0x2C1A8C0", Length = "0xB4")]
	[Token(Token = "0x6000A40")]
	public ProbeVolumeDebug() { }

	[Address(RVA = "0x2C1B450", Offset = "0x2C1A850", Length = "0x61")]
	[CompilerGenerated]
	[Token(Token = "0x6000A43")]
	private void <GetReset>b__32_0() { }

	[Address(RVA = "0x2C1B3E0", Offset = "0x2C1A7E0", Length = "0x67")]
	[Token(Token = "0x6000A42")]
	public override Action GetReset() { }

	[Address(RVA = "0x2C1B450", Offset = "0x2C1A850", Length = "0x61")]
	[Token(Token = "0x6000A41")]
	private void Init() { }

}

