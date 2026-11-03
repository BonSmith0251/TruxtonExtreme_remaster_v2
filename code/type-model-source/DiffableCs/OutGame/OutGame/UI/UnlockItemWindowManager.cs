namespace OutGame.UI;

[Token(Token = "0x2000165")]
public class UnlockItemWindowManager : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000166")]
	private sealed class <CoroutineWaitForComplete>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000653")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000654")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000655")]
		public UnlockItemWindowManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000656")]
		private bool <isCompleteAll>5__2; //Field offset: 0x28

		[Token(Token = "0x170001F6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000902")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001F7")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000904")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60008FF")]
		public <CoroutineWaitForComplete>d__7(int <>1__state) { }

		[Address(RVA = "0x2207E10", Offset = "0x2207210", Length = "0x1AE")]
		[Token(Token = "0x6000901")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000902")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000904")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2207FC0", Offset = "0x22073C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000903")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000900")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x400064B")]
	private const float _baseX = 1560; //Field offset: 0x0
	[Token(Token = "0x400064C")]
	private const float _baseY = -608; //Field offset: 0x0
	[Token(Token = "0x400064D")]
	private const float _width = 800; //Field offset: 0x0
	[Token(Token = "0x400064E")]
	private const float _height = 360; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400064F")]
	private GameObject _windowGameObject; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000650")]
	private List<UnlockItemWindow> _unlockItemWindowList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000651")]
	private Transform _parentTransform; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000652")]
	private bool _ssrFlg; //Field offset: 0x28

	[Address(RVA = "0x2210680", Offset = "0x220FA80", Length = "0x28F")]
	[Token(Token = "0x60008FA")]
	private void _resetMovePosition() { }

	[Address(RVA = "0x2210600", Offset = "0x220FA00", Length = "0x77")]
	[Token(Token = "0x60008FE")]
	public UnlockItemWindowManager() { }

	[Address(RVA = "0x22101A0", Offset = "0x220F5A0", Length = "0x67")]
	[IteratorStateMachine(typeof(<CoroutineWaitForComplete>d__7))]
	[Token(Token = "0x60008FB")]
	public IEnumerator CoroutineWaitForComplete() { }

	[Address(RVA = "0x2210210", Offset = "0x220F610", Length = "0x7")]
	[Token(Token = "0x60008FD")]
	public override void Dispose() { }

	[Address(RVA = "0x2210220", Offset = "0x220F620", Length = "0xB1")]
	[Token(Token = "0x60008F8")]
	public void Initialize(GameObject windowObject, RectTransform parentTransform) { }

	[Address(RVA = "0x22102E0", Offset = "0x220F6E0", Length = "0x18F")]
	[Token(Token = "0x60008F9")]
	public void Open(string text, bool ssrFlg) { }

	[Address(RVA = "0x2210470", Offset = "0x220F870", Length = "0x184")]
	[Token(Token = "0x60008FC")]
	public void Remove() { }

}

