namespace UnityEngine;

[AssetFileNameExtension("guiskin", new IL2CPP_TYPE_STRING[] {})]
[ExecuteInEditMode]
[RequiredByNativeCode]
[Token(Token = "0x2000015")]
public sealed class GUISkin : ScriptableObject
{
	[Token(Token = "0x2000016")]
	public sealed class SkinChangedDelegate : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x600010C")]
		public SkinChangedDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x600010D")]
		public override void Invoke() { }

	}

	[Token(Token = "0x4000098")]
	internal static GUIStyle ms_Error; //Field offset: 0x0
	[Token(Token = "0x400009A")]
	internal static SkinChangedDelegate m_SkinChanged; //Field offset: 0x8
	[Token(Token = "0x400009B")]
	internal static GUISkin current; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400007E")]
	private Font m_Font; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400007F")]
	private GUIStyle m_box; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000080")]
	private GUIStyle m_button; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000081")]
	private GUIStyle m_toggle; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000082")]
	private GUIStyle m_label; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000083")]
	private GUIStyle m_textField; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000084")]
	private GUIStyle m_textArea; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000085")]
	private GUIStyle m_window; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000086")]
	private GUIStyle m_horizontalSlider; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000087")]
	private GUIStyle m_horizontalSliderThumb; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000088")]
	private GUIStyle m_horizontalSliderThumbExtent; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000089")]
	private GUIStyle m_verticalSlider; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400008A")]
	private GUIStyle m_verticalSliderThumb; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400008B")]
	private GUIStyle m_verticalSliderThumbExtent; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400008C")]
	private GUIStyle m_SliderMixed; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x400008D")]
	private GUIStyle m_horizontalScrollbar; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x400008E")]
	private GUIStyle m_horizontalScrollbarThumb; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x400008F")]
	private GUIStyle m_horizontalScrollbarLeftButton; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000090")]
	private GUIStyle m_horizontalScrollbarRightButton; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000091")]
	private GUIStyle m_verticalScrollbar; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x4000092")]
	private GUIStyle m_verticalScrollbarThumb; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x4000093")]
	private GUIStyle m_verticalScrollbarUpButton; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x4000094")]
	private GUIStyle m_verticalScrollbarDownButton; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x4000095")]
	private GUIStyle m_ScrollView; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x4000096")]
	internal GUIStyle[] m_CustomStyles; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x4000097")]
	private GUISettings m_Settings; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000099")]
	private Dictionary<String, GUIStyle> m_Styles; //Field offset: 0xE8

	[Token(Token = "0x17000034")]
	public GUIStyle box
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x60000D4")]
		 get { } //Length: 7
		[Address(RVA = "0x30E9AB0", Offset = "0x30E8EB0", Length = "0x7A")]
		[Token(Token = "0x60000D5")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000038")]
	public GUIStyle button
	{
		[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
		[Token(Token = "0x60000DC")]
		 get { } //Length: 7
		[Address(RVA = "0x30E9B30", Offset = "0x30E8F30", Length = "0x7A")]
		[Token(Token = "0x60000DD")]
		 set { } //Length: 122
	}

	[Token(Token = "0x1700004B")]
	public GUIStyle[] customStyles
	{
		[Address(RVA = "0x30E9940", Offset = "0x30E8D40", Length = "0xA")]
		[Token(Token = "0x6000102")]
		 get { } //Length: 10
		[Address(RVA = "0x30E9BB0", Offset = "0x30E8FB0", Length = "0x80")]
		[Token(Token = "0x6000103")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700004D")]
	internal static GUIStyle error
	{
		[Address(RVA = "0x30E9950", Offset = "0x30E8D50", Length = "0xFA")]
		[Token(Token = "0x6000105")]
		internal get { } //Length: 250
	}

	[Token(Token = "0x17000033")]
	public Font font
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x60000D2")]
		 get { } //Length: 7
		[Address(RVA = "0x30E9C30", Offset = "0x30E9030", Length = "0x190")]
		[Token(Token = "0x60000D3")]
		 set { } //Length: 400
	}

	[Token(Token = "0x17000042")]
	public GUIStyle horizontalScrollbar
	{
		[Address(RVA = "0x30E9A60", Offset = "0x30E8E60", Length = "0xA")]
		[Token(Token = "0x60000F0")]
		 get { } //Length: 10
		[Address(RVA = "0x30E9F40", Offset = "0x30E9340", Length = "0x80")]
		[Token(Token = "0x60000F1")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000044")]
	public GUIStyle horizontalScrollbarLeftButton
	{
		[Address(RVA = "0x2F92D10", Offset = "0x2F92110", Length = "0xA")]
		[Token(Token = "0x60000F4")]
		 get { } //Length: 10
		[Address(RVA = "0x30E9DC0", Offset = "0x30E91C0", Length = "0x80")]
		[Token(Token = "0x60000F5")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000045")]
	public GUIStyle horizontalScrollbarRightButton
	{
		[Address(RVA = "0x30E9A50", Offset = "0x30E8E50", Length = "0xA")]
		[Token(Token = "0x60000F6")]
		 get { } //Length: 10
		[Address(RVA = "0x30E9E40", Offset = "0x30E9240", Length = "0x80")]
		[Token(Token = "0x60000F7")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000043")]
	public GUIStyle horizontalScrollbarThumb
	{
		[Address(RVA = "0x2F92D00", Offset = "0x2F92100", Length = "0xA")]
		[Token(Token = "0x60000F2")]
		 get { } //Length: 10
		[Address(RVA = "0x30E9EC0", Offset = "0x30E92C0", Length = "0x80")]
		[Token(Token = "0x60000F3")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700003B")]
	public GUIStyle horizontalSlider
	{
		[Address(RVA = "0x2F944E0", Offset = "0x2F938E0", Length = "0x7")]
		[Token(Token = "0x60000E2")]
		 get { } //Length: 7
		[Address(RVA = "0x30EA0C0", Offset = "0x30E94C0", Length = "0x7A")]
		[Token(Token = "0x60000E3")]
		 set { } //Length: 122
	}

	[Token(Token = "0x1700003C")]
	public GUIStyle horizontalSliderThumb
	{
		[Address(RVA = "0x2F94500", Offset = "0x2F93900", Length = "0x7")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 7
		[Address(RVA = "0x30EA040", Offset = "0x30E9440", Length = "0x7A")]
		[Token(Token = "0x60000E5")]
		 set { } //Length: 122
	}

	[Token(Token = "0x1700003D")]
	internal GUIStyle horizontalSliderThumbExtent
	{
		[Address(RVA = "0x2F94510", Offset = "0x2F93910", Length = "0x7")]
		[Token(Token = "0x60000E6")]
		internal get { } //Length: 7
		[Address(RVA = "0x30E9FC0", Offset = "0x30E93C0", Length = "0x7A")]
		[Token(Token = "0x60000E7")]
		internal set { } //Length: 122
	}

	[Token(Token = "0x17000035")]
	public GUIStyle label
	{
		[Address(RVA = "0x2F944A0", Offset = "0x2F938A0", Length = "0x7")]
		[Token(Token = "0x60000D6")]
		 get { } //Length: 7
		[Address(RVA = "0x30EA140", Offset = "0x30E9540", Length = "0x7A")]
		[Token(Token = "0x60000D7")]
		 set { } //Length: 122
	}

	[Token(Token = "0x1700004A")]
	public GUIStyle scrollView
	{
		[Address(RVA = "0x30E9A70", Offset = "0x30E8E70", Length = "0xA")]
		[Token(Token = "0x6000100")]
		 get { } //Length: 10
		[Address(RVA = "0x30EA1C0", Offset = "0x30E95C0", Length = "0x80")]
		[Token(Token = "0x6000101")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700004C")]
	public GUISettings settings
	{
		[Address(RVA = "0x30E9A80", Offset = "0x30E8E80", Length = "0xA")]
		[Token(Token = "0x6000104")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700003E")]
	internal GUIStyle sliderMixed
	{
		[Address(RVA = "0x2F94480", Offset = "0x2F93880", Length = "0xA")]
		[Token(Token = "0x60000E8")]
		internal get { } //Length: 10
		[Address(RVA = "0x30EA240", Offset = "0x30E9640", Length = "0x80")]
		[Token(Token = "0x60000E9")]
		internal set { } //Length: 128
	}

	[Token(Token = "0x17000037")]
	public GUIStyle textArea
	{
		[Address(RVA = "0x2F944D0", Offset = "0x2F938D0", Length = "0x7")]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 7
		[Address(RVA = "0x30EA2C0", Offset = "0x30E96C0", Length = "0x7A")]
		[Token(Token = "0x60000DB")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000036")]
	public GUIStyle textField
	{
		[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
		[Token(Token = "0x60000D8")]
		 get { } //Length: 7
		[Address(RVA = "0x30EA340", Offset = "0x30E9740", Length = "0x7A")]
		[Token(Token = "0x60000D9")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000039")]
	public GUIStyle toggle
	{
		[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
		[Token(Token = "0x60000DE")]
		 get { } //Length: 7
		[Address(RVA = "0x30EA3C0", Offset = "0x30E97C0", Length = "0x7A")]
		[Token(Token = "0x60000DF")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000046")]
	public GUIStyle verticalScrollbar
	{
		[Address(RVA = "0x26D4F00", Offset = "0x26D4300", Length = "0xA")]
		[Token(Token = "0x60000F8")]
		 get { } //Length: 10
		[Address(RVA = "0x30EA5C0", Offset = "0x30E99C0", Length = "0x80")]
		[Token(Token = "0x60000F9")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000049")]
	public GUIStyle verticalScrollbarDownButton
	{
		[Address(RVA = "0x30E9A90", Offset = "0x30E8E90", Length = "0xA")]
		[Token(Token = "0x60000FE")]
		 get { } //Length: 10
		[Address(RVA = "0x30EA440", Offset = "0x30E9840", Length = "0x80")]
		[Token(Token = "0x60000FF")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000047")]
	public GUIStyle verticalScrollbarThumb
	{
		[Address(RVA = "0x2F91460", Offset = "0x2F90860", Length = "0xA")]
		[Token(Token = "0x60000FA")]
		 get { } //Length: 10
		[Address(RVA = "0x30EA4C0", Offset = "0x30E98C0", Length = "0x80")]
		[Token(Token = "0x60000FB")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000048")]
	public GUIStyle verticalScrollbarUpButton
	{
		[Address(RVA = "0x30E9AA0", Offset = "0x30E8EA0", Length = "0xA")]
		[Token(Token = "0x60000FC")]
		 get { } //Length: 10
		[Address(RVA = "0x30EA540", Offset = "0x30E9940", Length = "0x80")]
		[Token(Token = "0x60000FD")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700003F")]
	public GUIStyle verticalSlider
	{
		[Address(RVA = "0x2F94520", Offset = "0x2F93920", Length = "0x7")]
		[Token(Token = "0x60000EA")]
		 get { } //Length: 7
		[Address(RVA = "0x30EA740", Offset = "0x30E9B40", Length = "0x7A")]
		[Token(Token = "0x60000EB")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000040")]
	public GUIStyle verticalSliderThumb
	{
		[Address(RVA = "0x2F944B0", Offset = "0x2F938B0", Length = "0x7")]
		[Token(Token = "0x60000EC")]
		 get { } //Length: 7
		[Address(RVA = "0x30EA6C0", Offset = "0x30E9AC0", Length = "0x7A")]
		[Token(Token = "0x60000ED")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000041")]
	internal GUIStyle verticalSliderThumbExtent
	{
		[Address(RVA = "0x2F94460", Offset = "0x2F93860", Length = "0xA")]
		[Token(Token = "0x60000EE")]
		internal get { } //Length: 10
		[Address(RVA = "0x30EA640", Offset = "0x30E9A40", Length = "0x7D")]
		[Token(Token = "0x60000EF")]
		internal set { } //Length: 125
	}

	[Token(Token = "0x1700003A")]
	public GUIStyle window
	{
		[Address(RVA = "0x2F944F0", Offset = "0x2F938F0", Length = "0x7")]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 7
		[Address(RVA = "0x30EA7C0", Offset = "0x30E9BC0", Length = "0x7A")]
		[Token(Token = "0x60000E1")]
		 set { } //Length: 122
	}

	[Address(RVA = "0x30E9860", Offset = "0x30E8C60", Length = "0xDD")]
	[Token(Token = "0x60000CF")]
	public GUISkin() { }

	[Address(RVA = "0x30E7ED0", Offset = "0x30E72D0", Length = "0x6D")]
	[Token(Token = "0x6000106")]
	internal void Apply() { }

	[Address(RVA = "0x30E7F40", Offset = "0x30E7340", Length = "0x1338")]
	[Token(Token = "0x6000107")]
	private void BuildStyleCache() { }

	[Address(RVA = "0x30E9280", Offset = "0x30E8680", Length = "0x7D")]
	[Token(Token = "0x60000D1")]
	internal static void CleanupRoots() { }

	[Address(RVA = "0x30E9300", Offset = "0x30E8700", Length = "0x8E")]
	[Token(Token = "0x6000109")]
	public GUIStyle FindStyle(string styleName) { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x60000D4")]
	public GUIStyle get_box() { }

	[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
	[Token(Token = "0x60000DC")]
	public GUIStyle get_button() { }

	[Address(RVA = "0x30E9940", Offset = "0x30E8D40", Length = "0xA")]
	[Token(Token = "0x6000102")]
	public GUIStyle[] get_customStyles() { }

	[Address(RVA = "0x30E9950", Offset = "0x30E8D50", Length = "0xFA")]
	[Token(Token = "0x6000105")]
	internal static GUIStyle get_error() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x60000D2")]
	public Font get_font() { }

	[Address(RVA = "0x30E9A60", Offset = "0x30E8E60", Length = "0xA")]
	[Token(Token = "0x60000F0")]
	public GUIStyle get_horizontalScrollbar() { }

	[Address(RVA = "0x2F92D10", Offset = "0x2F92110", Length = "0xA")]
	[Token(Token = "0x60000F4")]
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	[Address(RVA = "0x30E9A50", Offset = "0x30E8E50", Length = "0xA")]
	[Token(Token = "0x60000F6")]
	public GUIStyle get_horizontalScrollbarRightButton() { }

	[Address(RVA = "0x2F92D00", Offset = "0x2F92100", Length = "0xA")]
	[Token(Token = "0x60000F2")]
	public GUIStyle get_horizontalScrollbarThumb() { }

	[Address(RVA = "0x2F944E0", Offset = "0x2F938E0", Length = "0x7")]
	[Token(Token = "0x60000E2")]
	public GUIStyle get_horizontalSlider() { }

	[Address(RVA = "0x2F94500", Offset = "0x2F93900", Length = "0x7")]
	[Token(Token = "0x60000E4")]
	public GUIStyle get_horizontalSliderThumb() { }

	[Address(RVA = "0x2F94510", Offset = "0x2F93910", Length = "0x7")]
	[Token(Token = "0x60000E6")]
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	[Address(RVA = "0x2F944A0", Offset = "0x2F938A0", Length = "0x7")]
	[Token(Token = "0x60000D6")]
	public GUIStyle get_label() { }

	[Address(RVA = "0x30E9A70", Offset = "0x30E8E70", Length = "0xA")]
	[Token(Token = "0x6000100")]
	public GUIStyle get_scrollView() { }

	[Address(RVA = "0x30E9A80", Offset = "0x30E8E80", Length = "0xA")]
	[Token(Token = "0x6000104")]
	public GUISettings get_settings() { }

	[Address(RVA = "0x2F94480", Offset = "0x2F93880", Length = "0xA")]
	[Token(Token = "0x60000E8")]
	internal GUIStyle get_sliderMixed() { }

	[Address(RVA = "0x2F944D0", Offset = "0x2F938D0", Length = "0x7")]
	[Token(Token = "0x60000DA")]
	public GUIStyle get_textArea() { }

	[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
	[Token(Token = "0x60000D8")]
	public GUIStyle get_textField() { }

	[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
	[Token(Token = "0x60000DE")]
	public GUIStyle get_toggle() { }

	[Address(RVA = "0x26D4F00", Offset = "0x26D4300", Length = "0xA")]
	[Token(Token = "0x60000F8")]
	public GUIStyle get_verticalScrollbar() { }

	[Address(RVA = "0x30E9A90", Offset = "0x30E8E90", Length = "0xA")]
	[Token(Token = "0x60000FE")]
	public GUIStyle get_verticalScrollbarDownButton() { }

	[Address(RVA = "0x2F91460", Offset = "0x2F90860", Length = "0xA")]
	[Token(Token = "0x60000FA")]
	public GUIStyle get_verticalScrollbarThumb() { }

	[Address(RVA = "0x30E9AA0", Offset = "0x30E8EA0", Length = "0xA")]
	[Token(Token = "0x60000FC")]
	public GUIStyle get_verticalScrollbarUpButton() { }

	[Address(RVA = "0x2F94520", Offset = "0x2F93920", Length = "0x7")]
	[Token(Token = "0x60000EA")]
	public GUIStyle get_verticalSlider() { }

	[Address(RVA = "0x2F944B0", Offset = "0x2F938B0", Length = "0x7")]
	[Token(Token = "0x60000EC")]
	public GUIStyle get_verticalSliderThumb() { }

	[Address(RVA = "0x2F94460", Offset = "0x2F93860", Length = "0xA")]
	[Token(Token = "0x60000EE")]
	internal GUIStyle get_verticalSliderThumbExtent() { }

	[Address(RVA = "0x2F944F0", Offset = "0x2F938F0", Length = "0x7")]
	[Token(Token = "0x60000E0")]
	public GUIStyle get_window() { }

	[Address(RVA = "0x30E9390", Offset = "0x30E8790", Length = "0xB4")]
	[Token(Token = "0x600010B")]
	public IEnumerator GetEnumerator() { }

	[Address(RVA = "0x30E9450", Offset = "0x30E8850", Length = "0x2D9")]
	[Token(Token = "0x6000108")]
	public GUIStyle GetStyle(string styleName) { }

	[Address(RVA = "0x30E9730", Offset = "0x30E8B30", Length = "0x126")]
	[Token(Token = "0x600010A")]
	internal void MakeCurrent() { }

	[Address(RVA = "0x30E7ED0", Offset = "0x30E72D0", Length = "0x6D")]
	[Token(Token = "0x60000D0")]
	internal void OnEnable() { }

	[Address(RVA = "0x30E9AB0", Offset = "0x30E8EB0", Length = "0x7A")]
	[Token(Token = "0x60000D5")]
	public void set_box(GUIStyle value) { }

	[Address(RVA = "0x30E9B30", Offset = "0x30E8F30", Length = "0x7A")]
	[Token(Token = "0x60000DD")]
	public void set_button(GUIStyle value) { }

	[Address(RVA = "0x30E9BB0", Offset = "0x30E8FB0", Length = "0x80")]
	[Token(Token = "0x6000103")]
	public void set_customStyles(GUIStyle[] value) { }

	[Address(RVA = "0x30E9C30", Offset = "0x30E9030", Length = "0x190")]
	[Token(Token = "0x60000D3")]
	public void set_font(Font value) { }

	[Address(RVA = "0x30E9F40", Offset = "0x30E9340", Length = "0x80")]
	[Token(Token = "0x60000F1")]
	public void set_horizontalScrollbar(GUIStyle value) { }

	[Address(RVA = "0x30E9DC0", Offset = "0x30E91C0", Length = "0x80")]
	[Token(Token = "0x60000F5")]
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	[Address(RVA = "0x30E9E40", Offset = "0x30E9240", Length = "0x80")]
	[Token(Token = "0x60000F7")]
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	[Address(RVA = "0x30E9EC0", Offset = "0x30E92C0", Length = "0x80")]
	[Token(Token = "0x60000F3")]
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	[Address(RVA = "0x30EA0C0", Offset = "0x30E94C0", Length = "0x7A")]
	[Token(Token = "0x60000E3")]
	public void set_horizontalSlider(GUIStyle value) { }

	[Address(RVA = "0x30EA040", Offset = "0x30E9440", Length = "0x7A")]
	[Token(Token = "0x60000E5")]
	public void set_horizontalSliderThumb(GUIStyle value) { }

	[Address(RVA = "0x30E9FC0", Offset = "0x30E93C0", Length = "0x7A")]
	[Token(Token = "0x60000E7")]
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	[Address(RVA = "0x30EA140", Offset = "0x30E9540", Length = "0x7A")]
	[Token(Token = "0x60000D7")]
	public void set_label(GUIStyle value) { }

	[Address(RVA = "0x30EA1C0", Offset = "0x30E95C0", Length = "0x80")]
	[Token(Token = "0x6000101")]
	public void set_scrollView(GUIStyle value) { }

	[Address(RVA = "0x30EA240", Offset = "0x30E9640", Length = "0x80")]
	[Token(Token = "0x60000E9")]
	internal void set_sliderMixed(GUIStyle value) { }

	[Address(RVA = "0x30EA2C0", Offset = "0x30E96C0", Length = "0x7A")]
	[Token(Token = "0x60000DB")]
	public void set_textArea(GUIStyle value) { }

	[Address(RVA = "0x30EA340", Offset = "0x30E9740", Length = "0x7A")]
	[Token(Token = "0x60000D9")]
	public void set_textField(GUIStyle value) { }

	[Address(RVA = "0x30EA3C0", Offset = "0x30E97C0", Length = "0x7A")]
	[Token(Token = "0x60000DF")]
	public void set_toggle(GUIStyle value) { }

	[Address(RVA = "0x30EA5C0", Offset = "0x30E99C0", Length = "0x80")]
	[Token(Token = "0x60000F9")]
	public void set_verticalScrollbar(GUIStyle value) { }

	[Address(RVA = "0x30EA440", Offset = "0x30E9840", Length = "0x80")]
	[Token(Token = "0x60000FF")]
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	[Address(RVA = "0x30EA4C0", Offset = "0x30E98C0", Length = "0x80")]
	[Token(Token = "0x60000FB")]
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	[Address(RVA = "0x30EA540", Offset = "0x30E9940", Length = "0x80")]
	[Token(Token = "0x60000FD")]
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	[Address(RVA = "0x30EA740", Offset = "0x30E9B40", Length = "0x7A")]
	[Token(Token = "0x60000EB")]
	public void set_verticalSlider(GUIStyle value) { }

	[Address(RVA = "0x30EA6C0", Offset = "0x30E9AC0", Length = "0x7A")]
	[Token(Token = "0x60000ED")]
	public void set_verticalSliderThumb(GUIStyle value) { }

	[Address(RVA = "0x30EA640", Offset = "0x30E9A40", Length = "0x7D")]
	[Token(Token = "0x60000EF")]
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	[Address(RVA = "0x30EA7C0", Offset = "0x30E9BC0", Length = "0x7A")]
	[Token(Token = "0x60000E1")]
	public void set_window(GUIStyle value) { }

}

