namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20000ED")]
internal struct StringBuffer
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004C5")]
	private Char[] _buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004C6")]
	private int _position; //Field offset: 0x8

	[Token(Token = "0x170000DF")]
	public Char[] InternalBuffer
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60006F7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000DE")]
	public bool IsEmpty
	{
		[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
		[Token(Token = "0x60006EE")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000DD")]
	public int Position
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60006EC")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x60006ED")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x21528C0", Offset = "0x2151CC0", Length = "0x37")]
	[Token(Token = "0x60006EF")]
	public StringBuffer(IArrayPool<Char> bufferPool, int initalSize) { }

	[Address(RVA = "0x2152900", Offset = "0x2151D00", Length = "0x1E")]
	[NullableContext(1)]
	[Token(Token = "0x60006F0")]
	private StringBuffer(Char[] buffer) { }

	[Address(RVA = "0x2152610", Offset = "0x2151A10", Length = "0xBA")]
	[Token(Token = "0x60006F1")]
	public void Append(IArrayPool<Char> bufferPool, char value) { }

	[Address(RVA = "0x21526D0", Offset = "0x2151AD0", Length = "0xC7")]
	[NullableContext(1)]
	[Token(Token = "0x60006F2")]
	public void Append(IArrayPool<Char> bufferPool, Char[] buffer, int startIndex, int count) { }

	[Address(RVA = "0x21527A0", Offset = "0x2151BA0", Length = "0x4B")]
	[Token(Token = "0x60006F3")]
	public void Clear(IArrayPool<Char> bufferPool) { }

	[Address(RVA = "0x21527F0", Offset = "0x2151BF0", Length = "0x6E")]
	[Token(Token = "0x60006F4")]
	private void EnsureSize(IArrayPool<Char> bufferPool, int appendLength) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60006F7")]
	public Char[] get_InternalBuffer() { }

	[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
	[Token(Token = "0x60006EE")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60006EC")]
	public int get_Position() { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x60006ED")]
	public void set_Position(int value) { }

	[Address(RVA = "0x2152860", Offset = "0x2151C60", Length = "0x23")]
	[NullableContext(1)]
	[Token(Token = "0x60006F5")]
	public virtual string ToString() { }

	[Address(RVA = "0x2152890", Offset = "0x2151C90", Length = "0x22")]
	[NullableContext(1)]
	[Token(Token = "0x60006F6")]
	public string ToString(int start, int length) { }

}

