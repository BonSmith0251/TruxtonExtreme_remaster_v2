namespace UnityEngine.UIElements;

[Token(Token = "0x20001CC")]
internal class EventCallbackFunctor : EventCallbackFunctorBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000832")]
	private EventCallback<TEventType> m_Callback; //Field offset: 0x0

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000D14")]
	public EventCallbackFunctor`1() { }

	[Address(RVA = "0x1BABBF0", Offset = "0x1BAAFF0", Length = "0x7A")]
	[Token(Token = "0x6000D10")]
	public virtual void Dispose() { }

	[Address(RVA = "0x1BABC70", Offset = "0x1BAB070", Length = "0xC2")]
	[Token(Token = "0x6000D0F")]
	public static EventCallbackFunctor<TEventType> GetPooled(long eventTypeId, EventCallback<TEventType> callback, InvokePolicy invokePolicy = 0) { }

	[Address(RVA = "0x1BABD40", Offset = "0x1BAB140", Length = "0xCA")]
	[Token(Token = "0x6000D11")]
	public virtual void Invoke(EventBase evt) { }

	[Address(RVA = "0x1BABE10", Offset = "0x1BAB210", Length = "0x28")]
	[Token(Token = "0x6000D13")]
	public virtual bool IsEquivalentTo(long eventTypeId, Delegate callback) { }

	[Address(RVA = "0x1BABE40", Offset = "0x1BAB240", Length = "0x30")]
	[Token(Token = "0x6000D12")]
	public virtual void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown) { }

}

