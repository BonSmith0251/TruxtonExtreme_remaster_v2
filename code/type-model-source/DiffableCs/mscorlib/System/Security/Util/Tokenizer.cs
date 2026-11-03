namespace System.Security.Util;

[Token(Token = "0x20002D7")]
internal sealed class Tokenizer
{
	[Token(Token = "0x20002DA")]
	public interface ITokenReader
	{

		[Token(Token = "0x60017E5")]
		public int Read() { }

	}

	[Token(Token = "0x20002DB")]
	public class StreamTokenReader : ITokenReader
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C49")]
		internal StreamReader _in; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C4A")]
		internal int _numCharRead; //Field offset: 0x18

		[Token(Token = "0x1700025A")]
		internal int NumCharEncountered
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x60017E8")]
			internal get { } //Length: 4
		}

		[Address(RVA = "0x1EAD540", Offset = "0x1EAC940", Length = "0x39")]
		[Token(Token = "0x60017E6")]
		internal StreamTokenReader(StreamReader input) { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60017E8")]
		internal int get_NumCharEncountered() { }

		[Address(RVA = "0x1EAD500", Offset = "0x1EAC900", Length = "0x3E")]
		[Token(Token = "0x60017E7")]
		public override int Read() { }

	}

	[Token(Token = "0x20002D9")]
	public sealed class StringMaker
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C43")]
		private String[] aStrings; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C44")]
		private uint cStringsMax; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000C45")]
		private uint cStringsUsed; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C46")]
		public StringBuilder _outStringBuilder; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C47")]
		public Char[] _outChars; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C48")]
		public int _outIndex; //Field offset: 0x30

		[Address(RVA = "0x1EADA50", Offset = "0x1EACE50", Length = "0x8A")]
		[Token(Token = "0x60017E2")]
		public StringMaker() { }

		[Address(RVA = "0x1EAD580", Offset = "0x1EAC980", Length = "0x8F")]
		[Token(Token = "0x60017E3")]
		private bool CompareStringAndChars(string str, Char[] a, int l) { }

		[Address(RVA = "0x1EAD610", Offset = "0x1EACA10", Length = "0x6C")]
		[Token(Token = "0x60017E1")]
		private static uint HashCharArray(Char[] a, int l) { }

		[Address(RVA = "0x1EAD680", Offset = "0x1EACA80", Length = "0x72")]
		[Token(Token = "0x60017E0")]
		private static uint HashString(string str) { }

		[Address(RVA = "0x1EAD700", Offset = "0x1EACB00", Length = "0x344")]
		[Token(Token = "0x60017E4")]
		public string MakeString() { }

	}

	[Token(Token = "0x20002D8")]
	private enum TokenSource : int
	{
		UnicodeByteArray = 0,
		UTF8ByteArray = 1,
		ASCIIByteArray = 2,
		CharArray = 3,
		String = 4,
		NestedStrings = 5,
		Other = 6,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C2B")]
	public int LineNo; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C2C")]
	private int _inProcessingTag; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C2D")]
	private Byte[] _inBytes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C2E")]
	private Char[] _inChars; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C2F")]
	private string _inString; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C30")]
	private int _inIndex; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000C31")]
	private int _inSize; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C32")]
	private int _inSavedCharacter; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000C33")]
	private TokenSource _inTokenSource; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C34")]
	private ITokenReader _inTokenReader; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C35")]
	private StringMaker _maker; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C36")]
	private String[] _searchStrings; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000C37")]
	private String[] _replaceStrings; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C38")]
	private int _inNestedIndex; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000C39")]
	private int _inNestedSize; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C3A")]
	private string _inNestedString; //Field offset: 0x68

	[Address(RVA = "0x1EAEFE0", Offset = "0x1EAE3E0", Length = "0xB0")]
	[Token(Token = "0x60017DC")]
	internal Tokenizer(string input) { }

	[Address(RVA = "0x1EAE230", Offset = "0x1EAD630", Length = "0x75")]
	[Token(Token = "0x60017DA")]
	internal void BasicInitialization() { }

	[Address(RVA = "0x1EAE2B0", Offset = "0x1EAD6B0", Length = "0x290")]
	[Token(Token = "0x60017DD")]
	internal void ChangeFormat(Encoding encoding) { }

	[Address(RVA = "0x1EAE550", Offset = "0x1EAD950", Length = "0x1D")]
	[Token(Token = "0x60017DF")]
	private string GetStringToken() { }

	[Address(RVA = "0x1EAE570", Offset = "0x1EAD970", Length = "0x9E8")]
	[Token(Token = "0x60017DE")]
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	[Address(RVA = "0x1EAEF90", Offset = "0x1EAE390", Length = "0x4A")]
	[Token(Token = "0x60017DB")]
	public void Recycle() { }

}

