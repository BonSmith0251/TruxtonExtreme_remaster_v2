namespace TMPro;

[Token(Token = "0x20000AD")]
public class TMP_TextParsingUtilities
{
	[Token(Token = "0x4000657")]
	private static readonly TMP_TextParsingUtilities s_Instance; //Field offset: 0x0
	[Token(Token = "0x4000658")]
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; //Field offset: 0x0
	[Token(Token = "0x4000659")]
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; //Field offset: 0x0
	[Token(Token = "0x400065A")]
	private static readonly HashSet<UInt32> k_EmojiLookup; //Field offset: 0x8
	[Token(Token = "0x400065B")]
	private static readonly HashSet<UInt32> k_EmojiPresentationFormLookup; //Field offset: 0x10

	[Token(Token = "0x17000193")]
	public static TMP_TextParsingUtilities instance
	{
		[Address(RVA = "0x2F17BD0", Offset = "0x2F16FD0", Length = "0x4E")]
		[Token(Token = "0x6000697")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x2EF6E80", Offset = "0x2EF6280", Length = "0xCFB2")]
	[Token(Token = "0x6000696")]
	private static TMP_TextParsingUtilities() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60006A8")]
	public TMP_TextParsingUtilities() { }

	[Address(RVA = "0x2F174F0", Offset = "0x2F168F0", Length = "0xC")]
	[Token(Token = "0x60006A0")]
	internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	[Address(RVA = "0x2F17BD0", Offset = "0x2F16FD0", Length = "0x4E")]
	[Token(Token = "0x6000697")]
	public static TMP_TextParsingUtilities get_instance() { }

	[Address(RVA = "0x2F17560", Offset = "0x2F16960", Length = "0xD4")]
	[Token(Token = "0x6000698")]
	public static int GetHashCode(string s) { }

	[Address(RVA = "0x2F17500", Offset = "0x2F16900", Length = "0x57")]
	[Token(Token = "0x6000699")]
	public static int GetHashCodeCaseSensitive(string s) { }

	[Address(RVA = "0x2F17640", Offset = "0x2F16A40", Length = "0x108")]
	[Token(Token = "0x60006A2")]
	internal static bool IsBaseGlyph(uint c) { }

	[Address(RVA = "0x2F17750", Offset = "0x2F16B50", Length = "0xE0")]
	[Token(Token = "0x60006A7")]
	internal static bool IsCJK(uint c) { }

	[Address(RVA = "0x2F17830", Offset = "0x2F16C30", Length = "0x44")]
	[Token(Token = "0x60006A1")]
	internal static bool IsDiacriticalMark(uint c) { }

	[Address(RVA = "0x2F17900", Offset = "0x2F16D00", Length = "0x77")]
	[Token(Token = "0x60006A4")]
	internal static bool IsEmoji(uint c) { }

	[Address(RVA = "0x2F17880", Offset = "0x2F16C80", Length = "0x77")]
	[Token(Token = "0x60006A5")]
	internal static bool IsEmojiPresentationForm(uint c) { }

	[Address(RVA = "0x2F17980", Offset = "0x2F16D80", Length = "0x51")]
	[Token(Token = "0x60006A6")]
	internal static bool IsHangul(uint c) { }

	[Address(RVA = "0x2F179E0", Offset = "0x2F16DE0", Length = "0x15")]
	[Token(Token = "0x600069E")]
	public static bool IsHighSurrogate(uint c) { }

	[Address(RVA = "0x2F17A00", Offset = "0x2F16E00", Length = "0x2B")]
	[Token(Token = "0x60006A3")]
	internal static bool IsIgnorableForLigature(uint cp) { }

	[Address(RVA = "0x2F17A30", Offset = "0x2F16E30", Length = "0x15")]
	[Token(Token = "0x600069F")]
	public static bool IsLowSurrogate(uint c) { }

	[Address(RVA = "0x2F17AB0", Offset = "0x2F16EB0", Length = "0x5D")]
	[Token(Token = "0x600069D")]
	public static uint ToLowerASCIIFast(uint c) { }

	[Address(RVA = "0x2F17A50", Offset = "0x2F16E50", Length = "0x57")]
	[Token(Token = "0x600069A")]
	public static char ToLowerASCIIFast(char c) { }

	[Address(RVA = "0x2F17B70", Offset = "0x2F16F70", Length = "0x57")]
	[Token(Token = "0x600069B")]
	public static char ToUpperASCIIFast(char c) { }

	[Address(RVA = "0x2F17B10", Offset = "0x2F16F10", Length = "0x5D")]
	[Token(Token = "0x600069C")]
	public static uint ToUpperASCIIFast(uint c) { }

}

