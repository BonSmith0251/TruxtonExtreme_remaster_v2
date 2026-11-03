namespace System.Text.RegularExpressions;

[Token(Token = "0x20000EB")]
internal sealed class RegexFC
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003F5")]
	private RegexCharClass _cc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003F6")]
	public bool _nullable; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40003F7")]
	private bool <CaseInsensitive>k__BackingField; //Field offset: 0x19

	[Token(Token = "0x170000DE")]
	public private bool CaseInsensitive
	{
		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000552")]
		 get { } //Length: 5
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000553")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2624320", Offset = "0x2623720", Length = "0x78")]
	[Token(Token = "0x600054E")]
	public RegexFC(bool nullable) { }

	[Address(RVA = "0x2624220", Offset = "0x2623620", Length = "0xF9")]
	[Token(Token = "0x600054F")]
	public RegexFC(char ch, bool not, bool nullable, bool caseInsensitive) { }

	[Address(RVA = "0x26243A0", Offset = "0x26237A0", Length = "0xC8")]
	[Token(Token = "0x6000550")]
	public RegexFC(string charClass, bool nullable, bool caseInsensitive) { }

	[Address(RVA = "0x2624020", Offset = "0x2623420", Length = "0x8F")]
	[Token(Token = "0x6000551")]
	public bool AddFC(RegexFC fc, bool concatenate) { }

	[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000552")]
	public bool get_CaseInsensitive() { }

	[Address(RVA = "0x26240B0", Offset = "0x26234B0", Length = "0x16A")]
	[Token(Token = "0x6000554")]
	public string GetFirstChars(CultureInfo culture) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000553")]
	private void set_CaseInsensitive(bool value) { }

}

