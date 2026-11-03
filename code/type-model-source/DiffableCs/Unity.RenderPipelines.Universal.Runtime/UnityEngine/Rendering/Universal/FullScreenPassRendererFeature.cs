namespace UnityEngine.Rendering.Universal;

[MovedFrom(null)]
[Token(Token = "0x2000171")]
public class FullScreenPassRendererFeature : ScriptableRendererFeature, ISerializationCallbackReceiver
{
	[Token(Token = "0x2000173")]
	public class FullScreenRenderPass : ScriptableRenderPass
	{
		[CompilerGenerated]
		[Token(Token = "0x2000176")]
		private sealed class <>c
		{
			[Token(Token = "0x400086D")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x400086E")]
			public static BaseRenderFunc<MainPassData, RasterGraphContext> <>9__11_0; //Field offset: 0x8
			[Token(Token = "0x400086F")]
			public static BaseRenderFunc<CopyPassData, RasterGraphContext> <>9__12_0; //Field offset: 0x10

			[Address(RVA = "0x2DE51B0", Offset = "0x2DE45B0", Length = "0x67")]
			[Token(Token = "0x600080E")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600080F")]
			public <>c() { }

			[Address(RVA = "0x2DDE520", Offset = "0x2DDD920", Length = "0xFE")]
			[Token(Token = "0x6000811")]
			internal void <AddCopyPassRenderPassFullscreen>b__12_0(CopyPassData data, RasterGraphContext rgContext) { }

			[Address(RVA = "0x2DDE620", Offset = "0x2DDDA20", Length = "0x2D8")]
			[Token(Token = "0x6000810")]
			internal void <AddFullscreenRenderPassInputPass>b__11_0(MainPassData data, RasterGraphContext rgContext) { }

		}

		[Token(Token = "0x2000174")]
		private class CopyPassData
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000869")]
			internal TextureHandle inputTexture; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600080C")]
			public CopyPassData() { }

		}

		[Token(Token = "0x2000175")]
		private class MainPassData
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400086A")]
			internal Material material; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400086B")]
			internal int passIndex; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x400086C")]
			internal TextureHandle inputTexture; //Field offset: 0x1C

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600080D")]
			public MainPassData() { }

		}

		[Token(Token = "0x4000868")]
		private static MaterialPropertyBlock s_SharedPropertyBlock; //Field offset: 0x0
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000864")]
		private Material m_Material; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000865")]
		private int m_PassIndex; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4000866")]
		private bool m_FetchActiveColor; //Field offset: 0x6C
		[FieldOffset(Offset = "0x6D")]
		[Token(Token = "0x4000867")]
		private bool m_BindDepthStencilAttachment; //Field offset: 0x6D

		[Address(RVA = "0x2DCB2B0", Offset = "0x2DCA6B0", Length = "0x73")]
		[Token(Token = "0x600080B")]
		private static FullScreenRenderPass() { }

		[Address(RVA = "0x2DCB330", Offset = "0x2DCA730", Length = "0x75")]
		[Token(Token = "0x6000803")]
		public FullScreenRenderPass(string passName) { }

		[Address(RVA = "0x2DC9C40", Offset = "0x2DC9040", Length = "0x3B8")]
		[Token(Token = "0x600080A")]
		private void AddCopyPassRenderPassFullscreen(RenderGraph renderGraph, TextureHandle source, TextureHandle destination) { }

		[Address(RVA = "0x2DCA000", Offset = "0x2DC9400", Length = "0xA0F")]
		[Token(Token = "0x6000809")]
		private void AddFullscreenRenderPassInputPass(RenderGraph renderGraph, UniversalResourceData resourcesData, UniversalCameraData cameraData, TextureHandle source, TextureHandle destination) { }

		[Address(RVA = "0x2DCAA10", Offset = "0x2DC9E10", Length = "0x7A")]
		[Token(Token = "0x6000806")]
		private static void ExecuteCopyColorPass(RasterCommandBuffer cmd, RTHandle sourceTexture) { }

		[Address(RVA = "0x2DCAA90", Offset = "0x2DC9E90", Length = "0x251")]
		[Token(Token = "0x6000807")]
		private static void ExecuteMainPass(RasterCommandBuffer cmd, RTHandle sourceTexture, Material material, int passIndex) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000805")]
		internal void ReAllocate(RenderTextureDescriptor desc) { }

		[Address(RVA = "0x2DCACF0", Offset = "0x2DCA0F0", Length = "0x56E")]
		[Token(Token = "0x6000808")]
		public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

		[Address(RVA = "0x2DCB260", Offset = "0x2DCA660", Length = "0x45")]
		[Token(Token = "0x6000804")]
		public void SetupMembers(Material material, int passIndex, bool fetchActiveColor, bool bindDepthStencilAttachment) { }

	}

	[Token(Token = "0x2000172")]
	internal enum InjectionPoint : int
	{
		BeforeRenderingTransparents = 450,
		BeforeRenderingPostProcessing = 550,
		AfterRenderingPostProcessing = 600,
	}

	[Token(Token = "0x2000177")]
	private enum Version : int
	{
		Uninitialised = -1,
		Initial = 0,
		AddFetchColorBufferCheckbox = 1,
		Count = 2,
		Latest = 1,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000858")]
	public InjectionPoint injectionPoint; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000859")]
	public bool fetchColorBuffer; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400085A")]
	public ScriptableRenderPassInput requirements; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400085B")]
	public Material passMaterial; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400085C")]
	public int passIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400085D")]
	public bool bindDepthStencilAttachment; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400085E")]
	private FullScreenRenderPass m_FullScreenPass; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400085F")]
	private Version m_Version; //Field offset: 0x48

	[Address(RVA = "0x2DC9C20", Offset = "0x2DC9020", Length = "0x19")]
	[Token(Token = "0x6000802")]
	public FullScreenPassRendererFeature() { }

	[Address(RVA = "0x2DC98C0", Offset = "0x2DC8CC0", Length = "0x24E")]
	[Token(Token = "0x60007FE")]
	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[Address(RVA = "0x2DC9B10", Offset = "0x2DC8F10", Length = "0xC4")]
	[Token(Token = "0x60007FC")]
	public virtual void Create() { }

	[Address(RVA = "0x2DC9BE0", Offset = "0x2DC8FE0", Length = "0x15")]
	[Token(Token = "0x60007FD")]
	internal virtual bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out Event atEvent, out MaskSize maskSize) { }

	[Address(RVA = "0x2DC9C00", Offset = "0x2DC9000", Length = "0xE")]
	[Token(Token = "0x6000801")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x2DC9C10", Offset = "0x2DC9010", Length = "0xE")]
	[Token(Token = "0x6000800")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007FF")]
	private void UpgradeIfNeeded() { }

}

