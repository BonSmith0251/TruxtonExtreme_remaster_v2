namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000128")]
internal class HDRDebugViewPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200012D")]
	private sealed class <>c
	{
		[Token(Token = "0x4000674")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000675")]
		public static BaseRenderFunc<PassDataCIExy, UnsafeGraphContext> <>9__12_0; //Field offset: 0x8
		[Token(Token = "0x4000676")]
		public static BaseRenderFunc<PassDataDebugView, RasterGraphContext> <>9__12_1; //Field offset: 0x10

		[Address(RVA = "0x2DC8C20", Offset = "0x2DC8020", Length = "0x67")]
		[Token(Token = "0x600072B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600072C")]
		public <>c() { }

		[Address(RVA = "0x2DC8220", Offset = "0x2DC7620", Length = "0x118")]
		[Token(Token = "0x600072D")]
		internal void <RenderHDRDebug>b__12_0(PassDataCIExy data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2DC8340", Offset = "0x2DC7740", Length = "0x16A")]
		[Token(Token = "0x600072E")]
		internal void <RenderHDRDebug>b__12_1(PassDataDebugView data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000129")]
	private enum HDRDebugPassId : int
	{
		CIExyPrepass = 0,
		DebugViewPass = 1,
	}

	[Token(Token = "0x200012A")]
	private class PassDataCIExy
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000663")]
		internal Material material; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000664")]
		internal Vector4 luminanceParameters; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000665")]
		internal TextureHandle srcColor; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000666")]
		internal TextureHandle xyBuffer; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000667")]
		internal TextureHandle passThrough; //Field offset: 0x48

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000727")]
		public PassDataCIExy() { }

	}

	[Token(Token = "0x200012B")]
	private class PassDataDebugView
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000668")]
		internal Material material; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000669")]
		internal HDRDebugMode hdrDebugMode; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400066A")]
		internal UniversalCameraData cameraData; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400066B")]
		internal Vector4 luminanceParameters; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400066C")]
		internal TextureHandle xyBuffer; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400066D")]
		internal TextureHandle srcColor; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400066E")]
		internal TextureHandle dstColor; //Field offset: 0x58

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000728")]
		public PassDataDebugView() { }

	}

	[Token(Token = "0x200012C")]
	public class ShaderConstants
	{
		[Token(Token = "0x400066F")]
		public static readonly int _DebugHDRModeId; //Field offset: 0x0
		[Token(Token = "0x4000670")]
		public static readonly int _HDRDebugParamsId; //Field offset: 0x4
		[Token(Token = "0x4000671")]
		public static readonly int _xyTextureId; //Field offset: 0x8
		[Token(Token = "0x4000672")]
		public static readonly int _SizeOfHDRXYMapping; //Field offset: 0xC
		[Token(Token = "0x4000673")]
		public static readonly int _CIExyUAVIndex; //Field offset: 0x10

		[Address(RVA = "0x2DC61C0", Offset = "0x2DC55C0", Length = "0xCF")]
		[Token(Token = "0x600072A")]
		private static ShaderConstants() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000729")]
		public ShaderConstants() { }

	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400065E")]
	private RTHandle m_PassthroughRT; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400065F")]
	private Material m_material; //Field offset: 0x68

	[Address(RVA = "0x2DADB60", Offset = "0x2DACF60", Length = "0x9C")]
	[Token(Token = "0x600071F")]
	public HDRDebugViewPass(Material mat) { }

	[Address(RVA = "0x2DAC100", Offset = "0x2DAB500", Length = "0xB9")]
	[Token(Token = "0x6000720")]
	public static void ConfigureDescriptorForCIEPrepass(ref RenderTextureDescriptor descriptor) { }

	[Address(RVA = "0x2DAC1C0", Offset = "0x2DAB5C0", Length = "0x11")]
	[Token(Token = "0x6000724")]
	public void Dispose() { }

	[Address(RVA = "0x2DAC1E0", Offset = "0x2DAB5E0", Length = "0x313")]
	[Token(Token = "0x6000722")]
	private static void ExecuteCIExyPrepass(CommandBuffer cmd, PassDataCIExy data, RTHandle sourceTexture, RTHandle xyTarget, RTHandle destTexture) { }

	[Address(RVA = "0x2DAC500", Offset = "0x2DAB900", Length = "0x529")]
	[Token(Token = "0x6000723")]
	private static void ExecuteHDRDebugViewFinalPass(RasterCommandBuffer cmd, in PassDataDebugView data, RTHandle source, Vector4 scaleBias, RTHandle destination, RTHandle xyTarget) { }

	[Address(RVA = "0x2DACA30", Offset = "0x2DABE30", Length = "0x163")]
	[Token(Token = "0x6000721")]
	internal static Vector4 GetLuminanceParameters(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2DACBA0", Offset = "0x2DABFA0", Length = "0xE7A")]
	[Token(Token = "0x6000726")]
	internal void RenderHDRDebug(RenderGraph renderGraph, UniversalCameraData cameraData, TextureHandle srcColor, TextureHandle overlayUITexture, TextureHandle dstColor, HDRDebugMode hdrDebugMode) { }

	[Address(RVA = "0x2DADA20", Offset = "0x2DACE20", Length = "0x13E")]
	[Token(Token = "0x6000725")]
	public void Setup(UniversalCameraData cameraData, HDRDebugMode hdrdebugMode) { }

}

