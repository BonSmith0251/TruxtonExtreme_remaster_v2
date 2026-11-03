namespace System.Text.RegularExpressions;

[Token(Token = "0x20000F2")]
internal sealed class RegexReplacement
{
	[Token(Token = "0x400042B")]
	private const int Specials = 4; //Field offset: 0x0
	[Token(Token = "0x400042C")]
	public const int LeftPortion = -1; //Field offset: 0x0
	[Token(Token = "0x400042D")]
	public const int RightPortion = -2; //Field offset: 0x0
	[Token(Token = "0x400042E")]
	public const int LastGroup = -3; //Field offset: 0x0
	[Token(Token = "0x400042F")]
	public const int WholeString = -4; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000430")]
	private readonly List<String> _strings; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000431")]
	private readonly List<Int32> _rules; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000432")]
	private readonly string <Pattern>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170000E5")]
	public string Pattern
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60005EA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x263A090", Offset = "0x2639490", Length = "0x45E")]
	[Token(Token = "0x60005E8")]
	public RegexReplacement(string rep, RegexNode concat, Hashtable _caps) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60005EA")]
	public string get_Pattern() { }

	[Address(RVA = "0x26393D0", Offset = "0x26387D0", Length = "0x233")]
	[Token(Token = "0x60005E9")]
	public static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) { }

	[Address(RVA = "0x2639610", Offset = "0x2638A10", Length = "0x6DB")]
	[Token(Token = "0x60005ED")]
	public string Replace(Regex regex, string input, int count, int startat) { }

	[Address(RVA = "0x2639ED0", Offset = "0x26392D0", Length = "0x1BC")]
	[Token(Token = "0x60005EB")]
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	[Address(RVA = "0x2639CF0", Offset = "0x26390F0", Length = "0x1DE")]
	[Token(Token = "0x60005EC")]
	private void ReplacementImplRTL(List<String> al, Match match) { }

}

