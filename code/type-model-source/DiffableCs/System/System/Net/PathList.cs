namespace System.Net;

[DefaultMember("Item")]
[Token(Token = "0x200027E")]
internal class PathList
{
	[Token(Token = "0x200027F")]
	private class PathListComparer : IComparer
	{
		[Token(Token = "0x4000A3F")]
		internal static readonly PathListComparer StaticInstance; //Field offset: 0x0

		[Address(RVA = "0x26CCCD0", Offset = "0x26CC0D0", Length = "0x67")]
		[Token(Token = "0x60010C8")]
		private static PathListComparer() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60010C7")]
		public PathListComparer() { }

		[Address(RVA = "0x26CCAA0", Offset = "0x26CBEA0", Length = "0x220")]
		[Token(Token = "0x60010C6")]
		private override int System.Collections.IComparer.Compare(object ol, object or) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A3E")]
	private SortedList m_list; //Field offset: 0x10

	[Token(Token = "0x17000387")]
	public int Count
	{
		[Address(RVA = "0x1FC08C0", Offset = "0x1FBFCC0", Length = "0x2A")]
		[Token(Token = "0x60010BF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000389")]
	public object Item
	{
		[Address(RVA = "0x268E400", Offset = "0x268D800", Length = "0x2A")]
		[Token(Token = "0x60010C2")]
		 get { } //Length: 42
		[Address(RVA = "0x26CD120", Offset = "0x26CC520", Length = "0xF5")]
		[Token(Token = "0x60010C3")]
		 set { } //Length: 245
	}

	[Token(Token = "0x1700038A")]
	public object SyncRoot
	{
		[Address(RVA = "0x1FC8EC0", Offset = "0x1FC82C0", Length = "0x2A")]
		[Token(Token = "0x60010C5")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000388")]
	public ICollection Values
	{
		[Address(RVA = "0x1FC0410", Offset = "0x1FBF810", Length = "0x2A")]
		[Token(Token = "0x60010C1")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x26CD060", Offset = "0x26CC460", Length = "0xB3")]
	[Token(Token = "0x60010BE")]
	public PathList() { }

	[Address(RVA = "0x1FC08C0", Offset = "0x1FBFCC0", Length = "0x2A")]
	[Token(Token = "0x60010BF")]
	public int get_Count() { }

	[Address(RVA = "0x268E400", Offset = "0x268D800", Length = "0x2A")]
	[Token(Token = "0x60010C2")]
	public object get_Item(string s) { }

	[Address(RVA = "0x1FC8EC0", Offset = "0x1FC82C0", Length = "0x2A")]
	[Token(Token = "0x60010C5")]
	public object get_SyncRoot() { }

	[Address(RVA = "0x1FC0410", Offset = "0x1FBF810", Length = "0x2A")]
	[Token(Token = "0x60010C1")]
	public ICollection get_Values() { }

	[Address(RVA = "0x26CCD40", Offset = "0x26CC140", Length = "0x31A")]
	[Token(Token = "0x60010C0")]
	public int GetCookiesCount() { }

	[Address(RVA = "0x1E3EF90", Offset = "0x1E3E390", Length = "0x2A")]
	[Token(Token = "0x60010C4")]
	public IEnumerator GetEnumerator() { }

	[Address(RVA = "0x26CD120", Offset = "0x26CC520", Length = "0xF5")]
	[Token(Token = "0x60010C3")]
	public void set_Item(string s, object value) { }

}

