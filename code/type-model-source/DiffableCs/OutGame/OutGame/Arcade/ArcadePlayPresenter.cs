namespace OutGame.Arcade;

[Token(Token = "0x20001D0")]
public class ArcadePlayPresenter : GamePlayPresenterBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001D3")]
	private sealed class <_BeginView>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000813")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000814")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000815")]
		public ArcadePlayPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000299")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BB6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700029A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BB8")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000BB3")]
		public <_BeginView>d__3(int <>1__state) { }

		[Address(RVA = "0x221F220", Offset = "0x221E620", Length = "0x1D7")]
		[Token(Token = "0x6000BB5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BB6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BB8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x221F810", Offset = "0x221EC10", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000BB7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000BB4")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001D4")]
	private sealed class <_EndView>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000816")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000817")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x1700029B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BBC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700029C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BBE")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000BB9")]
		public <_EndView>d__7(int <>1__state) { }

		[Address(RVA = "0x2220090", Offset = "0x221F490", Length = "0xC3")]
		[Token(Token = "0x6000BBB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BBC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BBE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2220160", Offset = "0x221F560", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000BBD")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000BBA")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001D5")]
	private sealed class <_Initialize>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000818")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000819")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400081A")]
		public ArcadePlayPresenter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400081B")]
		private InGameManager <ingm>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400081C")]
		private bool <isSkipReset>5__3; //Field offset: 0x30

		[Token(Token = "0x1700029D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BC2")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700029E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BC4")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000BBF")]
		public <_Initialize>d__2(int <>1__state) { }

		[Address(RVA = "0x2221880", Offset = "0x2220C80", Length = "0x608")]
		[Token(Token = "0x6000BC1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2221EF0", Offset = "0x22212F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC0")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001D6")]
	private sealed class <_Terminate>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400081D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400081E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400081F")]
		public ArcadePlayPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700029F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BC8")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170002A0")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BCA")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC5")]
		public <_Terminate>d__8(int <>1__state) { }

		[Address(RVA = "0x2222170", Offset = "0x2221570", Length = "0x9A")]
		[Token(Token = "0x6000BC7")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BCA")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2222350", Offset = "0x2221750", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC9")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC6")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001D7")]
	private sealed class <_UpdateCoroutine>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000820")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000821")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000822")]
		public ArcadePlayPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x170002A1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BCE")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170002A2")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BD0")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000BCB")]
		public <_UpdateCoroutine>d__4(int <>1__state) { }

		[Address(RVA = "0x2222890", Offset = "0x2221C90", Length = "0x115")]
		[Token(Token = "0x6000BCD")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BCE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BD0")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x22229F0", Offset = "0x2221DF0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000BCF")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000BCC")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20001D2")]
	internal class CarriedData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400080C")]
		public PlayerInformation _pinfo; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400080D")]
		public PlayerCommonData _pdata; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400080E")]
		public HashSet<Int32> _dropItems; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400080F")]
		public int _startRound; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000810")]
		public int _clearCount; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000811")]
		public float _startDiPoint; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000812")]
		public long _highScore; //Field offset: 0x38

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BB2")]
		public CarriedData() { }

	}

	[Token(Token = "0x20001D1")]
	internal class Value : IPresenterValue
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000806")]
		private int _startStage; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000807")]
		private int _startRound; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000808")]
		private bool _isInfinityMode; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x4000809")]
		private bool _isShutterPlay; //Field offset: 0x19
		[FieldOffset(Offset = "0x1A")]
		[Token(Token = "0x400080A")]
		private bool _isStartOver; //Field offset: 0x1A
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400080B")]
		private CarriedData _cdata; //Field offset: 0x20

		[Token(Token = "0x17000296")]
		public bool IsInfinity
		{
			[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
			[Token(Token = "0x6000BAA")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000297")]
		public bool IsShutterPlay
		{
			[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
			[Token(Token = "0x6000BAB")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000298")]
		public bool IsStartOver
		{
			[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
			[Token(Token = "0x6000BAC")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000295")]
		public int StartRound
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[Token(Token = "0x6000BA9")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000294")]
		public int StartStage
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x6000BA8")]
			 get { } //Length: 85
		}

		[Address(RVA = "0x2226BA0", Offset = "0x2225FA0", Length = "0x60")]
		[Token(Token = "0x6000BA7")]
		public Value(int tstage, int tround, bool isInfinity, bool isShutterPlay) { }

		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000BAA")]
		public bool get_IsInfinity() { }

		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[Token(Token = "0x6000BAB")]
		public bool get_IsShutterPlay() { }

		[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
		[Token(Token = "0x6000BAC")]
		public bool get_IsStartOver() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000BA9")]
		public int get_StartRound() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000BA8")]
		public int get_StartStage() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000BB1")]
		public CarriedData GetCarryData() { }

		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x6000BAE")]
		public override string GetString() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000BAD")]
		public override int GetValue(int n) { }

		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000BB0")]
		public void SetCarryData(CarriedData tdata) { }

		[Address(RVA = "0x2226860", Offset = "0x2225C60", Length = "0x17")]
		[Token(Token = "0x6000BAF")]
		public void SetStartOver() { }

	}

	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40007FA")]
	private InGameViewUI _ingameUI; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40007FB")]
	private ViewGameover _gameoverLabel; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40007FC")]
	private AssetReference _ingameResident; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40007FD")]
	private TXEMoviePlayer _moviePlayer; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40007FE")]
	private RawImage _movieImage; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40007FF")]
	private ArcadePlayModel _acmodel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000800")]
	private AssetReferenceTable _stages; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000801")]
	private GameAddPoints _diPointTable; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000802")]
	private ExtendScores _extendScores; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000803")]
	private CarriedData _carryData; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000804")]
	private bool _isShutterPlay; //Field offset: 0x90
	[FieldOffset(Offset = "0x91")]
	[Token(Token = "0x4000805")]
	private bool _isQuit; //Field offset: 0x91

	[Address(RVA = "0x22131D0", Offset = "0x22125D0", Length = "0x67")]
	[IteratorStateMachine(typeof(<_BeginView>d__3))]
	[Token(Token = "0x6000BA0")]
	protected virtual IEnumerator _BeginView() { }

	[Address(RVA = "0x2213240", Offset = "0x2212640", Length = "0x4B")]
	[IteratorStateMachine(typeof(<_EndView>d__7))]
	[Token(Token = "0x6000BA4")]
	protected virtual IEnumerator _EndView() { }

	[Address(RVA = "0x2213290", Offset = "0x2212690", Length = "0x67")]
	[IteratorStateMachine(typeof(<_Initialize>d__2))]
	[Token(Token = "0x6000B9F")]
	protected virtual IEnumerator _Initialize() { }

	[Address(RVA = "0x2213300", Offset = "0x2212700", Length = "0x67")]
	[IteratorStateMachine(typeof(<_Terminate>d__8))]
	[Token(Token = "0x6000BA5")]
	protected virtual IEnumerator _Terminate() { }

	[Address(RVA = "0x22133E0", Offset = "0x22127E0", Length = "0x16D")]
	[Token(Token = "0x6000BA2")]
	protected virtual void _Update() { }

	[Address(RVA = "0x2213370", Offset = "0x2212770", Length = "0x67")]
	[IteratorStateMachine(typeof(<_UpdateCoroutine>d__4))]
	[Token(Token = "0x6000BA1")]
	protected virtual IEnumerator _UpdateCoroutine() { }

	[Address(RVA = "0x21C5A40", Offset = "0x21C4E40", Length = "0x7")]
	[Token(Token = "0x6000BA6")]
	public ArcadePlayPresenter() { }

	[Address(RVA = "0x2212BE0", Offset = "0x2211FE0", Length = "0x5EB")]
	[Token(Token = "0x6000BA3")]
	private void CheckQuit(InGameManager gm) { }

}

