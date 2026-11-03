namespace TMPro;

[Token(Token = "0x200003B")]
internal class TweenRunner
{
	[CompilerGenerated]
	[Token(Token = "0x200003C")]
	private sealed class <Start>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000194")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000195")]
		private object <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000196")]
		public T tweenInfo; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000197")]
		private float <elapsedTime>5__2; //Field offset: 0x0

		[Token(Token = "0x1700004C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001A5")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700004D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001A7")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001A2")]
		public <Start>d__2(int <>1__state) { }

		[Address(RVA = "0x19DECA0", Offset = "0x19DE0A0", Length = "0x125")]
		[Token(Token = "0x60001A4")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001A5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001A7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60001A6")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001A3")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000192")]
	protected MonoBehaviour m_CoroutineContainer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000193")]
	protected IEnumerator m_Tween; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001A1")]
	public TweenRunner`1() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x600019E")]
	public void Init(MonoBehaviour coroutineContainer) { }

	[Address(RVA = "0x10ABDC0", Offset = "0x10AB1C0", Length = "0xB3")]
	[IteratorStateMachine(typeof(<Start>d__2))]
	[Token(Token = "0x600019D")]
	private static IEnumerator Start(T tweenInfo) { }

	[Address(RVA = "0x10ABBB0", Offset = "0x10AAFB0", Length = "0x20F")]
	[Token(Token = "0x600019F")]
	public void StartTween(T info) { }

	[Address(RVA = "0x10AC0C0", Offset = "0x10AB4C0", Length = "0x48")]
	[Token(Token = "0x60001A0")]
	public void StopTween() { }

}

