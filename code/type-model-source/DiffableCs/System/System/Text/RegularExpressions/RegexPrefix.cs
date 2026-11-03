namespace System.Text.RegularExpressions;

[IsReadOnly]
[Token(Token = "0x20000F1")]
internal struct RegexPrefix
{
	[CompilerGenerated]
	[Token(Token = "0x4000429")]
	private static readonly RegexPrefix <Empty>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000428")]
	private readonly bool <CaseInsensitive>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400042A")]
	private readonly string <Prefix>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x170000E2")]
	internal bool CaseInsensitive
	{
		[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005E4")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170000E3")]
	internal static RegexPrefix Empty
	{
		[Address(RVA = "0x2639370", Offset = "0x2638770", Length = "0x5A")]
		[CompilerGenerated]
		[Token(Token = "0x60005E5")]
		internal get { } //Length: 90
	}

	[Token(Token = "0x170000E4")]
	internal string Prefix
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60005E6")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x26392B0", Offset = "0x26386B0", Length = "0x82")]
	[Token(Token = "0x60005E7")]
	private static RegexPrefix() { }

	[Address(RVA = "0x2639340", Offset = "0x2638740", Length = "0x2C")]
	[Token(Token = "0x60005E3")]
	internal RegexPrefix(string prefix, bool ci) { }

	[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005E4")]
	internal bool get_CaseInsensitive() { }

	[Address(RVA = "0x2639370", Offset = "0x2638770", Length = "0x5A")]
	[CompilerGenerated]
	[Token(Token = "0x60005E5")]
	internal static RegexPrefix get_Empty() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60005E6")]
	internal string get_Prefix() { }

}

