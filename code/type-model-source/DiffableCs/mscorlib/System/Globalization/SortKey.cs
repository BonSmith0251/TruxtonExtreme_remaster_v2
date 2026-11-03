namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x2000570")]
public class SortKey
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40016BD")]
	private readonly string source; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40016BE")]
	private readonly Byte[] key; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016BF")]
	private readonly CompareOptions options; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40016C0")]
	private readonly int lcid; //Field offset: 0x24

	[Token(Token = "0x170005CB")]
	public override Byte[] KeyData
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600282F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005CA")]
	public override string OriginalString
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600282E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1FBAF30", Offset = "0x1FBA330", Length = "0xDA")]
	[Token(Token = "0x600282B")]
	internal SortKey(int lcid, string source, CompareOptions opt) { }

	[Address(RVA = "0x1FBAE70", Offset = "0x1FBA270", Length = "0x65")]
	[Token(Token = "0x600282C")]
	internal SortKey(int lcid, string source, Byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	[Address(RVA = "0x1FBAEE0", Offset = "0x1FBA2E0", Length = "0x45")]
	[Token(Token = "0x600282D")]
	internal SortKey(string localeName, string str, CompareOptions options, Byte[] keyData) { }

	[Address(RVA = "0x1FBB010", Offset = "0x1FBA410", Length = "0x2C")]
	[Token(Token = "0x6002833")]
	internal SortKey() { }

	[Address(RVA = "0x1FBA9E0", Offset = "0x1FB9DE0", Length = "0x216")]
	[Token(Token = "0x600282A")]
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	[Address(RVA = "0x1FBAC00", Offset = "0x1FBA000", Length = "0x97")]
	[Token(Token = "0x6002830")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600282F")]
	public override Byte[] get_KeyData() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600282E")]
	public override string get_OriginalString() { }

	[Address(RVA = "0x1FBACA0", Offset = "0x1FBA0A0", Length = "0x6A")]
	[Token(Token = "0x6002831")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1FBAD10", Offset = "0x1FBA110", Length = "0x15A")]
	[Token(Token = "0x6002832")]
	public virtual string ToString() { }

}

