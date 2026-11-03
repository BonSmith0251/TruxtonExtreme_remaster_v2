namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000164")]
public class JConstructor : JContainer
{
	[CompilerGenerated]
	[Token(Token = "0x2000165")]
	private struct <LoadAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400068C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x400068D")]
		public AsyncTaskMethodBuilder<JConstructor> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x400068E")]
		public JsonReader reader; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400068F")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x4000690")]
		public JsonLoadSettings settings; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x4000691")]
		private JConstructor <c>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x4000692")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000693")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x218B310", Offset = "0x218A710", Length = "0x618")]
		[Token(Token = "0x6000B59")]
		private override void MoveNext() { }

		[Address(RVA = "0x218B9A0", Offset = "0x218ADA0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000B5A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000166")]
	private struct <WriteToAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000694")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000695")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x4000696")]
		public JsonWriter writer; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x4000697")]
		public JConstructor <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000698")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x4000699")]
		public JsonConverter[] converters; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400069A")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400069B")]
		private int <i>5__2; //Field offset: 0x50

		[Address(RVA = "0x218E0A0", Offset = "0x218D4A0", Length = "0x41D")]
		[Token(Token = "0x6000B5B")]
		private override void MoveNext() { }

		[Address(RVA = "0x218E4C0", Offset = "0x218D8C0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000B5C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x58")]
	[Nullable(2)]
	[Token(Token = "0x400068A")]
	private string _name; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400068B")]
	private readonly List<JToken> _values; //Field offset: 0x60

	[Token(Token = "0x170001D5")]
	protected virtual IList<JToken> ChildrenTokens
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000B45")]
		 get { } //Length: 5
	}

	[Nullable(2)]
	[Token(Token = "0x170001D8")]
	public virtual JToken Item
	{
		[Address(RVA = "0x21720A0", Offset = "0x21714A0", Length = "0x121")]
		[Token(Token = "0x6000B54")]
		 get { } //Length: 289
		[Address(RVA = "0x21721D0", Offset = "0x21715D0", Length = "0x131")]
		[Token(Token = "0x6000B55")]
		 set { } //Length: 305
	}

	[Nullable(2)]
	[Token(Token = "0x170001D6")]
	public string Name
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[NullableContext(2)]
		[Token(Token = "0x6000B48")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[NullableContext(2)]
		[Token(Token = "0x6000B49")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001D7")]
	public virtual JTokenType Type
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6000B4A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2171F30", Offset = "0x2171330", Length = "0xB3")]
	[Token(Token = "0x6000B4D")]
	internal JConstructor(JConstructor other, JsonCloneSettings settings) { }

	[Address(RVA = "0x2171FF0", Offset = "0x21713F0", Length = "0xA8")]
	[Token(Token = "0x6000B4B")]
	public JConstructor() { }

	[Address(RVA = "0x2171D00", Offset = "0x2171100", Length = "0xA6")]
	[Token(Token = "0x6000B4C")]
	public JConstructor(JConstructor other) { }

	[Address(RVA = "0x2171DB0", Offset = "0x21711B0", Length = "0x173")]
	[Token(Token = "0x6000B50")]
	public JConstructor(string name) { }

	[Address(RVA = "0x2171CC0", Offset = "0x21710C0", Length = "0x3C")]
	[Token(Token = "0x6000B4E")]
	public JConstructor(string name, Object[] content) { }

	[Address(RVA = "0x2171CC0", Offset = "0x21710C0", Length = "0x3C")]
	[Token(Token = "0x6000B4F")]
	public JConstructor(string name, object content) { }

	[Address(RVA = "0x2171410", Offset = "0x2170810", Length = "0xDF")]
	[Token(Token = "0x6000B52")]
	internal virtual JToken CloneToken(JsonCloneSettings settings = null) { }

	[Address(RVA = "0x21714F0", Offset = "0x21708F0", Length = "0x95")]
	[Token(Token = "0x6000B51")]
	internal virtual bool DeepEquals(JToken node) { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000B45")]
	protected virtual IList<JToken> get_ChildrenTokens() { }

	[Address(RVA = "0x21720A0", Offset = "0x21714A0", Length = "0x121")]
	[Token(Token = "0x6000B54")]
	public virtual JToken get_Item(object key) { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[NullableContext(2)]
	[Token(Token = "0x6000B48")]
	public string get_Name() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x6000B4A")]
	public virtual JTokenType get_Type() { }

	[Address(RVA = "0x2171590", Offset = "0x2170990", Length = "0x46")]
	[Token(Token = "0x6000B56")]
	internal virtual int GetDeepHashCode() { }

	[Address(RVA = "0x21715E0", Offset = "0x21709E0", Length = "0x5E")]
	[NullableContext(2)]
	[Token(Token = "0x6000B46")]
	internal virtual int IndexOfItem(JToken item) { }

	[Address(RVA = "0x21717B0", Offset = "0x2170BB0", Length = "0x22A")]
	[Token(Token = "0x6000B58")]
	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }

	[Address(RVA = "0x21717A0", Offset = "0x2170BA0", Length = "0xA")]
	[Token(Token = "0x6000B57")]
	public static JConstructor Load(JsonReader reader) { }

	[Address(RVA = "0x2171640", Offset = "0x2170A40", Length = "0x143")]
	[AsyncStateMachine(typeof(<LoadAsync>d__2))]
	[Token(Token = "0x6000B44")]
	public static Task<JConstructor> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2171790", Offset = "0x2170B90", Length = "0xD")]
	[Token(Token = "0x6000B43")]
	public static Task<JConstructor> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x21719E0", Offset = "0x2170DE0", Length = "0x9D")]
	[Token(Token = "0x6000B47")]
	internal virtual void MergeItem(object content, JsonMergeSettings settings) { }

	[Address(RVA = "0x21721D0", Offset = "0x21715D0", Length = "0x131")]
	[Token(Token = "0x6000B55")]
	public virtual void set_Item(object key, JToken value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[NullableContext(2)]
	[Token(Token = "0x6000B49")]
	public void set_Name(string value) { }

	[Address(RVA = "0x2171BC0", Offset = "0x2170FC0", Length = "0xF5")]
	[Token(Token = "0x6000B53")]
	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[Address(RVA = "0x2171A80", Offset = "0x2170E80", Length = "0x13D")]
	[AsyncStateMachine(typeof(<WriteToAsync>d__0))]
	[Token(Token = "0x6000B42")]
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

