namespace InGame.Kernel;

[DefaultExecutionOrder(-2)]
[Token(Token = "0x2000047")]
public class InGameManager : MonoBehaviourSingleton<InGameManager>
{
	[CompilerGenerated]
	[Token(Token = "0x2000068")]
	private sealed class <_gameForceQuitPhase>d__417 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400036E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400036F")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000370")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000371")]
		private float <passtime>5__2; //Field offset: 0x28

		[Token(Token = "0x170000D4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600045B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000D5")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600045D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000458")]
		public <_gameForceQuitPhase>d__417(int <>1__state) { }

		[Address(RVA = "0x1D2E690", Offset = "0x1D2DA90", Length = "0x64")]
		[Token(Token = "0x600045A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600045B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600045D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2E990", Offset = "0x1D2DD90", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600045C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000459")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000069")]
	private sealed class <_gameOver>d__416 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000372")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000373")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000374")]
		public InGameManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000D6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000461")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000D7")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000463")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600045E")]
		public <_gameOver>d__416(int <>1__state) { }

		[Address(RVA = "0x1D2E9D0", Offset = "0x1D2DDD0", Length = "0x1E0")]
		[Token(Token = "0x6000460")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000461")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000463")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2EBC0", Offset = "0x1D2DFC0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000462")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600045F")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006A")]
	private sealed class <_playerDeadPhase>d__410 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000375")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000376")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000377")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000378")]
		private int <numDeadPlayer>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000379")]
		private float <srate>5__3; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400037A")]
		private NoPlayScope <>7__wrap3; //Field offset: 0x30

		[Token(Token = "0x170000D8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000468")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000D9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600046A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000464")]
		public <_playerDeadPhase>d__410(int <>1__state) { }

		[Address(RVA = "0x1D2FCD0", Offset = "0x1D2F0D0", Length = "0x50")]
		[Token(Token = "0x6000467")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1D2F4F0", Offset = "0x1D2E8F0", Length = "0x6E8")]
		[Token(Token = "0x6000466")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000468")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600046A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2FC00", Offset = "0x1D2F000", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000469")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1D2FC40", Offset = "0x1D2F040", Length = "0x8F")]
		[DebuggerHidden]
		[Token(Token = "0x6000465")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006B")]
	private sealed class <_restartGameFast>d__415 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400037B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400037C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400037D")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400037E")]
		private YieldInstruction <twait>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400037F")]
		private float <sstep>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000380")]
		private float <tstep>5__4; //Field offset: 0x34

		[Token(Token = "0x170000DA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600046E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000DB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000470")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600046B")]
		public <_restartGameFast>d__415(int <>1__state) { }

		[Address(RVA = "0x1D2FD20", Offset = "0x1D2F120", Length = "0x2F9")]
		[Token(Token = "0x600046D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600046E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000470")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D30020", Offset = "0x1D2F420", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600046F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600046C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006C")]
	private sealed class <_stageClearPhase>d__406 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000381")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000382")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000383")]
		public InGameManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000DC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000474")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000DD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000476")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000471")]
		public <_stageClearPhase>d__406(int <>1__state) { }

		[Address(RVA = "0x1D30060", Offset = "0x1D2F460", Length = "0x31D")]
		[Token(Token = "0x6000473")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000474")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000476")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D30380", Offset = "0x1D2F780", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000475")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000472")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000065")]
	private sealed class <_TimeoverPhase>d__409 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000365")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000366")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000367")]
		public InGameManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000CE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000449")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000CF")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600044B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000446")]
		public <_TimeoverPhase>d__409(int <>1__state) { }

		[Address(RVA = "0x1D2C1B0", Offset = "0x1D2B5B0", Length = "0x2BD")]
		[Token(Token = "0x6000448")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000449")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600044B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2C470", Offset = "0x1D2B870", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600044A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000447")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000066")]
	private sealed class <_TimeupPhase>d__411 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000368")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000369")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400036A")]
		public InGameManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000D0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600044F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000D1")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000451")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600044C")]
		public <_TimeupPhase>d__411(int <>1__state) { }

		[Address(RVA = "0x1D2C4B0", Offset = "0x1D2B8B0", Length = "0x88")]
		[Token(Token = "0x600044E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600044F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000451")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2C540", Offset = "0x1D2B940", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000450")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600044D")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000067")]
	private sealed class <_TrainingClearPhase>d__408 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400036B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400036C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400036D")]
		public InGameManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000D2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000455")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000D3")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000457")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000452")]
		public <_TrainingClearPhase>d__408(int <>1__state) { }

		[Address(RVA = "0x1D2C580", Offset = "0x1D2B980", Length = "0x1D0")]
		[Token(Token = "0x6000454")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000455")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000457")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2C760", Offset = "0x1D2BB60", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000456")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000453")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004C")]
	private sealed class <>c
	{
		[Token(Token = "0x40002E9")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40002EA")]
		public static Func<PawnEnemy, Boolean> <>9__317_0; //Field offset: 0x8
		[Token(Token = "0x40002EB")]
		public static Func<PawnEnemy, Boolean> <>9__318_0; //Field offset: 0x10

		[Address(RVA = "0x1D2C0A0", Offset = "0x1D2B4A0", Length = "0x67")]
		[Token(Token = "0x60003C1")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60003C2")]
		public <>c() { }

		[Address(RVA = "0x1D2C000", Offset = "0x1D2B400", Length = "0x1F")]
		[Token(Token = "0x60003C4")]
		internal bool <CheckRushBouns>b__318_0(PawnEnemy n) { }

		[Address(RVA = "0xA4D5F0", Offset = "0xA4C9F0", Length = "0x2C")]
		[Token(Token = "0x60003C3")]
		internal bool <StartRushBonus>b__317_0(PawnEnemy e) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004D")]
	private struct <BulletFireAsync>d__303 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002EC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002ED")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002EE")]
		public BulletTemplate bt; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002EF")]
		public CancellationTokenSource ctoken; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002F0")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002F1")]
		public Transform cpost; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002F2")]
		public Vector3 cpos; //Field offset: 0x30
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40002F3")]
		public float sevol; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40002F4")]
		public Action<InGameBulletInterface> generateCallback; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40002F5")]
		private int <loopcount>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40002F6")]
		private float <startArc>5__3; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40002F7")]
		private float <targetArc>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40002F8")]
		private float <speedRate>5__5; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40002F9")]
		private bool <isTarget>5__6; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40002FA")]
		private CancellationToken <token>5__7; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40002FB")]
		private int <loopStep>5__8; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40002FC")]
		private float <delaySecond>5__9; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40002FD")]
		private float <rstep>5__10; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x40002FE")]
		private Awaiter <>u__1; //Field offset: 0x74

		[Address(RVA = "0x1D25750", Offset = "0x1D24B50", Length = "0x5DA")]
		[Token(Token = "0x60003C5")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60003C6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004E")]
	private struct <CheckRushBouns>d__318 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002FF")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000300")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000301")]
		public List<PawnEnemy> penemys; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000302")]
		public InGameManager <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000303")]
		public int tmul; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000304")]
		private Awaiter <>u__1; //Field offset: 0x24

		[Address(RVA = "0x1D25D30", Offset = "0x1D25130", Length = "0x3A4")]
		[Token(Token = "0x60003C7")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60003C8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004F")]
	private sealed class <CleanupEnemyWait>d__407 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000305")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000306")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000307")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000308")]
		public float minSeconds; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000309")]
		private YieldInstruction <twait>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400030A")]
		private float <lpassTime>5__3; //Field offset: 0x38

		[Token(Token = "0x170000A6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003CC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000A7")]
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
		public <CleanupEnemyWait>d__407(int <>1__state) { }

		[Address(RVA = "0x1D260E0", Offset = "0x1D254E0", Length = "0x17F")]
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

		[Address(RVA = "0x1D26260", Offset = "0x1D25660", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003CD")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003CA")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000050")]
	private struct <DelaySecond>d__541 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400030B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400030C")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400030D")]
		public float tsec; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400030E")]
		public CancellationToken token; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400030F")]
		private Awaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x1D27210", Offset = "0x1D26610", Length = "0x263")]
		[Token(Token = "0x60003CF")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60003D0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000051")]
	private struct <DelaySecondReal>d__542 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000310")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000311")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000312")]
		public float tsec; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000313")]
		public CancellationToken token; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000314")]
		private Awaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x1D27020", Offset = "0x1D26420", Length = "0x1E2")]
		[Token(Token = "0x60003D1")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60003D2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000052")]
	private sealed class <FinishStage>d__510 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000315")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000316")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000317")]
		public InGameManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000A8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003D6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000A9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003D8")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003D3")]
		public <FinishStage>d__510(int <>1__state) { }

		[Address(RVA = "0x1D27480", Offset = "0x1D26880", Length = "0x278")]
		[Token(Token = "0x60003D5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003D6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003D8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D27700", Offset = "0x1D26B00", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003D7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003D4")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000053")]
	private sealed class <Initialize>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000318")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000319")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400031A")]
		public InGameManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000AA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003DC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000AB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003DE")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003D9")]
		public <Initialize>d__0(int <>1__state) { }

		[Address(RVA = "0x1D281B0", Offset = "0x1D275B0", Length = "0x673")]
		[Token(Token = "0x60003DB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003DC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003DE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D28830", Offset = "0x1D27C30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003DD")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003DA")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000054")]
	private sealed class <InitializeSubManagers>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400031B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400031C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400031D")]
		public InGameManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000AC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003E2")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000AD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003E4")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003DF")]
		public <InitializeSubManagers>d__4(int <>1__state) { }

		[Address(RVA = "0x1D27740", Offset = "0x1D26B40", Length = "0x908")]
		[Token(Token = "0x60003E1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003E2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003E4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D28050", Offset = "0x1D27450", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003E3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003E0")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000055")]
	private sealed class <InitializeTimeline>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400031E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400031F")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000320")]
		public GameObject tobj; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000321")]
		public InGameManager <>4__this; //Field offset: 0x28

		[Token(Token = "0x170000AE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003E8")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000AF")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003EA")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003E5")]
		public <InitializeTimeline>d__23(int <>1__state) { }

		[Address(RVA = "0x1D28090", Offset = "0x1D27490", Length = "0xDC")]
		[Token(Token = "0x60003E7")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003E8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003EA")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D28170", Offset = "0x1D27570", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003E9")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003E6")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000056")]
	private sealed class <IntervalLow>d__544 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000322")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000323")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000324")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000325")]
		private WaitForSeconds <waitSecond>5__2; //Field offset: 0x28

		[Token(Token = "0x170000B0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003EE")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000B1")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003F0")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003EB")]
		public <IntervalLow>d__544(int <>1__state) { }

		[Address(RVA = "0x1D28870", Offset = "0x1D27C70", Length = "0xD4")]
		[Token(Token = "0x60003ED")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003EE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003F0")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D28950", Offset = "0x1D27D50", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003EF")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003EC")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000057")]
	private sealed class <IntervalNormal>d__543 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000326")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000327")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000328")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000329")]
		private WaitForSeconds <waitSecond>5__2; //Field offset: 0x28

		[Token(Token = "0x170000B2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003F4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000B3")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003F6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003F1")]
		public <IntervalNormal>d__543(int <>1__state) { }

		[Address(RVA = "0x1D28990", Offset = "0x1D27D90", Length = "0xE8")]
		[Token(Token = "0x60003F3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003F4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003F6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D28A80", Offset = "0x1D27E80", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003F5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003F2")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000058")]
	private sealed class <LocalWaitSeconds>d__412 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400032A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400032B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400032C")]
		public bool withBase; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400032D")]
		public float tsec; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400032E")]
		public InGameManager <>4__this; //Field offset: 0x28

		[Token(Token = "0x170000B4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003FA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000B5")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003FC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003F7")]
		public <LocalWaitSeconds>d__412(int <>1__state) { }

		[Address(RVA = "0x1D29680", Offset = "0x1D28A80", Length = "0x103")]
		[Token(Token = "0x60003F9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003FA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003FC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D29790", Offset = "0x1D28B90", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003FB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003F8")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000059")]
	private sealed class <RestartGame>d__414 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400032F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000330")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000331")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000332")]
		public float twait; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000333")]
		public int areaIndex; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000334")]
		public Action startCallBack; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000335")]
		public float swait; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000336")]
		private NoPlayScope <>7__wrap1; //Field offset: 0x40

		[Token(Token = "0x170000B6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000401")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000B7")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000403")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003FD")]
		public <RestartGame>d__414(int <>1__state) { }

		[Address(RVA = "0x1D2A060", Offset = "0x1D29460", Length = "0x50")]
		[Token(Token = "0x6000400")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1D297D0", Offset = "0x1D28BD0", Length = "0x7A0")]
		[Token(Token = "0x60003FF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000401")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000403")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D29F90", Offset = "0x1D29390", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000402")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1D29FD0", Offset = "0x1D293D0", Length = "0x8E")]
		[DebuggerHidden]
		[Token(Token = "0x60003FE")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005A")]
	private sealed class <SetupBullet>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000337")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000338")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000339")]
		public PrefabPacks packs; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400033A")]
		public InGameManager <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400033B")]
		private TXEDataCache <dcache>5__2; //Field offset: 0x30

		[Token(Token = "0x170000B8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000407")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000B9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000409")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000404")]
		public <SetupBullet>d__8(int <>1__state) { }

		[Address(RVA = "0x1D2A1E0", Offset = "0x1D295E0", Length = "0x226")]
		[Token(Token = "0x6000406")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000407")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000409")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2A410", Offset = "0x1D29810", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000408")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000405")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005B")]
	private sealed class <SetupBulletTemplate>d__20 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400033C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400033D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400033E")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400033F")]
		public Dictionary<String, Int32> tdic; //Field offset: 0x28

		[Token(Token = "0x170000BA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600040D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000BB")]
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
		public <SetupBulletTemplate>d__20(int <>1__state) { }

		[Address(RVA = "0x1D2A0B0", Offset = "0x1D294B0", Length = "0xE9")]
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

		[Address(RVA = "0x1D2A1A0", Offset = "0x1D295A0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600040E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600040B")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005C")]
	private sealed class <SetupDatas>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000340")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000341")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000342")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000343")]
		public PrefabPacks bullets; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000344")]
		public PrefabPacks effects; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000345")]
		public Dictionary<String, Int32> players; //Field offset: 0x38

		[Token(Token = "0x170000BC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000413")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000BD")]
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
		public <SetupDatas>d__10(int <>1__state) { }

		[Address(RVA = "0x1D2A450", Offset = "0x1D29850", Length = "0x18C")]
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

		[Address(RVA = "0x1D2A5E0", Offset = "0x1D299E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000414")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000411")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005D")]
	private sealed class <SetupEffect>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000346")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000347")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000348")]
		public PrefabPacks packs; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000349")]
		public InGameManager <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400034A")]
		private TXEDataCache <dcache>5__2; //Field offset: 0x30

		[Token(Token = "0x170000BE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000419")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000BF")]
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
		public <SetupEffect>d__9(int <>1__state) { }

		[Address(RVA = "0x1D2A620", Offset = "0x1D29A20", Length = "0x234")]
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

		[Address(RVA = "0x1D2A860", Offset = "0x1D29C60", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600041A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000417")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005E")]
	private sealed class <SetupEnemyModel>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400034B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400034C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400034D")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400034E")]
		public Dictionary<String, Int32> tdic; //Field offset: 0x28

		[Token(Token = "0x170000C0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600041F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000C1")]
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
		public <SetupEnemyModel>d__19(int <>1__state) { }

		[Address(RVA = "0x1D2A8A0", Offset = "0x1D29CA0", Length = "0xEB")]
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

		[Address(RVA = "0x1D2A990", Offset = "0x1D29D90", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000420")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600041D")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005F")]
	private sealed class <SetupPlayerModel>d__17 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400034F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000350")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000351")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000352")]
		public Dictionary<String, Int32> tdic; //Field offset: 0x28

		[Token(Token = "0x170000C2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000425")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000C3")]
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
		public <SetupPlayerModel>d__17(int <>1__state) { }

		[Address(RVA = "0x1D2A9D0", Offset = "0x1D29DD0", Length = "0x15B")]
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

		[Address(RVA = "0x1D2AB30", Offset = "0x1D29F30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000426")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000423")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000060")]
	private sealed class <SetupRoute>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000353")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000354")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000355")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000356")]
		public Dictionary<String, Int32> _routeNames; //Field offset: 0x28

		[Token(Token = "0x170000C4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600042B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000C5")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600042D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000428")]
		public <SetupRoute>d__21(int <>1__state) { }

		[Address(RVA = "0x1D2AB70", Offset = "0x1D29F70", Length = "0x16A")]
		[Token(Token = "0x600042A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600042B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600042D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2ACE0", Offset = "0x1D2A0E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600042C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000429")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000061")]
	private sealed class <SetupRuins>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000357")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000358")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000359")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400035A")]
		public Dictionary<String, Int32> _ruinNames; //Field offset: 0x28

		[Token(Token = "0x170000C6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000431")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000C7")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000433")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600042E")]
		public <SetupRuins>d__22(int <>1__state) { }

		[Address(RVA = "0x1D2AD20", Offset = "0x1D2A120", Length = "0x346")]
		[Token(Token = "0x6000430")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000431")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000433")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2B070", Offset = "0x1D2A470", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000432")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600042F")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000062")]
	private sealed class <ShowErrorMessage>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400035B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400035C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400035D")]
		public InGameManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000C8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000437")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000C9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000439")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000434")]
		public <ShowErrorMessage>d__11(int <>1__state) { }

		[Address(RVA = "0x1D2B910", Offset = "0x1D2AD10", Length = "0x272")]
		[Token(Token = "0x6000436")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000437")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000439")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2BB90", Offset = "0x1D2AF90", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000438")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000435")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000063")]
	private sealed class <StartStage>d__504 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400035E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400035F")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000360")]
		public InGameManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000361")]
		public Phase tphase; //Field offset: 0x28

		[Token(Token = "0x170000CA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600043D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000CB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600043F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600043A")]
		public <StartStage>d__504(int <>1__state) { }

		[Address(RVA = "0x1D2BBD0", Offset = "0x1D2AFD0", Length = "0x3D4")]
		[Token(Token = "0x600043C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600043D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600043F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2BFC0", Offset = "0x1D2B3C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600043E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600043B")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000064")]
	private sealed class <WaitSubManabgersEnd>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000362")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000363")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000364")]
		public InGameManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000CC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000443")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000CD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000445")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000440")]
		public <WaitSubManabgersEnd>d__6(int <>1__state) { }

		[Address(RVA = "0x1D2C110", Offset = "0x1D2B510", Length = "0x5F")]
		[Token(Token = "0x6000442")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000443")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000445")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2C170", Offset = "0x1D2B570", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000444")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000441")]
		private override void System.IDisposable.Dispose() { }

	}

	[Flags]
	[Token(Token = "0x2000048")]
	private enum ArmDropFlag : int
	{
		None = 0,
		Black = 1,
		Gold = 2,
	}

	[Flags]
	[Token(Token = "0x200004A")]
	private enum HitDirFlag : int
	{
		None = 0,
		LHIT = 1,
		RHIT = 2,
		UHIT = 4,
		DHIT = 8,
	}

	[Token(Token = "0x2000049")]
	private struct JemQue
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D2")]
		private Vector3 epos; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40002D3")]
		private float tlen; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002D4")]
		private int tnum; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40002D5")]
		private int tpno; //Field offset: 0x14

		[Token(Token = "0x170000A4")]
		public float Len
		{
			[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
			[Token(Token = "0x60003BF")]
			 get { } //Length: 6
		}

		[Token(Token = "0x170000A2")]
		public int Num
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x60003BD")]
			 get { } //Length: 85
		}

		[Token(Token = "0x170000A3")]
		public int Pno
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[Token(Token = "0x60003BE")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170000A5")]
		public Vector3 Pos
		{
			[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
			[Token(Token = "0x60003C0")]
			 get { } //Length: 18
		}

		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[Token(Token = "0x60003BF")]
		public float get_Len() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60003BD")]
		public int get_Num() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x60003BE")]
		public int get_Pno() { }

		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[Token(Token = "0x60003C0")]
		public Vector3 get_Pos() { }

		[Address(RVA = "0x1D25610", Offset = "0x1D24A10", Length = "0x1F")]
		[Token(Token = "0x60003BC")]
		public void SetInfo(Vector3 pos, float len, int num, int pno) { }

	}

	[Token(Token = "0x200004B")]
	internal enum Phase : int
	{
		Initialize = 0,
		StartDemo = 1,
		PlayStart = 2,
		Playing = 3,
		Dead = 4,
		CheckRetry = 5,
		SetRetry = 6,
		GameOver = 7,
		StageClear = 8,
		StageExit = 9,
		Terminate = 10,
		DebugMode = 11,
	}

	[Token(Token = "0x4000227")]
	private static readonly Rect GMEnemySkipArea; //Field offset: 0x0
	[Token(Token = "0x4000288")]
	private const float _BottomClampOffset = 25; //Field offset: 0x0
	[Token(Token = "0x40002B5")]
	private const float DiPointMax = 1000; //Field offset: 0x0
	[Token(Token = "0x40002B6")]
	private const float DiPointMin = -1000; //Field offset: 0x0
	[Token(Token = "0x40002C3")]
	public const long DefaultHighScore = 100000; //Field offset: 0x0
	[Token(Token = "0x40002C6")]
	public const float BGSliderSkyRate = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000261")]
	public static readonly string TweenID; //Field offset: 0x10
	[Token(Token = "0x4000262")]
	private static readonly Rect gameScreenBulletArea; //Field offset: 0x18
	[Token(Token = "0x4000263")]
	private static readonly Rect gameScreenArea; //Field offset: 0x28
	[Token(Token = "0x4000264")]
	private static readonly Rect gameScreenAreaM; //Field offset: 0x38
	[Token(Token = "0x4000265")]
	private static readonly Rect gameScreenAreaL; //Field offset: 0x48
	[Token(Token = "0x4000266")]
	private static readonly Rect gameScreenAreaW; //Field offset: 0x58
	[Token(Token = "0x4000267")]
	private static readonly Rect[] gameScreenAreas; //Field offset: 0x68
	[Token(Token = "0x4000276")]
	private static readonly float _cameraTall; //Field offset: 0x70
	[Token(Token = "0x4000277")]
	private static readonly Vector3 _cameraPosition; //Field offset: 0x74
	[Token(Token = "0x4000278")]
	private static readonly Quaternion _cameraRotate; //Field offset: 0x80
	[Token(Token = "0x4000279")]
	private static readonly Quaternion _groundCameraRotate; //Field offset: 0x90
	[Token(Token = "0x4000281")]
	private static readonly String[] _itemCarryMoveName; //Field offset: 0xA0
	[Token(Token = "0x4000282")]
	public static readonly string itemCarryName; //Field offset: 0xA8
	[Token(Token = "0x4000283")]
	private static readonly String[] _itemCarryDrop; //Field offset: 0xB0
	[Token(Token = "0x4000284")]
	private static readonly int Sc5000cd; //Field offset: 0xB8
	[Token(Token = "0x4000285")]
	public static readonly int Sc1000cd; //Field offset: 0xBC
	[Token(Token = "0x4000286")]
	private static readonly int ScRushBcd; //Field offset: 0xC0
	[Token(Token = "0x4000287")]
	private static readonly int ItemGetCode; //Field offset: 0xC4
	[Token(Token = "0x4000289")]
	private static float _dropItemSpeed; //Field offset: 0xC8
	[Token(Token = "0x4000294")]
	private static readonly int JemQueMax; //Field offset: 0xCC
	[Token(Token = "0x400029C")]
	public static int PlayerMax; //Field offset: 0xD0
	[Token(Token = "0x400029D")]
	public static readonly Vector3 SinglePlayStartPosition; //Field offset: 0xD4
	[Token(Token = "0x400029E")]
	public static readonly Vector3 TeamPlayStartPosition1; //Field offset: 0xE0
	[Token(Token = "0x400029F")]
	public static readonly Vector3 TeamPlayStartPosition2; //Field offset: 0xEC
	[Token(Token = "0x40002A0")]
	public static readonly Vector3 Player2Height; //Field offset: 0xF8
	[Token(Token = "0x40002A1")]
	public static readonly Vector3 PlayerOutsideOffset; //Field offset: 0x104
	[Token(Token = "0x40002A2")]
	public static readonly Vector3 PlayerExitOffset; //Field offset: 0x110
	[Token(Token = "0x40002A3")]
	public static readonly Vector3 PlayerTargetOffset; //Field offset: 0x11C
	[Token(Token = "0x40002A4")]
	public static readonly Vector3 PlayerHomingOffset; //Field offset: 0x128
	[Token(Token = "0x40002A5")]
	public static readonly float PlayerControllWidth; //Field offset: 0x134
	[Token(Token = "0x40002A6")]
	public static readonly float PlayerControllWidthRange; //Field offset: 0x138
	[Token(Token = "0x40002A7")]
	public static readonly float PlayerControllHeightM; //Field offset: 0x13C
	[Token(Token = "0x40002A8")]
	public static readonly float PlayerControllHeightP; //Field offset: 0x140
	[Token(Token = "0x40002A9")]
	public static readonly float PlayerControllHeight; //Field offset: 0x144
	[Token(Token = "0x40002AA")]
	public static readonly Vector3 PlayerControllMin; //Field offset: 0x148
	[Token(Token = "0x40002AB")]
	public static readonly Vector3 PlayerControllMax; //Field offset: 0x154
	[Token(Token = "0x40002B1")]
	private static readonly Rect BulletArea_Tutorial; //Field offset: 0x160
	[Token(Token = "0x40002B2")]
	private static readonly Rect BulletArea_Story; //Field offset: 0x170
	[Token(Token = "0x40002B3")]
	private static readonly Rect BulletArea_Arcade; //Field offset: 0x180
	[Token(Token = "0x40002B4")]
	private static readonly Rect BulletArea_Arcade2; //Field offset: 0x190
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000228")]
	private TimeFactor _baseTimeFactor; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000229")]
	private TimeFactor _playTimeFactor; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400022A")]
	private TimeFactor _effectTimeFactor; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400022B")]
	private float _lapedDeltaTime; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400022C")]
	private float _effectedTime; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400022D")]
	private float _bgSlideRate; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400022E")]
	private bool _isPause; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400022F")]
	private int _pauseReqPadNo; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000230")]
	private bool _withPauseMenu; //Field offset: 0x4C
	[FieldOffset(Offset = "0x4D")]
	[Token(Token = "0x4000231")]
	private bool _isPauseReq; //Field offset: 0x4D
	[FieldOffset(Offset = "0x4E")]
	[Token(Token = "0x4000232")]
	private bool _isPauseExitReq; //Field offset: 0x4E
	[FieldOffset(Offset = "0x4F")]
	[Token(Token = "0x4000233")]
	private bool _isStartStage; //Field offset: 0x4F
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000234")]
	private bool _isStopStage; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x4000235")]
	private bool _isEndReturn; //Field offset: 0x51
	[FieldOffset(Offset = "0x52")]
	[Token(Token = "0x4000236")]
	private bool _isTrainingMode; //Field offset: 0x52
	[FieldOffset(Offset = "0x53")]
	[Token(Token = "0x4000237")]
	private bool _isRushMode; //Field offset: 0x53
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000238")]
	private bool _isQuitDone; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x4000239")]
	private bool _isGameOver; //Field offset: 0x55
	[FieldOffset(Offset = "0x56")]
	[Token(Token = "0x400023A")]
	private bool _isCompleteStage; //Field offset: 0x56
	[FieldOffset(Offset = "0x57")]
	[Token(Token = "0x400023B")]
	private bool _isNextStage; //Field offset: 0x57
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400023C")]
	private bool _isManualQuit; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x400023D")]
	private bool _isStartOverStart; //Field offset: 0x59
	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x400023E")]
	private bool _isStartOverQuit; //Field offset: 0x5A
	[FieldOffset(Offset = "0x5B")]
	[Token(Token = "0x400023F")]
	private bool _isScoreDisplay; //Field offset: 0x5B
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000240")]
	private bool _isQuiting; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000241")]
	private float _damageMag; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000242")]
	private float _eventRepeatScale; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000243")]
	private float _bulletDistanceMax; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000244")]
	private int _playerCountMax; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000245")]
	private PlayableDirector _stageTimeline; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000246")]
	private PlayStage _stageOrder; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000247")]
	private Transform _systemRoot; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000248")]
	private Transform _inGameRoot; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000249")]
	private GameObject _inGameEnemyRootObject; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400024A")]
	private Transform _inGameEnemyRoot; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400024B")]
	private GameObject _inGameGroundSkyObject; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400024C")]
	private Transform _inGameGroundSky; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400024D")]
	private GameObject _poolObject; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400024E")]
	private Transform _poolRoot; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400024F")]
	private Transform _collisionArea; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000250")]
	private PauseWindowMenu _pauseLabel; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000251")]
	private ViewGameover _gameoverLabel; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000252")]
	private ViewTimeup _timeupLabel; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000253")]
	private InGamePlayerManager _playerManager; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000254")]
	private InGameEnemyManager _enemyManager; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000255")]
	private InGameBulletManager _bulletManager; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000256")]
	private InGameParticleSystemManager _particleManager; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000257")]
	private InGameAnimationManager _animationManager; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000258")]
	private InGameEffectManager _effectManager; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000259")]
	private InGameAreaManager _areaManager; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400025A")]
	private InGameStageManager _stageManager; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400025B")]
	private InGameRouteManager _routeManager; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400025C")]
	private InGameRuinManager _ruinManager; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400025D")]
	private HybridCollisionManager _collisionManager; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400025E")]
	private InGameEnemyClipsManager _enemyClipsManager; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400025F")]
	private InGameBonusManager _bonusManager; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000260")]
	private PhysicsUpdater _physicsUpdater; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000268")]
	private PlayerControll[] _playerControll; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000269")]
	private Transform[] _playerTransform; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400026A")]
	private Vector3[] _playerSkyPosition; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400026B")]
	private Vector3[] _playerBulletPosition; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400026C")]
	private Vector3[] _playerGamePosition; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x400026D")]
	private Vector3[] _playerEnemyRootPos; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x400026E")]
	private Vector2[] _playerScreenPosition; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x400026F")]
	private InGameCollisionBase[] _playersBody; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000270")]
	private Dictionary<String, Int32> _enemyDestroyedBackup; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000271")]
	private List<String> _errorMessages; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000272")]
	private Action _pauseAction; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000273")]
	private PositionShiftMan _positionShiftObject; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000274")]
	private CancellationToken _destroyedToken; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000275")]
	private CancellationTokenSource _stageToken; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400027A")]
	private CanvasGroup _displayMessageCanvas; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x400027B")]
	private UITextMeshPro _displayMessage; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x400027C")]
	private UIBossGauge _bossGauge; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400027D")]
	private InGameViewUI _UIView; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x400027E")]
	private int _bossBonusTime0; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x400027F")]
	private int _bossBonusTime1; //Field offset: 0x1E4
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000280")]
	private int _bossBonusTime2; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x400028A")]
	private List<PawnEnemy> _strongestEnemys; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x400028B")]
	private List<PawnEnemy> _highEnemys; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400028C")]
	private HashSet<Int32> _dropGroundItems; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400028D")]
	private int _strongestCount; //Field offset: 0x208
	[FieldOffset(Offset = "0x20C")]
	[Token(Token = "0x400028E")]
	private int _strongestIndex; //Field offset: 0x20C
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400028F")]
	private int _highenemyCount; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[Token(Token = "0x4000290")]
	private int _highenemyIndex; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000291")]
	private ItemReferenceTable _itemTable; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000292")]
	private int _itemTableCount; //Field offset: 0x220
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000293")]
	private ArmDropFlag _armDrop; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000295")]
	private int _jemBornCount; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000296")]
	private JemQue[] _jemques; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000297")]
	private HashSet<InGameBulletItem> _dropJems; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000298")]
	private HashSet<InGameBulletItem> _finishJems; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000299")]
	private HashSet<InGameBulletItem> _bornJems; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x400029A")]
	private InGameJemManager _jemMan; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400029B")]
	private bool _isObstacleStay; //Field offset: 0x258
	[FieldOffset(Offset = "0x25C")]
	[Readonly]
	[SerializeField]
	[Token(Token = "0x40002AC")]
	private Phase _playPhase; //Field offset: 0x25C
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40002AD")]
	private Coroutine _calledCoroutine; //Field offset: 0x260
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40002AE")]
	private bool _isNoDeadCount; //Field offset: 0x268
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x40002AF")]
	private Rect gameBulletArea; //Field offset: 0x26C
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x40002B0")]
	private Rect gameLaserArea; //Field offset: 0x27C
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40002B7")]
	private GameAddPoints _gameAddPoints; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40002B8")]
	private float _DiPoint; //Field offset: 0x298
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x40002B9")]
	private float _perSeconds; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40002BA")]
	private float _perDestroy; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A4")]
	[Token(Token = "0x40002BB")]
	private float _perBomber; //Field offset: 0x2A4
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x40002BC")]
	private float _perBStock; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2AC")]
	[Token(Token = "0x40002BD")]
	private float _perPowup; //Field offset: 0x2AC
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x40002BE")]
	private float _perBoss; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B4")]
	[Token(Token = "0x40002BF")]
	private float _perDead; //Field offset: 0x2B4
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x40002C0")]
	private float _DiMin; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2BC")]
	[Token(Token = "0x40002C1")]
	private float _DiMax; //Field offset: 0x2BC
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x40002C2")]
	private ExtendScores _extendScores; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x40002C4")]
	private PlayerInformation[] _playerinfo; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x40002C5")]
	private PlayerCommonData _playerCommonData; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x40002C7")]
	protected UnityEvent<InGameManager> _onNormalUpdateEvent; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x40002C8")]
	protected UnityEvent _onLowUpdateEvent; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x40002C9")]
	protected UnityEvent _onReStartEvent; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x40002CA")]
	private Vector3 _cinemachineBGCameraSlide; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2FC")]
	[Token(Token = "0x40002CB")]
	private float _collisionUpdateTiming; //Field offset: 0x2FC
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x40002CC")]
	private bool _isUpdateDisable; //Field offset: 0x300
	[FieldOffset(Offset = "0x304")]
	[Token(Token = "0x40002CD")]
	private TLClipFlag _tlClipFlag; //Field offset: 0x304

	[Token(Token = "0x1700007E")]
	public InGameAnimationManager AnimatorManager
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x60002E4")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000080")]
	public InGameAreaManager AreaManager
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[Token(Token = "0x60002E6")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700006E")]
	public float BaseDeltaTime
	{
		[Address(RVA = "0x1CF27E0", Offset = "0x1CF1BE0", Length = "0x1C")]
		[Token(Token = "0x60002D4")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700006D")]
	public float BaseTimeFactor
	{
		[Address(RVA = "0x1CF2800", Offset = "0x1CF1C00", Length = "0x1C")]
		[Token(Token = "0x60002D3")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000086")]
	public InGameBonusManager BonusManager
	{
		[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
		[Token(Token = "0x60002EC")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700008D")]
	public UIBossGauge BossGauge
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[Token(Token = "0x600031A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700007C")]
	public InGameBulletManager BulletManager
	{
		[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
		[Token(Token = "0x60002E2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000087")]
	public static Vector3 CameraBasePosition
	{
		[Address(RVA = "0x1CF2840", Offset = "0x1CF1C40", Length = "0x63")]
		[Token(Token = "0x60002F7")]
		 get { } //Length: 99
	}

	[Token(Token = "0x17000088")]
	public static Quaternion CameraBaseRotate
	{
		[Address(RVA = "0x1CF28B0", Offset = "0x1CF1CB0", Length = "0x5E")]
		[Token(Token = "0x60002F8")]
		 get { } //Length: 94
	}

	[Token(Token = "0x1700008A")]
	public static float CameraTall
	{
		[Address(RVA = "0x1CF2910", Offset = "0x1CF1D10", Length = "0x50")]
		[Token(Token = "0x60002FA")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000085")]
	public InGameEnemyClipsManager ClipsManager
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[Token(Token = "0x60002EB")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000084")]
	public HybridCollisionManager CollisionManager
	{
		[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
		[Token(Token = "0x60002EA")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000070")]
	public float DeltaTime
	{
		[Address(RVA = "0x1CF2980", Offset = "0x1CF1D80", Length = "0x1C")]
		[Token(Token = "0x60002D6")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170000A1")]
	public string DiPointStr
	{
		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x600038B")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000074")]
	public float EffectDeltaTime
	{
		[Address(RVA = "0x1CF29A0", Offset = "0x1CF1DA0", Length = "0x1C")]
		[Token(Token = "0x60002DA")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700007F")]
	public InGameEffectManager EffectManager
	{
		[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
		[Token(Token = "0x60002E5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000073")]
	public float EffectTimeFactor
	{
		[Address(RVA = "0x1CF29C0", Offset = "0x1CF1DC0", Length = "0x1C")]
		[Token(Token = "0x60002D9")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700007B")]
	public InGameEnemyManager EnemyManager
	{
		[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
		[Token(Token = "0x60002E1")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000071")]
	public float EventRepeatScale
	{
		[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
		[Token(Token = "0x60002D7")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000076")]
	public Transform GameRoot
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x60002DC")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000A0")]
	public float GetDiPoint
	{
		[Address(RVA = "0x1CF29F0", Offset = "0x1CF1DF0", Length = "0x9")]
		[Token(Token = "0x600038A")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000089")]
	public static Quaternion GroundCameraBaseRotate
	{
		[Address(RVA = "0x1CF2A00", Offset = "0x1CF1E00", Length = "0x5E")]
		[Token(Token = "0x60002F9")]
		 get { } //Length: 94
	}

	[Token(Token = "0x17000077")]
	public Transform InGameEnemyRoot
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x60002DD")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000078")]
	public Transform InGameGroundSky
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x60002DE")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000062")]
	public bool IsBaseGameStop
	{
		[Address(RVA = "0x1CF2AA0", Offset = "0x1CF1EA0", Length = "0x25")]
		[Token(Token = "0x60002C5")]
		 get { } //Length: 37
	}

	[Token(Token = "0x17000093")]
	public bool IsBGSlideMode
	{
		[Address(RVA = "0x1CF2A70", Offset = "0x1CF1E70", Length = "0x29")]
		[Token(Token = "0x600036A")]
		 get { } //Length: 41
	}

	[Token(Token = "0x17000068")]
	public bool IsCompleteStage
	{
		[Address(RVA = "0x1CF2AD0", Offset = "0x1CF1ED0", Length = "0x5")]
		[Token(Token = "0x60002CE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000094")]
	public bool IsDeadingPhase
	{
		[Address(RVA = "0x1CF2AE0", Offset = "0x1CF1EE0", Length = "0xB")]
		[Token(Token = "0x600036B")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000097")]
	public bool IsEndingPhase
	{
		[Address(RVA = "0x1CF2B00", Offset = "0x1CF1F00", Length = "0x29")]
		[Token(Token = "0x600036E")]
		 get { } //Length: 41
	}

	[Token(Token = "0x17000064")]
	public bool IsEndReturn
	{
		[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
		[Token(Token = "0x60002CA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000099")]
	public bool IsEnemyBulletPhase
	{
		[Address(RVA = "0x1CF2B30", Offset = "0x1CF1F30", Length = "0x50")]
		[Token(Token = "0x6000370")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000098")]
	public bool IsEnemyCallPhase
	{
		[Address(RVA = "0x1CF2B80", Offset = "0x1CF1F80", Length = "0x3E")]
		[Token(Token = "0x600036F")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000090")]
	public bool IsFirstPlayPhase
	{
		[Address(RVA = "0x1CF2BC0", Offset = "0x1CF1FC0", Length = "0x17")]
		[Token(Token = "0x6000367")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000091")]
	public bool IsFirstTimePhase
	{
		[Address(RVA = "0x1CF2BE0", Offset = "0x1CF1FE0", Length = "0xB")]
		[Token(Token = "0x6000368")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000067")]
	public bool IsGameOver
	{
		[Address(RVA = "0x1CF2BF0", Offset = "0x1CF1FF0", Length = "0x5")]
		[Token(Token = "0x60002CD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000063")]
	public bool IsGameStop
	{
		[Address(RVA = "0x1CF2C00", Offset = "0x1CF2000", Length = "0x25")]
		[Token(Token = "0x60002C9")]
		 get { } //Length: 37
	}

	[Token(Token = "0x1700006A")]
	public bool IsManualQuit
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[Token(Token = "0x60002D0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000069")]
	public bool IsNextStage
	{
		[Address(RVA = "0x1CF2C40", Offset = "0x1CF2040", Length = "0x5")]
		[Token(Token = "0x60002CF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700009F")]
	public bool IsNoDeadCount
	{
		[Address(RVA = "0x1CF2C50", Offset = "0x1CF2050", Length = "0x8")]
		[Token(Token = "0x600037B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700009C")]
	public bool IsNoScorePhase
	{
		[Address(RVA = "0x1CF2C60", Offset = "0x1CF2060", Length = "0x32")]
		[Token(Token = "0x6000373")]
		 get { } //Length: 50
	}

	[Token(Token = "0x1700009B")]
	public bool IsNotReadyPhase
	{
		[Address(RVA = "0x1CF2CA0", Offset = "0x1CF20A0", Length = "0x20")]
		[Token(Token = "0x6000372")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000060")]
	public bool IsPause
	{
		[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
		[Token(Token = "0x60002C3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000061")]
	public bool IsPauseMenuOpen
	{
		[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
		[Token(Token = "0x60002C4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000095")]
	public bool IsPauseNGPhase
	{
		[Address(RVA = "0x1CF2CD0", Offset = "0x1CF20D0", Length = "0x17")]
		[Token(Token = "0x600036C")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700009A")]
	public bool IsPlayerMarkDisplay
	{
		[Address(RVA = "0x1CF2D00", Offset = "0x1CF2100", Length = "0x1A")]
		[Token(Token = "0x6000371")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000092")]
	public bool IsPlayerMoving
	{
		[Address(RVA = "0x1CF2D20", Offset = "0x1CF2120", Length = "0x17")]
		[Token(Token = "0x6000369")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700009E")]
	public bool IsPlayerShooting
	{
		[Address(RVA = "0x1CF2D40", Offset = "0x1CF2140", Length = "0x17")]
		[Token(Token = "0x6000375")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000096")]
	public bool IsPlayingInGame
	{
		[Address(RVA = "0x1CF2D60", Offset = "0x1CF2160", Length = "0x20")]
		[Token(Token = "0x600036D")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700009D")]
	public bool IsPlayingProcess
	{
		[Address(RVA = "0x1CF2D80", Offset = "0x1CF2180", Length = "0x45")]
		[Token(Token = "0x6000374")]
		 get { } //Length: 69
	}

	[Token(Token = "0x17000066")]
	public bool IsQuitDone
	{
		[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
		[Token(Token = "0x60002CC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006C")]
	public bool IsScoreDisplay
	{
		[Address(RVA = "0x1CF2DE0", Offset = "0x1CF21E0", Length = "0x11")]
		[Token(Token = "0x60002D2")]
		 get { } //Length: 17
	}

	[Token(Token = "0x1700008B")]
	public bool IsStageDebugMode
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600030C")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700006B")]
	public bool IsStartOver
	{
		[Address(RVA = "0x1CF2E00", Offset = "0x1CF2200", Length = "0x5")]
		[Token(Token = "0x60002D1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700008C")]
	public bool IsTimelineDebugMode
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600030D")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000065")]
	public bool IsTrainingMode
	{
		[Address(RVA = "0x1CF2E10", Offset = "0x1CF2210", Length = "0x5")]
		[Token(Token = "0x60002CB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005F")]
	public float LapedDeltaTime
	{
		[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
		[Token(Token = "0x60002C2")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700007D")]
	public InGameParticleSystemManager ParticleManager
	{
		[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
		[Token(Token = "0x60002E3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000072")]
	public int PlayerCount
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[Token(Token = "0x60002D8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700007A")]
	public InGamePlayerManager PlayerManager
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[Token(Token = "0x60002E0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700008F")]
	public Phase PlayPhase
	{
		[Address(RVA = "0x1CF2E30", Offset = "0x1CF2230", Length = "0x7")]
		[Token(Token = "0x6000366")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700006F")]
	public float PlayTimeFactor
	{
		[Address(RVA = "0x1CF2E40", Offset = "0x1CF2240", Length = "0x1C")]
		[Token(Token = "0x60002D5")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000079")]
	public Transform PoolRoot
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[Token(Token = "0x60002DF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700005E")]
	public TimeFactor PTimeFactor
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60002C1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000082")]
	public InGameRouteManager RouteManager
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[Token(Token = "0x60002E8")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000083")]
	public InGameRuinManager RuinManager
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[Token(Token = "0x60002E9")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000081")]
	public InGameStageManager StageManager
	{
		[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
		[Token(Token = "0x60002E7")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700008E")]
	public int StrongestCount
	{
		[Address(RVA = "0x1CF2EB0", Offset = "0x1CF22B0", Length = "0x7")]
		[Token(Token = "0x6000338")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000075")]
	public Transform SystemRoot
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x60002DB")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1CF0D80", Offset = "0x1CF0180", Length = "0x32A")]
	[Token(Token = "0x600039A")]
	private void _checkPauseState() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000305")]
	protected bool _DebugCheckTimeline(PlayableDirector tl, int stackCount = 0) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000306")]
	private void _debugDisplay() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000307")]
	private void _debugFunctions() { }

	[Address(RVA = "0x1CF1530", Offset = "0x1CF0930", Length = "0x63")]
	[Token(Token = "0x60002C0")]
	private void _errorClear() { }

	[Address(RVA = "0x1CF15A0", Offset = "0x1CF09A0", Length = "0x6D")]
	[IteratorStateMachine(typeof(<_gameForceQuitPhase>d__417))]
	[Token(Token = "0x6000365")]
	private IEnumerator _gameForceQuitPhase() { }

	[Address(RVA = "0x1CF1610", Offset = "0x1CF0A10", Length = "0x6D")]
	[IteratorStateMachine(typeof(<_gameOver>d__416))]
	[Token(Token = "0x6000364")]
	private IEnumerator _gameOver() { }

	[Address(RVA = "0x1CF1680", Offset = "0x1CF0A80", Length = "0x188")]
	[Token(Token = "0x600039E")]
	private float _getSlideRate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002FB")]
	private void _InitializeDebug() { }

	[Address(RVA = "0x1CEEB70", Offset = "0x1CEDF70", Length = "0x19C")]
	[Token(Token = "0x60003AA")]
	protected void _InitializeEvent() { }

	[Address(RVA = "0x1CF1810", Offset = "0x1CF0C10", Length = "0x48")]
	[Token(Token = "0x6000339")]
	private void _initializeItemTable(ItemReferenceTable itemTable) { }

	[Address(RVA = "0x1CEED10", Offset = "0x1CEE110", Length = "0x561")]
	[Token(Token = "0x6000348")]
	protected void _InitializeParameters() { }

	[Address(RVA = "0x1CF1860", Offset = "0x1CF0C60", Length = "0xDB")]
	[Token(Token = "0x60003A2")]
	private bool _isPlayerAutopilot() { }

	[Address(RVA = "0x1CEF280", Offset = "0x1CEE680", Length = "0x208")]
	[Token(Token = "0x600033F")]
	public void _JemsComplete() { }

	[Address(RVA = "0x1CF1940", Offset = "0x1CF0D40", Length = "0x2EA")]
	[Token(Token = "0x6000361")]
	private void _outPlayer() { }

	[Address(RVA = "0x1CF1C30", Offset = "0x1CF1030", Length = "0x6D")]
	[IteratorStateMachine(typeof(<_playerDeadPhase>d__410))]
	[Token(Token = "0x600035E")]
	private IEnumerator _playerDeadPhase() { }

	[Address(RVA = "0x1CF2030", Offset = "0x1CF1430", Length = "0x2CE")]
	[Token(Token = "0x600039C")]
	private void _progressStageTime(float dt) { }

	[Address(RVA = "0x1CF1CA0", Offset = "0x1CF10A0", Length = "0x388")]
	[Token(Token = "0x600039D")]
	private void _progressStageTimeResult() { }

	[Address(RVA = "0x1CF2300", Offset = "0x1CF1700", Length = "0x6D")]
	[IteratorStateMachine(typeof(<_restartGameFast>d__415))]
	[Token(Token = "0x6000363")]
	private IEnumerator _restartGameFast() { }

	[Address(RVA = "0x1CF2370", Offset = "0x1CF1770", Length = "0xDE")]
	[Token(Token = "0x6000358")]
	private void _setPlayerAttribute(PFlag tflag, bool isSet) { }

	[Address(RVA = "0x1CF2450", Offset = "0x1CF1850", Length = "0x1B0")]
	[Token(Token = "0x6000359")]
	private void _setPlayerControll(bool isSet, PFlag tflag) { }

	[Address(RVA = "0x1CF2610", Offset = "0x1CF1A10", Length = "0x6D")]
	[IteratorStateMachine(typeof(<_stageClearPhase>d__406))]
	[Token(Token = "0x600035A")]
	private IEnumerator _stageClearPhase() { }

	[Address(RVA = "0x1CF2680", Offset = "0x1CF1A80", Length = "0x46")]
	[Token(Token = "0x6000357")]
	private void _stopPhaseCoroutine() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002FC")]
	private void _TerminateDebug() { }

	[Address(RVA = "0x1CEF490", Offset = "0x1CEE890", Length = "0x154")]
	[Token(Token = "0x60003AB")]
	protected void _TerminateEvent() { }

	[Address(RVA = "0x1CEF5F0", Offset = "0x1CEE9F0", Length = "0x6D")]
	[IteratorStateMachine(typeof(<_TimeoverPhase>d__409))]
	[Token(Token = "0x600035D")]
	private IEnumerator _TimeoverPhase() { }

	[Address(RVA = "0x1CEF660", Offset = "0x1CEEA60", Length = "0x6D")]
	[IteratorStateMachine(typeof(<_TimeupPhase>d__411))]
	[Token(Token = "0x600035F")]
	private IEnumerator _TimeupPhase() { }

	[Address(RVA = "0x1CEF6D0", Offset = "0x1CEEAD0", Length = "0x6D")]
	[IteratorStateMachine(typeof(<_TrainingClearPhase>d__408))]
	[Token(Token = "0x600035C")]
	private IEnumerator _TrainingClearPhase(bool isClearPhase) { }

	[Address(RVA = "0x1CF26D0", Offset = "0x1CF1AD0", Length = "0xEE")]
	[Token(Token = "0x600039B")]
	private void _updateDeltaTime(float realDeltaTime) { }

	[Address(RVA = "0x1CEF740", Offset = "0x1CEEB40", Length = "0xCF")]
	[Token(Token = "0x600032F")]
	private void _UpdateEnemyManager() { }

	[Address(RVA = "0x1CEF810", Offset = "0x1CEEC10", Length = "0x843")]
	[Token(Token = "0x600033E")]
	private void _UpdateJems(float dt) { }

	[Address(RVA = "0x1CF0060", Offset = "0x1CEF460", Length = "0x156")]
	[Token(Token = "0x6000346")]
	public void _UpdateObstacle() { }

	[Address(RVA = "0x1CF01C0", Offset = "0x1CEF5C0", Length = "0x259")]
	[Token(Token = "0x6000349")]
	private void _UpdateParameters() { }

	[Address(RVA = "0x1CF0420", Offset = "0x1CEF820", Length = "0xB2")]
	[Token(Token = "0x60003A9")]
	private void _UpdatePositionShift() { }

	[Address(RVA = "0x1CF04E0", Offset = "0x1CEF8E0", Length = "0x89E")]
	[Token(Token = "0x60003B8")]
	private static InGameManager() { }

	[Address(RVA = "0x1CF10B0", Offset = "0x1CF04B0", Length = "0x475")]
	[Token(Token = "0x60003B7")]
	public InGameManager() { }

	[Address(RVA = "0x1CED270", Offset = "0x1CEC670", Length = "0xA1")]
	[CompilerGenerated]
	[Token(Token = "0x60003BB")]
	private void <_checkPauseState>b__516_0() { }

	[Address(RVA = "0x1CED320", Offset = "0x1CEC720", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60003BA")]
	private void <_gameOver>b__416_0() { }

	[Address(RVA = "0x1CED250", Offset = "0x1CEC650", Length = "0x12")]
	[CompilerGenerated]
	[Token(Token = "0x60003B9")]
	private bool <RestartGame>b__414_0() { }

	[Address(RVA = "0x1CE2070", Offset = "0x1CE1470", Length = "0x54")]
	[Token(Token = "0x6000333")]
	public void AddAlreadyHash(int thash) { }

	[Address(RVA = "0x1CE22D0", Offset = "0x1CE16D0", Length = "0x34")]
	[Token(Token = "0x6000389")]
	private void AddDiPoint(float tpoint) { }

	[Address(RVA = "0x1CE20D0", Offset = "0x1CE14D0", Length = "0x3C")]
	[Token(Token = "0x6000380")]
	public void AddDiPoint_BomberStock() { }

	[Address(RVA = "0x1CE2110", Offset = "0x1CE1510", Length = "0x3C")]
	[Token(Token = "0x600037F")]
	public void AddDiPoint_BomberUse() { }

	[Address(RVA = "0x1CE2150", Offset = "0x1CE1550", Length = "0x3C")]
	[Token(Token = "0x6000381")]
	public void AddDiPoint_BossDestroy() { }

	[Address(RVA = "0x1CE2190", Offset = "0x1CE1590", Length = "0x73")]
	[Token(Token = "0x6000386")]
	private void AddDiPoint_EnemyDestroy() { }

	[Address(RVA = "0x1CE2210", Offset = "0x1CE1610", Length = "0x3C")]
	[Token(Token = "0x6000387")]
	private void AddDiPoint_PlayerDead() { }

	[Address(RVA = "0x1CE2250", Offset = "0x1CE1650", Length = "0x3C")]
	[Token(Token = "0x600037E")]
	public void AddDiPoint_Powerup() { }

	[Address(RVA = "0x1CE2290", Offset = "0x1CE1690", Length = "0x3C")]
	[Token(Token = "0x6000388")]
	private void AddDiPoint_Timepass(float dt) { }

	[Address(RVA = "0x1CE2310", Offset = "0x1CE1710", Length = "0xBF")]
	[Token(Token = "0x6000289")]
	public void AddErrorMessage(string msg, TXEErrors errorCode = -1) { }

	[Address(RVA = "0x1CE23D0", Offset = "0x1CE17D0", Length = "0x21")]
	[Token(Token = "0x60003AF")]
	public void AddOnLowEvent(UnityAction f) { }

	[Address(RVA = "0x1CE2400", Offset = "0x1CE1800", Length = "0x56")]
	[Token(Token = "0x60003AD")]
	public void AddOnNormalEvent(UnityAction<InGameManager> f) { }

	[Address(RVA = "0x1CE2460", Offset = "0x1CE1860", Length = "0x68")]
	[Token(Token = "0x60002B9")]
	public bool AddPhysicsObject(IPhysicsUpdater physicsObject, Transform objectTransform) { }

	[Address(RVA = "0x1CE24D0", Offset = "0x1CE18D0", Length = "0x21")]
	[Token(Token = "0x60003B1")]
	public void AddRestartEvent(UnityAction f) { }

	[Address(RVA = "0x1CE2500", Offset = "0x1CE1900", Length = "0x47")]
	[Token(Token = "0x600038C")]
	public void AddScore(long nsc, bool isP1 = true) { }

	[Address(RVA = "0x1CE2550", Offset = "0x1CE1950", Length = "0xA1")]
	[Token(Token = "0x60002BF")]
	private void BackupDestoryed() { }

	[Address(RVA = "0x1CE2A50", Offset = "0x1CE1E50", Length = "0x123")]
	[Token(Token = "0x600031F")]
	public void BulletFire(BulletTemplate bt, Vector3 startLocalPosition, int nlap, float startArc, float rate, InGameEnemyMoveBase emitModel, Transform emitSelf, Transform emitDir, Action<InGameBulletInterface> callback = null, float seVol = 1) { }

	[Address(RVA = "0x1CE2600", Offset = "0x1CE1A00", Length = "0x11E")]
	[AsyncStateMachine(typeof(<BulletFireAsync>d__303))]
	[Token(Token = "0x6000322")]
	public UniTaskVoid BulletFireAsync(BulletTemplate bt, Vector3 cpos, Transform cpost = null, CancellationTokenSource ctoken = null, Action<InGameBulletInterface> generateCallback = null, float sevol = 1) { }

	[Address(RVA = "0x1CE2720", Offset = "0x1CE1B20", Length = "0x164")]
	[Token(Token = "0x6000321")]
	public void BulletFireForget(BulletTemplate bt, Transform cpost, CancellationTokenSource ctoken, float sevol = 1) { }

	[Address(RVA = "0x1CE2890", Offset = "0x1CE1C90", Length = "0x1BD")]
	[Token(Token = "0x6000320")]
	public List<InGameBulletInterface> BulletFireToList(BulletTemplate bt, Vector3 startLocalPosition, int nlap, float startArc, float rate, InGameEnemyMoveBase emitModel, Transform emitSelf, Transform emitDir, Action<InGameBulletInterface> callback = null, float seVol = 1) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000308")]
	public void CheckError() { }

	[Address(RVA = "0x1CE2B80", Offset = "0x1CE1F80", Length = "0xB2")]
	[AsyncStateMachine(typeof(<CheckRushBouns>d__318))]
	[Token(Token = "0x600032A")]
	private UniTaskVoid CheckRushBouns(List<PawnEnemy> penemys, int tmul) { }

	[Address(RVA = "0x1CE2C40", Offset = "0x1CE2040", Length = "0x7F")]
	[IteratorStateMachine(typeof(<CleanupEnemyWait>d__407))]
	[Token(Token = "0x600035B")]
	private IEnumerator CleanupEnemyWait(float minSeconds) { }

	[Address(RVA = "0x1CE2CC0", Offset = "0x1CE20C0", Length = "0x8")]
	[Token(Token = "0x600030B")]
	public void ClearDebugFlag() { }

	[Address(RVA = "0x1CE2CD0", Offset = "0x1CE20D0", Length = "0x4A")]
	[Token(Token = "0x600037D")]
	public void ClearDiPointFactor() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000303")]
	public void ClearLog() { }

	[Address(RVA = "0x1CE2D20", Offset = "0x1CE2120", Length = "0x5A")]
	[Token(Token = "0x600034E")]
	public void ClearTLFlag() { }

	[Address(RVA = "0x1CE2D80", Offset = "0x1CE2180", Length = "0x200")]
	[Token(Token = "0x60003A8")]
	private void CollisionUpdateSolution(float dt) { }

	[Address(RVA = "0x1CE2F90", Offset = "0x1CE2390", Length = "0xB")]
	[Token(Token = "0x600038F")]
	public void CompleteStage() { }

	[Address(RVA = "0x1CE2FA0", Offset = "0x1CE23A0", Length = "0x2E")]
	[Token(Token = "0x600033B")]
	public Kind ConvertDropKind(Kind tkind) { }

	[Address(RVA = "0x1CE2FD0", Offset = "0x1CE23D0", Length = "0x1D7")]
	[Token(Token = "0x6000337")]
	public static ValueTuple<Int32, Int32, Int32> CountupLists(List<PawnEnemy> elists) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002FD")]
	public void Debug_RetryStage(bool withTl) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000304")]
	public string DebugString() { }

	[Address(RVA = "0x1CE3290", Offset = "0x1CE2690", Length = "0xD3")]
	[AsyncStateMachine(typeof(<DelaySecond>d__541))]
	[Token(Token = "0x60003B3")]
	public static UniTask DelaySecond(CancellationToken token, float tsec) { }

	[Address(RVA = "0x1CE31B0", Offset = "0x1CE25B0", Length = "0xD3")]
	[AsyncStateMachine(typeof(<DelaySecondReal>d__542))]
	[Token(Token = "0x60003B4")]
	public static UniTask DelaySecondReal(CancellationToken token, float tsec) { }

	[Address(RVA = "0x1CE3370", Offset = "0x1CE2770", Length = "0x150")]
	[Token(Token = "0x60002B5")]
	public void DeleteGameRoot() { }

	[Address(RVA = "0x1CE34C0", Offset = "0x1CE28C0", Length = "0x316")]
	[Token(Token = "0x600031E")]
	public void DirectBulletFire(BulletTemplate bt, Vector3 cpos) { }

	[Address(RVA = "0x1CE37E0", Offset = "0x1CE2BE0", Length = "0xEC")]
	[Token(Token = "0x60002B3")]
	public void DisplayTimeup() { }

	[Address(RVA = "0x1CE3A00", Offset = "0x1CE2E00", Length = "0x133")]
	[Token(Token = "0x600031B")]
	public List<PawnEnemy> EntryEnemy(EnemyData _enemyData, Transform _root, Vector3 _posOffset, Division tdivision, float sDelay, int indexValue) { }

	[Address(RVA = "0x1CE38D0", Offset = "0x1CE2CD0", Length = "0x12D")]
	[Token(Token = "0x600031C")]
	public List<PawnEnemy> EntryEnemyNoRate(EnemyData _enemyData, Transform _root, Vector3 _posOffset, Division tdivision, int indexValue) { }

	[Address(RVA = "0x1CE3B40", Offset = "0x1CE2F40", Length = "0x2E3")]
	[Token(Token = "0x6000323")]
	public void EntryItemCarry(Kind ikind, Vector3 startOffset, int tdir) { }

	[Address(RVA = "0x1CE3E30", Offset = "0x1CE3230", Length = "0x6B")]
	[Token(Token = "0x6000336")]
	public HashSet<Int32> ExportDropLists() { }

	[Address(RVA = "0x1CE3EA0", Offset = "0x1CE32A0", Length = "0x6D")]
	[IteratorStateMachine(typeof(<FinishStage>d__510))]
	[Token(Token = "0x6000394")]
	public IEnumerator FinishStage() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x60002E4")]
	public InGameAnimationManager get_AnimatorManager() { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[Token(Token = "0x60002E6")]
	public InGameAreaManager get_AreaManager() { }

	[Address(RVA = "0x1CF27E0", Offset = "0x1CF1BE0", Length = "0x1C")]
	[Token(Token = "0x60002D4")]
	public float get_BaseDeltaTime() { }

	[Address(RVA = "0x1CF2800", Offset = "0x1CF1C00", Length = "0x1C")]
	[Token(Token = "0x60002D3")]
	public float get_BaseTimeFactor() { }

	[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
	[Token(Token = "0x60002EC")]
	public InGameBonusManager get_BonusManager() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[Token(Token = "0x600031A")]
	public UIBossGauge get_BossGauge() { }

	[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
	[Token(Token = "0x60002E2")]
	public InGameBulletManager get_BulletManager() { }

	[Address(RVA = "0x1CF2840", Offset = "0x1CF1C40", Length = "0x63")]
	[Token(Token = "0x60002F7")]
	public static Vector3 get_CameraBasePosition() { }

	[Address(RVA = "0x1CF28B0", Offset = "0x1CF1CB0", Length = "0x5E")]
	[Token(Token = "0x60002F8")]
	public static Quaternion get_CameraBaseRotate() { }

	[Address(RVA = "0x1CF2910", Offset = "0x1CF1D10", Length = "0x50")]
	[Token(Token = "0x60002FA")]
	public static float get_CameraTall() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[Token(Token = "0x60002EB")]
	public InGameEnemyClipsManager get_ClipsManager() { }

	[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
	[Token(Token = "0x60002EA")]
	public HybridCollisionManager get_CollisionManager() { }

	[Address(RVA = "0x1CF2980", Offset = "0x1CF1D80", Length = "0x1C")]
	[Token(Token = "0x60002D6")]
	public float get_DeltaTime() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x600038B")]
	public string get_DiPointStr() { }

	[Address(RVA = "0x1CF29A0", Offset = "0x1CF1DA0", Length = "0x1C")]
	[Token(Token = "0x60002DA")]
	public float get_EffectDeltaTime() { }

	[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
	[Token(Token = "0x60002E5")]
	public InGameEffectManager get_EffectManager() { }

	[Address(RVA = "0x1CF29C0", Offset = "0x1CF1DC0", Length = "0x1C")]
	[Token(Token = "0x60002D9")]
	public float get_EffectTimeFactor() { }

	[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
	[Token(Token = "0x60002E1")]
	public InGameEnemyManager get_EnemyManager() { }

	[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
	[Token(Token = "0x60002D7")]
	public float get_EventRepeatScale() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x60002DC")]
	public Transform get_GameRoot() { }

	[Address(RVA = "0x1CF29F0", Offset = "0x1CF1DF0", Length = "0x9")]
	[Token(Token = "0x600038A")]
	public float get_GetDiPoint() { }

	[Address(RVA = "0x1CF2A00", Offset = "0x1CF1E00", Length = "0x5E")]
	[Token(Token = "0x60002F9")]
	public static Quaternion get_GroundCameraBaseRotate() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x60002DD")]
	public Transform get_InGameEnemyRoot() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x60002DE")]
	public Transform get_InGameGroundSky() { }

	[Address(RVA = "0x1CF2AA0", Offset = "0x1CF1EA0", Length = "0x25")]
	[Token(Token = "0x60002C5")]
	public bool get_IsBaseGameStop() { }

	[Address(RVA = "0x1CF2A70", Offset = "0x1CF1E70", Length = "0x29")]
	[Token(Token = "0x600036A")]
	public bool get_IsBGSlideMode() { }

	[Address(RVA = "0x1CF2AD0", Offset = "0x1CF1ED0", Length = "0x5")]
	[Token(Token = "0x60002CE")]
	public bool get_IsCompleteStage() { }

	[Address(RVA = "0x1CF2AE0", Offset = "0x1CF1EE0", Length = "0xB")]
	[Token(Token = "0x600036B")]
	public bool get_IsDeadingPhase() { }

	[Address(RVA = "0x1CF2B00", Offset = "0x1CF1F00", Length = "0x29")]
	[Token(Token = "0x600036E")]
	public bool get_IsEndingPhase() { }

	[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
	[Token(Token = "0x60002CA")]
	public bool get_IsEndReturn() { }

	[Address(RVA = "0x1CF2B30", Offset = "0x1CF1F30", Length = "0x50")]
	[Token(Token = "0x6000370")]
	public bool get_IsEnemyBulletPhase() { }

	[Address(RVA = "0x1CF2B80", Offset = "0x1CF1F80", Length = "0x3E")]
	[Token(Token = "0x600036F")]
	public bool get_IsEnemyCallPhase() { }

	[Address(RVA = "0x1CF2BC0", Offset = "0x1CF1FC0", Length = "0x17")]
	[Token(Token = "0x6000367")]
	public bool get_IsFirstPlayPhase() { }

	[Address(RVA = "0x1CF2BE0", Offset = "0x1CF1FE0", Length = "0xB")]
	[Token(Token = "0x6000368")]
	public bool get_IsFirstTimePhase() { }

	[Address(RVA = "0x1CF2BF0", Offset = "0x1CF1FF0", Length = "0x5")]
	[Token(Token = "0x60002CD")]
	public bool get_IsGameOver() { }

	[Address(RVA = "0x1CF2C00", Offset = "0x1CF2000", Length = "0x25")]
	[Token(Token = "0x60002C9")]
	public bool get_IsGameStop() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[Token(Token = "0x60002D0")]
	public bool get_IsManualQuit() { }

	[Address(RVA = "0x1CF2C40", Offset = "0x1CF2040", Length = "0x5")]
	[Token(Token = "0x60002CF")]
	public bool get_IsNextStage() { }

	[Address(RVA = "0x1CF2C50", Offset = "0x1CF2050", Length = "0x8")]
	[Token(Token = "0x600037B")]
	public bool get_IsNoDeadCount() { }

	[Address(RVA = "0x1CF2C60", Offset = "0x1CF2060", Length = "0x32")]
	[Token(Token = "0x6000373")]
	public bool get_IsNoScorePhase() { }

	[Address(RVA = "0x1CF2CA0", Offset = "0x1CF20A0", Length = "0x20")]
	[Token(Token = "0x6000372")]
	public bool get_IsNotReadyPhase() { }

	[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
	[Token(Token = "0x60002C3")]
	public bool get_IsPause() { }

	[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
	[Token(Token = "0x60002C4")]
	public bool get_IsPauseMenuOpen() { }

	[Address(RVA = "0x1CF2CD0", Offset = "0x1CF20D0", Length = "0x17")]
	[Token(Token = "0x600036C")]
	public bool get_IsPauseNGPhase() { }

	[Address(RVA = "0x1CF2D00", Offset = "0x1CF2100", Length = "0x1A")]
	[Token(Token = "0x6000371")]
	public bool get_IsPlayerMarkDisplay() { }

	[Address(RVA = "0x1CF2D20", Offset = "0x1CF2120", Length = "0x17")]
	[Token(Token = "0x6000369")]
	public bool get_IsPlayerMoving() { }

	[Address(RVA = "0x1CF2D40", Offset = "0x1CF2140", Length = "0x17")]
	[Token(Token = "0x6000375")]
	public bool get_IsPlayerShooting() { }

	[Address(RVA = "0x1CF2D60", Offset = "0x1CF2160", Length = "0x20")]
	[Token(Token = "0x600036D")]
	public bool get_IsPlayingInGame() { }

	[Address(RVA = "0x1CF2D80", Offset = "0x1CF2180", Length = "0x45")]
	[Token(Token = "0x6000374")]
	public bool get_IsPlayingProcess() { }

	[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
	[Token(Token = "0x60002CC")]
	public bool get_IsQuitDone() { }

	[Address(RVA = "0x1CF2DE0", Offset = "0x1CF21E0", Length = "0x11")]
	[Token(Token = "0x60002D2")]
	public bool get_IsScoreDisplay() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600030C")]
	public bool get_IsStageDebugMode() { }

	[Address(RVA = "0x1CF2E00", Offset = "0x1CF2200", Length = "0x5")]
	[Token(Token = "0x60002D1")]
	public bool get_IsStartOver() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600030D")]
	public bool get_IsTimelineDebugMode() { }

	[Address(RVA = "0x1CF2E10", Offset = "0x1CF2210", Length = "0x5")]
	[Token(Token = "0x60002CB")]
	public bool get_IsTrainingMode() { }

	[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
	[Token(Token = "0x60002C2")]
	public float get_LapedDeltaTime() { }

	[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
	[Token(Token = "0x60002E3")]
	public InGameParticleSystemManager get_ParticleManager() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[Token(Token = "0x60002D8")]
	public int get_PlayerCount() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[Token(Token = "0x60002E0")]
	public InGamePlayerManager get_PlayerManager() { }

	[Address(RVA = "0x1CF2E30", Offset = "0x1CF2230", Length = "0x7")]
	[Token(Token = "0x6000366")]
	public Phase get_PlayPhase() { }

	[Address(RVA = "0x1CF2E40", Offset = "0x1CF2240", Length = "0x1C")]
	[Token(Token = "0x60002D5")]
	public float get_PlayTimeFactor() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[Token(Token = "0x60002DF")]
	public Transform get_PoolRoot() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60002C1")]
	public TimeFactor get_PTimeFactor() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[Token(Token = "0x60002E8")]
	public InGameRouteManager get_RouteManager() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[Token(Token = "0x60002E9")]
	public InGameRuinManager get_RuinManager() { }

	[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
	[Token(Token = "0x60002E7")]
	public InGameStageManager get_StageManager() { }

	[Address(RVA = "0x1CF2EB0", Offset = "0x1CF22B0", Length = "0x7")]
	[Token(Token = "0x6000338")]
	public int get_StrongestCount() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x60002DB")]
	public Transform get_SystemRoot() { }

	[Address(RVA = "0x1CE3F10", Offset = "0x1CE3310", Length = "0x188")]
	[Token(Token = "0x6000328")]
	public void Get5000(Vector3 targetPos, int pno, bool isGround) { }

	[Address(RVA = "0x1CE40A0", Offset = "0x1CE34A0", Length = "0x13")]
	[Token(Token = "0x600030F")]
	public int GetBossTime() { }

	[Address(RVA = "0x1CE40C0", Offset = "0x1CE34C0", Length = "0x114")]
	[Token(Token = "0x6000383")]
	public float GetBulletSpeedScale() { }

	[Address(RVA = "0x1CE41E0", Offset = "0x1CE35E0", Length = "0x145")]
	[Token(Token = "0x6000325")]
	public Vector3 GetClampedBonusPosition(Vector3 wpos, bool enableBottomOffset) { }

	[Address(RVA = "0x1CE4330", Offset = "0x1CE3730", Length = "0x111")]
	[Token(Token = "0x6000324")]
	public Vector3 GetClampedPosition(Vector3 wpos, bool enableBottomOffset) { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[Token(Token = "0x60002A5")]
	public float GetDamageMag(int pindex) { }

	[Address(RVA = "0x1CE4460", Offset = "0x1CE3860", Length = "0x114")]
	[Token(Token = "0x6000384")]
	public float GetEventRepeatScale() { }

	[Address(RVA = "0x1CE4580", Offset = "0x1CE3980", Length = "0xB5")]
	[Token(Token = "0x60002ED")]
	public Vector3 GetGameRootPosition(Vector3 wpos, bool isGround) { }

	[Address(RVA = "0x1CE4640", Offset = "0x1CE3A40", Length = "0x134")]
	[Token(Token = "0x6000330")]
	public string GetGroundItemName(Kind tkind, Vector3 wpos, bool isForce) { }

	[Address(RVA = "0x1CE4780", Offset = "0x1CE3B80", Length = "0x6D")]
	[Token(Token = "0x600032D")]
	public PawnEnemy GetHighEnemy() { }

	[Address(RVA = "0x1CE47F0", Offset = "0x1CE3BF0", Length = "0x18D")]
	[Token(Token = "0x6000345")]
	private HitDirFlag GetHitDir(Bounds tbound, Vector3 spos, float pheight) { }

	[Address(RVA = "0x1CE4980", Offset = "0x1CE3D80", Length = "0x15D")]
	[Token(Token = "0x60002F4")]
	public Vector2 GetInGameScreenViewport(Vector3 worldPosition, bool isGround) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000300")]
	public string GetLog() { }

	[Address(RVA = "0x1CE4AE0", Offset = "0x1CE3EE0", Length = "0xD6")]
	[Token(Token = "0x600029E")]
	public float GetNearestPlayerDistance(Vector2 spos) { }

	[Address(RVA = "0x1CE4CB0", Offset = "0x1CE40B0", Length = "0x188")]
	[Token(Token = "0x600029D")]
	public int GetNearestPlayerIndex(Vector2 spos) { }

	[Address(RVA = "0x1CE4BC0", Offset = "0x1CE3FC0", Length = "0x63")]
	[Token(Token = "0x600029C")]
	public int GetNearestPlayerIndexInLocal(Vector3 lpos) { }

	[Address(RVA = "0x1CE4C30", Offset = "0x1CE4030", Length = "0x72")]
	[Token(Token = "0x600029B")]
	public int GetNearestPlayerIndexInWorld(Vector3 wpos, bool isGround) { }

	[Address(RVA = "0x1CE4E40", Offset = "0x1CE4240", Length = "0x49F")]
	[Token(Token = "0x6000344")]
	private Vector3 GetObstaclePosition(Vector3 rpos, Vector3 spos, float tsize) { }

	[Address(RVA = "0x1CE52E0", Offset = "0x1CE46E0", Length = "0x378")]
	[Token(Token = "0x6000343")]
	private Vector3 GetObstacleVector(Vector3 rpos, Vector3 spos, Vector3 vforce, float tdistance, float speed) { }

	[Address(RVA = "0x1CE5E20", Offset = "0x1CE5220", Length = "0x3A")]
	[Token(Token = "0x600028F")]
	public PlayerControll GetPlayer(string pname, bool is2P = false) { }

	[Address(RVA = "0x1CE5660", Offset = "0x1CE4A60", Length = "0x134")]
	[Token(Token = "0x60003A3")]
	private int GetPlayerAwakeLevel() { }

	[Address(RVA = "0x1CE57A0", Offset = "0x1CE4BA0", Length = "0x93")]
	[Token(Token = "0x60002A7")]
	public InGameCollisionBase GetPlayerBody(int index = 0) { }

	[Address(RVA = "0x1CE5840", Offset = "0x1CE4C40", Length = "0xE7")]
	[Token(Token = "0x60002A8")]
	public InGameCollisionBase GetPlayerBody(Vector3 lpos) { }

	[Address(RVA = "0x1CE5930", Offset = "0x1CE4D30", Length = "0xE0")]
	[Token(Token = "0x60002A2")]
	public Vector3 GetPlayerBulletPosition(int index = 0) { }

	[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
	[Token(Token = "0x600029A")]
	public PlayerCommonData GetPlayerCommonData() { }

	[Address(RVA = "0x1CE5A30", Offset = "0x1CE4E30", Length = "0xBF")]
	[Token(Token = "0x60002A4")]
	public PlayerControll GetPlayerControll(int index = 0) { }

	[Address(RVA = "0x1CE5AF0", Offset = "0x1CE4EF0", Length = "0x48")]
	[Token(Token = "0x60002A0")]
	public Vector3 GetPlayerEnemyRootPosition(int index = 0) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000301")]
	public string GetPlayerInfo() { }

	[Address(RVA = "0x1CE5B40", Offset = "0x1CE4F40", Length = "0x2E")]
	[Token(Token = "0x6000298")]
	public PlayerInformation GetPlayerInformation(int index = 0) { }

	[Address(RVA = "0x1CE5B70", Offset = "0x1CE4F70", Length = "0x48")]
	[Token(Token = "0x600029F")]
	public Vector3 GetPlayerPosition(int index = 0) { }

	[Address(RVA = "0x1CE5BC0", Offset = "0x1CE4FC0", Length = "0xCE")]
	[Token(Token = "0x60002A3")]
	public Vector2 GetPlayerScreenPosition(int index = 0) { }

	[Address(RVA = "0x1CE5C90", Offset = "0x1CE5090", Length = "0xE0")]
	[Token(Token = "0x60002A1")]
	public Vector3 GetPlayerSkyPosition(int index = 0) { }

	[Address(RVA = "0x1CE5D80", Offset = "0x1CE5180", Length = "0x93")]
	[Token(Token = "0x60002A6")]
	public Transform GetPlayerTransform(int index = 0) { }

	[Address(RVA = "0x1CE5FF0", Offset = "0x1CE53F0", Length = "0x181")]
	[Token(Token = "0x60002BE")]
	public InGameResult GetResult() { }

	[Address(RVA = "0x1CE5E60", Offset = "0x1CE5260", Length = "0x180")]
	[Token(Token = "0x60002BD")]
	public InGameResult GetResult(bool isComplete) { }

	[Address(RVA = "0x1CE6180", Offset = "0x1CE5580", Length = "0x2ED")]
	[Token(Token = "0x600032B")]
	public void GetRushBonus(Vector3 wpos, int tmul) { }

	[Address(RVA = "0x1CE6470", Offset = "0x1CE5870", Length = "0x62")]
	[Token(Token = "0x60002F2")]
	public Vector2 GetScreenPosition(Vector3 wpos, bool isGround, bool isLocal) { }

	[Address(RVA = "0x1CE64E0", Offset = "0x1CE58E0", Length = "0xC2")]
	[Token(Token = "0x60002F3")]
	public Vector2 GetScreenViewport(Vector3 wpos, bool isGround, bool isLocal) { }

	[Address(RVA = "0x1CE65B0", Offset = "0x1CE59B0", Length = "0xE9")]
	[Token(Token = "0x60002F1")]
	public Vector3 GetSkyBulletPosition(Vector3 wpos) { }

	[Address(RVA = "0x1CE66A0", Offset = "0x1CE5AA0", Length = "0xA7")]
	[Token(Token = "0x60002EF")]
	public Vector3 GetSkyEmitPosition(Vector3 wpos, bool isGround) { }

	[Address(RVA = "0x1CE6750", Offset = "0x1CE5B50", Length = "0x109")]
	[Token(Token = "0x60002EE")]
	public Vector3 GetSkyRootPosition(Vector3 wpos, bool isGround) { }

	[Address(RVA = "0x1CE6860", Offset = "0x1CE5C60", Length = "0x228")]
	[Token(Token = "0x6000327")]
	public void GetSomthing(Vector3 targetPos, bool isGround) { }

	[Address(RVA = "0x1CE6A90", Offset = "0x1CE5E90", Length = "0x6D")]
	[Token(Token = "0x600032C")]
	public PawnEnemy GetStrongestEnemy() { }

	[Address(RVA = "0x1CE6B00", Offset = "0x1CE5F00", Length = "0x1F0")]
	[Token(Token = "0x600032E")]
	public Vector3 GetStrongestMostNear(Vector3 tpos) { }

	[Address(RVA = "0x1CE6D00", Offset = "0x1CE6100", Length = "0x6E")]
	[Token(Token = "0x6000299")]
	public PlayerInformation GetTeamInformation() { }

	[Address(RVA = "0x1CE6D70", Offset = "0x1CE6170", Length = "0x83")]
	[Token(Token = "0x6000335")]
	public void ImportDropLists(HashSet<Int32> tlist) { }

	[Address(RVA = "0x1CE6FB0", Offset = "0x1CE63B0", Length = "0x6D")]
	[IteratorStateMachine(typeof(<Initialize>d__0))]
	[Token(Token = "0x600027D")]
	public IEnumerator Initialize() { }

	[Address(RVA = "0x1CE6E00", Offset = "0x1CE6200", Length = "0xA9")]
	[Token(Token = "0x600033D")]
	private void InitializeJems() { }

	[Address(RVA = "0x1CE6EB0", Offset = "0x1CE62B0", Length = "0x6D")]
	[IteratorStateMachine(typeof(<InitializeSubManagers>d__4))]
	[Token(Token = "0x6000281")]
	public IEnumerator InitializeSubManagers() { }

	[Address(RVA = "0x1CE6F20", Offset = "0x1CE6320", Length = "0x8A")]
	[IteratorStateMachine(typeof(<InitializeTimeline>d__23))]
	[Token(Token = "0x6000294")]
	public IEnumerator InitializeTimeline(GameObject tobj) { }

	[Address(RVA = "0x1CE7020", Offset = "0x1CE6420", Length = "0x6D")]
	[IteratorStateMachine(typeof(<IntervalLow>d__544))]
	[Token(Token = "0x60003B6")]
	protected IEnumerator IntervalLow() { }

	[Address(RVA = "0x1CE7090", Offset = "0x1CE6490", Length = "0x6D")]
	[IteratorStateMachine(typeof(<IntervalNormal>d__543))]
	[Token(Token = "0x60003B5")]
	protected IEnumerator IntervalNormal() { }

	[Address(RVA = "0x1CE7100", Offset = "0x1CE6500", Length = "0x54")]
	[Token(Token = "0x6000332")]
	public bool IsAlreadyExist(int thash) { }

	[Address(RVA = "0x1CE7160", Offset = "0x1CE6560", Length = "0xD7")]
	[Token(Token = "0x6000331")]
	public bool IsAlreadyExist(Kind tkind, Vector3 wpos, bool withAdd) { }

	[Address(RVA = "0x1CE7240", Offset = "0x1CE6640", Length = "0x7E")]
	[Token(Token = "0x600031D")]
	public bool IsCompleteDestroy(string enemyName, string dbKeyString) { }

	[Address(RVA = "0x1CE72C0", Offset = "0x1CE66C0", Length = "0x3D")]
	[Token(Token = "0x600028A")]
	public bool IsErrorMessage() { }

	[Address(RVA = "0x1CE7300", Offset = "0x1CE6700", Length = "0x10B")]
	[Token(Token = "0x60002F5")]
	public bool IsFireDistance(Vector3 spos) { }

	[Address(RVA = "0x1CE76F0", Offset = "0x1CE6AF0", Length = "0x1EB")]
	[Token(Token = "0x60002AC")]
	public bool IsGameArea(Vector3 wpos, float r) { }

	[Address(RVA = "0x1CE7580", Offset = "0x1CE6980", Length = "0x163")]
	[Token(Token = "0x60002AA")]
	public bool IsGameArea(Vector3 lpos) { }

	[Address(RVA = "0x1CE7410", Offset = "0x1CE6810", Length = "0x163")]
	[Token(Token = "0x60002AB")]
	public bool IsGameAreaSky(Vector3 lpos) { }

	[Address(RVA = "0x1CE78E0", Offset = "0x1CE6CE0", Length = "0x176")]
	[Token(Token = "0x6000377")]
	public bool IsGameBulletAreaWorld(Vector3 wpos, bool isGround) { }

	[Address(RVA = "0x1CE7A60", Offset = "0x1CE6E60", Length = "0x166")]
	[Token(Token = "0x6000376")]
	public bool IsGameLaserAreaWorld(Vector3 wpos) { }

	[Address(RVA = "0x1CE7BD0", Offset = "0x1CE6FD0", Length = "0x163")]
	[Token(Token = "0x60002AF")]
	public bool IsGameWideArea(Vector3 lpos) { }

	[Address(RVA = "0x1CF2EC0", Offset = "0x1CF22C0", Length = "0x1FA")]
	[Token(Token = "0x6000342")]
	private bool isHitAnything(Vector3 tpos, Vector3 tstep, Vector2 tdir, float tdistance, int nMask) { }

	[Address(RVA = "0x1CE7D40", Offset = "0x1CE7140", Length = "0x1A4")]
	[Token(Token = "0x60002A9")]
	public bool IsInGameAreaWorld(Vector3 wpos, bool isGround, EnemySize tsize) { }

	[Address(RVA = "0x1CE7EF0", Offset = "0x1CE72F0", Length = "0x77")]
	[Token(Token = "0x60002AD")]
	public bool IsInGameRange(Vector3 wpos, float trange) { }

	[Address(RVA = "0x1CE7F70", Offset = "0x1CE7370", Length = "0xDB")]
	[Token(Token = "0x60003A0")]
	public bool IsPlayerDeading() { }

	[Address(RVA = "0x1CE8050", Offset = "0x1CE7450", Length = "0x79")]
	[Token(Token = "0x600039F")]
	private bool IsPlayerEnable(int n) { }

	[Address(RVA = "0x1CE80D0", Offset = "0x1CE74D0", Length = "0xDB")]
	[Token(Token = "0x60003A1")]
	public bool IsPlayerRescueOK() { }

	[Address(RVA = "0x1CE81B0", Offset = "0x1CE75B0", Length = "0x34")]
	[Token(Token = "0x6000379")]
	public bool IsSecondlyPlayBGM() { }

	[Address(RVA = "0x1CE81F0", Offset = "0x1CE75F0", Length = "0xAA")]
	[Token(Token = "0x60002AE")]
	public bool IsSkipGroundRestart(Vector3 wpos) { }

	[Address(RVA = "0x1CE82A0", Offset = "0x1CE76A0", Length = "0x30")]
	[Token(Token = "0x6000284")]
	public bool IsSubManabgersEnd() { }

	[Address(RVA = "0x1CE82D0", Offset = "0x1CE76D0", Length = "0xA")]
	[Token(Token = "0x600034D")]
	public bool IsTLFlag(TLClipFlag tflag) { }

	[Address(RVA = "0x1CE82E0", Offset = "0x1CE76E0", Length = "0x29A")]
	[Token(Token = "0x6000326")]
	public void ItemDrop(Kind itemKind, Vector3 targetPos, bool enableBottomOffset = false) { }

	[Address(RVA = "0x1CE8580", Offset = "0x1CE7980", Length = "0x52B")]
	[Token(Token = "0x60003A6")]
	private void LateUpdate() { }

	[Address(RVA = "0x1CE8AB0", Offset = "0x1CE7EB0", Length = "0x91")]
	[IteratorStateMachine(typeof(<LocalWaitSeconds>d__412))]
	[Token(Token = "0x6000360")]
	public IEnumerator LocalWaitSeconds(float tsec, bool withBase) { }

	[Address(RVA = "0x1CE8B50", Offset = "0x1CE7F50", Length = "0x5")]
	[Token(Token = "0x600027F")]
	private void OnApplicationQuit() { }

	[Address(RVA = "0x1CE8B60", Offset = "0x1CE7F60", Length = "0x72")]
	[Token(Token = "0x6000280")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1CE8BE0", Offset = "0x1CE7FE0", Length = "0x62")]
	[Token(Token = "0x60002BC")]
	private void OnPauseRequested() { }

	[Address(RVA = "0x1CE8C50", Offset = "0x1CE8050", Length = "0x91")]
	[Token(Token = "0x6000398")]
	public void PauseWithLabel(bool isPause, int _padno) { }

	[Address(RVA = "0x1CE8CF0", Offset = "0x1CE80F0", Length = "0xF5")]
	[Token(Token = "0x6000352")]
	public void Phase_ForceQuit() { }

	[Address(RVA = "0x1CE8DF0", Offset = "0x1CE81F0", Length = "0xBF")]
	[Token(Token = "0x600034F")]
	public void Phase_PlayerDead() { }

	[Address(RVA = "0x1CE8EB0", Offset = "0x1CE82B0", Length = "0x16D")]
	[Token(Token = "0x6000353")]
	public void Phase_StageClear() { }

	[Address(RVA = "0x1CE9020", Offset = "0x1CE8420", Length = "0x63")]
	[Token(Token = "0x6000351")]
	public void Phase_Terminate() { }

	[Address(RVA = "0x1CE9090", Offset = "0x1CE8490", Length = "0x152")]
	[Token(Token = "0x6000354")]
	public void Phase_Timeover() { }

	[Address(RVA = "0x1CE91F0", Offset = "0x1CE85F0", Length = "0xBF")]
	[Token(Token = "0x6000350")]
	public void Phase_TimeupDone() { }

	[Address(RVA = "0x1CE92B0", Offset = "0x1CE86B0", Length = "0xF5")]
	[Token(Token = "0x6000355")]
	public void Phase_TrainingClear() { }

	[Address(RVA = "0x1CE93B0", Offset = "0x1CE87B0", Length = "0x131")]
	[Token(Token = "0x6000340")]
	public void PipilDrop(Vector3 spos, int dropCount, int playerNo, EnemySize enemySize) { }

	[Address(RVA = "0x1CE94F0", Offset = "0x1CE88F0", Length = "0x1A4")]
	[Token(Token = "0x6000347")]
	public static Vector3 PlayerControllClamp(Vector3 playerPosition) { }

	[Address(RVA = "0x1CE96A0", Offset = "0x1CE8AA0", Length = "0x361")]
	[Token(Token = "0x6000341")]
	public Vector3 PlayerControllPosition(Vector3 playerPosition, Vector3 playerVec, float playerSpeed) { }

	[Address(RVA = "0x1CE9A10", Offset = "0x1CE8E10", Length = "0x6A")]
	[Token(Token = "0x6000397")]
	public void QuitGame(bool isManualQuit = false, bool isStartOver = false) { }

	[Address(RVA = "0x1CE9A80", Offset = "0x1CE8E80", Length = "0x39F")]
	[Token(Token = "0x6000392")]
	public void RefreshStage() { }

	[Address(RVA = "0x1CE9E20", Offset = "0x1CE9220", Length = "0x8F")]
	[Token(Token = "0x6000334")]
	public void RemoveAlreadyHash(int thash) { }

	[Address(RVA = "0x1CE9EB0", Offset = "0x1CE92B0", Length = "0x21")]
	[Token(Token = "0x60003B0")]
	public void RemoveOnLowEvent(UnityAction f) { }

	[Address(RVA = "0x1CE9EE0", Offset = "0x1CE92E0", Length = "0x56")]
	[Token(Token = "0x60003AE")]
	public void RemoveOnNormalEvent(UnityAction<InGameManager> f) { }

	[Address(RVA = "0x1CE9F40", Offset = "0x1CE9340", Length = "0x21")]
	[Token(Token = "0x60002BA")]
	public bool RemovePhysicsObject(IPhysicsUpdater physicsObject) { }

	[Address(RVA = "0x1CE9F70", Offset = "0x1CE9370", Length = "0x21")]
	[Token(Token = "0x60003B2")]
	public void RemoveRestartEvent(UnityAction f) { }

	[Address(RVA = "0x1CE9FA0", Offset = "0x1CE93A0", Length = "0xA3")]
	[Token(Token = "0x6000396")]
	public void RequestPause(bool isPause, bool withoutMenu) { }

	[Address(RVA = "0x1CEA050", Offset = "0x1CE9450", Length = "0x375")]
	[Token(Token = "0x600038D")]
	public void ResetScore(int numStock, int numBomber) { }

	[Address(RVA = "0x1CEA3D0", Offset = "0x1CE97D0", Length = "0x9")]
	[Token(Token = "0x600034C")]
	public void ResetTLFlag(TLClipFlag tflag) { }

	[Address(RVA = "0x1CEA3E0", Offset = "0x1CE97E0", Length = "0x114")]
	[Token(Token = "0x6000393")]
	public void RestartArea(int tindex) { }

	[Address(RVA = "0x1CEA500", Offset = "0x1CE9900", Length = "0xB3")]
	[IteratorStateMachine(typeof(<RestartGame>d__414))]
	[Token(Token = "0x6000362")]
	public IEnumerator RestartGame(float twait, float swait, int areaIndex, Action startCallBack = null) { }

	[Address(RVA = "0x1CEA5C0", Offset = "0x1CE99C0", Length = "0x15")]
	[Token(Token = "0x6000319")]
	public void SetAreaBreak(bool isBreak) { }

	[Address(RVA = "0x1CEA5E0", Offset = "0x1CE99E0", Length = "0x2C")]
	[Token(Token = "0x600033C")]
	public void SetArmDropMask(bool isBlack, bool isGold) { }

	[Address(RVA = "0x1CEA610", Offset = "0x1CE9A10", Length = "0x93")]
	[Token(Token = "0x6000316")]
	public void SetBGMName(string tname) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[Token(Token = "0x600030E")]
	public void SetBossGauge(UIBossGauge gauge) { }

	[Address(RVA = "0x1CEA6B0", Offset = "0x1CE9AB0", Length = "0xBA")]
	[Token(Token = "0x6000311")]
	public UIBossGauge SetBossGaugeStart(bool isActive) { }

	[Address(RVA = "0x1CEA790", Offset = "0x1CE9B90", Length = "0xEB")]
	[Token(Token = "0x6000310")]
	public void SetBossTime(int tkind) { }

	[Address(RVA = "0x1CEA880", Offset = "0x1CE9C80", Length = "0x1C")]
	[Token(Token = "0x600028C")]
	public void SetEffectTimeRate(float rate) { }

	[Address(RVA = "0x1CEA8A0", Offset = "0x1CE9CA0", Length = "0x4")]
	[Token(Token = "0x60002B6")]
	public void SetEndReturn(bool v) { }

	[Address(RVA = "0x1CEAA70", Offset = "0x1CE9E70", Length = "0x92")]
	[Token(Token = "0x60002B1")]
	public void SetGameoverLabel(ViewGameover v) { }

	[Address(RVA = "0x1CEA8B0", Offset = "0x1CE9CB0", Length = "0x1B9")]
	[Token(Token = "0x60002B4")]
	public void SetGameRoot(Transform root = null) { }

	[Address(RVA = "0x1CEAD20", Offset = "0x1CEA120", Length = "0xBB")]
	[Token(Token = "0x6000314")]
	public void SetInGameMessage(string vstr) { }

	[Address(RVA = "0x1CEAB10", Offset = "0x1CE9F10", Length = "0xA7")]
	[Token(Token = "0x6000313")]
	public void SetInGameMessageAlpha(float v) { }

	[Address(RVA = "0x1CEABC0", Offset = "0x1CE9FC0", Length = "0x15D")]
	[Token(Token = "0x6000312")]
	public void SetInGameMessageCanvas(CanvasGroup cg, UITextMeshPro tmp) { }

	[Address(RVA = "0x1CEADE0", Offset = "0x1CEA1E0", Length = "0x18")]
	[Conditional("TXEDEV")]
	[Conditional("INGAMEDEBUG")]
	[Token(Token = "0x60002FE")]
	public void SetLog(string s) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002FF")]
	public void SetLog(string s, float ttime) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000302")]
	public void SetLogError(string s) { }

	[Address(RVA = "0x1CEAE00", Offset = "0x1CEA200", Length = "0x4")]
	[Token(Token = "0x60002C8")]
	private void SetNextStage(bool tflag) { }

	[Address(RVA = "0x1CEAE10", Offset = "0x1CEA210", Length = "0x7")]
	[Token(Token = "0x600037A")]
	public void SetNoDeadCount(bool nset) { }

	[Address(RVA = "0x1CEAE40", Offset = "0x1CEA240", Length = "0xE2")]
	[Token(Token = "0x6000395")]
	public void SetPause(bool v) { }

	[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
	[Token(Token = "0x60002B0")]
	public void SetPauseMenu(PauseWindowMenu pmenu) { }

	[Address(RVA = "0x1CEAF60", Offset = "0x1CEA360", Length = "0x1A0")]
	[Token(Token = "0x6000297")]
	public void SetPlayerController(PlayerControll c, Transform t, InGameCollisionBase b, int index = 0) { }

	[Address(RVA = "0x1CEAF30", Offset = "0x1CEA330", Length = "0x7")]
	[Token(Token = "0x6000356")]
	public void SetPlayPhase(Phase tphase) { }

	[Address(RVA = "0x1CEAF40", Offset = "0x1CEA340", Length = "0x1C")]
	[Token(Token = "0x600028B")]
	public void SetPlayTimeRate(float rate) { }

	[Address(RVA = "0x1CEB110", Offset = "0x1CEA510", Length = "0x4")]
	[Token(Token = "0x60002C6")]
	public void SetQuitFlag(bool tflag) { }

	[Address(RVA = "0x1CEB120", Offset = "0x1CEA520", Length = "0x4")]
	[Token(Token = "0x60002B8")]
	public void SetRushMode(bool v) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000309")]
	public void SetStageDebug(bool nset) { }

	[Address(RVA = "0x1CEB130", Offset = "0x1CEA530", Length = "0x4")]
	[Token(Token = "0x60002C7")]
	public void SetStartOverStart(bool tflag) { }

	[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
	[Token(Token = "0x60002BB")]
	public void SetStartPauseAction(Action tact) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600030A")]
	public void SetTimelineDebug(bool nset) { }

	[Address(RVA = "0x1CEB170", Offset = "0x1CEA570", Length = "0x92")]
	[Token(Token = "0x60002B2")]
	public void SetTimeupLabel(ViewTimeup v) { }

	[Address(RVA = "0x1CEB160", Offset = "0x1CEA560", Length = "0x7")]
	[Token(Token = "0x600034B")]
	public void SetTLFlag(TLClipFlag tflag) { }

	[Address(RVA = "0x1CEB210", Offset = "0x1CEA610", Length = "0x4")]
	[Token(Token = "0x60002B7")]
	public void SetTrainingMode(bool v) { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[Token(Token = "0x6000315")]
	public void SetUIView(InGameViewUI tuiview) { }

	[Address(RVA = "0x1CEB240", Offset = "0x1CEA640", Length = "0x62F")]
	[Token(Token = "0x6000399")]
	protected void SetupBrain(PlayableDirector tl) { }

	[Address(RVA = "0x1CEB900", Offset = "0x1CEAD00", Length = "0x8A")]
	[IteratorStateMachine(typeof(<SetupBullet>d__8))]
	[Token(Token = "0x6000285")]
	public IEnumerator SetupBullet(PrefabPacks packs) { }

	[Address(RVA = "0x1CEB870", Offset = "0x1CEAC70", Length = "0x8A")]
	[IteratorStateMachine(typeof(<SetupBulletTemplate>d__20))]
	[Token(Token = "0x6000291")]
	public IEnumerator SetupBulletTemplate(Dictionary<String, Int32> tdic) { }

	[Address(RVA = "0x1CEB990", Offset = "0x1CEAD90", Length = "0x1F2")]
	[Token(Token = "0x60002F6")]
	public void SetupCameraPosition() { }

	[Address(RVA = "0x1CEBB90", Offset = "0x1CEAF90", Length = "0xC6")]
	[IteratorStateMachine(typeof(<SetupDatas>d__10))]
	[Token(Token = "0x6000287")]
	public IEnumerator SetupDatas(PrefabPacks bullets, PrefabPacks effects, Dictionary<String, Int32> players) { }

	[Address(RVA = "0x1CEBC60", Offset = "0x1CEB060", Length = "0x289")]
	[Token(Token = "0x600037C")]
	public void SetupDiPointFactor(GameAddPoints ttable, int nstage, int nround = 0, float spoint = 0) { }

	[Address(RVA = "0x1CEBEF0", Offset = "0x1CEB2F0", Length = "0x90")]
	[Token(Token = "0x6000296")]
	public void SetupDirector(PlayableDirector _stage, PlayStage torder = 0) { }

	[Address(RVA = "0x1CEBF90", Offset = "0x1CEB390", Length = "0x8A")]
	[IteratorStateMachine(typeof(<SetupEffect>d__9))]
	[Token(Token = "0x6000286")]
	public IEnumerator SetupEffect(PrefabPacks packs) { }

	[Address(RVA = "0x1CEC020", Offset = "0x1CEB420", Length = "0x8A")]
	[IteratorStateMachine(typeof(<SetupEnemyModel>d__19))]
	[Token(Token = "0x6000290")]
	public IEnumerator SetupEnemyModel(Dictionary<String, Int32> tdic) { }

	[Address(RVA = "0x1CEC0B0", Offset = "0x1CEB4B0", Length = "0x51")]
	[Token(Token = "0x6000385")]
	public void SetupExtendsFactor(ExtendScores exscores) { }

	[Address(RVA = "0x1CEC110", Offset = "0x1CEB510", Length = "0x17")]
	[Token(Token = "0x6000390")]
	public void SetupNextStage() { }

	[Address(RVA = "0x1CEC130", Offset = "0x1CEB530", Length = "0x8A")]
	[IteratorStateMachine(typeof(<SetupPlayerModel>d__17))]
	[Token(Token = "0x600028E")]
	public IEnumerator SetupPlayerModel(Dictionary<String, Int32> tdic) { }

	[Address(RVA = "0x1CEC1C0", Offset = "0x1CEB5C0", Length = "0x8A")]
	[IteratorStateMachine(typeof(<SetupRoute>d__21))]
	[Token(Token = "0x6000292")]
	public IEnumerator SetupRoute(Dictionary<String, Int32> _routeNames) { }

	[Address(RVA = "0x1CEC250", Offset = "0x1CEB650", Length = "0x8A")]
	[IteratorStateMachine(typeof(<SetupRuins>d__22))]
	[Token(Token = "0x6000293")]
	public IEnumerator SetupRuins(Dictionary<String, Int32> _ruinNames) { }

	[Address(RVA = "0x1CEC2E0", Offset = "0x1CEB6E0", Length = "0x7E")]
	[Token(Token = "0x6000295")]
	public void SetupStageParameter(int numStock, int numBomber, float damageMag, bool skipReset = false) { }

	[Address(RVA = "0x1CEC360", Offset = "0x1CEB760", Length = "0x6D")]
	[IteratorStateMachine(typeof(<ShowErrorMessage>d__11))]
	[Token(Token = "0x6000288")]
	public IEnumerator ShowErrorMessage() { }

	[Address(RVA = "0x1CEC3D0", Offset = "0x1CEB7D0", Length = "0x20C")]
	[Token(Token = "0x6000329")]
	public void StartRushBonus(List<PawnEnemy> penemys, int tmul) { }

	[Address(RVA = "0x1CEC5E0", Offset = "0x1CEB9E0", Length = "0x7C")]
	[IteratorStateMachine(typeof(<StartStage>d__504))]
	[Token(Token = "0x600038E")]
	public IEnumerator StartStage(Phase tphase = 1) { }

	[Address(RVA = "0x1CEC660", Offset = "0x1CEBA60", Length = "0x7E")]
	[Token(Token = "0x6000391")]
	public void StopStage() { }

	[Address(RVA = "0x1CEC6E0", Offset = "0x1CEBAE0", Length = "0xA8")]
	[Token(Token = "0x600033A")]
	public Kind TableItemDrop() { }

	[Address(RVA = "0x1CECD10", Offset = "0x1CEC110", Length = "0x536")]
	[Token(Token = "0x600027E")]
	public void Terminate() { }

	[Address(RVA = "0x1CEC790", Offset = "0x1CEBB90", Length = "0x57B")]
	[Token(Token = "0x6000282")]
	public void TerminateSubManagers(bool withNext = false) { }

	[Address(RVA = "0x1CEE140", Offset = "0x1CED540", Length = "0x41C")]
	[Token(Token = "0x60003A5")]
	private void Update() { }

	[Address(RVA = "0x1CED330", Offset = "0x1CEC730", Length = "0x148")]
	[Token(Token = "0x6000382")]
	public void UpdateDiPointStage(int nstage, int nround) { }

	[Address(RVA = "0x1CED480", Offset = "0x1CEC880", Length = "0x5E")]
	[Token(Token = "0x60003AC")]
	protected void UpdateDisplay() { }

	[Address(RVA = "0x1CED4E0", Offset = "0x1CEC8E0", Length = "0x243")]
	[Token(Token = "0x6000318")]
	public void UpdateGameSetting() { }

	[Address(RVA = "0x1CED730", Offset = "0x1CECB30", Length = "0x1B4")]
	[Token(Token = "0x6000378")]
	public void UpdateParamsByPlayMode(PlayMode tmode, PlayActor tactor) { }

	[Address(RVA = "0x1CED8F0", Offset = "0x1CECCF0", Length = "0x15B")]
	[Token(Token = "0x60003A4")]
	public void UpdatePlayerBonusMul() { }

	[Address(RVA = "0x1CEDA50", Offset = "0x1CECE50", Length = "0x4F4")]
	[Token(Token = "0x600034A")]
	public void UpdatePlayerPosition(int p, Vector3 wpos) { }

	[Address(RVA = "0x1CEDF50", Offset = "0x1CED350", Length = "0x126")]
	[Token(Token = "0x60003A7")]
	public void UpdateSlideRate(float srate) { }

	[Address(RVA = "0x1CEE080", Offset = "0x1CED480", Length = "0xBA")]
	[Token(Token = "0x600028D")]
	public void UpdateTimeRate(bool isForce) { }

	[Address(RVA = "0x1CEE560", Offset = "0x1CED960", Length = "0x100")]
	[Token(Token = "0x6000317")]
	public void VibrationPlayer(float lpow, float hpow, float tsec) { }

	[Address(RVA = "0x1CEE670", Offset = "0x1CEDA70", Length = "0x488")]
	[Token(Token = "0x60002F0")]
	private Vector3 ViewportToPlanePos(Vector3 spos) { }

	[Address(RVA = "0x1CEEB00", Offset = "0x1CEDF00", Length = "0x6D")]
	[IteratorStateMachine(typeof(<WaitSubManabgersEnd>d__6))]
	[Token(Token = "0x6000283")]
	public IEnumerator WaitSubManabgersEnd() { }

}

