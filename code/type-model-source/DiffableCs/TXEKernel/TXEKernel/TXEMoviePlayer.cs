namespace TXEKernel;

[RequireComponent(typeof(VideoPlayer))]
[Token(Token = "0x20000E4")]
public class TXEMoviePlayer : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20000E6")]
	private sealed class <>c__DisplayClass16_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004AB")]
		public TXEMoviePlayer <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004AC")]
		public Action onPlayEnd; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006D2")]
		public <>c__DisplayClass16_0() { }

		[Address(RVA = "0x271F890", Offset = "0x271EC90", Length = "0x4D")]
		[Token(Token = "0x60006D3")]
		internal void <SetMovie>b__0(VideoPlayer source) { }

		[Address(RVA = "0xE106E0", Offset = "0xE0FAE0", Length = "0x19")]
		[Token(Token = "0x60006D4")]
		internal void <SetMovie>b__1(VideoPlayer source) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E7")]
	private sealed class <CoroutineWaitForEnd>d__24 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004AD")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004AE")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004AF")]
		public TXEMoviePlayer <>4__this; //Field offset: 0x20

		[Token(Token = "0x170001FC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006D8")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001FD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006DA")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60006D5")]
		public <CoroutineWaitForEnd>d__24(int <>1__state) { }

		[Address(RVA = "0x2719EF0", Offset = "0x27192F0", Length = "0x60")]
		[Token(Token = "0x60006D7")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006D8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006DA")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2719F60", Offset = "0x2719360", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60006D9")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60006D6")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E8")]
	private sealed class <CoroutineWaitForPlay>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004B0")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004B1")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004B2")]
		public TXEMoviePlayer <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004B3")]
		public bool skipOnDrop; //Field offset: 0x28

		[Token(Token = "0x170001FE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006DE")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001FF")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006E0")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60006DB")]
		public <CoroutineWaitForPlay>d__23(int <>1__state) { }

		[Address(RVA = "0x2719FA0", Offset = "0x27193A0", Length = "0x19F")]
		[Token(Token = "0x60006DD")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006DE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006E0")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271A140", Offset = "0x2719540", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60006DF")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60006DC")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E9")]
	private sealed class <CoroutineWaitForReady>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004B4")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004B5")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004B6")]
		public TXEMoviePlayer <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000200")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006E4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000201")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006E6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60006E1")]
		public <CoroutineWaitForReady>d__22(int <>1__state) { }

		[Address(RVA = "0x271A180", Offset = "0x2719580", Length = "0xF7")]
		[Token(Token = "0x60006E3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006E4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006E6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271A280", Offset = "0x2719680", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60006E5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60006E2")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20000E5")]
	internal enum Status : int
	{
		Initializing = 0,
		PlayReady = 1,
		Playing = 2,
		Pause = 3,
		Stop = 4,
	}

	[Token(Token = "0x40004A3")]
	private static readonly String[] moviePaths; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400049D")]
	private Status _state; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400049E")]
	private bool _isErrorStop; //Field offset: 0x24
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x400049F")]
	private bool _isReady; //Field offset: 0x25
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004A0")]
	private RawImage _rawImage; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004A1")]
	private EventHandler _prepareCompleted; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004A2")]
	private EventHandler _loopPointReached; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40004A4")]
	private VideoPlayer _videoPlayer; //Field offset: 0x40

	[Token(Token = "0x170001F8")]
	private bool _isInitialized
	{
		[Address(RVA = "0x2716810", Offset = "0x2715C10", Length = "0x50")]
		[Token(Token = "0x60006C0")]
		private get { } //Length: 80
	}

	[Token(Token = "0x170001FB")]
	public bool IsErrorStop
	{
		[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
		[Token(Token = "0x60006C3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001FA")]
	public bool IsPlaying
	{
		[Address(RVA = "0x2716790", Offset = "0x2715B90", Length = "0x7F")]
		[Token(Token = "0x60006C2")]
		 get { } //Length: 127
	}

	[Token(Token = "0x170001F9")]
	public Status State
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60006C1")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x27166A0", Offset = "0x2715AA0", Length = "0xE2")]
	[Token(Token = "0x60006CE")]
	private static TXEMoviePlayer() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60006CD")]
	public TXEMoviePlayer() { }

	[Address(RVA = "0x2716660", Offset = "0x2715A60", Length = "0x2F")]
	[CompilerGenerated]
	[Token(Token = "0x60006CF")]
	private void <Initialize>b__15_0(VideoPlayer source) { }

	[Address(RVA = "0x2716690", Offset = "0x2715A90", Length = "0xC")]
	[CompilerGenerated]
	[Token(Token = "0x60006D0")]
	private void <Initialize>b__15_1(VideoPlayer source, string message) { }

	[Address(RVA = "0x1EE30C0", Offset = "0x1EE24C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60006D1")]
	private void <Initialize>b__15_2(VideoPlayer source) { }

	[Address(RVA = "0x2715DF0", Offset = "0x27151F0", Length = "0x67")]
	[IteratorStateMachine(typeof(<CoroutineWaitForEnd>d__24))]
	[Token(Token = "0x60006CC")]
	public IEnumerator CoroutineWaitForEnd() { }

	[Address(RVA = "0x2715E60", Offset = "0x2715260", Length = "0x78")]
	[IteratorStateMachine(typeof(<CoroutineWaitForPlay>d__23))]
	[Token(Token = "0x60006CB")]
	public IEnumerator CoroutineWaitForPlay(bool skipOnDrop = true) { }

	[Address(RVA = "0x2715EE0", Offset = "0x27152E0", Length = "0x67")]
	[IteratorStateMachine(typeof(<CoroutineWaitForReady>d__22))]
	[Token(Token = "0x60006CA")]
	public IEnumerator CoroutineWaitForReady() { }

	[Address(RVA = "0x2716810", Offset = "0x2715C10", Length = "0x50")]
	[Token(Token = "0x60006C0")]
	private bool get__isInitialized() { }

	[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
	[Token(Token = "0x60006C3")]
	public bool get_IsErrorStop() { }

	[Address(RVA = "0x2716790", Offset = "0x2715B90", Length = "0x7F")]
	[Token(Token = "0x60006C2")]
	public bool get_IsPlaying() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60006C1")]
	public Status get_State() { }

	[Address(RVA = "0x2715F50", Offset = "0x2715350", Length = "0x15C")]
	[Token(Token = "0x60006C6")]
	private string GetMoviePath(string mname) { }

	[Address(RVA = "0x27160B0", Offset = "0x27154B0", Length = "0x1DD")]
	[Token(Token = "0x60006C4")]
	public TXEMoviePlayer Initialize(RawImage rawImage) { }

	[Address(RVA = "0x2716290", Offset = "0x2715690", Length = "0x24")]
	[Token(Token = "0x60006C8")]
	public void Pause() { }

	[Address(RVA = "0x27162C0", Offset = "0x27156C0", Length = "0x64")]
	[Token(Token = "0x60006C7")]
	public bool Play(bool isLoop = false) { }

	[Address(RVA = "0x2716330", Offset = "0x2715730", Length = "0x2F9")]
	[Token(Token = "0x60006C5")]
	public void SetMovie(string movieName, Action onPlayEnd) { }

	[Address(RVA = "0x2716630", Offset = "0x2715A30", Length = "0x24")]
	[Token(Token = "0x60006C9")]
	public void Stop() { }

}

