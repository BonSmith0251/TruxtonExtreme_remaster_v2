namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000167")]
public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList, INotifyCollectionChanged
{
	[CompilerGenerated]
	[Token(Token = "0x2000168")]
	private sealed class <GetDescendants>d__36 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006A1")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006A2")]
		private JToken <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006A3")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40006A4")]
		private bool self; //Field offset: 0x24
		[FieldOffset(Offset = "0x25")]
		[Token(Token = "0x40006A5")]
		public bool <>3__self; //Field offset: 0x25
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x40006A6")]
		public JContainer <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40006A7")]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40006A8")]
		private JToken <o>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40006A9")]
		private IEnumerator<JToken> <>7__wrap3; //Field offset: 0x40

		[Token(Token = "0x170001EE")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BC7")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001EF")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BC9")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC2")]
		public <GetDescendants>d__36(int <>1__state) { }

		[Address(RVA = "0x218A7E0", Offset = "0x2189BE0", Length = "0x50")]
		[Token(Token = "0x6000BC5")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x218A830", Offset = "0x2189C30", Length = "0x50")]
		[Token(Token = "0x6000BC6")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x218A180", Offset = "0x2189580", Length = "0x411")]
		[Token(Token = "0x6000BC4")]
		private override bool MoveNext() { }

		[Address(RVA = "0x218A5A0", Offset = "0x21899A0", Length = "0xA3")]
		[DebuggerHidden]
		[Token(Token = "0x6000BCA")]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC7")]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[Address(RVA = "0x218A5A0", Offset = "0x21899A0", Length = "0xA3")]
		[DebuggerHidden]
		[Token(Token = "0x6000BCB")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC9")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x218A650", Offset = "0x2189A50", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC8")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x218A690", Offset = "0x2189A90", Length = "0x14D")]
		[DebuggerHidden]
		[Token(Token = "0x6000BC3")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000169")]
	private struct <ReadContentFromAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006AA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006AB")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40006AC")]
		public JsonReader reader; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Nullable(0)]
		[Token(Token = "0x40006AD")]
		public JContainer <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40006AE")]
		public JsonLoadSettings settings; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006AF")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Nullable(0)]
		[Token(Token = "0x40006B0")]
		private IJsonLineInfo <lineInfo>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x40006B1")]
		private JContainer <parent>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40006B2")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Nullable(0)]
		[Token(Token = "0x40006B3")]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x60

		[Address(RVA = "0x218C0A0", Offset = "0x218B4A0", Length = "0x960")]
		[Token(Token = "0x6000BCC")]
		private override void MoveNext() { }

		[Address(RVA = "0x218CA50", Offset = "0x218BE50", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000BCD")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200016A")]
	private struct <ReadTokenFromAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006B5")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Nullable(0)]
		[Token(Token = "0x40006B6")]
		public JsonReader reader; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006B7")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Nullable(0)]
		[Token(Token = "0x40006B8")]
		public JContainer <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Nullable(0)]
		[Token(Token = "0x40006B9")]
		public JsonLoadSettings options; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006BA")]
		private int <startDepth>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Nullable(0)]
		[Token(Token = "0x40006BB")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40006BC")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x58

		[Address(RVA = "0x218D520", Offset = "0x218C920", Length = "0x591")]
		[Token(Token = "0x6000BCE")]
		private override void MoveNext() { }

		[Address(RVA = "0x218DAC0", Offset = "0x218CEC0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000BCF")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x30")]
	[Nullable(2)]
	[Token(Token = "0x400069C")]
	internal ListChangedEventHandler _listChanged; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Nullable(2)]
	[Token(Token = "0x400069D")]
	internal AddingNewEventHandler _addingNew; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Nullable(2)]
	[Token(Token = "0x400069E")]
	internal NotifyCollectionChangedEventHandler _collectionChanged; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Nullable(2)]
	[Token(Token = "0x400069F")]
	private object _syncRoot; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40006A0")]
	private bool _busy; //Field offset: 0x50

	[Token(Token = "0x14000005")]
	public event AddingNewEventHandler AddingNew
	{
		[Address(RVA = "0x2176810", Offset = "0x2175C10", Length = "0x9F")]
		[Token(Token = "0x6000B61")]
		 add { } //Length: 159
		[Address(RVA = "0x2176BE0", Offset = "0x2175FE0", Length = "0x9F")]
		[Token(Token = "0x6000B62")]
		 remove { } //Length: 159
	}

	[Nullable(2)]
	[Token(Token = "0x14000006")]
	public override event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[Address(RVA = "0x21768B0", Offset = "0x2175CB0", Length = "0x9F")]
		[NullableContext(2)]
		[Token(Token = "0x6000B63")]
		 add { } //Length: 159
		[Address(RVA = "0x2176C80", Offset = "0x2176080", Length = "0x9F")]
		[NullableContext(2)]
		[Token(Token = "0x6000B64")]
		 remove { } //Length: 159
	}

	[Token(Token = "0x14000004")]
	public override event ListChangedEventHandler ListChanged
	{
		[Address(RVA = "0x2176950", Offset = "0x2175D50", Length = "0x9F")]
		[Token(Token = "0x6000B5F")]
		 add { } //Length: 159
		[Address(RVA = "0x2176D20", Offset = "0x2176120", Length = "0x9F")]
		[Token(Token = "0x6000B60")]
		 remove { } //Length: 159
	}

	[Token(Token = "0x170001D9")]
	protected abstract IList<JToken> ChildrenTokens
	{
		[Token(Token = "0x6000B65")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001E2")]
	public override int Count
	{
		[Address(RVA = "0x21769F0", Offset = "0x2175DF0", Length = "0x5B")]
		[Token(Token = "0x6000BAF")]
		 get { } //Length: 91
	}

	[Nullable(2)]
	[Token(Token = "0x170001DB")]
	public virtual JToken First
	{
		[Address(RVA = "0x2176A50", Offset = "0x2175E50", Length = "0x8A")]
		[NullableContext(2)]
		[Token(Token = "0x6000B6F")]
		 get { } //Length: 138
	}

	[Token(Token = "0x170001DA")]
	public virtual bool HasValues
	{
		[Address(RVA = "0x2176AE0", Offset = "0x2175EE0", Length = "0x61")]
		[Token(Token = "0x6000B6D")]
		 get { } //Length: 97
	}

	[Nullable(2)]
	[Token(Token = "0x170001DC")]
	public virtual JToken Last
	{
		[Address(RVA = "0x2176B50", Offset = "0x2175F50", Length = "0x8B")]
		[NullableContext(2)]
		[Token(Token = "0x6000B70")]
		 get { } //Length: 139
	}

	[Token(Token = "0x170001DE")]
	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BA0")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001DD")]
	private override JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item
	{
		[Address(RVA = "0x21571C0", Offset = "0x21565C0", Length = "0x14")]
		[Token(Token = "0x6000B9A")]
		private get { } //Length: 20
		[Address(RVA = "0x21571E0", Offset = "0x21565E0", Length = "0x14")]
		[Token(Token = "0x6000B9B")]
		private set { } //Length: 20
	}

	[Token(Token = "0x170001E3")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BB0")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001E4")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x2175850", Offset = "0x2174C50", Length = "0x6B")]
		[Token(Token = "0x6000BB1")]
		private get { } //Length: 107
	}

	[Token(Token = "0x170001DF")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BA8")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001E0")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BA9")]
		private get { } //Length: 3
	}

	[Nullable(2)]
	[Token(Token = "0x170001E1")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x21571C0", Offset = "0x21565C0", Length = "0x14")]
		[NullableContext(2)]
		[Token(Token = "0x6000BAC")]
		private get { } //Length: 20
		[Address(RVA = "0x2175A40", Offset = "0x2174E40", Length = "0x43")]
		[NullableContext(2)]
		[Token(Token = "0x6000BAD")]
		private set { } //Length: 67
	}

	[Token(Token = "0x170001E5")]
	private override bool System.ComponentModel.IBindingList.AllowEdit
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000BB4")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001E6")]
	private override bool System.ComponentModel.IBindingList.AllowNew
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000BB5")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001E7")]
	private override bool System.ComponentModel.IBindingList.AllowRemove
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000BB6")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001E8")]
	private override bool System.ComponentModel.IBindingList.IsSorted
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BB9")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001E9")]
	private override ListSortDirection System.ComponentModel.IBindingList.SortDirection
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000BBC")]
		private get { } //Length: 3
	}

	[Nullable(2)]
	[Token(Token = "0x170001EA")]
	private override PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[NullableContext(2)]
		[Token(Token = "0x6000BBD")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001EB")]
	private override bool System.ComponentModel.IBindingList.SupportsChangeNotification
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000BBE")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001EC")]
	private override bool System.ComponentModel.IBindingList.SupportsSearching
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BBF")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001ED")]
	private override bool System.ComponentModel.IBindingList.SupportsSorting
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BC0")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x21764C0", Offset = "0x21758C0", Length = "0x49")]
	[Token(Token = "0x6000B66")]
	internal JContainer() { }

	[Address(RVA = "0x2176510", Offset = "0x2175910", Length = "0x2FE")]
	[Token(Token = "0x6000B67")]
	internal JContainer(JContainer other, JsonCloneSettings settings) { }

	[Address(RVA = "0x21723D0", Offset = "0x21717D0", Length = "0x86")]
	[NullableContext(2)]
	[Token(Token = "0x6000B84")]
	public override void Add(object content) { }

	[Address(RVA = "0x2176810", Offset = "0x2175C10", Length = "0x9F")]
	[Token(Token = "0x6000B61")]
	public void add_AddingNew(AddingNewEventHandler value) { }

	[Address(RVA = "0x21768B0", Offset = "0x2175CB0", Length = "0x9F")]
	[NullableContext(2)]
	[Token(Token = "0x6000B63")]
	public override void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[Address(RVA = "0x2176950", Offset = "0x2175D50", Length = "0x9F")]
	[Token(Token = "0x6000B5F")]
	public override void add_ListChanged(ListChangedEventHandler value) { }

	[Address(RVA = "0x2172310", Offset = "0x2171710", Length = "0x86")]
	[Token(Token = "0x6000B86")]
	internal void AddAndSkipParentCheck(JToken token) { }

	[Address(RVA = "0x21723A0", Offset = "0x21717A0", Length = "0x24")]
	[NullableContext(2)]
	[Token(Token = "0x6000B87")]
	public void AddFirst(object content) { }

	[Address(RVA = "0x2172460", Offset = "0x2171860", Length = "0xA6")]
	[Token(Token = "0x6000B68")]
	internal void CheckReentrancy() { }

	[Address(RVA = "0x2172510", Offset = "0x2171910", Length = "0x63")]
	[Token(Token = "0x6000B71")]
	public virtual JEnumerable<JToken> Children() { }

	[Address(RVA = "0x2172580", Offset = "0x2171980", Length = "0x2F4")]
	[Token(Token = "0x6000B7E")]
	internal override void ClearItems() { }

	[Address(RVA = "0x2172880", Offset = "0x2171C80", Length = "0x22")]
	[NullableContext(2)]
	[Token(Token = "0x6000B80")]
	internal override bool ContainsItem(JToken item) { }

	[Address(RVA = "0x21728B0", Offset = "0x2171CB0", Length = "0x157")]
	[Token(Token = "0x6000B6E")]
	internal bool ContentsEqual(JContainer container) { }

	[Address(RVA = "0x2172A10", Offset = "0x2171E10", Length = "0x1F5")]
	[Token(Token = "0x6000B94")]
	internal int ContentsHashCode() { }

	[Address(RVA = "0x2172C10", Offset = "0x2172010", Length = "0x2E2")]
	[Token(Token = "0x6000B81")]
	internal override void CopyItemsTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x2172F00", Offset = "0x2172300", Length = "0x55")]
	[Token(Token = "0x6000B69")]
	internal override IList<JToken> CreateChildrenCollection() { }

	[Address(RVA = "0x2172F60", Offset = "0x2172360", Length = "0x9A")]
	[Token(Token = "0x6000B89")]
	internal static JToken CreateFromContent(object content) { }

	[Address(RVA = "0x2173000", Offset = "0x2172400", Length = "0x54")]
	[Token(Token = "0x6000B8A")]
	public JsonWriter CreateWriter() { }

	[Address(RVA = "0x2173070", Offset = "0x2172470", Length = "0xA")]
	[Token(Token = "0x6000B73")]
	public IEnumerable<JToken> Descendants() { }

	[Address(RVA = "0x2173060", Offset = "0x2172460", Length = "0xA")]
	[Token(Token = "0x6000B74")]
	public IEnumerable<JToken> DescendantsAndSelf() { }

	[Address(RVA = "0x2173080", Offset = "0x2172480", Length = "0x101")]
	[Token(Token = "0x6000B77")]
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[Address(RVA = "0x2173190", Offset = "0x2172590", Length = "0xAE")]
	[NullableContext(2)]
	[Token(Token = "0x6000BA2")]
	private JToken EnsureValue(object value) { }

	[Token(Token = "0x6000B65")]
	protected abstract IList<JToken> get_ChildrenTokens() { }

	[Address(RVA = "0x21769F0", Offset = "0x2175DF0", Length = "0x5B")]
	[Token(Token = "0x6000BAF")]
	public override int get_Count() { }

	[Address(RVA = "0x2176A50", Offset = "0x2175E50", Length = "0x8A")]
	[NullableContext(2)]
	[Token(Token = "0x6000B6F")]
	public virtual JToken get_First() { }

	[Address(RVA = "0x2176AE0", Offset = "0x2175EE0", Length = "0x61")]
	[Token(Token = "0x6000B6D")]
	public virtual bool get_HasValues() { }

	[Address(RVA = "0x2176B50", Offset = "0x2175F50", Length = "0x8B")]
	[NullableContext(2)]
	[Token(Token = "0x6000B70")]
	public virtual JToken get_Last() { }

	[Address(RVA = "0x2173240", Offset = "0x2172640", Length = "0x82")]
	[IteratorStateMachine(typeof(<GetDescendants>d__36))]
	[Token(Token = "0x6000B75")]
	internal IEnumerable<JToken> GetDescendants(bool self) { }

	[Address(RVA = "0x21732D0", Offset = "0x21726D0", Length = "0x69")]
	[Token(Token = "0x6000B7C")]
	internal override JToken GetItem(int index) { }

	[NullableContext(2)]
	[Token(Token = "0x6000B78")]
	internal abstract int IndexOfItem(JToken item) { }

	[Address(RVA = "0x2173340", Offset = "0x2172740", Length = "0x2C1")]
	[NullableContext(2)]
	[Token(Token = "0x6000B79")]
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[Address(RVA = "0x2173610", Offset = "0x2172A10", Length = "0xB9")]
	[NullableContext(2)]
	[Token(Token = "0x6000B76")]
	internal bool IsMultiContent(object content) { }

	[Address(RVA = "0x21736D0", Offset = "0x2172AD0", Length = "0xB0")]
	[Token(Token = "0x6000B82")]
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	[Address(RVA = "0x21741B0", Offset = "0x21735B0", Length = "0x44")]
	[NullableContext(2)]
	[Token(Token = "0x6000B8E")]
	public void Merge(object content) { }

	[Address(RVA = "0x2174150", Offset = "0x2173550", Length = "0x51")]
	[NullableContext(2)]
	[Token(Token = "0x6000B8F")]
	public void Merge(object content, JsonMergeSettings settings) { }

	[Address(RVA = "0x2173780", Offset = "0x2172B80", Length = "0x9CD")]
	[Token(Token = "0x6000BC1")]
	internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings) { }

	[Token(Token = "0x6000B8D")]
	internal abstract void MergeItem(object content, JsonMergeSettings settings) { }

	[Address(RVA = "0x2174200", Offset = "0x2173600", Length = "0x1F")]
	[Token(Token = "0x6000B6A")]
	protected override void OnAddingNew(AddingNewEventArgs e) { }

	[Address(RVA = "0x2174220", Offset = "0x2173620", Length = "0x6B")]
	[Token(Token = "0x6000B6C")]
	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	[Address(RVA = "0x2174290", Offset = "0x2173690", Length = "0x6B")]
	[Token(Token = "0x6000B6B")]
	protected override void OnListChanged(ListChangedEventArgs e) { }

	[Address(RVA = "0x2174450", Offset = "0x2173850", Length = "0x564")]
	[Token(Token = "0x6000B92")]
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	[Address(RVA = "0x2174300", Offset = "0x2173700", Length = "0x141")]
	[AsyncStateMachine(typeof(<ReadContentFromAsync>d__1))]
	[Token(Token = "0x6000B5E")]
	private Task ReadContentFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2174A00", Offset = "0x2173E00", Length = "0x26F")]
	[NullableContext(2)]
	[Token(Token = "0x6000B93")]
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	[Address(RVA = "0x2174DC0", Offset = "0x21741C0", Length = "0x1B4")]
	[Token(Token = "0x6000B91")]
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	[Address(RVA = "0x2174C70", Offset = "0x2174070", Length = "0x142")]
	[AsyncStateMachine(typeof(<ReadTokenFromAsync>d__0))]
	[Token(Token = "0x6000B5D")]
	internal Task ReadTokenFromAsync(JsonReader reader, JsonLoadSettings options, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2176BE0", Offset = "0x2175FE0", Length = "0x9F")]
	[Token(Token = "0x6000B62")]
	public void remove_AddingNew(AddingNewEventHandler value) { }

	[Address(RVA = "0x2176C80", Offset = "0x2176080", Length = "0x9F")]
	[NullableContext(2)]
	[Token(Token = "0x6000B64")]
	public override void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[Address(RVA = "0x2176D20", Offset = "0x2176120", Length = "0x9F")]
	[Token(Token = "0x6000B60")]
	public override void remove_ListChanged(ListChangedEventHandler value) { }

	[Address(RVA = "0x2155EF0", Offset = "0x21552F0", Length = "0x14")]
	[Token(Token = "0x6000B8C")]
	public void RemoveAll() { }

	[Address(RVA = "0x21752E0", Offset = "0x21746E0", Length = "0x4E")]
	[NullableContext(2)]
	[Token(Token = "0x6000B7B")]
	internal override bool RemoveItem(JToken item) { }

	[Address(RVA = "0x2174F80", Offset = "0x2174380", Length = "0x35F")]
	[Token(Token = "0x6000B7A")]
	internal override void RemoveItemAt(int index) { }

	[Address(RVA = "0x2175330", Offset = "0x2174730", Length = "0x47")]
	[Token(Token = "0x6000B8B")]
	public void ReplaceAll(object content) { }

	[Address(RVA = "0x2175380", Offset = "0x2174780", Length = "0x55")]
	[Token(Token = "0x6000B7F")]
	internal override void ReplaceItem(JToken existing, JToken replacement) { }

	[Address(RVA = "0x21753E0", Offset = "0x21747E0", Length = "0x46A")]
	[NullableContext(2)]
	[Token(Token = "0x6000B7D")]
	internal override void SetItem(int index, JToken item) { }

	[Address(RVA = "0x2155ED0", Offset = "0x21552D0", Length = "0x14")]
	[Token(Token = "0x6000B9C")]
	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	[Address(RVA = "0x2155EF0", Offset = "0x21552F0", Length = "0x14")]
	[Token(Token = "0x6000B9D")]
	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	[Address(RVA = "0x2155FE0", Offset = "0x21553E0", Length = "0x14")]
	[Token(Token = "0x6000B9E")]
	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	[Address(RVA = "0x2156000", Offset = "0x2155400", Length = "0x14")]
	[Token(Token = "0x6000B9F")]
	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BA0")]
	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	[Address(RVA = "0x2156BF0", Offset = "0x2155FF0", Length = "0x14")]
	[Token(Token = "0x6000BA1")]
	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	[Address(RVA = "0x21571C0", Offset = "0x21565C0", Length = "0x14")]
	[Token(Token = "0x6000B9A")]
	private override JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	[Address(RVA = "0x21564B0", Offset = "0x21558B0", Length = "0x14")]
	[Token(Token = "0x6000B97")]
	private override int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	[Address(RVA = "0x21564D0", Offset = "0x21558D0", Length = "0x2A")]
	[Token(Token = "0x6000B98")]
	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	[Address(RVA = "0x2156BD0", Offset = "0x2155FD0", Length = "0x14")]
	[Token(Token = "0x6000B99")]
	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	[Address(RVA = "0x21571E0", Offset = "0x21565E0", Length = "0x14")]
	[Token(Token = "0x6000B9B")]
	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	[Address(RVA = "0x2156000", Offset = "0x2155400", Length = "0x14")]
	[Token(Token = "0x6000BAE")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BB0")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x2175850", Offset = "0x2174C50", Length = "0x6B")]
	[Token(Token = "0x6000BB1")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x21758C0", Offset = "0x2174CC0", Length = "0x80")]
	[NullableContext(2)]
	[Token(Token = "0x6000BA3")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x2155EF0", Offset = "0x21552F0", Length = "0x14")]
	[Token(Token = "0x6000BA4")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0x2175950", Offset = "0x2174D50", Length = "0x30")]
	[NullableContext(2)]
	[Token(Token = "0x6000BA5")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BA8")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BA9")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0x21571C0", Offset = "0x21565C0", Length = "0x14")]
	[NullableContext(2)]
	[Token(Token = "0x6000BAC")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x2175980", Offset = "0x2174D80", Length = "0x30")]
	[NullableContext(2)]
	[Token(Token = "0x6000BA6")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x21759B0", Offset = "0x2174DB0", Length = "0x51")]
	[NullableContext(2)]
	[Token(Token = "0x6000BA7")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x2175A10", Offset = "0x2174E10", Length = "0x30")]
	[NullableContext(2)]
	[Token(Token = "0x6000BAA")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x2156BD0", Offset = "0x2155FD0", Length = "0x14")]
	[Token(Token = "0x6000BAB")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0x2175A40", Offset = "0x2174E40", Length = "0x43")]
	[NullableContext(2)]
	[Token(Token = "0x6000BAD")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BB2")]
	private override void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	[Address(RVA = "0x2175A90", Offset = "0x2174E90", Length = "0x209")]
	[Token(Token = "0x6000BB3")]
	private override object System.ComponentModel.IBindingList.AddNew() { }

	[Address(RVA = "0x2175CA0", Offset = "0x21750A0", Length = "0x3E")]
	[Token(Token = "0x6000BB7")]
	private override void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	[Address(RVA = "0x2175CE0", Offset = "0x21750E0", Length = "0x3E")]
	[Token(Token = "0x6000BB8")]
	private override int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000BB4")]
	private override bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000BB5")]
	private override bool System.ComponentModel.IBindingList.get_AllowNew() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000BB6")]
	private override bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BB9")]
	private override bool System.ComponentModel.IBindingList.get_IsSorted() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000BBC")]
	private override ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[NullableContext(2)]
	[Token(Token = "0x6000BBD")]
	private override PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000BBE")]
	private override bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BBF")]
	private override bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BC0")]
	private override bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BBA")]
	private override void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	[Address(RVA = "0x2175D20", Offset = "0x2175120", Length = "0x3E")]
	[Token(Token = "0x6000BBB")]
	private override void System.ComponentModel.IBindingList.RemoveSort() { }

	[Address(RVA = "0x2175D60", Offset = "0x2175160", Length = "0x184")]
	[Token(Token = "0x6000B96")]
	private override PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000B95")]
	private override string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	[Address(RVA = "0x2176190", Offset = "0x2175590", Length = "0x86")]
	[NullableContext(2)]
	[Token(Token = "0x6000B85")]
	internal bool TryAdd(object content) { }

	[Address(RVA = "0x2175EF0", Offset = "0x21752F0", Length = "0x29F")]
	[NullableContext(2)]
	[Token(Token = "0x6000B88")]
	internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	[Address(RVA = "0x2176220", Offset = "0x2175620", Length = "0x164")]
	[Token(Token = "0x6000B90")]
	private void ValidateContent(object content) { }

	[Address(RVA = "0x2176390", Offset = "0x2175790", Length = "0x12B")]
	[Token(Token = "0x6000B83")]
	internal override void ValidateToken(JToken o, JToken existing) { }

	[Address(RVA = "0x84D4B0", Offset = "0x84C8B0", Length = "0x52")]
	[NullableContext(2)]
	[Token(Token = "0x6000B72")]
	public virtual IEnumerable<T> Values() { }

}

