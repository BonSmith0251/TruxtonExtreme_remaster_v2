namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000183")]
[TupleElementNames(new IL2CPP_TYPE_STRING[] {"data", "channels"})]
public sealed class AsyncAudioFilterReadTrigger : AsyncTriggerBase<ValueTuple`2<Single[], Int32>>
{

	[Address(RVA = "0x2771C00", Offset = "0x2771000", Length = "0x39")]
	[Token(Token = "0x60009FB")]
	public AsyncAudioFilterReadTrigger() { }

	[Address(RVA = "0x27718B0", Offset = "0x2770CB0", Length = "0x67")]
	[Token(Token = "0x60009F7")]
	public IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler() { }

	[Address(RVA = "0x2771830", Offset = "0x2770C30", Length = "0x7C")]
	[Token(Token = "0x60009F8")]
	public IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2771B70", Offset = "0x2770F70", Length = "0x8E")]
	[Token(Token = "0x60009F6")]
	private void OnAudioFilterRead(Single[] data, int channels) { }

	[Address(RVA = "0x2771A50", Offset = "0x2770E50", Length = "0x114")]
	[Token(Token = "0x60009F9")]
	public UniTask<ValueTuple`2<Single[], Int32>> OnAudioFilterReadAsync() { }

	[Address(RVA = "0x2771920", Offset = "0x2770D20", Length = "0x12A")]
	[Token(Token = "0x60009FA")]
	public UniTask<ValueTuple`2<Single[], Int32>> OnAudioFilterReadAsync(CancellationToken cancellationToken) { }

}

