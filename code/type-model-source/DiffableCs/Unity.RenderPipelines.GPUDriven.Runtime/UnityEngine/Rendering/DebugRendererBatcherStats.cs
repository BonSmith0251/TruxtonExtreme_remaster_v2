namespace UnityEngine.Rendering;

[Token(Token = "0x200002B")]
internal class DebugRendererBatcherStats : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000085")]
	public bool enabled; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000086")]
	public NativeList<InstanceCullerViewStats> instanceCullerStats; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000087")]
	public NativeList<InstanceOcclusionEventStats> instanceOcclusionEventStats; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000088")]
	public NativeList<DebugOccluderStats> occluderStats; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000089")]
	public bool occlusionOverlayEnabled; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400008A")]
	public bool occlusionOverlayCountVisible; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x400008B")]
	public bool overrideOcclusionTestToAlwaysPass; //Field offset: 0x32

	[Address(RVA = "0x2CC4D40", Offset = "0x2CC4140", Length = "0xE0")]
	[Token(Token = "0x6000105")]
	public DebugRendererBatcherStats() { }

	[Address(RVA = "0x2CC4790", Offset = "0x2CC3B90", Length = "0xB1")]
	[Token(Token = "0x6000108")]
	public override void Dispose() { }

	[Address(RVA = "0x2CC4850", Offset = "0x2CC3C50", Length = "0x335")]
	[Token(Token = "0x6000106")]
	public void FinalizeInstanceCullerViewStats() { }

	[Address(RVA = "0x2CC4B90", Offset = "0x2CC3F90", Length = "0x1A2")]
	[Token(Token = "0x6000107")]
	private InstanceOcclusionEventStats GetLastInstanceOcclusionEventStatsForView(int viewIndex) { }

}

