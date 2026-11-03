namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005E0")]
internal class TextureBlitter : IDisposable
{
	[Token(Token = "0x20005E1")]
	private struct BlitInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400156A")]
		public Texture src; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400156B")]
		public RectInt srcRect; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400156C")]
		public Vector2Int dstPos; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400156D")]
		public int border; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400156E")]
		public Color tint; //Field offset: 0x24

	}

	[Token(Token = "0x4001561")]
	private static readonly Int32[] k_TextureIds; //Field offset: 0x0
	[Token(Token = "0x4001562")]
	private static ProfilerMarker s_CommitSampler; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001563")]
	private BlitInfo[] m_SingleBlit; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001564")]
	private Material m_BlitMaterial; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001565")]
	private MaterialPropertyBlock m_Properties; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001566")]
	private RectInt m_Viewport; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001567")]
	private RenderTexture m_PrevRT; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001568")]
	private List<BlitInfo> m_PendingBlits; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001569")]
	private bool <disposed>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x17000A8D")]
	protected private bool disposed
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002A3C")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002A3D")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x3329140", Offset = "0x3328540", Length = "0x12F")]
	[Token(Token = "0x6002A40")]
	private static TextureBlitter() { }

	[Address(RVA = "0x3329270", Offset = "0x3328670", Length = "0xB2")]
	[Token(Token = "0x6002A41")]
	public TextureBlitter(int capacity = 512) { }

	[Address(RVA = "0x33282C0", Offset = "0x33276C0", Length = "0x23A")]
	[Token(Token = "0x6002A45")]
	private void BeginBlit(RenderTexture dst) { }

	[Address(RVA = "0x3328500", Offset = "0x3327900", Length = "0x12F")]
	[Token(Token = "0x6002A43")]
	public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	[Address(RVA = "0x3328630", Offset = "0x3327A30", Length = "0xF0")]
	[Token(Token = "0x6002A44")]
	public void Commit(RenderTexture dst) { }

	[Address(RVA = "0x3328730", Offset = "0x3327B30", Length = "0x61")]
	[Token(Token = "0x6002A3E")]
	public override void Dispose() { }

	[Address(RVA = "0x33287A0", Offset = "0x3327BA0", Length = "0x7C")]
	[Token(Token = "0x6002A3F")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x3328820", Offset = "0x3327C20", Length = "0x6C1")]
	[Token(Token = "0x6002A46")]
	private void DoBlit(IList<BlitInfo> blitInfos, int startIndex) { }

	[Address(RVA = "0x3328EF0", Offset = "0x33282F0", Length = "0xBC")]
	[Token(Token = "0x6002A47")]
	private void EndBlit() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002A3C")]
	protected bool get_disposed() { }

	[Address(RVA = "0x3328FB0", Offset = "0x33283B0", Length = "0x186")]
	[Token(Token = "0x6002A42")]
	public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002A3D")]
	private void set_disposed(bool value) { }

}

