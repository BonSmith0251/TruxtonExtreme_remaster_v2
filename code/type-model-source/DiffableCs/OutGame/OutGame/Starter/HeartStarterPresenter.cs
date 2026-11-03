namespace OutGame.Starter;

[Token(Token = "0x20000A0")]
public class HeartStarterPresenter : GamePlayPresenterBase
{
	[CompilerGenerated]
	[Token(Token = "0x20000A2")]
	private sealed class <_BeginView>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400026A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400026B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400026C")]
		public HeartStarterPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000F8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600040D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000F9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600040F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600040A")]
		public <_BeginView>d__2(int <>1__state) { }

		[Address(RVA = "0x21E1240", Offset = "0x21E0640", Length = "0xC7")]
		[Token(Token = "0x600040C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600040D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600040F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21E1520", Offset = "0x21E0920", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600040E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600040B")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A3")]
	private sealed class <_EndView>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400026D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400026E")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x170000FA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000413")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000FB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000415")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000410")]
		public <_EndView>d__6(int <>1__state) { }

		[Address(RVA = "0x21E18A0", Offset = "0x21E0CA0", Length = "0x81")]
		[Token(Token = "0x6000412")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000413")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000415")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21E1A40", Offset = "0x21E0E40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000414")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000411")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A4")]
	private sealed class <_Initialize>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400026F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000270")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000271")]
		public HeartStarterPresenter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000272")]
		private bool <isSO>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000273")]
		private InGameManager <ingm>5__3; //Field offset: 0x30

		[Token(Token = "0x170000FC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000419")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000FD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600041B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000416")]
		public <_Initialize>d__1(int <>1__state) { }

		[Address(RVA = "0x21E2220", Offset = "0x21E1620", Length = "0x45F")]
		[Token(Token = "0x6000418")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000419")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600041B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21E2CE0", Offset = "0x21E20E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600041A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000417")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A5")]
	private sealed class <_Terminate>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000274")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000275")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000276")]
		public HeartStarterPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000FE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600041F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000FF")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000421")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600041C")]
		public <_Terminate>d__7(int <>1__state) { }

		[Address(RVA = "0x21E33C0", Offset = "0x21E27C0", Length = "0x9A")]
		[Token(Token = "0x600041E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600041F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000421")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21E3460", Offset = "0x21E2860", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000420")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600041D")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A6")]
	private sealed class <_UpdateCoroutine>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000277")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000278")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000279")]
		public HeartStarterPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000100")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000425")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000101")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000427")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000422")]
		public <_UpdateCoroutine>d__3(int <>1__state) { }

		[Address(RVA = "0x21E3930", Offset = "0x21E2D30", Length = "0x12F")]
		[Token(Token = "0x6000424")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000425")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000427")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21E3A60", Offset = "0x21E2E60", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000426")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000423")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20000A1")]
	internal class Value : IPresenterValue
	{

		[Token(Token = "0x170000F7")]
		public bool IsStartOver
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6000406")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000409")]
		public Value() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000406")]
		public bool get_IsStartOver() { }

		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x6000408")]
		public override string GetString() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000407")]
		public override int GetValue(int n) { }

	}

	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000261")]
	private InGameViewUI _ingameUI; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000262")]
	private AssetReference _ingameResident; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000263")]
	private TXEMoviePlayer _moviePlayer; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000264")]
	private RawImage _movieImage; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000265")]
	private HeartStarterModel _hsmodel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000266")]
	private AssetReference _stage; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000267")]
	private GameAddPoints _diPointTable; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000268")]
	private ExtendScores _extendScores; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000269")]
	private bool _isQuit; //Field offset: 0x80

	[Address(RVA = "0x21D7460", Offset = "0x21D6860", Length = "0x67")]
	[IteratorStateMachine(typeof(<_BeginView>d__2))]
	[Token(Token = "0x60003FF")]
	protected virtual IEnumerator _BeginView() { }

	[Address(RVA = "0x21D74D0", Offset = "0x21D68D0", Length = "0x4B")]
	[IteratorStateMachine(typeof(<_EndView>d__6))]
	[Token(Token = "0x6000403")]
	protected virtual IEnumerator _EndView() { }

	[Address(RVA = "0x21D7520", Offset = "0x21D6920", Length = "0x67")]
	[IteratorStateMachine(typeof(<_Initialize>d__1))]
	[Token(Token = "0x60003FE")]
	protected virtual IEnumerator _Initialize() { }

	[Address(RVA = "0x21D7590", Offset = "0x21D6990", Length = "0x67")]
	[IteratorStateMachine(typeof(<_Terminate>d__7))]
	[Token(Token = "0x6000404")]
	protected virtual IEnumerator _Terminate() { }

	[Address(RVA = "0x21D7670", Offset = "0x21D6A70", Length = "0x16D")]
	[Token(Token = "0x6000401")]
	protected virtual void _Update() { }

	[Address(RVA = "0x21D7600", Offset = "0x21D6A00", Length = "0x67")]
	[IteratorStateMachine(typeof(<_UpdateCoroutine>d__3))]
	[Token(Token = "0x6000400")]
	protected virtual IEnumerator _UpdateCoroutine() { }

	[Address(RVA = "0x21C5A40", Offset = "0x21C4E40", Length = "0x7")]
	[Token(Token = "0x6000405")]
	public HeartStarterPresenter() { }

	[Address(RVA = "0x21D70A0", Offset = "0x21D64A0", Length = "0x3B5")]
	[Token(Token = "0x6000402")]
	private void CheckQuit(InGameManager gm) { }

}

