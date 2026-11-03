namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000D0")]
internal static class JavaScriptUtils
{
	[CompilerGenerated]
	[Token(Token = "0x20000D1")]
	private struct <WriteCharAsync>d__14 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000485")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000486")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000487")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000488")]
		public TextWriter writer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000489")]
		public char c; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400048A")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400048B")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2131F20", Offset = "0x2131320", Length = "0x269")]
		[Token(Token = "0x6000655")]
		private override void MoveNext() { }

		[Address(RVA = "0x2132190", Offset = "0x2131590", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000656")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D2")]
	private struct <WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400048C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400048D")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400048E")]
		public Char[] writeBuffer; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400048F")]
		public int lastWritePosition; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000490")]
		public JsonTextWriter client; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x4000491")]
		public string s; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x4000492")]
		public TextWriter writer; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000493")]
		public CancellationToken cancellationToken; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Nullable(0)]
		[Token(Token = "0x4000494")]
		public Boolean[] charEscapeFlags; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000495")]
		public StringEscapeHandling stringEscapeHandling; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4000496")]
		private bool <isEscapedUnicodeText>5__2; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Nullable(0)]
		[Token(Token = "0x4000497")]
		private string <escapedValue>5__3; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000498")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000499")]
		private int <i>5__4; //Field offset: 0x78

		[Address(RVA = "0x21328C0", Offset = "0x2131CC0", Length = "0xB18")]
		[Token(Token = "0x6000657")]
		private override void MoveNext() { }

		[Address(RVA = "0x21333F0", Offset = "0x21327F0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000658")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D3")]
	private struct <WriteEscapedJavaScriptStringWithDelimitersAsync>d__13 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400049B")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400049C")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x400049D")]
		public string s; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x400049E")]
		public TextWriter writer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x400049F")]
		public Boolean[] charEscapeFlags; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40004A0")]
		public StringEscapeHandling stringEscapeHandling; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x40004A1")]
		public JsonTextWriter client; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Nullable(0)]
		[Token(Token = "0x40004A2")]
		public Char[] writeBuffer; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40004A3")]
		public CancellationToken cancellationToken; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40004A4")]
		public char delimiter; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40004A5")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x68

		[Address(RVA = "0x2133450", Offset = "0x2132850", Length = "0x3AE")]
		[Token(Token = "0x6000659")]
		private override void MoveNext() { }

		[Address(RVA = "0x2133800", Offset = "0x2132C00", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600065A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x4000480")]
	internal static readonly Boolean[] SingleQuoteCharEscapeFlags; //Field offset: 0x0
	[Token(Token = "0x4000483")]
	private const int UnicodeTextLength = 6; //Field offset: 0x0
	[Token(Token = "0x4000484")]
	private const string EscapedUnicodeText = "!"; //Field offset: 0x0
	[Token(Token = "0x4000481")]
	internal static readonly Boolean[] DoubleQuoteCharEscapeFlags; //Field offset: 0x8
	[Token(Token = "0x4000482")]
	internal static readonly Boolean[] HtmlCharEscapeFlags; //Field offset: 0x10

	[Address(RVA = "0x2129AF0", Offset = "0x2128EF0", Length = "0xA8C")]
	[Token(Token = "0x6000647")]
	private static JavaScriptUtils() { }

	[Address(RVA = "0x2127B10", Offset = "0x2126F10", Length = "0xAF")]
	[Token(Token = "0x600064C")]
	private static int FirstCharToEscape(string s, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	[Address(RVA = "0x2127BC0", Offset = "0x2126FC0", Length = "0xC6")]
	[Token(Token = "0x6000648")]
	public static Boolean[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	[Address(RVA = "0x2127C90", Offset = "0x2127090", Length = "0x84")]
	[Token(Token = "0x6000649")]
	public static bool ShouldEscapeJavaScriptString(string s, Boolean[] charEscapeFlags) { }

	[Address(RVA = "0x2127D20", Offset = "0x2127120", Length = "0x241")]
	[Token(Token = "0x600064B")]
	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	[Address(RVA = "0x2127F70", Offset = "0x2127370", Length = "0x1D6")]
	[Token(Token = "0x6000654")]
	private static bool TryGetDateConstructorValue(JsonReader reader, out Nullable<Int64>& integer, out string errorMessage) { }

	[Address(RVA = "0x2128150", Offset = "0x2127550", Length = "0x49C")]
	[Token(Token = "0x6000653")]
	public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage) { }

	[Address(RVA = "0x21285F0", Offset = "0x21279F0", Length = "0x128")]
	[AsyncStateMachine(typeof(<WriteCharAsync>d__14))]
	[Token(Token = "0x6000650")]
	public static Task WriteCharAsync(Task task, TextWriter writer, char c, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2128720", Offset = "0x2127B20", Length = "0x166")]
	[AsyncStateMachine(typeof(<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16))]
	[Token(Token = "0x6000652")]
	private static Task WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, int lastWritePosition, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x21292C0", Offset = "0x21286C0", Length = "0x814")]
	[NullableContext(2)]
	[Token(Token = "0x600064A")]
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<Char> bufferPool, ref Char[] writeBuffer) { }

	[Address(RVA = "0x2128890", Offset = "0x2127C90", Length = "0x268")]
	[Token(Token = "0x600064D")]
	public static Task WriteEscapedJavaScriptStringAsync(TextWriter writer, string s, char delimiter, bool appendDelimiters, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2128C80", Offset = "0x2128080", Length = "0x3A8")]
	[Token(Token = "0x600064E")]
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(TextWriter writer, string s, char delimiter, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2128B00", Offset = "0x2127F00", Length = "0x17A")]
	[AsyncStateMachine(typeof(<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13))]
	[Token(Token = "0x600064F")]
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(Task task, TextWriter writer, string s, char delimiter, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2129030", Offset = "0x2128430", Length = "0x28D")]
	[Token(Token = "0x6000651")]
	private static Task WriteEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

}

