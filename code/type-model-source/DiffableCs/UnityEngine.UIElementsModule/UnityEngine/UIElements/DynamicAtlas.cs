namespace UnityEngine.UIElements;

[Token(Token = "0x2000009")]
internal class DynamicAtlas : AtlasBase
{
	[Token(Token = "0x200000A")]
	public class TextureInfo : LinkedPoolItem<TextureInfo>
	{
		[Token(Token = "0x4000018")]
		public static readonly LinkedPool<TextureInfo> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000014")]
		public DynamicAtlasPage page; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000015")]
		public int counter; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000016")]
		public Alloc2D alloc; //Field offset: 0x28
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000017")]
		public RectInt rect; //Field offset: 0x58

		[Address(RVA = "0x320FA90", Offset = "0x320EE90", Length = "0x11E")]
		[Token(Token = "0x600002B")]
		private static TextureInfo() { }

		[Address(RVA = "0x320FBB0", Offset = "0x320EFB0", Length = "0x39")]
		[Token(Token = "0x600002A")]
		public TextureInfo() { }

		[Address(RVA = "0x320F9D0", Offset = "0x320EDD0", Length = "0x65")]
		[Token(Token = "0x6000028")]
		private static TextureInfo Create() { }

		[Address(RVA = "0x320FA40", Offset = "0x320EE40", Length = "0x46")]
		[Token(Token = "0x6000029")]
		private static void Reset(TextureInfo info) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000A")]
	private Dictionary<Texture, TextureInfo> m_Database; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000B")]
	private DynamicAtlasPage m_PointPage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000C")]
	private DynamicAtlasPage m_BilinearPage; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000D")]
	private ColorSpace m_ColorSpace; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000E")]
	private List<IPanel> m_Panels; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000F")]
	private int m_MinAtlasSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000010")]
	private int m_MaxAtlasSize; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000011")]
	private int m_MaxSubTextureSize; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000012")]
	private DynamicAtlasFilters m_ActiveFilters; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000013")]
	private DynamicAtlasCustomFilter m_CustomFilter; //Field offset: 0x50

	[Token(Token = "0x17000005")]
	public DynamicAtlasFilters activeFilters
	{
		[Address(RVA = "0x320B880", Offset = "0x320AC80", Length = "0x1D")]
		[Token(Token = "0x6000023")]
		 set { } //Length: 29
	}

	[Token(Token = "0x17000007")]
	public DynamicAtlasCustomFilter customFilter
	{
		[Address(RVA = "0x320B8A0", Offset = "0x320ACA0", Length = "0x51")]
		[Token(Token = "0x6000026")]
		 set { } //Length: 81
	}

	[Token(Token = "0x17000004")]
	public static DynamicAtlasFilters defaultFilters
	{
		[Address(RVA = "0x25A5780", Offset = "0x25A4B80", Length = "0x6")]
		[Token(Token = "0x6000022")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000001")]
	internal bool isInitialized
	{
		[Address(RVA = "0x320B860", Offset = "0x320AC60", Length = "0x17")]
		[Token(Token = "0x6000015")]
		internal get { } //Length: 23
	}

	[Token(Token = "0x17000003")]
	public int maxAtlasSize
	{
		[Address(RVA = "0x320B900", Offset = "0x320AD00", Length = "0x1D")]
		[Token(Token = "0x6000021")]
		 set { } //Length: 29
	}

	[Token(Token = "0x17000006")]
	public int maxSubTextureSize
	{
		[Address(RVA = "0x2F98AE0", Offset = "0x2F97EE0", Length = "0x6")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 6
		[Address(RVA = "0x320B920", Offset = "0x320AD20", Length = "0x1D")]
		[Token(Token = "0x6000025")]
		 set { } //Length: 29
	}

	[Token(Token = "0x17000002")]
	public int minAtlasSize
	{
		[Address(RVA = "0x320B940", Offset = "0x320AD40", Length = "0x1D")]
		[Token(Token = "0x6000020")]
		 set { } //Length: 29
	}

	[Address(RVA = "0x320B700", Offset = "0x320AB00", Length = "0x15E")]
	[Token(Token = "0x6000027")]
	public DynamicAtlas() { }

	[Address(RVA = "0x320A880", Offset = "0x3209C80", Length = "0x8A")]
	[Token(Token = "0x600001A")]
	private void DestroyPages() { }

	[Address(RVA = "0x25A5780", Offset = "0x25A4B80", Length = "0x6")]
	[Token(Token = "0x6000022")]
	public static DynamicAtlasFilters get_defaultFilters() { }

	[Address(RVA = "0x320B860", Offset = "0x320AC60", Length = "0x17")]
	[Token(Token = "0x6000015")]
	internal bool get_isInitialized() { }

	[Address(RVA = "0x2F98AE0", Offset = "0x2F97EE0", Length = "0x6")]
	[Token(Token = "0x6000024")]
	public int get_maxSubTextureSize() { }

	[Address(RVA = "0x320A910", Offset = "0x3209D10", Length = "0x14A")]
	[Token(Token = "0x6000019")]
	private void InitPages() { }

	[Address(RVA = "0x320AA60", Offset = "0x3209E60", Length = "0x20")]
	[Token(Token = "0x600001E")]
	internal static bool IsTextureFormatSupported(TextureFormat format) { }

	[Address(RVA = "0x320AAF0", Offset = "0x3209EF0", Length = "0x104")]
	[Token(Token = "0x600001F")]
	public override bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode) { }

	[Address(RVA = "0x320ACC0", Offset = "0x320A0C0", Length = "0xC7")]
	[Token(Token = "0x6000016")]
	protected virtual void OnAssignedToPanel(IPanel panel) { }

	[Address(RVA = "0x320AD90", Offset = "0x320A190", Length = "0x87")]
	[Token(Token = "0x6000017")]
	protected virtual void OnRemovedFromPanel(IPanel panel) { }

	[Address(RVA = "0x320AE20", Offset = "0x320A220", Length = "0x7F")]
	[Token(Token = "0x600001D")]
	protected virtual void OnUpdateDynamicTextures(IPanel panel) { }

	[Address(RVA = "0x320AEA0", Offset = "0x320A2A0", Length = "0x177")]
	[Token(Token = "0x6000018")]
	public virtual void Reset() { }

	[Address(RVA = "0x320B020", Offset = "0x320A420", Length = "0x14A")]
	[Token(Token = "0x600001C")]
	public virtual void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas) { }

	[Address(RVA = "0x320B880", Offset = "0x320AC80", Length = "0x1D")]
	[Token(Token = "0x6000023")]
	public void set_activeFilters(DynamicAtlasFilters value) { }

	[Address(RVA = "0x320B8A0", Offset = "0x320ACA0", Length = "0x51")]
	[Token(Token = "0x6000026")]
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	[Address(RVA = "0x320B900", Offset = "0x320AD00", Length = "0x1D")]
	[Token(Token = "0x6000021")]
	public void set_maxAtlasSize(int value) { }

	[Address(RVA = "0x320B920", Offset = "0x320AD20", Length = "0x1D")]
	[Token(Token = "0x6000025")]
	public void set_maxSubTextureSize(int value) { }

	[Address(RVA = "0x320B940", Offset = "0x320AD40", Length = "0x1D")]
	[Token(Token = "0x6000020")]
	public void set_minAtlasSize(int value) { }

	[Address(RVA = "0x320B170", Offset = "0x320A570", Length = "0x582")]
	[Token(Token = "0x600001B")]
	public virtual bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

}

