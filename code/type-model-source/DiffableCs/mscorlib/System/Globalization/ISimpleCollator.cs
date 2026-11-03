namespace System.Globalization;

[Token(Token = "0x2000571")]
internal interface ISimpleCollator
{

	[Token(Token = "0x6002835")]
	public int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	[Token(Token = "0x6002834")]
	public SortKey GetSortKey(string source, CompareOptions options) { }

	[Token(Token = "0x6002838")]
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	[Token(Token = "0x6002836")]
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	[Token(Token = "0x6002837")]
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	[Token(Token = "0x6002839")]
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

}

