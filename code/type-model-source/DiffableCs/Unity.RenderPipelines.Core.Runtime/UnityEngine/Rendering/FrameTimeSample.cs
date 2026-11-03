namespace UnityEngine.Rendering;

[Token(Token = "0x20000CC")]
internal struct FrameTimeSample
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000297")]
	internal float FramesPerSecond; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000298")]
	internal float FullFrameTime; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000299")]
	internal float MainThreadCPUFrameTime; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400029A")]
	internal float MainThreadCPUPresentWaitTime; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400029B")]
	internal float RenderThreadCPUFrameTime; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400029C")]
	internal float GPUFrameTime; //Field offset: 0x14

	[Address(RVA = "0x2ACDEE0", Offset = "0x2ACD2E0", Length = "0x12")]
	[Token(Token = "0x6000778")]
	internal FrameTimeSample(float initValue) { }

}

