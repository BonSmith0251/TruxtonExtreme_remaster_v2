namespace Unity.Collections;

[DefaultMember("Item")]
[Token(Token = "0x20000D7")]
internal struct UnmanagedArray : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000413")]
	private IntPtr m_pointer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000414")]
	private int m_length; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000415")]
	private AllocatorHandle m_allocator; //Field offset: 0x0

	[Token(Token = "0x1700011F")]
	public T Item
	{
		[Address(RVA = "0x11A54E0", Offset = "0x11A48E0", Length = "0x5D")]
		[Token(Token = "0x60009EB")]
		 get { } //Length: 93
	}

	[Token(Token = "0x1700011E")]
	public int Length
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60009E7")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x11A53D0", Offset = "0x11A47D0", Length = "0x9F")]
	[Token(Token = "0x60009E8")]
	public UnmanagedArray`1(int length, AllocatorHandle allocator) { }

	[Address(RVA = "0x11A5320", Offset = "0x11A4720", Length = "0x94")]
	[Token(Token = "0x60009E9")]
	public override void Dispose() { }

	[Address(RVA = "0x11A54E0", Offset = "0x11A48E0", Length = "0x5D")]
	[Token(Token = "0x60009EB")]
	public T get_Item(int index) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60009E7")]
	public int get_Length() { }

	[Address(RVA = "0x11A53C0", Offset = "0x11A47C0", Length = "0xA")]
	[Token(Token = "0x60009EA")]
	public T* GetUnsafePointer() { }

}

