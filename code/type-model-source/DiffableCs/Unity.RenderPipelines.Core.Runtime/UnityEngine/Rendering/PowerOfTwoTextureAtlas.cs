namespace UnityEngine.Rendering;

[Token(Token = "0x2000197")]
public class PowerOfTwoTextureAtlas : Texture2DAtlas
{
	[CompilerGenerated]
	[Token(Token = "0x2000199")]
	private sealed class <>c
	{
		[Token(Token = "0x40007DA")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40007DB")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"instanceId", "size"})]
		public static Comparison<ValueTuple`2<Int32, Vector2Int>> <>9__23_0; //Field offset: 0x8

		[Address(RVA = "0x2C53D80", Offset = "0x2C53180", Length = "0x67")]
		[Token(Token = "0x6000BD6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BD7")]
		public <>c() { }

		[Address(RVA = "0x2C53B60", Offset = "0x2C52F60", Length = "0x83")]
		[Token(Token = "0x6000BD8")]
		internal int <RelayoutEntries>b__23_0(ValueTuple<Int32, Vector2Int> c1, ValueTuple<Int32, Vector2Int> c2) { }

	}

	[Token(Token = "0x2000198")]
	private enum BlitType : int
	{
		Padding = 0,
		PaddingMultiply = 1,
		OctahedralPadding = 2,
		OctahedralPaddingMultiply = 3,
	}

	[Token(Token = "0x40007D3")]
	private const float k_MipmapFactorApprox = 1.33; //Field offset: 0x0
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007D2")]
	private readonly int m_MipPadding; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007D4")]
	private Dictionary<Int32, Vector2Int> m_RequestedTextures; //Field offset: 0x50

	[Token(Token = "0x17000171")]
	public int mipPadding
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x6000BC2")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2C47EA0", Offset = "0x2C472A0", Length = "0xFD")]
	[Token(Token = "0x6000BC1")]
	public PowerOfTwoTextureAtlas(int size, int mipPadding, GraphicsFormat format, FilterMode filterMode = 0, string name = "", bool useMipMap = true) { }

	[Address(RVA = "0x2C46670", Offset = "0x2C45A70", Length = "0x215")]
	[Token(Token = "0x6000BCD")]
	public virtual bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1) { }

	[Address(RVA = "0x2C46890", Offset = "0x2C45C90", Length = "0x3F0")]
	[Token(Token = "0x6000BC6")]
	private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType) { }

	[Address(RVA = "0x2C46DA0", Offset = "0x2C461A0", Length = "0x105")]
	[Token(Token = "0x6000BC9")]
	public virtual void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1) { }

	[Address(RVA = "0x2C46C90", Offset = "0x2C46090", Length = "0x105")]
	[Token(Token = "0x6000BCA")]
	public void BlitOctahedralTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1) { }

	[Address(RVA = "0x2C46FC0", Offset = "0x2C463C0", Length = "0xFF")]
	[Token(Token = "0x6000BC7")]
	public virtual void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1) { }

	[Address(RVA = "0x2C46EB0", Offset = "0x2C462B0", Length = "0x105")]
	[Token(Token = "0x6000BC8")]
	public void BlitTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1) { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x6000BC2")]
	public int get_mipPadding() { }

	[Address(RVA = "0x2C470C0", Offset = "0x2C464C0", Length = "0xC5")]
	[Token(Token = "0x6000BD4")]
	public static long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, GraphicsFormat format) { }

	[Address(RVA = "0x2C47190", Offset = "0x2C46590", Length = "0xE2")]
	[Token(Token = "0x6000BD5")]
	public static int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, GraphicsFormat format) { }

	[Address(RVA = "0x2C47360", Offset = "0x2C46760", Length = "0x17C")]
	[Token(Token = "0x6000BC4")]
	public Vector4 GetPayloadScaleOffset(Texture texture, in Vector4 scaleOffset) { }

	[Address(RVA = "0x2C47280", Offset = "0x2C46680", Length = "0xD8")]
	[Token(Token = "0x6000BC5")]
	public static Vector4 GetPayloadScaleOffset(in Vector2 textureSize, in Vector2 paddingSize, in Vector4 scaleOffset) { }

	[Address(RVA = "0x2C474E0", Offset = "0x2C468E0", Length = "0xB5")]
	[Token(Token = "0x6000BCC")]
	private Vector2 GetPowerOfTwoTextureSize(Texture texture) { }

	[Address(RVA = "0x2C475A0", Offset = "0x2C469A0", Length = "0x24")]
	[Token(Token = "0x6000BC3")]
	private int GetTexturePadding() { }

	[Address(RVA = "0x2C475D0", Offset = "0x2C469D0", Length = "0x4F0")]
	[Token(Token = "0x6000BD3")]
	public bool RelayoutEntries() { }

	[Address(RVA = "0x2C47AD0", Offset = "0x2C46ED0", Length = "0x8D")]
	[Token(Token = "0x6000BCF")]
	public bool ReserveSpace(Texture texture) { }

	[Address(RVA = "0x2C47D90", Offset = "0x2C47190", Length = "0x57")]
	[Token(Token = "0x6000BD0")]
	public bool ReserveSpace(Texture texture, int width, int height) { }

	[Address(RVA = "0x2C47D10", Offset = "0x2C47110", Length = "0x77")]
	[Token(Token = "0x6000BD1")]
	public bool ReserveSpace(Texture textureA, Texture textureB, int width, int height) { }

	[Address(RVA = "0x2C47B60", Offset = "0x2C46F60", Length = "0x1AA")]
	[Token(Token = "0x6000BD2")]
	public bool ReserveSpace(int id, int width, int height) { }

	[Address(RVA = "0x2C47DF0", Offset = "0x2C471F0", Length = "0x44")]
	[Token(Token = "0x6000BCE")]
	public void ResetRequestedTexture() { }

	[Address(RVA = "0x2C47E40", Offset = "0x2C47240", Length = "0x59")]
	[Token(Token = "0x6000BCB")]
	private void TextureSizeToPowerOfTwo(Texture texture, ref int width, ref int height) { }

}

