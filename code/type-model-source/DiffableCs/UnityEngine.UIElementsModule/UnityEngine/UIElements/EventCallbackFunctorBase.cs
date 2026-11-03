namespace UnityEngine.UIElements;

[Token(Token = "0x20001CB")]
internal abstract class EventCallbackFunctorBase : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000830")]
	public long eventTypeId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000831")]
	public InvokePolicy invokePolicy; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000D0E")]
	protected EventCallbackFunctorBase() { }

	[Token(Token = "0x6000D0C")]
	public abstract void Dispose() { }

	[Token(Token = "0x6000D0A")]
	public abstract void Invoke(EventBase evt) { }

	[Token(Token = "0x6000D0D")]
	public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback) { }

	[Token(Token = "0x6000D0B")]
	public abstract void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown) { }

}

