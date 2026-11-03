namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200016A")]
public sealed class AsyncAwakeTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2771DA0", Offset = "0x27711A0", Length = "0x39")]
	[Token(Token = "0x600093F")]
	public AsyncAwakeTrigger() { }

	[Address(RVA = "0x2771C40", Offset = "0x2771040", Length = "0x157")]
	[Token(Token = "0x600093E")]
	public UniTask AwakeAsync() { }

}

