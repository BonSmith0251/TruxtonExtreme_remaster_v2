namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x2000602")]
internal struct ArrayBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001883")]
	private T[] _array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001884")]
	private int _count; //Field offset: 0x0

	[Token(Token = "0x17000727")]
	public int Capacity
	{
		[Address(RVA = "0xB450B0", Offset = "0xB444B0", Length = "0xD")]
		[Token(Token = "0x6002CF6")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000728")]
	public int Count
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6002CF7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000729")]
	public T Item
	{
		[Address(RVA = "0xB450C0", Offset = "0xB444C0", Length = "0x2A")]
		[Token(Token = "0x6002CF8")]
		 get { } //Length: 42
	}

	[Address(RVA = "0xB44750", Offset = "0xB43B50", Length = "0xCC")]
	[Token(Token = "0x6002CF9")]
	public void Add(T item) { }

	[Address(RVA = "0xB449A0", Offset = "0xB43DA0", Length = "0x149")]
	[Token(Token = "0x6002CFB")]
	private void EnsureCapacity(int minimum) { }

	[Address(RVA = "0xB450B0", Offset = "0xB444B0", Length = "0xD")]
	[Token(Token = "0x6002CF6")]
	public int get_Capacity() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6002CF7")]
	public int get_Count() { }

	[Address(RVA = "0xB450C0", Offset = "0xB444C0", Length = "0x2A")]
	[Token(Token = "0x6002CF8")]
	public T get_Item(int index) { }

	[Address(RVA = "0xB44D20", Offset = "0xB44120", Length = "0x3E")]
	[Token(Token = "0x6002CFA")]
	public void UncheckedAdd(T item) { }

}

