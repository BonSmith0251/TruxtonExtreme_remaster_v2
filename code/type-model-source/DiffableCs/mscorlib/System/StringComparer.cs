namespace System;

[Token(Token = "0x2000134")]
public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<String>, IEqualityComparer<String>
{
	[Token(Token = "0x400043E")]
	private static readonly CultureAwareComparer s_invariantCulture; //Field offset: 0x0
	[Token(Token = "0x400043F")]
	private static readonly CultureAwareComparer s_invariantCultureIgnoreCase; //Field offset: 0x8
	[Token(Token = "0x4000440")]
	private static readonly OrdinalCaseSensitiveComparer s_ordinal; //Field offset: 0x10
	[Token(Token = "0x4000441")]
	private static readonly OrdinalIgnoreCaseComparer s_ordinalIgnoreCase; //Field offset: 0x18

	[Token(Token = "0x170000A1")]
	public static StringComparer InvariantCultureIgnoreCase
	{
		[Address(RVA = "0x204BE10", Offset = "0x204B210", Length = "0x4F")]
		[Token(Token = "0x6000A1B")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000A2")]
	public static StringComparer Ordinal
	{
		[Address(RVA = "0x204BEB0", Offset = "0x204B2B0", Length = "0x4F")]
		[Token(Token = "0x6000A1C")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000A3")]
	public static StringComparer OrdinalIgnoreCase
	{
		[Address(RVA = "0x204BE60", Offset = "0x204B260", Length = "0x4F")]
		[Token(Token = "0x6000A1D")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x204BBF0", Offset = "0x204AFF0", Length = "0x213")]
	[Token(Token = "0x6000A26")]
	private static StringComparer() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000A25")]
	protected StringComparer() { }

	[Address(RVA = "0x204B8B0", Offset = "0x204ACB0", Length = "0x155")]
	[Token(Token = "0x6000A1F")]
	public override int Compare(object x, object y) { }

	[Token(Token = "0x6000A22")]
	public abstract int Compare(string x, string y) { }

	[Address(RVA = "0x204BA10", Offset = "0x204AE10", Length = "0xB1")]
	[Token(Token = "0x6000A1E")]
	public static StringComparer Create(CultureInfo culture, bool ignoreCase) { }

	[Address(RVA = "0x204BAD0", Offset = "0x204AED0", Length = "0x6E")]
	[Token(Token = "0x6000A20")]
	public override bool Equals(object x, object y) { }

	[Token(Token = "0x6000A23")]
	public abstract bool Equals(string x, string y) { }

	[Address(RVA = "0x204BE10", Offset = "0x204B210", Length = "0x4F")]
	[Token(Token = "0x6000A1B")]
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	[Address(RVA = "0x204BEB0", Offset = "0x204B2B0", Length = "0x4F")]
	[Token(Token = "0x6000A1C")]
	public static StringComparer get_Ordinal() { }

	[Address(RVA = "0x204BE60", Offset = "0x204B260", Length = "0x4F")]
	[Token(Token = "0x6000A1D")]
	public static StringComparer get_OrdinalIgnoreCase() { }

	[Address(RVA = "0x204BB40", Offset = "0x204AF40", Length = "0xA6")]
	[Token(Token = "0x6000A21")]
	public override int GetHashCode(object obj) { }

	[Token(Token = "0x6000A24")]
	public abstract int GetHashCode(string obj) { }

}

