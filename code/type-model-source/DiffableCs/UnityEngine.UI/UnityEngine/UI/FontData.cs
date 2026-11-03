namespace UnityEngine.UI;

[Token(Token = "0x200001C")]
public class FontData : ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("font")]
	[SerializeField]
	[Token(Token = "0x4000060")]
	private Font m_Font; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("fontSize")]
	[SerializeField]
	[Token(Token = "0x4000061")]
	private int m_FontSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[FormerlySerializedAs("fontStyle")]
	[SerializeField]
	[Token(Token = "0x4000062")]
	private FontStyle m_FontStyle; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000063")]
	private bool m_BestFit; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000064")]
	private int m_MinSize; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000065")]
	private int m_MaxSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[FormerlySerializedAs("alignment")]
	[SerializeField]
	[Token(Token = "0x4000066")]
	private TextAnchor m_Alignment; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000067")]
	private bool m_AlignByGeometry; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[FormerlySerializedAs("richText")]
	[SerializeField]
	[Token(Token = "0x4000068")]
	private bool m_RichText; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000069")]
	private HorizontalWrapMode m_HorizontalOverflow; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400006A")]
	private VerticalWrapMode m_VerticalOverflow; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400006B")]
	private float m_LineSpacing; //Field offset: 0x3C

	[Token(Token = "0x17000030")]
	public bool alignByGeometry
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x60000D2")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[Token(Token = "0x60000D3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002F")]
	public TextAnchor alignment
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x60000D0")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[Token(Token = "0x60000D1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002C")]
	public bool bestFit
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x60000CA")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x60000CB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000028")]
	public static FontData defaultFontData
	{
		[Address(RVA = "0x31DCED0", Offset = "0x31DC2D0", Length = "0x7B")]
		[Token(Token = "0x60000C3")]
		 get { } //Length: 123
	}

	[Token(Token = "0x17000029")]
	public Font font
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000C4")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60000C5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002A")]
	public int fontSize
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60000C6")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x60000C7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002B")]
	public FontStyle fontStyle
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x60000C8")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x60000C9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000032")]
	public HorizontalWrapMode horizontalOverflow
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x60000D6")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[Token(Token = "0x60000D7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000034")]
	public float lineSpacing
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 6
		[Address(RVA = "0x29EA3D0", Offset = "0x29E97D0", Length = "0x6")]
		[Token(Token = "0x60000DB")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700002E")]
	public int maxSize
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60000CE")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x60000CF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002D")]
	public int minSize
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60000CC")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x60000CD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000031")]
	public bool richText
	{
		[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
		[Token(Token = "0x60000D4")]
		 get { } //Length: 5
		[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
		[Token(Token = "0x60000D5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000033")]
	public VerticalWrapMode verticalOverflow
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x60000D8")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x60000D9")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000DE")]
	public FontData() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x60000D2")]
	public bool get_alignByGeometry() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x60000D0")]
	public TextAnchor get_alignment() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x60000CA")]
	public bool get_bestFit() { }

	[Address(RVA = "0x31DCED0", Offset = "0x31DC2D0", Length = "0x7B")]
	[Token(Token = "0x60000C3")]
	public static FontData get_defaultFontData() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000C4")]
	public Font get_font() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60000C6")]
	public int get_fontSize() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x60000C8")]
	public FontStyle get_fontStyle() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x60000D6")]
	public HorizontalWrapMode get_horizontalOverflow() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[Token(Token = "0x60000DA")]
	public float get_lineSpacing() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x60000CE")]
	public int get_maxSize() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x60000CC")]
	public int get_minSize() { }

	[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
	[Token(Token = "0x60000D4")]
	public bool get_richText() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60000D8")]
	public VerticalWrapMode get_verticalOverflow() { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[Token(Token = "0x60000D3")]
	public void set_alignByGeometry(bool value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[Token(Token = "0x60000D1")]
	public void set_alignment(TextAnchor value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x60000CB")]
	public void set_bestFit(bool value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60000C5")]
	public void set_font(Font value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x60000C7")]
	public void set_fontSize(int value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x60000C9")]
	public void set_fontStyle(FontStyle value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[Token(Token = "0x60000D7")]
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	[Address(RVA = "0x29EA3D0", Offset = "0x29E97D0", Length = "0x6")]
	[Token(Token = "0x60000DB")]
	public void set_lineSpacing(float value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x60000CF")]
	public void set_maxSize(int value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x60000CD")]
	public void set_minSize(int value) { }

	[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
	[Token(Token = "0x60000D5")]
	public void set_richText(bool value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x60000D9")]
	public void set_verticalOverflow(VerticalWrapMode value) { }

	[Address(RVA = "0x31DCE80", Offset = "0x31DC280", Length = "0x4D")]
	[Token(Token = "0x60000DD")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000DC")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

