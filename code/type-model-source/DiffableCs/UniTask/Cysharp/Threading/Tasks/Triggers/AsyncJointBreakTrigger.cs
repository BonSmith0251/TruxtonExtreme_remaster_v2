namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001A5")]
public sealed class AsyncJointBreakTrigger : AsyncTriggerBase<Single>
{

	[Address(RVA = "0x2777F60", Offset = "0x2777360", Length = "0x39")]
	[Token(Token = "0x6000A72")]
	public AsyncJointBreakTrigger() { }

	[Address(RVA = "0x2777C60", Offset = "0x2777060", Length = "0x67")]
	[Token(Token = "0x6000A6E")]
	public IAsyncOnJointBreakHandler GetOnJointBreakAsyncHandler() { }

	[Address(RVA = "0x2777BE0", Offset = "0x2776FE0", Length = "0x7C")]
	[Token(Token = "0x6000A6F")]
	public IAsyncOnJointBreakHandler GetOnJointBreakAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2777F10", Offset = "0x2777310", Length = "0x49")]
	[Token(Token = "0x6000A6D")]
	private void OnJointBreak(float breakForce) { }

	[Address(RVA = "0x2777CD0", Offset = "0x27770D0", Length = "0x10C")]
	[Token(Token = "0x6000A70")]
	public UniTask<Single> OnJointBreakAsync() { }

	[Address(RVA = "0x2777DE0", Offset = "0x27771E0", Length = "0x122")]
	[Token(Token = "0x6000A71")]
	public UniTask<Single> OnJointBreakAsync(CancellationToken cancellationToken) { }

}

