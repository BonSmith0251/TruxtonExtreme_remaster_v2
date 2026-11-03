namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView`1))]
[DefaultMember("Item")]
[IsByRefLike]
[IsReadOnly]
[NonVersionable]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x200012A")]
public struct ReadOnlySpan
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000436")]
	internal readonly ByReference<T> _pointer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000437")]
	private readonly int _length; //Field offset: 0x0

	[Token(Token = "0x1700009E")]
	public static ReadOnlySpan<T> Empty
	{
		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x600099F")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700009D")]
	public bool IsEmpty
	{
		[Address(RVA = "0xF1EA30", Offset = "0xF1DE30", Length = "0x8")]
		[NonVersionable]
		[Token(Token = "0x600099B")]
		 get { } //Length: 8
	}

	[IsReadOnly]
	[Token(Token = "0x1700009B")]
	public T Item
	{
		[Address(RVA = "0xF1EB40", Offset = "0xF1DF40", Length = "0x31")]
		[Intrinsic]
		[NonVersionable]
		[Token(Token = "0x6000991")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700009C")]
	public int Length
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[NonVersionable]
		[Token(Token = "0x600099A")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xF1E310", Offset = "0xF1D710", Length = "0x1A")]
	[Token(Token = "0x600098D")]
	public ReadOnlySpan`1(T[] array) { }

	[Address(RVA = "0xF1E690", Offset = "0xF1DA90", Length = "0x7D")]
	[Token(Token = "0x600098E")]
	public ReadOnlySpan`1(T[] array, int start, int length) { }

	[Address(RVA = "0xF1E820", Offset = "0xF1DC20", Length = "0x8C")]
	[CLSCompliant(False)]
	[Token(Token = "0x600098F")]
	public ReadOnlySpan`1(Void* pointer, int length) { }

	[Address(RVA = "0xAEE300", Offset = "0xAED700", Length = "0x8")]
	[Token(Token = "0x6000990")]
	internal ReadOnlySpan`1(ref T ptr, int length) { }

	[Address(RVA = "0xF1A0B0", Offset = "0xF194B0", Length = "0x8A")]
	[Token(Token = "0x6000993")]
	public void CopyTo(Span<T> destination) { }

	[Address(RVA = "0xF1A140", Offset = "0xF19540", Length = "0x49")]
	[Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
	[Token(Token = "0x600099C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
	[Token(Token = "0x600099F")]
	public static ReadOnlySpan<T> get_Empty() { }

	[Address(RVA = "0xF1EA30", Offset = "0xF1DE30", Length = "0x8")]
	[NonVersionable]
	[Token(Token = "0x600099B")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xF1EB40", Offset = "0xF1DF40", Length = "0x31")]
	[Intrinsic]
	[NonVersionable]
	[Token(Token = "0x6000991")]
	public T get_Item(int index) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[NonVersionable]
	[Token(Token = "0x600099A")]
	public int get_Length() { }

	[Address(RVA = "0xF1A190", Offset = "0xF19590", Length = "0x49")]
	[Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
	[Token(Token = "0x600099D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xF1A1E0", Offset = "0xF195E0", Length = "0xD")]
	[Token(Token = "0x6000992")]
	public T GetPinnableReference() { }

	[Address(RVA = "0xF1ECD0", Offset = "0xF1E0D0", Length = "0x15")]
	[Token(Token = "0x6000995")]
	public static bool op_Equality(ReadOnlySpan<T> left, ReadOnlySpan<T> right) { }

	[Address(RVA = "0xF1ECF0", Offset = "0xF1E0F0", Length = "0x5C")]
	[Token(Token = "0x600099E")]
	public static ReadOnlySpan<T> op_Implicit(T[] array) { }

	[Address(RVA = "0xF1A7F0", Offset = "0xF19BF0", Length = "0x7D")]
	[Token(Token = "0x6000997")]
	public ReadOnlySpan<T> Slice(int start) { }

	[Address(RVA = "0xF1A870", Offset = "0xF19C70", Length = "0x78")]
	[Token(Token = "0x6000998")]
	public ReadOnlySpan<T> Slice(int start, int length) { }

	[Address(RVA = "0xF1B5D0", Offset = "0xF1A9D0", Length = "0x14A")]
	[Token(Token = "0x6000999")]
	public T[] ToArray() { }

	[Address(RVA = "0xF1D600", Offset = "0xF1CA00", Length = "0x169")]
	[Token(Token = "0x6000996")]
	public virtual string ToString() { }

	[Address(RVA = "0xF1E160", Offset = "0xF1D560", Length = "0x87")]
	[Token(Token = "0x6000994")]
	public bool TryCopyTo(Span<T> destination) { }

}

