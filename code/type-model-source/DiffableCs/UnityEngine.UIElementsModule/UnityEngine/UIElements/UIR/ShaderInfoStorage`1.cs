namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005D7")]
internal class ShaderInfoStorage : BaseShaderInfoStorage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001534")]
	private readonly int m_InitialSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001535")]
	private readonly int m_MaxSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001536")]
	private readonly TextureFormat m_Format; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001537")]
	private readonly Func<Color, T> m_Convert; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001538")]
	private UIRAtlasAllocator m_Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001539")]
	private Texture2D m_Texture; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400153A")]
	private NativeArray<T> m_Texels; //Field offset: 0x0

	[Token(Token = "0x17000A89")]
	public virtual Texture2D texture
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6002A16")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xF61070", Offset = "0xF60470", Length = "0x104")]
	[Token(Token = "0x6002A14")]
	public ShaderInfoStorage`1(TextureFormat format, Func<Color, T> convert, int initialSize = 64, int maxSize = 4096) { }

	[Address(RVA = "0xF5FCB0", Offset = "0xF5F0B0", Length = "0x171")]
	[Token(Token = "0x6002A17")]
	public virtual bool AllocateRect(int width, int height, out RectInt uvs) { }

	[Address(RVA = "0xF601D0", Offset = "0xF5F5D0", Length = "0x104")]
	[Token(Token = "0x6002A1B")]
	private static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight) { }

	[Address(RVA = "0xF602E0", Offset = "0xF5F6E0", Length = "0x3EE")]
	[Token(Token = "0x6002A1A")]
	private void CreateOrExpandTexture() { }

	[Address(RVA = "0xF60B50", Offset = "0xF5FF50", Length = "0xC9")]
	[Token(Token = "0x6002A15")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6002A16")]
	public virtual Texture2D get_texture() { }

	[Address(RVA = "0xF60DE0", Offset = "0xF601E0", Length = "0xFC")]
	[Token(Token = "0x6002A18")]
	public virtual void SetTexel(int x, int y, Color color) { }

	[Address(RVA = "0xF60EE0", Offset = "0xF602E0", Length = "0xA2")]
	[Token(Token = "0x6002A19")]
	public virtual void UpdateTexture() { }

}

