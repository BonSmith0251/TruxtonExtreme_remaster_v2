namespace UnityEngine.Rendering;

[Token(Token = "0x2000029")]
internal struct InstanceOcclusionEventStats
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000079")]
	public int viewInstanceID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400007A")]
	public InstanceOcclusionEventType eventType; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400007B")]
	public int occluderVersion; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400007C")]
	public int subviewMask; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007D")]
	public OcclusionTest occlusionTest; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400007E")]
	public int visibleInstances; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007F")]
	public int culledInstances; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000080")]
	public int visiblePrimitives; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000081")]
	public int culledPrimitives; //Field offset: 0x20

}

