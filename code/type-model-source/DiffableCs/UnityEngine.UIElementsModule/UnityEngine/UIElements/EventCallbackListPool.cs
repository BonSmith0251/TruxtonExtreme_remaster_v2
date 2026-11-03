namespace UnityEngine.UIElements;

[Token(Token = "0x20001D0")]
internal class EventCallbackListPool
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400083C")]
	private readonly Stack<EventCallbackList> m_Stack; //Field offset: 0x10

	[Address(RVA = "0x33CA750", Offset = "0x33C9B50", Length = "0x77")]
	[Token(Token = "0x6000D1F")]
	public EventCallbackListPool() { }

	[Address(RVA = "0x33CA500", Offset = "0x33C9900", Length = "0x1C4")]
	[Token(Token = "0x6000D1D")]
	public EventCallbackList Get(EventCallbackList initializer) { }

	[Address(RVA = "0x33CA6D0", Offset = "0x33C9AD0", Length = "0x71")]
	[Token(Token = "0x6000D1E")]
	public void Release(EventCallbackList element) { }

}

