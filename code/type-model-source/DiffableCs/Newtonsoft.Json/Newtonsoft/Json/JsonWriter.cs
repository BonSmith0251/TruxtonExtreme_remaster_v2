namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000077")]
public abstract class JsonWriter : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000079")]
	private struct <<InternalWriteEndAsync>g__AwaitEnd|11_2>d : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E6")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40002E8")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x40002E9")]
		public JsonWriter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002EA")]
		public int LevelsToComplete; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40002EB")]
		public CancellationToken CancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40002EC")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x21149F0", Offset = "0x2113DF0", Length = "0x24B")]
		[Token(Token = "0x60004B3")]
		private override void MoveNext() { }

		[Address(RVA = "0x2114C40", Offset = "0x2114040", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60004B4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007A")]
	private struct <<InternalWriteEndAsync>g__AwaitIndent|11_1>d : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002ED")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40002EF")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x40002F0")]
		public JsonWriter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002F1")]
		public JsonToken token; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40002F2")]
		public CancellationToken CancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40002F3")]
		public int LevelsToComplete; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40002F4")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		[Address(RVA = "0x2114CA0", Offset = "0x21140A0", Length = "0x336")]
		[Token(Token = "0x60004B5")]
		private override void MoveNext() { }

		[Address(RVA = "0x2114FE0", Offset = "0x21143E0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60004B6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007B")]
	private struct <<InternalWriteEndAsync>g__AwaitProperty|11_0>d : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F5")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002F6")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40002F7")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x40002F8")]
		public JsonWriter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002F9")]
		public CancellationToken CancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40002FA")]
		public JsonToken token; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40002FB")]
		public int LevelsToComplete; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40002FC")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2115040", Offset = "0x2114440", Length = "0x42E")]
		[Token(Token = "0x60004B7")]
		private override void MoveNext() { }

		[Address(RVA = "0x2115470", Offset = "0x2114870", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60004B8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007C")]
	private struct <<InternalWriteEndAsync>g__AwaitRemaining|11_3>d : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002FD")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40002FF")]
		public JsonWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000300")]
		public CancellationToken CancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000301")]
		public int LevelsToComplete; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000302")]
		private JsonToken <token>5__2; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000303")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x21154D0", Offset = "0x21148D0", Length = "0x3E5")]
		[Token(Token = "0x60004B9")]
		private override void MoveNext() { }

		[Address(RVA = "0x21158C0", Offset = "0x2114CC0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60004BA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007D")]
	private struct <AutoCompleteAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000304")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000305")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000306")]
		public JsonWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000307")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000308")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x2130E80", Offset = "0x2130280", Length = "0x270")]
		[Token(Token = "0x60004BB")]
		private override void MoveNext() { }

		[Address(RVA = "0x2131100", Offset = "0x2130500", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60004BC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007E")]
	private struct <InternalWriteStartAsync>d__20 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000309")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400030A")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400030B")]
		public JsonWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400030C")]
		public JsonToken token; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400030D")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400030E")]
		public JsonContainerType container; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400030F")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2131610", Offset = "0x2130A10", Length = "0x1B0")]
		[Token(Token = "0x60004BD")]
		private override void MoveNext() { }

		[Address(RVA = "0x21317D0", Offset = "0x2130BD0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60004BE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007F")]
	private struct <WriteConstructorDateAsync>d__32 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000310")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000311")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000312")]
		public JsonReader reader; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000313")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000314")]
		public JsonWriter <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000315")]
		private DateTime <date>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x4000316")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000317")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x21321F0", Offset = "0x21315F0", Length = "0x661")]
		[Token(Token = "0x60004BF")]
		private override void MoveNext() { }

		[Address(RVA = "0x2132860", Offset = "0x2131C60", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60004C0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000080")]
	private struct <WriteTokenAsync>d__30 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000318")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000319")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400031A")]
		public JsonWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x400031B")]
		public JsonReader reader; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400031C")]
		public bool writeDateConstructorAsDate; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400031D")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400031E")]
		public bool writeComments; //Field offset: 0x40
		[FieldOffset(Offset = "0x41")]
		[Token(Token = "0x400031F")]
		public bool writeChildren; //Field offset: 0x41
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000320")]
		private int <initialDepth>5__2; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000321")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Nullable(0)]
		[Token(Token = "0x4000322")]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x58

		[Address(RVA = "0x2133860", Offset = "0x2132C60", Length = "0x5FF")]
		[Token(Token = "0x60004C1")]
		private override void MoveNext() { }

		[Address(RVA = "0x2133E70", Offset = "0x2133270", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60004C2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000081")]
	private struct <WriteTokenSyncReadingAsync>d__31 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000323")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000324")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000325")]
		public JsonWriter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000326")]
		public JsonReader reader; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000327")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000328")]
		private int <initialDepth>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x4000329")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2133ED0", Offset = "0x21332D0", Length = "0x422")]
		[Token(Token = "0x60004C3")]
		private override void MoveNext() { }

		[Address(RVA = "0x2134300", Offset = "0x2133700", Length = "0xAF")]
		[DebuggerHidden]
		[Token(Token = "0x60004C4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[NullableContext(0)]
	[Token(Token = "0x2000078")]
	public enum State : int
	{
		Start = 0,
		Property = 1,
		ObjectStart = 2,
		Object = 3,
		ArrayStart = 4,
		Array = 5,
		ConstructorStart = 6,
		Constructor = 7,
		Closed = 8,
		Error = 9,
	}

	[Token(Token = "0x40002CD")]
	private static readonly State[][] StateArray; //Field offset: 0x0
	[Token(Token = "0x40002CE")]
	internal static readonly State[][] StateArrayTemplate; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Nullable(2)]
	[Token(Token = "0x40002CF")]
	private List<JsonPosition> _stack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002D0")]
	private JsonPosition _currentPosition; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002D1")]
	private State _currentState; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40002D2")]
	private Formatting _formatting; //Field offset: 0x34
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002D3")]
	private bool <CloseOutput>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x40002D4")]
	private bool <AutoCompleteOnClose>k__BackingField; //Field offset: 0x39
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40002D5")]
	private DateFormatHandling _dateFormatHandling; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002D6")]
	private DateTimeZoneHandling _dateTimeZoneHandling; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40002D7")]
	private StringEscapeHandling _stringEscapeHandling; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002D8")]
	private FloatFormatHandling _floatFormatHandling; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Nullable(2)]
	[Token(Token = "0x40002D9")]
	private string _dateFormatString; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Nullable(2)]
	[Token(Token = "0x40002DA")]
	private CultureInfo _culture; //Field offset: 0x58

	[Token(Token = "0x1700009F")]
	public bool AutoCompleteOnClose
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600043D")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600043E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700009E")]
	public bool CloseOutput
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600043B")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600043C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A2")]
	internal string ContainerPath
	{
		[Address(RVA = "0x210FC20", Offset = "0x210F020", Length = "0x88")]
		[Token(Token = "0x6000441")]
		internal get { } //Length: 136
	}

	[Token(Token = "0x170000AA")]
	public CultureInfo Culture
	{
		[Address(RVA = "0x210FCB0", Offset = "0x210F0B0", Length = "0x54")]
		[Token(Token = "0x6000450")]
		 get { } //Length: 84
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x6000451")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000A5")]
	public DateFormatHandling DateFormatHandling
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x6000445")]
		 get { } //Length: 4
		[Address(RVA = "0x210FF90", Offset = "0x210F390", Length = "0x63")]
		[Token(Token = "0x6000446")]
		 set { } //Length: 99
	}

	[Nullable(2)]
	[Token(Token = "0x170000A9")]
	public string DateFormatString
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[NullableContext(2)]
		[Token(Token = "0x600044E")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[NullableContext(2)]
		[Token(Token = "0x600044F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000A6")]
	public DateTimeZoneHandling DateTimeZoneHandling
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x6000447")]
		 get { } //Length: 4
		[Address(RVA = "0x2110000", Offset = "0x210F400", Length = "0x63")]
		[Token(Token = "0x6000448")]
		 set { } //Length: 99
	}

	[Token(Token = "0x170000A8")]
	public FloatFormatHandling FloatFormatHandling
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x600044C")]
		 get { } //Length: 4
		[Address(RVA = "0x2110070", Offset = "0x210F470", Length = "0x63")]
		[Token(Token = "0x600044D")]
		 set { } //Length: 99
	}

	[Token(Token = "0x170000A4")]
	public Formatting Formatting
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000443")]
		 get { } //Length: 4
		[Address(RVA = "0x21100E0", Offset = "0x210F4E0", Length = "0x63")]
		[Token(Token = "0x6000444")]
		 set { } //Length: 99
	}

	[Token(Token = "0x170000A3")]
	public string Path
	{
		[Address(RVA = "0x210FD10", Offset = "0x210F110", Length = "0xFC")]
		[Token(Token = "0x6000442")]
		 get { } //Length: 252
	}

	[Token(Token = "0x170000A7")]
	public StringEscapeHandling StringEscapeHandling
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x6000449")]
		 get { } //Length: 4
		[Address(RVA = "0x2110150", Offset = "0x210F550", Length = "0x76")]
		[Token(Token = "0x600044A")]
		 set { } //Length: 118
	}

	[Token(Token = "0x170000A0")]
	protected private int Top
	{
		[Address(RVA = "0x210FE10", Offset = "0x210F210", Length = "0x51")]
		[Token(Token = "0x600043F")]
		private get { } //Length: 81
	}

	[Token(Token = "0x170000A1")]
	public WriteState WriteState
	{
		[Address(RVA = "0x210FE70", Offset = "0x210F270", Length = "0x1C")]
		[Token(Token = "0x6000440")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x210F8D0", Offset = "0x210ECD0", Length = "0x31A")]
	[Token(Token = "0x600043A")]
	private static JsonWriter() { }

	[Address(RVA = "0x210FBF0", Offset = "0x210EFF0", Length = "0x29")]
	[Token(Token = "0x6000452")]
	protected JsonWriter() { }

	[Address(RVA = "0x2106E60", Offset = "0x2106260", Length = "0x126")]
	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitEnd|11_2>d))]
	[CompilerGenerated]
	[Token(Token = "0x60004B1")]
	private Task <InternalWriteEndAsync>g__AwaitEnd|11_2(Task task, int LevelsToComplete, CancellationToken CancellationToken) { }

	[Address(RVA = "0x2106F90", Offset = "0x2106390", Length = "0x13E")]
	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitIndent|11_1>d))]
	[CompilerGenerated]
	[Token(Token = "0x60004B0")]
	private Task <InternalWriteEndAsync>g__AwaitIndent|11_1(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[Address(RVA = "0x21070D0", Offset = "0x21064D0", Length = "0x132")]
	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitProperty|11_0>d))]
	[CompilerGenerated]
	[Token(Token = "0x60004AF")]
	private Task <InternalWriteEndAsync>g__AwaitProperty|11_0(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[Address(RVA = "0x2107210", Offset = "0x2106610", Length = "0x108")]
	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d))]
	[CompilerGenerated]
	[Token(Token = "0x60004B2")]
	private Task <InternalWriteEndAsync>g__AwaitRemaining|11_3(int LevelsToComplete, CancellationToken CancellationToken) { }

	[Address(RVA = "0x2105240", Offset = "0x2104640", Length = "0x22E")]
	[Token(Token = "0x6000475")]
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	[Address(RVA = "0x2104D20", Offset = "0x2104120", Length = "0x64")]
	[Token(Token = "0x600046C")]
	private void AutoCompleteAll() { }

	[Address(RVA = "0x2104D90", Offset = "0x2104190", Length = "0x124")]
	[Token(Token = "0x60003ED")]
	internal Task AutoCompleteAsync(JsonToken tokenBeingWritten, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2105090", Offset = "0x2104490", Length = "0xF0")]
	[AsyncStateMachine(typeof(<AutoCompleteAsync>d__1))]
	[Token(Token = "0x60003EE")]
	private Task AutoCompleteAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2105180", Offset = "0x2104580", Length = "0xBF")]
	[Token(Token = "0x600046E")]
	private void AutoCompleteClose(JsonContainerType type) { }

	[Address(RVA = "0x2105470", Offset = "0x2104870", Length = "0x1D5")]
	[Token(Token = "0x6000439")]
	internal static State[][] BuildStateArray() { }

	[Address(RVA = "0x2105650", Offset = "0x2104A50", Length = "0xFE")]
	[Token(Token = "0x600046F")]
	private int CalculateLevelsToComplete(JsonContainerType type) { }

	[Address(RVA = "0x2105750", Offset = "0x2104B50", Length = "0x6B")]
	[Token(Token = "0x6000469")]
	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	[Address(RVA = "0x21057C0", Offset = "0x2104BC0", Length = "0x6B")]
	[Token(Token = "0x6000468")]
	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	[Address(RVA = "0x2105900", Offset = "0x2104D00", Length = "0x64")]
	[Token(Token = "0x6000458")]
	public override void Close() { }

	[Address(RVA = "0x2105830", Offset = "0x2104C30", Length = "0xCA")]
	[Token(Token = "0x60003EF")]
	public override Task CloseAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2105970", Offset = "0x2104D70", Length = "0xA5")]
	[Token(Token = "0x60004A6")]
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	[Address(RVA = "0x2105A20", Offset = "0x2104E20", Length = "0x25")]
	[Token(Token = "0x60004A3")]
	protected override void Dispose(bool disposing) { }

	[Token(Token = "0x6000457")]
	public abstract void Flush() { }

	[Address(RVA = "0x2105A50", Offset = "0x2104E50", Length = "0xCA")]
	[Token(Token = "0x60003F0")]
	public override Task FlushAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600043D")]
	public bool get_AutoCompleteOnClose() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600043B")]
	public bool get_CloseOutput() { }

	[Address(RVA = "0x210FC20", Offset = "0x210F020", Length = "0x88")]
	[Token(Token = "0x6000441")]
	internal string get_ContainerPath() { }

	[Address(RVA = "0x210FCB0", Offset = "0x210F0B0", Length = "0x54")]
	[Token(Token = "0x6000450")]
	public CultureInfo get_Culture() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x6000445")]
	public DateFormatHandling get_DateFormatHandling() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[NullableContext(2)]
	[Token(Token = "0x600044E")]
	public string get_DateFormatString() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x6000447")]
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x600044C")]
	public FloatFormatHandling get_FloatFormatHandling() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000443")]
	public Formatting get_Formatting() { }

	[Address(RVA = "0x210FD10", Offset = "0x210F110", Length = "0xFC")]
	[Token(Token = "0x6000442")]
	public string get_Path() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x6000449")]
	public StringEscapeHandling get_StringEscapeHandling() { }

	[Address(RVA = "0x210FE10", Offset = "0x210F210", Length = "0x51")]
	[Token(Token = "0x600043F")]
	protected private int get_Top() { }

	[Address(RVA = "0x210FE70", Offset = "0x210F270", Length = "0x1C")]
	[Token(Token = "0x6000440")]
	public WriteState get_WriteState() { }

	[Address(RVA = "0x2105B20", Offset = "0x2104F20", Length = "0xB8")]
	[Token(Token = "0x600046D")]
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	[Address(RVA = "0x2105BF0", Offset = "0x2104FF0", Length = "0xD")]
	[Token(Token = "0x60004AE")]
	internal void InternalWriteComment() { }

	[Address(RVA = "0x2105BE0", Offset = "0x2104FE0", Length = "0x10")]
	[Token(Token = "0x6000403")]
	internal Task InternalWriteCommentAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2105180", Offset = "0x2104580", Length = "0xBF")]
	[Token(Token = "0x60004A8")]
	internal void InternalWriteEnd(JsonContainerType container) { }

	[Address(RVA = "0x2105C00", Offset = "0x2105000", Length = "0x27E")]
	[Token(Token = "0x60003F8")]
	internal Task InternalWriteEndAsync(JsonContainerType type, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2105F50", Offset = "0x2105350", Length = "0x2B")]
	[Token(Token = "0x60004A9")]
	internal void InternalWritePropertyName(string name) { }

	[Address(RVA = "0x2105E80", Offset = "0x2105280", Length = "0xC1")]
	[Token(Token = "0x60003FF")]
	internal Task InternalWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004AA")]
	internal void InternalWriteRaw() { }

	[Address(RVA = "0x21060A0", Offset = "0x21054A0", Length = "0x181")]
	[Token(Token = "0x60004AB")]
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	[Address(RVA = "0x2105F80", Offset = "0x2105380", Length = "0x117")]
	[AsyncStateMachine(typeof(<InternalWriteStartAsync>d__20))]
	[Token(Token = "0x6000401")]
	internal Task InternalWriteStartAsync(JsonToken token, JsonContainerType container, CancellationToken cancellationToken) { }

	[Address(RVA = "0x21062F0", Offset = "0x21056F0", Length = "0x11")]
	[Token(Token = "0x60004AC")]
	internal void InternalWriteValue(JsonToken token) { }

	[Address(RVA = "0x2106230", Offset = "0x2105630", Length = "0xB5")]
	[Token(Token = "0x6000436")]
	internal Task InternalWriteValueAsync(JsonToken token, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2106310", Offset = "0x2105710", Length = "0x5B")]
	[Token(Token = "0x60004AD")]
	internal void InternalWriteWhitespace(string ws) { }

	[Address(RVA = "0x2106370", Offset = "0x2105770", Length = "0xD0")]
	[Token(Token = "0x6000467")]
	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600044B")]
	internal override void OnStringEscapeHandlingChanged() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000456")]
	private JsonContainerType Peek() { }

	[Address(RVA = "0x2106450", Offset = "0x2105850", Length = "0x103")]
	[Token(Token = "0x6000455")]
	private JsonContainerType Pop() { }

	[Address(RVA = "0x2106560", Offset = "0x2105960", Length = "0x16F")]
	[Token(Token = "0x6000454")]
	private void Push(JsonContainerType value) { }

	[Address(RVA = "0x21066D0", Offset = "0x2105AD0", Length = "0x18F")]
	[Token(Token = "0x60004A5")]
	private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value) { }

	[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600043E")]
	public void set_AutoCompleteOnClose(bool value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600043C")]
	public void set_CloseOutput(bool value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6000451")]
	public void set_Culture(CultureInfo value) { }

	[Address(RVA = "0x210FF90", Offset = "0x210F390", Length = "0x63")]
	[Token(Token = "0x6000446")]
	public void set_DateFormatHandling(DateFormatHandling value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[NullableContext(2)]
	[Token(Token = "0x600044F")]
	public void set_DateFormatString(string value) { }

	[Address(RVA = "0x2110000", Offset = "0x210F400", Length = "0x63")]
	[Token(Token = "0x6000448")]
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	[Address(RVA = "0x2110070", Offset = "0x210F470", Length = "0x63")]
	[Token(Token = "0x600044D")]
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	[Address(RVA = "0x21100E0", Offset = "0x210F4E0", Length = "0x63")]
	[Token(Token = "0x6000444")]
	public void set_Formatting(Formatting value) { }

	[Address(RVA = "0x2110150", Offset = "0x210F550", Length = "0x76")]
	[Token(Token = "0x600044A")]
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	[Address(RVA = "0x2106BD0", Offset = "0x2105FD0", Length = "0x1D8")]
	[Token(Token = "0x60004A7")]
	protected void SetWriteState(JsonToken token, object value) { }

	[Address(RVA = "0x2106860", Offset = "0x2105C60", Length = "0x320")]
	[Token(Token = "0x6000437")]
	protected Task SetWriteStateAsync(JsonToken token, object value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2106DF0", Offset = "0x21061F0", Length = "0x61")]
	[Token(Token = "0x60004A2")]
	private override void System.IDisposable.Dispose() { }

	[Address(RVA = "0x2107320", Offset = "0x2106720", Length = "0xC6")]
	[Token(Token = "0x6000470")]
	private void UpdateCurrentState() { }

	[Address(RVA = "0x21073F0", Offset = "0x21067F0", Length = "0xA")]
	[Token(Token = "0x6000453")]
	internal void UpdateScopeWithFinishedValue() { }

	[Address(RVA = "0x2105BF0", Offset = "0x2104FF0", Length = "0xD")]
	[NullableContext(2)]
	[Token(Token = "0x60004A0")]
	public override void WriteComment(string text) { }

	[Address(RVA = "0x2107400", Offset = "0x2106800", Length = "0xDF")]
	[Token(Token = "0x6000402")]
	public override Task WriteCommentAsync(string text, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2107600", Offset = "0x2106A00", Length = "0xB5")]
	[Token(Token = "0x600046A")]
	private void WriteConstructorDate(JsonReader reader) { }

	[Address(RVA = "0x21074E0", Offset = "0x21068E0", Length = "0x11E")]
	[AsyncStateMachine(typeof(<WriteConstructorDateAsync>d__32))]
	[Token(Token = "0x600040D")]
	private Task WriteConstructorDateAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2107D90", Offset = "0x2107190", Length = "0xE2")]
	[Token(Token = "0x600046B")]
	private void WriteEnd(JsonContainerType type) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000471")]
	protected override void WriteEnd(JsonToken token) { }

	[Address(RVA = "0x2107C90", Offset = "0x2107090", Length = "0xF1")]
	[Token(Token = "0x6000461")]
	public override void WriteEnd() { }

	[Address(RVA = "0x2107790", Offset = "0x2106B90", Length = "0xD")]
	[Token(Token = "0x600045C")]
	public override void WriteEndArray() { }

	[Address(RVA = "0x21076C0", Offset = "0x2106AC0", Length = "0xCA")]
	[Token(Token = "0x60003F9")]
	public override Task WriteEndArrayAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2107870", Offset = "0x2106C70", Length = "0xDD")]
	[Token(Token = "0x60003F1")]
	protected override Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	[Address(RVA = "0x21077A0", Offset = "0x2106BA0", Length = "0xCA")]
	[Token(Token = "0x60003F6")]
	public override Task WriteEndAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2107A20", Offset = "0x2106E20", Length = "0xD")]
	[Token(Token = "0x600045E")]
	public override void WriteEndConstructor() { }

	[Address(RVA = "0x2107950", Offset = "0x2106D50", Length = "0xCA")]
	[Token(Token = "0x60003FA")]
	public override Task WriteEndConstructorAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2107A30", Offset = "0x2106E30", Length = "0x179")]
	[Token(Token = "0x60003F7")]
	internal Task WriteEndInternalAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2107C80", Offset = "0x2107080", Length = "0xD")]
	[Token(Token = "0x600045A")]
	public override void WriteEndObject() { }

	[Address(RVA = "0x2107BB0", Offset = "0x2106FB0", Length = "0xCA")]
	[Token(Token = "0x60003FB")]
	public override Task WriteEndObjectAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000472")]
	protected override void WriteIndent() { }

	[Address(RVA = "0x2107E80", Offset = "0x2107280", Length = "0xCA")]
	[Token(Token = "0x60003F2")]
	protected override Task WriteIndentAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000474")]
	protected override void WriteIndentSpace() { }

	[Address(RVA = "0x2107F50", Offset = "0x2107350", Length = "0xCA")]
	[Token(Token = "0x60003F4")]
	protected override Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x21080F0", Offset = "0x21074F0", Length = "0x16")]
	[Token(Token = "0x6000476")]
	public override void WriteNull() { }

	[Address(RVA = "0x2108020", Offset = "0x2107420", Length = "0xCA")]
	[Token(Token = "0x60003FC")]
	public override Task WriteNullAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2105F50", Offset = "0x2105350", Length = "0x2B")]
	[Token(Token = "0x600045F")]
	public override void WritePropertyName(string name) { }

	[Address(RVA = "0x21082F0", Offset = "0x21076F0", Length = "0x14")]
	[Token(Token = "0x6000460")]
	public override void WritePropertyName(string name, bool escape) { }

	[Address(RVA = "0x21081F0", Offset = "0x21075F0", Length = "0xF6")]
	[Token(Token = "0x60003FE")]
	public override Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2108110", Offset = "0x2107510", Length = "0xDF")]
	[Token(Token = "0x60003FD")]
	public override Task WritePropertyNameAsync(string name, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[NullableContext(2)]
	[Token(Token = "0x6000478")]
	public override void WriteRaw(string json) { }

	[Address(RVA = "0x2108310", Offset = "0x2107710", Length = "0xDF")]
	[Token(Token = "0x60003F5")]
	public override Task WriteRawAsync(string json, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x21084D0", Offset = "0x21078D0", Length = "0x4A")]
	[NullableContext(2)]
	[Token(Token = "0x6000479")]
	public override void WriteRawValue(string json) { }

	[Address(RVA = "0x21083F0", Offset = "0x21077F0", Length = "0xDF")]
	[Token(Token = "0x6000404")]
	public override Task WriteRawValueAsync(string json, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x21085F0", Offset = "0x21079F0", Length = "0x10")]
	[Token(Token = "0x600045B")]
	public override void WriteStartArray() { }

	[Address(RVA = "0x2108520", Offset = "0x2107920", Length = "0xCA")]
	[Token(Token = "0x6000400")]
	public override Task WriteStartArrayAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x21086E0", Offset = "0x2107AE0", Length = "0x10")]
	[Token(Token = "0x600045D")]
	public override void WriteStartConstructor(string name) { }

	[Address(RVA = "0x2108600", Offset = "0x2107A00", Length = "0xDF")]
	[Token(Token = "0x6000405")]
	public override Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x21087C0", Offset = "0x2107BC0", Length = "0x10")]
	[Token(Token = "0x6000459")]
	public override void WriteStartObject() { }

	[Address(RVA = "0x21086F0", Offset = "0x2107AF0", Length = "0xCA")]
	[Token(Token = "0x6000406")]
	public override Task WriteStartObjectAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x21098F0", Offset = "0x2108CF0", Length = "0x854")]
	[NullableContext(2)]
	[Token(Token = "0x6000464")]
	public void WriteToken(JsonToken token, object value) { }

	[Address(RVA = "0x21098E0", Offset = "0x2108CE0", Length = "0xB")]
	[Token(Token = "0x6000465")]
	public void WriteToken(JsonToken token) { }

	[Address(RVA = "0x2109550", Offset = "0x2108950", Length = "0x374")]
	[Token(Token = "0x6000466")]
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	[Address(RVA = "0x21098D0", Offset = "0x2108CD0", Length = "0xB")]
	[Token(Token = "0x6000462")]
	public void WriteToken(JsonReader reader) { }

	[Address(RVA = "0x210A190", Offset = "0x2109590", Length = "0x82")]
	[Token(Token = "0x6000463")]
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	[Address(RVA = "0x2109370", Offset = "0x2108770", Length = "0x94")]
	[Token(Token = "0x6000408")]
	public Task WriteTokenAsync(JsonReader reader, bool writeChildren, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2109410", Offset = "0x2108810", Length = "0x1D")]
	[Token(Token = "0x6000409")]
	public Task WriteTokenAsync(JsonToken token, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x21089A0", Offset = "0x2107DA0", Length = "0xE0")]
	[Token(Token = "0x600040A")]
	public Task WriteTokenAsync(JsonToken token, object value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x21087D0", Offset = "0x2107BD0", Length = "0x138")]
	[AsyncStateMachine(typeof(<WriteTokenAsync>d__30))]
	[Token(Token = "0x600040B")]
	internal override Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2108910", Offset = "0x2107D10", Length = "0x86")]
	[Token(Token = "0x6000407")]
	public Task WriteTokenAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2109430", Offset = "0x2108830", Length = "0x116")]
	[AsyncStateMachine(typeof(<WriteTokenSyncReadingAsync>d__31))]
	[Token(Token = "0x600040C")]
	internal Task WriteTokenSyncReadingAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[Address(RVA = "0x210A2F0", Offset = "0x21096F0", Length = "0x16")]
	[Token(Token = "0x6000477")]
	public override void WriteUndefined() { }

	[Address(RVA = "0x210A220", Offset = "0x2109620", Length = "0xCA")]
	[Token(Token = "0x6000434")]
	public override Task WriteUndefinedAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210DB20", Offset = "0x210CF20", Length = "0x82")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000497")]
	public override void WriteValue(Nullable<SByte> value) { }

	[Address(RVA = "0x210DD70", Offset = "0x210D170", Length = "0x16")]
	[NullableContext(2)]
	[Token(Token = "0x600047A")]
	public override void WriteValue(string value) { }

	[Address(RVA = "0x210D9D0", Offset = "0x210CDD0", Length = "0x16")]
	[Token(Token = "0x600047B")]
	public override void WriteValue(int value) { }

	[Address(RVA = "0x210D9D0", Offset = "0x210CDD0", Length = "0x16")]
	[CLSCompliant(False)]
	[Token(Token = "0x600047C")]
	public override void WriteValue(uint value) { }

	[Address(RVA = "0x210D9D0", Offset = "0x210CDD0", Length = "0x16")]
	[Token(Token = "0x600047D")]
	public override void WriteValue(long value) { }

	[Address(RVA = "0x210D9D0", Offset = "0x210CDD0", Length = "0x16")]
	[CLSCompliant(False)]
	[Token(Token = "0x600047E")]
	public override void WriteValue(ulong value) { }

	[Address(RVA = "0x210DBB0", Offset = "0x210CFB0", Length = "0x16")]
	[Token(Token = "0x600047F")]
	public override void WriteValue(float value) { }

	[Address(RVA = "0x210DEA0", Offset = "0x210D2A0", Length = "0x16")]
	[Token(Token = "0x6000481")]
	public override void WriteValue(bool value) { }

	[Address(RVA = "0x210D9D0", Offset = "0x210CDD0", Length = "0x16")]
	[Token(Token = "0x6000482")]
	public override void WriteValue(short value) { }

	[Address(RVA = "0x210D9D0", Offset = "0x210CDD0", Length = "0x16")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000483")]
	public override void WriteValue(ushort value) { }

	[Address(RVA = "0x210DD70", Offset = "0x210D170", Length = "0x16")]
	[Token(Token = "0x6000484")]
	public override void WriteValue(char value) { }

	[Address(RVA = "0x210D9D0", Offset = "0x210CDD0", Length = "0x16")]
	[Token(Token = "0x6000485")]
	public override void WriteValue(byte value) { }

	[Address(RVA = "0x210D9D0", Offset = "0x210CDD0", Length = "0x16")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000486")]
	public override void WriteValue(sbyte value) { }

	[Address(RVA = "0x210DBB0", Offset = "0x210CFB0", Length = "0x16")]
	[Token(Token = "0x6000487")]
	public override void WriteValue(decimal value) { }

	[Address(RVA = "0x210D9F0", Offset = "0x210CDF0", Length = "0x16")]
	[Token(Token = "0x6000488")]
	public override void WriteValue(DateTime value) { }

	[Address(RVA = "0x210D9F0", Offset = "0x210CDF0", Length = "0x16")]
	[Token(Token = "0x6000489")]
	public override void WriteValue(DateTimeOffset value) { }

	[Address(RVA = "0x210DD70", Offset = "0x210D170", Length = "0x16")]
	[Token(Token = "0x600048A")]
	public override void WriteValue(Guid value) { }

	[Address(RVA = "0x210DBB0", Offset = "0x210CFB0", Length = "0x16")]
	[Token(Token = "0x6000480")]
	public override void WriteValue(double value) { }

	[Address(RVA = "0x210E050", Offset = "0x210D450", Length = "0x1250")]
	[Token(Token = "0x60004A4")]
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	[Address(RVA = "0x210F650", Offset = "0x210EA50", Length = "0x81")]
	[Token(Token = "0x600048C")]
	public override void WriteValue(Nullable<Int32> value) { }

	[Address(RVA = "0x210DE10", Offset = "0x210D210", Length = "0x82")]
	[Token(Token = "0x6000496")]
	public override void WriteValue(Nullable<Byte> value) { }

	[Address(RVA = "0x210DA90", Offset = "0x210CE90", Length = "0x87")]
	[Token(Token = "0x6000498")]
	public override void WriteValue(Nullable<Decimal> value) { }

	[Address(RVA = "0x210DA10", Offset = "0x210CE10", Length = "0x7D")]
	[Token(Token = "0x6000499")]
	public override void WriteValue(Nullable<DateTime> value) { }

	[Address(RVA = "0x210D950", Offset = "0x210CD50", Length = "0x80")]
	[Token(Token = "0x6000495")]
	public override void WriteValue(Nullable<Char> value) { }

	[Address(RVA = "0x210DFC0", Offset = "0x210D3C0", Length = "0x87")]
	[Token(Token = "0x600049A")]
	public override void WriteValue(Nullable<DateTimeOffset> value) { }

	[Address(RVA = "0x210F6E0", Offset = "0x210EAE0", Length = "0x87")]
	[Token(Token = "0x600049B")]
	public override void WriteValue(Nullable<Guid> value) { }

	[Address(RVA = "0x210DC60", Offset = "0x210D060", Length = "0x7D")]
	[Token(Token = "0x600049C")]
	public override void WriteValue(Nullable<TimeSpan> value) { }

	[Address(RVA = "0x210F770", Offset = "0x210EB70", Length = "0x80")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000494")]
	public override void WriteValue(Nullable<UInt16> value) { }

	[Address(RVA = "0x210F620", Offset = "0x210EA20", Length = "0x2F")]
	[NullableContext(2)]
	[Token(Token = "0x600049D")]
	public override void WriteValue(Byte[] value) { }

	[Address(RVA = "0x210DD70", Offset = "0x210D170", Length = "0x16")]
	[Token(Token = "0x600048B")]
	public override void WriteValue(TimeSpan value) { }

	[Address(RVA = "0x210F3C0", Offset = "0x210E7C0", Length = "0x95")]
	[NullableContext(2)]
	[Token(Token = "0x600049E")]
	public override void WriteValue(Uri value) { }

	[Address(RVA = "0x210F460", Offset = "0x210E860", Length = "0x12A")]
	[NullableContext(2)]
	[Token(Token = "0x600049F")]
	public override void WriteValue(object value) { }

	[Address(RVA = "0x210DF40", Offset = "0x210D340", Length = "0x80")]
	[Token(Token = "0x6000493")]
	public override void WriteValue(Nullable<Int16> value) { }

	[Address(RVA = "0x210F590", Offset = "0x210E990", Length = "0x82")]
	[Token(Token = "0x6000492")]
	public override void WriteValue(Nullable<Boolean> value) { }

	[Address(RVA = "0x210DD90", Offset = "0x210D190", Length = "0x7E")]
	[Token(Token = "0x6000491")]
	public override void WriteValue(Nullable<Double> value) { }

	[Address(RVA = "0x210DBD0", Offset = "0x210CFD0", Length = "0x83")]
	[Token(Token = "0x6000490")]
	public override void WriteValue(Nullable<Single> value) { }

	[Address(RVA = "0x210DEC0", Offset = "0x210D2C0", Length = "0x7D")]
	[CLSCompliant(False)]
	[Token(Token = "0x600048F")]
	public override void WriteValue(Nullable<UInt64> value) { }

	[Address(RVA = "0x210F340", Offset = "0x210E740", Length = "0x7D")]
	[Token(Token = "0x600048E")]
	public override void WriteValue(Nullable<Int64> value) { }

	[Address(RVA = "0x210DCE0", Offset = "0x210D0E0", Length = "0x81")]
	[CLSCompliant(False)]
	[Token(Token = "0x600048D")]
	public override void WriteValue(Nullable<UInt32> value) { }

	[Address(RVA = "0x210B500", Offset = "0x210A900", Length = "0xE9")]
	[Token(Token = "0x600042C")]
	public override Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210B090", Offset = "0x210A490", Length = "0xDF")]
	[Token(Token = "0x6000428")]
	public override Task WriteValueAsync(short value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210BD00", Offset = "0x210B100", Length = "0xDD")]
	[Token(Token = "0x6000429")]
	public override Task WriteValueAsync(Nullable<Int16> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210B6D0", Offset = "0x210AAD0", Length = "0xDF")]
	[Token(Token = "0x600042A")]
	public override Task WriteValueAsync(string value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210B890", Offset = "0x210AC90", Length = "0xDF")]
	[Token(Token = "0x600042B")]
	public override Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210B5F0", Offset = "0x210A9F0", Length = "0xDF")]
	[Token(Token = "0x6000423")]
	public override Task WriteValueAsync(long value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210C090", Offset = "0x210B490", Length = "0xDD")]
	[CLSCompliant(False)]
	[Token(Token = "0x600042D")]
	public override Task WriteValueAsync(uint value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210B330", Offset = "0x210A730", Length = "0xE9")]
	[Token(Token = "0x6000417")]
	public override Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210C170", Offset = "0x210B570", Length = "0x12C0")]
	[Token(Token = "0x6000438")]
	internal static Task WriteValueAsync(JsonWriter writer, PrimitiveTypeCode typeCode, object value, CancellationToken cancellationToken) { }

	[Address(RVA = "0x210D6A0", Offset = "0x210CAA0", Length = "0xF4")]
	[Token(Token = "0x6000418")]
	public override Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210BC10", Offset = "0x210B010", Length = "0xE9")]
	[Token(Token = "0x6000419")]
	public override Task WriteValueAsync(decimal value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210AEB0", Offset = "0x210A2B0", Length = "0xF4")]
	[Token(Token = "0x600041A")]
	public override Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210A310", Offset = "0x2109710", Length = "0xE9")]
	[Token(Token = "0x6000424")]
	public override Task WriteValueAsync(Nullable<Int64> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210ACF0", Offset = "0x210A0F0", Length = "0xDF")]
	[Token(Token = "0x6000425")]
	public override Task WriteValueAsync(object value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210B250", Offset = "0x210A650", Length = "0xDF")]
	[Token(Token = "0x600041B")]
	public override Task WriteValueAsync(double value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210B170", Offset = "0x210A570", Length = "0xDF")]
	[Token(Token = "0x600041D")]
	public override Task WriteValueAsync(float value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210B7B0", Offset = "0x210ABB0", Length = "0xDF")]
	[Token(Token = "0x600041E")]
	public override Task WriteValueAsync(Nullable<Single> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210A870", Offset = "0x2109C70", Length = "0xE9")]
	[Token(Token = "0x600041F")]
	public override Task WriteValueAsync(Guid value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210BEC0", Offset = "0x210B2C0", Length = "0xF0")]
	[Token(Token = "0x6000420")]
	public override Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210D7A0", Offset = "0x210CBA0", Length = "0xDD")]
	[Token(Token = "0x6000421")]
	public override Task WriteValueAsync(int value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210AFB0", Offset = "0x210A3B0", Length = "0xDF")]
	[Token(Token = "0x6000422")]
	public override Task WriteValueAsync(Nullable<Int32> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210A400", Offset = "0x2109800", Length = "0xE9")]
	[Token(Token = "0x600041C")]
	public override Task WriteValueAsync(Nullable<Double> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210ADD0", Offset = "0x210A1D0", Length = "0xDF")]
	[Token(Token = "0x6000415")]
	public override Task WriteValueAsync(DateTime value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210D4D0", Offset = "0x210C8D0", Length = "0xE9")]
	[Token(Token = "0x6000416")]
	public override Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210BFB0", Offset = "0x210B3B0", Length = "0xE0")]
	[Token(Token = "0x600040E")]
	public override Task WriteValueAsync(bool value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210BA50", Offset = "0x210AE50", Length = "0xDF")]
	[CLSCompliant(False)]
	[Token(Token = "0x600042E")]
	public override Task WriteValueAsync(Nullable<UInt32> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210D5C0", Offset = "0x210C9C0", Length = "0xE0")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000426")]
	public override Task WriteValueAsync(sbyte value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210BDE0", Offset = "0x210B1E0", Length = "0xDF")]
	[CLSCompliant(False)]
	[Token(Token = "0x600042F")]
	public override Task WriteValueAsync(ulong value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210A960", Offset = "0x2109D60", Length = "0xE9")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000430")]
	public override Task WriteValueAsync(Nullable<UInt64> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210A6B0", Offset = "0x2109AB0", Length = "0xDF")]
	[Token(Token = "0x6000431")]
	public override Task WriteValueAsync(Uri value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210A4F0", Offset = "0x21098F0", Length = "0xDF")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000432")]
	public override Task WriteValueAsync(ushort value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210A5D0", Offset = "0x21099D0", Length = "0xDD")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000433")]
	public override Task WriteValueAsync(Nullable<UInt16> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210A790", Offset = "0x2109B90", Length = "0xDF")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000427")]
	public override Task WriteValueAsync(Nullable<SByte> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210AB30", Offset = "0x2109F30", Length = "0xE0")]
	[Token(Token = "0x6000410")]
	public override Task WriteValueAsync(byte value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210B970", Offset = "0x210AD70", Length = "0xDF")]
	[Token(Token = "0x6000411")]
	public override Task WriteValueAsync(Nullable<Byte> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210AA50", Offset = "0x2109E50", Length = "0xDF")]
	[Token(Token = "0x6000412")]
	public override Task WriteValueAsync(Byte[] value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210B420", Offset = "0x210A820", Length = "0xDF")]
	[Token(Token = "0x6000413")]
	public override Task WriteValueAsync(char value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210BB30", Offset = "0x210AF30", Length = "0xDD")]
	[Token(Token = "0x6000414")]
	public override Task WriteValueAsync(Nullable<Char> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x210AC10", Offset = "0x210A010", Length = "0xDF")]
	[Token(Token = "0x600040F")]
	public override Task WriteValueAsync(Nullable<Boolean> value, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000473")]
	protected override void WriteValueDelimiter() { }

	[Address(RVA = "0x210D880", Offset = "0x210CC80", Length = "0xCA")]
	[Token(Token = "0x60003F3")]
	protected override Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2106310", Offset = "0x2105710", Length = "0x5B")]
	[Token(Token = "0x60004A1")]
	public override void WriteWhitespace(string ws) { }

	[Address(RVA = "0x210F7F0", Offset = "0x210EBF0", Length = "0xDF")]
	[Token(Token = "0x6000435")]
	public override Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken = null) { }

}

