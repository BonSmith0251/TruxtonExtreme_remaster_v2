namespace UnityEngine.UI.CoroutineTween;

[Token(Token = "0x2000090")]
internal class TweenRunner
{
	[CompilerGenerated]
	[Token(Token = "0x2000091")]
	private sealed class <Start>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000289")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028A")]
		private object <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028B")]
		public T tweenInfo; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028C")]
		private float <elapsedTime>5__2; //Field offset: 0x0

		[Token(Token = "0x17000168")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600058E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000169")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000590")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600058B")]
		public <Start>d__2(int <>1__state) { }

		[Address(RVA = "0x19DEDD0", Offset = "0x19DE1D0", Length = "0x125")]
		[Token(Token = "0x600058D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600058E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000590")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x600058F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600058C")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000287")]
	protected MonoBehaviour m_CoroutineContainer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000288")]
	protected IEnumerator m_Tween; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600058A")]
	public TweenRunner`1() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000587")]
	public void Init(MonoBehaviour coroutineContainer) { }

	[Address(RVA = "0x10ABFF0", Offset = "0x10AB3F0", Length = "0xC3")]
	[IteratorStateMachine(typeof(<Start>d__2))]
	[Token(Token = "0x6000586")]
	private static IEnumerator Start(T tweenInfo) { }

	[Address(RVA = "0x10AB2C0", Offset = "0x10AA6C0", Length = "0x23E")]
	[Token(Token = "0x6000588")]
	public void StartTween(T info) { }

	[Address(RVA = "0x10AC0C0", Offset = "0x10AB4C0", Length = "0x48")]
	[Token(Token = "0x6000589")]
	public void StopTween() { }

}

