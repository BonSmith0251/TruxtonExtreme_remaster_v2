namespace UnityEngine;

[NativeHeader("Runtime/GfxDevice/FrameTiming.h")]
[Token(Token = "0x20000DF")]
public struct FrameTiming
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("totalFrameTime")]
	[Token(Token = "0x400026D")]
	public double cpuFrameTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("mainThreadActiveTime")]
	[Token(Token = "0x400026E")]
	public double cpuMainThreadFrameTime; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("mainThreadPresentWaitTime")]
	[Token(Token = "0x400026F")]
	public double cpuMainThreadPresentWaitTime; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeName("renderThreadActiveTime")]
	[Token(Token = "0x4000270")]
	public double cpuRenderThreadFrameTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[NativeName("gpuFrameTime")]
	[Token(Token = "0x4000271")]
	public double gpuFrameTime; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[NativeName("frameStartTimestamp")]
	[Token(Token = "0x4000272")]
	public ulong frameStartTimestamp; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[NativeName("firstSubmitTimestamp")]
	[Token(Token = "0x4000273")]
	public ulong firstSubmitTimestamp; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[NativeName("presentFrameTimestamp")]
	[Token(Token = "0x4000274")]
	public ulong cpuTimePresentCalled; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[NativeName("frameCompleteTimestamp")]
	[Token(Token = "0x4000275")]
	public ulong cpuTimeFrameComplete; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[NativeName("heightScale")]
	[Token(Token = "0x4000276")]
	public float heightScale; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[NativeName("widthScale")]
	[Token(Token = "0x4000277")]
	public float widthScale; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[NativeName("syncInterval")]
	[Token(Token = "0x4000278")]
	public uint syncInterval; //Field offset: 0x50

}

