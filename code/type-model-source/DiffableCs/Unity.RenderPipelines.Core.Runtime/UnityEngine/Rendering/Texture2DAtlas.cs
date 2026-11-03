namespace UnityEngine.Rendering;

[Token(Token = "0x20001A8")]
public class Texture2DAtlas
{
	[Token(Token = "0x20001A9")]
	private enum BlitType : int
	{
		Default = 0,
		CubeTo2DOctahedral = 1,
		SingleChannel = 2,
		CubeTo2DOctahedralSingleChannel = 3,
	}

	[Token(Token = "0x4000820")]
	const int kGPUTexInvalid = 0; //Field offset: 0x0
	[Token(Token = "0x4000821")]
	const int kGPUTexValidMip0 = 1; //Field offset: 0x0
	[Token(Token = "0x4000822")]
	const int kGPUTexValidMipAll = 2; //Field offset: 0x0
	[Token(Token = "0x400082D")]
	private static readonly Vector4 fullScaleOffset; //Field offset: 0x0
	[Token(Token = "0x400082E")]
	private static readonly int s_MaxMipLevelPadding; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000823")]
	 RTHandle m_AtlasTexture; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000824")]
	 int m_Width; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000825")]
	 int m_Height; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000826")]
	 GraphicsFormat m_Format; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000827")]
	 bool m_UseMipMaps; //Field offset: 0x24
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x4000828")]
	private bool m_IsAtlasTextureOwner; //Field offset: 0x25
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000829")]
	private AtlasAllocator m_AtlasAllocator; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400082A")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"scaleOffset", "size"})]
	private Dictionary<Int32, ValueTuple`2<Vector4, Vector2Int>> m_AllocationCache; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400082B")]
	private Dictionary<Int32, Int32> m_IsGPUTextureUpToDate; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400082C")]
	private Dictionary<Int32, Int32> m_TextureHashes; //Field offset: 0x40

	[Token(Token = "0x17000195")]
	public RTHandle AtlasTexture
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C83")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000194")]
	public static int maxMipLevelPadding
	{
		[Address(RVA = "0x2C51D50", Offset = "0x2C51150", Length = "0x4E")]
		[Token(Token = "0x6000C82")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x2C519A0", Offset = "0x2C50DA0", Length = "0x53")]
	[Token(Token = "0x6000CA2")]
	private static Texture2DAtlas() { }

	[Address(RVA = "0x2C51A00", Offset = "0x2C50E00", Length = "0x341")]
	[Token(Token = "0x6000C84")]
	public Texture2DAtlas(int width, int height, GraphicsFormat format, FilterMode filterMode = 0, bool powerOfTwoPadding = false, string name = "", bool useMipMap = true) { }

	[Address(RVA = "0x2C4F6F0", Offset = "0x2C4EAF0", Length = "0xDA")]
	[Token(Token = "0x6000C9E")]
	public override bool AddTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture) { }

	[Address(RVA = "0x2C4FA60", Offset = "0x2C4EE60", Length = "0x22A")]
	[Token(Token = "0x6000C91")]
	public override bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1) { }

	[Address(RVA = "0x2C4F7D0", Offset = "0x2C4EBD0", Length = "0x21F")]
	[Token(Token = "0x6000C93")]
	public override bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref Vector4 scaleOffset) { }

	[Address(RVA = "0x2C4F9F0", Offset = "0x2C4EDF0", Length = "0x62")]
	[Token(Token = "0x6000C92")]
	public bool AllocateTextureWithoutBlit(Texture texture, int width, int height, ref Vector4 scaleOffset) { }

	[Address(RVA = "0x2C4FC90", Offset = "0x2C4F090", Length = "0x2A7")]
	[Token(Token = "0x6000C8B")]
	private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType) { }

	[Address(RVA = "0x2C4FF40", Offset = "0x2C4F340", Length = "0x196")]
	[Token(Token = "0x6000C90")]
	public override void BlitCubeTexture2D(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, bool blitMips = true, int overrideInstanceID = -1) { }

	[Address(RVA = "0x2C500E0", Offset = "0x2C4F4E0", Length = "0x61")]
	[Token(Token = "0x6000C8F")]
	public override void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1) { }

	[Address(RVA = "0x2C50150", Offset = "0x2C4F550", Length = "0x18B")]
	[Token(Token = "0x6000C8E")]
	public override void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1) { }

	[Address(RVA = "0x2C502E0", Offset = "0x2C4F6E0", Length = "0x1D8")]
	[Token(Token = "0x6000C87")]
	public void ClearTarget(CommandBuffer cmd) { }

	[Address(RVA = "0x2C504C0", Offset = "0x2C4F8C0", Length = "0x1FA")]
	[Token(Token = "0x6000CA1")]
	internal bool EnsureTextureSlot(out bool isUploadNeeded, ref Vector4 scaleBias, int key, int width, int height) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C83")]
	public RTHandle get_AtlasTexture() { }

	[Address(RVA = "0x2C51D50", Offset = "0x2C51150", Length = "0x4E")]
	[Token(Token = "0x6000C82")]
	public static int get_maxMipLevelPadding() { }

	[Address(RVA = "0x2C506C0", Offset = "0x2C4FAC0", Length = "0x6B")]
	[Token(Token = "0x6000C9A")]
	internal Vector2Int GetCachedTextureSize(int id) { }

	[Address(RVA = "0x2C50730", Offset = "0x2C4FB30", Length = "0x67")]
	[Token(Token = "0x6000C94")]
	 int GetTextureHash(Texture textureA, Texture textureB) { }

	[Address(RVA = "0x2C507A0", Offset = "0x2C4FBA0", Length = "0x45")]
	[Token(Token = "0x6000C96")]
	public int GetTextureID(Texture textureA, Texture textureB) { }

	[Address(RVA = "0x2C507F0", Offset = "0x2C4FBF0", Length = "0x1F")]
	[Token(Token = "0x6000C95")]
	public int GetTextureID(Texture texture) { }

	[Address(RVA = "0x2C50810", Offset = "0x2C4FC10", Length = "0x85")]
	[Token(Token = "0x6000C88")]
	 int GetTextureMipmapCount(int width, int height) { }

	[Address(RVA = "0x2C508A0", Offset = "0x2C4FCA0", Length = "0xB8")]
	[Token(Token = "0x6000C89")]
	 bool Is2D(Texture texture) { }

	[Address(RVA = "0x2C50960", Offset = "0x2C4FD60", Length = "0x6B")]
	[Token(Token = "0x6000C97")]
	public bool IsCached(out Vector4 scaleOffset, Texture textureA, Texture textureB) { }

	[Address(RVA = "0x2C50A50", Offset = "0x2C4FE50", Length = "0x3F")]
	[Token(Token = "0x6000C98")]
	public bool IsCached(out Vector4 scaleOffset, Texture texture) { }

	[Address(RVA = "0x2C509D0", Offset = "0x2C4FDD0", Length = "0x7C")]
	[Token(Token = "0x6000C99")]
	public bool IsCached(out Vector4 scaleOffset, int id) { }

	[Address(RVA = "0x2C50A90", Offset = "0x2C4FE90", Length = "0x286")]
	[Token(Token = "0x6000C8A")]
	 bool IsSingleChannelBlit(Texture source, Texture destination) { }

	[Address(RVA = "0x2C50D20", Offset = "0x2C50120", Length = "0x54")]
	[Token(Token = "0x6000C8D")]
	 void MarkGPUTextureInvalid(int instanceId) { }

	[Address(RVA = "0x2C50D80", Offset = "0x2C50180", Length = "0x63")]
	[Token(Token = "0x6000C8C")]
	 void MarkGPUTextureValid(int instanceId, bool mipAreValid = false) { }

	[Address(RVA = "0x2C51360", Offset = "0x2C50760", Length = "0x24B")]
	[Token(Token = "0x6000C9B")]
	public override bool NeedsUpdate(Texture texture, bool needMips = false) { }

	[Address(RVA = "0x2C50DF0", Offset = "0x2C501F0", Length = "0xE0")]
	[Token(Token = "0x6000C9C")]
	public override bool NeedsUpdate(int id, int updateCount, bool needMips = false) { }

	[Address(RVA = "0x2C50EE0", Offset = "0x2C502E0", Length = "0x47B")]
	[Token(Token = "0x6000C9D")]
	public override bool NeedsUpdate(Texture textureA, Texture textureB, bool needMips = false) { }

	[Address(RVA = "0x2C515B0", Offset = "0x2C509B0", Length = "0x63")]
	[Token(Token = "0x6000C85")]
	public void Release() { }

	[Address(RVA = "0x2C51620", Offset = "0x2C50A20", Length = "0xB7")]
	[Token(Token = "0x6000C86")]
	public void ResetAllocator() { }

	[Address(RVA = "0x2C516E0", Offset = "0x2C50AE0", Length = "0x1E2")]
	[Token(Token = "0x6000C9F")]
	public override bool UpdateTexture(CommandBuffer cmd, Texture oldTexture, Texture newTexture, ref Vector4 scaleOffset, Vector4 sourceScaleOffset, bool updateIfNeeded = true, bool blitMips = true) { }

	[Address(RVA = "0x2C518D0", Offset = "0x2C50CD0", Length = "0xCE")]
	[Token(Token = "0x6000CA0")]
	public override bool UpdateTexture(CommandBuffer cmd, Texture texture, ref Vector4 scaleOffset, bool updateIfNeeded = true, bool blitMips = true) { }

}

