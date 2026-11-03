namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200005C")]
internal class GlobalPropertiesPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200005E")]
	private sealed class <>c
	{
		[Token(Token = "0x4000200")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000201")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x2D455F0", Offset = "0x2D449F0", Length = "0x67")]
		[Token(Token = "0x6000246")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000247")]
		public <>c() { }

		[Address(RVA = "0x2D45440", Offset = "0x2D44840", Length = "0x138")]
		[Token(Token = "0x6000248")]
		internal void <Setup>b__3_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x200005D")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001FF")]
		internal Vector2Int screenParams; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000245")]
		public PassData() { }

	}

	[Token(Token = "0x40001FD")]
	private static readonly string k_SetGlobalProperties; //Field offset: 0x0
	[Token(Token = "0x40001FE")]
	private static readonly ProfilingSampler m_SetGlobalPropertiesProfilingSampler; //Field offset: 0x8

	[Address(RVA = "0x2D35740", Offset = "0x2D34B40", Length = "0xD4")]
	[Token(Token = "0x6000244")]
	private static GlobalPropertiesPass() { }

	[Address(RVA = "0x2D203D0", Offset = "0x2D1F7D0", Length = "0x7")]
	[Token(Token = "0x6000243")]
	public GlobalPropertiesPass() { }

	[Address(RVA = "0x2D34F60", Offset = "0x2D34360", Length = "0x7D5")]
	[Token(Token = "0x6000242")]
	internal static void Setup(RenderGraph graph, ContextContainer frameData, Renderer2DData rendererData, UniversalCameraData cameraData, bool useLights) { }

}

