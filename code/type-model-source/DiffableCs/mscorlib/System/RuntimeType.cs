namespace System;

[Token(Token = "0x2000192")]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable
{
	[DefaultMember("Item")]
	[Token(Token = "0x2000194")]
	private struct ListBuilder
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EC")]
		private T[] _items; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005ED")]
		private T _item; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EE")]
		private int _count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EF")]
		private int _capacity; //Field offset: 0x0

		[Token(Token = "0x17000142")]
		public int Count
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x6000EEF")]
			 get { } //Length: 85
		}

		[Token(Token = "0x17000141")]
		public T Item
		{
			[Address(RVA = "0xB0AD90", Offset = "0xB0A190", Length = "0x2E")]
			[Token(Token = "0x6000EEC")]
			 get { } //Length: 46
		}

		[Address(RVA = "0xB0AD50", Offset = "0xB0A150", Length = "0x34")]
		[Token(Token = "0x6000EEB")]
		public ListBuilder`1(int capacity) { }

		[Address(RVA = "0xB0AA00", Offset = "0xB09E00", Length = "0x129")]
		[Token(Token = "0x6000EF0")]
		public void Add(T item) { }

		[Address(RVA = "0xB0AB30", Offset = "0xB09F30", Length = "0xB3")]
		[Token(Token = "0x6000EEE")]
		public void CopyTo(Object[] array, int index) { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000EEF")]
		public int get_Count() { }

		[Address(RVA = "0xB0AD90", Offset = "0xB0A190", Length = "0x2E")]
		[Token(Token = "0x6000EEC")]
		public T get_Item(int index) { }

		[Address(RVA = "0xB0ABF0", Offset = "0xB09FF0", Length = "0x157")]
		[Token(Token = "0x6000EED")]
		public T[] ToArray() { }

	}

	[Token(Token = "0x2000193")]
	public enum MemberListType : int
	{
		All = 0,
		CaseSensitive = 1,
		CaseInsensitive = 2,
		HandleToInfo = 3,
	}

	[Token(Token = "0x40005D2")]
	internal static readonly RuntimeType ValueType; //Field offset: 0x0
	[Token(Token = "0x40005E1")]
	private const BindingFlags ClassicBindingMask = 61696; //Field offset: 0x0
	[Token(Token = "0x40005E0")]
	private const BindingFlags BinderNonFieldGetSet = 16773888; //Field offset: 0x0
	[Token(Token = "0x40005DF")]
	private const BindingFlags BinderSetInvokeField = 2304; //Field offset: 0x0
	[Token(Token = "0x40005DE")]
	private const BindingFlags BinderGetSetField = 3072; //Field offset: 0x0
	[Token(Token = "0x40005DD")]
	private const BindingFlags BinderSetInvokeProperty = 8448; //Field offset: 0x0
	[Token(Token = "0x40005DB")]
	private const BindingFlags BinderNonCreateInstance = 15616; //Field offset: 0x0
	[Token(Token = "0x40005DA")]
	private const BindingFlags InvocationMask = 65280; //Field offset: 0x0
	[Token(Token = "0x40005DC")]
	private const BindingFlags BinderGetSetProperty = 12288; //Field offset: 0x0
	[Token(Token = "0x40005D9")]
	private const BindingFlags MemberBindingMask = 255; //Field offset: 0x0
	[Token(Token = "0x40005E6")]
	private const int GenericParameterCountAny = -1; //Field offset: 0x0
	[Token(Token = "0x40005D3")]
	internal static readonly RuntimeType EnumType; //Field offset: 0x8
	[Token(Token = "0x40005D4")]
	private static readonly RuntimeType ObjectType; //Field offset: 0x10
	[Token(Token = "0x40005D5")]
	private static readonly RuntimeType StringType; //Field offset: 0x18
	[Token(Token = "0x40005D6")]
	private static readonly RuntimeType DelegateType; //Field offset: 0x20
	[Token(Token = "0x40005D7")]
	private static Type[] s_SICtorParamTypes; //Field offset: 0x28
	[Token(Token = "0x40005D8")]
	internal static Func<Type, Type[], Type> MakeTypeBuilderInstantiation; //Field offset: 0x30
	[Token(Token = "0x40005E2")]
	private static RuntimeType s_typedRef; //Field offset: 0x38
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005E3")]
	private MonoTypeInfo type_info; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005E4")]
	internal object GenericCache; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005E5")]
	private RuntimeConstructorInfo m_serializationCtor; //Field offset: 0x28

	[Token(Token = "0x17000129")]
	public virtual Assembly Assembly
	{
		[Address(RVA = "0x2072E80", Offset = "0x2072280", Length = "0x7")]
		[Token(Token = "0x6000E7C")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700013B")]
	public virtual string AssemblyQualifiedName
	{
		[Address(RVA = "0x20774C0", Offset = "0x20768C0", Length = "0xC")]
		[Token(Token = "0x6000EDF")]
		 get { } //Length: 12
	}

	[Token(Token = "0x1700012B")]
	public virtual Type BaseType
	{
		[Address(RVA = "0x20774D0", Offset = "0x20768D0", Length = "0x7")]
		[Token(Token = "0x6000E82")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000138")]
	public virtual bool ContainsGenericParameters
	{
		[Address(RVA = "0x20774E0", Offset = "0x20768E0", Length = "0x119")]
		[Token(Token = "0x6000EC1")]
		 get { } //Length: 281
	}

	[Token(Token = "0x1700013A")]
	public virtual MethodBase DeclaringMethod
	{
		[Address(RVA = "0x2077600", Offset = "0x2076A00", Length = "0x5")]
		[Token(Token = "0x6000ED3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700013C")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x2077610", Offset = "0x2076A10", Length = "0x5")]
		[Token(Token = "0x6000EE0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700013F")]
	public virtual string FullName
	{
		[Address(RVA = "0x2077620", Offset = "0x2076A20", Length = "0x107")]
		[Token(Token = "0x6000EE4")]
		 get { } //Length: 263
	}

	[Token(Token = "0x1700012E")]
	public virtual GenericParameterAttributes GenericParameterAttributes
	{
		[Address(RVA = "0x20777D0", Offset = "0x2076BD0", Length = "0xC0")]
		[Token(Token = "0x6000E8E")]
		 get { } //Length: 192
	}

	[Token(Token = "0x17000132")]
	public virtual int GenericParameterPosition
	{
		[Address(RVA = "0x20778A0", Offset = "0x2076CA0", Length = "0x8C")]
		[Token(Token = "0x6000E9D")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000139")]
	public virtual Guid GUID
	{
		[Address(RVA = "0x2077730", Offset = "0x2076B30", Length = "0x98")]
		[Token(Token = "0x6000ECC")]
		 get { } //Length: 152
	}

	[Token(Token = "0x17000134")]
	public virtual bool IsConstructedGenericType
	{
		[Address(RVA = "0x2077930", Offset = "0x2076D30", Length = "0x47")]
		[Token(Token = "0x6000EA0")]
		 get { } //Length: 71
	}

	[Token(Token = "0x1700012D")]
	public virtual bool IsEnum
	{
		[Address(RVA = "0x2077980", Offset = "0x2076D80", Length = "0x62")]
		[Token(Token = "0x6000E8C")]
		 get { } //Length: 98
	}

	[Token(Token = "0x17000131")]
	public virtual bool IsGenericParameter
	{
		[Address(RVA = "0x20779F0", Offset = "0x2076DF0", Length = "0x7")]
		[Token(Token = "0x6000E9C")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000133")]
	public virtual bool IsGenericType
	{
		[Address(RVA = "0x2077A10", Offset = "0x2076E10", Length = "0x7")]
		[Token(Token = "0x6000E9F")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000130")]
	public virtual bool IsGenericTypeDefinition
	{
		[Address(RVA = "0x2077A00", Offset = "0x2076E00", Length = "0x7")]
		[Token(Token = "0x6000E9B")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700012F")]
	internal virtual bool IsSzArray
	{
		[Address(RVA = "0x2077A80", Offset = "0x2076E80", Length = "0x7")]
		[Token(Token = "0x6000E8F")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000140")]
	public virtual bool IsSZArray
	{
		[Address(RVA = "0x2077A20", Offset = "0x2076E20", Length = "0x5D")]
		[Token(Token = "0x6000EE5")]
		 get { } //Length: 93
	}

	[Token(Token = "0x17000135")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x2077A90", Offset = "0x2076E90", Length = "0x40")]
		[Token(Token = "0x6000EAB")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000137")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x2077AD0", Offset = "0x2076ED0", Length = "0x7")]
		[Token(Token = "0x6000EAD")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000128")]
	public virtual Module Module
	{
		[Address(RVA = "0x2072E90", Offset = "0x2072290", Length = "0x7")]
		[Token(Token = "0x6000E7A")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700013D")]
	public virtual string Name
	{
		[Address(RVA = "0x2077AE0", Offset = "0x2076EE0", Length = "0x5")]
		[Token(Token = "0x6000EE1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700013E")]
	public virtual string Namespace
	{
		[Address(RVA = "0x2077AF0", Offset = "0x2076EF0", Length = "0x5")]
		[Token(Token = "0x6000EE2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000136")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x2077B00", Offset = "0x2076F00", Length = "0x14")]
		[Token(Token = "0x6000EAC")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700012A")]
	public virtual RuntimeTypeHandle TypeHandle
	{
		[Address(RVA = "0x2077B20", Offset = "0x2076F20", Length = "0x27")]
		[Token(Token = "0x6000E7E")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700012C")]
	public virtual Type UnderlyingSystemType
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6000E84")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2076F70", Offset = "0x2076370", Length = "0x4E4")]
	[Token(Token = "0x6000EEA")]
	private static RuntimeType() { }

	[Address(RVA = "0x2077460", Offset = "0x2076860", Length = "0x45")]
	[Token(Token = "0x6000E67")]
	internal RuntimeType() { }

	[Address(RVA = "0x206B7A0", Offset = "0x206ABA0", Length = "0x1F0")]
	[Token(Token = "0x6000EB6")]
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000EA5")]
	public override object Clone() { }

	[Address(RVA = "0x206B9A0", Offset = "0x206ADA0", Length = "0x292")]
	[Token(Token = "0x6000EAE")]
	private void CreateInstanceCheckThis() { }

	[Address(RVA = "0x206BC40", Offset = "0x206B040", Length = "0x11C")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000EB0")]
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x206BD60", Offset = "0x206B160", Length = "0x13E")]
	[Token(Token = "0x6000EC3")]
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	[Address(RVA = "0x206BEA0", Offset = "0x206B2A0", Length = "0x852")]
	[Token(Token = "0x6000EAF")]
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x206C700", Offset = "0x206BB00", Length = "0x5")]
	[Token(Token = "0x6000ED2")]
	private static object CreateInstanceInternal(Type type) { }

	[Address(RVA = "0x206C710", Offset = "0x206BB10", Length = "0x2DD")]
	[Token(Token = "0x6000EB5")]
	private object CreateInstanceMono(bool nonPublic, bool wrapExceptions) { }

	[Address(RVA = "0x206C9F0", Offset = "0x206BDF0", Length = "0x4B")]
	[Token(Token = "0x6000EB4")]
	internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache) { }

	[Address(RVA = "0x206CA40", Offset = "0x206BE40", Length = "0x7")]
	[Token(Token = "0x6000EA2")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x206CA50", Offset = "0x206BE50", Length = "0x208")]
	[Token(Token = "0x6000E62")]
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	[Address(RVA = "0x206CC60", Offset = "0x206C060", Length = "0xA6")]
	[Token(Token = "0x6000E65")]
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	[Address(RVA = "0x206CD10", Offset = "0x206C110", Length = "0x26B")]
	[Token(Token = "0x6000E66")]
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	[Address(RVA = "0x206CF80", Offset = "0x206C380", Length = "0xA6")]
	[Token(Token = "0x6000E64")]
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	[Address(RVA = "0x206D030", Offset = "0x206C430", Length = "0x7E")]
	[Token(Token = "0x6000E61")]
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	[Address(RVA = "0x206D0B0", Offset = "0x206C4B0", Length = "0x114")]
	[Token(Token = "0x6000E63")]
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	[Address(RVA = "0x206D1D0", Offset = "0x206C5D0", Length = "0x100")]
	[Token(Token = "0x6000E60")]
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out MemberListType listType) { }

	[Address(RVA = "0x206D2E0", Offset = "0x206C6E0", Length = "0x14E")]
	[Token(Token = "0x6000E5F")]
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out MemberListType listType) { }

	[Address(RVA = "0x206D430", Offset = "0x206C830", Length = "0x3D")]
	[Token(Token = "0x6000E5E")]
	internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic) { }

	[Address(RVA = "0x206D470", Offset = "0x206C870", Length = "0x17F")]
	[Token(Token = "0x6000EAA")]
	internal virtual string FormatTypeName(bool serialization) { }

	[Address(RVA = "0x2072E80", Offset = "0x2072280", Length = "0x7")]
	[Token(Token = "0x6000E7C")]
	public virtual Assembly get_Assembly() { }

	[Address(RVA = "0x20774C0", Offset = "0x20768C0", Length = "0xC")]
	[Token(Token = "0x6000EDF")]
	public virtual string get_AssemblyQualifiedName() { }

	[Address(RVA = "0x20774D0", Offset = "0x20768D0", Length = "0x7")]
	[Token(Token = "0x6000E82")]
	public virtual Type get_BaseType() { }

	[Address(RVA = "0x20774E0", Offset = "0x20768E0", Length = "0x119")]
	[Token(Token = "0x6000EC1")]
	public virtual bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x2077600", Offset = "0x2076A00", Length = "0x5")]
	[Token(Token = "0x6000ED3")]
	public virtual MethodBase get_DeclaringMethod() { }

	[Address(RVA = "0x2077610", Offset = "0x2076A10", Length = "0x5")]
	[Token(Token = "0x6000EE0")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x2077620", Offset = "0x2076A20", Length = "0x107")]
	[Token(Token = "0x6000EE4")]
	public virtual string get_FullName() { }

	[Address(RVA = "0x20777D0", Offset = "0x2076BD0", Length = "0xC0")]
	[Token(Token = "0x6000E8E")]
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	[Address(RVA = "0x20778A0", Offset = "0x2076CA0", Length = "0x8C")]
	[Token(Token = "0x6000E9D")]
	public virtual int get_GenericParameterPosition() { }

	[Address(RVA = "0x2077730", Offset = "0x2076B30", Length = "0x98")]
	[Token(Token = "0x6000ECC")]
	public virtual Guid get_GUID() { }

	[Address(RVA = "0x2077930", Offset = "0x2076D30", Length = "0x47")]
	[Token(Token = "0x6000EA0")]
	public virtual bool get_IsConstructedGenericType() { }

	[Address(RVA = "0x2077980", Offset = "0x2076D80", Length = "0x62")]
	[Token(Token = "0x6000E8C")]
	public virtual bool get_IsEnum() { }

	[Address(RVA = "0x20779F0", Offset = "0x2076DF0", Length = "0x7")]
	[Token(Token = "0x6000E9C")]
	public virtual bool get_IsGenericParameter() { }

	[Address(RVA = "0x2077A10", Offset = "0x2076E10", Length = "0x7")]
	[Token(Token = "0x6000E9F")]
	public virtual bool get_IsGenericType() { }

	[Address(RVA = "0x2077A00", Offset = "0x2076E00", Length = "0x7")]
	[Token(Token = "0x6000E9B")]
	public virtual bool get_IsGenericTypeDefinition() { }

	[Address(RVA = "0x2077A80", Offset = "0x2076E80", Length = "0x7")]
	[Token(Token = "0x6000E8F")]
	internal virtual bool get_IsSzArray() { }

	[Address(RVA = "0x2077A20", Offset = "0x2076E20", Length = "0x5D")]
	[Token(Token = "0x6000EE5")]
	public virtual bool get_IsSZArray() { }

	[Address(RVA = "0x2077A90", Offset = "0x2076E90", Length = "0x40")]
	[Token(Token = "0x6000EAB")]
	public virtual MemberTypes get_MemberType() { }

	[Address(RVA = "0x2077AD0", Offset = "0x2076ED0", Length = "0x7")]
	[Token(Token = "0x6000EAD")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x2072E90", Offset = "0x2072290", Length = "0x7")]
	[Token(Token = "0x6000E7A")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x2077AE0", Offset = "0x2076EE0", Length = "0x5")]
	[Token(Token = "0x6000EE1")]
	public virtual string get_Name() { }

	[Address(RVA = "0x2077AF0", Offset = "0x2076EF0", Length = "0x5")]
	[Token(Token = "0x6000EE2")]
	public virtual string get_Namespace() { }

	[Address(RVA = "0x2077B00", Offset = "0x2076F00", Length = "0x14")]
	[Token(Token = "0x6000EAC")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x2077B20", Offset = "0x2076F20", Length = "0x27")]
	[Token(Token = "0x6000E7E")]
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000E84")]
	public virtual Type get_UnderlyingSystemType() { }

	[Address(RVA = "0x206D5F0", Offset = "0x206C9F0", Length = "0x8E")]
	[Token(Token = "0x6000E91")]
	public virtual int GetArrayRank() { }

	[Address(RVA = "0x206D680", Offset = "0x206CA80", Length = "0x7")]
	[Token(Token = "0x6000E85")]
	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	[Address(RVA = "0x206D690", Offset = "0x206CA90", Length = "0x20B")]
	[Token(Token = "0x6000E83")]
	private RuntimeType GetBaseType() { }

	[Address(RVA = "0x206D8A0", Offset = "0x206CCA0", Length = "0x63")]
	[Token(Token = "0x6000EB9")]
	private string GetCachedName(TypeNameKind kind) { }

	[Address(RVA = "0x206D910", Offset = "0x206CD10", Length = "0x3C1")]
	[Token(Token = "0x6000E69")]
	private ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	[Address(RVA = "0x206DCE0", Offset = "0x206D0E0", Length = "0x294")]
	[Token(Token = "0x6000E74")]
	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x206E1B0", Offset = "0x206D5B0", Length = "0x95")]
	[ComVisible(True)]
	[Token(Token = "0x6000E6F")]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	[Address(RVA = "0x206DF80", Offset = "0x206D380", Length = "0x226")]
	[Token(Token = "0x6000EC9")]
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	[Address(RVA = "0x206E250", Offset = "0x206D650", Length = "0x5")]
	[Token(Token = "0x6000EC8")]
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	[Address(RVA = "0x206E260", Offset = "0x206D660", Length = "0x9D")]
	[Token(Token = "0x6000EA7")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x206E300", Offset = "0x206D700", Length = "0x19B")]
	[Token(Token = "0x6000EA8")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x206E4A0", Offset = "0x206D8A0", Length = "0x1AD")]
	[Token(Token = "0x6000EB1")]
	internal RuntimeConstructorInfo GetDefaultConstructor() { }

	[Address(RVA = "0x206E650", Offset = "0x206DA50", Length = "0xE1")]
	[Token(Token = "0x6000EB2")]
	private string GetDefaultMemberName() { }

	[Address(RVA = "0x206E740", Offset = "0x206DB40", Length = "0x7")]
	[Token(Token = "0x6000E92")]
	public virtual Type GetElementType() { }

	[Address(RVA = "0x206E750", Offset = "0x206DB50", Length = "0x22F")]
	[Token(Token = "0x6000E97")]
	public virtual string GetEnumName(object value) { }

	[Address(RVA = "0x206E980", Offset = "0x206DD80", Length = "0x12D")]
	[Token(Token = "0x6000E93")]
	public virtual String[] GetEnumNames() { }

	[Address(RVA = "0x206EAB0", Offset = "0x206DEB0", Length = "0xB0")]
	[Token(Token = "0x6000E95")]
	public virtual Type GetEnumUnderlyingType() { }

	[Address(RVA = "0x206EB60", Offset = "0x206DF60", Length = "0x181")]
	[Token(Token = "0x6000E94")]
	public virtual Array GetEnumValues() { }

	[Address(RVA = "0x206EFA0", Offset = "0x206E3A0", Length = "0x275")]
	[Token(Token = "0x6000E76")]
	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x206ECF0", Offset = "0x206E0F0", Length = "0x2AF")]
	[Token(Token = "0x6000E6B")]
	private ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	[Address(RVA = "0x206F430", Offset = "0x206E830", Length = "0x85")]
	[Token(Token = "0x6000E71")]
	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[Address(RVA = "0x206F220", Offset = "0x206E620", Length = "0x202")]
	[Token(Token = "0x6000EDB")]
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[Address(RVA = "0x206F4C0", Offset = "0x206E8C0", Length = "0x5")]
	[Token(Token = "0x6000ED8")]
	private IntPtr GetEvents_native(IntPtr name, MemberListType listType) { }

	[Address(RVA = "0x206F780", Offset = "0x206EB80", Length = "0x477")]
	[Token(Token = "0x6000E77")]
	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x206F4D0", Offset = "0x206E8D0", Length = "0x2AF")]
	[Token(Token = "0x6000E6C")]
	private ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	[Address(RVA = "0x206FEA0", Offset = "0x206F2A0", Length = "0x85")]
	[Token(Token = "0x6000E72")]
	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[Address(RVA = "0x206FC00", Offset = "0x206F000", Length = "0x291")]
	[Token(Token = "0x6000EDA")]
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[Address(RVA = "0x206FF30", Offset = "0x206F330", Length = "0x5")]
	[Token(Token = "0x6000ED9")]
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	[Address(RVA = "0x20774B0", Offset = "0x20768B0", Length = "0x5")]
	[Token(Token = "0x6000ED4")]
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	[Address(RVA = "0x206FFD0", Offset = "0x206F3D0", Length = "0x4B")]
	[Token(Token = "0x6000E99")]
	public virtual Type[] GetGenericArguments() { }

	[Address(RVA = "0x206FF50", Offset = "0x206F350", Length = "0x68")]
	[Token(Token = "0x6000E98")]
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	[Address(RVA = "0x206FFC0", Offset = "0x206F3C0", Length = "0x5")]
	[Token(Token = "0x6000ED5")]
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	[Address(RVA = "0x2070020", Offset = "0x206F420", Length = "0x48")]
	[Token(Token = "0x6000ED6")]
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	[Address(RVA = "0x2070070", Offset = "0x206F470", Length = "0x101")]
	[Token(Token = "0x6000EC2")]
	public virtual Type[] GetGenericParameterConstraints() { }

	[Address(RVA = "0x2070180", Offset = "0x206F580", Length = "0x5")]
	[Token(Token = "0x6000ED7")]
	private int GetGenericParameterPosition() { }

	[Address(RVA = "0x2070190", Offset = "0x206F590", Length = "0x8E")]
	[Token(Token = "0x6000E9E")]
	public virtual Type GetGenericTypeDefinition() { }

	[Address(RVA = "0x206FF40", Offset = "0x206F340", Length = "0x5")]
	[Token(Token = "0x6000ECB")]
	private static void GetGUID(Type type, Byte[] guid) { }

	[Address(RVA = "0x2070220", Offset = "0x206F620", Length = "0xB0")]
	[Token(Token = "0x6000EE3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x20702E0", Offset = "0x206F6E0", Length = "0x5")]
	[Token(Token = "0x6000EDC")]
	public virtual Type[] GetInterfaces() { }

	[Address(RVA = "0x20702F0", Offset = "0x206F6F0", Length = "0x497")]
	[Token(Token = "0x6000E79")]
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	[Address(RVA = "0x2070790", Offset = "0x206FB90", Length = "0x310")]
	[Token(Token = "0x6000E73")]
	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[Address(RVA = "0x2070AA0", Offset = "0x206FEA0", Length = "0x2F9")]
	[Token(Token = "0x6000EE9")]
	private ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	[Address(RVA = "0x2070DA0", Offset = "0x20701A0", Length = "0x339")]
	[Token(Token = "0x6000E68")]
	private ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, int genericParamCount, bool allowPrefixLookup) { }

	[Address(RVA = "0x2071570", Offset = "0x2070970", Length = "0x4A")]
	[Token(Token = "0x6000EE7")]
	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x20710E0", Offset = "0x20704E0", Length = "0x481")]
	[Token(Token = "0x6000EE8")]
	private MethodInfo GetMethodImplCommon(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x2071870", Offset = "0x2070C70", Length = "0xA3")]
	[Token(Token = "0x6000E6E")]
	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[Address(RVA = "0x20715C0", Offset = "0x20709C0", Length = "0x291")]
	[Token(Token = "0x6000EC6")]
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[Address(RVA = "0x2071860", Offset = "0x2070C60", Length = "0x5")]
	[Token(Token = "0x6000EC5")]
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, MemberListType listType) { }

	[Address(RVA = "0x2071D40", Offset = "0x2071140", Length = "0x463")]
	[Token(Token = "0x6000E78")]
	public virtual Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	[Address(RVA = "0x2071920", Offset = "0x2070D20", Length = "0x410")]
	[Token(Token = "0x6000E6D")]
	private ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	[Address(RVA = "0x20721B0", Offset = "0x20715B0", Length = "0x336")]
	[Token(Token = "0x6000EDE")]
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, MemberListType listType) { }

	[Address(RVA = "0x20724F0", Offset = "0x20718F0", Length = "0x5")]
	[Token(Token = "0x6000EDD")]
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	[Address(RVA = "0x2072500", Offset = "0x2071900", Length = "0x70")]
	[Token(Token = "0x6000EA6")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2072820", Offset = "0x2071C20", Length = "0x8D")]
	[Token(Token = "0x6000E70")]
	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[Address(RVA = "0x2072570", Offset = "0x2071970", Length = "0x291")]
	[Token(Token = "0x6000ECA")]
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[Address(RVA = "0x2072810", Offset = "0x2071C10", Length = "0x5")]
	[Token(Token = "0x6000EC7")]
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	[Address(RVA = "0x20728B0", Offset = "0x2071CB0", Length = "0x2ED")]
	[Token(Token = "0x6000E6A")]
	private ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	[Address(RVA = "0x2072BA0", Offset = "0x2071FA0", Length = "0x2D1")]
	[Token(Token = "0x6000E75")]
	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x2072E80", Offset = "0x2072280", Length = "0x7")]
	[Token(Token = "0x6000E7D")]
	internal RuntimeAssembly GetRuntimeAssembly() { }

	[Address(RVA = "0x2072E90", Offset = "0x2072290", Length = "0x7")]
	[Token(Token = "0x6000E7B")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x2072EA0", Offset = "0x20722A0", Length = "0x247")]
	[Token(Token = "0x6000EB3")]
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	[Address(RVA = "0x20731A0", Offset = "0x20725A0", Length = "0x7D")]
	[Token(Token = "0x6000E5A")]
	internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x2073100", Offset = "0x2072500", Length = "0x47")]
	[Token(Token = "0x6000ECE")]
	protected virtual TypeCode GetTypeCodeImpl() { }

	[Address(RVA = "0x20730F0", Offset = "0x20724F0", Length = "0x5")]
	[Token(Token = "0x6000ECF")]
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	[Address(RVA = "0x2073150", Offset = "0x2072550", Length = "0x4E")]
	[Token(Token = "0x6000ECD")]
	internal static Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError) { }

	[Address(RVA = "0x2073220", Offset = "0x2072620", Length = "0x7")]
	[Token(Token = "0x6000E8D")]
	protected virtual bool HasElementTypeImpl() { }

	[Address(RVA = "0x2073230", Offset = "0x2072630", Length = "0x1684")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000EA1")]
	public virtual object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, Object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParams) { }

	[Address(RVA = "0x20748C0", Offset = "0x2073CC0", Length = "0x7")]
	[Token(Token = "0x6000E90")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x20748D0", Offset = "0x2073CD0", Length = "0xDE")]
	[Token(Token = "0x6000E80")]
	public virtual bool IsAssignableFrom(Type c) { }

	[Address(RVA = "0x20749B0", Offset = "0x2073DB0", Length = "0x7")]
	[Token(Token = "0x6000E87")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x20749C0", Offset = "0x2073DC0", Length = "0xA")]
	[Token(Token = "0x6000E8A")]
	protected virtual bool IsCOMObjectImpl() { }

	[Address(RVA = "0x20749D0", Offset = "0x2073DD0", Length = "0x7")]
	[Token(Token = "0x6000E86")]
	protected virtual bool IsContextfulImpl() { }

	[Address(RVA = "0x20749E0", Offset = "0x2073DE0", Length = "0x598")]
	[Token(Token = "0x6000EB8")]
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	[Address(RVA = "0x2075610", Offset = "0x2074A10", Length = "0x19B")]
	[Token(Token = "0x6000EA9")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x20757B0", Offset = "0x2074BB0", Length = "0x5FE")]
	[Token(Token = "0x6000E96")]
	public virtual bool IsEnumDefined(object value) { }

	[Address(RVA = "0x2075DB0", Offset = "0x20751B0", Length = "0xA1")]
	[Token(Token = "0x6000E81")]
	public virtual bool IsEquivalentTo(Type other) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000ED1")]
	private bool IsGenericCOMObjectImpl() { }

	[Address(RVA = "0x2075E60", Offset = "0x2075260", Length = "0x8")]
	[Token(Token = "0x6000E7F")]
	public virtual bool IsInstanceOfType(object o) { }

	[Address(RVA = "0x2075E70", Offset = "0x2075270", Length = "0x7")]
	[Token(Token = "0x6000E89")]
	protected virtual bool IsPointerImpl() { }

	[Address(RVA = "0x2075E80", Offset = "0x2075280", Length = "0x7")]
	[Token(Token = "0x6000E88")]
	protected virtual bool IsPrimitiveImpl() { }

	[Address(RVA = "0x2075E90", Offset = "0x2075290", Length = "0xFD")]
	[ComVisible(True)]
	[Token(Token = "0x6000EE6")]
	public virtual bool IsSubclassOf(Type type) { }

	[Address(RVA = "0x2075F90", Offset = "0x2075390", Length = "0xDB")]
	[Token(Token = "0x6000E8B")]
	protected virtual bool IsValueTypeImpl() { }

	[Address(RVA = "0x2077B50", Offset = "0x2076F50", Length = "0x5")]
	[Token(Token = "0x6000EBA")]
	private Type make_array_type(int rank) { }

	[Address(RVA = "0x2077B60", Offset = "0x2076F60", Length = "0x5")]
	[Token(Token = "0x6000EBD")]
	private Type make_byref_type() { }

	[Address(RVA = "0x2076070", Offset = "0x2075470", Length = "0x7")]
	[Token(Token = "0x6000EBB")]
	public virtual Type MakeArrayType() { }

	[Address(RVA = "0x2076080", Offset = "0x2075480", Length = "0x59")]
	[Token(Token = "0x6000EBC")]
	public virtual Type MakeArrayType(int rank) { }

	[Address(RVA = "0x20760E0", Offset = "0x20754E0", Length = "0x69")]
	[Token(Token = "0x6000EBE")]
	public virtual Type MakeByRefType() { }

	[Address(RVA = "0x2076740", Offset = "0x2075B40", Length = "0x5")]
	[Token(Token = "0x6000EC4")]
	private static Type MakeGenericType(Type gt, Type[] types) { }

	[Address(RVA = "0x2076150", Offset = "0x2075550", Length = "0x5EA")]
	[Token(Token = "0x6000E9A")]
	public virtual Type MakeGenericType(Type[] instantiation) { }

	[Address(RVA = "0x2076750", Offset = "0x2075B50", Length = "0x5")]
	[Token(Token = "0x6000EBF")]
	private static Type MakePointerType(Type type) { }

	[Address(RVA = "0x2076760", Offset = "0x2075B60", Length = "0xD8")]
	[Token(Token = "0x6000EC0")]
	public virtual Type MakePointerType() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000EA3")]
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x6000EA4")]
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	[Address(RVA = "0x2076840", Offset = "0x2075C40", Length = "0x254")]
	[Token(Token = "0x6000E5C")]
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	[Address(RVA = "0x2076AA0", Offset = "0x2075EA0", Length = "0x10A")]
	[Token(Token = "0x6000E5D")]
	private static void SplitName(string fullname, out string name, out string ns) { }

	[Address(RVA = "0x2076BB0", Offset = "0x2075FB0", Length = "0x130")]
	[Token(Token = "0x6000E5B")]
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	[Address(RVA = "0x2076CF0", Offset = "0x20760F0", Length = "0xA")]
	[Token(Token = "0x6000ED0")]
	public virtual string ToString() { }

	[Address(RVA = "0x2076D00", Offset = "0x2076100", Length = "0x268")]
	[Token(Token = "0x6000EB7")]
	private object TryConvertToType(object value, ref bool failed) { }

}

