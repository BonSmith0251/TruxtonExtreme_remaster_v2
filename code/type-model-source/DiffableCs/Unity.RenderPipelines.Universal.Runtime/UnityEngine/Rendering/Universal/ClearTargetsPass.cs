namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001DD")]
internal class ClearTargetsPass
{
	[CompilerGenerated]
	[Token(Token = "0x20001DF")]
	private sealed class <>c
	{
		[Token(Token = "0x4000A69")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000A6A")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x2E0B130", Offset = "0x2E0A530", Length = "0x67")]
		[Token(Token = "0x6000A22")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A23")]
		public <>c() { }

		[Address(RVA = "0x2E0AB50", Offset = "0x2E09F50", Length = "0x45")]
		[Token(Token = "0x6000A24")]
		internal void <Render>b__3_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x20001DE")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A65")]
		internal TextureHandle color; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A66")]
		internal TextureHandle depth; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A67")]
		internal RTClearFlags clearFlags; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000A68")]
		internal Color clearColor; //Field offset: 0x34

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A21")]
		public PassData() { }

	}

	[Token(Token = "0x4000A64")]
	private static ProfilingSampler s_ClearProfilingSampler; //Field offset: 0x0

	[Address(RVA = "0x2DFE730", Offset = "0x2DFDB30", Length = "0x87")]
	[Token(Token = "0x6000A20")]
	private static ClearTargetsPass() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000A1F")]
	public ClearTargetsPass() { }

	[Address(RVA = "0x2DFE630", Offset = "0x2DFDA30", Length = "0xF5")]
	[Token(Token = "0x6000A1D")]
	internal static void Render(RenderGraph graph, TextureHandle colorHandle, TextureHandle depthHandle, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2DFE0F0", Offset = "0x2DFD4F0", Length = "0x534")]
	[Token(Token = "0x6000A1E")]
	internal static void Render(RenderGraph graph, TextureHandle colorHandle, TextureHandle depthHandle, RTClearFlags clearFlags, Color clearColor) { }

}

