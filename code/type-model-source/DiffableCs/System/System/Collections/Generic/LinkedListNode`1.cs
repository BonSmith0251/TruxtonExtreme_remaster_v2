namespace System.Collections.Generic;

[Token(Token = "0x20001F2")]
public sealed class LinkedListNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400074E")]
	internal LinkedList<T> list; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400074F")]
	internal LinkedListNode<T> next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000750")]
	internal LinkedListNode<T> prev; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000751")]
	internal T item; //Field offset: 0x0

	[Token(Token = "0x17000276")]
	public LinkedListNode<T> Next
	{
		[Address(RVA = "0xAFFE90", Offset = "0xAFF290", Length = "0x33")]
		[Token(Token = "0x6000CA4")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000277")]
	public LinkedListNode<T> Previous
	{
		[Address(RVA = "0xB00060", Offset = "0xAFF460", Length = "0x2F")]
		[Token(Token = "0x6000CA5")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000278")]
	public T Value
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[Token(Token = "0x6000CA6")]
		 get { } //Length: 11
		[Address(RVA = "0xB002A0", Offset = "0xAFF6A0", Length = "0x12")]
		[Token(Token = "0x6000CA7")]
		 set { } //Length: 18
	}

	[Address(RVA = "0xAFF9F0", Offset = "0xAFEDF0", Length = "0x33")]
	[Token(Token = "0x6000CA2")]
	public LinkedListNode`1(T value) { }

	[Address(RVA = "0xAFFBD0", Offset = "0xAFEFD0", Length = "0x50")]
	[Token(Token = "0x6000CA3")]
	internal LinkedListNode`1(LinkedList<T> list, T value) { }

	[Address(RVA = "0xAFFE90", Offset = "0xAFF290", Length = "0x33")]
	[Token(Token = "0x6000CA4")]
	public LinkedListNode<T> get_Next() { }

	[Address(RVA = "0xB00060", Offset = "0xAFF460", Length = "0x2F")]
	[Token(Token = "0x6000CA5")]
	public LinkedListNode<T> get_Previous() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[Token(Token = "0x6000CA6")]
	public T get_Value() { }

	[Address(RVA = "0xAFF7C0", Offset = "0xAFEBC0", Length = "0x47")]
	[Token(Token = "0x6000CA8")]
	internal void Invalidate() { }

	[Address(RVA = "0xB002A0", Offset = "0xAFF6A0", Length = "0x12")]
	[Token(Token = "0x6000CA7")]
	public void set_Value(T value) { }

}

