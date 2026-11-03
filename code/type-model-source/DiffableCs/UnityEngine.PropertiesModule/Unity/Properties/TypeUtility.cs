namespace Unity.Properties;

[Extension]
[Token(Token = "0x2000066")]
public static class TypeUtility
{
	[CompilerGenerated]
	[Token(Token = "0x200006D")]
	private sealed class <>c
	{
		[Token(Token = "0x400015C")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x3164700", Offset = "0x3163B00", Length = "0x67")]
		[Token(Token = "0x6000260")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000261")]
		public <>c() { }

		[Address(RVA = "0x31645B0", Offset = "0x31639B0", Length = "0x44")]
		[Token(Token = "0x6000262")]
		internal StringBuilder <.cctor>b__11_0() { }

		[Address(RVA = "0x3164600", Offset = "0x3163A00", Length = "0x1F")]
		[Token(Token = "0x6000263")]
		internal void <.cctor>b__11_1(StringBuilder sb) { }

		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x6000264")]
		internal string <.cctor>b__11_2() { }

	}

	[Token(Token = "0x200006B")]
	private struct Cache
	{
		[Token(Token = "0x400015A")]
		public static ITypeConstructor<T> TypeConstructor; //Field offset: 0x0

	}

	[Token(Token = "0x2000067")]
	private interface ITypeConstructor
	{

		[Token(Token = "0x1700004D")]
		public bool CanBeInstantiated
		{
			[Token(Token = "0x600024E")]
			 get { } //Length: 0
		}

		[Token(Token = "0x600024E")]
		public bool get_CanBeInstantiated() { }

		[Token(Token = "0x600024F")]
		public object Instantiate() { }

	}

	[Token(Token = "0x2000068")]
	private interface ITypeConstructor : ITypeConstructor
	{

		[Token(Token = "0x6000250")]
		public T Instantiate() { }

		[Token(Token = "0x6000251")]
		public void SetExplicitConstructor(Func<T> constructor) { }

	}

	[Token(Token = "0x200006A")]
	private class NonConstructable : ITypeConstructor
	{

		[Token(Token = "0x1700004F")]
		private override bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600025B")]
			private get { } //Length: 3
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600025D")]
		public NonConstructable() { }

		[Address(RVA = "0x3142A40", Offset = "0x3141E40", Length = "0x4E")]
		[Token(Token = "0x600025C")]
		public override object Instantiate() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600025B")]
		private override bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	}

	[Token(Token = "0x2000069")]
	private class TypeConstructor : ITypeConstructor<T>, ITypeConstructor
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000157")]
		private Func<T> m_ExplicitConstructor; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000158")]
		private Func<T> m_ImplicitConstructor; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000159")]
		private IConstructor<T> m_OverrideConstructor; //Field offset: 0x0

		[Token(Token = "0x1700004E")]
		private override bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated
		{
			[Address(RVA = "0x10CD2C0", Offset = "0x10CC6C0", Length = "0x89")]
			[Token(Token = "0x6000252")]
			private get { } //Length: 137
		}

		[Address(RVA = "0x10CDF20", Offset = "0x10CD320", Length = "0xF3")]
		[Token(Token = "0x6000253")]
		public TypeConstructor`1() { }

		[Address(RVA = "0x10C7640", Offset = "0x10C6A40", Length = "0x2D")]
		[Token(Token = "0x6000257")]
		private static T CreateClassInstance() { }

		[Address(RVA = "0x10C7A50", Offset = "0x10C6E50", Length = "0xC0")]
		[Token(Token = "0x6000256")]
		private static T CreateScriptableObjectInstance() { }

		[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
		[Token(Token = "0x6000255")]
		private static T CreateValueTypeInstance() { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000258")]
		public override void SetExplicitConstructor(Func<T> constructor) { }

		[Address(RVA = "0x10C91A0", Offset = "0x10C85A0", Length = "0x227")]
		[Token(Token = "0x6000254")]
		private void SetImplicitConstructor() { }

		[Address(RVA = "0x10CD2C0", Offset = "0x10CC6C0", Length = "0x89")]
		[Token(Token = "0x6000252")]
		private override bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

		[Address(RVA = "0x10CCAC0", Offset = "0x10CBEC0", Length = "0x70")]
		[Token(Token = "0x600025A")]
		private override object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }

		[Address(RVA = "0x10CA0F0", Offset = "0x10C94F0", Length = "0x256")]
		[Token(Token = "0x6000259")]
		private override T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }

	}

	[Token(Token = "0x200006C")]
	private class TypeConstructorVisitor : ITypeVisitor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400015B")]
		public ITypeConstructor TypeConstructor; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600025F")]
		public TypeConstructorVisitor() { }

		[Address(RVA = "0x9FAA10", Offset = "0x9F9E10", Length = "0x6D")]
		[Token(Token = "0x600025E")]
		public override void Visit() { }

	}

	[Token(Token = "0x4000152")]
	private static readonly ConcurrentDictionary<Type, ITypeConstructor> s_TypeConstructors; //Field offset: 0x0
	[Token(Token = "0x4000153")]
	private static readonly MethodInfo s_CreateTypeConstructor; //Field offset: 0x8
	[Token(Token = "0x4000154")]
	private static readonly ConcurrentDictionary<Type, String> s_CachedResolvedName; //Field offset: 0x10
	[Token(Token = "0x4000155")]
	private static readonly ObjectPool<StringBuilder> s_Builders; //Field offset: 0x18
	[Token(Token = "0x4000156")]
	private static readonly object syncedPoolObject; //Field offset: 0x20

	[Address(RVA = "0x31621E0", Offset = "0x31615E0", Length = "0x483")]
	[Token(Token = "0x6000239")]
	private static TypeUtility() { }

	[Address(RVA = "0x9A22E0", Offset = "0x9A16E0", Length = "0x7B")]
	[Token(Token = "0x6000242")]
	public static bool CanBeInstantiated() { }

	[Address(RVA = "0x3160F60", Offset = "0x3160360", Length = "0x107")]
	[Token(Token = "0x6000241")]
	public static bool CanBeInstantiated(Type type) { }

	[Address(RVA = "0x9A2360", Offset = "0x9A1760", Length = "0x10B")]
	[Token(Token = "0x600024C")]
	private static void CheckCanBeInstantiated(ITypeConstructor<T> constructor) { }

	[Address(RVA = "0x3161070", Offset = "0x3160470", Length = "0xDE")]
	[Token(Token = "0x600024D")]
	private static void CheckCanBeInstantiated(ITypeConstructor constructor, Type type) { }

	[Address(RVA = "0x3161150", Offset = "0x3160550", Length = "0x178")]
	[Token(Token = "0x600024B")]
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	[Address(RVA = "0x9A4690", Offset = "0x9A3A90", Length = "0x140")]
	[Token(Token = "0x600023E")]
	private static ITypeConstructor<T> CreateTypeConstructor() { }

	[Address(RVA = "0x31612D0", Offset = "0x31606D0", Length = "0x2D1")]
	[Preserve]
	[Token(Token = "0x600023D")]
	private static ITypeConstructor CreateTypeConstructor(Type type) { }

	[Address(RVA = "0x31615B0", Offset = "0x31609B0", Length = "0xEA")]
	[Extension]
	[Token(Token = "0x600023C")]
	public static Type GetRootType(Type type) { }

	[Address(RVA = "0x31616A0", Offset = "0x3160AA0", Length = "0xB5")]
	[Token(Token = "0x600023F")]
	private static ITypeConstructor GetTypeConstructor(Type type) { }

	[Address(RVA = "0x9A6D50", Offset = "0x9A6150", Length = "0x1DC")]
	[Token(Token = "0x6000240")]
	private static ITypeConstructor<T> GetTypeConstructor() { }

	[Address(RVA = "0x3161890", Offset = "0x3160C90", Length = "0x943")]
	[Token(Token = "0x600023B")]
	private static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex) { }

	[Address(RVA = "0x3161760", Offset = "0x3160B60", Length = "0x123")]
	[Token(Token = "0x600023A")]
	public static string GetTypeDisplayName(Type type) { }

	[Address(RVA = "0x9A7770", Offset = "0x9A6B70", Length = "0x154")]
	[Token(Token = "0x6000244")]
	public static T Instantiate() { }

	[Address(RVA = "0x9A78D0", Offset = "0x9A6CD0", Length = "0x1AA")]
	[Token(Token = "0x6000246")]
	public static T Instantiate(Type derivedType) { }

	[Address(RVA = "0x9A7350", Offset = "0x9A6750", Length = "0x417")]
	[Token(Token = "0x6000248")]
	public static TArray InstantiateArray(int count = 0) { }

	[Address(RVA = "0x9A6F30", Offset = "0x9A6330", Length = "0x413")]
	[Token(Token = "0x600024A")]
	public static TArray InstantiateArray(Type derivedType, int count = 0) { }

	[Address(RVA = "0x9A7B90", Offset = "0x9A6F90", Length = "0x105")]
	[Token(Token = "0x6000243")]
	public static void SetExplicitInstantiationMethod(Func<T> constructor) { }

	[Address(RVA = "0x9A8120", Offset = "0x9A7520", Length = "0x151")]
	[Token(Token = "0x6000245")]
	public static bool TryInstantiate(out T instance) { }

	[Address(RVA = "0x9A7F40", Offset = "0x9A7340", Length = "0x1D1")]
	[Token(Token = "0x6000247")]
	public static bool TryInstantiate(Type derivedType, out T value) { }

	[Address(RVA = "0x9A7CA0", Offset = "0x9A70A0", Length = "0x299")]
	[Token(Token = "0x6000249")]
	public static bool TryInstantiateArray(int count, out TArray instance) { }

}

