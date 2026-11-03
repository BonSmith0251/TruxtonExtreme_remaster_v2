namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001A3")]
public sealed class AsyncGUITrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2777580", Offset = "0x2776980", Length = "0x39")]
	[Token(Token = "0x6000A6B")]
	public AsyncGUITrigger() { }

	[Address(RVA = "0x27771E0", Offset = "0x27765E0", Length = "0x67")]
	[Token(Token = "0x6000A67")]
	public IAsyncOnGUIHandler GetOnGUIAsyncHandler() { }

	[Address(RVA = "0x2777250", Offset = "0x2776650", Length = "0x7C")]
	[Token(Token = "0x6000A68")]
	public IAsyncOnGUIHandler GetOnGUIAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2777510", Offset = "0x2776910", Length = "0x6E")]
	[Token(Token = "0x6000A66")]
	private void OnGUI() { }

	[Address(RVA = "0x27772D0", Offset = "0x27766D0", Length = "0x10C")]
	[Token(Token = "0x6000A69")]
	public UniTask OnGUIAsync() { }

	[Address(RVA = "0x27773E0", Offset = "0x27767E0", Length = "0x122")]
	[Token(Token = "0x6000A6A")]
	public UniTask OnGUIAsync(CancellationToken cancellationToken) { }

}

