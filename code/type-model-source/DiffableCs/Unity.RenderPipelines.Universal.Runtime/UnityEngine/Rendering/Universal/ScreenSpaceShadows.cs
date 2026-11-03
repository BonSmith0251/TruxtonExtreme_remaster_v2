namespace UnityEngine.Rendering.Universal;

[DisallowMultipleRendererFeature("Screen Space Shadows")]
[SupportedOnRenderer(typeof(UniversalRendererData))]
[Token(Token = "0x2000189")]
[Tooltip("Screen Space Shadows")]
internal class ScreenSpaceShadows : ScriptableRendererFeature
{
	[Token(Token = "0x200018A")]
	private class ScreenSpaceShadowsPass : ScriptableRenderPass
	{
		[CompilerGenerated]
		[Token(Token = "0x200018C")]
		private sealed class <>c
		{
			[Token(Token = "0x40008D1")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x40008D2")]
			public static BaseRenderFunc<PassData, UnsafeGraphContext> <>9__7_0; //Field offset: 0x8

			[Address(RVA = "0x2DE53E0", Offset = "0x2DE47E0", Length = "0x67")]
			[Token(Token = "0x600083A")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600083B")]
			public <>c() { }

			[Address(RVA = "0x2DE0780", Offset = "0x2DDFB80", Length = "0x1A7")]
			[Token(Token = "0x600083C")]
			internal void <RecordRenderGraph>b__7_0(PassData data, UnsafeGraphContext rgContext) { }

		}

		[Token(Token = "0x200018B")]
		private class PassData
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40008CF")]
			internal TextureHandle target; //Field offset: 0x10
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40008D0")]
			internal Material material; //Field offset: 0x20

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000839")]
			public PassData() { }

		}

		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40008CC")]
		private Material m_Material; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40008CD")]
		private ScreenSpaceShadowsSettings m_CurrentSettings; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40008CE")]
		private int m_ScreenSpaceShadowmapTextureID; //Field offset: 0x70

		[Address(RVA = "0x2DDBCF0", Offset = "0x2DDB0F0", Length = "0xCB")]
		[Token(Token = "0x6000834")]
		internal ScreenSpaceShadowsPass() { }

		[Address(RVA = "0x2DDB3A0", Offset = "0x2DDA7A0", Length = "0x149")]
		[Token(Token = "0x6000838")]
		private static void ExecutePass(UnsafeCommandBuffer cmd, PassData data, RTHandle target) { }

		[Address(RVA = "0x2DDB4F0", Offset = "0x2DDA8F0", Length = "0x26")]
		[Token(Token = "0x6000836")]
		private void InitPassData(ref PassData passData) { }

		[Address(RVA = "0x2DDB520", Offset = "0x2DDA920", Length = "0x734")]
		[Token(Token = "0x6000837")]
		public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

		[Address(RVA = "0x2DDBC60", Offset = "0x2DDB060", Length = "0x90")]
		[Token(Token = "0x6000835")]
		internal bool Setup(ScreenSpaceShadowsSettings featureSettings, Material material) { }

	}

	[Token(Token = "0x200018D")]
	private class ScreenSpaceShadowsPostPass : ScriptableRenderPass
	{
		[CompilerGenerated]
		[Token(Token = "0x200018F")]
		private sealed class <>c
		{
			[Token(Token = "0x40008D4")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x40008D5")]
			public static BaseRenderFunc<PassData, RasterGraphContext> <>9__3_0; //Field offset: 0x8

			[Address(RVA = "0x2DE5370", Offset = "0x2DE4770", Length = "0x67")]
			[Token(Token = "0x6000841")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000842")]
			public <>c() { }

			[Address(RVA = "0x2DE06A0", Offset = "0x2DDFAA0", Length = "0xD8")]
			[Token(Token = "0x6000843")]
			internal void <RecordRenderGraph>b__3_0(PassData data, RasterGraphContext rgContext) { }

		}

		[Token(Token = "0x200018E")]
		public class PassData
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40008D3")]
			internal UniversalShadowData shadowData; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000840")]
			public PassData() { }

		}


		[Address(RVA = "0x2DDC2B0", Offset = "0x2DDB6B0", Length = "0x78")]
		[Token(Token = "0x600083D")]
		internal ScreenSpaceShadowsPostPass() { }

		[Address(RVA = "0x2DDBDC0", Offset = "0x2DDB1C0", Length = "0xCD")]
		[Token(Token = "0x600083E")]
		private static void ExecutePass(RasterCommandBuffer cmd, UniversalShadowData shadowData) { }

		[Address(RVA = "0x2DDBE90", Offset = "0x2DDB290", Length = "0x415")]
		[Token(Token = "0x600083F")]
		public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	}

	[Token(Token = "0x40008CB")]
	private const string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows"; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008C6")]
	private Shader m_Shader; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40008C7")]
	private ScreenSpaceShadowsSettings m_Settings; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008C8")]
	private Material m_Material; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008C9")]
	private ScreenSpaceShadowsPass m_SSShadowsPass; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008CA")]
	private ScreenSpaceShadowsPostPass m_SSShadowsPostPass; //Field offset: 0x40

	[Address(RVA = "0x2DDC9C0", Offset = "0x2DDBDC0", Length = "0x66")]
	[Token(Token = "0x6000833")]
	public ScreenSpaceShadows() { }

	[Address(RVA = "0x2DDC330", Offset = "0x2DDB730", Length = "0x2DA")]
	[Token(Token = "0x6000830")]
	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[Address(RVA = "0x2DDC610", Offset = "0x2DDBA10", Length = "0x1E2")]
	[Token(Token = "0x600082F")]
	public virtual void Create() { }

	[Address(RVA = "0x2DDC800", Offset = "0x2DDBC00", Length = "0x60")]
	[Token(Token = "0x6000831")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2DDC860", Offset = "0x2DDBC60", Length = "0x15E")]
	[Token(Token = "0x6000832")]
	private bool LoadMaterial() { }

}

