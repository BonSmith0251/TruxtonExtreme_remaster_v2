namespace UnityEngine.TextCore;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextGenerationSettings.h")]
[Token(Token = "0x2000005")]
[UsedByNativeCode("TextGenerationSettings")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct NativeTextGenerationSettings
{
	[CompilerGenerated]
	[Token(Token = "0x2000006")]
	private sealed class <>c
	{
		[Token(Token = "0x400001A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400001B")]
		public static Predicate<TextSpan> <>9__24_0; //Field offset: 0x8

		[Address(RVA = "0x3191230", Offset = "0x3190630", Length = "0x67")]
		[Token(Token = "0x6000009")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600000A")]
		public <>c() { }

		[Address(RVA = "0x31911B0", Offset = "0x31905B0", Length = "0x8")]
		[Token(Token = "0x600000B")]
		internal bool <get_hasLink>b__24_0(TextSpan span) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000003")]
	public IntPtr fontAsset; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000004")]
	public IntPtr textSettings; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000005")]
	public string text; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000006")]
	public int screenWidth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000007")]
	public int screenHeight; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000008")]
	public bool wordWrapEnabled; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000009")]
	public TextOverflow overflow; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000A")]
	public LanguageDirection languageDirection; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400000B")]
	public int vertexPadding; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal HorizontalAlignment horizontalAlignment; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400000D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal VerticalAlignment verticalAlignment; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000E")]
	public int fontSize; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400000F")]
	public bool bestFit; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000010")]
	public int maxFontSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000011")]
	public int minFontSize; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000012")]
	public FontStyles fontStyle; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000013")]
	public TextFontWeight fontWeight; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000014")]
	public TextSpan[] textSpans; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000015")]
	public Color32 color; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000016")]
	public int characterSpacing; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000017")]
	public int wordSpacing; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000018")]
	public int paragraphSpacing; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000019")]
	public PreProcessFlags preProcessFlags; //Field offset: 0x68

	[Token(Token = "0x17000002")]
	public static NativeTextGenerationSettings Default
	{
		[Address(RVA = "0x3184900", Offset = "0x3183D00", Length = "0x53")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000001")]
	public bool hasLink
	{
		[Address(RVA = "0x3184960", Offset = "0x3183D60", Length = "0x122")]
		[Token(Token = "0x6000005")]
		 get { } //Length: 290
	}

	[Address(RVA = "0x3183D00", Offset = "0x3183100", Length = "0x1BC")]
	[IsReadOnly]
	[Token(Token = "0x6000006")]
	public TextSpan CreateTextSpan() { }

	[Address(RVA = "0x3184900", Offset = "0x3183D00", Length = "0x53")]
	[Token(Token = "0x6000007")]
	public static NativeTextGenerationSettings get_Default() { }

	[Address(RVA = "0x3184960", Offset = "0x3183D60", Length = "0x122")]
	[Token(Token = "0x6000005")]
	public bool get_hasLink() { }

	[Address(RVA = "0x3183EC0", Offset = "0x31832C0", Length = "0xA3D")]
	[Token(Token = "0x6000008")]
	public virtual string ToString() { }

}

