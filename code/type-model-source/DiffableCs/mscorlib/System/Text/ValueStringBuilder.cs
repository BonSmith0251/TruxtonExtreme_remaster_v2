namespace System.Text;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20002C0")]
internal struct ValueStringBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BD1")]
	private Char[] _arrayToReturnToPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BD2")]
	private Span<Char> _chars; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BD3")]
	private int _pos; //Field offset: 0x18

	[Token(Token = "0x17000236")]
	public char Item
	{
		[Address(RVA = "0x1EB5500", Offset = "0x1EB4900", Length = "0x1E")]
		[Token(Token = "0x60016E5")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000235")]
	public int Length
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60016E4")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1EB54F0", Offset = "0x1EB48F0", Length = "0x10")]
	[Token(Token = "0x60016E3")]
	public ValueStringBuilder(Span<Char> initialBuffer) { }

	[Address(RVA = "0x1EB4FE0", Offset = "0x1EB43E0", Length = "0x6D")]
	[Token(Token = "0x60016E8")]
	public void Append(char c) { }

	[Address(RVA = "0x1EB4D40", Offset = "0x1EB4140", Length = "0x1B8")]
	[Token(Token = "0x60016E9")]
	public void Append(string s) { }

	[Address(RVA = "0x1EB4F00", Offset = "0x1EB4300", Length = "0xD6")]
	[Token(Token = "0x60016EB")]
	public void Append(char c, int count) { }

	[Address(RVA = "0x1EB4C60", Offset = "0x1EB4060", Length = "0xDD")]
	[Token(Token = "0x60016EC")]
	public void Append(Char* value, int length) { }

	[Address(RVA = "0x1EB4A20", Offset = "0x1EB3E20", Length = "0x154")]
	[Token(Token = "0x60016EA")]
	private void AppendSlow(string s) { }

	[Address(RVA = "0x1EB4B80", Offset = "0x1EB3F80", Length = "0xD9")]
	[Token(Token = "0x60016ED")]
	public Span<Char> AppendSpan(int length) { }

	[Address(RVA = "0x1EB5050", Offset = "0x1EB4450", Length = "0x9A")]
	[Token(Token = "0x60016F0")]
	public void Dispose() { }

	[Address(RVA = "0x1EB5500", Offset = "0x1EB4900", Length = "0x1E")]
	[Token(Token = "0x60016E5")]
	public char get_Item(int index) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60016E4")]
	public int get_Length() { }

	[Address(RVA = "0x1EB5160", Offset = "0x1EB4560", Length = "0x1AC")]
	[Token(Token = "0x60016EF")]
	private void Grow(int requiredAdditionalCapacity) { }

	[Address(RVA = "0x1EB50F0", Offset = "0x1EB44F0", Length = "0x65")]
	[Token(Token = "0x60016EE")]
	private void GrowAndAppend(char c) { }

	[Address(RVA = "0x1EB5310", Offset = "0x1EB4710", Length = "0xDC")]
	[Token(Token = "0x60016E6")]
	public virtual string ToString() { }

	[Address(RVA = "0x1EB53F0", Offset = "0x1EB47F0", Length = "0xF1")]
	[Token(Token = "0x60016E7")]
	public bool TryCopyTo(Span<Char> destination, out int charsWritten) { }

}

