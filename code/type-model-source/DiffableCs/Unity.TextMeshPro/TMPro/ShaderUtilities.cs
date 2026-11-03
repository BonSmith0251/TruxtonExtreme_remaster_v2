namespace TMPro;

[Token(Token = "0x2000088")]
public static class ShaderUtilities
{
	[Token(Token = "0x4000433")]
	public static int ID_MainTex; //Field offset: 0x0
	[Token(Token = "0x4000434")]
	public static int ID_FaceTex; //Field offset: 0x4
	[Token(Token = "0x4000435")]
	public static int ID_FaceColor; //Field offset: 0x8
	[Token(Token = "0x4000436")]
	public static int ID_FaceDilate; //Field offset: 0xC
	[Token(Token = "0x4000437")]
	public static int ID_Shininess; //Field offset: 0x10
	[Token(Token = "0x4000438")]
	public static int ID_OutlineOffset1; //Field offset: 0x14
	[Token(Token = "0x4000439")]
	public static int ID_OutlineOffset2; //Field offset: 0x18
	[Token(Token = "0x400043A")]
	public static int ID_OutlineOffset3; //Field offset: 0x1C
	[Token(Token = "0x400043B")]
	public static int ID_OutlineMode; //Field offset: 0x20
	[Token(Token = "0x400043C")]
	public static int ID_IsoPerimeter; //Field offset: 0x24
	[Token(Token = "0x400043D")]
	public static int ID_Softness; //Field offset: 0x28
	[Token(Token = "0x400043E")]
	public static int ID_UnderlayColor; //Field offset: 0x2C
	[Token(Token = "0x400043F")]
	public static int ID_UnderlayOffsetX; //Field offset: 0x30
	[Token(Token = "0x4000440")]
	public static int ID_UnderlayOffsetY; //Field offset: 0x34
	[Token(Token = "0x4000441")]
	public static int ID_UnderlayDilate; //Field offset: 0x38
	[Token(Token = "0x4000442")]
	public static int ID_UnderlaySoftness; //Field offset: 0x3C
	[Token(Token = "0x4000443")]
	public static int ID_UnderlayOffset; //Field offset: 0x40
	[Token(Token = "0x4000444")]
	public static int ID_UnderlayIsoPerimeter; //Field offset: 0x44
	[Token(Token = "0x4000445")]
	public static int ID_WeightNormal; //Field offset: 0x48
	[Token(Token = "0x4000446")]
	public static int ID_WeightBold; //Field offset: 0x4C
	[Token(Token = "0x4000447")]
	public static int ID_OutlineTex; //Field offset: 0x50
	[Token(Token = "0x4000448")]
	public static int ID_OutlineWidth; //Field offset: 0x54
	[Token(Token = "0x4000449")]
	public static int ID_OutlineSoftness; //Field offset: 0x58
	[Token(Token = "0x400044A")]
	public static int ID_OutlineColor; //Field offset: 0x5C
	[Token(Token = "0x400044B")]
	public static int ID_Outline2Color; //Field offset: 0x60
	[Token(Token = "0x400044C")]
	public static int ID_Outline2Width; //Field offset: 0x64
	[Token(Token = "0x400044D")]
	public static int ID_Padding; //Field offset: 0x68
	[Token(Token = "0x400044E")]
	public static int ID_GradientScale; //Field offset: 0x6C
	[Token(Token = "0x400044F")]
	public static int ID_ScaleX; //Field offset: 0x70
	[Token(Token = "0x4000450")]
	public static int ID_ScaleY; //Field offset: 0x74
	[Token(Token = "0x4000451")]
	public static int ID_PerspectiveFilter; //Field offset: 0x78
	[Token(Token = "0x4000452")]
	public static int ID_Sharpness; //Field offset: 0x7C
	[Token(Token = "0x4000453")]
	public static int ID_TextureWidth; //Field offset: 0x80
	[Token(Token = "0x4000454")]
	public static int ID_TextureHeight; //Field offset: 0x84
	[Token(Token = "0x4000455")]
	public static int ID_BevelAmount; //Field offset: 0x88
	[Token(Token = "0x4000456")]
	public static int ID_GlowColor; //Field offset: 0x8C
	[Token(Token = "0x4000457")]
	public static int ID_GlowOffset; //Field offset: 0x90
	[Token(Token = "0x4000458")]
	public static int ID_GlowPower; //Field offset: 0x94
	[Token(Token = "0x4000459")]
	public static int ID_GlowOuter; //Field offset: 0x98
	[Token(Token = "0x400045A")]
	public static int ID_GlowInner; //Field offset: 0x9C
	[Token(Token = "0x400045B")]
	public static int ID_LightAngle; //Field offset: 0xA0
	[Token(Token = "0x400045C")]
	public static int ID_EnvMap; //Field offset: 0xA4
	[Token(Token = "0x400045D")]
	public static int ID_EnvMatrix; //Field offset: 0xA8
	[Token(Token = "0x400045E")]
	public static int ID_EnvMatrixRotation; //Field offset: 0xAC
	[Token(Token = "0x400045F")]
	public static int ID_MaskCoord; //Field offset: 0xB0
	[Token(Token = "0x4000460")]
	public static int ID_ClipRect; //Field offset: 0xB4
	[Token(Token = "0x4000461")]
	public static int ID_MaskSoftnessX; //Field offset: 0xB8
	[Token(Token = "0x4000462")]
	public static int ID_MaskSoftnessY; //Field offset: 0xBC
	[Token(Token = "0x4000463")]
	public static int ID_VertexOffsetX; //Field offset: 0xC0
	[Token(Token = "0x4000464")]
	public static int ID_VertexOffsetY; //Field offset: 0xC4
	[Token(Token = "0x4000465")]
	public static int ID_UseClipRect; //Field offset: 0xC8
	[Token(Token = "0x4000466")]
	public static int ID_StencilID; //Field offset: 0xCC
	[Token(Token = "0x4000467")]
	public static int ID_StencilOp; //Field offset: 0xD0
	[Token(Token = "0x4000468")]
	public static int ID_StencilComp; //Field offset: 0xD4
	[Token(Token = "0x4000469")]
	public static int ID_StencilReadMask; //Field offset: 0xD8
	[Token(Token = "0x400046A")]
	public static int ID_StencilWriteMask; //Field offset: 0xDC
	[Token(Token = "0x400046B")]
	public static int ID_ShaderFlags; //Field offset: 0xE0
	[Token(Token = "0x400046C")]
	public static int ID_ScaleRatio_A; //Field offset: 0xE4
	[Token(Token = "0x400046D")]
	public static int ID_ScaleRatio_B; //Field offset: 0xE8
	[Token(Token = "0x400046E")]
	public static int ID_ScaleRatio_C; //Field offset: 0xEC
	[Token(Token = "0x400046F")]
	public static string Keyword_Bevel; //Field offset: 0xF0
	[Token(Token = "0x4000470")]
	public static string Keyword_Glow; //Field offset: 0xF8
	[Token(Token = "0x4000471")]
	public static string Keyword_Underlay; //Field offset: 0x100
	[Token(Token = "0x4000472")]
	public static string Keyword_Ratios; //Field offset: 0x108
	[Token(Token = "0x4000473")]
	public static string Keyword_MASK_SOFT; //Field offset: 0x110
	[Token(Token = "0x4000474")]
	public static string Keyword_MASK_HARD; //Field offset: 0x118
	[Token(Token = "0x4000475")]
	public static string Keyword_MASK_TEX; //Field offset: 0x120
	[Token(Token = "0x4000476")]
	public static string Keyword_Outline; //Field offset: 0x128
	[Token(Token = "0x4000477")]
	public static string ShaderTag_ZTestMode; //Field offset: 0x130
	[Token(Token = "0x4000478")]
	public static string ShaderTag_CullMode; //Field offset: 0x138
	[Token(Token = "0x4000479")]
	private static float m_clamp; //Field offset: 0x140
	[Token(Token = "0x400047A")]
	public static bool isInitialized; //Field offset: 0x144
	[Token(Token = "0x400047B")]
	private static Shader k_ShaderRef_MobileSDF; //Field offset: 0x148
	[Token(Token = "0x400047C")]
	private static Shader k_ShaderRef_MobileBitmap; //Field offset: 0x150

	[Token(Token = "0x17000103")]
	internal static Shader ShaderRef_MobileBitmap
	{
		[Address(RVA = "0x2F074C0", Offset = "0x2F068C0", Length = "0x118")]
		[Token(Token = "0x600048D")]
		internal get { } //Length: 280
	}

	[Token(Token = "0x17000102")]
	internal static Shader ShaderRef_MobileSDF
	{
		[Address(RVA = "0x2F075E0", Offset = "0x2F069E0", Length = "0x118")]
		[Token(Token = "0x600048C")]
		internal get { } //Length: 280
	}

	[Address(RVA = "0x2F07180", Offset = "0x2F06580", Length = "0x336")]
	[Token(Token = "0x600048E")]
	private static ShaderUtilities() { }

	[Address(RVA = "0x2F04230", Offset = "0x2F03630", Length = "0x42D")]
	[Token(Token = "0x6000494")]
	private static float ComputePaddingForProperties(Material mat) { }

	[Address(RVA = "0x2F074C0", Offset = "0x2F068C0", Length = "0x118")]
	[Token(Token = "0x600048D")]
	internal static Shader get_ShaderRef_MobileBitmap() { }

	[Address(RVA = "0x2F075E0", Offset = "0x2F069E0", Length = "0x118")]
	[Token(Token = "0x600048C")]
	internal static Shader get_ShaderRef_MobileSDF() { }

	[Address(RVA = "0x2F04660", Offset = "0x2F03A60", Length = "0x42")]
	[Token(Token = "0x6000491")]
	public static Vector4 GetFontExtent(Material material) { }

	[Address(RVA = "0x2F05280", Offset = "0x2F04680", Length = "0xAFF")]
	[Token(Token = "0x6000493")]
	public static float GetPadding(Material material, bool enableExtraPadding, bool isBold) { }

	[Address(RVA = "0x2F046B0", Offset = "0x2F03AB0", Length = "0xBC6")]
	[Token(Token = "0x6000495")]
	public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold) { }

	[Address(RVA = "0x2F05D80", Offset = "0x2F05180", Length = "0xC58")]
	[Token(Token = "0x600048F")]
	public static void GetShaderPropertyIDs() { }

	[Address(RVA = "0x2F069E0", Offset = "0x2F05DE0", Length = "0x1C5")]
	[Token(Token = "0x6000492")]
	public static bool IsMaskingEnabled(Material material) { }

	[Address(RVA = "0x2F06BB0", Offset = "0x2F05FB0", Length = "0x5CB")]
	[Token(Token = "0x6000490")]
	public static void UpdateShaderRatios(Material mat) { }

}

