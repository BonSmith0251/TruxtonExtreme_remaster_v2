namespace OutGame.Arena;

[Token(Token = "0x20001B6")]
public class ArenaPlayModel : ModelGamePlayBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001B7")]
	private sealed class <CreatePlayer>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000797")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000798")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000799")]
		public ArenaPlayModel <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700025D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000AF4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700025E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000AF6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000AF1")]
		public <CreatePlayer>d__1(int <>1__state) { }

		[Address(RVA = "0x221C2D0", Offset = "0x221B6D0", Length = "0x88")]
		[Token(Token = "0x6000AF3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000AF4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000AF6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x221C360", Offset = "0x221B760", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000AF5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000AF2")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001B8")]
	private sealed class <RequestFinish>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400079A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400079B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400079C")]
		public ArenaPlayModel <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400079D")]
		private InGameManager <gm>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400079E")]
		private PlayerInformation <pinfo>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400079F")]
		private StageInformation <stgInfo>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40007A0")]
		private NoPlayScope <>7__wrap4; //Field offset: 0x40

		[Token(Token = "0x1700025F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000AFB")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000260")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000AFD")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000AF7")]
		public <RequestFinish>d__3(int <>1__state) { }

		[Address(RVA = "0x221C920", Offset = "0x221BD20", Length = "0x50")]
		[Token(Token = "0x6000AFA")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x221C3A0", Offset = "0x221B7A0", Length = "0x4A1")]
		[Token(Token = "0x6000AF9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000AFB")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000AFD")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x221C850", Offset = "0x221BC50", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000AFC")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x221C890", Offset = "0x221BC90", Length = "0x8E")]
		[DebuggerHidden]
		[Token(Token = "0x6000AF8")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001B9")]
	private sealed class <StartStage>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007A1")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007A2")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007A3")]
		public ArenaPlayModel <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007A4")]
		public CancellationToken _token; //Field offset: 0x28

		[Token(Token = "0x17000261")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000B01")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000262")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000B03")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000AFE")]
		public <StartStage>d__5(int <>1__state) { }

		[Address(RVA = "0x221D420", Offset = "0x221C820", Length = "0x1EE")]
		[Token(Token = "0x6000B00")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000B01")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000B03")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x221D610", Offset = "0x221CA10", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000B02")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000AFF")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000794")]
	private Value _startValue; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000795")]
	private UIBossGauge _timeGauge; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000796")]
	private int _displaySeconds; //Field offset: 0x88

	[Address(RVA = "0x2214BC0", Offset = "0x2213FC0", Length = "0x63")]
	[Token(Token = "0x6000ADD")]
	public ArenaPlayModel(AssetReferenceTable stages) { }

	[Address(RVA = "0x21D7040", Offset = "0x21D6440", Length = "0x7")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000AEF")]
	private IEnumerator <>n__0() { }

	[Address(RVA = "0x2214820", Offset = "0x2213C20", Length = "0x8")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000AF0")]
	private IEnumerator <>n__1(CancellationToken _token) { }

	[Address(RVA = "0x2214530", Offset = "0x2213930", Length = "0x67")]
	[IteratorStateMachine(typeof(<CreatePlayer>d__1))]
	[Token(Token = "0x6000ADE")]
	protected virtual IEnumerator CreatePlayer() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AEB")]
	protected virtual int GetBGMSetting() { }

	[Address(RVA = "0x22145A0", Offset = "0x22139A0", Length = "0x2C")]
	[Token(Token = "0x6000AE7")]
	protected virtual int GetBomberCount() { }

	[Address(RVA = "0x21D6EB0", Offset = "0x21D62B0", Length = "0x9")]
	[Token(Token = "0x6000AE8")]
	protected virtual float GetDamageMag() { }

	[Address(RVA = "0x22145D0", Offset = "0x22139D0", Length = "0x70")]
	[Token(Token = "0x6000AE5")]
	protected virtual long GetHighScore() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AE6")]
	protected virtual int GetPlayerCount() { }

	[Address(RVA = "0x2214650", Offset = "0x2213A50", Length = "0x9")]
	[Token(Token = "0x6000AEE")]
	private float GetPlaySeconds() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000AEC")]
	protected virtual bool IsAutoBomber() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000AE4")]
	public virtual bool IsMuteStart() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000AED")]
	public virtual bool IsSkipTakeOffMovie() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AE9")]
	protected virtual int P1FighterType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AEA")]
	protected virtual int P2FighterType() { }

	[Address(RVA = "0x2214660", Offset = "0x2213A60", Length = "0xB3")]
	[Token(Token = "0x6000ADF")]
	public StageInformation PrepareResults(InGameManager gm) { }

	[Address(RVA = "0x2214720", Offset = "0x2213B20", Length = "0x67")]
	[IteratorStateMachine(typeof(<RequestFinish>d__3))]
	[Token(Token = "0x6000AE0")]
	public IEnumerator RequestFinish() { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[Token(Token = "0x6000AE1")]
	public void SetValues(Value tvalue) { }

	[Address(RVA = "0x2214790", Offset = "0x2213B90", Length = "0x83")]
	[IteratorStateMachine(typeof(<StartStage>d__5))]
	[Token(Token = "0x6000AE2")]
	public virtual IEnumerator StartStage(CancellationToken _token) { }

	[Address(RVA = "0x2214830", Offset = "0x2213C30", Length = "0x387")]
	[Token(Token = "0x6000AE3")]
	public bool UpdateTime(float tpass, bool isGameOver) { }

}

