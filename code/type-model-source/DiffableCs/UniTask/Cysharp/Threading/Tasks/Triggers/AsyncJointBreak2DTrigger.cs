namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001A7")]
public sealed class AsyncJointBreak2DTrigger : AsyncTriggerBase<Joint2D>
{

	[Address(RVA = "0x2777BA0", Offset = "0x2776FA0", Length = "0x39")]
	[Token(Token = "0x6000A79")]
	public AsyncJointBreak2DTrigger() { }

	[Address(RVA = "0x2777950", Offset = "0x2776D50", Length = "0x67")]
	[Token(Token = "0x6000A75")]
	public IAsyncOnJointBreak2DHandler GetOnJointBreak2DAsyncHandler() { }

	[Address(RVA = "0x27778D0", Offset = "0x2776CD0", Length = "0x7C")]
	[Token(Token = "0x6000A76")]
	public IAsyncOnJointBreak2DHandler GetOnJointBreak2DAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2777B50", Offset = "0x2776F50", Length = "0x48")]
	[Token(Token = "0x6000A74")]
	private void OnJointBreak2D(Joint2D brokenJoint) { }

	[Address(RVA = "0x2777A90", Offset = "0x2776E90", Length = "0xB0")]
	[Token(Token = "0x6000A77")]
	public UniTask<Joint2D> OnJointBreak2DAsync() { }

	[Address(RVA = "0x27779C0", Offset = "0x2776DC0", Length = "0xC5")]
	[Token(Token = "0x6000A78")]
	public UniTask<Joint2D> OnJointBreak2DAsync(CancellationToken cancellationToken) { }

}

