namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIContent.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x200000C")]
public class GUIContent
{
	[Token(Token = "0x4000052")]
	private static readonly GUIContent s_Text; //Field offset: 0x0
	[Token(Token = "0x4000053")]
	private static readonly GUIContent s_Image; //Field offset: 0x8
	[Token(Token = "0x4000054")]
	private static readonly GUIContent s_TextImage; //Field offset: 0x10
	[Token(Token = "0x4000055")]
	internal static string k_ZeroWidthSpace; //Field offset: 0x18
	[Token(Token = "0x4000056")]
	public static GUIContent none; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400004D")]
	private string m_Text; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400004E")]
	private Texture m_Image; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400004F")]
	private string m_Tooltip; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000050")]
	private string m_TextWithWhitespace; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000051")]
	private Action OnTextChanged; //Field offset: 0x30

	[Token(Token = "0x14000001")]
	internal event Action OnTextChanged
	{
		[Address(RVA = "0x30E02F0", Offset = "0x30DF6F0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000097")]
		internal add { } //Length: 158
		[Address(RVA = "0x30E0400", Offset = "0x30DF800", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000098")]
		internal remove { } //Length: 158
	}

	[Token(Token = "0x1700002F")]
	public Texture image
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600009E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002D")]
	public string text
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x6000099")]
		 get { } //Length: 7
		[Address(RVA = "0x30E0520", Offset = "0x30DF920", Length = "0x60")]
		[Token(Token = "0x600009A")]
		 set { } //Length: 96
	}

	[Token(Token = "0x1700002E")]
	internal string textWithWhitespace
	{
		[Address(RVA = "0x30E0390", Offset = "0x30DF790", Length = "0x6E")]
		[Token(Token = "0x600009B")]
		internal get { } //Length: 110
		[Address(RVA = "0x30E04A0", Offset = "0x30DF8A0", Length = "0x7B")]
		[Token(Token = "0x600009C")]
		internal set { } //Length: 123
	}

	[Token(Token = "0x17000030")]
	public string tooltip
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x600009F")]
		 get { } //Length: 7
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60000A0")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x30DFDB0", Offset = "0x30DF1B0", Length = "0x25B")]
	[Token(Token = "0x60000A9")]
	private static GUIContent() { }

	[Address(RVA = "0x30E0130", Offset = "0x30DF530", Length = "0x104")]
	[Token(Token = "0x60000A5")]
	public GUIContent(GUIContent src) { }

	[Address(RVA = "0x30E0010", Offset = "0x30DF410", Length = "0x100")]
	[Token(Token = "0x60000A4")]
	public GUIContent(string text, Texture image, string tooltip) { }

	[Address(RVA = "0x30E0110", Offset = "0x30DF510", Length = "0x1D")]
	[Token(Token = "0x60000A3")]
	public GUIContent(string text, string tooltip) { }

	[Address(RVA = "0x30E02C0", Offset = "0x30DF6C0", Length = "0x2B")]
	[Token(Token = "0x60000A2")]
	public GUIContent(string text) { }

	[Address(RVA = "0x30E0240", Offset = "0x30DF640", Length = "0x72")]
	[Token(Token = "0x60000A1")]
	public GUIContent() { }

	[Address(RVA = "0x30E02F0", Offset = "0x30DF6F0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000097")]
	internal void add_OnTextChanged(Action value) { }

	[Address(RVA = "0x30DFA80", Offset = "0x30DEE80", Length = "0x1D6")]
	[Token(Token = "0x60000A7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void ClearStaticCache() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x6000099")]
	public string get_text() { }

	[Address(RVA = "0x30E0390", Offset = "0x30DF790", Length = "0x6E")]
	[Token(Token = "0x600009B")]
	internal string get_textWithWhitespace() { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x600009F")]
	public string get_tooltip() { }

	[Address(RVA = "0x30E0400", Offset = "0x30DF800", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000098")]
	internal void remove_OnTextChanged(Action value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x600009E")]
	public void set_image(Texture value) { }

	[Address(RVA = "0x30E0520", Offset = "0x30DF920", Length = "0x60")]
	[Token(Token = "0x600009A")]
	public void set_text(string value) { }

	[Address(RVA = "0x30E04A0", Offset = "0x30DF8A0", Length = "0x7B")]
	[Token(Token = "0x600009C")]
	internal void set_textWithWhitespace(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60000A0")]
	public void set_tooltip(string value) { }

	[Address(RVA = "0x30DFC60", Offset = "0x30DF060", Length = "0x35")]
	[Token(Token = "0x600009D")]
	internal void SetTextWithoutNotify(string value) { }

	[Address(RVA = "0x30DFCA0", Offset = "0x30DF0A0", Length = "0xD4")]
	[Token(Token = "0x60000A6")]
	internal static GUIContent Temp(string t) { }

	[Address(RVA = "0x30DFD80", Offset = "0x30DF180", Length = "0x22")]
	[Token(Token = "0x60000A8")]
	public virtual string ToString() { }

}

