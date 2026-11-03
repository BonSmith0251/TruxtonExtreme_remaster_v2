namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200005D")]
public class JsonTextWriter : JsonWriter
{
	[CompilerGenerated]
	[Token(Token = "0x200005E")]
	private struct <CloseBufferAndWriterAsync>d__9 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000220")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000222")]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000223")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x2110820", Offset = "0x210FC20", Length = "0x213")]
		[Token(Token = "0x6000375")]
		private override void MoveNext() { }

		[Address(RVA = "0x2110A40", Offset = "0x210FE40", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000376")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005F")]
	private struct <DoCloseAsync>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000224")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000226")]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000227")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000228")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x2110AA0", Offset = "0x210FEA0", Length = "0x31D")]
		[Token(Token = "0x6000377")]
		private override void MoveNext() { }

		[Address(RVA = "0x2110DC0", Offset = "0x21101C0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000378")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000060")]
	private struct <DoWriteCommentAsync>d__115 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000229")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400022A")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400022B")]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400022C")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x400022D")]
		public string text; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400022E")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x2110E20", Offset = "0x2110220", Length = "0x4C7")]
		[Token(Token = "0x6000379")]
		private override void MoveNext() { }

		[Address(RVA = "0x21112F0", Offset = "0x21106F0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600037A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000061")]
	private struct <DoWritePropertyNameAsync>d__30 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000230")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000231")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000232")]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000233")]
		public string name; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000234")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000235")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2111350", Offset = "0x2110750", Length = "0x34B")]
		[Token(Token = "0x600037B")]
		private override void MoveNext() { }

		[Address(RVA = "0x21116A0", Offset = "0x2110AA0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600037C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000062")]
	private struct <DoWritePropertyNameAsync>d__32 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000236")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000237")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000238")]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000239")]
		public string name; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400023A")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400023B")]
		public bool escape; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400023C")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2111700", Offset = "0x2110B00", Length = "0x67C")]
		[Token(Token = "0x600037D")]
		private override void MoveNext() { }

		[Address(RVA = "0x2111DA0", Offset = "0x21111A0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600037E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000063")]
	private struct <DoWriteRawValueAsync>d__121 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400023E")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400023F")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000240")]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000241")]
		public string json; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000242")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000243")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2111E00", Offset = "0x2111200", Length = "0x24D")]
		[Token(Token = "0x600037F")]
		private override void MoveNext() { }

		[Address(RVA = "0x2112050", Offset = "0x2111450", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000380")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000064")]
	private struct <DoWriteStartArrayAsync>d__35 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000244")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000246")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000247")]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000248")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000249")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x21120B0", Offset = "0x21114B0", Length = "0x27A")]
		[Token(Token = "0x6000381")]
		private override void MoveNext() { }

		[Address(RVA = "0x2112330", Offset = "0x2111730", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000382")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000065")]
	private struct <DoWriteStartConstructorAsync>d__40 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400024A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400024B")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400024C")]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400024D")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x400024E")]
		public string name; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400024F")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x2112390", Offset = "0x2111790", Length = "0x4A1")]
		[Token(Token = "0x6000383")]
		private override void MoveNext() { }

		[Address(RVA = "0x2112840", Offset = "0x2111C40", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000384")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000066")]
	private struct <DoWriteStartObjectAsync>d__38 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000250")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000251")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000252")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000253")]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000254")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000255")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x21128A0", Offset = "0x2111CA0", Length = "0x27A")]
		[Token(Token = "0x6000385")]
		private override void MoveNext() { }

		[Address(RVA = "0x2112B20", Offset = "0x2111F20", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000386")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000067")]
	private struct <DoWriteUndefinedAsync>d__43 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000256")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000258")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000259")]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400025A")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400025B")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x2112B80", Offset = "0x2111F80", Length = "0x2AB")]
		[Token(Token = "0x6000387")]
		private override void MoveNext() { }

		[Address(RVA = "0x2112E30", Offset = "0x2112230", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000388")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000068")]
	private struct <DoWriteValueAsync>d__60 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400025E")]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400025F")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000260")]
		public DateTime value; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000261")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x2112E90", Offset = "0x2112290", Length = "0x666")]
		[Token(Token = "0x6000389")]
		private override void MoveNext() { }

		[Address(RVA = "0x2113500", Offset = "0x2112900", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600038A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000069")]
	private struct <DoWriteValueAsync>d__64 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000262")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000263")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000264")]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000265")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000266")]
		public DateTimeOffset value; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000267")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2113560", Offset = "0x2112960", Length = "0x635")]
		[Token(Token = "0x600038B")]
		private override void MoveNext() { }

		[Address(RVA = "0x2113BA0", Offset = "0x2112FA0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600038C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006A")]
	private struct <DoWriteValueAsync>d__78 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000268")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000269")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400026A")]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400026B")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400026C")]
		public Guid value; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400026D")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2113C00", Offset = "0x2113000", Length = "0x4D6")]
		[Token(Token = "0x600038D")]
		private override void MoveNext() { }

		[Address(RVA = "0x21140E0", Offset = "0x21134E0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600038E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006B")]
	private struct <DoWriteValueAsync>d__97 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400026F")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000270")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000271")]
		public string value; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000272")]
		public JsonTextWriter <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000273")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000274")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2114140", Offset = "0x2113540", Length = "0x2E7")]
		[Token(Token = "0x600038F")]
		private override void MoveNext() { }

		[Address(RVA = "0x2114430", Offset = "0x2113830", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000390")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006C")]
	private struct <DoWriteValueAsync>d__99 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000275")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000276")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000277")]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000278")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000279")]
		public TimeSpan value; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400027A")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x2114490", Offset = "0x2113890", Length = "0x4FD")]
		[Token(Token = "0x6000391")]
		private override void MoveNext() { }

		[Address(RVA = "0x2114990", Offset = "0x2113D90", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000392")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006D")]
	private struct <WriteIndentAsync>d__13 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400027C")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400027D")]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400027E")]
		public int newLineLen; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400027F")]
		public int currentIndentCount; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000280")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000281")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x2115B50", Offset = "0x2114F50", Length = "0x381")]
		[Token(Token = "0x6000393")]
		private override void MoveNext() { }

		[Address(RVA = "0x2115EE0", Offset = "0x21152E0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000394")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006E")]
	private struct <WriteIntegerValueAsync>d__24 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000282")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000284")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000285")]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000286")]
		public ulong uvalue; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000287")]
		public bool negative; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000288")]
		public CancellationToken cancellationToken; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000289")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		[Address(RVA = "0x2115F40", Offset = "0x2115340", Length = "0x250")]
		[Token(Token = "0x6000395")]
		private override void MoveNext() { }

		[Address(RVA = "0x21161A0", Offset = "0x21155A0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000396")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006F")]
	private struct <WriteValueInternalAsync>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400028C")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x400028D")]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x400028E")]
		public string value; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400028F")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000290")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2116200", Offset = "0x2115600", Length = "0x279")]
		[Token(Token = "0x6000397")]
		private override void MoveNext() { }

		[Address(RVA = "0x2116480", Offset = "0x2115880", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000398")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000070")]
	private struct <WriteValueNonNullAsync>d__54 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000291")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000292")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000293")]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000294")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000295")]
		public Byte[] value; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000296")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x21164E0", Offset = "0x21158E0", Length = "0x57F")]
		[Token(Token = "0x6000399")]
		private override void MoveNext() { }

		[Address(RVA = "0x2116A70", Offset = "0x2115E70", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600039A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000071")]
	private struct <WriteValueNotNullAsync>d__110 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000297")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000298")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000299")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x400029A")]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x400029B")]
		public Uri value; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400029C")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400029D")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2116AD0", Offset = "0x2115ED0", Length = "0x266")]
		[Token(Token = "0x600039B")]
		private override void MoveNext() { }

		[Address(RVA = "0x2116D40", Offset = "0x2116140", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600039C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x4000215")]
	private const int IndentCharBufferSize = 12; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000214")]
	private readonly bool _safeAsync; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000216")]
	private readonly TextWriter _writer; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Nullable(2)]
	[Token(Token = "0x4000217")]
	private Base64Encoder _base64Encoder; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000218")]
	private char _indentChar; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000219")]
	private int _indentation; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400021A")]
	private char _quoteChar; //Field offset: 0x80
	[FieldOffset(Offset = "0x82")]
	[Token(Token = "0x400021B")]
	private bool _quoteName; //Field offset: 0x82
	[FieldOffset(Offset = "0x88")]
	[Nullable(2)]
	[Token(Token = "0x400021C")]
	private Boolean[] _charEscapeFlags; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Nullable(2)]
	[Token(Token = "0x400021D")]
	private Char[] _writeBuffer; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Nullable(2)]
	[Token(Token = "0x400021E")]
	private IArrayPool<Char> _arrayPool; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Nullable(2)]
	[Token(Token = "0x400021F")]
	private Char[] _indentChars; //Field offset: 0xA0

	[Nullable(2)]
	[Token(Token = "0x17000085")]
	public IArrayPool<Char> ArrayPool
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[NullableContext(2)]
		[Token(Token = "0x6000334")]
		 get { } //Length: 8
		[Address(RVA = "0x20F1BA0", Offset = "0x20F0FA0", Length = "0x72")]
		[NullableContext(2)]
		[Token(Token = "0x6000335")]
		 set { } //Length: 114
	}

	[Token(Token = "0x17000084")]
	private Base64Encoder Base64Encoder
	{
		[Address(RVA = "0x20F1AE0", Offset = "0x20F0EE0", Length = "0x7B")]
		[Token(Token = "0x6000333")]
		private get { } //Length: 123
	}

	[Token(Token = "0x17000086")]
	public int Indentation
	{
		[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
		[Token(Token = "0x6000336")]
		 get { } //Length: 4
		[Address(RVA = "0x20F1C50", Offset = "0x20F1050", Length = "0x62")]
		[Token(Token = "0x6000337")]
		 set { } //Length: 98
	}

	[Token(Token = "0x17000088")]
	public char IndentChar
	{
		[Address(RVA = "0x20F1B60", Offset = "0x20F0F60", Length = "0x5")]
		[Token(Token = "0x600033A")]
		 get { } //Length: 5
		[Address(RVA = "0x20F1C20", Offset = "0x20F1020", Length = "0x24")]
		[Token(Token = "0x600033B")]
		 set { } //Length: 36
	}

	[Token(Token = "0x17000087")]
	public char QuoteChar
	{
		[Address(RVA = "0x20F1B80", Offset = "0x20F0F80", Length = "0x8")]
		[Token(Token = "0x6000338")]
		 get { } //Length: 8
		[Address(RVA = "0x20F1CC0", Offset = "0x20F10C0", Length = "0x74")]
		[Token(Token = "0x6000339")]
		 set { } //Length: 116
	}

	[Token(Token = "0x17000089")]
	public bool QuoteName
	{
		[Address(RVA = "0x20F1B90", Offset = "0x20F0F90", Length = "0x8")]
		[Token(Token = "0x600033C")]
		 get { } //Length: 8
		[Address(RVA = "0x20F1D40", Offset = "0x20F1140", Length = "0x7")]
		[Token(Token = "0x600033D")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x20F19A0", Offset = "0x20F0DA0", Length = "0x138")]
	[Token(Token = "0x600033E")]
	public JsonTextWriter(TextWriter textWriter) { }

	[Address(RVA = "0x20E8C30", Offset = "0x20E8030", Length = "0x77")]
	[Token(Token = "0x6000340")]
	public virtual void Close() { }

	[Address(RVA = "0x20E89D0", Offset = "0x20E7DD0", Length = "0x112")]
	[Token(Token = "0x60002BF")]
	public virtual Task CloseAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20E8BC0", Offset = "0x20E7FC0", Length = "0x70")]
	[Token(Token = "0x6000341")]
	private void CloseBufferAndWriter() { }

	[Address(RVA = "0x20E8AF0", Offset = "0x20E7EF0", Length = "0xCB")]
	[AsyncStateMachine(typeof(<CloseBufferAndWriterAsync>d__9))]
	[Token(Token = "0x60002C1")]
	private Task CloseBufferAndWriterAsync() { }

	[Address(RVA = "0x20E8CB0", Offset = "0x20E80B0", Length = "0xF0")]
	[AsyncStateMachine(typeof(<DoCloseAsync>d__8))]
	[Token(Token = "0x60002C0")]
	internal Task DoCloseAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E8DA0", Offset = "0x20E81A0", Length = "0x7C")]
	[Token(Token = "0x60002BA")]
	internal Task DoFlushAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E8E20", Offset = "0x20E8220", Length = "0x117")]
	[AsyncStateMachine(typeof(<DoWriteCommentAsync>d__115))]
	[Token(Token = "0x600032B")]
	internal Task DoWriteCommentAsync(string text, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E8F40", Offset = "0x20E8340", Length = "0x135")]
	[Token(Token = "0x60002BE")]
	internal Task DoWriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E9080", Offset = "0x20E8480", Length = "0x1B3")]
	[Token(Token = "0x60002C4")]
	internal Task DoWriteIndentAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E9240", Offset = "0x20E8640", Length = "0x62")]
	[Token(Token = "0x60002C9")]
	internal Task DoWriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E92B0", Offset = "0x20E86B0", Length = "0x7B")]
	[Token(Token = "0x60002CD")]
	internal Task DoWriteNullAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E95A0", Offset = "0x20E89A0", Length = "0x247")]
	[Token(Token = "0x60002D5")]
	internal Task DoWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E9330", Offset = "0x20E8730", Length = "0x128")]
	[AsyncStateMachine(typeof(<DoWritePropertyNameAsync>d__32))]
	[Token(Token = "0x60002D8")]
	internal Task DoWritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E9460", Offset = "0x20E8860", Length = "0x134")]
	[AsyncStateMachine(typeof(<DoWritePropertyNameAsync>d__30))]
	[Token(Token = "0x60002D6")]
	private Task DoWritePropertyNameAsync(Task task, string name, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E97F0", Offset = "0x20E8BF0", Length = "0x6D")]
	[Token(Token = "0x60002CB")]
	internal Task DoWriteRawAsync(string json, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E9A20", Offset = "0x20E8E20", Length = "0x134")]
	[AsyncStateMachine(typeof(<DoWriteRawValueAsync>d__121))]
	[Token(Token = "0x6000331")]
	private Task DoWriteRawValueAsync(Task task, string json, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E9860", Offset = "0x20E8C60", Length = "0x1B1")]
	[Token(Token = "0x6000330")]
	internal Task DoWriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E9D10", Offset = "0x20E9110", Length = "0x117")]
	[AsyncStateMachine(typeof(<DoWriteStartArrayAsync>d__35))]
	[Token(Token = "0x60002DB")]
	internal Task DoWriteStartArrayAsync(Task task, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E9B60", Offset = "0x20E8F60", Length = "0x1AC")]
	[Token(Token = "0x60002DA")]
	internal Task DoWriteStartArrayAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E9E30", Offset = "0x20E9230", Length = "0x117")]
	[AsyncStateMachine(typeof(<DoWriteStartConstructorAsync>d__40))]
	[Token(Token = "0x60002E0")]
	internal Task DoWriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EA100", Offset = "0x20E9500", Length = "0x117")]
	[AsyncStateMachine(typeof(<DoWriteStartObjectAsync>d__38))]
	[Token(Token = "0x60002DE")]
	internal Task DoWriteStartObjectAsync(Task task, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20E9F50", Offset = "0x20E9350", Length = "0x1AC")]
	[Token(Token = "0x60002DD")]
	internal Task DoWriteStartObjectAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EA3F0", Offset = "0x20E97F0", Length = "0x117")]
	[AsyncStateMachine(typeof(<DoWriteUndefinedAsync>d__43))]
	[Token(Token = "0x60002E3")]
	private Task DoWriteUndefinedAsync(Task task, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EA220", Offset = "0x20E9620", Length = "0x1CE")]
	[Token(Token = "0x60002E2")]
	internal Task DoWriteUndefinedAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB4F0", Offset = "0x20EA8F0", Length = "0x89")]
	[Token(Token = "0x60002FC")]
	internal Task DoWriteValueAsync(decimal value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB260", Offset = "0x20EA660", Length = "0xD4")]
	[Token(Token = "0x60002FE")]
	internal Task DoWriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB160", Offset = "0x20EA560", Length = "0x80")]
	[Token(Token = "0x60002E7")]
	internal Task DoWriteValueAsync(bool value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EAB20", Offset = "0x20E9F20", Length = "0x10C")]
	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__64))]
	[Token(Token = "0x60002F8")]
	internal Task DoWriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB0D0", Offset = "0x20EA4D0", Length = "0x85")]
	[Token(Token = "0x60002E9")]
	internal Task DoWriteValueAsync(Nullable<Boolean> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB3E0", Offset = "0x20EA7E0", Length = "0x10C")]
	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__78))]
	[Token(Token = "0x6000306")]
	internal Task DoWriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB1E0", Offset = "0x20EA5E0", Length = "0x80")]
	[Token(Token = "0x60002F6")]
	internal Task DoWriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EAD70", Offset = "0x20EA170", Length = "0x10A")]
	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__60))]
	[Token(Token = "0x60002F4")]
	internal Task DoWriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB040", Offset = "0x20EA440", Length = "0x8F")]
	[Token(Token = "0x60002EC")]
	internal Task DoWriteValueAsync(Nullable<Byte> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EA510", Offset = "0x20E9910", Length = "0x8B")]
	[Token(Token = "0x60002FA")]
	internal Task DoWriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EA6C0", Offset = "0x20E9AC0", Length = "0x9F")]
	[Token(Token = "0x6000316")]
	internal Task DoWriteValueAsync(Nullable<Int16> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EA760", Offset = "0x20E9B60", Length = "0x21B")]
	[Token(Token = "0x6000318")]
	internal Task DoWriteValueAsync(string value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB340", Offset = "0x20EA740", Length = "0xA0")]
	[Token(Token = "0x600030B")]
	internal Task DoWriteValueAsync(Nullable<Int32> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB610", Offset = "0x20EAA10", Length = "0x8D")]
	[Token(Token = "0x6000329")]
	internal Task DoWriteValueAsync(Nullable<UInt16> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB6A0", Offset = "0x20EAAA0", Length = "0x8A")]
	[Token(Token = "0x6000323")]
	internal Task DoWriteValueAsync(Nullable<UInt64> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB580", Offset = "0x20EA980", Length = "0x8B")]
	[Token(Token = "0x6000308")]
	internal Task DoWriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EA5A0", Offset = "0x20E99A0", Length = "0x80")]
	[Token(Token = "0x600031D")]
	internal Task DoWriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EAF00", Offset = "0x20EA300", Length = "0x8E")]
	[Token(Token = "0x6000320")]
	internal Task DoWriteValueAsync(Nullable<UInt32> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EAC30", Offset = "0x20EA030", Length = "0x134")]
	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__97))]
	[Token(Token = "0x6000319")]
	private Task DoWriteValueAsync(Task task, string value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EA980", Offset = "0x20E9D80", Length = "0x83")]
	[Token(Token = "0x60002F2")]
	internal Task DoWriteValueAsync(Nullable<Char> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EAF90", Offset = "0x20EA390", Length = "0xA1")]
	[Token(Token = "0x6000313")]
	internal Task DoWriteValueAsync(Nullable<SByte> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EA620", Offset = "0x20E9A20", Length = "0x9B")]
	[Token(Token = "0x600030E")]
	internal Task DoWriteValueAsync(Nullable<Int64> value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EAA10", Offset = "0x20E9E10", Length = "0x10A")]
	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__99))]
	[Token(Token = "0x600031B")]
	internal Task DoWriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EAE80", Offset = "0x20EA280", Length = "0x7F")]
	[Token(Token = "0x60002F0")]
	internal Task DoWriteValueAsync(char value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB730", Offset = "0x20EAB30", Length = "0x62")]
	[Token(Token = "0x60002BC")]
	internal Task DoWriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB7A0", Offset = "0x20EABA0", Length = "0x7B")]
	[Token(Token = "0x60002E5")]
	internal Task DoWriteWhitespaceAsync(string ws, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EB820", Offset = "0x20EAC20", Length = "0xDF")]
	[Token(Token = "0x6000332")]
	internal Char[] EnsureWriteBuffer(int length, int copyTo) { }

	[Address(RVA = "0x20EB900", Offset = "0x20EAD00", Length = "0x48")]
	[Token(Token = "0x600036E")]
	private void EnsureWriteBuffer() { }

	[Address(RVA = "0x1F45660", Offset = "0x1F44A60", Length = "0x2A")]
	[Token(Token = "0x600033F")]
	public virtual void Flush() { }

	[Address(RVA = "0x20EB950", Offset = "0x20EAD50", Length = "0x95")]
	[Token(Token = "0x60002B9")]
	public virtual Task FlushAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[NullableContext(2)]
	[Token(Token = "0x6000334")]
	public IArrayPool<Char> get_ArrayPool() { }

	[Address(RVA = "0x20F1AE0", Offset = "0x20F0EE0", Length = "0x7B")]
	[Token(Token = "0x6000333")]
	private Base64Encoder get_Base64Encoder() { }

	[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
	[Token(Token = "0x6000336")]
	public int get_Indentation() { }

	[Address(RVA = "0x20F1B60", Offset = "0x20F0F60", Length = "0x5")]
	[Token(Token = "0x600033A")]
	public char get_IndentChar() { }

	[Address(RVA = "0x20F1B80", Offset = "0x20F0F80", Length = "0x8")]
	[Token(Token = "0x6000338")]
	public char get_QuoteChar() { }

	[Address(RVA = "0x20F1B90", Offset = "0x20F0F90", Length = "0x8")]
	[Token(Token = "0x600033C")]
	public bool get_QuoteName() { }

	[Address(RVA = "0x20EB9F0", Offset = "0x20EADF0", Length = "0x7")]
	[Token(Token = "0x6000348")]
	internal virtual void OnStringEscapeHandlingChanged() { }

	[Address(RVA = "0x20F1BA0", Offset = "0x20F0FA0", Length = "0x72")]
	[NullableContext(2)]
	[Token(Token = "0x6000335")]
	public void set_ArrayPool(IArrayPool<Char> value) { }

	[Address(RVA = "0x20F1C50", Offset = "0x20F1050", Length = "0x62")]
	[Token(Token = "0x6000337")]
	public void set_Indentation(int value) { }

	[Address(RVA = "0x20F1C20", Offset = "0x20F1020", Length = "0x24")]
	[Token(Token = "0x600033B")]
	public void set_IndentChar(char value) { }

	[Address(RVA = "0x20F1CC0", Offset = "0x20F10C0", Length = "0x74")]
	[Token(Token = "0x6000339")]
	public void set_QuoteChar(char value) { }

	[Address(RVA = "0x20F1D40", Offset = "0x20F1140", Length = "0x7")]
	[Token(Token = "0x600033D")]
	public void set_QuoteName(bool value) { }

	[Address(RVA = "0x20EBA00", Offset = "0x20EAE00", Length = "0x11F")]
	[Token(Token = "0x600034B")]
	private int SetIndentChars() { }

	[Address(RVA = "0x20EBB20", Offset = "0x20EAF20", Length = "0x7F")]
	[Token(Token = "0x6000349")]
	private void UpdateCharEscapeFlags() { }

	[Address(RVA = "0x20EBCD0", Offset = "0x20EB0D0", Length = "0xB7")]
	[NullableContext(2)]
	[Token(Token = "0x600036C")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x20EBBA0", Offset = "0x20EAFA0", Length = "0x12B")]
	[Token(Token = "0x600032A")]
	public virtual Task WriteCommentAsync(string text, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EBD90", Offset = "0x20EB190", Length = "0xE6")]
	[Token(Token = "0x60002CE")]
	private Task WriteDigitsAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EC0A0", Offset = "0x20EB4A0", Length = "0xE4")]
	[Token(Token = "0x6000345")]
	protected virtual void WriteEnd(JsonToken token) { }

	[Address(RVA = "0x20EBE80", Offset = "0x20EB280", Length = "0x1E")]
	[Token(Token = "0x600032C")]
	public virtual Task WriteEndArrayAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EBEA0", Offset = "0x20EB2A0", Length = "0x14")]
	[Token(Token = "0x60002C2")]
	public virtual Task WriteEndAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EBEC0", Offset = "0x20EB2C0", Length = "0x194")]
	[Token(Token = "0x60002BD")]
	protected virtual Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EC060", Offset = "0x20EB460", Length = "0x1E")]
	[Token(Token = "0x600032D")]
	public virtual Task WriteEndConstructorAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EC080", Offset = "0x20EB480", Length = "0x1E")]
	[Token(Token = "0x600032E")]
	public virtual Task WriteEndObjectAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EC270", Offset = "0x20EB670", Length = "0xFD")]
	[Token(Token = "0x6000354")]
	private void WriteEscapedString(string value, bool quote) { }

	[Address(RVA = "0x20EC190", Offset = "0x20EB590", Length = "0xDB")]
	[Token(Token = "0x60002D3")]
	private Task WriteEscapedStringAsync(string value, bool quote, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EC720", Offset = "0x20EBB20", Length = "0x140")]
	[Token(Token = "0x600034A")]
	protected virtual void WriteIndent() { }

	[Address(RVA = "0x20EC550", Offset = "0x20EB950", Length = "0x118")]
	[AsyncStateMachine(typeof(<WriteIndentAsync>d__13))]
	[Token(Token = "0x60002C5")]
	private Task WriteIndentAsync(int currentIndentCount, int newLineLen, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EC370", Offset = "0x20EB770", Length = "0x1DB")]
	[Token(Token = "0x60002C3")]
	protected virtual Task WriteIndentAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EC6F0", Offset = "0x20EBAF0", Length = "0x2F")]
	[Token(Token = "0x600034D")]
	protected virtual void WriteIndentSpace() { }

	[Address(RVA = "0x20EC670", Offset = "0x20EBA70", Length = "0x7A")]
	[Token(Token = "0x60002C8")]
	protected virtual Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20ECDA0", Offset = "0x20EC1A0", Length = "0xBB")]
	[Token(Token = "0x6000372")]
	private void WriteIntegerValue(int value) { }

	[Address(RVA = "0x20ECC80", Offset = "0x20EC080", Length = "0x87")]
	[Token(Token = "0x6000370")]
	private void WriteIntegerValue(ulong value, bool negative) { }

	[Address(RVA = "0x20ECD10", Offset = "0x20EC110", Length = "0x86")]
	[Token(Token = "0x6000373")]
	private void WriteIntegerValue(uint value, bool negative) { }

	[Address(RVA = "0x20ECE60", Offset = "0x20EC260", Length = "0x58")]
	[Token(Token = "0x600036F")]
	private void WriteIntegerValue(long value) { }

	[Address(RVA = "0x20ECC60", Offset = "0x20EC060", Length = "0x1D")]
	[Token(Token = "0x60002D2")]
	internal Task WriteIntegerValueAsync(ulong uvalue, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EC870", Offset = "0x20EBC70", Length = "0x25A")]
	[Token(Token = "0x60002CF")]
	private Task WriteIntegerValueAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20ECB10", Offset = "0x20EBF10", Length = "0x144")]
	[AsyncStateMachine(typeof(<WriteIntegerValueAsync>d__24))]
	[Token(Token = "0x60002D0")]
	private Task WriteIntegerValueAsync(Task task, ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20ECAD0", Offset = "0x20EBED0", Length = "0x32")]
	[Token(Token = "0x60002D1")]
	internal Task WriteIntegerValueAsync(long value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20ECEE0", Offset = "0x20EC2E0", Length = "0x86")]
	[Token(Token = "0x6000350")]
	public virtual void WriteNull() { }

	[Address(RVA = "0x20ECEC0", Offset = "0x20EC2C0", Length = "0x14")]
	[Token(Token = "0x60002CC")]
	public virtual Task WriteNullAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20ECF70", Offset = "0x20EC370", Length = "0x11A")]
	[Token(Token = "0x6000371")]
	private int WriteNumberToBuffer(ulong value, bool negative) { }

	[Address(RVA = "0x20ED090", Offset = "0x20EC490", Length = "0xE1")]
	[Token(Token = "0x6000374")]
	private int WriteNumberToBuffer(uint value, bool negative) { }

	[Address(RVA = "0x20ED2F0", Offset = "0x20EC6F0", Length = "0x5F")]
	[Token(Token = "0x6000346")]
	public virtual void WritePropertyName(string name) { }

	[Address(RVA = "0x20ED350", Offset = "0x20EC750", Length = "0xEE")]
	[Token(Token = "0x6000347")]
	public virtual void WritePropertyName(string name, bool escape) { }

	[Address(RVA = "0x20ED2D0", Offset = "0x20EC6D0", Length = "0x14")]
	[Token(Token = "0x60002D4")]
	public virtual Task WritePropertyNameAsync(string name, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20ED180", Offset = "0x20EC580", Length = "0x14E")]
	[Token(Token = "0x60002D7")]
	public virtual Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20ED6B0", Offset = "0x20ECAB0", Length = "0x46")]
	[NullableContext(2)]
	[Token(Token = "0x6000352")]
	public virtual void WriteRaw(string json) { }

	[Address(RVA = "0x20ED440", Offset = "0x20EC840", Length = "0x8A")]
	[Token(Token = "0x60002CA")]
	public virtual Task WriteRawAsync(string json, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20ED4D0", Offset = "0x20EC8D0", Length = "0x1D4")]
	[Token(Token = "0x600032F")]
	public virtual Task WriteRawValueAsync(string json, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20ED8F0", Offset = "0x20ECCF0", Length = "0x45")]
	[Token(Token = "0x6000343")]
	public virtual void WriteStartArray() { }

	[Address(RVA = "0x20ED700", Offset = "0x20ECB00", Length = "0x1EB")]
	[Token(Token = "0x60002D9")]
	public virtual Task WriteStartArrayAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EDA70", Offset = "0x20ECE70", Length = "0xB2")]
	[Token(Token = "0x6000344")]
	public virtual void WriteStartConstructor(string name) { }

	[Address(RVA = "0x20ED940", Offset = "0x20ECD40", Length = "0x12B")]
	[Token(Token = "0x60002DF")]
	public virtual Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EDD20", Offset = "0x20ED120", Length = "0x45")]
	[Token(Token = "0x6000342")]
	public virtual void WriteStartObject() { }

	[Address(RVA = "0x20EDB30", Offset = "0x20ECF30", Length = "0x1EB")]
	[Token(Token = "0x60002DC")]
	public virtual Task WriteStartObjectAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EDF80", Offset = "0x20ED380", Length = "0x86")]
	[Token(Token = "0x6000351")]
	public virtual void WriteUndefined() { }

	[Address(RVA = "0x20EDD70", Offset = "0x20ED170", Length = "0x20D")]
	[Token(Token = "0x60002E1")]
	public virtual Task WriteUndefinedAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20F0A50", Offset = "0x20EFE50", Length = "0xF2")]
	[Token(Token = "0x6000369")]
	public virtual void WriteValue(Guid value) { }

	[Address(RVA = "0x20F0C10", Offset = "0x20F0010", Length = "0x181")]
	[Token(Token = "0x6000367")]
	public virtual void WriteValue(DateTimeOffset value) { }

	[Address(RVA = "0x20F06B0", Offset = "0x20EFAB0", Length = "0xE5")]
	[NullableContext(2)]
	[Token(Token = "0x6000366")]
	public virtual void WriteValue(Byte[] value) { }

	[Address(RVA = "0x20F07A0", Offset = "0x20EFBA0", Length = "0x126")]
	[NullableContext(2)]
	[Token(Token = "0x600034F")]
	public virtual void WriteValue(object value) { }

	[Address(RVA = "0x20F1080", Offset = "0x20F0480", Length = "0x2F3")]
	[Token(Token = "0x6000364")]
	public virtual void WriteValue(DateTime value) { }

	[Address(RVA = "0x20F0E30", Offset = "0x20F0230", Length = "0x94")]
	[Token(Token = "0x6000363")]
	public virtual void WriteValue(decimal value) { }

	[Address(RVA = "0x20F0FC0", Offset = "0x20F03C0", Length = "0xB2")]
	[NullableContext(2)]
	[Token(Token = "0x6000353")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x20F08D0", Offset = "0x20EFCD0", Length = "0x33")]
	[Token(Token = "0x6000355")]
	public virtual void WriteValue(int value) { }

	[Address(RVA = "0x20F0B90", Offset = "0x20EFF90", Length = "0x71")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000356")]
	public virtual void WriteValue(uint value) { }

	[Address(RVA = "0x20F0F80", Offset = "0x20F0380", Length = "0x34")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000362")]
	public virtual void WriteValue(sbyte value) { }

	[Address(RVA = "0x20F1490", Offset = "0x20F0890", Length = "0x34")]
	[Token(Token = "0x6000361")]
	public virtual void WriteValue(byte value) { }

	[Address(RVA = "0x20F1660", Offset = "0x20F0A60", Length = "0x80")]
	[Token(Token = "0x6000357")]
	public virtual void WriteValue(long value) { }

	[Address(RVA = "0x20F1620", Offset = "0x20F0A20", Length = "0x38")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000358")]
	public virtual void WriteValue(ulong value) { }

	[Address(RVA = "0x20F16F0", Offset = "0x20F0AF0", Length = "0xB8")]
	[Token(Token = "0x6000359")]
	public virtual void WriteValue(float value) { }

	[Address(RVA = "0x20F14D0", Offset = "0x20F08D0", Length = "0x8A")]
	[Token(Token = "0x6000360")]
	public virtual void WriteValue(char value) { }

	[Address(RVA = "0x20F0B50", Offset = "0x20EFF50", Length = "0x34")]
	[CLSCompliant(False)]
	[Token(Token = "0x600035F")]
	public virtual void WriteValue(ushort value) { }

	[Address(RVA = "0x20F17B0", Offset = "0x20F0BB0", Length = "0xF0")]
	[Token(Token = "0x600035A")]
	public virtual void WriteValue(Nullable<Single> value) { }

	[Address(RVA = "0x20F1560", Offset = "0x20F0960", Length = "0xB8")]
	[Token(Token = "0x600035B")]
	public virtual void WriteValue(double value) { }

	[Address(RVA = "0x20F0910", Offset = "0x20EFD10", Length = "0xF9")]
	[Token(Token = "0x600035C")]
	public virtual void WriteValue(Nullable<Double> value) { }

	[Address(RVA = "0x20F0A10", Offset = "0x20EFE10", Length = "0x34")]
	[Token(Token = "0x600035E")]
	public virtual void WriteValue(short value) { }

	[Address(RVA = "0x20F0DA0", Offset = "0x20F01A0", Length = "0x8B")]
	[Token(Token = "0x600035D")]
	public virtual void WriteValue(bool value) { }

	[Address(RVA = "0x20F0ED0", Offset = "0x20F02D0", Length = "0xAF")]
	[NullableContext(2)]
	[Token(Token = "0x600036B")]
	public virtual void WriteValue(Uri value) { }

	[Address(RVA = "0x20F1380", Offset = "0x20F0780", Length = "0x109")]
	[Token(Token = "0x600036A")]
	public virtual void WriteValue(TimeSpan value) { }

	[Address(RVA = "0x20EE0D0", Offset = "0x20ED4D0", Length = "0x11A")]
	[Token(Token = "0x60002FD")]
	public virtual Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF3D0", Offset = "0x20EE7D0", Length = "0x43")]
	[Token(Token = "0x600030C")]
	public virtual Task WriteValueAsync(long value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF490", Offset = "0x20EE890", Length = "0xC1")]
	[Token(Token = "0x600030D")]
	public virtual Task WriteValueAsync(Nullable<Int64> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EEB90", Offset = "0x20EDF90", Length = "0xB8")]
	[Token(Token = "0x600030F")]
	internal Task WriteValueAsync(BigInteger value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EF250", Offset = "0x20EE650", Length = "0xAA")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000328")]
	public virtual Task WriteValueAsync(Nullable<UInt16> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF420", Offset = "0x20EE820", Length = "0x32")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000327")]
	public virtual Task WriteValueAsync(ushort value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE300", Offset = "0x20ED700", Length = "0x1F3")]
	[Token(Token = "0x6000310")]
	public virtual Task WriteValueAsync(object value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF0A0", Offset = "0x20EE4A0", Length = "0x48")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000311")]
	public virtual Task WriteValueAsync(sbyte value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EFA80", Offset = "0x20EEE80", Length = "0xC1")]
	[Token(Token = "0x600030A")]
	public virtual Task WriteValueAsync(Nullable<Int32> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE940", Offset = "0x20EDD40", Length = "0x24C")]
	[Token(Token = "0x6000324")]
	public virtual Task WriteValueAsync(Uri value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE840", Offset = "0x20EDC40", Length = "0xAC")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000322")]
	public virtual Task WriteValueAsync(Nullable<UInt64> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF070", Offset = "0x20EE470", Length = "0x2F")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000321")]
	public virtual Task WriteValueAsync(ulong value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE5B0", Offset = "0x20ED9B0", Length = "0xAB")]
	[CLSCompliant(False)]
	[Token(Token = "0x600031F")]
	public virtual Task WriteValueAsync(Nullable<UInt32> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE800", Offset = "0x20EDC00", Length = "0x31")]
	[CLSCompliant(False)]
	[Token(Token = "0x600031E")]
	public virtual Task WriteValueAsync(uint value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE1F0", Offset = "0x20ED5F0", Length = "0x48")]
	[Token(Token = "0x6000314")]
	public virtual Task WriteValueAsync(short value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF730", Offset = "0x20EEB30", Length = "0xA2")]
	[Token(Token = "0x600031C")]
	public virtual Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF560", Offset = "0x20EE960", Length = "0xA0")]
	[Token(Token = "0x60002F1")]
	public virtual Task WriteValueAsync(Nullable<Char> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE720", Offset = "0x20EDB20", Length = "0xC0")]
	[Token(Token = "0x6000315")]
	public virtual Task WriteValueAsync(Nullable<Int16> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF300", Offset = "0x20EE700", Length = "0xC2")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000312")]
	public virtual Task WriteValueAsync(Nullable<SByte> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EEF80", Offset = "0x20EE380", Length = "0x2F")]
	[Token(Token = "0x60002FF")]
	public virtual Task WriteValueAsync(double value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE8F0", Offset = "0x20EDCF0", Length = "0x14")]
	[Token(Token = "0x60002EF")]
	public virtual Task WriteValueAsync(char value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EFA30", Offset = "0x20EEE30", Length = "0x47")]
	[Token(Token = "0x6000309")]
	public virtual Task WriteValueAsync(int value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE240", Offset = "0x20ED640", Length = "0xB4")]
	[Token(Token = "0x60002FB")]
	public virtual Task WriteValueAsync(decimal value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE7E0", Offset = "0x20EDBE0", Length = "0x14")]
	[Token(Token = "0x60002E6")]
	public virtual Task WriteValueAsync(bool value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF7E0", Offset = "0x20EEBE0", Length = "0x249")]
	[Token(Token = "0x6000317")]
	public virtual Task WriteValueAsync(string value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE010", Offset = "0x20ED410", Length = "0xBD")]
	[Token(Token = "0x6000300")]
	internal Task WriteValueAsync(double value, bool nullable, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EF640", Offset = "0x20EEA40", Length = "0xC5")]
	[Token(Token = "0x6000301")]
	public virtual Task WriteValueAsync(Nullable<Double> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EEEB0", Offset = "0x20EE2B0", Length = "0xCD")]
	[Token(Token = "0x60002F9")]
	public virtual Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EED30", Offset = "0x20EE130", Length = "0x2F")]
	[Token(Token = "0x6000302")]
	public virtual Task WriteValueAsync(float value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EEFB0", Offset = "0x20EE3B0", Length = "0xBD")]
	[Token(Token = "0x6000303")]
	internal Task WriteValueAsync(float value, bool nullable, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EED60", Offset = "0x20EE160", Length = "0x14B")]
	[Token(Token = "0x60002ED")]
	public virtual Task WriteValueAsync(Byte[] value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF1A0", Offset = "0x20EE5A0", Length = "0xA2")]
	[Token(Token = "0x60002E8")]
	public virtual Task WriteValueAsync(Nullable<Boolean> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF600", Offset = "0x20EEA00", Length = "0x32")]
	[Token(Token = "0x60002EA")]
	public virtual Task WriteValueAsync(byte value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE500", Offset = "0x20ED900", Length = "0xA2")]
	[Token(Token = "0x60002F5")]
	public virtual Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF0F0", Offset = "0x20EE4F0", Length = "0xAC")]
	[Token(Token = "0x60002EB")]
	public virtual Task WriteValueAsync(Nullable<Byte> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EEC50", Offset = "0x20EE050", Length = "0xBF")]
	[Token(Token = "0x6000304")]
	public virtual Task WriteValueAsync(Nullable<Single> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EED10", Offset = "0x20EE110", Length = "0x14")]
	[Token(Token = "0x60002F3")]
	public virtual Task WriteValueAsync(DateTime value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF460", Offset = "0x20EE860", Length = "0x2E")]
	[Token(Token = "0x6000305")]
	public virtual Task WriteValueAsync(Guid value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE660", Offset = "0x20EDA60", Length = "0xB4")]
	[Token(Token = "0x6000307")]
	public virtual Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EE910", Offset = "0x20EDD10", Length = "0x2E")]
	[Token(Token = "0x60002F7")]
	public virtual Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EF710", Offset = "0x20EEB10", Length = "0x14")]
	[Token(Token = "0x600031A")]
	public virtual Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20EFBD0", Offset = "0x20EEFD0", Length = "0x2F")]
	[Token(Token = "0x600034C")]
	protected virtual void WriteValueDelimiter() { }

	[Address(RVA = "0x20EFB50", Offset = "0x20EEF50", Length = "0x7A")]
	[Token(Token = "0x60002BB")]
	protected virtual Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EFF00", Offset = "0x20EF300", Length = "0x2A")]
	[Token(Token = "0x600034E")]
	private void WriteValueInternal(string value, JsonToken token) { }

	[Address(RVA = "0x20EFD40", Offset = "0x20EF140", Length = "0x1B4")]
	[Token(Token = "0x60002C6")]
	private Task WriteValueInternalAsync(JsonToken token, string value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EFC00", Offset = "0x20EF000", Length = "0x134")]
	[AsyncStateMachine(typeof(<WriteValueInternalAsync>d__15))]
	[Token(Token = "0x60002C7")]
	private Task WriteValueInternalAsync(Task task, string value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20EFF30", Offset = "0x20EF330", Length = "0x117")]
	[AsyncStateMachine(typeof(<WriteValueNonNullAsync>d__54))]
	[Token(Token = "0x60002EE")]
	internal Task WriteValueNonNullAsync(Byte[] value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20F0050", Offset = "0x20EF450", Length = "0x134")]
	[AsyncStateMachine(typeof(<WriteValueNotNullAsync>d__110))]
	[Token(Token = "0x6000326")]
	internal Task WriteValueNotNullAsync(Task task, Uri value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20F0190", Offset = "0x20EF590", Length = "0x1C8")]
	[Token(Token = "0x6000325")]
	internal Task WriteValueNotNullAsync(Uri value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20F0530", Offset = "0x20EF930", Length = "0x17F")]
	[Token(Token = "0x6000365")]
	private int WriteValueToBuffer(DateTime value) { }

	[Address(RVA = "0x20F0360", Offset = "0x20EF760", Length = "0x1CC")]
	[Token(Token = "0x6000368")]
	private int WriteValueToBuffer(DateTimeOffset value) { }

	[Address(RVA = "0x20F1950", Offset = "0x20F0D50", Length = "0x47")]
	[Token(Token = "0x600036D")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x20F18B0", Offset = "0x20F0CB0", Length = "0x98")]
	[Token(Token = "0x60002E4")]
	public virtual Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken = null) { }

}

