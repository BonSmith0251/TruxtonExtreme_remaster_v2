namespace UnityEngine.TextCore.Text;

[ExcludeFromDocs]
[Token(Token = "0x200006F")]
public static class TextShaderUtilities
{
	[Token(Token = "0x400047F")]
	public static int ID_MainTex; //Field offset: 0x0
	[Token(Token = "0x4000480")]
	public static int ID_FaceTex; //Field offset: 0x4
	[Token(Token = "0x4000481")]
	public static int ID_FaceColor; //Field offset: 0x8
	[Token(Token = "0x4000482")]
	public static int ID_FaceDilate; //Field offset: 0xC
	[Token(Token = "0x4000483")]
	public static int ID_Shininess; //Field offset: 0x10
	[Token(Token = "0x4000484")]
	public static int ID_OutlineOffset1; //Field offset: 0x14
	[Token(Token = "0x4000485")]
	public static int ID_OutlineOffset2; //Field offset: 0x18
	[Token(Token = "0x4000486")]
	public static int ID_OutlineOffset3; //Field offset: 0x1C
	[Token(Token = "0x4000487")]
	public static int ID_OutlineMode; //Field offset: 0x20
	[Token(Token = "0x4000488")]
	public static int ID_IsoPerimeter; //Field offset: 0x24
	[Token(Token = "0x4000489")]
	public static int ID_Softness; //Field offset: 0x28
	[Token(Token = "0x400048A")]
	public static int ID_UnderlayColor; //Field offset: 0x2C
	[Token(Token = "0x400048B")]
	public static int ID_UnderlayOffsetX; //Field offset: 0x30
	[Token(Token = "0x400048C")]
	public static int ID_UnderlayOffsetY; //Field offset: 0x34
	[Token(Token = "0x400048D")]
	public static int ID_UnderlayDilate; //Field offset: 0x38
	[Token(Token = "0x400048E")]
	public static int ID_UnderlaySoftness; //Field offset: 0x3C
	[Token(Token = "0x400048F")]
	public static int ID_UnderlayOffset; //Field offset: 0x40
	[Token(Token = "0x4000490")]
	public static int ID_UnderlayIsoPerimeter; //Field offset: 0x44
	[Token(Token = "0x4000491")]
	public static int ID_WeightNormal; //Field offset: 0x48
	[Token(Token = "0x4000492")]
	public static int ID_WeightBold; //Field offset: 0x4C
	[Token(Token = "0x4000493")]
	public static int ID_OutlineTex; //Field offset: 0x50
	[Token(Token = "0x4000494")]
	public static int ID_OutlineWidth; //Field offset: 0x54
	[Token(Token = "0x4000495")]
	public static int ID_OutlineSoftness; //Field offset: 0x58
	[Token(Token = "0x4000496")]
	public static int ID_OutlineColor; //Field offset: 0x5C
	[Token(Token = "0x4000497")]
	public static int ID_Outline2Color; //Field offset: 0x60
	[Token(Token = "0x4000498")]
	public static int ID_Outline2Width; //Field offset: 0x64
	[Token(Token = "0x4000499")]
	public static int ID_Padding; //Field offset: 0x68
	[Token(Token = "0x400049A")]
	public static int ID_GradientScale; //Field offset: 0x6C
	[Token(Token = "0x400049B")]
	public static int ID_ScaleX; //Field offset: 0x70
	[Token(Token = "0x400049C")]
	public static int ID_ScaleY; //Field offset: 0x74
	[Token(Token = "0x400049D")]
	public static int ID_PerspectiveFilter; //Field offset: 0x78
	[Token(Token = "0x400049E")]
	public static int ID_Sharpness; //Field offset: 0x7C
	[Token(Token = "0x400049F")]
	public static int ID_TextureWidth; //Field offset: 0x80
	[Token(Token = "0x40004A0")]
	public static int ID_TextureHeight; //Field offset: 0x84
	[Token(Token = "0x40004A1")]
	public static int ID_BevelAmount; //Field offset: 0x88
	[Token(Token = "0x40004A2")]
	public static int ID_GlowColor; //Field offset: 0x8C
	[Token(Token = "0x40004A3")]
	public static int ID_GlowOffset; //Field offset: 0x90
	[Token(Token = "0x40004A4")]
	public static int ID_GlowPower; //Field offset: 0x94
	[Token(Token = "0x40004A5")]
	public static int ID_GlowOuter; //Field offset: 0x98
	[Token(Token = "0x40004A6")]
	public static int ID_GlowInner; //Field offset: 0x9C
	[Token(Token = "0x40004A7")]
	public static int ID_LightAngle; //Field offset: 0xA0
	[Token(Token = "0x40004A8")]
	public static int ID_EnvMap; //Field offset: 0xA4
	[Token(Token = "0x40004A9")]
	public static int ID_EnvMatrix; //Field offset: 0xA8
	[Token(Token = "0x40004AA")]
	public static int ID_EnvMatrixRotation; //Field offset: 0xAC
	[Token(Token = "0x40004AB")]
	public static int ID_MaskCoord; //Field offset: 0xB0
	[Token(Token = "0x40004AC")]
	public static int ID_ClipRect; //Field offset: 0xB4
	[Token(Token = "0x40004AD")]
	public static int ID_MaskSoftnessX; //Field offset: 0xB8
	[Token(Token = "0x40004AE")]
	public static int ID_MaskSoftnessY; //Field offset: 0xBC
	[Token(Token = "0x40004AF")]
	public static int ID_VertexOffsetX; //Field offset: 0xC0
	[Token(Token = "0x40004B0")]
	public static int ID_VertexOffsetY; //Field offset: 0xC4
	[Token(Token = "0x40004B1")]
	public static int ID_UseClipRect; //Field offset: 0xC8
	[Token(Token = "0x40004B2")]
	public static int ID_StencilID; //Field offset: 0xCC
	[Token(Token = "0x40004B3")]
	public static int ID_StencilOp; //Field offset: 0xD0
	[Token(Token = "0x40004B4")]
	public static int ID_StencilComp; //Field offset: 0xD4
	[Token(Token = "0x40004B5")]
	public static int ID_StencilReadMask; //Field offset: 0xD8
	[Token(Token = "0x40004B6")]
	public static int ID_StencilWriteMask; //Field offset: 0xDC
	[Token(Token = "0x40004B7")]
	public static int ID_ShaderFlags; //Field offset: 0xE0
	[Token(Token = "0x40004B8")]
	public static int ID_ScaleRatio_A; //Field offset: 0xE4
	[Token(Token = "0x40004B9")]
	public static int ID_ScaleRatio_B; //Field offset: 0xE8
	[Token(Token = "0x40004BA")]
	public static int ID_ScaleRatio_C; //Field offset: 0xEC
	[Token(Token = "0x40004BB")]
	public static string Keyword_Bevel; //Field offset: 0xF0
	[Token(Token = "0x40004BC")]
	public static string Keyword_Glow; //Field offset: 0xF8
	[Token(Token = "0x40004BD")]
	public static string Keyword_Underlay; //Field offset: 0x100
	[Token(Token = "0x40004BE")]
	public static string Keyword_Ratios; //Field offset: 0x108
	[Token(Token = "0x40004BF")]
	public static string Keyword_MASK_SOFT; //Field offset: 0x110
	[Token(Token = "0x40004C0")]
	public static string Keyword_MASK_HARD; //Field offset: 0x118
	[Token(Token = "0x40004C1")]
	public static string Keyword_MASK_TEX; //Field offset: 0x120
	[Token(Token = "0x40004C2")]
	public static string Keyword_Outline; //Field offset: 0x128
	[Token(Token = "0x40004C3")]
	public static string ShaderTag_ZTestMode; //Field offset: 0x130
	[Token(Token = "0x40004C4")]
	public static string ShaderTag_CullMode; //Field offset: 0x138
	[Token(Token = "0x40004C5")]
	private static float m_clamp; //Field offset: 0x140
	[Token(Token = "0x40004C6")]
	public static bool isInitialized; //Field offset: 0x144
	[Token(Token = "0x40004C7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static readonly string k_SDFText; //Field offset: 0x148
	[Token(Token = "0x40004C8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static readonly string k_BitmapText; //Field offset: 0x150
	[Token(Token = "0x40004C9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static readonly string k_SpriteText; //Field offset: 0x158
	[Token(Token = "0x40004CA")]
	private static Shader k_ShaderRef_MobileSDF; //Field offset: 0x160
	[Token(Token = "0x40004CB")]
	private static Shader k_ShaderRef_MobileBitmap; //Field offset: 0x168
	[Token(Token = "0x40004CC")]
	private static Shader k_ShaderRef_Sprite; //Field offset: 0x170

	[Token(Token = "0x1700008A")]
	internal static Shader ShaderRef_MobileBitmap
	{
		[Address(RVA = "0x31C9030", Offset = "0x31C8430", Length = "0x117")]
		[Token(Token = "0x6000340")]
		internal get { } //Length: 279
	}

	[Token(Token = "0x17000089")]
	internal static Shader ShaderRef_MobileSDF
	{
		[Address(RVA = "0x31C9150", Offset = "0x31C8550", Length = "0xEB")]
		[Token(Token = "0x600033F")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 235
	}

	[Token(Token = "0x1700008B")]
	internal static Shader ShaderRef_Sprite
	{
		[Address(RVA = "0x31C9240", Offset = "0x31C8640", Length = "0x1BA")]
		[Token(Token = "0x6000341")]
		internal get { } //Length: 442
	}

	[Address(RVA = "0x31C8C10", Offset = "0x31C8010", Length = "0x411")]
	[Token(Token = "0x6000342")]
	private static TextShaderUtilities() { }

	[Address(RVA = "0x31C9030", Offset = "0x31C8430", Length = "0x117")]
	[Token(Token = "0x6000340")]
	internal static Shader get_ShaderRef_MobileBitmap() { }

	[Address(RVA = "0x31C9150", Offset = "0x31C8550", Length = "0xEB")]
	[Token(Token = "0x600033F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Shader get_ShaderRef_MobileSDF() { }

	[Address(RVA = "0x31C9240", Offset = "0x31C8640", Length = "0x1BA")]
	[Token(Token = "0x6000341")]
	internal static Shader get_ShaderRef_Sprite() { }

	[Address(RVA = "0x31C8120", Offset = "0x31C7520", Length = "0xAE3")]
	[Token(Token = "0x6000343")]
	internal static void GetShaderPropertyIDs() { }

}

