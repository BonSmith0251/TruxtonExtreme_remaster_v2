namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200017F")]
public sealed class AsyncApplicationPauseTrigger : AsyncTriggerBase<Boolean>
{

	[Address(RVA = "0x2771410", Offset = "0x2770810", Length = "0x39")]
	[Token(Token = "0x60009ED")]
	public AsyncApplicationPauseTrigger() { }

	[Address(RVA = "0x2771110", Offset = "0x2770510", Length = "0x67")]
	[Token(Token = "0x60009E9")]
	public IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler() { }

	[Address(RVA = "0x2771090", Offset = "0x2770490", Length = "0x7C")]
	[Token(Token = "0x60009EA")]
	public IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27713C0", Offset = "0x27707C0", Length = "0x48")]
	[Token(Token = "0x60009E8")]
	private void OnApplicationPause(bool pauseStatus) { }

	[Address(RVA = "0x27712B0", Offset = "0x27706B0", Length = "0x10C")]
	[Token(Token = "0x60009EB")]
	public UniTask<Boolean> OnApplicationPauseAsync() { }

	[Address(RVA = "0x2771180", Offset = "0x2770580", Length = "0x122")]
	[Token(Token = "0x60009EC")]
	public UniTask<Boolean> OnApplicationPauseAsync(CancellationToken cancellationToken) { }

}

