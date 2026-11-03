namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000071")]
internal class DBufferCopyDepthPass : CopyDepthPass
{

	[Address(RVA = "0x2D6FA10", Offset = "0x2D6EE10", Length = "0x2C")]
	[Token(Token = "0x60002B2")]
	public DBufferCopyDepthPass(RenderPassEvent evt, Shader copyDepthShader, bool shouldClear = false, bool copyToDepth = false, bool copyResolvedDepth = false) { }

	[Address(RVA = "0x2D6F6B0", Offset = "0x2D6EAB0", Length = "0x357")]
	[Token(Token = "0x60002B3")]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

}

