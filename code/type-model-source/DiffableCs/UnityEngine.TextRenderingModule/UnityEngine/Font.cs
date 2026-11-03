namespace UnityEngine;

[NativeClass("TextRendering::Font")]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[StaticAccessor("TextRenderingPrivate", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000011")]
public sealed class Font : object
{
	[Token(Token = "0x2000012")]
	internal sealed class FontTextureRebuildCallback : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x6000092")]
		public FontTextureRebuildCallback(object object, IntPtr method) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x6000093")]
		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000057")]
	private static Action<Font> textureRebuilt; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000058")]
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; //Field offset: 0x18

	[Token(Token = "0x14000002")]
	private event FontTextureRebuildCallback m_FontTextureRebuildCallback
	{
		[Address(RVA = "0x31CABD0", Offset = "0x31C9FD0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600005D")]
		private add { } //Length: 158
		[Address(RVA = "0x31CB340", Offset = "0x31CA740", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600005E")]
		private remove { } //Length: 158
	}

	[Token(Token = "0x14000001")]
	public static event Action<Font> textureRebuilt
	{
		[Address(RVA = "0x31CAC70", Offset = "0x31CA070", Length = "0xD7")]
		[CompilerGenerated]
		[Token(Token = "0x600005B")]
		 add { } //Length: 215
		[Address(RVA = "0x31CB3E0", Offset = "0x31CA7E0", Length = "0xD7")]
		[CompilerGenerated]
		[Token(Token = "0x600005C")]
		 remove { } //Length: 215
	}

	[Token(Token = "0x17000017")]
	public int ascent
	{
		[Address(RVA = "0x31CAD90", Offset = "0x31CA190", Length = "0x76")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000019")]
	public CharacterInfo[] characterInfo
	{
		[Address(RVA = "0x31CAE60", Offset = "0x31CA260", Length = "0xF9")]
		[FreeFunction("TextRenderingPrivate::GetFontCharacterInfo", HasExplicitThis = True)]
		[Token(Token = "0x6000066")]
		 get { } //Length: 249
		[Address(RVA = "0x31CB510", Offset = "0x31CA910", Length = "0x104")]
		[FreeFunction("TextRenderingPrivate::SetFontCharacterInfo", HasExplicitThis = True)]
		[Token(Token = "0x6000067")]
		 set { } //Length: 260
	}

	[Token(Token = "0x17000016")]
	public bool dynamic
	{
		[Address(RVA = "0x31CAFA0", Offset = "0x31CA3A0", Length = "0x76")]
		[Token(Token = "0x6000063")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000015")]
	public String[] fontNames
	{
		[Address(RVA = "0x31CB060", Offset = "0x31CA460", Length = "0x76")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 118
		[Address(RVA = "0x31CB670", Offset = "0x31CAA70", Length = "0x85")]
		[Token(Token = "0x6000062")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000018")]
	public int fontSize
	{
		[Address(RVA = "0x31CB120", Offset = "0x31CA520", Length = "0x76")]
		[Token(Token = "0x6000065")]
		 get { } //Length: 118
	}

	[NativeProperty("LineSpacing", False, TargetType::Function (0))]
	[Token(Token = "0x1700001A")]
	public int lineHeight
	{
		[Address(RVA = "0x31CB1E0", Offset = "0x31CA5E0", Length = "0x76")]
		[Token(Token = "0x6000068")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000014")]
	public Material material
	{
		[Address(RVA = "0x31CB2A0", Offset = "0x31CA6A0", Length = "0x90")]
		[Token(Token = "0x600005F")]
		 get { } //Length: 144
		[Address(RVA = "0x31CB750", Offset = "0x31CAB50", Length = "0xBA")]
		[Token(Token = "0x6000060")]
		 set { } //Length: 186
	}

	[Obsolete("Font.textureRebuildCallback has been deprecated. Use Font.textureRebuilt instead.")]
	[Token(Token = "0x1700001B")]
	public FontTextureRebuildCallback textureRebuildCallback
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x6000069")]
		 get { } //Length: 7
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600006A")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x31CAA80", Offset = "0x31C9E80", Length = "0x8D")]
	[Token(Token = "0x600006D")]
	private Font(String[] names, int size) { }

	[Address(RVA = "0x31CAB10", Offset = "0x31C9F10", Length = "0xBE")]
	[Token(Token = "0x600006C")]
	public Font(string name) { }

	[Address(RVA = "0x31CAA20", Offset = "0x31C9E20", Length = "0x56")]
	[Token(Token = "0x600006B")]
	public Font() { }

	[Address(RVA = "0x31CABD0", Offset = "0x31C9FD0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600005D")]
	private void add_m_FontTextureRebuildCallback(FontTextureRebuildCallback value) { }

	[Address(RVA = "0x31CAC70", Offset = "0x31CA070", Length = "0xD7")]
	[CompilerGenerated]
	[Token(Token = "0x600005B")]
	public static void add_textureRebuilt(Action<Font> value) { }

	[Address(RVA = "0x31C9C70", Offset = "0x31C9070", Length = "0x63")]
	[Token(Token = "0x600006F")]
	public static Font CreateDynamicFontFromOSFont(String[] fontnames, int size) { }

	[Address(RVA = "0x31C9CE0", Offset = "0x31C90E0", Length = "0xA9")]
	[Token(Token = "0x600006E")]
	public static Font CreateDynamicFontFromOSFont(string fontname, int size) { }

	[Address(RVA = "0x31CAD90", Offset = "0x31CA190", Length = "0x76")]
	[Token(Token = "0x6000064")]
	public int get_ascent() { }

	[Address(RVA = "0x31CAD50", Offset = "0x31CA150", Length = "0x33")]
	[Token(Token = "0x6000087")]
	private static int get_ascent_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CAE60", Offset = "0x31CA260", Length = "0xF9")]
	[FreeFunction("TextRenderingPrivate::GetFontCharacterInfo", HasExplicitThis = True)]
	[Token(Token = "0x6000066")]
	public CharacterInfo[] get_characterInfo() { }

	[Address(RVA = "0x31CAE10", Offset = "0x31CA210", Length = "0x42")]
	[Token(Token = "0x6000089")]
	private static void get_characterInfo_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x31CAFA0", Offset = "0x31CA3A0", Length = "0x76")]
	[Token(Token = "0x6000063")]
	public bool get_dynamic() { }

	[Address(RVA = "0x31CAF60", Offset = "0x31CA360", Length = "0x33")]
	[Token(Token = "0x6000086")]
	private static bool get_dynamic_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CB060", Offset = "0x31CA460", Length = "0x76")]
	[Token(Token = "0x6000061")]
	public String[] get_fontNames() { }

	[Address(RVA = "0x31CB020", Offset = "0x31CA420", Length = "0x33")]
	[Token(Token = "0x6000084")]
	private static String[] get_fontNames_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CB120", Offset = "0x31CA520", Length = "0x76")]
	[Token(Token = "0x6000065")]
	public int get_fontSize() { }

	[Address(RVA = "0x31CB0E0", Offset = "0x31CA4E0", Length = "0x33")]
	[Token(Token = "0x6000088")]
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CB1E0", Offset = "0x31CA5E0", Length = "0x76")]
	[Token(Token = "0x6000068")]
	public int get_lineHeight() { }

	[Address(RVA = "0x31CB1A0", Offset = "0x31CA5A0", Length = "0x33")]
	[Token(Token = "0x600008B")]
	private static int get_lineHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CB2A0", Offset = "0x31CA6A0", Length = "0x90")]
	[Token(Token = "0x600005F")]
	public Material get_material() { }

	[Address(RVA = "0x31CB260", Offset = "0x31CA660", Length = "0x33")]
	[Token(Token = "0x6000082")]
	private static IntPtr get_material_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x6000069")]
	public FontTextureRebuildCallback get_textureRebuildCallback() { }

	[Address(RVA = "0x31C9F70", Offset = "0x31C9370", Length = "0xA0")]
	[ExcludeFromDocs]
	[Token(Token = "0x600007E")]
	public bool GetCharacterInfo(char ch, out CharacterInfo info) { }

	[Address(RVA = "0x31C9E00", Offset = "0x31C9200", Length = "0xB1")]
	[ExcludeFromDocs]
	[Token(Token = "0x600007D")]
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size) { }

	[Address(RVA = "0x31C9EC0", Offset = "0x31C92C0", Length = "0xA9")]
	[FreeFunction("TextRenderingPrivate::GetCharacterInfo", HasExplicitThis = True)]
	[Token(Token = "0x600007C")]
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { }

	[Address(RVA = "0x31C9D90", Offset = "0x31C9190", Length = "0x62")]
	[Token(Token = "0x6000090")]
	private static bool GetCharacterInfo_Injected(IntPtr _unity_self, char ch, out CharacterInfo info, int size, FontStyle style) { }

	[Address(RVA = "0x31CA050", Offset = "0x31C9450", Length = "0x54")]
	[Token(Token = "0x6000072")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.TextRenderingModule"})]
	internal static Font GetDefault() { }

	[Address(RVA = "0x31CA020", Offset = "0x31C9420", Length = "0x2A")]
	[Token(Token = "0x600008C")]
	private static IntPtr GetDefault_Injected() { }

	[Address(RVA = "0x31CA0B0", Offset = "0x31C94B0", Length = "0x1D")]
	[Token(Token = "0x6000071")]
	public static int GetMaxVertsForString(string str) { }

	[Address(RVA = "0x31CA0D0", Offset = "0x31C94D0", Length = "0x2A")]
	[Token(Token = "0x6000077")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static String[] GetOSFallbacks() { }

	[Address(RVA = "0x31CA100", Offset = "0x31C9500", Length = "0x2A")]
	[Token(Token = "0x6000075")]
	public static String[] GetOSInstalledFontNames() { }

	[Address(RVA = "0x31CA130", Offset = "0x31C9530", Length = "0x2A")]
	[Token(Token = "0x6000076")]
	public static String[] GetPathsToOSFonts() { }

	[Address(RVA = "0x31CA230", Offset = "0x31C9630", Length = "0x83")]
	[Token(Token = "0x6000074")]
	private bool HasCharacter(int c) { }

	[Address(RVA = "0x31CA1A0", Offset = "0x31C95A0", Length = "0x84")]
	[Token(Token = "0x6000073")]
	public bool HasCharacter(char c) { }

	[Address(RVA = "0x31CA160", Offset = "0x31C9560", Length = "0x40")]
	[Token(Token = "0x600008D")]
	private static bool HasCharacter_Injected(IntPtr _unity_self, int c) { }

	[Address(RVA = "0x31CA2C0", Offset = "0x31C96C0", Length = "0x52")]
	[Token(Token = "0x600007B")]
	private static void Internal_CreateDynamicFont(Font self, String[] _names, int size) { }

	[Address(RVA = "0x31CA550", Offset = "0x31C9950", Length = "0x187")]
	[Token(Token = "0x6000079")]
	private static void Internal_CreateFont(Font self, string name) { }

	[Address(RVA = "0x31CA500", Offset = "0x31C9900", Length = "0x42")]
	[Token(Token = "0x600008E")]
	private static void Internal_CreateFont_Injected(Font self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x31CA370", Offset = "0x31C9770", Length = "0x187")]
	[Token(Token = "0x600007A")]
	private static void Internal_CreateFontFromPath(Font self, string fontPath) { }

	[Address(RVA = "0x31CA320", Offset = "0x31C9720", Length = "0x42")]
	[Token(Token = "0x600008F")]
	private static void Internal_CreateFontFromPath_Injected(Font self, ref ManagedSpanWrapper fontPath) { }

	[Address(RVA = "0x31CA6E0", Offset = "0x31C9AE0", Length = "0x79")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000070")]
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	[Address(RVA = "0x31CA760", Offset = "0x31C9B60", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x6000078")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.CoreModule"})]
	internal static bool IsFontSmoothingEnabled() { }

	[Address(RVA = "0x31CB340", Offset = "0x31CA740", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600005E")]
	private void remove_m_FontTextureRebuildCallback(FontTextureRebuildCallback value) { }

	[Address(RVA = "0x31CB3E0", Offset = "0x31CA7E0", Length = "0xD7")]
	[CompilerGenerated]
	[Token(Token = "0x600005C")]
	public static void remove_textureRebuilt(Action<Font> value) { }

	[Address(RVA = "0x31CA800", Offset = "0x31C9C00", Length = "0x1DB")]
	[Token(Token = "0x600007F")]
	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	[Address(RVA = "0x31CAA00", Offset = "0x31C9E00", Length = "0x1A")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000080")]
	public void RequestCharactersInTexture(string characters, int size) { }

	[Address(RVA = "0x31CA9E0", Offset = "0x31C9DE0", Length = "0x1D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000081")]
	public void RequestCharactersInTexture(string characters) { }

	[Address(RVA = "0x31CA790", Offset = "0x31C9B90", Length = "0x62")]
	[Token(Token = "0x6000091")]
	private static void RequestCharactersInTexture_Injected(IntPtr _unity_self, ref ManagedSpanWrapper characters, int size, FontStyle style) { }

	[Address(RVA = "0x31CB510", Offset = "0x31CA910", Length = "0x104")]
	[FreeFunction("TextRenderingPrivate::SetFontCharacterInfo", HasExplicitThis = True)]
	[Token(Token = "0x6000067")]
	public void set_characterInfo(CharacterInfo[] value) { }

	[Address(RVA = "0x31CB4C0", Offset = "0x31CA8C0", Length = "0x42")]
	[Token(Token = "0x600008A")]
	private static void set_characterInfo_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x31CB670", Offset = "0x31CAA70", Length = "0x85")]
	[Token(Token = "0x6000062")]
	public void set_fontNames(String[] value) { }

	[Address(RVA = "0x31CB620", Offset = "0x31CAA20", Length = "0x42")]
	[Token(Token = "0x6000085")]
	private static void set_fontNames_Injected(IntPtr _unity_self, String[] value) { }

	[Address(RVA = "0x31CB750", Offset = "0x31CAB50", Length = "0xBA")]
	[Token(Token = "0x6000060")]
	public void set_material(Material value) { }

	[Address(RVA = "0x31CB700", Offset = "0x31CAB00", Length = "0x42")]
	[Token(Token = "0x6000083")]
	private static void set_material_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x600006A")]
	public void set_textureRebuildCallback(FontTextureRebuildCallback value) { }

}

