namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200056C")]
public class TextInfo : ICloneable, IDeserializationCallback
{
	[Token(Token = "0x40016B2")]
	internal static TextInfo s_Invariant; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x40016AD")]
	private bool m_isReadOnly; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[OptionalField(VersionAdded = 3)]
	[Token(Token = "0x40016AE")]
	private string m_cultureName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016AF")]
	private CultureData m_cultureData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40016B0")]
	private string m_textInfoName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40016B1")]
	private Nullable<Boolean> m_IsAsciiCasingSameAsInvariant; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x40016B3")]
	private string customCultureName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40016B4")]
	internal bool m_useUserOverride; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40016B5")]
	internal int m_win32LangID; //Field offset: 0x44

	[ComVisible(False)]
	[Token(Token = "0x170005BD")]
	public string CultureName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60027DD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005BC")]
	internal static TextInfo Invariant
	{
		[Address(RVA = "0x1F7E3C0", Offset = "0x1F7D7C0", Length = "0x102")]
		[Token(Token = "0x60027D7")]
		internal get { } //Length: 258
	}

	[Token(Token = "0x170005BE")]
	private bool IsAsciiCasingSameAsInvariant
	{
		[Address(RVA = "0x1F7E4D0", Offset = "0x1F7D8D0", Length = "0xDB")]
		[Token(Token = "0x60027E7")]
		private get { } //Length: 219
	}

	[Address(RVA = "0x1F7E390", Offset = "0x1F7D790", Length = "0x2C")]
	[Token(Token = "0x60027F7")]
	internal TextInfo() { }

	[Address(RVA = "0x1F7E320", Offset = "0x1F7D720", Length = "0x6A")]
	[Token(Token = "0x60027D8")]
	internal TextInfo(CultureData cultureData) { }

	[Address(RVA = "0x1F7C6A0", Offset = "0x1F7BAA0", Length = "0x93")]
	[Token(Token = "0x60027EC")]
	private static int AddNonLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen) { }

	[Address(RVA = "0x1F7C740", Offset = "0x1F7BB40", Length = "0x68")]
	[Token(Token = "0x60027ED")]
	private int AddTitlecaseLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen) { }

	[Address(RVA = "0x1F7C910", Offset = "0x1F7BD10", Length = "0x146")]
	[Token(Token = "0x60027F6")]
	internal void ChangeCase(ReadOnlySpan<Char> source, Span<Char> destination, bool toUpper) { }

	[Address(RVA = "0x1F7CA60", Offset = "0x1F7BE60", Length = "0x7B")]
	[ComVisible(False)]
	[Token(Token = "0x60027DE")]
	public override object Clone() { }

	[Address(RVA = "0x1F7CAE0", Offset = "0x1F7BEE0", Length = "0x8D")]
	[Token(Token = "0x60027E8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60027DD")]
	public string get_CultureName() { }

	[Address(RVA = "0x1F7E3C0", Offset = "0x1F7D7C0", Length = "0x102")]
	[Token(Token = "0x60027D7")]
	internal static TextInfo get_Invariant() { }

	[Address(RVA = "0x1F7E4D0", Offset = "0x1F7D8D0", Length = "0xDB")]
	[Token(Token = "0x60027E7")]
	private bool get_IsAsciiCasingSameAsInvariant() { }

	[Address(RVA = "0x1F7CB70", Offset = "0x1F7BF70", Length = "0x2A")]
	[Token(Token = "0x60027E9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F7CBA0", Offset = "0x1F7BFA0", Length = "0xC")]
	[Token(Token = "0x60027E6")]
	private static bool IsAscii(char c) { }

	[Address(RVA = "0x1F7CBB0", Offset = "0x1F7BFB0", Length = "0xF")]
	[Token(Token = "0x60027EF")]
	private static bool IsLetterCategory(UnicodeCategory uc) { }

	[Address(RVA = "0x1F7CBC0", Offset = "0x1F7BFC0", Length = "0x10")]
	[Token(Token = "0x60027EE")]
	private static bool IsWordSeparator(UnicodeCategory category) { }

	[Address(RVA = "0x1F7CBD0", Offset = "0x1F7BFD0", Length = "0x120")]
	[Token(Token = "0x60027DA")]
	private void OnDeserialized() { }

	[Address(RVA = "0x1F7CD00", Offset = "0x1F7C100", Length = "0x7")]
	[OnDeserialized]
	[Token(Token = "0x60027DB")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x1F7CD10", Offset = "0x1F7C110", Length = "0x34")]
	[OnDeserializing]
	[Token(Token = "0x60027D9")]
	private void OnDeserializing(StreamingContext ctx) { }

	[Address(RVA = "0x1F7CD50", Offset = "0x1F7C150", Length = "0x90")]
	[OnSerializing]
	[Token(Token = "0x60027DC")]
	private void OnSerializing(StreamingContext ctx) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x60027DF")]
	internal void SetReadOnlyState(bool readOnly) { }

	[Address(RVA = "0x1F7CD00", Offset = "0x1F7C100", Length = "0x7")]
	[Token(Token = "0x60027F0")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x1F7D430", Offset = "0x1F7C830", Length = "0x5A")]
	[Token(Token = "0x60027E0")]
	public override char ToLower(char c) { }

	[Address(RVA = "0x1F7D490", Offset = "0x1F7C890", Length = "0x117")]
	[Token(Token = "0x60027E1")]
	public override string ToLower(string str) { }

	[Address(RVA = "0x1F7CDF0", Offset = "0x1F7C1F0", Length = "0x15")]
	[Token(Token = "0x60027E2")]
	private static char ToLowerAsciiInvariant(char c) { }

	[Address(RVA = "0x1F7D350", Offset = "0x1F7C750", Length = "0xD8")]
	[Token(Token = "0x60027F2")]
	private string ToLowerInternal(string str) { }

	[Address(RVA = "0x1F7CE10", Offset = "0x1F7C210", Length = "0x532")]
	[Token(Token = "0x60027F4")]
	private char ToLowerInternal(char c) { }

	[Address(RVA = "0x1F7D5B0", Offset = "0x1F7C9B0", Length = "0x4B")]
	[Token(Token = "0x60027EA")]
	public virtual string ToString() { }

	[Address(RVA = "0x1F7D600", Offset = "0x1F7CA00", Length = "0x3AF")]
	[Token(Token = "0x60027EB")]
	public string ToTitleCase(string str) { }

	[Address(RVA = "0x1F7E1A0", Offset = "0x1F7D5A0", Length = "0x117")]
	[Token(Token = "0x60027E4")]
	public override string ToUpper(string str) { }

	[Address(RVA = "0x1F7E2C0", Offset = "0x1F7D6C0", Length = "0x5E")]
	[Token(Token = "0x60027E3")]
	public override char ToUpper(char c) { }

	[Address(RVA = "0x1F7DA70", Offset = "0x1F7CE70", Length = "0x1B")]
	[Token(Token = "0x60027E5")]
	internal static char ToUpperAsciiInvariant(char c) { }

	[Address(RVA = "0x1F7D9B0", Offset = "0x1F7CDB0", Length = "0xB1")]
	[Token(Token = "0x60027F5")]
	internal void ToUpperAsciiInvariant(ReadOnlySpan<Char> source, Span<Char> destination) { }

	[Address(RVA = "0x1F7E0C0", Offset = "0x1F7D4C0", Length = "0xD8")]
	[Token(Token = "0x60027F1")]
	private string ToUpperInternal(string str) { }

	[Address(RVA = "0x1F7DA90", Offset = "0x1F7CE90", Length = "0x120")]
	[Token(Token = "0x60027F3")]
	private char ToUpperInternal(char c) { }

}

