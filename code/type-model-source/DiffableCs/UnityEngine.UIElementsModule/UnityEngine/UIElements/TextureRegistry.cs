namespace UnityEngine.UIElements;

[Token(Token = "0x20002E3")]
internal class TextureRegistry
{
	[Token(Token = "0x20002E4")]
	private struct TextureInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC8")]
		public Texture texture; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BC9")]
		public bool dynamic; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000BCA")]
		public int refCount; //Field offset: 0xC

	}

	[Token(Token = "0x4000BC6")]
	internal const int maxTextures = 2048; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000BC7")]
	private static readonly TextureRegistry <instance>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BC3")]
	private List<TextureInfo> m_Textures; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BC4")]
	private Dictionary<Texture, TextureId> m_TextureToId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BC5")]
	private Stack<TextureId> m_FreeIds; //Field offset: 0x20

	[Token(Token = "0x170003EF")]
	public static TextureRegistry instance
	{
		[Address(RVA = "0x340CCF0", Offset = "0x340C0F0", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x600141E")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x340CA80", Offset = "0x340BE80", Length = "0x15C")]
	[Token(Token = "0x6001426")]
	private static TextureRegistry() { }

	[Address(RVA = "0x340CBE0", Offset = "0x340BFE0", Length = "0x10D")]
	[Token(Token = "0x6001425")]
	public TextureRegistry() { }

	[Address(RVA = "0x340BE90", Offset = "0x340B290", Length = "0x193")]
	[Token(Token = "0x6001423")]
	public TextureId Acquire(Texture tex) { }

	[Address(RVA = "0x340C040", Offset = "0x340B440", Length = "0x37F")]
	[Token(Token = "0x6001422")]
	private TextureId AllocAndAcquire(Texture texture, bool dynamic) { }

	[Address(RVA = "0x340C030", Offset = "0x340B430", Length = "0xF")]
	[Token(Token = "0x6001420")]
	public TextureId AllocAndAcquireDynamic() { }

	[Address(RVA = "0x340CCF0", Offset = "0x340C0F0", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x600141E")]
	public static TextureRegistry get_instance() { }

	[Address(RVA = "0x340C3C0", Offset = "0x340B7C0", Length = "0x19F")]
	[Token(Token = "0x600141F")]
	public Texture GetTexture(TextureId id) { }

	[Address(RVA = "0x340C560", Offset = "0x340B960", Length = "0x294")]
	[Token(Token = "0x6001424")]
	public void Release(TextureId id) { }

	[Address(RVA = "0x340C800", Offset = "0x340BC00", Length = "0x27B")]
	[Token(Token = "0x6001421")]
	public void UpdateDynamic(TextureId id, Texture texture) { }

}

