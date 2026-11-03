namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Legacy/Text", 100)]
[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x2000074")]
public class Text : MaskableGraphic, ILayoutElement
{
	[Token(Token = "0x400024D")]
	protected static Material s_DefaultText; //Field offset: 0x0
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x4000249")]
	private FontData m_FontData; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[TextArea(3, 10)]
	[Token(Token = "0x400024A")]
	protected string m_Text; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400024B")]
	private TextGenerator m_TextCache; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400024C")]
	private TextGenerator m_TextCacheForLayout; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400024E")]
	protected bool m_DisableFontTextureRebuiltCallback; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400024F")]
	private readonly UIVertex[] m_TempVerts; //Field offset: 0x108

	[Token(Token = "0x17000141")]
	public bool alignByGeometry
	{
		[Address(RVA = "0x345CE70", Offset = "0x345C270", Length = "0x1E")]
		[Token(Token = "0x60004BF")]
		 get { } //Length: 30
		[Address(RVA = "0x345D6F0", Offset = "0x345CAF0", Length = "0x3A")]
		[Token(Token = "0x60004C0")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000140")]
	public TextAnchor alignment
	{
		[Address(RVA = "0x345CE90", Offset = "0x345C290", Length = "0x1D")]
		[Token(Token = "0x60004BD")]
		 get { } //Length: 29
		[Address(RVA = "0x345D730", Offset = "0x345CB30", Length = "0x57")]
		[Token(Token = "0x60004BE")]
		 set { } //Length: 87
	}

	[Token(Token = "0x17000137")]
	public TextGenerator cachedTextGenerator
	{
		[Address(RVA = "0x345CF30", Offset = "0x345C330", Length = "0xAC")]
		[Token(Token = "0x60004AD")]
		 get { } //Length: 172
	}

	[Token(Token = "0x17000138")]
	public TextGenerator cachedTextGeneratorForLayout
	{
		[Address(RVA = "0x345CEB0", Offset = "0x345C2B0", Length = "0x73")]
		[Token(Token = "0x60004AE")]
		 get { } //Length: 115
	}

	[Token(Token = "0x1700014D")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x60004DB")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700014A")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x60004D8")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700013A")]
	public Font font
	{
		[Address(RVA = "0x345D020", Offset = "0x345C420", Length = "0x1E")]
		[Token(Token = "0x60004B1")]
		 get { } //Length: 30
		[Address(RVA = "0x345D850", Offset = "0x345CC50", Length = "0x11D")]
		[Token(Token = "0x60004B2")]
		 set { } //Length: 285
	}

	[Token(Token = "0x17000142")]
	public int fontSize
	{
		[Address(RVA = "0x345CFE0", Offset = "0x345C3E0", Length = "0x1D")]
		[Token(Token = "0x60004C1")]
		 get { } //Length: 29
		[Address(RVA = "0x345D790", Offset = "0x345CB90", Length = "0x57")]
		[Token(Token = "0x60004C2")]
		 set { } //Length: 87
	}

	[Token(Token = "0x17000146")]
	public FontStyle fontStyle
	{
		[Address(RVA = "0x345D000", Offset = "0x345C400", Length = "0x1D")]
		[Token(Token = "0x60004C9")]
		 get { } //Length: 29
		[Address(RVA = "0x345D7F0", Offset = "0x345CBF0", Length = "0x57")]
		[Token(Token = "0x60004CA")]
		 set { } //Length: 87
	}

	[Token(Token = "0x17000143")]
	public HorizontalWrapMode horizontalOverflow
	{
		[Address(RVA = "0x345D040", Offset = "0x345C440", Length = "0x1D")]
		[Token(Token = "0x60004C3")]
		 get { } //Length: 29
		[Address(RVA = "0x345D970", Offset = "0x345CD70", Length = "0x57")]
		[Token(Token = "0x60004C4")]
		 set { } //Length: 87
	}

	[Token(Token = "0x1700014E")]
	public override int layoutPriority
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60004DC")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000145")]
	public float lineSpacing
	{
		[Address(RVA = "0x345D060", Offset = "0x345C460", Length = "0x1F")]
		[Token(Token = "0x60004C7")]
		 get { } //Length: 31
		[Address(RVA = "0x345D9D0", Offset = "0x345CDD0", Length = "0x60")]
		[Token(Token = "0x60004C8")]
		 set { } //Length: 96
	}

	[Token(Token = "0x17000139")]
	public virtual Texture mainTexture
	{
		[Address(RVA = "0x345D080", Offset = "0x345C480", Length = "0x1F3")]
		[Token(Token = "0x60004AF")]
		 get { } //Length: 499
	}

	[Token(Token = "0x1700014B")]
	public override float minHeight
	{
		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x60004D9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000148")]
	public override float minWidth
	{
		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x60004D6")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000147")]
	public float pixelsPerUnit
	{
		[Address(RVA = "0x345D280", Offset = "0x345C680", Length = "0x16B")]
		[Token(Token = "0x60004CB")]
		 get { } //Length: 363
	}

	[Token(Token = "0x1700014C")]
	public override float preferredHeight
	{
		[Address(RVA = "0x345D3F0", Offset = "0x345C7F0", Length = "0x137")]
		[Token(Token = "0x60004DA")]
		 get { } //Length: 311
	}

	[Token(Token = "0x17000149")]
	public override float preferredWidth
	{
		[Address(RVA = "0x345D530", Offset = "0x345C930", Length = "0x11C")]
		[Token(Token = "0x60004D7")]
		 get { } //Length: 284
	}

	[Token(Token = "0x1700013D")]
	public bool resizeTextForBestFit
	{
		[Address(RVA = "0x345D650", Offset = "0x345CA50", Length = "0x1E")]
		[Token(Token = "0x60004B7")]
		 get { } //Length: 30
		[Address(RVA = "0x345DA40", Offset = "0x345CE40", Length = "0x57")]
		[Token(Token = "0x60004B8")]
		 set { } //Length: 87
	}

	[Token(Token = "0x1700013F")]
	public int resizeTextMaxSize
	{
		[Address(RVA = "0x345D670", Offset = "0x345CA70", Length = "0x1D")]
		[Token(Token = "0x60004BB")]
		 get { } //Length: 29
		[Address(RVA = "0x345DAA0", Offset = "0x345CEA0", Length = "0x57")]
		[Token(Token = "0x60004BC")]
		 set { } //Length: 87
	}

	[Token(Token = "0x1700013E")]
	public int resizeTextMinSize
	{
		[Address(RVA = "0x345D690", Offset = "0x345CA90", Length = "0x1D")]
		[Token(Token = "0x60004B9")]
		 get { } //Length: 29
		[Address(RVA = "0x345DB00", Offset = "0x345CF00", Length = "0x57")]
		[Token(Token = "0x60004BA")]
		 set { } //Length: 87
	}

	[Token(Token = "0x1700013C")]
	public bool supportRichText
	{
		[Address(RVA = "0x345D6B0", Offset = "0x345CAB0", Length = "0x1E")]
		[Token(Token = "0x60004B5")]
		 get { } //Length: 30
		[Address(RVA = "0x345DB60", Offset = "0x345CF60", Length = "0x57")]
		[Token(Token = "0x60004B6")]
		 set { } //Length: 87
	}

	[Token(Token = "0x1700013B")]
	public override string text
	{
		[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
		[Token(Token = "0x60004B3")]
		 get { } //Length: 8
		[Address(RVA = "0x345DBC0", Offset = "0x345CFC0", Length = "0xEE")]
		[Token(Token = "0x60004B4")]
		 set { } //Length: 238
	}

	[Token(Token = "0x17000144")]
	public VerticalWrapMode verticalOverflow
	{
		[Address(RVA = "0x345D6D0", Offset = "0x345CAD0", Length = "0x1D")]
		[Token(Token = "0x60004C5")]
		 get { } //Length: 29
		[Address(RVA = "0x345DCB0", Offset = "0x345D0B0", Length = "0x57")]
		[Token(Token = "0x60004C6")]
		 set { } //Length: 87
	}

	[Address(RVA = "0x345CDC0", Offset = "0x345C1C0", Length = "0xA4")]
	[Token(Token = "0x60004AC")]
	protected Text() { }

	[Address(RVA = "0x345BFE0", Offset = "0x345B3E0", Length = "0x57")]
	[Token(Token = "0x60004CF")]
	internal void AssignDefaultFont() { }

	[Address(RVA = "0x345BF30", Offset = "0x345B330", Length = "0xAE")]
	[Token(Token = "0x60004D0")]
	internal void AssignDefaultFontIfNecessary() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004D4")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004D5")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x345C040", Offset = "0x345B440", Length = "0x11F")]
	[Token(Token = "0x60004B0")]
	public void FontTextureChanged() { }

	[Address(RVA = "0x345CE70", Offset = "0x345C270", Length = "0x1E")]
	[Token(Token = "0x60004BF")]
	public bool get_alignByGeometry() { }

	[Address(RVA = "0x345CE90", Offset = "0x345C290", Length = "0x1D")]
	[Token(Token = "0x60004BD")]
	public TextAnchor get_alignment() { }

	[Address(RVA = "0x345CF30", Offset = "0x345C330", Length = "0xAC")]
	[Token(Token = "0x60004AD")]
	public TextGenerator get_cachedTextGenerator() { }

	[Address(RVA = "0x345CEB0", Offset = "0x345C2B0", Length = "0x73")]
	[Token(Token = "0x60004AE")]
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x60004DB")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x60004D8")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x345D020", Offset = "0x345C420", Length = "0x1E")]
	[Token(Token = "0x60004B1")]
	public Font get_font() { }

	[Address(RVA = "0x345CFE0", Offset = "0x345C3E0", Length = "0x1D")]
	[Token(Token = "0x60004C1")]
	public int get_fontSize() { }

	[Address(RVA = "0x345D000", Offset = "0x345C400", Length = "0x1D")]
	[Token(Token = "0x60004C9")]
	public FontStyle get_fontStyle() { }

	[Address(RVA = "0x345D040", Offset = "0x345C440", Length = "0x1D")]
	[Token(Token = "0x60004C3")]
	public HorizontalWrapMode get_horizontalOverflow() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60004DC")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x345D060", Offset = "0x345C460", Length = "0x1F")]
	[Token(Token = "0x60004C7")]
	public float get_lineSpacing() { }

	[Address(RVA = "0x345D080", Offset = "0x345C480", Length = "0x1F3")]
	[Token(Token = "0x60004AF")]
	public virtual Texture get_mainTexture() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x60004D9")]
	public override float get_minHeight() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x60004D6")]
	public override float get_minWidth() { }

	[Address(RVA = "0x345D280", Offset = "0x345C680", Length = "0x16B")]
	[Token(Token = "0x60004CB")]
	public float get_pixelsPerUnit() { }

	[Address(RVA = "0x345D3F0", Offset = "0x345C7F0", Length = "0x137")]
	[Token(Token = "0x60004DA")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x345D530", Offset = "0x345C930", Length = "0x11C")]
	[Token(Token = "0x60004D7")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x345D650", Offset = "0x345CA50", Length = "0x1E")]
	[Token(Token = "0x60004B7")]
	public bool get_resizeTextForBestFit() { }

	[Address(RVA = "0x345D670", Offset = "0x345CA70", Length = "0x1D")]
	[Token(Token = "0x60004BB")]
	public int get_resizeTextMaxSize() { }

	[Address(RVA = "0x345D690", Offset = "0x345CA90", Length = "0x1D")]
	[Token(Token = "0x60004B9")]
	public int get_resizeTextMinSize() { }

	[Address(RVA = "0x345D6B0", Offset = "0x345CAB0", Length = "0x1E")]
	[Token(Token = "0x60004B5")]
	public bool get_supportRichText() { }

	[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
	[Token(Token = "0x60004B3")]
	public override string get_text() { }

	[Address(RVA = "0x345D6D0", Offset = "0x345CAD0", Length = "0x1D")]
	[Token(Token = "0x60004C5")]
	public VerticalWrapMode get_verticalOverflow() { }

	[Address(RVA = "0x345C160", Offset = "0x345B560", Length = "0x242")]
	[Token(Token = "0x60004D1")]
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	[Address(RVA = "0x345C3B0", Offset = "0x345B7B0", Length = "0x11C")]
	[Token(Token = "0x60004D2")]
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	[Address(RVA = "0x345C4F0", Offset = "0x345B8F0", Length = "0x53")]
	[Token(Token = "0x60004CD")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x345C550", Offset = "0x345B950", Length = "0x71")]
	[Token(Token = "0x60004CC")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x345C5D0", Offset = "0x345B9D0", Length = "0x763")]
	[Token(Token = "0x60004D3")]
	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	[Address(RVA = "0x345D6F0", Offset = "0x345CAF0", Length = "0x3A")]
	[Token(Token = "0x60004C0")]
	public void set_alignByGeometry(bool value) { }

	[Address(RVA = "0x345D730", Offset = "0x345CB30", Length = "0x57")]
	[Token(Token = "0x60004BE")]
	public void set_alignment(TextAnchor value) { }

	[Address(RVA = "0x345D850", Offset = "0x345CC50", Length = "0x11D")]
	[Token(Token = "0x60004B2")]
	public void set_font(Font value) { }

	[Address(RVA = "0x345D790", Offset = "0x345CB90", Length = "0x57")]
	[Token(Token = "0x60004C2")]
	public void set_fontSize(int value) { }

	[Address(RVA = "0x345D7F0", Offset = "0x345CBF0", Length = "0x57")]
	[Token(Token = "0x60004CA")]
	public void set_fontStyle(FontStyle value) { }

	[Address(RVA = "0x345D970", Offset = "0x345CD70", Length = "0x57")]
	[Token(Token = "0x60004C4")]
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	[Address(RVA = "0x345D9D0", Offset = "0x345CDD0", Length = "0x60")]
	[Token(Token = "0x60004C8")]
	public void set_lineSpacing(float value) { }

	[Address(RVA = "0x345DA40", Offset = "0x345CE40", Length = "0x57")]
	[Token(Token = "0x60004B8")]
	public void set_resizeTextForBestFit(bool value) { }

	[Address(RVA = "0x345DAA0", Offset = "0x345CEA0", Length = "0x57")]
	[Token(Token = "0x60004BC")]
	public void set_resizeTextMaxSize(int value) { }

	[Address(RVA = "0x345DB00", Offset = "0x345CF00", Length = "0x57")]
	[Token(Token = "0x60004BA")]
	public void set_resizeTextMinSize(int value) { }

	[Address(RVA = "0x345DB60", Offset = "0x345CF60", Length = "0x57")]
	[Token(Token = "0x60004B6")]
	public void set_supportRichText(bool value) { }

	[Address(RVA = "0x345DBC0", Offset = "0x345CFC0", Length = "0xEE")]
	[Token(Token = "0x60004B4")]
	public override void set_text(string value) { }

	[Address(RVA = "0x345DCB0", Offset = "0x345D0B0", Length = "0x57")]
	[Token(Token = "0x60004C6")]
	public void set_verticalOverflow(VerticalWrapMode value) { }

	[Address(RVA = "0x345CD40", Offset = "0x345C140", Length = "0x7F")]
	[Token(Token = "0x60004CE")]
	protected virtual void UpdateGeometry() { }

}

