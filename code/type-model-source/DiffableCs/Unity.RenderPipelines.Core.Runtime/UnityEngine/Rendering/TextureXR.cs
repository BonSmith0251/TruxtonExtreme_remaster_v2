namespace UnityEngine.Rendering;

[Token(Token = "0x20001AA")]
public static class TextureXR
{
	[Token(Token = "0x4000834")]
	private static int m_MaxViews; //Field offset: 0x0
	[Token(Token = "0x4000835")]
	private static Texture m_BlackUIntTexture2DArray; //Field offset: 0x8
	[Token(Token = "0x4000836")]
	private static Texture m_BlackUIntTexture; //Field offset: 0x10
	[Token(Token = "0x4000837")]
	private static RTHandle m_BlackUIntTexture2DArrayRTH; //Field offset: 0x18
	[Token(Token = "0x4000838")]
	private static RTHandle m_BlackUIntTextureRTH; //Field offset: 0x20
	[Token(Token = "0x4000839")]
	private static Texture2DArray m_ClearTexture2DArray; //Field offset: 0x28
	[Token(Token = "0x400083A")]
	private static Texture2D m_ClearTexture; //Field offset: 0x30
	[Token(Token = "0x400083B")]
	private static RTHandle m_ClearTexture2DArrayRTH; //Field offset: 0x38
	[Token(Token = "0x400083C")]
	private static RTHandle m_ClearTextureRTH; //Field offset: 0x40
	[Token(Token = "0x400083D")]
	private static Texture2DArray m_MagentaTexture2DArray; //Field offset: 0x48
	[Token(Token = "0x400083E")]
	private static Texture2D m_MagentaTexture; //Field offset: 0x50
	[Token(Token = "0x400083F")]
	private static RTHandle m_MagentaTexture2DArrayRTH; //Field offset: 0x58
	[Token(Token = "0x4000840")]
	private static RTHandle m_MagentaTextureRTH; //Field offset: 0x60
	[Token(Token = "0x4000841")]
	private static Texture2D m_BlackTexture; //Field offset: 0x68
	[Token(Token = "0x4000842")]
	private static Texture3D m_BlackTexture3D; //Field offset: 0x70
	[Token(Token = "0x4000843")]
	private static Texture2DArray m_BlackTexture2DArray; //Field offset: 0x78
	[Token(Token = "0x4000844")]
	private static RTHandle m_BlackTexture2DArrayRTH; //Field offset: 0x80
	[Token(Token = "0x4000845")]
	private static RTHandle m_BlackTextureRTH; //Field offset: 0x88
	[Token(Token = "0x4000846")]
	private static RTHandle m_BlackTexture3DRTH; //Field offset: 0x90
	[Token(Token = "0x4000847")]
	private static Texture2DArray m_WhiteTexture2DArray; //Field offset: 0x98
	[Token(Token = "0x4000848")]
	private static RTHandle m_WhiteTexture2DArrayRTH; //Field offset: 0xA0
	[Token(Token = "0x4000849")]
	private static RTHandle m_WhiteTextureRTH; //Field offset: 0xA8

	[Token(Token = "0x17000199")]
	public static TextureDimension dimension
	{
		[Address(RVA = "0x2C539C0", Offset = "0x2C52DC0", Length = "0x87")]
		[Token(Token = "0x6000CA6")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000196")]
	public static int maxViews
	{
		[Address(RVA = "0x2C53AF0", Offset = "0x2C52EF0", Length = "0x52")]
		[Token(Token = "0x6000CA3")]
		 set { } //Length: 82
	}

	[Token(Token = "0x17000197")]
	public static int slices
	{
		[Address(RVA = "0x2C53A50", Offset = "0x2C52E50", Length = "0x4D")]
		[Token(Token = "0x6000CA4")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000198")]
	public static bool useTexArray
	{
		[Address(RVA = "0x2C53AA0", Offset = "0x2C52EA0", Length = "0x4F")]
		[Token(Token = "0x6000CA5")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x2C53980", Offset = "0x2C52D80", Length = "0x39")]
	[Token(Token = "0x6000CB3")]
	private static TextureXR() { }

	[Address(RVA = "0x2C51DA0", Offset = "0x2C511A0", Length = "0xCC")]
	[Token(Token = "0x6000CB2")]
	private static Texture3D CreateBlackTexture3D(string name) { }

	[Address(RVA = "0x2C52110", Offset = "0x2C51510", Length = "0x1F7")]
	[Token(Token = "0x6000CB1")]
	private static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	[Address(RVA = "0x2C51E70", Offset = "0x2C51270", Length = "0x294")]
	[Token(Token = "0x6000CB0")]
	private static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	[Address(RVA = "0x2C52310", Offset = "0x2C51710", Length = "0x211")]
	[Token(Token = "0x6000CAF")]
	private static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name) { }

	[Address(RVA = "0x2C539C0", Offset = "0x2C52DC0", Length = "0x87")]
	[Token(Token = "0x6000CA6")]
	public static TextureDimension get_dimension() { }

	[Address(RVA = "0x2C53A50", Offset = "0x2C52E50", Length = "0x4D")]
	[Token(Token = "0x6000CA4")]
	public static int get_slices() { }

	[Address(RVA = "0x2C53AA0", Offset = "0x2C52EA0", Length = "0x4F")]
	[Token(Token = "0x6000CA5")]
	public static bool get_useTexArray() { }

	[Address(RVA = "0x2C525F0", Offset = "0x2C519F0", Length = "0xCF")]
	[Token(Token = "0x6000CAA")]
	public static RTHandle GetBlackTexture() { }

	[Address(RVA = "0x2C52530", Offset = "0x2C51930", Length = "0x52")]
	[Token(Token = "0x6000CAC")]
	public static RTHandle GetBlackTexture3D() { }

	[Address(RVA = "0x2C52590", Offset = "0x2C51990", Length = "0x52")]
	[Token(Token = "0x6000CAB")]
	public static RTHandle GetBlackTextureArray() { }

	[Address(RVA = "0x2C526C0", Offset = "0x2C51AC0", Length = "0xC9")]
	[Token(Token = "0x6000CA7")]
	public static RTHandle GetBlackUIntTexture() { }

	[Address(RVA = "0x2C52790", Offset = "0x2C51B90", Length = "0xC9")]
	[Token(Token = "0x6000CA8")]
	public static RTHandle GetClearTexture() { }

	[Address(RVA = "0x2C52860", Offset = "0x2C51C60", Length = "0xC9")]
	[Token(Token = "0x6000CA9")]
	public static RTHandle GetMagentaTexture() { }

	[Address(RVA = "0x2C52930", Offset = "0x2C51D30", Length = "0xCF")]
	[Token(Token = "0x6000CAD")]
	public static RTHandle GetWhiteTexture() { }

	[Address(RVA = "0x2C52A00", Offset = "0x2C51E00", Length = "0xF74")]
	[Token(Token = "0x6000CAE")]
	public static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	[Address(RVA = "0x2C53AF0", Offset = "0x2C52EF0", Length = "0x52")]
	[Token(Token = "0x6000CA3")]
	public static void set_maxViews(int value) { }

}

