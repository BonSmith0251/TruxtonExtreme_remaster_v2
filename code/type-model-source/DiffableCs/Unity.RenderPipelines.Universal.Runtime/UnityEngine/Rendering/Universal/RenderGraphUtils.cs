namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001DA")]
internal static class RenderGraphUtils
{
	[CompilerGenerated]
	[Token(Token = "0x20001DC")]
	private sealed class <>c
	{
		[Token(Token = "0x4000A62")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000A63")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__6_0; //Field offset: 0x8

		[Address(RVA = "0x2E0B0C0", Offset = "0x2E0A4C0", Length = "0x67")]
		[Token(Token = "0x6000A1A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A1B")]
		public <>c() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000A1C")]
		internal void <SetGlobalTexture>b__6_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x20001DB")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A60")]
		internal TextureHandle texture; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A61")]
		internal int nameID; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A19")]
		public PassData() { }

	}

	[Token(Token = "0x4000A5C")]
	private static ProfilingSampler s_SetGlobalTextureProfilingSampler; //Field offset: 0x0
	[Token(Token = "0x4000A5D")]
	internal const int GBufferSize = 7; //Field offset: 0x0
	[Token(Token = "0x4000A5E")]
	internal const int DBufferSize = 3; //Field offset: 0x0
	[Token(Token = "0x4000A5F")]
	internal const int LightTextureSize = 4; //Field offset: 0x0

	[Address(RVA = "0x2E08780", Offset = "0x2E07B80", Length = "0x87")]
	[Token(Token = "0x6000A18")]
	private static RenderGraphUtils() { }

	[Address(RVA = "0x2E08250", Offset = "0x2E07650", Length = "0x37F")]
	[Token(Token = "0x6000A17")]
	public static void SetGlobalTexture(RenderGraph graph, int nameId, TextureHandle handle, string passName = "Set Global Texture", string file = "", int line = 0) { }

	[Address(RVA = "0x2E085D0", Offset = "0x2E079D0", Length = "0x1A7")]
	[Token(Token = "0x6000A16")]
	internal static void UseDBufferIfValid(IRasterRenderGraphBuilder builder, UniversalResourceData resourceData) { }

}

