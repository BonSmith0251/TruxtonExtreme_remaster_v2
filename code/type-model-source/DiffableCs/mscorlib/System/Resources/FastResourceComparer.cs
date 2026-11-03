namespace System.Resources;

[Token(Token = "0x20004BD")]
internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<String>, IEqualityComparer<String>
{
	[Token(Token = "0x40012BC")]
	internal static readonly FastResourceComparer Default; //Field offset: 0x0

	[Address(RVA = "0x1F34E60", Offset = "0x1F34260", Length = "0x67")]
	[Token(Token = "0x60021BC")]
	private static FastResourceComparer() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60021BB")]
	public FastResourceComparer() { }

	[Address(RVA = "0x1F34BC0", Offset = "0x1F33FC0", Length = "0x61")]
	[Token(Token = "0x60021B4")]
	public override int Compare(object a, object b) { }

	[Address(RVA = "0x1F34BA0", Offset = "0x1F33FA0", Length = "0x11")]
	[Token(Token = "0x60021B5")]
	public override int Compare(string a, string b) { }

	[Address(RVA = "0x1F34AD0", Offset = "0x1F33ED0", Length = "0xC4")]
	[Token(Token = "0x60021B8")]
	public static int CompareOrdinal(string a, Byte[] bytes, int bCharLength) { }

	[Address(RVA = "0x1F34930", Offset = "0x1F33D30", Length = "0xED")]
	[Token(Token = "0x60021B9")]
	public static int CompareOrdinal(Byte[] bytes, int aCharLength, string b) { }

	[Address(RVA = "0x1F34A20", Offset = "0x1F33E20", Length = "0xAD")]
	[Token(Token = "0x60021BA")]
	internal static int CompareOrdinal(Byte* a, int byteLen, string b) { }

	[Address(RVA = "0x1F34CA0", Offset = "0x1F340A0", Length = "0x11")]
	[Token(Token = "0x60021B6")]
	public override bool Equals(string a, string b) { }

	[Address(RVA = "0x1F34C30", Offset = "0x1F34030", Length = "0x61")]
	[Token(Token = "0x60021B7")]
	public override bool Equals(object a, object b) { }

	[Address(RVA = "0x1F34CC0", Offset = "0x1F340C0", Length = "0xA5")]
	[Token(Token = "0x60021B1")]
	public override int GetHashCode(object key) { }

	[Address(RVA = "0x1F34D70", Offset = "0x1F34170", Length = "0x88")]
	[Token(Token = "0x60021B2")]
	public override int GetHashCode(string key) { }

	[Address(RVA = "0x1F34E00", Offset = "0x1F34200", Length = "0x57")]
	[Token(Token = "0x60021B3")]
	internal static int HashFunction(string key) { }

}

