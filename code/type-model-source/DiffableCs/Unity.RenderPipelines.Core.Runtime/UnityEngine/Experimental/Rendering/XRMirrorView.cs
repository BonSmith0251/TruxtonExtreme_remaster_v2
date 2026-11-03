namespace UnityEngine.Experimental.Rendering;

[Token(Token = "0x200000F")]
internal static class XRMirrorView
{
	[Token(Token = "0x4000037")]
	private static readonly MaterialPropertyBlock s_MirrorViewMaterialProperty; //Field offset: 0x0
	[Token(Token = "0x4000038")]
	private static readonly ProfilingSampler k_MirrorViewProfilingSampler; //Field offset: 0x8
	[Token(Token = "0x4000039")]
	private static readonly int k_SourceTex; //Field offset: 0x10
	[Token(Token = "0x400003A")]
	private static readonly int k_SourceTexArraySlice; //Field offset: 0x14
	[Token(Token = "0x400003B")]
	private static readonly int k_ScaleBias; //Field offset: 0x18
	[Token(Token = "0x400003C")]
	private static readonly int k_ScaleBiasRt; //Field offset: 0x1C
	[Token(Token = "0x400003D")]
	private static readonly int k_SRGBRead; //Field offset: 0x20
	[Token(Token = "0x400003E")]
	private static readonly int k_SRGBWrite; //Field offset: 0x24
	[Token(Token = "0x400003F")]
	private static readonly int k_MaxNits; //Field offset: 0x28
	[Token(Token = "0x4000040")]
	private static readonly int k_SourceMaxNits; //Field offset: 0x2C
	[Token(Token = "0x4000041")]
	private static readonly int k_SourceHDREncoding; //Field offset: 0x30
	[Token(Token = "0x4000042")]
	private static readonly int k_ColorTransform; //Field offset: 0x34

	[Address(RVA = "0x2BCA9A0", Offset = "0x2BC9DA0", Length = "0x28B")]
	[Token(Token = "0x6000039")]
	private static XRMirrorView() { }

	[Address(RVA = "0x2BC9A70", Offset = "0x2BC8E70", Length = "0xF21")]
	[Token(Token = "0x6000038")]
	internal static void RenderMirrorView(CommandBuffer cmd, Camera camera, Material mat, XRDisplaySubsystem display) { }

}

