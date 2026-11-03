namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x2000028")]
public abstract class JsonReader : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x200002A")]
	private struct <MoveToContentFromNonContentAsync>d__14 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000080")]
		public JsonReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000081")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000082")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20E7830", Offset = "0x20E6C30", Length = "0x25C")]
		[Token(Token = "0x6000129")]
		private override void MoveNext() { }

		[Address(RVA = "0x20E7A90", Offset = "0x20E6E90", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600012A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002B")]
	private struct <ReadAndMoveToContentAsync>d__12 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000083")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000085")]
		public JsonReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000086")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000087")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20E7B00", Offset = "0x20E6F00", Length = "0x45A")]
		[Token(Token = "0x600012B")]
		private override void MoveNext() { }

		[Address(RVA = "0x20E7F60", Offset = "0x20E7360", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600012C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002C")]
	private struct <ReadArrayIntoByteArrayAsync>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000088")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400008A")]
		public JsonReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400008B")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x400008C")]
		private List<Byte> <buffer>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x400008D")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x20E7FD0", Offset = "0x20E73D0", Length = "0x326")]
		[Token(Token = "0x600012D")]
		private override void MoveNext() { }

		[Address(RVA = "0x20E8300", Offset = "0x20E7700", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600012E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002D")]
	private struct <ReaderReadAndAssertAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000090")]
		public JsonReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000091")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000092")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20E8370", Offset = "0x20E7770", Length = "0x205")]
		[Token(Token = "0x600012F")]
		private override void MoveNext() { }

		[Address(RVA = "0x20E8580", Offset = "0x20E7980", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000130")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002E")]
	private struct <SkipAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000093")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000095")]
		public JsonReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000096")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000097")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000098")]
		private int <depth>5__2; //Field offset: 0x40

		[Address(RVA = "0x20E85E0", Offset = "0x20E79E0", Length = "0x387")]
		[Token(Token = "0x6000131")]
		private override void MoveNext() { }

		[Address(RVA = "0x20E8970", Offset = "0x20E7D70", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000132")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[NullableContext(0)]
	[Token(Token = "0x2000029")]
	private enum State : int
	{
		Start = 0,
		Complete = 1,
		Property = 2,
		ObjectStart = 3,
		Object = 4,
		ArrayStart = 5,
		Array = 6,
		Closed = 7,
		PostValue = 8,
		ConstructorStart = 9,
		Constructor = 10,
		Error = 11,
		Finished = 12,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000061")]
	private JsonToken _tokenType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000062")]
	private object _value; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000063")]
	internal char _quoteChar; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000064")]
	internal State _currentState; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000065")]
	private JsonPosition _currentPosition; //Field offset: 0x28
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000066")]
	private CultureInfo _culture; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000067")]
	private DateTimeZoneHandling _dateTimeZoneHandling; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000068")]
	private Nullable<Int32> _maxDepth; //Field offset: 0x4C
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000069")]
	private bool _hasExceededMaxDepth; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400006A")]
	internal DateParseHandling _dateParseHandling; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400006B")]
	internal FloatParseHandling _floatParseHandling; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400006C")]
	private string _dateFormatString; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400006D")]
	private List<JsonPosition> _stack; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400006E")]
	private bool <CloseInput>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x400006F")]
	private bool <SupportMultipleContent>k__BackingField; //Field offset: 0x71

	[Token(Token = "0x1700002E")]
	public bool CloseInput
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 5
		[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000E7")]
		 set { } //Length: 4
	}

	[Nullable(1)]
	[Token(Token = "0x1700003B")]
	public CultureInfo Culture
	{
		[Address(RVA = "0x20D3BC0", Offset = "0x20D2FC0", Length = "0x54")]
		[NullableContext(1)]
		[Token(Token = "0x60000FB")]
		 get { } //Length: 84
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[NullableContext(1)]
		[Token(Token = "0x60000FC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002D")]
	protected State CurrentState
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60000E5")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000034")]
	public string DateFormatString
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60000F2")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x60000F3")]
		 set { } //Length: 995
	}

	[Token(Token = "0x17000032")]
	public DateParseHandling DateParseHandling
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x60000EE")]
		 get { } //Length: 4
		[Address(RVA = "0x20D3DC0", Offset = "0x20D31C0", Length = "0x63")]
		[Token(Token = "0x60000EF")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000031")]
	public DateTimeZoneHandling DateTimeZoneHandling
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60000EC")]
		 get { } //Length: 4
		[Address(RVA = "0x20D3E30", Offset = "0x20D3230", Length = "0x63")]
		[Token(Token = "0x60000ED")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000039")]
	public override int Depth
	{
		[Address(RVA = "0x20D3C20", Offset = "0x20D3020", Length = "0x6F")]
		[Token(Token = "0x60000F9")]
		 get { } //Length: 111
	}

	[Token(Token = "0x17000033")]
	public FloatParseHandling FloatParseHandling
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[Token(Token = "0x60000F0")]
		 get { } //Length: 4
		[Address(RVA = "0x20D3EA0", Offset = "0x20D32A0", Length = "0x63")]
		[Token(Token = "0x60000F1")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000035")]
	public Nullable<Int32> MaxDepth
	{
		[Address(RVA = "0x20D3C90", Offset = "0x20D3090", Length = "0x5")]
		[Token(Token = "0x60000F4")]
		 get { } //Length: 5
		[Address(RVA = "0x20D3F10", Offset = "0x20D3310", Length = "0xB1")]
		[Token(Token = "0x60000F5")]
		 set { } //Length: 177
	}

	[Nullable(1)]
	[Token(Token = "0x1700003A")]
	public override string Path
	{
		[Address(RVA = "0x20D3CA0", Offset = "0x20D30A0", Length = "0xFC")]
		[NullableContext(1)]
		[Token(Token = "0x60000FA")]
		 get { } //Length: 252
	}

	[Token(Token = "0x17000030")]
	public private override char QuoteChar
	{
		[Address(RVA = "0x111BFD0", Offset = "0x111B3D0", Length = "0x5")]
		[Token(Token = "0x60000EA")]
		 get { } //Length: 5
		[Address(RVA = "0x20D3FD0", Offset = "0x20D33D0", Length = "0x5")]
		[Token(Token = "0x60000EB")]
		private set { } //Length: 5
	}

	[Token(Token = "0x1700002F")]
	public bool SupportMultipleContent
	{
		[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000E8")]
		 get { } //Length: 5
		[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000E9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000036")]
	public override JsonToken TokenType
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60000F6")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000037")]
	public override object Value
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60000F7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000038")]
	public override Type ValueType
	{
		[Address(RVA = "0x20D3DA0", Offset = "0x20D31A0", Length = "0x13")]
		[Token(Token = "0x60000F8")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x20D3B40", Offset = "0x20D2F40", Length = "0x71")]
	[Token(Token = "0x60000FE")]
	protected JsonReader() { }

	[Address(RVA = "0x20CE8B0", Offset = "0x20CDCB0", Length = "0x1B")]
	[Token(Token = "0x6000122")]
	public override void Close() { }

	[Address(RVA = "0x20CE8D0", Offset = "0x20CDCD0", Length = "0x3F")]
	[NullableContext(1)]
	[Token(Token = "0x6000114")]
	internal JsonReaderException CreateUnexpectedEndException() { }

	[Address(RVA = "0x20CE910", Offset = "0x20CDD10", Length = "0x25")]
	[Token(Token = "0x6000121")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000E6")]
	public bool get_CloseInput() { }

	[Address(RVA = "0x20D3BC0", Offset = "0x20D2FC0", Length = "0x54")]
	[NullableContext(1)]
	[Token(Token = "0x60000FB")]
	public CultureInfo get_Culture() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x60000E5")]
	protected State get_CurrentState() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60000F2")]
	public string get_DateFormatString() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x60000EE")]
	public DateParseHandling get_DateParseHandling() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60000EC")]
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	[Address(RVA = "0x20D3C20", Offset = "0x20D3020", Length = "0x6F")]
	[Token(Token = "0x60000F9")]
	public override int get_Depth() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[Token(Token = "0x60000F0")]
	public FloatParseHandling get_FloatParseHandling() { }

	[Address(RVA = "0x20D3C90", Offset = "0x20D3090", Length = "0x5")]
	[Token(Token = "0x60000F4")]
	public Nullable<Int32> get_MaxDepth() { }

	[Address(RVA = "0x20D3CA0", Offset = "0x20D30A0", Length = "0xFC")]
	[NullableContext(1)]
	[Token(Token = "0x60000FA")]
	public override string get_Path() { }

	[Address(RVA = "0x111BFD0", Offset = "0x111B3D0", Length = "0x5")]
	[Token(Token = "0x60000EA")]
	public override char get_QuoteChar() { }

	[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000E8")]
	public bool get_SupportMultipleContent() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60000F6")]
	public override JsonToken get_TokenType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60000F7")]
	public override object get_Value() { }

	[Address(RVA = "0x20D3DA0", Offset = "0x20D31A0", Length = "0x13")]
	[Token(Token = "0x60000F8")]
	public override Type get_ValueType() { }

	[Address(RVA = "0x20CE940", Offset = "0x20CDD40", Length = "0x69")]
	[Token(Token = "0x6000128")]
	private JsonToken GetContentToken() { }

	[Address(RVA = "0x20CE9B0", Offset = "0x20CDDB0", Length = "0xA2")]
	[Token(Token = "0x60000FD")]
	internal JsonPosition GetPosition(int depth) { }

	[Address(RVA = "0x20CEA60", Offset = "0x20CDE60", Length = "0xE1")]
	[Token(Token = "0x600011F")]
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	[Address(RVA = "0x20CEE00", Offset = "0x20CE200", Length = "0x5B")]
	[Token(Token = "0x6000127")]
	internal bool MoveToContent() { }

	[Address(RVA = "0x20CEB50", Offset = "0x20CDF50", Length = "0x18B")]
	[NullableContext(1)]
	[Token(Token = "0x60000E3")]
	internal Task<Boolean> MoveToContentAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20CECE0", Offset = "0x20CE0E0", Length = "0x115")]
	[AsyncStateMachine(typeof(<MoveToContentFromNonContentAsync>d__14))]
	[NullableContext(1)]
	[Token(Token = "0x60000E4")]
	private Task<Boolean> MoveToContentFromNonContentAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000101")]
	private JsonContainerType Peek() { }

	[Address(RVA = "0x20CEE60", Offset = "0x20CE260", Length = "0x13C")]
	[Token(Token = "0x6000100")]
	private JsonContainerType Pop() { }

	[Address(RVA = "0x20CEFA0", Offset = "0x20CE3A0", Length = "0x34F")]
	[Token(Token = "0x60000FF")]
	private void Push(JsonContainerType value) { }

	[Token(Token = "0x6000102")]
	public abstract bool Read() { }

	[Address(RVA = "0x20CF2F0", Offset = "0x20CE6F0", Length = "0x5A")]
	[Token(Token = "0x6000123")]
	internal void ReadAndAssert() { }

	[Address(RVA = "0x20CF470", Offset = "0x20CE870", Length = "0x57")]
	[Token(Token = "0x6000126")]
	internal bool ReadAndMoveToContent() { }

	[Address(RVA = "0x20CF350", Offset = "0x20CE750", Length = "0x115")]
	[AsyncStateMachine(typeof(<ReadAndMoveToContentAsync>d__12))]
	[NullableContext(1)]
	[Token(Token = "0x60000E2")]
	internal Task<Boolean> ReadAndMoveToContentAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20CF4D0", Offset = "0x20CE8D0", Length = "0x241")]
	[NullableContext(1)]
	[Token(Token = "0x6000108")]
	private bool ReadArrayElementIntoByteArrayReportDone(List<Byte> buffer) { }

	[Address(RVA = "0x20CF840", Offset = "0x20CEC40", Length = "0xF9")]
	[NullableContext(1)]
	[Token(Token = "0x6000107")]
	internal Byte[] ReadArrayIntoByteArray() { }

	[Address(RVA = "0x20CF720", Offset = "0x20CEB20", Length = "0x11E")]
	[AsyncStateMachine(typeof(<ReadArrayIntoByteArrayAsync>d__5))]
	[Token(Token = "0x60000DB")]
	internal Task<Byte[]> ReadArrayIntoByteArrayAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20CFA10", Offset = "0x20CEE10", Length = "0x394")]
	[Token(Token = "0x600010B")]
	public override Nullable<Boolean> ReadAsBoolean() { }

	[Address(RVA = "0x20CF940", Offset = "0x20CED40", Length = "0xC1")]
	[NullableContext(1)]
	[Token(Token = "0x60000D9")]
	public override Task<Nullable`1<Boolean>> ReadAsBooleanAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20CFEA0", Offset = "0x20CF2A0", Length = "0x44E")]
	[Token(Token = "0x6000106")]
	public override Byte[] ReadAsBytes() { }

	[Address(RVA = "0x20CFDD0", Offset = "0x20CF1D0", Length = "0xC1")]
	[Token(Token = "0x60000DA")]
	public override Task<Byte[]> ReadAsBytesAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20D07E0", Offset = "0x20CFBE0", Length = "0x2EB")]
	[Token(Token = "0x600010F")]
	public override Nullable<DateTime> ReadAsDateTime() { }

	[Address(RVA = "0x20D02F0", Offset = "0x20CF6F0", Length = "0xD9")]
	[NullableContext(1)]
	[Token(Token = "0x60000DC")]
	public override Task<Nullable`1<DateTime>> ReadAsDateTimeAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20D04C0", Offset = "0x20CF8C0", Length = "0x31E")]
	[Token(Token = "0x6000111")]
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	[Address(RVA = "0x20D03D0", Offset = "0x20CF7D0", Length = "0xEE")]
	[NullableContext(1)]
	[Token(Token = "0x60000DD")]
	public override Task<Nullable`1<DateTimeOffset>> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20D0BC0", Offset = "0x20CFFC0", Length = "0x48C")]
	[Token(Token = "0x600010D")]
	public override Nullable<Decimal> ReadAsDecimal() { }

	[Address(RVA = "0x20D0AD0", Offset = "0x20CFED0", Length = "0xEE")]
	[NullableContext(1)]
	[Token(Token = "0x60000DE")]
	public override Task<Nullable`1<Decimal>> ReadAsDecimalAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20D1100", Offset = "0x20D0500", Length = "0x354")]
	[Token(Token = "0x6000109")]
	public override Nullable<Double> ReadAsDouble() { }

	[Address(RVA = "0x20D1070", Offset = "0x20D0470", Length = "0x8B")]
	[NullableContext(1)]
	[Token(Token = "0x60000DF")]
	public override Task<Nullable`1<Double>> ReadAsDoubleAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20D1550", Offset = "0x20D0950", Length = "0xC0")]
	[Token(Token = "0x6000103")]
	public override Nullable<Int32> ReadAsInt32() { }

	[Address(RVA = "0x20D1480", Offset = "0x20D0880", Length = "0xC1")]
	[NullableContext(1)]
	[Token(Token = "0x60000E0")]
	public override Task<Nullable`1<Int32>> ReadAsInt32Async(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20D1A20", Offset = "0x20D0E20", Length = "0x2EF")]
	[Token(Token = "0x6000105")]
	public override string ReadAsString() { }

	[Address(RVA = "0x20D1950", Offset = "0x20D0D50", Length = "0xC1")]
	[Token(Token = "0x60000E1")]
	public override Task<String> ReadAsStringAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20D1D10", Offset = "0x20D1110", Length = "0xA4")]
	[NullableContext(1)]
	[Token(Token = "0x60000D6")]
	public override Task<Boolean> ReadAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20D1DC0", Offset = "0x20D11C0", Length = "0x183")]
	[Token(Token = "0x600010C")]
	internal Nullable<Boolean> ReadBooleanString(string s) { }

	[Address(RVA = "0x20D1F50", Offset = "0x20D1350", Length = "0x309")]
	[Token(Token = "0x6000112")]
	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	[Address(RVA = "0x20D2260", Offset = "0x20D1660", Length = "0x2AC")]
	[Token(Token = "0x6000110")]
	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	[Address(RVA = "0x20D2510", Offset = "0x20D1910", Length = "0x2E1")]
	[Token(Token = "0x600010E")]
	internal Nullable<Decimal> ReadDecimalString(string s) { }

	[Address(RVA = "0x20D2800", Offset = "0x20D1C00", Length = "0x1B6")]
	[Token(Token = "0x600010A")]
	internal Nullable<Double> ReadDoubleString(string s) { }

	[Address(RVA = "0x20D3220", Offset = "0x20D2620", Length = "0x4A")]
	[Token(Token = "0x6000113")]
	internal void ReaderReadAndAssert() { }

	[Address(RVA = "0x20D3130", Offset = "0x20D2530", Length = "0xF0")]
	[AsyncStateMachine(typeof(<ReaderReadAndAssertAsync>d__2))]
	[NullableContext(1)]
	[Token(Token = "0x60000D8")]
	internal Task ReaderReadAndAssertAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20D2A10", Offset = "0x20D1E10", Length = "0x28C")]
	[Token(Token = "0x6000125")]
	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	[Address(RVA = "0x20D29C0", Offset = "0x20D1DC0", Length = "0x4F")]
	[Token(Token = "0x6000124")]
	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	[Address(RVA = "0x20D2CD0", Offset = "0x20D20D0", Length = "0x1B0")]
	[Token(Token = "0x6000104")]
	internal Nullable<Int32> ReadInt32String(string s) { }

	[Address(RVA = "0x20D2E90", Offset = "0x20D2290", Length = "0x29D")]
	[Token(Token = "0x6000115")]
	internal void ReadIntoWrappedTypeObject() { }

	[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000E7")]
	public void set_CloseInput(bool value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[NullableContext(1)]
	[Token(Token = "0x60000FC")]
	public void set_Culture(CultureInfo value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x60000F3")]
	public void set_DateFormatString(string value) { }

	[Address(RVA = "0x20D3DC0", Offset = "0x20D31C0", Length = "0x63")]
	[Token(Token = "0x60000EF")]
	public void set_DateParseHandling(DateParseHandling value) { }

	[Address(RVA = "0x20D3E30", Offset = "0x20D3230", Length = "0x63")]
	[Token(Token = "0x60000ED")]
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	[Address(RVA = "0x20D3EA0", Offset = "0x20D32A0", Length = "0x63")]
	[Token(Token = "0x60000F1")]
	public void set_FloatParseHandling(FloatParseHandling value) { }

	[Address(RVA = "0x20D3F10", Offset = "0x20D3310", Length = "0xB1")]
	[Token(Token = "0x60000F5")]
	public void set_MaxDepth(Nullable<Int32> value) { }

	[Address(RVA = "0x20D3FD0", Offset = "0x20D33D0", Length = "0x5")]
	[Token(Token = "0x60000EB")]
	protected private override void set_QuoteChar(char value) { }

	[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000E9")]
	public void set_SupportMultipleContent(bool value) { }

	[Address(RVA = "0x20D3270", Offset = "0x20D2670", Length = "0x13")]
	[Token(Token = "0x600011E")]
	private void SetFinished() { }

	[Address(RVA = "0x20D3290", Offset = "0x20D2690", Length = "0x27")]
	[Token(Token = "0x600011A")]
	internal void SetPostValueState(bool updateIndex) { }

	[Address(RVA = "0x20D32C0", Offset = "0x20D26C0", Length = "0x103")]
	[Token(Token = "0x600011D")]
	protected void SetStateBasedOnCurrent() { }

	[Address(RVA = "0x20D35D0", Offset = "0x20D29D0", Length = "0x1D")]
	[Token(Token = "0x6000117")]
	protected void SetToken(JsonToken newToken) { }

	[Address(RVA = "0x20D35B0", Offset = "0x20D29B0", Length = "0x1A")]
	[Token(Token = "0x6000118")]
	protected void SetToken(JsonToken newToken, object value) { }

	[Address(RVA = "0x20D33D0", Offset = "0x20D27D0", Length = "0x194")]
	[Token(Token = "0x6000119")]
	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	[Address(RVA = "0x20D36F0", Offset = "0x20D2AF0", Length = "0xC0")]
	[Token(Token = "0x6000116")]
	public void Skip() { }

	[Address(RVA = "0x20D35F0", Offset = "0x20D29F0", Length = "0xF9")]
	[AsyncStateMachine(typeof(<SkipAsync>d__1))]
	[NullableContext(1)]
	[Token(Token = "0x60000D7")]
	public Task SkipAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20D37B0", Offset = "0x20D2BB0", Length = "0x61")]
	[Token(Token = "0x6000120")]
	private override void System.IDisposable.Dispose() { }

	[Address(RVA = "0x20D3820", Offset = "0x20D2C20", Length = "0xA")]
	[Token(Token = "0x600011B")]
	private void UpdateScopeWithFinishedValue() { }

	[Address(RVA = "0x20D3830", Offset = "0x20D2C30", Length = "0x306")]
	[Token(Token = "0x600011C")]
	private void ValidateEnd(JsonToken endToken) { }

}

