namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x2000248")]
public sealed class RegisteredWaitHandle : MarshalByRefObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A60")]
	private WaitHandle _waitObject; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A61")]
	private WaitOrTimerCallback _callback; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A62")]
	private object _state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A63")]
	private WaitHandle _finalEvent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A64")]
	private ManualResetEvent _cancelEvent; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A65")]
	private TimeSpan _timeout; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A66")]
	private int _callsInProcess; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000A67")]
	private bool _executeOnlyOnce; //Field offset: 0x4C
	[FieldOffset(Offset = "0x4D")]
	[Token(Token = "0x4000A68")]
	private bool _unregistered; //Field offset: 0x4D

	[Address(RVA = "0x20B3DC0", Offset = "0x20B31C0", Length = "0xE0")]
	[Token(Token = "0x6001372")]
	internal RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	[Address(RVA = "0x20B3680", Offset = "0x20B2A80", Length = "0xC0")]
	[Token(Token = "0x6001374")]
	private void DoCallBack(object timedOut) { }

	[Address(RVA = "0x20B3750", Offset = "0x20B2B50", Length = "0xE3")]
	[ComVisible(True)]
	[Token(Token = "0x6001375")]
	public bool Unregister(WaitHandle waitObject) { }

	[Address(RVA = "0x20B3840", Offset = "0x20B2C40", Length = "0x57D")]
	[Token(Token = "0x6001373")]
	internal void Wait(object state) { }

}

