namespace UnityEngine.UIElements;

[Token(Token = "0x20002D0")]
internal class DynamicAtlasPage : IDisposable
{
	[Token(Token = "0x4000B68")]
	private static int s_TextureCounter; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B5D")]
	private TextureId <textureId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B5E")]
	private RenderTexture <atlas>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B5F")]
	private readonly RenderTextureFormat <format>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000B60")]
	private readonly FilterMode <filterMode>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B61")]
	private readonly Vector2Int <minSize>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B62")]
	private readonly Vector2Int <maxSize>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B63")]
	private readonly int m_1Padding; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000B64")]
	private readonly int m_2Padding; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B65")]
	private Allocator2D m_Allocator; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B66")]
	private TextureBlitter m_Blitter; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B67")]
	private Vector2Int m_CurrentSize; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B69")]
	private bool <disposed>k__BackingField; //Field offset: 0x58

	[Token(Token = "0x170003D5")]
	public private RenderTexture atlas
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600139B")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600139C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170003D8")]
	protected private bool disposed
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60013A0")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60013A1")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003D7")]
	public FilterMode filterMode
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600139E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003D6")]
	public RenderTextureFormat format
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600139D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003D4")]
	public private TextureId textureId
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6001399")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600139A")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x33FE780", Offset = "0x33FDB80", Length = "0x184")]
	[Token(Token = "0x600139F")]
	public DynamicAtlasPage(RenderTextureFormat format, FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize) { }

	[Address(RVA = "0x33FD8B0", Offset = "0x33FCCB0", Length = "0x3F")]
	[Token(Token = "0x60013A7")]
	public void Commit() { }

	[Address(RVA = "0x33FD8F0", Offset = "0x33FCCF0", Length = "0x144")]
	[Token(Token = "0x60013A9")]
	private RenderTexture CreateAtlasTexture() { }

	[Address(RVA = "0x33FDA40", Offset = "0x33FCE40", Length = "0x1C9")]
	[Token(Token = "0x60013A3")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x33FDC10", Offset = "0x33FD010", Length = "0x61")]
	[Token(Token = "0x60013A2")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600139B")]
	public RenderTexture get_atlas() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60013A0")]
	protected bool get_disposed() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600139E")]
	public FilterMode get_filterMode() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600139D")]
	public RenderTextureFormat get_format() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6001399")]
	public TextureId get_textureId() { }

	[Address(RVA = "0x33FDC80", Offset = "0x33FD080", Length = "0xFC")]
	[Token(Token = "0x60013A6")]
	public void Remove(Alloc2D alloc) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600139C")]
	private void set_atlas(RenderTexture value) { }

	[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60013A1")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600139A")]
	private void set_textureId(TextureId value) { }

	[Address(RVA = "0x33FDD80", Offset = "0x33FD180", Length = "0x3BD")]
	[Token(Token = "0x60013A4")]
	public bool TryAdd(Texture2D image, out Alloc2D alloc, out RectInt rect) { }

	[Address(RVA = "0x33FE5B0", Offset = "0x33FD9B0", Length = "0x1CF")]
	[Token(Token = "0x60013A5")]
	public void Update(Texture2D image, RectInt rect) { }

	[Address(RVA = "0x33FE140", Offset = "0x33FD540", Length = "0x46F")]
	[Token(Token = "0x60013A8")]
	private void UpdateAtlasTexture() { }

}

