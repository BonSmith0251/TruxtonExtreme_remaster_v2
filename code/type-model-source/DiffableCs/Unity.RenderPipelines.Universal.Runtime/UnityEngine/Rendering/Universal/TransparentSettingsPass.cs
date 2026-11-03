namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200015D")]
internal class TransparentSettingsPass : ScriptableRenderPass
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40007FE")]
	private bool m_shouldReceiveShadows; //Field offset: 0x60

	[Address(RVA = "0x2DDE480", Offset = "0x2DDD880", Length = "0x9A")]
	[Token(Token = "0x60007CC")]
	public TransparentSettingsPass(RenderPassEvent evt, bool shadowReceiveSupported) { }

	[Address(RVA = "0x2DDE3F0", Offset = "0x2DDD7F0", Length = "0x74")]
	[Token(Token = "0x60007CE")]
	public static void ExecutePass(RasterCommandBuffer rasterCommandBuffer) { }

	[Address(RVA = "0x2DDE470", Offset = "0x2DDD870", Length = "0x8")]
	[Token(Token = "0x60007CD")]
	public bool Setup() { }

}

