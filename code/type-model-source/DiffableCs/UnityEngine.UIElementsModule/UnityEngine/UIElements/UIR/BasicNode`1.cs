namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A9")]
internal class BasicNode : LinkedPoolItem<BasicNode`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013C4")]
	public BasicNode<T> next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013C5")]
	public T data; //Field offset: 0x0

	[Address(RVA = "0xDAAD40", Offset = "0xDAA140", Length = "0x14")]
	[Token(Token = "0x60028D4")]
	public BasicNode`1() { }

	[Address(RVA = "0x16B5E80", Offset = "0x16B5280", Length = "0x6B")]
	[Token(Token = "0x60028D3")]
	public void InsertFirst(ref BasicNode<T>& first) { }

}

