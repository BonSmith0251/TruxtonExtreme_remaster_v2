namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000173")]
public class JProperty : JContainer
{
	[CompilerGenerated]
	[Token(Token = "0x2000176")]
	private struct <LoadAsync>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E1")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Nullable(0)]
		[Token(Token = "0x40006E2")]
		public AsyncTaskMethodBuilder<JProperty> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40006E3")]
		public JsonReader reader; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006E4")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40006E5")]
		public JsonLoadSettings settings; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40006E6")]
		private JProperty <p>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x40006E7")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40006E8")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x218BA10", Offset = "0x218AE10", Length = "0x618")]
		[Token(Token = "0x6000C67")]
		private override void MoveNext() { }

		[Address(RVA = "0x218C030", Offset = "0x218B430", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000C68")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000177")]
	private struct <WriteToAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E9")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006EA")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40006EB")]
		public Task task; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x40006EC")]
		public JProperty <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40006ED")]
		public JsonWriter writer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006EE")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40006EF")]
		public JsonConverter[] converters; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40006F0")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		[Address(RVA = "0x218E520", Offset = "0x218D920", Length = "0x29E")]
		[Token(Token = "0x6000C69")]
		private override void MoveNext() { }

		[Address(RVA = "0x218E7C0", Offset = "0x218DBC0", Length = "0x6BF")]
		[DebuggerHidden]
		[Token(Token = "0x6000C6A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[DefaultMember("Item")]
	[Nullable(0)]
	[Token(Token = "0x2000174")]
	private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000175")]
		private sealed class <GetEnumerator>d__1 : IEnumerator<JToken>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40006DE")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40006DF")]
			private JToken <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Nullable(0)]
			[Token(Token = "0x40006E0")]
			public JPropertyList <>4__this; //Field offset: 0x20

			[Token(Token = "0x17000201")]
			private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000C64")]
				private get { } //Length: 5
			}

			[Token(Token = "0x17000202")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000C66")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x6000C61")]
			public <GetEnumerator>d__1(int <>1__state) { }

			[Address(RVA = "0x218A880", Offset = "0x2189C80", Length = "0x60")]
			[Token(Token = "0x6000C63")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C64")]
			private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C66")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x218A8F0", Offset = "0x2189CF0", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000C65")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x6000C62")]
			private override void System.IDisposable.Dispose() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Nullable(2)]
		[Token(Token = "0x40006DD")]
		internal JToken _token; //Field offset: 0x10

		[Token(Token = "0x170001FE")]
		public override int Count
		{
			[Address(RVA = "0x217BE00", Offset = "0x217B200", Length = "0xA")]
			[Token(Token = "0x6000C59")]
			 get { } //Length: 10
		}

		[Token(Token = "0x170001FF")]
		public override bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000C5A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000200")]
		public override JToken Item
		{
			[Address(RVA = "0x217BE10", Offset = "0x217B210", Length = "0x53")]
			[Token(Token = "0x6000C5E")]
			 get { } //Length: 83
			[Address(RVA = "0x217BE70", Offset = "0x217B270", Length = "0x5E")]
			[Token(Token = "0x6000C5F")]
			 set { } //Length: 94
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C60")]
		public JPropertyList() { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000C54")]
		public override void Add(JToken item) { }

		[Address(RVA = "0x1CC8D30", Offset = "0x1CC8130", Length = "0x13")]
		[Token(Token = "0x6000C55")]
		public override void Clear() { }

		[Address(RVA = "0x217BC80", Offset = "0x217B080", Length = "0x8")]
		[Token(Token = "0x6000C56")]
		public override bool Contains(JToken item) { }

		[Address(RVA = "0x217BC90", Offset = "0x217B090", Length = "0x7E")]
		[Token(Token = "0x6000C57")]
		public override void CopyTo(JToken[] array, int arrayIndex) { }

		[Address(RVA = "0x217BE00", Offset = "0x217B200", Length = "0xA")]
		[Token(Token = "0x6000C59")]
		public override int get_Count() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C5A")]
		public override bool get_IsReadOnly() { }

		[Address(RVA = "0x217BE10", Offset = "0x217B210", Length = "0x53")]
		[Token(Token = "0x6000C5E")]
		public override JToken get_Item(int index) { }

		[Address(RVA = "0x217BD10", Offset = "0x217B110", Length = "0x67")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__1))]
		[Token(Token = "0x6000C52")]
		public override IEnumerator<JToken> GetEnumerator() { }

		[Address(RVA = "0x217BD80", Offset = "0x217B180", Length = "0xD")]
		[Token(Token = "0x6000C5B")]
		public override int IndexOf(JToken item) { }

		[Address(RVA = "0x217BD90", Offset = "0x217B190", Length = "0x15")]
		[Token(Token = "0x6000C5C")]
		public override void Insert(int index, JToken item) { }

		[Address(RVA = "0x217BDD0", Offset = "0x217B1D0", Length = "0x2B")]
		[Token(Token = "0x6000C58")]
		public override bool Remove(JToken item) { }

		[Address(RVA = "0x217BDB0", Offset = "0x217B1B0", Length = "0x18")]
		[Token(Token = "0x6000C5D")]
		public override void RemoveAt(int index) { }

		[Address(RVA = "0x217BE70", Offset = "0x217B270", Length = "0x5E")]
		[Token(Token = "0x6000C5F")]
		public override void set_Item(int index, JToken value) { }

		[Address(RVA = "0x217BD10", Offset = "0x217B110", Length = "0x67")]
		[Token(Token = "0x6000C53")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006DB")]
	private readonly JPropertyList _content; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006DC")]
	private readonly string _name; //Field offset: 0x60

	[Token(Token = "0x170001FA")]
	protected virtual IList<JToken> ChildrenTokens
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000C39")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001FB")]
	public string Name
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C3A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001FD")]
	public virtual JTokenType Type
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C4A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001FC")]
	public JToken Value
	{
		[Address(RVA = "0x217D4B0", Offset = "0x217C8B0", Length = "0x1B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C3B")]
		 get { } //Length: 27
		[Address(RVA = "0x217D4D0", Offset = "0x217C8D0", Length = "0x8C")]
		[Token(Token = "0x6000C3C")]
		 set { } //Length: 140
	}

	[Address(RVA = "0x217D310", Offset = "0x217C710", Length = "0x193")]
	[Token(Token = "0x6000C4D")]
	public JProperty(string name, object content) { }

	[Address(RVA = "0x217D0D0", Offset = "0x217C4D0", Length = "0x8")]
	[Token(Token = "0x6000C4C")]
	public JProperty(string name, Object[] content) { }

	[Address(RVA = "0x217D0E0", Offset = "0x217C4E0", Length = "0x95")]
	[Token(Token = "0x6000C3D")]
	public JProperty(JProperty other) { }

	[Address(RVA = "0x217D180", Offset = "0x217C580", Length = "0xA2")]
	[Token(Token = "0x6000C3E")]
	internal JProperty(JProperty other, JsonCloneSettings settings) { }

	[Address(RVA = "0x217D230", Offset = "0x217C630", Length = "0xD2")]
	[Token(Token = "0x6000C4B")]
	internal JProperty(string name) { }

	[Address(RVA = "0x217BED0", Offset = "0x217B2D0", Length = "0xAC")]
	[Token(Token = "0x6000C47")]
	internal virtual void ClearItems() { }

	[Address(RVA = "0x217BF80", Offset = "0x217B380", Length = "0xCE")]
	[Token(Token = "0x6000C49")]
	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	[Address(RVA = "0x217C050", Offset = "0x217B450", Length = "0x1E")]
	[NullableContext(2)]
	[Token(Token = "0x6000C45")]
	internal virtual bool ContainsItem(JToken item) { }

	[Address(RVA = "0x217C070", Offset = "0x217B470", Length = "0x95")]
	[Token(Token = "0x6000C48")]
	internal virtual bool DeepEquals(JToken node) { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000C39")]
	protected virtual IList<JToken> get_ChildrenTokens() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[DebuggerStepThrough]
	[Token(Token = "0x6000C3A")]
	public string get_Name() { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[DebuggerStepThrough]
	[Token(Token = "0x6000C4A")]
	public virtual JTokenType get_Type() { }

	[Address(RVA = "0x217D4B0", Offset = "0x217C8B0", Length = "0x1B")]
	[DebuggerStepThrough]
	[Token(Token = "0x6000C3B")]
	public JToken get_Value() { }

	[Address(RVA = "0x217C110", Offset = "0x217B510", Length = "0x72")]
	[Token(Token = "0x6000C4F")]
	internal virtual int GetDeepHashCode() { }

	[Address(RVA = "0x217C190", Offset = "0x217B590", Length = "0x61")]
	[Token(Token = "0x6000C3F")]
	internal virtual JToken GetItem(int index) { }

	[Address(RVA = "0x217C200", Offset = "0x217B600", Length = "0x32")]
	[NullableContext(2)]
	[Token(Token = "0x6000C43")]
	internal virtual int IndexOfItem(JToken item) { }

	[Address(RVA = "0x217C240", Offset = "0x217B640", Length = "0x121")]
	[NullableContext(2)]
	[Token(Token = "0x6000C44")]
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[Address(RVA = "0x217C4D0", Offset = "0x217B8D0", Length = "0xA")]
	[Token(Token = "0x6000C50")]
	public static JProperty Load(JsonReader reader) { }

	[Address(RVA = "0x217C4E0", Offset = "0x217B8E0", Length = "0x22A")]
	[Token(Token = "0x6000C51")]
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

	[Address(RVA = "0x217C370", Offset = "0x217B770", Length = "0x143")]
	[AsyncStateMachine(typeof(<LoadAsync>d__4))]
	[Token(Token = "0x6000C38")]
	public static Task<JProperty> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x217C4C0", Offset = "0x217B8C0", Length = "0xD")]
	[Token(Token = "0x6000C37")]
	public static Task<JProperty> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x217C710", Offset = "0x217BB10", Length = "0x101")]
	[Token(Token = "0x6000C46")]
	internal virtual void MergeItem(object content, JsonMergeSettings settings) { }

	[Address(RVA = "0x217C8D0", Offset = "0x217BCD0", Length = "0xAC")]
	[NullableContext(2)]
	[Token(Token = "0x6000C41")]
	internal virtual bool RemoveItem(JToken item) { }

	[Address(RVA = "0x217C820", Offset = "0x217BC20", Length = "0xAC")]
	[Token(Token = "0x6000C42")]
	internal virtual void RemoveItemAt(int index) { }

	[Address(RVA = "0x217D4D0", Offset = "0x217C8D0", Length = "0x8C")]
	[Token(Token = "0x6000C3C")]
	public void set_Value(JToken value) { }

	[Address(RVA = "0x217C980", Offset = "0x217BD80", Length = "0x2E9")]
	[NullableContext(2)]
	[Token(Token = "0x6000C40")]
	internal virtual void SetItem(int index, JToken item) { }

	[Address(RVA = "0x217CFC0", Offset = "0x217C3C0", Length = "0x9D")]
	[Token(Token = "0x6000C4E")]
	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[Address(RVA = "0x217CC70", Offset = "0x217C070", Length = "0x140")]
	[AsyncStateMachine(typeof(<WriteToAsync>d__1))]
	[Token(Token = "0x6000C35")]
	private Task WriteToAsync(Task task, JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	[Address(RVA = "0x217CDB0", Offset = "0x217C1B0", Length = "0x204")]
	[Token(Token = "0x6000C34")]
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	[Address(RVA = "0x217D060", Offset = "0x217C460", Length = "0x64")]
	[Token(Token = "0x6000C36")]
	private Task WriteValueAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

