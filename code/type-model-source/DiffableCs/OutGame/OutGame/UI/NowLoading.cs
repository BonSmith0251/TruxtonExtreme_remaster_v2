namespace OutGame.UI;

[Token(Token = "0x200011D")]
public class NowLoading : MonoBehaviourSingleton<NowLoading>
{
	[CompilerGenerated]
	[Token(Token = "0x2000120")]
	private sealed class <Waiting>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004CA")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004CB")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004CC")]
		public bool isLoading; //Field offset: 0x20

		[Token(Token = "0x1700019F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600072B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001A0")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600072D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000728")]
		public <Waiting>d__1(int <>1__state) { }

		[Address(RVA = "0x21F88B0", Offset = "0x21F7CB0", Length = "0x119")]
		[Token(Token = "0x600072A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600072B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600072D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F8B30", Offset = "0x21F7F30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600072C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000729")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011F")]
	private sealed class <WaitLoadingFontDisplay>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004C5")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004C6")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004C7")]
		public NowLoading <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004C8")]
		public bool isLoading; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004C9")]
		private YieldInstruction <cacheWait>5__2; //Field offset: 0x30

		[Token(Token = "0x1700019D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000725")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700019E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000727")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000722")]
		public <WaitLoadingFontDisplay>d__3(int <>1__state) { }

		[Address(RVA = "0x21F8700", Offset = "0x21F7B00", Length = "0x163")]
		[Token(Token = "0x6000724")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000725")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000727")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F8870", Offset = "0x21F7C70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000726")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000723")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200011E")]
	internal class NowLoadingScope : IDisposable
	{

		[Address(RVA = "0x21EBDB0", Offset = "0x21EB1B0", Length = "0xCF")]
		[Token(Token = "0x6000720")]
		public NowLoadingScope() { }

		[Address(RVA = "0x21EBD30", Offset = "0x21EB130", Length = "0x75")]
		[Token(Token = "0x6000721")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004BE")]
	private UIRotater _rotater; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004BF")]
	private UIImage _icon; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004C0")]
	private Color _iconColor; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004C1")]
	private bool _isLoading; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x40004C2")]
	private bool _isBlink; //Field offset: 0x41
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40004C3")]
	private float _canvasAlpha; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004C4")]
	private float _blinkTimer; //Field offset: 0x48

	[Address(RVA = "0x21EC230", Offset = "0x21EB630", Length = "0x45")]
	[Token(Token = "0x600071F")]
	public NowLoading() { }

	[Address(RVA = "0x21EBE80", Offset = "0x21EB280", Length = "0x1E")]
	[Token(Token = "0x600071D")]
	private void DisplayActive(bool tactive) { }

	[Address(RVA = "0x21EBEA0", Offset = "0x21EB2A0", Length = "0x65")]
	[Token(Token = "0x600071A")]
	public void Loading(bool isLoading) { }

	[Address(RVA = "0x21EBF10", Offset = "0x21EB310", Length = "0x45")]
	[Token(Token = "0x600071E")]
	private void SetIconAlpha(float ta) { }

	[Address(RVA = "0x21EBF60", Offset = "0x21EB360", Length = "0x1E1")]
	[Token(Token = "0x600071C")]
	private void Update() { }

	[Address(RVA = "0x21EC1D0", Offset = "0x21EB5D0", Length = "0x5B")]
	[IteratorStateMachine(typeof(<Waiting>d__1))]
	[Token(Token = "0x6000719")]
	public static IEnumerator Waiting(bool isLoading) { }

	[Address(RVA = "0x21EC150", Offset = "0x21EB550", Length = "0x78")]
	[IteratorStateMachine(typeof(<WaitLoadingFontDisplay>d__3))]
	[Token(Token = "0x600071B")]
	public IEnumerator WaitLoadingFontDisplay(bool isLoading) { }

}

