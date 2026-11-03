namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView`1))]
[DefaultMember("Item")]
[IsByRefLike]
[IsReadOnly]
[NonVersionable]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000130")]
public struct Span
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400043C")]
	internal readonly ByReference<T> _pointer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400043D")]
	private readonly int _length; //Field offset: 0x0

	[Token(Token = "0x1700009F")]
	public T Item
	{
		[Address(RVA = "0xF1EB40", Offset = "0xF1DF40", Length = "0x31")]
		[Intrinsic]
		[NonVersionable]
		[Token(Token = "0x60009EE")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170000A0")]
	public int Length
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[NonVersionable]
		[Token(Token = "0x60009FA")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xF1E310", Offset = "0xF1D710", Length = "0x1A")]
	[Token(Token = "0x60009EA")]
	public Span`1(T[] array) { }

	[Address(RVA = "0xF1E690", Offset = "0xF1DA90", Length = "0x7D")]
	[Token(Token = "0x60009EB")]
	public Span`1(T[] array, int start, int length) { }

	[Address(RVA = "0xF788F0", Offset = "0xF77CF0", Length = "0x8C")]
	[CLSCompliant(False)]
	[Token(Token = "0x60009EC")]
	public Span`1(Void* pointer, int length) { }

	[Address(RVA = "0xAEE300", Offset = "0xAED700", Length = "0x8")]
	[Token(Token = "0x60009ED")]
	internal Span`1(ref T ptr, int length) { }

	[Address(RVA = "0xF76E20", Offset = "0xF76220", Length = "0x40")]
	[Token(Token = "0x60009F0")]
	public void Clear() { }

	[Address(RVA = "0xF77010", Offset = "0xF76410", Length = "0x8A")]
	[Token(Token = "0x60009F2")]
	public void CopyTo(Span<T> destination) { }

	[Address(RVA = "0xF1A140", Offset = "0xF19540", Length = "0x49")]
	[Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
	[Token(Token = "0x60009FB")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF77320", Offset = "0xF76720", Length = "0x1D1")]
	[Token(Token = "0x60009F1")]
	public void Fill(T value) { }

	[Address(RVA = "0xF1EB40", Offset = "0xF1DF40", Length = "0x31")]
	[Intrinsic]
	[NonVersionable]
	[Token(Token = "0x60009EE")]
	public T get_Item(int index) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[NonVersionable]
	[Token(Token = "0x60009FA")]
	public int get_Length() { }

	[Address(RVA = "0xF1A190", Offset = "0xF19590", Length = "0x49")]
	[Obsolete("GetHashCode() on Span will always throw an exception.")]
	[Token(Token = "0x60009FC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xF1A1E0", Offset = "0xF195E0", Length = "0xD")]
	[Token(Token = "0x60009EF")]
	public T GetPinnableReference() { }

	[Address(RVA = "0xF1ECD0", Offset = "0xF1E0D0", Length = "0x15")]
	[Token(Token = "0x60009F4")]
	public static bool op_Equality(Span<T> left, Span<T> right) { }

	[Address(RVA = "0xF1ECF0", Offset = "0xF1E0F0", Length = "0x5C")]
	[Token(Token = "0x60009FD")]
	public static Span<T> op_Implicit(T[] array) { }

	[Address(RVA = "0xF78980", Offset = "0xF77D80", Length = "0x49")]
	[Token(Token = "0x60009F5")]
	public static ReadOnlySpan<T> op_Implicit(Span<T> span) { }

	[Address(RVA = "0xF1A870", Offset = "0xF19C70", Length = "0x78")]
	[Token(Token = "0x60009F8")]
	public Span<T> Slice(int start, int length) { }

	[Address(RVA = "0xF1A7F0", Offset = "0xF19BF0", Length = "0x7D")]
	[Token(Token = "0x60009F7")]
	public Span<T> Slice(int start) { }

	[Address(RVA = "0xF77A80", Offset = "0xF76E80", Length = "0x14A")]
	[Token(Token = "0x60009F9")]
	public T[] ToArray() { }

	[Address(RVA = "0xF78000", Offset = "0xF77400", Length = "0x169")]
	[Token(Token = "0x60009F6")]
	public virtual string ToString() { }

	[Address(RVA = "0xF78450", Offset = "0xF77850", Length = "0x87")]
	[Token(Token = "0x60009F3")]
	public bool TryCopyTo(Span<T> destination) { }

}

