namespace OutGame.UI;

[Token(Token = "0x200010B")]
public class DoublePlay : MonoBehaviourSingleton<DoublePlay>
{
	[CompilerGenerated]
	[Token(Token = "0x200010D")]
	private sealed class <WaitDoublePlayFontDisplay>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000483")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000484")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000485")]
		public DoublePlay <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000486")]
		public bool isWaittime; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000487")]
		private YieldInstruction <cacheWait>5__2; //Field offset: 0x30

		[Token(Token = "0x17000192")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006CB")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000193")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006CD")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60006C8")]
		public <WaitDoublePlayFontDisplay>d__4(int <>1__state) { }

		[Address(RVA = "0x21F8520", Offset = "0x21F7920", Length = "0x193")]
		[Token(Token = "0x60006CA")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006CB")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006CD")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F86C0", Offset = "0x21F7AC0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60006CC")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60006C9")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200010E")]
	private sealed class <Waiting>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000488")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000489")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400048A")]
		public bool isWaittime; //Field offset: 0x20

		[Token(Token = "0x17000194")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006D1")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000195")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006D3")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60006CE")]
		public <Waiting>d__1(int <>1__state) { }

		[Address(RVA = "0x21F89D0", Offset = "0x21F7DD0", Length = "0x119")]
		[Token(Token = "0x60006D0")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006D1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006D3")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F8AF0", Offset = "0x21F7EF0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60006D2")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60006CF")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200010C")]
	internal class DoublePlayScope : IDisposable
	{

		[Address(RVA = "0x21E8510", Offset = "0x21E7910", Length = "0xB5")]
		[Token(Token = "0x60006C6")]
		public DoublePlayScope() { }

		[Address(RVA = "0x21E8490", Offset = "0x21E7890", Length = "0x75")]
		[Token(Token = "0x60006C7")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400047D")]
	private UITextMeshPro _ttext; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400047E")]
	private bool _isDoublePlay; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400047F")]
	private bool _isBlink; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000480")]
	private float _canvasAlpha; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000481")]
	private float _blinkTimer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000482")]
	private CanvasGroup _canvas; //Field offset: 0x38

	[Address(RVA = "0x21E88F0", Offset = "0x21E7CF0", Length = "0x39")]
	[Token(Token = "0x60006C5")]
	public DoublePlay() { }

	[Address(RVA = "0x21E85D0", Offset = "0x21E79D0", Length = "0xA1")]
	[Token(Token = "0x60006C0")]
	protected virtual void Awake() { }

	[Address(RVA = "0x21E8680", Offset = "0x21E7A80", Length = "0x44")]
	[Token(Token = "0x60006C4")]
	private void DisplayActive(bool tactive) { }

	[Address(RVA = "0x21E8930", Offset = "0x21E7D30", Length = "0x4B")]
	[Token(Token = "0x60006C1")]
	public void doublePlay(bool isDoublePlay) { }

	[Address(RVA = "0x21E86D0", Offset = "0x21E7AD0", Length = "0x137")]
	[Token(Token = "0x60006C3")]
	private void Update() { }

	[Address(RVA = "0x21E8810", Offset = "0x21E7C10", Length = "0x78")]
	[IteratorStateMachine(typeof(<WaitDoublePlayFontDisplay>d__4))]
	[Token(Token = "0x60006C2")]
	public IEnumerator WaitDoublePlayFontDisplay(bool isWaittime) { }

	[Address(RVA = "0x21E8890", Offset = "0x21E7C90", Length = "0x5B")]
	[IteratorStateMachine(typeof(<Waiting>d__1))]
	[Token(Token = "0x60006BF")]
	public static IEnumerator Waiting(bool isWaittime) { }

}

