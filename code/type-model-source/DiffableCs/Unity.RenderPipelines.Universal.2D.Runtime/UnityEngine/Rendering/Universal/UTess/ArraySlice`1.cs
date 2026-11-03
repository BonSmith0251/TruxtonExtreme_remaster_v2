namespace UnityEngine.Rendering.Universal.UTess;

[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(ArraySliceDebugView`1))]
[DefaultMember("Item")]
[Token(Token = "0x2000098")]
internal struct ArraySlice : IEquatable<ArraySlice`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40002CB")]
	internal Byte* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002CC")]
	internal int m_Stride; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002CD")]
	internal int m_Length; //Field offset: 0x0

	[Token(Token = "0x17000095")]
	public T Item
	{
		[Address(RVA = "0xB4A5F0", Offset = "0xB499F0", Length = "0x42")]
		[Token(Token = "0x6000382")]
		 get { } //Length: 66
		[Address(RVA = "0xB4AA50", Offset = "0xB49E50", Length = "0x50")]
		[Token(Token = "0x6000383")]
		[WriteAccessRequired]
		 set { } //Length: 80
	}

	[Token(Token = "0x17000097")]
	public int Length
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x6000388")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000096")]
	public int Stride
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000387")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xB4A540", Offset = "0xB49940", Length = "0xA2")]
	[Token(Token = "0x600037B")]
	public ArraySlice`1(NativeArray<T> array, int start, int length) { }

	[Address(RVA = "0xB49C70", Offset = "0xB49070", Length = "0x126")]
	[Token(Token = "0x6000381")]
	public static ArraySlice<T> ConvertExistingDataToArraySlice(Void* dataPointer, int stride, int length) { }

	[Address(RVA = "0xB49F20", Offset = "0xB49320", Length = "0xDD")]
	[Token(Token = "0x6000385")]
	internal void CopyTo(T[] array) { }

	[Address(RVA = "0xB4A000", Offset = "0xB49400", Length = "0x1D")]
	[Token(Token = "0x600037C")]
	public override bool Equals(ArraySlice<T> other) { }

	[Address(RVA = "0xB4A160", Offset = "0xB49560", Length = "0x104")]
	[Token(Token = "0x600037D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xB4A5F0", Offset = "0xB499F0", Length = "0x42")]
	[Token(Token = "0x6000382")]
	public T get_Item(int index) { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x6000388")]
	public int get_Length() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6000387")]
	public int get_Stride() { }

	[Address(RVA = "0xB4A270", Offset = "0xB49670", Length = "0x13")]
	[Token(Token = "0x600037E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000384")]
	internal Void* GetUnsafeReadOnlyPtr() { }

	[Address(RVA = "0xB4A760", Offset = "0xB49B60", Length = "0x58")]
	[Token(Token = "0x600037F")]
	public static bool op_Equality(ArraySlice<T> left, ArraySlice<T> right) { }

	[Address(RVA = "0xB4A850", Offset = "0xB49C50", Length = "0x58")]
	[Token(Token = "0x6000380")]
	public static bool op_Inequality(ArraySlice<T> left, ArraySlice<T> right) { }

	[Address(RVA = "0xB4AA50", Offset = "0xB49E50", Length = "0x50")]
	[Token(Token = "0x6000383")]
	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	[Address(RVA = "0xB4A3A0", Offset = "0xB497A0", Length = "0xA6")]
	[Token(Token = "0x6000386")]
	internal T[] ToArray() { }

}

