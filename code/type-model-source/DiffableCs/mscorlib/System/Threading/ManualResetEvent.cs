namespace System.Threading;

[Token(Token = "0x20001F7")]
public sealed class ManualResetEvent : EventWaitHandle
{

	[Address(RVA = "0x20A19E0", Offset = "0x20A0DE0", Length = "0x10B")]
	[Token(Token = "0x6001186")]
	public ManualResetEvent(bool initialState) { }

}

