namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000161")]
public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
{
	[CompilerGenerated]
	[Token(Token = "0x2000162")]
	private struct <LoadAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400067A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x400067B")]
		public AsyncTaskMethodBuilder<JArray> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400067C")]
		public JsonReader reader; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400067D")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x400067E")]
		public JsonLoadSettings settings; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x400067F")]
		private JArray <a>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x4000680")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000681")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x216FE60", Offset = "0x216F260", Length = "0x5C7")]
		[Token(Token = "0x6000B3E")]
		private override void MoveNext() { }

		[Address(RVA = "0x2170430", Offset = "0x216F830", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000B3F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000163")]
	private struct <WriteToAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000682")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000683")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000684")]
		public JsonWriter writer; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000685")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000686")]
		public JArray <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000687")]
		public JsonConverter[] converters; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000688")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000689")]
		private int <i>5__2; //Field offset: 0x50

		[Address(RVA = "0x2170D90", Offset = "0x2170190", Length = "0x3F5")]
		[Token(Token = "0x6000B40")]
		private override void MoveNext() { }

		[Address(RVA = "0x2171190", Offset = "0x2170590", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000B41")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000679")]
	private readonly List<JToken> _values; //Field offset: 0x58

	[Token(Token = "0x170001D0")]
	protected virtual IList<JToken> ChildrenTokens
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000B1D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001D4")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000B3B")]
		 get { } //Length: 3
	}

	[Nullable(2)]
	[Token(Token = "0x170001D2")]
	public virtual JToken Item
	{
		[Address(RVA = "0x2157090", Offset = "0x2156490", Length = "0x121")]
		[Token(Token = "0x6000B2D")]
		 get { } //Length: 289
		[Address(RVA = "0x2157200", Offset = "0x2156600", Length = "0x131")]
		[Token(Token = "0x6000B2E")]
		 set { } //Length: 305
	}

	[Token(Token = "0x170001D3")]
	public override JToken Item
	{
		[Address(RVA = "0x21571C0", Offset = "0x21565C0", Length = "0x14")]
		[Token(Token = "0x6000B2F")]
		 get { } //Length: 20
		[Address(RVA = "0x21571E0", Offset = "0x21565E0", Length = "0x14")]
		[Token(Token = "0x6000B30")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170001D1")]
	public virtual JTokenType Type
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000B1E")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2156EC0", Offset = "0x21562C0", Length = "0x9E")]
	[Token(Token = "0x6000B22")]
	public JArray(Object[] content) { }

	[Address(RVA = "0x2156E40", Offset = "0x2156240", Length = "0x77")]
	[Token(Token = "0x6000B1F")]
	public JArray() { }

	[Address(RVA = "0x2156F60", Offset = "0x2156360", Length = "0x8B")]
	[Token(Token = "0x6000B20")]
	public JArray(JArray other) { }

	[Address(RVA = "0x2156FF0", Offset = "0x21563F0", Length = "0x98")]
	[Token(Token = "0x6000B21")]
	internal JArray(JArray other, JsonCloneSettings settings) { }

	[Address(RVA = "0x2156EC0", Offset = "0x21562C0", Length = "0x9E")]
	[Token(Token = "0x6000B23")]
	public JArray(object content) { }

	[Address(RVA = "0x2155ED0", Offset = "0x21552D0", Length = "0x14")]
	[Token(Token = "0x6000B37")]
	public override void Add(JToken item) { }

	[Address(RVA = "0x2155EF0", Offset = "0x21552F0", Length = "0x14")]
	[Token(Token = "0x6000B38")]
	public override void Clear() { }

	[Address(RVA = "0x2155F10", Offset = "0x2155310", Length = "0xC4")]
	[Token(Token = "0x6000B25")]
	internal virtual JToken CloneToken(JsonCloneSettings settings = null) { }

	[Address(RVA = "0x2155FE0", Offset = "0x21553E0", Length = "0x14")]
	[Token(Token = "0x6000B39")]
	public override bool Contains(JToken item) { }

	[Address(RVA = "0x2156000", Offset = "0x2155400", Length = "0x14")]
	[Token(Token = "0x6000B3A")]
	public override void CopyTo(JToken[] array, int arrayIndex) { }

	[Address(RVA = "0x2156020", Offset = "0x2155420", Length = "0x81")]
	[Token(Token = "0x6000B24")]
	internal virtual bool DeepEquals(JToken node) { }

	[Address(RVA = "0x2156230", Offset = "0x2155630", Length = "0x178")]
	[Token(Token = "0x6000B2B")]
	public static JArray FromObject(object o, JsonSerializer jsonSerializer) { }

	[Address(RVA = "0x21560B0", Offset = "0x21554B0", Length = "0x17F")]
	[Token(Token = "0x6000B2A")]
	public static JArray FromObject(object o) { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000B1D")]
	protected virtual IList<JToken> get_ChildrenTokens() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000B3B")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x21571C0", Offset = "0x21565C0", Length = "0x14")]
	[Token(Token = "0x6000B2F")]
	public override JToken get_Item(int index) { }

	[Address(RVA = "0x2157090", Offset = "0x2156490", Length = "0x121")]
	[Token(Token = "0x6000B2D")]
	public virtual JToken get_Item(object key) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000B1E")]
	public virtual JTokenType get_Type() { }

	[Address(RVA = "0x21563B0", Offset = "0x21557B0", Length = "0x7")]
	[Token(Token = "0x6000B3D")]
	internal virtual int GetDeepHashCode() { }

	[Address(RVA = "0x21563C0", Offset = "0x21557C0", Length = "0x81")]
	[Token(Token = "0x6000B36")]
	public override IEnumerator<JToken> GetEnumerator() { }

	[Address(RVA = "0x21564B0", Offset = "0x21558B0", Length = "0x14")]
	[Token(Token = "0x6000B33")]
	public override int IndexOf(JToken item) { }

	[Address(RVA = "0x2156450", Offset = "0x2155850", Length = "0x5E")]
	[NullableContext(2)]
	[Token(Token = "0x6000B31")]
	internal virtual int IndexOfItem(JToken item) { }

	[Address(RVA = "0x21564D0", Offset = "0x21558D0", Length = "0x2A")]
	[Token(Token = "0x6000B34")]
	public override void Insert(int index, JToken item) { }

	[Address(RVA = "0x2156970", Offset = "0x2155D70", Length = "0xA")]
	[Token(Token = "0x6000B26")]
	public static JArray Load(JsonReader reader) { }

	[Address(RVA = "0x2156790", Offset = "0x2155B90", Length = "0x1DC")]
	[Token(Token = "0x6000B27")]
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	[Address(RVA = "0x2156500", Offset = "0x2155900", Length = "0x13A")]
	[Token(Token = "0x6000B1B")]
	public static Task<JArray> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2156640", Offset = "0x2155A40", Length = "0x143")]
	[AsyncStateMachine(typeof(<LoadAsync>d__2))]
	[Token(Token = "0x6000B1C")]
	public static Task<JArray> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2156980", Offset = "0x2155D80", Length = "0xE4")]
	[Token(Token = "0x6000B32")]
	internal virtual void MergeItem(object content, JsonMergeSettings settings) { }

	[Address(RVA = "0x2156A70", Offset = "0x2155E70", Length = "0x148")]
	[Token(Token = "0x6000B29")]
	public static JArray Parse(string json, JsonLoadSettings settings) { }

	[Address(RVA = "0x2156BC0", Offset = "0x2155FC0", Length = "0xA")]
	[Token(Token = "0x6000B28")]
	public static JArray Parse(string json) { }

	[Address(RVA = "0x2156BF0", Offset = "0x2155FF0", Length = "0x14")]
	[Token(Token = "0x6000B3C")]
	public override bool Remove(JToken item) { }

	[Address(RVA = "0x2156BD0", Offset = "0x2155FD0", Length = "0x14")]
	[Token(Token = "0x6000B35")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x21571E0", Offset = "0x21565E0", Length = "0x14")]
	[Token(Token = "0x6000B30")]
	public override void set_Item(int index, JToken value) { }

	[Address(RVA = "0x2157200", Offset = "0x2156600", Length = "0x131")]
	[Token(Token = "0x6000B2E")]
	public virtual void set_Item(object key, JToken value) { }

	[Address(RVA = "0x2156D50", Offset = "0x2156150", Length = "0xEE")]
	[Token(Token = "0x6000B2C")]
	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[Address(RVA = "0x2156C10", Offset = "0x2156010", Length = "0x13D")]
	[AsyncStateMachine(typeof(<WriteToAsync>d__0))]
	[Token(Token = "0x6000B1A")]
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

