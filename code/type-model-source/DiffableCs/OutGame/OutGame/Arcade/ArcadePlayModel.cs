namespace OutGame.Arcade;

[Token(Token = "0x20001CB")]
public class ArcadePlayModel : ModelGamePlayBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001CC")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x20001CD")]
		private sealed class <<RequestNextStage>g__stageFinisher|1>d : IEnumerator<Object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40007F0")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40007F1")]
			private object <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40007F2")]
			public <>c__DisplayClass2_0 <>4__this; //Field offset: 0x20

			[Token(Token = "0x1700028D")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000B91")]
				private get { } //Length: 5
			}

			[Token(Token = "0x1700028E")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000B93")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x6000B8E")]
			public <<RequestNextStage>g__stageFinisher|1>d(int <>1__state) { }

			[Address(RVA = "0x221D650", Offset = "0x221CA50", Length = "0x2AF")]
			[Token(Token = "0x6000B90")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000B91")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000B93")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x221D900", Offset = "0x221CD00", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000B92")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x6000B8F")]
			private override void System.IDisposable.Dispose() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007EC")]
		public InGameManager gm; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007ED")]
		public ArcadePlayModel <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007EE")]
		public bool isNext; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007EF")]
		public PlayerInformation pinfo; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B8B")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x221D940", Offset = "0x221CD40", Length = "0x89")]
		[Token(Token = "0x6000B8C")]
		internal void <RequestNextStage>b__0() { }

		[Address(RVA = "0x221D9D0", Offset = "0x221CDD0", Length = "0x67")]
		[IteratorStateMachine(typeof(<<RequestNextStage>g__stageFinisher|1>d))]
		[Token(Token = "0x6000B8D")]
		internal IEnumerator <RequestNextStage>g__stageFinisher|1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001CE")]
	private sealed class <RequestNextStage>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007F3")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007F4")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007F5")]
		public ArcadePlayModel <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007F6")]
		private <>c__DisplayClass2_0 <>8__1; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40007F7")]
		private StageInformation <stgInfo>5__2; //Field offset: 0x30

		[Token(Token = "0x1700028F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000B97")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000290")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000B99")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000B94")]
		public <RequestNextStage>d__2(int <>1__state) { }

		[Address(RVA = "0x221C970", Offset = "0x221BD70", Length = "0x450")]
		[Token(Token = "0x6000B96")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000B97")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000B99")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x221CDE0", Offset = "0x221C1E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000B98")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000B95")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40007EA")]
	private bool _isRoundLoopStart; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40007EB")]
	private CarriedData _cdata; //Field offset: 0x80

	[Token(Token = "0x1700028C")]
	public CarriedData CarryData
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6000B8A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700028B")]
	public bool IsRoundLoopStart
	{
		[Address(RVA = "0x1D14910", Offset = "0x1D13D10", Length = "0x5")]
		[Token(Token = "0x6000B89")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2212B70", Offset = "0x2211F70", Length = "0x63")]
	[Token(Token = "0x6000B80")]
	public ArcadePlayModel(AssetReferenceTable stages) { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6000B8A")]
	public CarriedData get_CarryData() { }

	[Address(RVA = "0x1D14910", Offset = "0x1D13D10", Length = "0x5")]
	[Token(Token = "0x6000B89")]
	public bool get_IsRoundLoopStart() { }

	[Address(RVA = "0x2212860", Offset = "0x2211C60", Length = "0x59")]
	[Token(Token = "0x6000B86")]
	protected virtual int GetBomberCount() { }

	[Address(RVA = "0x22128C0", Offset = "0x2211CC0", Length = "0xA8")]
	[Token(Token = "0x6000B84")]
	protected virtual long GetHighScore() { }

	[Address(RVA = "0x2212980", Offset = "0x2211D80", Length = "0x59")]
	[Token(Token = "0x6000B85")]
	protected virtual int GetPlayerCount() { }

	[Address(RVA = "0x2212970", Offset = "0x2211D70", Length = "0xC")]
	[Token(Token = "0x6000B88")]
	protected virtual PlayMode GetPlayMode() { }

	[Address(RVA = "0x22129E0", Offset = "0x2211DE0", Length = "0x10")]
	[Token(Token = "0x6000B87")]
	public virtual bool IsSkipTakeOffMovie() { }

	[Address(RVA = "0x22129F0", Offset = "0x2211DF0", Length = "0xC3")]
	[Token(Token = "0x6000B81")]
	public StageInformation PrepareResults(InGameManager gm, bool isComplete) { }

	[Address(RVA = "0x2212AC0", Offset = "0x2211EC0", Length = "0x67")]
	[IteratorStateMachine(typeof(<RequestNextStage>d__2))]
	[Token(Token = "0x6000B82")]
	public IEnumerator RequestNextStage() { }

	[Address(RVA = "0x2212B30", Offset = "0x2211F30", Length = "0x36")]
	[Token(Token = "0x6000B83")]
	public void SetCarryData(CarriedData tdata) { }

}

