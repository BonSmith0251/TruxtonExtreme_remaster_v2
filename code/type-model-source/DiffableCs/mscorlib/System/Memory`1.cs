namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView`1))]
[IsReadOnly]
[Token(Token = "0x200010F")]
public struct Memory : IEquatable<Memory`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400040C")]
	private readonly object _object; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400040D")]
	private readonly int _index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400040E")]
	private readonly int _length; //Field offset: 0x0

	[Token(Token = "0x1700008B")]
	public int Length
	{
		[Address(RVA = "0xD0EE80", Offset = "0xD0E280", Length = "0x8")]
		[Token(Token = "0x600089B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700008C")]
	public Span<T> Span
	{
		[Address(RVA = "0xD06550", Offset = "0xD05950", Length = "0x3C8")]
		[Token(Token = "0x600089E")]
		 get { } //Length: 968
	}

	[Address(RVA = "0xD0EE30", Offset = "0xD0E230", Length = "0x46")]
	[Token(Token = "0x6000895")]
	public Memory`1(T[] array) { }

	[Address(RVA = "0xD0ECF0", Offset = "0xD0E0F0", Length = "0x74")]
	[Token(Token = "0x6000896")]
	internal Memory`1(T[] array, int start) { }

	[Address(RVA = "0xD0ED70", Offset = "0xD0E170", Length = "0x7D")]
	[Token(Token = "0x6000897")]
	public Memory`1(T[] array, int start, int length) { }

	[Address(RVA = "0xD0EDF0", Offset = "0xD0E1F0", Length = "0x36")]
	[Token(Token = "0x6000898")]
	internal Memory`1(object obj, int start, int length) { }

	[Address(RVA = "0xD0D290", Offset = "0xD0C690", Length = "0x6")]
	[Token(Token = "0x60008A4")]
	private static int CombineHashCodes(int left, int right) { }

	[Address(RVA = "0xD0D2A0", Offset = "0xD0C6A0", Length = "0x61")]
	[Token(Token = "0x60008A5")]
	private static int CombineHashCodes(int h1, int h2, int h3) { }

	[Address(RVA = "0xD0D6B0", Offset = "0xD0CAB0", Length = "0x210")]
	[Token(Token = "0x60008A1")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xB4A000", Offset = "0xB49400", Length = "0x1D")]
	[Token(Token = "0x60008A2")]
	public override bool Equals(Memory<T> other) { }

	[Address(RVA = "0xD0EE80", Offset = "0xD0E280", Length = "0x8")]
	[Token(Token = "0x600089B")]
	public int get_Length() { }

	[Address(RVA = "0xD06550", Offset = "0xD05950", Length = "0x3C8")]
	[Token(Token = "0x600089E")]
	public Span<T> get_Span() { }

	[Address(RVA = "0xD0D9B0", Offset = "0xD0CDB0", Length = "0xD5")]
	[Token(Token = "0x60008A3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xD0EE90", Offset = "0xD0E290", Length = "0x6A")]
	[Token(Token = "0x6000899")]
	public static Memory<T> op_Implicit(T[] array) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x600089A")]
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }

	[Address(RVA = "0xD0E160", Offset = "0xD0D560", Length = "0x2D4")]
	[Token(Token = "0x600089F")]
	public MemoryHandle Pin() { }

	[Address(RVA = "0xD0E440", Offset = "0xD0D840", Length = "0xA1")]
	[Token(Token = "0x600089D")]
	public Memory<T> Slice(int start, int length) { }

	[Address(RVA = "0xD0E650", Offset = "0xD0DA50", Length = "0x80")]
	[Token(Token = "0x60008A0")]
	public T[] ToArray() { }

	[Address(RVA = "0xD0EAF0", Offset = "0xD0DEF0", Length = "0x1FE")]
	[Token(Token = "0x600089C")]
	public virtual string ToString() { }

}

