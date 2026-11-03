namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x2000271")]
public struct RenderGraphParameters
{
	[FieldOffset(Offset = "0x0")]
	[Obsolete("Not used anymore. The debugging tools use the name of the object identified by executionId. #from(6000.3)")]
	[Token(Token = "0x4000B02")]
	public string executionName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B03")]
	public EntityId executionId; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000B04")]
	public bool generateDebugData; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B05")]
	public int currentFrameIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B06")]
	public bool rendererListCulling; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B07")]
	public ScriptableRenderContext scriptableRenderContext; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B08")]
	public CommandBuffer commandBuffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B09")]
	internal bool invalidContextForTesting; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000B0A")]
	public RenderTextureUVOriginStrategy renderTextureUVOriginStrategy; //Field offset: 0x2C

}

