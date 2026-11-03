namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView`1))]
[IsReadOnly]
[Token(Token = "0x2000129")]
public struct ReadOnlyMemory : IEquatable<ReadOnlyMemory`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000433")]
	private readonly object _object; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000434")]
	private readonly int _index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000435")]
	private readonly int _length; //Field offset: 0x0

	[Token(Token = "0x17000099")]
	public int Length
	{
		[Address(RVA = "0xD0EE80", Offset = "0xD0E280", Length = "0x8")]
		[Token(Token = "0x6000984")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700009A")]
	public ReadOnlySpan<T> Span
	{
		[Address(RVA = "0xF11BE0", Offset = "0xF10FE0", Length = "0x401")]
		[Token(Token = "0x6000986")]
		 get { } //Length: 1025
	}

	[Address(RVA = "0xD0EE30", Offset = "0xD0E230", Length = "0x46")]
	[Token(Token = "0x6000982")]
	public ReadOnlyMemory`1(T[] array) { }

	[Address(RVA = "0xD0ED70", Offset = "0xD0E170", Length = "0x7D")]
	[Token(Token = "0x6000983")]
	public ReadOnlyMemory`1(T[] array, int start, int length) { }

	[Address(RVA = "0xD0D290", Offset = "0xD0C690", Length = "0x6")]
	[Token(Token = "0x600098A")]
	private static int CombineHashCodes(int left, int right) { }

	[Address(RVA = "0xD0D2A0", Offset = "0xD0C6A0", Length = "0x61")]
	[Token(Token = "0x600098B")]
	private static int CombineHashCodes(int h1, int h2, int h3) { }

	[Address(RVA = "0xF18D10", Offset = "0xF18110", Length = "0x21E")]
	[Token(Token = "0x6000987")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xB4A000", Offset = "0xB49400", Length = "0x1D")]
	[Token(Token = "0x6000988")]
	public override bool Equals(ReadOnlyMemory<T> other) { }

	[Address(RVA = "0xD0EE80", Offset = "0xD0E280", Length = "0x8")]
	[Token(Token = "0x6000984")]
	public int get_Length() { }

	[Address(RVA = "0xF11BE0", Offset = "0xF10FE0", Length = "0x401")]
	[Token(Token = "0x6000986")]
	public ReadOnlySpan<T> get_Span() { }

	[Address(RVA = "0xF18F30", Offset = "0xF18330", Length = "0xD5")]
	[Token(Token = "0x6000989")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xF190F0", Offset = "0xF184F0", Length = "0xF")]
	[Token(Token = "0x600098C")]
	internal object GetObjectStartLength(out int start, out int length) { }

	[Address(RVA = "0xF19100", Offset = "0xF18500", Length = "0x329")]
	[Token(Token = "0x6000985")]
	public virtual string ToString() { }

}

