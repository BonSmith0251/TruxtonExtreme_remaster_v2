namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200016E")]
public sealed class AsyncStartTrigger : AsyncTriggerBase<AsyncUnit>
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000589")]
	private bool called; //Field offset: 0x48

	[Address(RVA = "0x277F710", Offset = "0x277EB10", Length = "0x39")]
	[Token(Token = "0x600094C")]
	public AsyncStartTrigger() { }

	[Address(RVA = "0x277F690", Offset = "0x277EA90", Length = "0x72")]
	[Token(Token = "0x600094A")]
	private void Start() { }

	[Address(RVA = "0x277F530", Offset = "0x277E930", Length = "0x157")]
	[Token(Token = "0x600094B")]
	public UniTask StartAsync() { }

}

