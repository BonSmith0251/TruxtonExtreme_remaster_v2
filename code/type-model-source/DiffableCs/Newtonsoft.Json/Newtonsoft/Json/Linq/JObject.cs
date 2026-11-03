namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200016C")]
public class JObject : JContainer, IDictionary<String, JToken>, ICollection<KeyValuePair`2<String, JToken>>, IEnumerable<KeyValuePair`2<String, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
{
	[CompilerGenerated]
	[Token(Token = "0x200016F")]
	private struct <<WriteToAsync>g__AwaitProperties|0_0>d : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006C5")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40006C6")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x40006C7")]
		public JObject <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006C8")]
		public int i; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40006C9")]
		public JsonWriter Writer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006CA")]
		public CancellationToken CancellationToken; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40006CB")]
		public JsonConverter[] Converters; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40006CC")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50

		[Address(RVA = "0x218DB20", Offset = "0x218CF20", Length = "0x3E7")]
		[Token(Token = "0x6000C26")]
		private override void MoveNext() { }

		[Address(RVA = "0x218DF10", Offset = "0x218D310", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000C27")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000170")]
	private sealed class <>c
	{
		[Nullable(0)]
		[Token(Token = "0x40006CD")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		[Token(Token = "0x40006CE")]
		public static Func<JProperty, JToken> <>9__31_0; //Field offset: 0x8

		[Address(RVA = "0x218E030", Offset = "0x218D430", Length = "0x67")]
		[Token(Token = "0x6000C28")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C29")]
		public <>c() { }

		[Address(RVA = "0x218DF90", Offset = "0x218D390", Length = "0x20")]
		[NullableContext(0)]
		[Token(Token = "0x6000C2A")]
		internal JToken <PropertyValues>b__31_0(JProperty p) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000171")]
	private sealed class <GetEnumerator>d__64 : IEnumerator<KeyValuePair`2<String, JToken>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006CF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		[Token(Token = "0x40006D0")]
		private KeyValuePair<String, JToken> <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x40006D1")]
		public JObject <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40006D2")]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x30

		[Token(Token = "0x170001F8")]
		private override KeyValuePair<String, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x6000C2F")]
			private get { } //Length: 11
		}

		[Token(Token = "0x170001F9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x218ABF0", Offset = "0x2189FF0", Length = "0x45")]
			[DebuggerHidden]
			[Token(Token = "0x6000C31")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000C2B")]
		public <GetEnumerator>d__64(int <>1__state) { }

		[Address(RVA = "0x218ACD0", Offset = "0x218A0D0", Length = "0x50")]
		[Token(Token = "0x6000C2E")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x218A930", Offset = "0x2189D30", Length = "0x27B")]
		[Token(Token = "0x6000C2D")]
		private override bool MoveNext() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[DebuggerHidden]
		[Token(Token = "0x6000C2F")]
		private override KeyValuePair<String, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

		[Address(RVA = "0x218ABF0", Offset = "0x2189FF0", Length = "0x45")]
		[DebuggerHidden]
		[Token(Token = "0x6000C31")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x218ABB0", Offset = "0x2189FB0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000C30")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x218AC40", Offset = "0x218A040", Length = "0x8C")]
		[DebuggerHidden]
		[Token(Token = "0x6000C2C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000172")]
	private struct <LoadAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x40006D4")]
		public AsyncTaskMethodBuilder<JObject> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40006D5")]
		public JsonReader reader; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006D6")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40006D7")]
		public JsonLoadSettings settings; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40006D8")]
		private JObject <o>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x40006D9")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40006DA")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x218AD20", Offset = "0x218A120", Length = "0x5EA")]
		[Token(Token = "0x6000C32")]
		private override void MoveNext() { }

		[Address(RVA = "0x218B930", Offset = "0x218AD30", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000C33")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
	[Token(Token = "0x200016D")]
	private class JObjectDynamicProxy : DynamicProxy<JObject>
	{
		[CompilerGenerated]
		[Token(Token = "0x200016E")]
		private sealed class <>c
		{
			[Nullable(0)]
			[Token(Token = "0x40006C2")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Nullable(0)]
			[Token(Token = "0x40006C3")]
			public static Func<JProperty, String> <>9__2_0; //Field offset: 0x8

			[Address(RVA = "0x218DFC0", Offset = "0x218D3C0", Length = "0x67")]
			[Token(Token = "0x6000C23")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000C24")]
			public <>c() { }

			[Address(RVA = "0x218DF70", Offset = "0x218D370", Length = "0x17")]
			[NullableContext(0)]
			[Token(Token = "0x6000C25")]
			internal string <GetDynamicMemberNames>b__2_0(JProperty p) { }

		}


		[Address(RVA = "0x2177040", Offset = "0x2176440", Length = "0x39")]
		[Token(Token = "0x6000C22")]
		public JObjectDynamicProxy() { }

		[Address(RVA = "0x2176DC0", Offset = "0x21761C0", Length = "0x151")]
		[Token(Token = "0x6000C21")]
		public virtual IEnumerable<String> GetDynamicMemberNames(JObject instance) { }

		[Address(RVA = "0x2176F20", Offset = "0x2176320", Length = "0x40")]
		[Token(Token = "0x6000C1F")]
		public virtual bool TryGetMember(JObject instance, GetMemberBinder binder, out object result) { }

		[Address(RVA = "0x2176F70", Offset = "0x2176370", Length = "0xCD")]
		[Token(Token = "0x6000C20")]
		public virtual bool TrySetMember(JObject instance, SetMemberBinder binder, object value) { }

	}

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006BF")]
	private readonly JPropertyKeyedCollection _properties; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Nullable(2)]
	[Token(Token = "0x40006C0")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Nullable(2)]
	[Token(Token = "0x40006C1")]
	private PropertyChangingEventHandler PropertyChanging; //Field offset: 0x68

	[Nullable(2)]
	[Token(Token = "0x14000007")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x217A050", Offset = "0x2179450", Length = "0x9E")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000BDC")]
		 add { } //Length: 158
		[Address(RVA = "0x217A310", Offset = "0x2179710", Length = "0x9E")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000BDD")]
		 remove { } //Length: 158
	}

	[Nullable(2)]
	[Token(Token = "0x14000008")]
	public override event PropertyChangingEventHandler PropertyChanging
	{
		[Address(RVA = "0x217A0F0", Offset = "0x21794F0", Length = "0x9E")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000BDE")]
		 add { } //Length: 158
		[Address(RVA = "0x217A3B0", Offset = "0x21797B0", Length = "0x9E")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000BDF")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170001F1")]
	protected virtual IList<JToken> ChildrenTokens
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000BDB")]
		 get { } //Length: 5
	}

	[Nullable(2)]
	[Token(Token = "0x170001F3")]
	public virtual JToken Item
	{
		[Address(RVA = "0x217A190", Offset = "0x2179590", Length = "0xF4")]
		[Token(Token = "0x6000BF3")]
		 get { } //Length: 244
		[Address(RVA = "0x217A550", Offset = "0x2179950", Length = "0x104")]
		[Token(Token = "0x6000BF4")]
		 set { } //Length: 260
	}

	[Nullable(2)]
	[Token(Token = "0x170001F4")]
	public override JToken Item
	{
		[Address(RVA = "0x217A290", Offset = "0x2179690", Length = "0x7F")]
		[Token(Token = "0x6000BF5")]
		 get { } //Length: 127
		[Address(RVA = "0x217A450", Offset = "0x2179850", Length = "0xF6")]
		[Token(Token = "0x6000BF6")]
		 set { } //Length: 246
	}

	[Token(Token = "0x170001F7")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C0B")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001F5")]
	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys
	{
		[Address(RVA = "0x2178FB0", Offset = "0x21783B0", Length = "0x54")]
		[Token(Token = "0x6000C03")]
		private get { } //Length: 84
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	[Token(Token = "0x170001F6")]
	private override ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values
	{
		[Address(RVA = "0x2179010", Offset = "0x2178410", Length = "0x3E")]
		[Token(Token = "0x6000C06")]
		private get { } //Length: 62
	}

	[Token(Token = "0x170001F2")]
	public virtual JTokenType Type
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000BEE")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2179FB0", Offset = "0x21793B0", Length = "0x97")]
	[Token(Token = "0x6000BE0")]
	public JObject() { }

	[Address(RVA = "0x2179EA0", Offset = "0x21792A0", Length = "0x7A")]
	[Token(Token = "0x6000BE1")]
	public JObject(JObject other) { }

	[Address(RVA = "0x2179F20", Offset = "0x2179320", Length = "0x87")]
	[Token(Token = "0x6000BE2")]
	internal JObject(JObject other, JsonCloneSettings settings) { }

	[Address(RVA = "0x2179DE0", Offset = "0x21791E0", Length = "0xBE")]
	[Token(Token = "0x6000BE3")]
	public JObject(Object[] content) { }

	[Address(RVA = "0x2179DE0", Offset = "0x21791E0", Length = "0xBE")]
	[Token(Token = "0x6000BE4")]
	public JObject(object content) { }

	[Address(RVA = "0x21796A0", Offset = "0x2178AA0", Length = "0x147")]
	[AsyncStateMachine(typeof(<<WriteToAsync>g__AwaitProperties|0_0>d))]
	[CompilerGenerated]
	[Token(Token = "0x6000C1E")]
	private Task <WriteToAsync>g__AwaitProperties|0_0(Task task, int i, JsonWriter Writer, CancellationToken CancellationToken, JsonConverter[] Converters) { }

	[Address(RVA = "0x2177080", Offset = "0x2176480", Length = "0x87")]
	[Token(Token = "0x6000C01")]
	public override void Add(string propertyName, JToken value) { }

	[Address(RVA = "0x217A050", Offset = "0x2179450", Length = "0x9E")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000BDC")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x217A0F0", Offset = "0x21794F0", Length = "0x9E")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000BDE")]
	public override void add_PropertyChanging(PropertyChangingEventHandler value) { }

	[Address(RVA = "0x2177110", Offset = "0x2176510", Length = "0xB3")]
	[Token(Token = "0x6000BED")]
	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	[Address(RVA = "0x21771D0", Offset = "0x21765D0", Length = "0xE7")]
	[Token(Token = "0x6000C02")]
	public override bool ContainsKey(string propertyName) { }

	[Address(RVA = "0x21772C0", Offset = "0x21766C0", Length = "0x8D")]
	[Token(Token = "0x6000BE5")]
	internal virtual bool DeepEquals(JToken node) { }

	[Address(RVA = "0x21774D0", Offset = "0x21768D0", Length = "0x178")]
	[Token(Token = "0x6000BFC")]
	public static JObject FromObject(object o, JsonSerializer jsonSerializer) { }

	[Address(RVA = "0x2177350", Offset = "0x2176750", Length = "0x17F")]
	[Token(Token = "0x6000BFB")]
	public static JObject FromObject(object o) { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000BDB")]
	protected virtual IList<JToken> get_ChildrenTokens() { }

	[Address(RVA = "0x217A190", Offset = "0x2179590", Length = "0xF4")]
	[Token(Token = "0x6000BF3")]
	public virtual JToken get_Item(object key) { }

	[Address(RVA = "0x217A290", Offset = "0x2179690", Length = "0x7F")]
	[Token(Token = "0x6000BF5")]
	public override JToken get_Item(string propertyName) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000BEE")]
	public virtual JTokenType get_Type() { }

	[Address(RVA = "0x21563B0", Offset = "0x21557B0", Length = "0x7")]
	[Token(Token = "0x6000C0D")]
	internal virtual int GetDeepHashCode() { }

	[Address(RVA = "0x2177650", Offset = "0x2176A50", Length = "0x67")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__64))]
	[Token(Token = "0x6000C0E")]
	public override IEnumerator<KeyValuePair`2<String, JToken>> GetEnumerator() { }

	[Address(RVA = "0x21776C0", Offset = "0x2176AC0", Length = "0xCC")]
	[Token(Token = "0x6000C1D")]
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	[Address(RVA = "0x21777D0", Offset = "0x2176BD0", Length = "0x3A")]
	[NullableContext(2)]
	[Token(Token = "0x6000BFE")]
	public JToken GetValue(string propertyName) { }

	[Address(RVA = "0x2177790", Offset = "0x2176B90", Length = "0x34")]
	[NullableContext(2)]
	[Token(Token = "0x6000BFF")]
	public JToken GetValue(string propertyName, StringComparison comparison) { }

	[Address(RVA = "0x2177810", Offset = "0x2176C10", Length = "0xBF")]
	[NullableContext(2)]
	[Token(Token = "0x6000BE6")]
	internal virtual int IndexOfItem(JToken item) { }

	[Address(RVA = "0x21778D0", Offset = "0x2176CD0", Length = "0x7C")]
	[NullableContext(2)]
	[Token(Token = "0x6000BE7")]
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[Address(RVA = "0x2177950", Offset = "0x2176D50", Length = "0x148")]
	[Token(Token = "0x6000BEB")]
	internal void InternalPropertyChanged(JProperty childProperty) { }

	[Address(RVA = "0x2177AA0", Offset = "0x2176EA0", Length = "0x2A")]
	[Token(Token = "0x6000BEC")]
	internal void InternalPropertyChanging(JProperty childProperty) { }

	[Address(RVA = "0x2177AD0", Offset = "0x2176ED0", Length = "0x8C")]
	[Token(Token = "0x6000BEA")]
	private static bool IsNull(JToken token) { }

	[Address(RVA = "0x2177CD0", Offset = "0x21770D0", Length = "0x1FA")]
	[Token(Token = "0x6000BF8")]
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	[Address(RVA = "0x2177CC0", Offset = "0x21770C0", Length = "0xA")]
	[Token(Token = "0x6000BF7")]
	public static JObject Load(JsonReader reader) { }

	[Address(RVA = "0x2177B60", Offset = "0x2176F60", Length = "0x143")]
	[AsyncStateMachine(typeof(<LoadAsync>d__2))]
	[Token(Token = "0x6000BDA")]
	public static Task<JObject> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2177CB0", Offset = "0x21770B0", Length = "0xD")]
	[Token(Token = "0x6000BD9")]
	public static Task<JObject> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2177ED0", Offset = "0x21772D0", Length = "0x3AA")]
	[Token(Token = "0x6000BE9")]
	internal virtual void MergeItem(object content, JsonMergeSettings settings) { }

	[Address(RVA = "0x2178280", Offset = "0x2177680", Length = "0x86")]
	[Token(Token = "0x6000C0F")]
	protected override void OnPropertyChanged(string propertyName) { }

	[Address(RVA = "0x2178310", Offset = "0x2177710", Length = "0x86")]
	[Token(Token = "0x6000C10")]
	protected override void OnPropertyChanging(string propertyName) { }

	[Address(RVA = "0x21783A0", Offset = "0x21777A0", Length = "0xA")]
	[Token(Token = "0x6000BF9")]
	public static JObject Parse(string json) { }

	[Address(RVA = "0x21783B0", Offset = "0x21777B0", Length = "0x148")]
	[Token(Token = "0x6000BFA")]
	public static JObject Parse(string json, JsonLoadSettings settings) { }

	[Address(RVA = "0x2178500", Offset = "0x2177900", Length = "0x3A")]
	[Token(Token = "0x6000BEF")]
	public IEnumerable<JProperty> Properties() { }

	[Address(RVA = "0x21786C0", Offset = "0x2177AC0", Length = "0x1EA")]
	[Token(Token = "0x6000BF1")]
	public JProperty Property(string name, StringComparison comparison) { }

	[Address(RVA = "0x21788B0", Offset = "0x2177CB0", Length = "0xE")]
	[Token(Token = "0x6000BF0")]
	public JProperty Property(string name) { }

	[Address(RVA = "0x2178540", Offset = "0x2177940", Length = "0x171")]
	[Token(Token = "0x6000BF2")]
	public JEnumerable<JToken> PropertyValues() { }

	[Address(RVA = "0x21788C0", Offset = "0x2177CC0", Length = "0x97")]
	[Token(Token = "0x6000C04")]
	public override bool Remove(string propertyName) { }

	[Address(RVA = "0x217A310", Offset = "0x2179710", Length = "0x9E")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000BDD")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x217A3B0", Offset = "0x21797B0", Length = "0x9E")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000BDF")]
	public override void remove_PropertyChanging(PropertyChangingEventHandler value) { }

	[Address(RVA = "0x217A450", Offset = "0x2179850", Length = "0xF6")]
	[Token(Token = "0x6000BF6")]
	public override void set_Item(string propertyName, JToken value) { }

	[Address(RVA = "0x217A550", Offset = "0x2179950", Length = "0x104")]
	[Token(Token = "0x6000BF4")]
	public virtual void set_Item(object key, JToken value) { }

	[Address(RVA = "0x2178960", Offset = "0x2177D60", Length = "0x93")]
	[Token(Token = "0x6000C07")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<String, JToken> item) { }

	[Address(RVA = "0x2155EF0", Offset = "0x21552F0", Length = "0x14")]
	[Token(Token = "0x6000C08")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	[Address(RVA = "0x2178A00", Offset = "0x2177E00", Length = "0x80")]
	[Token(Token = "0x6000C09")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<String, JToken> item) { }

	[Address(RVA = "0x2178A90", Offset = "0x2177E90", Length = "0x397")]
	[Token(Token = "0x6000C0A")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<String, JToken>[] array, int arrayIndex) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C0B")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	[Address(RVA = "0x2178E30", Offset = "0x2178230", Length = "0x177")]
	[Token(Token = "0x6000C0C")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<String, JToken> item) { }

	[Address(RVA = "0x2178FB0", Offset = "0x21783B0", Length = "0x54")]
	[Token(Token = "0x6000C03")]
	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	[Address(RVA = "0x2179010", Offset = "0x2178410", Length = "0x3E")]
	[Token(Token = "0x6000C06")]
	private override ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	[Address(RVA = "0x2179050", Offset = "0x2178450", Length = "0x4E")]
	[Token(Token = "0x6000C13")]
	private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[NullableContext(2)]
	[Token(Token = "0x6000C14")]
	private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[NullableContext(2)]
	[Token(Token = "0x6000C15")]
	private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	[Address(RVA = "0x21790A0", Offset = "0x21784A0", Length = "0x44")]
	[Token(Token = "0x6000C16")]
	private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[NullableContext(2)]
	[Token(Token = "0x6000C17")]
	private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[NullableContext(2)]
	[Token(Token = "0x6000C18")]
	private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000C19")]
	private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	[Address(RVA = "0x2179140", Offset = "0x2178540", Length = "0x4E")]
	[Token(Token = "0x6000C1B")]
	private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	[Address(RVA = "0x21790F0", Offset = "0x21784F0", Length = "0x4E")]
	[Token(Token = "0x6000C1A")]
	private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	[Address(RVA = "0x21794C0", Offset = "0x21788C0", Length = "0xA8")]
	[Token(Token = "0x6000C11")]
	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	[Address(RVA = "0x2179190", Offset = "0x2178590", Length = "0x32D")]
	[Token(Token = "0x6000C12")]
	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	[Address(RVA = "0x2179570", Offset = "0x2178970", Length = "0x77")]
	[NullableContext(2)]
	[Token(Token = "0x6000C1C")]
	private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	[Address(RVA = "0x2179640", Offset = "0x2178A40", Length = "0x5A")]
	[Token(Token = "0x6000C05")]
	public override bool TryGetValue(string propertyName, out JToken value) { }

	[Address(RVA = "0x21795F0", Offset = "0x21789F0", Length = "0x49")]
	[Token(Token = "0x6000C00")]
	public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value) { }

	[Address(RVA = "0x21797F0", Offset = "0x2178BF0", Length = "0x2E0")]
	[Token(Token = "0x6000BE8")]
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	[Address(RVA = "0x2179CC0", Offset = "0x21790C0", Length = "0x111")]
	[Token(Token = "0x6000BFD")]
	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[Address(RVA = "0x2179AE0", Offset = "0x2178EE0", Length = "0x1DD")]
	[Token(Token = "0x6000BD8")]
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

