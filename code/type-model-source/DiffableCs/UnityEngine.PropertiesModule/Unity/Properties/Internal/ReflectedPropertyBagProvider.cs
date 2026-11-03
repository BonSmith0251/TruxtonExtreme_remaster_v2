namespace Unity.Properties.Internal;

[Token(Token = "0x20000A2")]
internal class ReflectedPropertyBagProvider
{
	[CompilerGenerated]
	[Token(Token = "0x20000A3")]
	private sealed class <>c
	{
		[Token(Token = "0x400016B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400016C")]
		public static Func<MethodInfo, Boolean> <>9__10_0; //Field offset: 0x8
		[Token(Token = "0x400016D")]
		public static Func<MemberInfo, Int32> <>9__22_0; //Field offset: 0x10

		[Address(RVA = "0x3164850", Offset = "0x3163C50", Length = "0x67")]
		[Token(Token = "0x600033A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600033B")]
		public <>c() { }

		[Address(RVA = "0x3164670", Offset = "0x3163A70", Length = "0x8C")]
		[Token(Token = "0x600033C")]
		internal bool <.ctor>b__10_0(MethodInfo x) { }

		[Address(RVA = "0xA50640", Offset = "0xA4FA40", Length = "0x2C")]
		[Token(Token = "0x600033D")]
		internal int <GetPropertyMembers>b__22_0(MemberInfo x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A4")]
	private sealed class <GetPropertyMembers>d__22 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400016E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400016F")]
		private MemberInfo <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000170")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000171")]
		private Type type; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000172")]
		public Type <>3__type; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000173")]
		private IOrderedEnumerable<MemberInfo> <members>5__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000174")]
		private IEnumerator<MemberInfo> <>s__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000175")]
		private MemberInfo <member>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000176")]
		private bool <hasDontCreatePropertyAttribute>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x51")]
		[Token(Token = "0x4000177")]
		private bool <hasCreatePropertyAttribute>5__5; //Field offset: 0x51
		[FieldOffset(Offset = "0x52")]
		[Token(Token = "0x4000178")]
		private bool <hasNonSerializedAttribute>5__6; //Field offset: 0x52
		[FieldOffset(Offset = "0x53")]
		[Token(Token = "0x4000179")]
		private bool <hasSerializedFieldAttribute>5__7; //Field offset: 0x53
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x400017A")]
		private bool <hasSerializeReferenceAttribute>5__8; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400017B")]
		private FieldInfo <field>5__9; //Field offset: 0x58

		[Token(Token = "0x17000096")]
		private override MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000342")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000097")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000344")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x600033E")]
		public <GetPropertyMembers>d__22(int <>1__state) { }

		[Address(RVA = "0x3163100", Offset = "0x3162500", Length = "0x50")]
		[Token(Token = "0x6000341")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x3162670", Offset = "0x3161A70", Length = "0x917")]
		[Token(Token = "0x6000340")]
		private override bool MoveNext() { }

		[Address(RVA = "0x3162F90", Offset = "0x3162390", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6000345")]
		private override IEnumerator<MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000342")]
		private override MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

		[Address(RVA = "0x3162F90", Offset = "0x3162390", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6000346")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000344")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x3163030", Offset = "0x3162430", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000343")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x3163070", Offset = "0x3162470", Length = "0x8E")]
		[DebuggerHidden]
		[Token(Token = "0x600033F")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000161")]
	private readonly MethodInfo m_CreatePropertyMethod; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000162")]
	private readonly MethodInfo m_CreatePropertyBagMethod; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000163")]
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000164")]
	private readonly MethodInfo m_CreateSetPropertyBagMethod; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000165")]
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000166")]
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000167")]
	private readonly MethodInfo m_CreateArrayPropertyBagMethod; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000168")]
	private readonly MethodInfo m_CreateListPropertyBagMethod; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000169")]
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400016A")]
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod; //Field offset: 0x58

	[Address(RVA = "0x3160350", Offset = "0x315F750", Length = "0x44D")]
	[Token(Token = "0x600032B")]
	public ReflectedPropertyBagProvider() { }

	[Address(RVA = "0x8E3C60", Offset = "0x8E3060", Length = "0x5E")]
	[Preserve]
	[Token(Token = "0x6000333")]
	private IPropertyBag<TElement[]> CreateArrayPropertyBag() { }

	[Address(RVA = "0x8E3C60", Offset = "0x8E3060", Length = "0x5E")]
	[Preserve]
	[Token(Token = "0x6000336")]
	private IPropertyBag<Dictionary`2<TKey, TValue>> CreateDictionaryPropertyBag() { }

	[Address(RVA = "0x8E3C60", Offset = "0x8E3060", Length = "0x5E")]
	[Preserve]
	[Token(Token = "0x6000335")]
	private IPropertyBag<HashSet`1<TElement>> CreateHashSetPropertyBag() { }

	[Address(RVA = "0x8E3C60", Offset = "0x8E3060", Length = "0x5E")]
	[Preserve]
	[Token(Token = "0x600032F")]
	private IPropertyBag<TList> CreateIndexedCollectionPropertyBag() { }

	[Address(RVA = "0x8E3C60", Offset = "0x8E3060", Length = "0x5E")]
	[Preserve]
	[Token(Token = "0x6000331")]
	private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag() { }

	[Address(RVA = "0x8E3C60", Offset = "0x8E3060", Length = "0x5E")]
	[Preserve]
	[Token(Token = "0x6000332")]
	private IPropertyBag<KeyValuePair`2<TKey, TValue>> CreateKeyValuePairPropertyBag() { }

	[Address(RVA = "0x8E3C60", Offset = "0x8E3060", Length = "0x5E")]
	[Preserve]
	[Token(Token = "0x6000334")]
	private IPropertyBag<List`1<TElement>> CreateListPropertyBag() { }

	[Address(RVA = "0x8E57A0", Offset = "0x8E4BA0", Length = "0x177")]
	[Preserve]
	[Token(Token = "0x600032E")]
	private void CreateProperty(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag) { }

	[Address(RVA = "0x315FF50", Offset = "0x315F350", Length = "0x14F")]
	[Token(Token = "0x600032C")]
	public IPropertyBag CreatePropertyBag(Type type) { }

	[Address(RVA = "0x8E3CC0", Offset = "0x8E30C0", Length = "0x1AD5")]
	[Token(Token = "0x600032D")]
	public IPropertyBag<TContainer> CreatePropertyBag() { }

	[Address(RVA = "0x8E3C60", Offset = "0x8E3060", Length = "0x5E")]
	[Preserve]
	[Token(Token = "0x6000330")]
	private IPropertyBag<TSet> CreateSetPropertyBag() { }

	[Address(RVA = "0x31600A0", Offset = "0x315F4A0", Length = "0x71")]
	[IteratorStateMachine(typeof(<GetPropertyMembers>d__22))]
	[Token(Token = "0x6000337")]
	private static IEnumerable<MemberInfo> GetPropertyMembers(Type type) { }

	[Address(RVA = "0x3160120", Offset = "0x315F520", Length = "0x135")]
	[Token(Token = "0x6000338")]
	private static bool IsValidMember(MemberInfo memberInfo) { }

	[Address(RVA = "0x3160260", Offset = "0x315F660", Length = "0xE5")]
	[Token(Token = "0x6000339")]
	private static bool IsValidPropertyType(Type type) { }

}

