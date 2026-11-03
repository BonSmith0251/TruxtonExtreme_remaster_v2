namespace UnityEngine.Rendering;

[Token(Token = "0x2000027")]
internal struct InstanceCullerViewStats
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006E")]
	public BatchCullingViewType viewType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400006F")]
	public int viewInstanceID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000070")]
	public int splitIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000071")]
	public int visibleInstancesOnCPU; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000072")]
	public int visibleInstancesOnGPU; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000073")]
	public int visiblePrimitivesOnCPU; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000074")]
	public int visiblePrimitivesOnGPU; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000075")]
	public int drawCommands; //Field offset: 0x1C

}

