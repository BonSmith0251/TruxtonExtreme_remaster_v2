namespace TXEKernel.Sound;

[Token(Token = "0x2000121")]
public class SoundUtility : SimpleSingleton<SoundUtility>
{
	[CompilerGenerated]
	[Token(Token = "0x200012D")]
	private sealed class <AfterLoadBGM>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008B0")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008B1")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008B2")]
		public float twait; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008B3")]
		public Action tcallback; //Field offset: 0x28

		[Token(Token = "0x1700023C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600084A")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700023D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600084C")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000847")]
		public <AfterLoadBGM>d__18(int <>1__state) { }

		[Address(RVA = "0x2728630", Offset = "0x2727A30", Length = "0x163")]
		[Token(Token = "0x6000849")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600084A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600084C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x27287A0", Offset = "0x2727BA0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600084B")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000848")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000130")]
	private sealed class <AfterLoads>d__17 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008BC")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008BD")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008BE")]
		public Action tcallback; //Field offset: 0x20

		[Token(Token = "0x17000242")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600085C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000243")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600085E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000859")]
		public <AfterLoads>d__17(int <>1__state) { }

		[Address(RVA = "0x2728C20", Offset = "0x2728020", Length = "0x23C")]
		[Token(Token = "0x600085B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600085C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600085E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2728E60", Offset = "0x2728260", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600085D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600085A")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012E")]
	private sealed class <AfterLoadSEComic>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008B4")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008B5")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008B6")]
		public Action endCallback; //Field offset: 0x20

		[Token(Token = "0x1700023E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000850")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700023F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000852")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600084D")]
		public <AfterLoadSEComic>d__21(int <>1__state) { }

		[Address(RVA = "0x27287E0", Offset = "0x2727BE0", Length = "0x1A5")]
		[Token(Token = "0x600084F")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000850")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000852")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2728990", Offset = "0x2727D90", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000851")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600084E")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012F")]
	private sealed class <AfterLoadSEInGame>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008B7")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008B8")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008B9")]
		public float twait; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008BA")]
		public Action startCallback; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40008BB")]
		public Action endCallback; //Field offset: 0x30

		[Token(Token = "0x17000240")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000856")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000241")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000858")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000853")]
		public <AfterLoadSEInGame>d__19(int <>1__state) { }

		[Address(RVA = "0x27289D0", Offset = "0x2727DD0", Length = "0x20E")]
		[Token(Token = "0x6000855")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000856")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000858")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2728BE0", Offset = "0x2727FE0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000857")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000854")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000131")]
	private struct <LoadClip>d__57 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008BF")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008C0")]
		public AsyncUniTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008C1")]
		public string bpath; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008C2")]
		private string <tpath>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40008C3")]
		private Awaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x2728F40", Offset = "0x2728340", Length = "0x565")]
		[Token(Token = "0x600085F")]
		private override void MoveNext() { }

		[Address(RVA = "0x27294B0", Offset = "0x27288B0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000860")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000132")]
	private struct <LoadClips>d__58 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008C4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008C5")]
		public AsyncUniTaskMethodBuilder<Int32[]> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008C6")]
		public List<String> filenames; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008C7")]
		private Awaiter<Int32[]> <>u__1; //Field offset: 0x28

		[Address(RVA = "0x2729500", Offset = "0x2728900", Length = "0x87C")]
		[Token(Token = "0x6000861")]
		private override void MoveNext() { }

		[Address(RVA = "0x2729D80", Offset = "0x2729180", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000862")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000133")]
	private sealed class <Setup>d__16 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008C8")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008C9")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008CA")]
		public SoundDataBaseRecords db; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008CB")]
		private SoundUtility <su>5__2; //Field offset: 0x28

		[Token(Token = "0x17000244")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000866")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000245")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000868")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000863")]
		public <Setup>d__16(int <>1__state) { }

		[Address(RVA = "0x272B180", Offset = "0x272A580", Length = "0x17A")]
		[Token(Token = "0x6000865")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000866")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000868")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x272B300", Offset = "0x272A700", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000867")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000864")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000134")]
	private sealed class <SetupBGM>d__26 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008CC")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008CD")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008CE")]
		public SoundUtility <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008CF")]
		private Awaiter<Int32[]> <loadTask>5__2; //Field offset: 0x28

		[Token(Token = "0x17000246")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600086C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000247")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600086E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000869")]
		public <SetupBGM>d__26(int <>1__state) { }

		[Address(RVA = "0x272A490", Offset = "0x2729890", Length = "0x468")]
		[Token(Token = "0x600086B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600086C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600086E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x272A900", Offset = "0x2729D00", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600086D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600086A")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000135")]
	private sealed class <SetupSE>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008D0")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008D1")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008D2")]
		public int nstart; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40008D3")]
		public int nend; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008D4")]
		public SoundUtility <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40008D5")]
		public SCType skind; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40008D6")]
		private Awaiter<Int32[]> <loadTask>5__2; //Field offset: 0x38

		[Token(Token = "0x17000248")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000872")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000249")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000874")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600086F")]
		public <SetupSE>d__25(int <>1__state) { }

		[Address(RVA = "0x272A940", Offset = "0x2729D40", Length = "0x486")]
		[Token(Token = "0x6000871")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000872")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000874")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x272ADD0", Offset = "0x272A1D0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000873")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000870")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000136")]
	private sealed class <SetupSystem>d__24 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008D7")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008D8")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008D9")]
		public SoundUtility <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008DA")]
		public SoundDataBaseRecords db; //Field offset: 0x28

		[Token(Token = "0x1700024A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000878")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700024B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600087A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000875")]
		public <SetupSystem>d__24(int <>1__state) { }

		[Address(RVA = "0x272AE10", Offset = "0x272A210", Length = "0x32A")]
		[Token(Token = "0x6000877")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000878")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600087A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x272B140", Offset = "0x272A540", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000879")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000876")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000124")]
	internal enum BGM : int
	{
		none = -1,
		txe_bgm_b000 = 0,
		txe_bgm_f000 = 1,
		txe_bgm_d000 = 2,
		tatsujin_bgm_st1_opening_loop = 3,
		tatsujin_bgm_st1_loop = 4,
		tatsujin_bgm_st2_loop = 5,
		tatsujin_bgm_st3_loop = 6,
		tatsujin_bgm_st4_loop = 7,
		tatsujin_bgm_st5_loop = 8,
		tatsujin_bgm_boss_intro_loop = 9,
		tatsujin_bgm_boss_loop = 10,
		tatsujin_oh_bgm_st1_loop = 11,
		tatsujin_oh_bgm_st2_intro_loop = 12,
		tatsujin_oh_bgm_st2_loop = 13,
		tatsujin_oh_bgm_st3_loop = 14,
		tatsujin_oh_bgm_st4_intro_loop = 15,
		tatsujin_oh_bgm_st4_loop = 16,
		tatsujin_oh_bgm_st5_intro_loop = 17,
		tatsujin_oh_bgm_st5_loop = 18,
		tatsujin_oh_bgm_st6_intro_loop = 19,
		tatsujin_oh_bgm_st6_loop = 20,
		tatsujin_oh_bgm_boss_intro_loop = 21,
		tatsujin_oh_bgm_boss_loop = 22,
		txe_bgm_w000 = 23,
		txe_bgm_o000 = 24,
		txe_bgm_c001_01 = 25,
		txe_bgm_c002_01 = 26,
		txe_bgm_c003_01 = 27,
		txe_bgm_c004_01 = 28,
		txe_bgm_c005_01 = 29,
		txe_bgm_c005_02 = 30,
		txe_bgm_c006_01 = 31,
		txe_bgm_c007_01 = 32,
		txe_bgm_c007_02 = 33,
		txe_bgm_c007_03 = 34,
		txe_bgm_c007_04 = 35,
		txe_bgm_c008_01 = 36,
		txe_bgm_c009_01 = 37,
		txe_bgm_c010_01 = 38,
		txe_bgm_c011_01 = 39,
		txe_bgm_c012_01 = 40,
		txe_bgm_c013_01 = 41,
		txe_bgm_c014_01 = 42,
		txe_bgm_c015_01 = 43,
		txe_bgm_f001 = 44,
		txe_bgm_r000 = 45,
		txe_bgm_p001_01 = 46,
		txe_bgm_p002_01 = 47,
		txe_bgm_p003_01 = 48,
		txe_bgm_p004_01 = 49,
		txe_bgm_p005_01 = 50,
		txe_bgm_f002 = 51,
		txe_bgm_f003 = 52,
		txe_bgm_c016_01 = 53,
		txe_bgm_c017_01 = 54,
		txe_bgm_o001 = 55,
		txe_bgm_i000 = 56,
		txe_bgm_c018_01 = 57,
		txe_bgm_f004 = 58,
		txe_bgm_f005 = 59,
		txe_bgm_f006 = 60,
		txe_bgm_f007 = 61,
		txe_bgm_o002 = 62,
		batsugun_bgm_st1_loop = 63,
		batsugun_bgm_st1_boss_intro_loop = 64,
		batsugun_bgm_st1_boss_loop = 65,
		batsugun_bgm_st2_loop = 66,
		batsugun_bgm_st2_boss_intro_loop = 67,
		batsugun_bgm_st2_boss_loop = 68,
		batsugun_bgm_st3_loop = 69,
		batsugun_bgm_st3_boss_loop = 70,
		batsugun_bgm_st4_intro_loop = 71,
		batsugun_bgm_st4_loop = 72,
		batsugun_bgm_st4_boss_loop = 73,
		batsugun_bgm_st5_loop = 74,
		batsugun_bgm_st5_boss_loop = 75,
		batsugun_bgm_gameover = 76,
		batsugun_bgm_result = 77,
		txe_bgm_o003 = 78,
		txe_bgm_f008 = 79,
		txe_bgm_f009 = 80,
		txe_bgm_a000 = 81,
		txe_bgm_f010 = 82,
		txe_bgm_f011 = 83,
		txe_bgm_f012 = 84,
		txe_bgm_f013 = 85,
		txe_bgm_f014 = 86,
		txe_bgm_f015 = 87,
		txe_bgm_r001 = 88,
		txe_bgm_i001 = 89,
		txe_bgm_f016 = 90,
		txe_bgm_f017 = 91,
		txe_bgm_f018 = 92,
		txe_bgm_f019 = 93,
		txe_bgm_f020 = 94,
		txe_bgm_f021 = 95,
		txe_bgm_f022 = 96,
		txe_bgm_f023 = 97,
		txe_bgm_f024 = 98,
		txe_bgm_f025 = 99,
		txe_bgm_f026 = 100,
		txe_bgm_f027 = 101,
		txe_bgm_f028 = 102,
		txe_bgm_f029 = 103,
		txe_bgm_f030 = 104,
		txe_bgm_f031 = 105,
		txe_bgm_f032 = 106,
		txe_bgm_f033 = 107,
		txe_bgm_f034 = 108,
		txe_bgm_f035 = 109,
		tatsujin_bgm_gameover = 110,
		tatsujin_bgm_name_entry = 111,
		tatsujin_oh_bgm_gameover = 112,
		tatsujin_oh_bgm_continue = 113,
		txe_bgm_o004 = 114,
		txe_bgm_f036 = 115,
		txe_bgm_f037 = 116,
		txe_bgm_f038 = 117,
		txe_bgm_f039 = 118,
		txe_bgm_f040 = 119,
		txe_bgm_f041 = 120,
		txe_bgm_f042 = 121,
		txe_bgm_f043 = 122,
		txe_bgm_f044 = 123,
		txe_bgm_f045 = 124,
		txe_bgm_f046 = 125,
		txe_bgm_f047 = 126,
	}

	[Token(Token = "0x200012C")]
	internal enum BossBGM : int
	{
		none = -1,
		txe_bgm_b000 = 0,
		txe_bgm_heavylong_intro = 108,
		txe_bgm_heavylong = 109,
		ttj_bgm_boss = 9,
		toh_bgm_boss = 21,
		btg_bgm_darkecho_intro = 64,
		btg_bgm_kingbird_intro = 67,
		btg_bgm_psychoparanoia = 70,
		btg_bgm_yokan = 73,
		btg_bgm_finalattack = 75,
	}

	[Token(Token = "0x2000127")]
	internal enum BulletSE : int
	{
		none = -1,
		Bullet001 = 115,
		Bullet002 = 116,
		Bullet003 = 117,
		Bullet004 = 118,
		Bullet005 = 119,
		Bullet006 = 120,
		Bullet007 = 121,
		Bullet008 = 122,
		Bullet009 = 123,
		Bullet010 = 124,
		Bullet011 = 125,
		Bullet011s = 128,
		Bullet012 = 126,
		Bullet013 = 106,
		Bullet100 = 127,
	}

	[Token(Token = "0x200012A")]
	internal enum ExpSound : int
	{
		none = -1,
		exp_fighter = 0,
		exp_L1 = 1,
		exp_L2 = 2,
		exp_L3 = 198,
		exp_L4 = 199,
		exp_L5 = 200,
		exp_M1 = 3,
		exp_M2 = 4,
		exp_S1 = 5,
		exp_S2 = 6,
		exp_S3 = 34,
		exp_S4 = 35,
		exp_S5 = 194,
		exp_S6 = 195,
		exp_S7 = 196,
		exp_S8 = 197,
		meteor_exp_s1_01 = 207,
		meteor_exp_s2_01 = 208,
		meteor_exp_m1_01 = 209,
		bg4_ene_mi01_break_01 = 164,
		bg8_boss01_legbreaks_r_01 = 156,
		bg8_boss01_legbreaks_l_01 = 157,
		exp_st3_boss = 17,
		exp_st3_boss_a01 = 40,
		exp_st3_boss_b02 = 41,
		exp_st3_boss_c03 = 42,
		exp_bg4_boss_a01 = 60,
		exp_pf_ene_mc01_01 = 202,
		exp_pf_ene_bma01_bsd01_01 = 203,
		exp_pf_ene_md01_01 = 204,
		exp_pf_ene_mg01_01 = 205,
		exp_pf_ene_mx01_01 = 206,
		exp_pf_ene_bsa_bsb_bsc01_01 = 213,
		ene_x1_exp_01 = 171,
		ene_x2_exp_01 = 172,
		ene_x3_exp_01 = 173,
		exp_pf_item_box_all_01 = 214,
		exp_bg_obj_colorbox_all_01 = 215,
		exp_pf_ene_sn_01 = 216,
		exp_pf_ene_sv_01 = 217,
		exp_pf_ene_mj01_all_01 = 218,
		exp_pf_ene_sd01_01 = 219,
		exp_pf_ene_sl01_01 = 220,
		exp_pf_ene_sf01_01 = 221,
		exp_pf_ene_mf01_01 = 222,
		exp_pf_ene_mp01_01 = 223,
		exp_pf_ene_tsa01_01 = 224,
		ene_mk_dead_01 = 238,
		exp_secret = 229,
	}

	[Token(Token = "0x2000123")]
	internal enum ID : int
	{
		none = -1,
		exp_fighter = 0,
		exp_L1 = 1,
		exp_L2 = 2,
		exp_M1 = 3,
		exp_M2 = 4,
		exp_S1 = 5,
		exp_S2 = 6,
		trophy_release_01 = 7,
		laser_loop = 8,
		powershot = 9,
		bomb_def_01 = 10,
		homingshot = 11,
		tatsujin_beam = 12,
		speed_down = 13,
		shot_powerup = 14,
		enemy_shot_01 = 15,
		enemy_beam_01 = 16,
		exp_st3_boss = 17,
		enemy_hit_01 = 18,
		st3_boss_app_01 = 19,
		item_speedup = 20,
		item_bomb = 21,
		item_2up_01 = 22,
		item_3up_01 = 23,
		st3_boss_beam_loop_l = 24,
		st3_boss_beam_loop_r = 25,
		st3_boss_shot_01_l = 26,
		st3_boss_shot_01_r = 27,
		enemy_beam_charge_01 = 28,
		enemy_beam_loop_01 = 29,
		item_def = 30,
		item_5000p = 31,
		speed_up = 32,
		weapon_change_on = 33,
		exp_S3 = 34,
		exp_S4 = 35,
		wallshot = 36,
		growshot = 37,
		bomb_lv2_01 = 38,
		bomb_lv3_01 = 39,
		exp_st3_boss_a01 = 40,
		exp_st3_boss_b02 = 41,
		exp_st3_boss_c03 = 42,
		exit_fighter_01 = 43,
		landing_demo_se_01 = 44,
		result_environment_01 = 45,
		result_open_01 = 46,
		result_score_success_01 = 47,
		result_score_display_01 = 48,
		result_score_count_a01 = 49,
		result_score_count_b01 = 50,
		bg4_base_gate_open_a01 = 51,
		bg4_base_gate_open_b01 = 52,
		bg4_base_gate_open_c01 = 53,
		bg4_boss_app_01 = 54,
		bg4_boss_cannon_01 = 55,
		bg4_boss_charge_01 = 56,
		bg4_boss_beam_01 = 57,
		bg4_boss_wing_open_01 = 58,
		bg4_boss_wing_close_01 = 59,
		exp_bg4_boss_a01 = 60,
		bg2_boss_app_01 = 61,
		bg2_boss_main_gun_move_01 = 62,
		bg2_boss_beam_charge_01 = 63,
		bg2_boss_beam_charge_02 = 64,
		bg2_boss_beam_01 = 65,
		bg2_boss_beam_02 = 66,
		bg2_boss_laser_01 = 67,
		bg2_boss_parts_destruction_r = 68,
		bg2_boss_parts_destruction_l = 69,
		bg2_boss_mainwing_operating = 70,
		bg2_boss_cannon_move_01 = 71,
		bg3_boss_beam_charge_01 = 72,
		bg3_boss_beam_01 = 73,
		bg5_boss_app_01 = 74,
		bg5_boss_turning_01 = 75,
		bg5_boss_shot_pink_01 = 76,
		bg5_boss_parts_firing_01 = 77,
		bg5_boss_parts_return_01 = 78,
		bg5_boss_cannon_01 = 79,
		bg5_boss_charge_01 = 80,
		bg5_boss_beam_01 = 81,
		bg5_boss_beam_02 = 82,
		bg8_fortress_app_01 = 83,
		app_fighter = 84,
		bg7_boss_app_01 = 85,
		bg7_boss_open_arm_01 = 86,
		bg7_boss_close_arm_01 = 87,
		bg7_boss_unit_rotation_01 = 88,
		bg7_boss_unit_exp_01 = 89,
		bg7_boss_main_gun_cocking_01 = 90,
		bg7_boss_main_gun_shot_01 = 91,
		bg7_boss_main_gun_shot_exp_01 = 92,
		bg4_boss_rushing_01 = 93,
		bg4_boss_app_above_01 = 94,
		bg4_boss_app_rising_01 = 95,
		bg4_boss_transformation_01 = 96,
		bg4_boss_transformation_02 = 97,
		bg4_boss_unit_rotation_01 = 98,
		bg4_boss_tornado_bullet_01 = 99,
		bg1_boss_mothership_01 = 100,
		bg1_boss_mothership_02 = 101,
		bg1_boss_app_01 = 102,
		bg1_boss_charge_01 = 103,
		bg1_boss_beam_01 = 104,
		bg1_boss_wing_open_01 = 105,
		enemybullet013_01 = 106,
		bg1_boss_wing_close_01 = 107,
		pipiru_shot_pws_01 = 108,
		pipiru_shot_thl_01 = 109,
		pipiru_shot_tsb_01 = 110,
		pipiru_shot_hms_01 = 111,
		pipiru_shot_grs_01 = 112,
		pipiru_shot_wls_01 = 113,
		warp_st_item_a_01 = 114,
		enemybullet001_01 = 115,
		enemybullet002_01 = 116,
		enemybullet003_01 = 117,
		enemybullet004_01 = 118,
		enemybullet005_01 = 119,
		enemybullet006_01 = 120,
		enemybullet007_01 = 121,
		enemybullet008_01 = 122,
		enemybullet009_01 = 123,
		enemybullet010_01 = 124,
		enemybullet011_01 = 125,
		enemybullet012_01 = 126,
		enemybullet100_01 = 127,
		enemybullet011s_01 = 128,
		bg7_boss_parts_destruction_01 = 129,
		bg7_boss_move_the_bow_01 = 130,
		bg7_boss_rise_01 = 131,
		bg7_boss_separation_01 = 132,
		bg7_boss_move_01 = 133,
		bg7_boss_gattai_01 = 134,
		bg7_bg_gmk01_r_01 = 135,
		bg7_bg_gmk01_l_01 = 136,
		bg7_bg_gmk02_l_to_r_1_01 = 137,
		bg7_bg_gmk02_l_to_r_2_01 = 138,
		bg7_bg_gmk02_l_to_r_3_01 = 139,
		bg7_bg_gmk02_r_to_l_1_01 = 140,
		bg7_bg_gmk02_r_to_l_2_01 = 141,
		bg6_tank_start_loop_01 = 142,
		bg6_tank_stop_01 = 143,
		bg6_tank_battery_01 = 144,
		enemy_before_combination_01 = 145,
		enemy_combination_01 = 146,
		enemy_electromagnetic_01 = 147,
		bg4_fish_bite_01 = 148,
		bg8_boss01_app_01 = 149,
		bg8_boss01_app_cry1_01 = 150,
		bg8_boss01_app_cry2_01 = 151,
		bg8_boss01_damage_cry_r_01 = 152,
		bg8_boss01_damage_cry_l_01 = 153,
		bg8_boss01_dead_cry_01 = 154,
		bg8_boss01_turning1_01 = 155,
		bg8_boss01_legbreaks_r_01 = 156,
		bg8_boss01_legbreaks_l_01 = 157,
		bg8_boss02_app_01 = 158,
		bg8_boss02_app_stop_01 = 159,
		bg8_boss02_leg_spreading_01 = 160,
		bg8_boss02_leg_spreading_02 = 161,
		bg8_boss02_leg_closing_01 = 162,
		bg8_boss02_flying_01 = 163,
		bg4_ene_mi01_break_01 = 164,
		bg8_spear_out_01 = 165,
		bg8_spear_back_01 = 166,
		bg5_ene_mk_hit_01 = 167,
		ene_x1_app_01 = 168,
		ene_x2_app_01 = 169,
		ene_x3_app_01 = 170,
		ene_x1_exp_01 = 171,
		ene_x2_exp_01 = 172,
		ene_x3_exp_01 = 173,
		ene_sl_mp_beam_charge_01 = 174,
		ene_sl_mp_beam_loop_01 = 175,
		bg1_spacestation_env_01 = 176,
		boss_defeat01_01 = 177,
		ene_mb01_move_01 = 178,
		bg2_battleship_move_l_01 = 179,
		bg2_battleship_move_c_01 = 180,
		bg2_battleship_move_r_01 = 181,
		bg4_deepsea_base_01 = 182,
		bg5_boss_tentacle_01 = 183,
		bg2_ene_mj01_head_stop_l_01 = 184,
		bg2_ene_mj01_head_stop_r_01 = 185,
		bg1_ene_ss_01 = 186,
		pipiru_mode_obj_app_01 = 187,
		pipiru_mode_stage_change_01 = 188,
		pipiru_mode_obj_disapp_01 = 189,
		bg8_boss02_magic_circle_01 = 190,
		bg1_ene_mq_app_01 = 191,
		bg7_boss_main_gun_cocking_02 = 192,
		bg8_boss03_app_01 = 193,
		exp_S5 = 194,
		exp_S6 = 195,
		exp_S7 = 196,
		exp_S8 = 197,
		exp_L3 = 198,
		exp_L4 = 199,
		exp_L5 = 200,
		exp_L6 = 201,
		exp_pf_ene_mc01_01 = 202,
		exp_pf_ene_bma01_bsd01_01 = 203,
		exp_pf_ene_md01_01 = 204,
		exp_pf_ene_mg01_01 = 205,
		exp_pf_ene_mx01_01 = 206,
		meteor_exp_s1_01 = 207,
		meteor_exp_s2_01 = 208,
		meteor_exp_m1_01 = 209,
		bg3_boss_move_descent_01 = 210,
		bg3_boss_move_rise_01 = 211,
		boss_parts_destruction_g_01 = 212,
		exp_pf_ene_bsa_bsb_bsc01_01 = 213,
		exp_pf_item_box_all_01 = 214,
		exp_bg_obj_colorbox_all_01 = 215,
		exp_pf_ene_sn_01 = 216,
		exp_pf_ene_sv_01 = 217,
		exp_pf_ene_mj01_all_01 = 218,
		exp_pf_ene_sd01_01 = 219,
		exp_pf_ene_sl01_01 = 220,
		exp_pf_ene_sf01_01 = 221,
		exp_pf_ene_mf01_01 = 222,
		exp_pf_ene_mp01_01 = 223,
		exp_pf_ene_tsa01_01 = 224,
		result_end_01 = 225,
		result_achievement_normal_01 = 226,
		result_achievement_ssr_01 = 227,
		item_1up_01 = 228,
		se_Jewel_app_01 = 229,
		se_Jewel_capture_01 = 230,
		pipiru_mode_level_eff_01 = 231,
		arena_count_01 = 232,
		boss8a_escape_01 = 233,
		boss8a_camera_out_01 = 234,
		boss8b_hovering_01 = 235,
		boss8c_beam_loop_01 = 236,
		bg7_boss_close_arm_02 = 237,
		ene_mk_dead_01 = 238,
		black_laser_01 = 239,
		bg8_start_se_01 = 240,
		bg4_boss_ene_sg_injection_01 = 241,
		powershot_lv1 = 242,
		powershot_lv2 = 243,
		powershot_lv3 = 244,
		powershot_lv4 = 245,
		tatsujin_beam_lv1 = 246,
		tatsujin_beam_lv2 = 247,
		tatsujin_beam_lv3 = 248,
		tatsujin_beam_lv4 = 249,
		thunder_laser_lv1 = 250,
		thunder_laser_lv2 = 251,
		thunder_laser_lv3 = 252,
		thunder_laser_lv4 = 253,
		gold_laser_lv1 = 254,
		gold_laser_lv2 = 255,
		gold_laser_lv3 = 256,
		gold_laser_lv4 = 257,
		homingshot_lv1 = 258,
		homingshot_lv2 = 259,
		homingshot_lv3 = 260,
		homingshot_lv4 = 261,
		starmine_lv1 = 262,
		starmine_lv2 = 263,
		starmine_lv3 = 264,
		starmine_lv4 = 265,
		black_laser_lv1 = 266,
		black_laser_lv2 = 267,
		black_laser_lv3 = 268,
		black_laser_lv4 = 269,
		item_1000p = 270,
		txe_se_c001_01 = 1000,
		txe_se_c002_01 = 1001,
		txe_se_c006_01 = 1002,
		txe_se_c007_01 = 1003,
		txe_se_c007_03 = 1004,
		txe_se_c008_02 = 1005,
		txe_se_c009_01 = 1006,
		txe_se_c011_01 = 1007,
		txe_se_c012_01 = 1008,
		txe_se_c013_01 = 1009,
		txe_se_c013_02 = 1010,
		txe_se_c014_01 = 1011,
		txe_se_c021_01 = 1012,
		txe_se_c024_01 = 1013,
		txe_se_c025_01 = 1014,
		txe_se_c026_01 = 1015,
		txe_se_c028_01 = 1016,
		txe_se_c028_02 = 1017,
		txe_se_c029_01 = 1018,
		txe_se_c029_02 = 1019,
		txe_se_c030_01 = 1020,
		txe_se_c030_02 = 1021,
		txe_se_c030_03 = 1022,
		txe_se_c031_01 = 1023,
		txe_se_c032_01 = 1024,
		txe_se_c033_01 = 1025,
		txe_se_c034_01 = 1026,
		txe_se_c035_01 = 1027,
		txe_se_c036_01 = 1028,
		txe_se_c037_01 = 1029,
		txe_se_c039_01 = 1030,
		txe_se_c040_01 = 1031,
		txe_se_c041_01 = 1032,
		txe_se_c043_01 = 1033,
		txe_se_c044_01 = 1034,
		txe_se_c045_01 = 1035,
		txe_se_c046_01 = 1036,
		txe_se_c047_01 = 1037,
		txe_se_c048_01 = 1038,
		txe_se_c048_02 = 1039,
		txe_se_c048_03 = 1040,
		txe_se_c049_01 = 1041,
		txe_se_c049_02 = 1042,
		txe_se_c050_01 = 1043,
		txe_se_c051_01 = 1044,
		txe_se_c052_01 = 1045,
		txe_se_c053_01 = 1046,
		txe_se_c053_02 = 1047,
		txe_se_c054_01 = 1048,
		txe_se_c056_01 = 1049,
		txe_se_c057_01 = 1050,
		txe_se_c058_01 = 1051,
		txe_se_c059_01 = 1052,
		txe_se_c060_01 = 1053,
		txe_se_c061_01 = 1054,
		txe_se_c062_01 = 1055,
		txe_se_c063_01 = 1056,
		txe_se_c063_02 = 1057,
		txe_se_c064_01 = 1058,
		txe_se_c067_01 = 1059,
		txe_se_c068_01 = 1060,
		txe_se_c069_01 = 1061,
		txe_se_c070_01 = 1062,
		txe_se_c071_01 = 1063,
		txe_se_c073_01 = 1064,
		txe_se_c074_01 = 1065,
		txe_se_c075_01 = 1066,
		txe_se_c076_01 = 1067,
		txe_se_c077_01 = 1068,
		txe_se_c079_01 = 1069,
		txe_se_c080_01 = 1070,
		txe_se_c083_01 = 1071,
		txe_se_c084_01 = 1072,
		txe_se_c085_01 = 1073,
		txe_se_c086_01 = 1074,
		txe_se_c100_01 = 1075,
		txe_se_c101_01 = 1076,
		txe_se_c102_01 = 1077,
		txe_se_c105_01 = 1078,
		txe_se_c106_01 = 1079,
		txe_se_c108_01 = 1080,
		txe_se_c109_01 = 1081,
		txe_se_c110_01 = 1082,
		txe_se_c111_01 = 1083,
		txe_se_c112_01 = 1084,
		txe_se_c113_01 = 1085,
		txe_se_c114_01 = 1086,
		txe_se_c115_01 = 1087,
		txe_se_c116_01 = 1088,
		txe_se_c117_01 = 1089,
		txe_se_c118_01 = 1090,
		txe_se_c119_01 = 1091,
		txe_se_c120_01 = 1092,
		txe_se_c121_01 = 1093,
		txe_se_c122_01 = 1094,
		txe_se_c123_01 = 1095,
		txe_se_c124_01 = 1096,
		txe_se_c125_01 = 1097,
		txe_se_c126_01 = 1098,
		txe_se_c127_01 = 1099,
		txe_se_c128_01 = 1100,
		txe_se_c129_01 = 1101,
		txe_se_c130_01 = 1102,
		txe_se_c131_01 = 1103,
		txe_se_c132_01 = 1104,
		txe_se_c133_01 = 1105,
		txe_se_c134_01 = 1106,
		txe_se_c135_01 = 1107,
		txe_se_c136_01 = 1108,
		txe_se_c137_01 = 1109,
		txe_se_c138_01_a03_p05_02_ui = 1110,
		txe_se_c139_01_b04_p04_01_ui = 1111,
		txe_se_c140_01_a03_p04_01_nz = 1112,
		txe_se_c141_01_a04_p03_01 = 1113,
		txe_se_c142_01_b01_p10_02 = 1114,
		txe_se_c143_01_c03_p08_01 = 1115,
		txe_se_c144_01_c03_p09_01 = 1116,
		txe_se_c145_01_c03_p09_02 = 1117,
		txe_se_c146_01_c03_p11_01 = 1118,
		txe_se_c148_01_c06_p14_01 = 1119,
		txe_se_c149_01_c06_p15_01 = 1120,
		txe_se_c150_01_b03_p02_03 = 1121,
		txe_se_c151_01_c06_p09_02 = 1122,
		txe_se_c152_01_a01_p06_03 = 1123,
		txe_se_c153_01_a01_p06_03 = 1124,
		txe_se_c154_01_a01_p13_02 = 1125,
		txe_se_c155_01_a01_p13_02 = 1126,
		txe_se_c156_01_a01_p13_03 = 1127,
		txe_se_c157_01_a01_p13_03 = 1128,
		txe_se_c158_01_a01_p16_01 = 1129,
		txe_se_c159_01_a01_p16_01 = 1130,
		txe_se_c160_01_a01_p16_02 = 1131,
		txe_se_c161_01_a01_p17_02 = 1132,
		txe_se_c162_01_a01_p18_01 = 1133,
		txe_se_c162_01_a01_p18_03 = 1134,
		txe_se_c163_01_a01_p19_01 = 1135,
		txe_se_c164_page_op_01 = 1136,
		txe_se_c165_page_op_01 = 1137,
		txe_se_c166_page_op_key_l_01 = 1138,
		txe_se_c167_page_op_key_r_01 = 1139,
		txe_se_c168_01_a03_p07_02 = 1140,
		txe_se_c169_01_a03_p07_03 = 1141,
		txe_se_c170_01_a03_p08_01 = 1142,
		txe_se_c171_01_a03_p08_02 = 1143,
		txe_se_c172_01_a03_p08_03 = 1144,
		txe_se_c173_01_a03_p08_04 = 1145,
		txe_se_c174_01_a03_p09_01 = 1146,
		txe_se_c175_01_a03_p09_02 = 1147,
		txe_se_c176_01_c05_p11_03 = 1148,
		txe_se_c177_01_a02_p02_01 = 1149,
		txe_se_c178_01_a02_p02_02 = 1150,
		txe_se_c179_01_a05_p04_02 = 1151,
		txe_se_c180_01_a06_p02_01 = 1152,
		txe_se_c181_01_a06_p03_01 = 1153,
		txe_se_c182_01_a06_p04_04 = 1154,
		txe_se_c183_01_a06_p05_01 = 1155,
		txe_se_c184_01_a06_p05_02 = 1156,
		txe_se_c185_01_a06_p08_02 = 1157,
		txe_se_c186_01_b02_p07_03 = 1158,
		txe_se_c187_01_b06_p04_03 = 1159,
		txe_se_c188_01_b06_p04_04 = 1160,
		txe_se_c189_01_a05_p05_01 = 1161,
		txe_se_c190_01_b06_p05_01 = 1162,
		txe_se_c191_01_b06_p01_03 = 1163,
		txe_se_c192_01_b06_p06_03 = 1164,
		txe_se_c193_01_c04_p07_02 = 1165,
		txe_se_c194_01_a05_p03_02 = 1166,
		txe_se_c195_01_a00_p05_02 = 1167,
		txe_se_c196_01_a00_p09_03 = 1168,
		txe_se_c197_01_c03_p12_03 = 1169,
		txe_se_c198_01_c03_p14_03 = 1170,
		txe_se_c199_01_c05_p04_01 = 1171,
		txe_se_c200_01_c05_p05_03 = 1172,
		se_cursor_001 = 2000,
		se_ok_001 = 2001,
		se_cancel_001 = 2002,
		o_game_shutter_close_01 = 2003,
		o_game_shutter_open_01 = 2004,
		se_pause_001 = 2005,
		se_tutorial_ok_001 = 2006,
		se_ok_002 = 2007,
	}

	[Token(Token = "0x200012B")]
	internal enum InGameBGM : int
	{
		none = -1,
		txe_bgm_f000 = 1,
		txe_bgm_f001 = 44,
		txe_bgm_f002 = 51,
		txe_bgm_f003 = 52,
		txe_bgm_f004 = 58,
		txe_bgm_f005 = 59,
		txe_bgm_f006 = 60,
		txe_bgm_f007 = 61,
		txe_bgm_f008 = 79,
		txe_bgm_f009 = 80,
		txe_bgm_f010 = 82,
		txe_bgm_f011 = 83,
		txe_bgm_f012 = 84,
		txe_bgm_f013 = 85,
		txe_bgm_f014 = 86,
		txe_bgm_f015 = 87,
		txe_bgm_f032 = 106,
		txe_bgm_f033 = 107,
		txe_bgm_f034 = 108,
		txe_bgm_f035 = 109,
		txe_bgm_f036 = 115,
		txe_bgm_f037 = 116,
		txe_bgm_f038 = 117,
		txe_bgm_f039 = 118,
		txe_bgm_f040 = 119,
		txe_bgm_f041 = 120,
		txe_bgm_f042 = 121,
		txe_bgm_f043 = 122,
		txe_bgm_f044 = 123,
		txe_bgm_f045 = 124,
		txe_bgm_f046 = 125,
		txe_bgm_f047 = 126,
		ttj_bgm_faraway_op = 3,
		ttj_bgm_faraway = 4,
		ttj_bgm_sally = 5,
		ttj_bgm_hope = 6,
		ttj_bgm_friend = 7,
		ttj_bgm_unknown = 8,
		toh_bgm_liveinfuture = 11,
		toh_bgm_idefendstm_intro = 12,
		toh_bgm_idefendstm = 13,
		toh_bgm_gratify = 14,
		toh_bgm_nodelusion_intro = 15,
		toh_bgm_nodelusion = 16,
		toh_bgm_stillloveyou_intro = 17,
		toh_bgm_stillloveyou = 18,
		toh_bgm_faze_intro = 19,
		toh_bgm_faze = 20,
		btg_bgm_heartbeat = 63,
		btg_bgm_skimsea = 66,
		btg_bgm_bomberdance = 69,
		btg_bgm_compticket_intro = 71,
		btg_bgm_compticket = 72,
		btg_bgm_geofrontier = 74,
	}

	[Token(Token = "0x2000128")]
	internal enum LaserSE : int
	{
		none = -1,
		NChage01 = 28,
		NLoop01 = 29,
		SChage01 = 174,
		SLoop01 = 175,
		LChage01 = 72,
		LLoop01 = 73,
		BG3BossChage01 = 72,
		BG3BossLoop01 = 73,
		ThunderLoop = 8,
	}

	[Token(Token = "0x2000122")]
	internal class NoPlayScope : IDisposable
	{

		[Address(RVA = "0x2720E20", Offset = "0x2720220", Length = "0x85")]
		[Token(Token = "0x600083B")]
		public NoPlayScope() { }

		[Address(RVA = "0x2720DA0", Offset = "0x27201A0", Length = "0x75")]
		[Token(Token = "0x600083C")]
		public override void Dispose() { }

	}

	[Token(Token = "0x2000129")]
	internal enum PLaserSE : int
	{
		blackLv1 = 266,
		blackLv2 = 267,
		blackLv3 = 268,
		blackLv4 = 269,
		goldLv1 = 254,
		goldLv2 = 255,
		goldLv3 = 256,
		goldLv4 = 257,
		thunderLv1 = 250,
		thunderLv2 = 251,
		thunderLv3 = 252,
		thunderLv4 = 253,
	}

	[Token(Token = "0x2000126")]
	private class SoundQueInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000808")]
		private SCType _stype; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000809")]
		private float _volume; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400080A")]
		private float _pan; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400080B")]
		private float _guarantee; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400080C")]
		private int _priority; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400080D")]
		private int _polyphony; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400080E")]
		private bool _isoverlap; //Field offset: 0x28
		[FieldOffset(Offset = "0x29")]
		[Token(Token = "0x400080F")]
		private bool _isoneshot; //Field offset: 0x29

		[Token(Token = "0x17000237")]
		public float Guarantee
		{
			[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
			[Token(Token = "0x6000840")]
			 get { } //Length: 6
		}

		[Token(Token = "0x1700023B")]
		public bool IsOneShot
		{
			[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
			[Token(Token = "0x6000844")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700023A")]
		public bool IsOverlap
		{
			[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
			[Token(Token = "0x6000843")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000236")]
		public float Pan
		{
			[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
			[Token(Token = "0x600083F")]
			 get { } //Length: 6
		}

		[Token(Token = "0x17000239")]
		public int Polyphony
		{
			[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
			[Token(Token = "0x6000842")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000238")]
		public int Priotity
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[Token(Token = "0x6000841")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000234")]
		public SCType SType
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x600083D")]
			 get { } //Length: 85
		}

		[Token(Token = "0x17000235")]
		public float Volume
		{
			[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
			[Token(Token = "0x600083E")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x2722110", Offset = "0x2721510", Length = "0x15")]
		[Token(Token = "0x6000846")]
		public SoundQueInfo() { }

		[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
		[Token(Token = "0x6000840")]
		public float get_Guarantee() { }

		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[Token(Token = "0x6000844")]
		public bool get_IsOneShot() { }

		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000843")]
		public bool get_IsOverlap() { }

		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x600083F")]
		public float get_Pan() { }

		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000842")]
		public int get_Polyphony() { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000841")]
		public int get_Priotity() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600083D")]
		public SCType get_SType() { }

		[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
		[Token(Token = "0x600083E")]
		public float get_Volume() { }

		[Address(RVA = "0x27220D0", Offset = "0x27214D0", Length = "0x37")]
		[Token(Token = "0x6000845")]
		public void Set(SCType stype, float v, float tpan, int tpri, int tpoly, float guarantee, bool isoverlap, bool isoneshot) { }

	}

	[Token(Token = "0x2000125")]
	internal enum VOICE : int
	{
		none = -1,
	}

	[Token(Token = "0x40005AB")]
	private static readonly Dictionary<BGM, BGM> _IntroLoops; //Field offset: 0x0
	[Token(Token = "0x40005BC")]
	private const int _queMax = 128; //Field offset: 0x0
	[Token(Token = "0x40005AC")]
	public static readonly string AudioPath; //Field offset: 0x8
	[Token(Token = "0x40005AD")]
	private static readonly string bgmPath; //Field offset: 0x10
	[Token(Token = "0x40005AE")]
	private static readonly string sePath; //Field offset: 0x18
	[Token(Token = "0x40005AF")]
	private static readonly string comicPath; //Field offset: 0x20
	[Token(Token = "0x40005B0")]
	private static readonly string fileExtend; //Field offset: 0x28
	[Token(Token = "0x40005B1")]
	private static readonly int comicSEStart; //Field offset: 0x30
	[Token(Token = "0x40005B2")]
	private static readonly int systemSEStart; //Field offset: 0x34
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005B3")]
	private SoundManager _manager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005B4")]
	private StagePlayList _playlist; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005B5")]
	private Dictionary<Int32, Int32> _sePalettes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005B6")]
	private Dictionary<Int32, Int32> _bgmPalettes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005B7")]
	private Dictionary<Int32, Record> _seRecords; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005B8")]
	private Dictionary<Int32, Record> _bgmRecords; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005B9")]
	private bool _isEntryRequest; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005BA")]
	private Dictionary<Int32, SoundQueInfo> _requestQue; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005BB")]
	private Dictionary<Int32, Single> _lastPlayTime; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005BD")]
	private int _queCount; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005BE")]
	private SoundQueInfo[] _queStack; //Field offset: 0x60

	[Token(Token = "0x17000233")]
	public bool IsEntryPlayQue
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x6000830")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000232")]
	public SoundManager Manager
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600082F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2725D60", Offset = "0x2725160", Length = "0x406")]
	[Token(Token = "0x600083A")]
	private static SoundUtility() { }

	[Address(RVA = "0x2726170", Offset = "0x2725570", Length = "0xD2")]
	[Token(Token = "0x6000839")]
	public SoundUtility() { }

	[Address(RVA = "0x2722130", Offset = "0x2721530", Length = "0x79")]
	[IteratorStateMachine(typeof(<AfterLoadBGM>d__18))]
	[Token(Token = "0x600081B")]
	public static IEnumerator AfterLoadBGM(float twait = 0, Action tcallback = null) { }

	[Address(RVA = "0x27222C0", Offset = "0x27216C0", Length = "0x67")]
	[IteratorStateMachine(typeof(<AfterLoads>d__17))]
	[Token(Token = "0x600081A")]
	public static IEnumerator AfterLoads(Action tcallback = null) { }

	[Address(RVA = "0x27221B0", Offset = "0x27215B0", Length = "0x67")]
	[IteratorStateMachine(typeof(<AfterLoadSEComic>d__21))]
	[Token(Token = "0x600081E")]
	public static IEnumerator AfterLoadSEComic(Action endCallback = null) { }

	[Address(RVA = "0x2722220", Offset = "0x2721620", Length = "0x96")]
	[IteratorStateMachine(typeof(<AfterLoadSEInGame>d__19))]
	[Token(Token = "0x600081C")]
	public static IEnumerator AfterLoadSEInGame(float twait = 0, Action startCallback = null, Action endCallback = null) { }

	[Address(RVA = "0x2722330", Offset = "0x2721730", Length = "0x142")]
	[Token(Token = "0x600080A")]
	public static ID ChangeToID(int nint) { }

	[Address(RVA = "0x2722480", Offset = "0x2721880", Length = "0x202")]
	[Token(Token = "0x600080B")]
	public static ID ChangeToID(string nstr) { }

	[Address(RVA = "0x2722690", Offset = "0x2721A90", Length = "0x4C")]
	[Token(Token = "0x6000835")]
	public void ClearQue() { }

	[Address(RVA = "0x27226E0", Offset = "0x2721AE0", Length = "0x19E")]
	[Token(Token = "0x6000834")]
	public void EntryQue(ID tid, float tvol, float tpan) { }

	[Address(RVA = "0x2722880", Offset = "0x2721C80", Length = "0x98")]
	[Token(Token = "0x600081F")]
	public static void Finish() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x6000830")]
	public bool get_IsEntryPlayQue() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600082F")]
	public SoundManager get_Manager() { }

	[Address(RVA = "0x2722920", Offset = "0x2721D20", Length = "0x9D")]
	[Token(Token = "0x600082B")]
	public AudioClip GetBGMClip(BGM tid) { }

	[Address(RVA = "0x27229C0", Offset = "0x2721DC0", Length = "0x155")]
	[Token(Token = "0x600082C")]
	public BGM GetBGMID(PlayStage tstage, PlaySection tsection, bool isRestart) { }

	[Address(RVA = "0x2722B20", Offset = "0x2721F20", Length = "0x120")]
	[Token(Token = "0x600082E")]
	private static string GetBGMPath(BGM tid) { }

	[Address(RVA = "0x2722C40", Offset = "0x2722040", Length = "0x126")]
	[Token(Token = "0x6000813")]
	public static AudioClip GetClip(BGM tid) { }

	[Address(RVA = "0x2722D70", Offset = "0x2722170", Length = "0x63")]
	[Token(Token = "0x6000828")]
	public int GetPaletteIndex(ID tid) { }

	[Address(RVA = "0x2722E40", Offset = "0x2722240", Length = "0x60")]
	[Token(Token = "0x6000829")]
	public Record GetRecord(ID tid) { }

	[Address(RVA = "0x2722DE0", Offset = "0x27221E0", Length = "0x60")]
	[Token(Token = "0x600082A")]
	public Record GetRecord(BGM tid) { }

	[Address(RVA = "0x2722EA0", Offset = "0x27222A0", Length = "0x181")]
	[Token(Token = "0x600082D")]
	private static string GetSEPath(ID tid) { }

	[Address(RVA = "0x2723030", Offset = "0x2722430", Length = "0x6E")]
	[Token(Token = "0x600081D")]
	public bool IsReadyComicSE() { }

	[Address(RVA = "0x27230A0", Offset = "0x27224A0", Length = "0x127")]
	[Token(Token = "0x6000838")]
	private bool IsRequestPlay(SoundQueInfo tinfo, string tname, int skey, float nowTime) { }

	[Address(RVA = "0x27231D0", Offset = "0x27225D0", Length = "0xFA")]
	[AsyncStateMachine(typeof(<LoadClip>d__57))]
	[Token(Token = "0x6000831")]
	private static UniTask<Int32> LoadClip(string bpath) { }

	[Address(RVA = "0x27232D0", Offset = "0x27226D0", Length = "0x105")]
	[AsyncStateMachine(typeof(<LoadClips>d__58))]
	[Token(Token = "0x6000832")]
	public static UniTask<Int32[]> LoadClips(List<String> filenames) { }

	[Address(RVA = "0x27233E0", Offset = "0x27227E0", Length = "0x7E")]
	[Token(Token = "0x6000816")]
	public static void PauseCh(int tch, bool isPause) { }

	[Address(RVA = "0x2724190", Offset = "0x2723590", Length = "0x228")]
	[Token(Token = "0x600080C")]
	public static int Play(ID tid, float pan = 0, bool isReserve = false) { }

	[Address(RVA = "0x2723460", Offset = "0x2722860", Length = "0x2A0")]
	[Token(Token = "0x6000810")]
	public static int PlayBGM(BGM tid, int tch = -1) { }

	[Address(RVA = "0x2723710", Offset = "0x2722B10", Length = "0x199")]
	[Token(Token = "0x600080D")]
	public static void PlayCh(int tch, ID tid, float pan = 0) { }

	[Address(RVA = "0x27238B0", Offset = "0x2722CB0", Length = "0x9F")]
	[Token(Token = "0x6000811")]
	public void PlayGameover() { }

	[Address(RVA = "0x2723950", Offset = "0x2722D50", Length = "0x87")]
	[Token(Token = "0x6000818")]
	public static void PlayQue(ID tid, float tvol) { }

	[Address(RVA = "0x2723DE0", Offset = "0x27231E0", Length = "0x7F")]
	[Token(Token = "0x6000817")]
	public static void PlayQue(ID tid) { }

	[Address(RVA = "0x27239E0", Offset = "0x2722DE0", Length = "0x3F7")]
	[Token(Token = "0x6000837")]
	private void PlayQue() { }

	[Address(RVA = "0x2723E60", Offset = "0x2723260", Length = "0x9F")]
	[Token(Token = "0x6000812")]
	public void PlayResult() { }

	[Address(RVA = "0x2723F00", Offset = "0x2723300", Length = "0xA6")]
	[Token(Token = "0x600080E")]
	public static int PlaySE(ID tid) { }

	[Address(RVA = "0x2723FB0", Offset = "0x27233B0", Length = "0x1D1")]
	[Token(Token = "0x600080F")]
	public int PlaySystemSE(ID tid) { }

	[Address(RVA = "0x2724490", Offset = "0x2723890", Length = "0x6C5")]
	[Token(Token = "0x6000820")]
	public void Release() { }

	[Address(RVA = "0x27243C0", Offset = "0x27237C0", Length = "0xCE")]
	[Token(Token = "0x6000833")]
	public void ReleaseClip(string bpath) { }

	[Address(RVA = "0x2724B60", Offset = "0x2723F60", Length = "0x10F")]
	[Token(Token = "0x6000836")]
	public void ResetClearQue() { }

	[Address(RVA = "0x27254F0", Offset = "0x27248F0", Length = "0x67")]
	[IteratorStateMachine(typeof(<Setup>d__16))]
	[Token(Token = "0x6000819")]
	public static IEnumerator Setup(SoundDataBaseRecords db) { }

	[Address(RVA = "0x2724CF0", Offset = "0x27240F0", Length = "0x67")]
	[IteratorStateMachine(typeof(<SetupBGM>d__26))]
	[Token(Token = "0x6000823")]
	public IEnumerator SetupBGM() { }

	[Address(RVA = "0x2724D60", Offset = "0x2724160", Length = "0x2E9")]
	[Token(Token = "0x6000827")]
	private void SetupPaletteBGM() { }

	[Address(RVA = "0x2725050", Offset = "0x2724450", Length = "0x362")]
	[Token(Token = "0x6000826")]
	private void SetupPaletteSE() { }

	[Address(RVA = "0x27253C0", Offset = "0x27247C0", Length = "0x9A")]
	[IteratorStateMachine(typeof(<SetupSE>d__25))]
	[Token(Token = "0x6000822")]
	public IEnumerator SetupSE(SCType skind, int nstart, int nend) { }

	[Address(RVA = "0x2725460", Offset = "0x2724860", Length = "0x84")]
	[IteratorStateMachine(typeof(<SetupSystem>d__24))]
	[Token(Token = "0x6000821")]
	public IEnumerator SetupSystem(SoundDataBaseRecords db) { }

	[Address(RVA = "0x2724C70", Offset = "0x2724070", Length = "0x7E")]
	[Token(Token = "0x6000815")]
	public static void SetVolumeRate(int tch, float tvol) { }

	[Address(RVA = "0x2725560", Offset = "0x2724960", Length = "0x73")]
	[Token(Token = "0x6000814")]
	public static void StopCh(int tch) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000824")]
	public void UpdatePlaylist(StagePlayList pl) { }

	[Address(RVA = "0x27255E0", Offset = "0x27249E0", Length = "0x774")]
	[Token(Token = "0x6000825")]
	public void UpdateSoundDataBase(SoundDataBaseRecords db) { }

}

