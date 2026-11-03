namespace OutGame.Team;

[Token(Token = "0x2000095")]
public class TeamPlayPresenter : GamePlayPresenterBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000097")]
	private sealed class <_BeginView>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000248")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000249")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400024A")]
		public TeamPlayPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000E7")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003C6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000E8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003C8")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003C3")]
		public <_BeginView>d__2(int <>1__state) { }

		[Address(RVA = "0x21E1240", Offset = "0x21E0640", Length = "0xC7")]
		[Token(Token = "0x60003C5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003C6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003C8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21E14A0", Offset = "0x21E08A0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003C7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003C4")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000098")]
	private sealed class <_EndView>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400024B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400024C")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x170000E9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003CC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000EA")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003CE")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003C9")]
		public <_EndView>d__6(int <>1__state) { }

		[Address(RVA = "0x21E1930", Offset = "0x21E0D30", Length = "0xC3")]
		[Token(Token = "0x60003CB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003CC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003CE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21E1A00", Offset = "0x21E0E00", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003CD")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003CA")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000099")]
	private sealed class <_Initialize>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400024D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400024E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400024F")]
		public TeamPlayPresenter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000250")]
		private InGameManager <ingm>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000251")]
		private int <pstage>5__3; //Field offset: 0x30

		[Token(Token = "0x170000EB")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003D2")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000EC")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003D4")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003CF")]
		public <_Initialize>d__1(int <>1__state) { }

		[Address(RVA = "0x21E2720", Offset = "0x21E1B20", Length = "0xB0")]
		[Token(Token = "0x60003D1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003D2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003D4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21E2CA0", Offset = "0x21E20A0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003D3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003D0")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200009A")]
	private sealed class <_Terminate>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000252")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000253")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000254")]
		public TeamPlayPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000ED")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003D8")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000EE")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003DA")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003D5")]
		public <_Terminate>d__7(int <>1__state) { }

		[Address(RVA = "0x21E33C0", Offset = "0x21E27C0", Length = "0x9A")]
		[Token(Token = "0x60003D7")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003D8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003DA")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21E34A0", Offset = "0x21E28A0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003D9")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003D6")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200009B")]
	private sealed class <_UpdateCoroutine>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000255")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000256")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000257")]
		public TeamPlayPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000EF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003DE")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000F0")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003E0")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003DB")]
		public <_UpdateCoroutine>d__3(int <>1__state) { }

		[Address(RVA = "0x21E3810", Offset = "0x21E2C10", Length = "0x115")]
		[Token(Token = "0x60003DD")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003DE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003E0")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21E3AA0", Offset = "0x21E2EA0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003DF")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003DC")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000096")]
	internal class Value : IPresenterValue
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000246")]
		private int _startStage; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000247")]
		private bool _doublePlay; //Field offset: 0x14

		[Token(Token = "0x170000E6")]
		public bool DoublePlay
		{
			[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
			[Token(Token = "0x60003C0")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170000E5")]
		public int StartStage
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x60003BF")]
			 get { } //Length: 85
		}

		[Address(RVA = "0x20933F0", Offset = "0x20927F0", Length = "0x36")]
		[Token(Token = "0x60003BE")]
		public Value(int tstage, bool tdouble) { }

		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x60003C0")]
		public bool get_DoublePlay() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60003BF")]
		public int get_StartStage() { }

		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x60003C2")]
		public override string GetString() { }

		[Address(RVA = "0x21E6C80", Offset = "0x21E6080", Length = "0x12")]
		[Token(Token = "0x60003C1")]
		public override int GetValue(int n) { }

	}

	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400023D")]
	private InGameViewUI _ingameUI; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400023E")]
	private ViewGameover _gameoverLabel; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400023F")]
	private AssetReference _ingameResident; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000240")]
	private RawImage _resultImage; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000241")]
	private TeamPlayModel _tpmodel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000242")]
	private AssetReferenceTable _stageTables; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000243")]
	private GameAddPoints _diPointTable; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000244")]
	private ExtendScores _extendScores; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000245")]
	private bool _isShutterPlay; //Field offset: 0x80

	[Address(RVA = "0x21DACC0", Offset = "0x21DA0C0", Length = "0x67")]
	[IteratorStateMachine(typeof(<_BeginView>d__2))]
	[Token(Token = "0x60003B7")]
	protected virtual IEnumerator _BeginView() { }

	[Address(RVA = "0x21DAD30", Offset = "0x21DA130", Length = "0x4B")]
	[IteratorStateMachine(typeof(<_EndView>d__6))]
	[Token(Token = "0x60003BB")]
	protected virtual IEnumerator _EndView() { }

	[Address(RVA = "0x21DAD80", Offset = "0x21DA180", Length = "0x67")]
	[IteratorStateMachine(typeof(<_Initialize>d__1))]
	[Token(Token = "0x60003B6")]
	protected virtual IEnumerator _Initialize() { }

	[Address(RVA = "0x21DADF0", Offset = "0x21DA1F0", Length = "0x67")]
	[IteratorStateMachine(typeof(<_Terminate>d__7))]
	[Token(Token = "0x60003BC")]
	protected virtual IEnumerator _Terminate() { }

	[Address(RVA = "0x21DAED0", Offset = "0x21DA2D0", Length = "0x15D")]
	[Token(Token = "0x60003B9")]
	protected virtual void _Update() { }

	[Address(RVA = "0x21DAE60", Offset = "0x21DA260", Length = "0x67")]
	[IteratorStateMachine(typeof(<_UpdateCoroutine>d__3))]
	[Token(Token = "0x60003B8")]
	protected virtual IEnumerator _UpdateCoroutine() { }

	[Address(RVA = "0x21C5A40", Offset = "0x21C4E40", Length = "0x7")]
	[Token(Token = "0x60003BD")]
	public TeamPlayPresenter() { }

	[Address(RVA = "0x21DA8E0", Offset = "0x21D9CE0", Length = "0x3DD")]
	[Token(Token = "0x60003BA")]
	private void CheckQuit(InGameManager gm) { }

}

