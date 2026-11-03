namespace System.Dynamic;

[Token(Token = "0x2000267")]
public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<String, Object>, ICollection<KeyValuePair`2<String, Object>>, IEnumerable<KeyValuePair`2<String, Object>>, IEnumerable, INotifyPropertyChanged
{
	[CompilerGenerated]
	[Token(Token = "0x2000272")]
	private sealed class <GetExpandoEnumerator>d__51 : IEnumerator<KeyValuePair`2<String, Object>>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000473")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000474")]
		private KeyValuePair<String, Object> <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000475")]
		public ExpandoObject <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000476")]
		public int version; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000477")]
		public ExpandoData data; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000478")]
		private int <i>5__2; //Field offset: 0x40

		[Token(Token = "0x1700027B")]
		private override KeyValuePair<String, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x6000C3A")]
			private get { } //Length: 11
		}

		[Token(Token = "0x1700027C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x22B9500", Offset = "0x22B8900", Length = "0x45")]
			[DebuggerHidden]
			[Token(Token = "0x6000C3C")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000C37")]
		public <GetExpandoEnumerator>d__51(int <>1__state) { }

		[Address(RVA = "0x22B92E0", Offset = "0x22B86E0", Length = "0x1D7")]
		[Token(Token = "0x6000C39")]
		private override bool MoveNext() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[DebuggerHidden]
		[Token(Token = "0x6000C3A")]
		private override KeyValuePair<String, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

		[Address(RVA = "0x22B9500", Offset = "0x22B8900", Length = "0x45")]
		[DebuggerHidden]
		[Token(Token = "0x6000C3C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x22B94C0", Offset = "0x22B88C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000C3B")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000C38")]
		private override void System.IDisposable.Dispose() { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x2000271")]
	private class ExpandoData
	{
		[Token(Token = "0x400046F")]
		internal static ExpandoData Empty; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000470")]
		internal readonly ExpandoClass Class; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000471")]
		private readonly Object[] _dataArray; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000472")]
		private int _version; //Field offset: 0x20

		[Token(Token = "0x17000278")]
		internal object Item
		{
			[Address(RVA = "0x1F12AF0", Offset = "0x1F11EF0", Length = "0x2B")]
			[Token(Token = "0x6000C2E")]
			internal get { } //Length: 43
			[Address(RVA = "0x22AE2D0", Offset = "0x22AD6D0", Length = "0x7E")]
			[Token(Token = "0x6000C2F")]
			internal set { } //Length: 126
		}

		[Token(Token = "0x1700027A")]
		internal int Length
		{
			[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
			[Token(Token = "0x6000C31")]
			internal get { } //Length: 26
		}

		[Token(Token = "0x17000279")]
		internal int Version
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[Token(Token = "0x6000C30")]
			internal get { } //Length: 4
		}

		[Address(RVA = "0x22AE040", Offset = "0x22AD440", Length = "0x13E")]
		[Token(Token = "0x6000C36")]
		private static ExpandoData() { }

		[Address(RVA = "0x22AE180", Offset = "0x22AD580", Length = "0xEF")]
		[Token(Token = "0x6000C32")]
		private ExpandoData() { }

		[Address(RVA = "0x22AE270", Offset = "0x22AD670", Length = "0x5F")]
		[Token(Token = "0x6000C33")]
		internal ExpandoData(ExpandoClass klass, Object[] data, int version) { }

		[Address(RVA = "0x1F12AF0", Offset = "0x1F11EF0", Length = "0x2B")]
		[Token(Token = "0x6000C2E")]
		internal object get_Item(int index) { }

		[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
		[Token(Token = "0x6000C31")]
		internal int get_Length() { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000C30")]
		internal int get_Version() { }

		[Address(RVA = "0x22ADD70", Offset = "0x22AD170", Length = "0x7")]
		[Token(Token = "0x6000C35")]
		private static int GetAlignedSize(int len) { }

		[Address(RVA = "0x22AE2D0", Offset = "0x22AD6D0", Length = "0x7E")]
		[Token(Token = "0x6000C2F")]
		internal void set_Item(int index, object value) { }

		[Address(RVA = "0x22ADD80", Offset = "0x22AD180", Length = "0x2B6")]
		[Token(Token = "0x6000C34")]
		internal ExpandoData UpdateClass(ExpandoClass newClass) { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(KeyCollectionDebugView))]
	[Token(Token = "0x2000269")]
	private class KeyCollection : ICollection<String>, IEnumerable<String>, IEnumerable
	{
		[CompilerGenerated]
		[Token(Token = "0x200026A")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<String>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000458")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000459")]
			private string <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400045A")]
			public KeyCollection <>4__this; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400045B")]
			private int <i>5__2; //Field offset: 0x28
			[FieldOffset(Offset = "0x2C")]
			[Token(Token = "0x400045C")]
			private int <n>5__3; //Field offset: 0x2C

			[Token(Token = "0x1700026F")]
			private override string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000C04")]
				private get { } //Length: 5
			}

			[Token(Token = "0x17000270")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000C06")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x6000C01")]
			public <GetEnumerator>d__15(int <>1__state) { }

			[Address(RVA = "0x22B90E0", Offset = "0x22B84E0", Length = "0x171")]
			[Token(Token = "0x6000C03")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C04")]
			private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C06")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x22B92A0", Offset = "0x22B86A0", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000C05")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x6000C02")]
			private override void System.IDisposable.Dispose() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000454")]
		private readonly ExpandoObject _expando; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000455")]
		private readonly int _expandoVersion; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000456")]
		private readonly int _expandoCount; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000457")]
		private readonly ExpandoData _expandoData; //Field offset: 0x20

		[Token(Token = "0x1700026D")]
		public override int Count
		{
			[Address(RVA = "0x229B4D0", Offset = "0x229A8D0", Length = "0x68")]
			[Token(Token = "0x6000BFC")]
			 get { } //Length: 104
		}

		[Token(Token = "0x1700026E")]
		public override bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6000BFD")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x229B3D0", Offset = "0x229A7D0", Length = "0xF0")]
		[Token(Token = "0x6000BF6")]
		internal KeyCollection(ExpandoObject expando) { }

		[Address(RVA = "0x229AE60", Offset = "0x229A260", Length = "0x27")]
		[Token(Token = "0x6000BF8")]
		public override void Add(string item) { }

		[Address(RVA = "0x229AE90", Offset = "0x229A290", Length = "0x64")]
		[Token(Token = "0x6000BF7")]
		private void CheckVersion() { }

		[Address(RVA = "0x229AF00", Offset = "0x229A300", Length = "0x27")]
		[Token(Token = "0x6000BF9")]
		public override void Clear() { }

		[Address(RVA = "0x229AF30", Offset = "0x229A330", Length = "0x12B")]
		[Token(Token = "0x6000BFA")]
		public override bool Contains(string item) { }

		[Address(RVA = "0x229B060", Offset = "0x229A460", Length = "0x2C0")]
		[Token(Token = "0x6000BFB")]
		public override void CopyTo(String[] array, int arrayIndex) { }

		[Address(RVA = "0x229B4D0", Offset = "0x229A8D0", Length = "0x68")]
		[Token(Token = "0x6000BFC")]
		public override int get_Count() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000BFD")]
		public override bool get_IsReadOnly() { }

		[Address(RVA = "0x229B330", Offset = "0x229A730", Length = "0x6D")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
		[Token(Token = "0x6000BFF")]
		public override IEnumerator<String> GetEnumerator() { }

		[Address(RVA = "0x229B3A0", Offset = "0x229A7A0", Length = "0x27")]
		[Token(Token = "0x6000BFE")]
		public override bool Remove(string item) { }

		[Address(RVA = "0x229B330", Offset = "0x229A730", Length = "0x6D")]
		[Token(Token = "0x6000C00")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x2000268")]
	private sealed class KeyCollectionDebugView
	{

	}

	[Token(Token = "0x200026E")]
	private class MetaExpando : DynamicMetaObject
	{
		[CompilerGenerated]
		[Token(Token = "0x200026F")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000466")]
			public InvokeMemberBinder binder; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000467")]
			public DynamicMetaObject[] args; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000C24")]
			public <>c__DisplayClass3_0() { }

			[Address(RVA = "0x22B95B0", Offset = "0x22B89B0", Length = "0x3A")]
			[Token(Token = "0x6000C25")]
			internal DynamicMetaObject <BindInvokeMember>b__0(DynamicMetaObject value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000270")]
		private sealed class <GetDynamicMemberNames>d__6 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000468")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000469")]
			private string <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400046A")]
			private int <>l__initialThreadId; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400046B")]
			public MetaExpando <>4__this; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x400046C")]
			private ExpandoData <expandoData>5__2; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x400046D")]
			private ExpandoClass <klass>5__3; //Field offset: 0x38
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x400046E")]
			private int <i>5__4; //Field offset: 0x40

			[Token(Token = "0x17000276")]
			private override string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000C29")]
				private get { } //Length: 5
			}

			[Token(Token = "0x17000277")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000C2B")]
				private get { } //Length: 5
			}

			[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x6000C26")]
			public <GetDynamicMemberNames>d__6(int <>1__state) { }

			[Address(RVA = "0x22B8C80", Offset = "0x22B8080", Length = "0x1C2")]
			[Token(Token = "0x6000C28")]
			private override bool MoveNext() { }

			[Address(RVA = "0x22B8E50", Offset = "0x22B8250", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000C2C")]
			private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C29")]
			private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

			[Address(RVA = "0x22B8E50", Offset = "0x22B8250", Length = "0x9C")]
			[DebuggerHidden]
			[Token(Token = "0x6000C2D")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C2B")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x22B8EF0", Offset = "0x22B82F0", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000C2A")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x6000C27")]
			private override void System.IDisposable.Dispose() { }

		}


		[Token(Token = "0x17000275")]
		public ExpandoObject Value
		{
			[Address(RVA = "0x22B1940", Offset = "0x22B0D40", Length = "0x57")]
			[Token(Token = "0x6000C23")]
			 get { } //Length: 87
		}

		[Address(RVA = "0x22B1880", Offset = "0x22B0C80", Length = "0xB2")]
		[Token(Token = "0x6000C18")]
		public MetaExpando(Expression expression, ExpandoObject value) { }

		[Address(RVA = "0x22AFEC0", Offset = "0x22AF2C0", Length = "0x2E0")]
		[Token(Token = "0x6000C1F")]
		private DynamicMetaObject AddDynamicTestAndDefer(DynamicMetaObjectBinder binder, ExpandoClass klass, ExpandoClass originalClass, DynamicMetaObject succeeds) { }

		[Address(RVA = "0x22B01B0", Offset = "0x22AF5B0", Length = "0x3D0")]
		[Token(Token = "0x6000C1D")]
		public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

		[Address(RVA = "0x22B0590", Offset = "0x22AF990", Length = "0xDA")]
		[Token(Token = "0x6000C1A")]
		public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

		[Address(RVA = "0x22B0670", Offset = "0x22AFA70", Length = "0x75E")]
		[Token(Token = "0x6000C19")]
		private DynamicMetaObject BindGetOrInvokeMember(DynamicMetaObjectBinder binder, string name, bool ignoreCase, DynamicMetaObject fallback, Func<DynamicMetaObject, DynamicMetaObject> fallbackInvoke) { }

		[Address(RVA = "0x22B0DD0", Offset = "0x22B01D0", Length = "0x199")]
		[Token(Token = "0x6000C1B")]
		public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

		[Address(RVA = "0x22B0F70", Offset = "0x22B0370", Length = "0x5DF")]
		[Token(Token = "0x6000C1C")]
		public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

		[Address(RVA = "0x22B1940", Offset = "0x22B0D40", Length = "0x57")]
		[Token(Token = "0x6000C23")]
		public ExpandoObject get_Value() { }

		[Address(RVA = "0x22B1550", Offset = "0x22B0950", Length = "0x124")]
		[Token(Token = "0x6000C20")]
		private ExpandoClass GetClassEnsureIndex(string name, bool caseInsensitive, ExpandoObject obj, out ExpandoClass klass, out int index) { }

		[Address(RVA = "0x22B1680", Offset = "0x22B0A80", Length = "0x71")]
		[IteratorStateMachine(typeof(<GetDynamicMemberNames>d__6))]
		[Token(Token = "0x6000C1E")]
		public virtual IEnumerable<String> GetDynamicMemberNames() { }

		[Address(RVA = "0x22B1700", Offset = "0x22B0B00", Length = "0x129")]
		[Token(Token = "0x6000C21")]
		private Expression GetLimitedSelf() { }

		[Address(RVA = "0x22B1830", Offset = "0x22B0C30", Length = "0x49")]
		[Token(Token = "0x6000C22")]
		private BindingRestrictions GetRestrictions() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(ValueCollectionDebugView))]
	[Token(Token = "0x200026C")]
	private class ValueCollection : ICollection<Object>, IEnumerable<Object>, IEnumerable
	{
		[CompilerGenerated]
		[Token(Token = "0x200026D")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<Object>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000461")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000462")]
			private object <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000463")]
			public ValueCollection <>4__this; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000464")]
			private ExpandoData <data>5__2; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000465")]
			private int <i>5__3; //Field offset: 0x30

			[Token(Token = "0x17000273")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000C15")]
				private get { } //Length: 5
			}

			[Token(Token = "0x17000274")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000C17")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x6000C12")]
			public <GetEnumerator>d__15(int <>1__state) { }

			[Address(RVA = "0x22B8F30", Offset = "0x22B8330", Length = "0x1AE")]
			[Token(Token = "0x6000C14")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C15")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C17")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x22B9260", Offset = "0x22B8660", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000C16")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x6000C13")]
			private override void System.IDisposable.Dispose() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400045D")]
		private readonly ExpandoObject _expando; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400045E")]
		private readonly int _expandoVersion; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400045F")]
		private readonly int _expandoCount; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000460")]
		private readonly ExpandoData _expandoData; //Field offset: 0x20

		[Token(Token = "0x17000271")]
		public override int Count
		{
			[Address(RVA = "0x22B9DA0", Offset = "0x22B91A0", Length = "0x783")]
			[Token(Token = "0x6000C0D")]
			 get { } //Length: 1923
		}

		[Token(Token = "0x17000272")]
		public override bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6000C0E")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x229B3D0", Offset = "0x229A7D0", Length = "0xF0")]
		[Token(Token = "0x6000C07")]
		internal ValueCollection(ExpandoObject expando) { }

		[Address(RVA = "0x22B9750", Offset = "0x22B8B50", Length = "0x27")]
		[Token(Token = "0x6000C09")]
		public override void Add(object item) { }

		[Address(RVA = "0x22B9780", Offset = "0x22B8B80", Length = "0x64")]
		[Token(Token = "0x6000C08")]
		private void CheckVersion() { }

		[Address(RVA = "0x22B97F0", Offset = "0x22B8BF0", Length = "0x27")]
		[Token(Token = "0x6000C0A")]
		public override void Clear() { }

		[Address(RVA = "0x22B9820", Offset = "0x22B8C20", Length = "0x1AE")]
		[Token(Token = "0x6000C0B")]
		public override bool Contains(object item) { }

		[Address(RVA = "0x22B99D0", Offset = "0x22B8DD0", Length = "0x32C")]
		[Token(Token = "0x6000C0C")]
		public override void CopyTo(Object[] array, int arrayIndex) { }

		[Address(RVA = "0x22B9DA0", Offset = "0x22B91A0", Length = "0x783")]
		[Token(Token = "0x6000C0D")]
		public override int get_Count() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000C0E")]
		public override bool get_IsReadOnly() { }

		[Address(RVA = "0x22B9D00", Offset = "0x22B9100", Length = "0x67")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
		[Token(Token = "0x6000C10")]
		public override IEnumerator<Object> GetEnumerator() { }

		[Address(RVA = "0x22B9D70", Offset = "0x22B9170", Length = "0x27")]
		[Token(Token = "0x6000C0F")]
		public override bool Remove(object item) { }

		[Address(RVA = "0x22B9D00", Offset = "0x22B9100", Length = "0x67")]
		[Token(Token = "0x6000C11")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x200026B")]
	private sealed class ValueCollectionDebugView
	{

	}

	[Token(Token = "0x400044A")]
	private static readonly MethodInfo s_expandoTryGetValue; //Field offset: 0x0
	[Token(Token = "0x400044B")]
	private static readonly MethodInfo s_expandoTrySetValue; //Field offset: 0x8
	[Token(Token = "0x400044C")]
	private static readonly MethodInfo s_expandoTryDeleteValue; //Field offset: 0x10
	[Token(Token = "0x400044D")]
	private static readonly MethodInfo s_expandoPromoteClass; //Field offset: 0x18
	[Token(Token = "0x400044E")]
	private static readonly MethodInfo s_expandoCheckVersion; //Field offset: 0x20
	[Token(Token = "0x4000452")]
	internal static readonly object Uninitialized; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400044F")]
	internal readonly object LockObject; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000450")]
	private ExpandoData _data; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000451")]
	private int _count; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000453")]
	private PropertyChangedEventHandler _propertyChanged; //Field offset: 0x28

	[Token(Token = "0x17000267")]
	internal ExpandoClass Class
	{
		[Address(RVA = "0x21B18E0", Offset = "0x21B0CE0", Length = "0x1B")]
		[Token(Token = "0x6000BDC")]
		internal get { } //Length: 27
	}

	[Token(Token = "0x1700026B")]
	private override int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000BEB")]
		private get { } //Length: 4
	}

	[Token(Token = "0x1700026C")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BEC")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700026A")]
	private override object System.Collections.Generic.IDictionary<System.String,System.Object>.Item
	{
		[Address(RVA = "0x2298810", Offset = "0x2297C10", Length = "0x67")]
		[Token(Token = "0x6000BE5")]
		private get { } //Length: 103
		[Address(RVA = "0x2298940", Offset = "0x2297D40", Length = "0x81")]
		[Token(Token = "0x6000BE6")]
		private set { } //Length: 129
	}

	[Token(Token = "0x17000268")]
	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys
	{
		[Address(RVA = "0x2298880", Offset = "0x2297C80", Length = "0x54")]
		[Token(Token = "0x6000BE3")]
		private get { } //Length: 84
	}

	[Token(Token = "0x17000269")]
	private override ICollection<Object> System.Collections.Generic.IDictionary<System.String,System.Object>.Values
	{
		[Address(RVA = "0x22988E0", Offset = "0x2297CE0", Length = "0x54")]
		[Token(Token = "0x6000BE4")]
		private get { } //Length: 84
	}

	[Address(RVA = "0x22992C0", Offset = "0x22986C0", Length = "0x281")]
	[Token(Token = "0x6000BF5")]
	private static ExpandoObject() { }

	[Address(RVA = "0x2299550", Offset = "0x2298950", Length = "0xA8")]
	[Token(Token = "0x6000BD7")]
	public ExpandoObject() { }

	[Address(RVA = "0x2297C40", Offset = "0x2297040", Length = "0x2D")]
	[Token(Token = "0x6000BE2")]
	private bool ExpandoContainsKey(string key) { }

	[Address(RVA = "0x21B18E0", Offset = "0x21B0CE0", Length = "0x1B")]
	[Token(Token = "0x6000BDC")]
	internal ExpandoClass get_Class() { }

	[Address(RVA = "0x2297C70", Offset = "0x2297070", Length = "0x9A")]
	[IteratorStateMachine(typeof(<GetExpandoEnumerator>d__51))]
	[Token(Token = "0x6000BF4")]
	private IEnumerator<KeyValuePair`2<String, Object>> GetExpandoEnumerator(ExpandoData data, int version) { }

	[Address(RVA = "0x2297D10", Offset = "0x2297110", Length = "0x9C")]
	[Token(Token = "0x6000BDB")]
	internal bool IsDeletedMember(int index) { }

	[Address(RVA = "0x2297E00", Offset = "0x2297200", Length = "0x173")]
	[Token(Token = "0x6000BDE")]
	internal void PromoteClass(object oldClass, object newClass) { }

	[Address(RVA = "0x2297DB0", Offset = "0x22971B0", Length = "0x48")]
	[Token(Token = "0x6000BDD")]
	private ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	[Address(RVA = "0x2297F80", Offset = "0x2297380", Length = "0x54")]
	[Token(Token = "0x6000BED")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<String, Object> item) { }

	[Address(RVA = "0x2297FE0", Offset = "0x22973E0", Length = "0x245")]
	[Token(Token = "0x6000BEE")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	[Address(RVA = "0x2298230", Offset = "0x2297630", Length = "0x93")]
	[Token(Token = "0x6000BEF")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<String, Object> item) { }

	[Address(RVA = "0x22982D0", Offset = "0x22976D0", Length = "0x30B")]
	[Token(Token = "0x6000BF0")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<String, Object>[] array, int arrayIndex) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000BEB")]
	private override int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BEC")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	[Address(RVA = "0x22985E0", Offset = "0x22979E0", Length = "0x6D")]
	[Token(Token = "0x6000BF1")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<String, Object> item) { }

	[Address(RVA = "0x2298650", Offset = "0x2297A50", Length = "0x8")]
	[Token(Token = "0x6000BE7")]
	private override void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	[Address(RVA = "0x2298660", Offset = "0x2297A60", Length = "0xC2")]
	[Token(Token = "0x6000BE8")]
	private override bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	[Address(RVA = "0x2298810", Offset = "0x2297C10", Length = "0x67")]
	[Token(Token = "0x6000BE5")]
	private override object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	[Address(RVA = "0x2298880", Offset = "0x2297C80", Length = "0x54")]
	[Token(Token = "0x6000BE3")]
	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	[Address(RVA = "0x22988E0", Offset = "0x2297CE0", Length = "0x54")]
	[Token(Token = "0x6000BE4")]
	private override ICollection<Object> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values() { }

	[Address(RVA = "0x2298730", Offset = "0x2297B30", Length = "0xA5")]
	[Token(Token = "0x6000BE9")]
	private override bool System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(string key) { }

	[Address(RVA = "0x2298940", Offset = "0x2297D40", Length = "0x81")]
	[Token(Token = "0x6000BE6")]
	private override void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(string key, object value) { }

	[Address(RVA = "0x22987E0", Offset = "0x2297BE0", Length = "0x2C")]
	[Token(Token = "0x6000BEA")]
	private override bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	[Address(RVA = "0x22989D0", Offset = "0x2297DD0", Length = "0x22")]
	[Token(Token = "0x6000BF2")]
	private override IEnumerator<KeyValuePair`2<String, Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	[Address(RVA = "0x22989D0", Offset = "0x2297DD0", Length = "0x22")]
	[Token(Token = "0x6000BF3")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x2298A00", Offset = "0x2297E00", Length = "0x64")]
	[Token(Token = "0x6000BDF")]
	private override DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	[Address(RVA = "0x2298A70", Offset = "0x2297E70", Length = "0x81")]
	[Token(Token = "0x6000BE0")]
	private void TryAddMember(string key, object value) { }

	[Address(RVA = "0x2298B00", Offset = "0x2297F00", Length = "0x304")]
	[Token(Token = "0x6000BDA")]
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	[Address(RVA = "0x2298E10", Offset = "0x2298210", Length = "0x146")]
	[Token(Token = "0x6000BD8")]
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	[Address(RVA = "0x22987E0", Offset = "0x2297BE0", Length = "0x2C")]
	[Token(Token = "0x6000BE1")]
	private bool TryGetValueForKey(string key, out object value) { }

	[Address(RVA = "0x2298F60", Offset = "0x2298360", Length = "0x35E")]
	[Token(Token = "0x6000BD9")]
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

}

