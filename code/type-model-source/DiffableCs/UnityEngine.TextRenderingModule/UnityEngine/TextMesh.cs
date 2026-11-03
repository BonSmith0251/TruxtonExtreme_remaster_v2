namespace UnityEngine;

[NativeClass("TextRenderingPrivate::TextMesh")]
[NativeHeader("Modules/TextRendering/Public/TextMesh.h")]
[RequireComponent(typeof(Transform), typeof(MeshRenderer))]
[Token(Token = "0x200000C")]
public sealed class TextMesh : Component
{

	[Token(Token = "0x1700000D")]
	public TextAlignment alignment
	{
		[Address(RVA = "0x31CDBB0", Offset = "0x31CCFB0", Length = "0x76")]
		[Token(Token = "0x6000033")]
		 get { } //Length: 118
		[Address(RVA = "0x31CE590", Offset = "0x31CD990", Length = "0x83")]
		[Token(Token = "0x6000034")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700000E")]
	public TextAnchor anchor
	{
		[Address(RVA = "0x31CDC70", Offset = "0x31CD070", Length = "0x76")]
		[Token(Token = "0x6000035")]
		 get { } //Length: 118
		[Address(RVA = "0x31CE660", Offset = "0x31CDA60", Length = "0x83")]
		[Token(Token = "0x6000036")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700000F")]
	public float characterSize
	{
		[Address(RVA = "0x31CDD30", Offset = "0x31CD130", Length = "0x76")]
		[Token(Token = "0x6000037")]
		 get { } //Length: 118
		[Address(RVA = "0x31CE740", Offset = "0x31CDB40", Length = "0x86")]
		[Token(Token = "0x6000038")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000013")]
	public Color color
	{
		[Address(RVA = "0x31CDE00", Offset = "0x31CD200", Length = "0x8E")]
		[Token(Token = "0x600003F")]
		 get { } //Length: 142
		[Address(RVA = "0x31CE820", Offset = "0x31CDC20", Length = "0x85")]
		[Token(Token = "0x6000040")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000009")]
	public Font font
	{
		[Address(RVA = "0x31CE050", Offset = "0x31CD450", Length = "0x90")]
		[Token(Token = "0x600002B")]
		 get { } //Length: 144
		[Address(RVA = "0x31CEAA0", Offset = "0x31CDEA0", Length = "0xBA")]
		[Token(Token = "0x600002C")]
		 set { } //Length: 186
	}

	[Token(Token = "0x1700000A")]
	public int fontSize
	{
		[Address(RVA = "0x31CDED0", Offset = "0x31CD2D0", Length = "0x76")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 118
		[Address(RVA = "0x31CE8F0", Offset = "0x31CDCF0", Length = "0x83")]
		[Token(Token = "0x600002E")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700000B")]
	public FontStyle fontStyle
	{
		[Address(RVA = "0x31CDF90", Offset = "0x31CD390", Length = "0x76")]
		[Token(Token = "0x600002F")]
		 get { } //Length: 118
		[Address(RVA = "0x31CE9C0", Offset = "0x31CDDC0", Length = "0x83")]
		[Token(Token = "0x6000030")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000010")]
	public float lineSpacing
	{
		[Address(RVA = "0x31CE130", Offset = "0x31CD530", Length = "0x76")]
		[Token(Token = "0x6000039")]
		 get { } //Length: 118
		[Address(RVA = "0x31CEBB0", Offset = "0x31CDFB0", Length = "0x86")]
		[Token(Token = "0x600003A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000C")]
	public float offsetZ
	{
		[Address(RVA = "0x31CE1F0", Offset = "0x31CD5F0", Length = "0x76")]
		[Token(Token = "0x6000031")]
		 get { } //Length: 118
		[Address(RVA = "0x31CEC90", Offset = "0x31CE090", Length = "0x86")]
		[Token(Token = "0x6000032")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000012")]
	public bool richText
	{
		[Address(RVA = "0x31CE2B0", Offset = "0x31CD6B0", Length = "0x76")]
		[Token(Token = "0x600003D")]
		 get { } //Length: 118
		[Address(RVA = "0x31CED70", Offset = "0x31CE170", Length = "0x86")]
		[Token(Token = "0x600003E")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000011")]
	public float tabSize
	{
		[Address(RVA = "0x31CE370", Offset = "0x31CD770", Length = "0x76")]
		[Token(Token = "0x600003B")]
		 get { } //Length: 118
		[Address(RVA = "0x31CEE50", Offset = "0x31CE250", Length = "0x86")]
		[Token(Token = "0x600003C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000008")]
	public string text
	{
		[Address(RVA = "0x31CE440", Offset = "0x31CD840", Length = "0x106")]
		[Token(Token = "0x6000029")]
		 get { } //Length: 262
		[Address(RVA = "0x31CEF30", Offset = "0x31CE330", Length = "0x1C7")]
		[Token(Token = "0x600002A")]
		 set { } //Length: 455
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000041")]
	public TextMesh() { }

	[Address(RVA = "0x31CDBB0", Offset = "0x31CCFB0", Length = "0x76")]
	[Token(Token = "0x6000033")]
	public TextAlignment get_alignment() { }

	[Address(RVA = "0x31CDB70", Offset = "0x31CCF70", Length = "0x33")]
	[Token(Token = "0x600004C")]
	private static TextAlignment get_alignment_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CDC70", Offset = "0x31CD070", Length = "0x76")]
	[Token(Token = "0x6000035")]
	public TextAnchor get_anchor() { }

	[Address(RVA = "0x31CDC30", Offset = "0x31CD030", Length = "0x33")]
	[Token(Token = "0x600004E")]
	private static TextAnchor get_anchor_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CDD30", Offset = "0x31CD130", Length = "0x76")]
	[Token(Token = "0x6000037")]
	public float get_characterSize() { }

	[Address(RVA = "0x31CDCF0", Offset = "0x31CD0F0", Length = "0x33")]
	[Token(Token = "0x6000050")]
	private static float get_characterSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CDE00", Offset = "0x31CD200", Length = "0x8E")]
	[Token(Token = "0x600003F")]
	public Color get_color() { }

	[Address(RVA = "0x31CDDB0", Offset = "0x31CD1B0", Length = "0x42")]
	[Token(Token = "0x6000058")]
	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x31CE050", Offset = "0x31CD450", Length = "0x90")]
	[Token(Token = "0x600002B")]
	public Font get_font() { }

	[Address(RVA = "0x31CE010", Offset = "0x31CD410", Length = "0x33")]
	[Token(Token = "0x6000044")]
	private static IntPtr get_font_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CDED0", Offset = "0x31CD2D0", Length = "0x76")]
	[Token(Token = "0x600002D")]
	public int get_fontSize() { }

	[Address(RVA = "0x31CDE90", Offset = "0x31CD290", Length = "0x33")]
	[Token(Token = "0x6000046")]
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CDF90", Offset = "0x31CD390", Length = "0x76")]
	[Token(Token = "0x600002F")]
	public FontStyle get_fontStyle() { }

	[Address(RVA = "0x31CDF50", Offset = "0x31CD350", Length = "0x33")]
	[Token(Token = "0x6000048")]
	private static FontStyle get_fontStyle_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CE130", Offset = "0x31CD530", Length = "0x76")]
	[Token(Token = "0x6000039")]
	public float get_lineSpacing() { }

	[Address(RVA = "0x31CE0F0", Offset = "0x31CD4F0", Length = "0x33")]
	[Token(Token = "0x6000052")]
	private static float get_lineSpacing_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CE1F0", Offset = "0x31CD5F0", Length = "0x76")]
	[Token(Token = "0x6000031")]
	public float get_offsetZ() { }

	[Address(RVA = "0x31CE1B0", Offset = "0x31CD5B0", Length = "0x33")]
	[Token(Token = "0x600004A")]
	private static float get_offsetZ_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CE2B0", Offset = "0x31CD6B0", Length = "0x76")]
	[Token(Token = "0x600003D")]
	public bool get_richText() { }

	[Address(RVA = "0x31CE270", Offset = "0x31CD670", Length = "0x33")]
	[Token(Token = "0x6000056")]
	private static bool get_richText_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CE370", Offset = "0x31CD770", Length = "0x76")]
	[Token(Token = "0x600003B")]
	public float get_tabSize() { }

	[Address(RVA = "0x31CE330", Offset = "0x31CD730", Length = "0x33")]
	[Token(Token = "0x6000054")]
	private static float get_tabSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CE440", Offset = "0x31CD840", Length = "0x106")]
	[Token(Token = "0x6000029")]
	public string get_text() { }

	[Address(RVA = "0x31CE3F0", Offset = "0x31CD7F0", Length = "0x42")]
	[Token(Token = "0x6000042")]
	private static void get_text_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x31CE590", Offset = "0x31CD990", Length = "0x83")]
	[Token(Token = "0x6000034")]
	public void set_alignment(TextAlignment value) { }

	[Address(RVA = "0x31CE550", Offset = "0x31CD950", Length = "0x40")]
	[Token(Token = "0x600004D")]
	private static void set_alignment_Injected(IntPtr _unity_self, TextAlignment value) { }

	[Address(RVA = "0x31CE660", Offset = "0x31CDA60", Length = "0x83")]
	[Token(Token = "0x6000036")]
	public void set_anchor(TextAnchor value) { }

	[Address(RVA = "0x31CE620", Offset = "0x31CDA20", Length = "0x40")]
	[Token(Token = "0x600004F")]
	private static void set_anchor_Injected(IntPtr _unity_self, TextAnchor value) { }

	[Address(RVA = "0x31CE740", Offset = "0x31CDB40", Length = "0x86")]
	[Token(Token = "0x6000038")]
	public void set_characterSize(float value) { }

	[Address(RVA = "0x31CE6F0", Offset = "0x31CDAF0", Length = "0x43")]
	[Token(Token = "0x6000051")]
	private static void set_characterSize_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x31CE820", Offset = "0x31CDC20", Length = "0x85")]
	[Token(Token = "0x6000040")]
	public void set_color(Color value) { }

	[Address(RVA = "0x31CE7D0", Offset = "0x31CDBD0", Length = "0x42")]
	[Token(Token = "0x6000059")]
	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

	[Address(RVA = "0x31CEAA0", Offset = "0x31CDEA0", Length = "0xBA")]
	[Token(Token = "0x600002C")]
	public void set_font(Font value) { }

	[Address(RVA = "0x31CEA50", Offset = "0x31CDE50", Length = "0x42")]
	[Token(Token = "0x6000045")]
	private static void set_font_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x31CE8F0", Offset = "0x31CDCF0", Length = "0x83")]
	[Token(Token = "0x600002E")]
	public void set_fontSize(int value) { }

	[Address(RVA = "0x31CE8B0", Offset = "0x31CDCB0", Length = "0x40")]
	[Token(Token = "0x6000047")]
	private static void set_fontSize_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x31CE9C0", Offset = "0x31CDDC0", Length = "0x83")]
	[Token(Token = "0x6000030")]
	public void set_fontStyle(FontStyle value) { }

	[Address(RVA = "0x31CE980", Offset = "0x31CDD80", Length = "0x40")]
	[Token(Token = "0x6000049")]
	private static void set_fontStyle_Injected(IntPtr _unity_self, FontStyle value) { }

	[Address(RVA = "0x31CEBB0", Offset = "0x31CDFB0", Length = "0x86")]
	[Token(Token = "0x600003A")]
	public void set_lineSpacing(float value) { }

	[Address(RVA = "0x31CEB60", Offset = "0x31CDF60", Length = "0x43")]
	[Token(Token = "0x6000053")]
	private static void set_lineSpacing_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x31CEC90", Offset = "0x31CE090", Length = "0x86")]
	[Token(Token = "0x6000032")]
	public void set_offsetZ(float value) { }

	[Address(RVA = "0x31CEC40", Offset = "0x31CE040", Length = "0x43")]
	[Token(Token = "0x600004B")]
	private static void set_offsetZ_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x31CED70", Offset = "0x31CE170", Length = "0x86")]
	[Token(Token = "0x600003E")]
	public void set_richText(bool value) { }

	[Address(RVA = "0x31CED20", Offset = "0x31CE120", Length = "0x42")]
	[Token(Token = "0x6000057")]
	private static void set_richText_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x31CEE50", Offset = "0x31CE250", Length = "0x86")]
	[Token(Token = "0x600003C")]
	public void set_tabSize(float value) { }

	[Address(RVA = "0x31CEE00", Offset = "0x31CE200", Length = "0x43")]
	[Token(Token = "0x6000055")]
	private static void set_tabSize_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x31CEF30", Offset = "0x31CE330", Length = "0x1C7")]
	[Token(Token = "0x600002A")]
	public void set_text(string value) { }

	[Address(RVA = "0x31CEEE0", Offset = "0x31CE2E0", Length = "0x42")]
	[Token(Token = "0x6000043")]
	private static void set_text_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

}

