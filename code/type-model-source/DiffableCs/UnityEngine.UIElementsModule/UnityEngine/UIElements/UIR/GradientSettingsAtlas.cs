namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200059F")]
internal class GradientSettingsAtlas : IDisposable
{
	[Token(Token = "0x20005A0")]
	private struct RawTexture
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001387")]
		public Color32[] rgba; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001388")]
		public int width; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4001389")]
		public int height; //Field offset: 0xC

		[Address(RVA = "0x32FEED0", Offset = "0x32FE2D0", Length = "0xA6")]
		[Token(Token = "0x60028B5")]
		public void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY) { }

		[Address(RVA = "0x32FEF80", Offset = "0x32FE380", Length = "0x90")]
		[Token(Token = "0x60028B4")]
		public void WriteRawInt2Packed(int v0, int v1, int destX, int destY) { }

	}

	[Token(Token = "0x400137D")]
	private static ProfilerMarker s_MarkerWrite; //Field offset: 0x0
	[Token(Token = "0x400137E")]
	private static ProfilerMarker s_MarkerCommit; //Field offset: 0x8
	[Token(Token = "0x4001384")]
	private static int s_TextureCounter; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400137F")]
	private readonly int m_Length; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001380")]
	private readonly int m_ElemWidth; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001381")]
	private BestFitAllocator m_Allocator; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001382")]
	private Texture2D m_Atlas; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001383")]
	private RawTexture m_RawAtlas; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001385")]
	private bool <disposed>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4001386")]
	private bool <MustCommit>k__BackingField; //Field offset: 0x39

	[Token(Token = "0x17000A49")]
	public Texture2D atlas
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x60028AB")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000A48")]
	protected private bool disposed
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60028A5")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60028A6")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000A47")]
	internal int length
	{
		[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
		[Token(Token = "0x60028A4")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000A4A")]
	public private bool MustCommit
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60028AF")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60028B0")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x32F7230", Offset = "0x32F6630", Length = "0x98")]
	[Token(Token = "0x60028B3")]
	private static GradientSettingsAtlas() { }

	[Address(RVA = "0x32F72D0", Offset = "0x32F66D0", Length = "0xD5")]
	[Token(Token = "0x60028A9")]
	public GradientSettingsAtlas(int length = 4096) { }

	[Address(RVA = "0x32F6730", Offset = "0x32F5B30", Length = "0xDC")]
	[Token(Token = "0x60028AC")]
	public Alloc Add(int count) { }

	[Address(RVA = "0x32F6810", Offset = "0x32F5C10", Length = "0x1CB")]
	[Token(Token = "0x60028B1")]
	public void Commit() { }

	[Address(RVA = "0x32F69E0", Offset = "0x32F5DE0", Length = "0x61")]
	[Token(Token = "0x60028A7")]
	public override void Dispose() { }

	[Address(RVA = "0x32F6A50", Offset = "0x32F5E50", Length = "0x69")]
	[Token(Token = "0x60028A8")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x60028AB")]
	public Texture2D get_atlas() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60028A5")]
	protected bool get_disposed() { }

	[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
	[Token(Token = "0x60028A4")]
	internal int get_length() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60028AF")]
	public bool get_MustCommit() { }

	[Address(RVA = "0x32F6AC0", Offset = "0x32F5EC0", Length = "0x17B")]
	[Token(Token = "0x60028B2")]
	private void PrepareAtlas() { }

	[Address(RVA = "0x32F6C40", Offset = "0x32F6040", Length = "0x49")]
	[Token(Token = "0x60028AD")]
	public void Remove(Alloc alloc) { }

	[Address(RVA = "0x32F6C90", Offset = "0x32F6090", Length = "0xBE")]
	[Token(Token = "0x60028AA")]
	public void Reset() { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60028A6")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60028B0")]
	private void set_MustCommit(bool value) { }

	[Address(RVA = "0x32F6D50", Offset = "0x32F6150", Length = "0x4DF")]
	[Token(Token = "0x60028AE")]
	public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap) { }

}

