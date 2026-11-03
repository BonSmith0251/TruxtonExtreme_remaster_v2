namespace System.Text;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x200000D")]
internal struct ValueStringBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000020")]
	private Char[] _arrayToReturnToPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000021")]
	private Span<Char> _chars; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000022")]
	private int _pos; //Field offset: 0x18

	[Token(Token = "0x17000005")]
	public int Length
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600008F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1EB54F0", Offset = "0x1EB48F0", Length = "0x10")]
	[Token(Token = "0x600008E")]
	public ValueStringBuilder(Span<Char> initialBuffer) { }

	[Address(RVA = "0x23ED240", Offset = "0x23EC640", Length = "0x6D")]
	[Token(Token = "0x6000093")]
	public void Append(char c) { }

	[Address(RVA = "0x23ED0B0", Offset = "0x23EC4B0", Length = "0xA5")]
	[Token(Token = "0x6000094")]
	public void Append(string s) { }

	[Address(RVA = "0x23ECFD0", Offset = "0x23EC3D0", Length = "0xD6")]
	[Token(Token = "0x6000096")]
	public void Append(char c, int count) { }

	[Address(RVA = "0x23ED160", Offset = "0x23EC560", Length = "0xDD")]
	[Token(Token = "0x6000097")]
	public void Append(Char* value, int length) { }

	[Address(RVA = "0x23ECD90", Offset = "0x23EC190", Length = "0x154")]
	[Token(Token = "0x6000095")]
	private void AppendSlow(string s) { }

	[Address(RVA = "0x23ECEF0", Offset = "0x23EC2F0", Length = "0xD9")]
	[Token(Token = "0x6000098")]
	public Span<Char> AppendSpan(int length) { }

	[Address(RVA = "0x23ED2B0", Offset = "0x23EC6B0", Length = "0x9A")]
	[Token(Token = "0x600009B")]
	public void Dispose() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600008F")]
	public int get_Length() { }

	[Address(RVA = "0x23ED390", Offset = "0x23EC790", Length = "0x1AC")]
	[Token(Token = "0x600009A")]
	private void Grow(int requiredAdditionalCapacity) { }

	[Address(RVA = "0x23ED350", Offset = "0x23EC750", Length = "0x35")]
	[Token(Token = "0x6000099")]
	private void GrowAndAppend(char c) { }

	[Address(RVA = "0x23ED540", Offset = "0x23EC940", Length = "0x1E2")]
	[Token(Token = "0x6000092")]
	public void Insert(int index, char value, int count) { }

	[Address(RVA = "0x23ED730", Offset = "0x23ECB30", Length = "0xDC")]
	[Token(Token = "0x6000090")]
	public virtual string ToString() { }

	[Address(RVA = "0x23ED810", Offset = "0x23ECC10", Length = "0xF1")]
	[Token(Token = "0x6000091")]
	public bool TryCopyTo(Span<Char> destination, out int charsWritten) { }

}

