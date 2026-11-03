namespace UnityEngine.UIElements;

[Token(Token = "0x20001CD")]
internal class EventCallbackFunctor : EventCallbackFunctorBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000833")]
	private EventCallback<TEventType, TCallbackArgs> m_Callback; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000834")]
	private TCallbackArgs <userArgs>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700025B")]
	internal TCallbackArgs userArgs
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000D15")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000D16")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000D1C")]
	public EventCallbackFunctor`2() { }

	[Address(RVA = "0x1BABE80", Offset = "0x1BAB280", Length = "0x92")]
	[Token(Token = "0x6000D18")]
	public virtual void Dispose() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000D15")]
	internal TCallbackArgs get_userArgs() { }

	[Address(RVA = "0x1BAC310", Offset = "0x1BAB710", Length = "0xF3")]
	[Token(Token = "0x6000D17")]
	public static EventCallbackFunctor<TEventType, TCallbackArgs> GetPooled(long eventTypeId, EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, InvokePolicy invokePolicy = 0) { }

	[Address(RVA = "0x1BAC410", Offset = "0x1BAB810", Length = "0xDD")]
	[Token(Token = "0x6000D19")]
	public virtual void Invoke(EventBase evt) { }

	[Address(RVA = "0x1BABE10", Offset = "0x1BAB210", Length = "0x28")]
	[Token(Token = "0x6000D1B")]
	public virtual bool IsEquivalentTo(long eventTypeId, Delegate callback) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000D16")]
	internal void set_userArgs(TCallbackArgs value) { }

	[Address(RVA = "0x1BAC6F0", Offset = "0x1BABAF0", Length = "0x30")]
	[Token(Token = "0x6000D1A")]
	public virtual void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown) { }

}

