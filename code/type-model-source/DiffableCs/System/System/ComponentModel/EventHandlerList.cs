namespace System.ComponentModel;

[DefaultMember("Item")]
[Token(Token = "0x2000150")]
public sealed class EventHandlerList
{
	[Token(Token = "0x2000151")]
	private sealed class ListEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005F2")]
		internal ListEntry _next; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005F3")]
		internal object _key; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40005F4")]
		internal Delegate _handler; //Field offset: 0x20

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F0")]
	private ListEntry _head; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005F1")]
	private Component _parent; //Field offset: 0x18

	[Token(Token = "0x17000188")]
	public Delegate Item
	{
		[Address(RVA = "0x2648860", Offset = "0x2647C60", Length = "0x5B")]
		[Token(Token = "0x600084B")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x2648840", Offset = "0x2647C40", Length = "0x20")]
	[Token(Token = "0x600084C")]
	private ListEntry Find(object key) { }

	[Address(RVA = "0x2648860", Offset = "0x2647C60", Length = "0x5B")]
	[Token(Token = "0x600084B")]
	public Delegate get_Item(object key) { }

}

