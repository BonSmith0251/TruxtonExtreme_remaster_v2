namespace System.Data;

[Token(Token = "0x200001F")]
internal sealed class TypeLimiter
{
	[CompilerGenerated]
	[Token(Token = "0x2000022")]
	private sealed class <>c
	{
		[Token(Token = "0x40000D8")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000D9")]
		public static Func<DataColumn, Type> <>9__10_0; //Field offset: 0x8
		[Token(Token = "0x40000DA")]
		public static Func<DataTable, IEnumerable`1<Type>> <>9__11_0; //Field offset: 0x10

		[Address(RVA = "0x232A9A0", Offset = "0x2329DA0", Length = "0x67")]
		[Token(Token = "0x600030C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600030D")]
		public <>c() { }

		[Address(RVA = "0x232A970", Offset = "0x2329D70", Length = "0x17")]
		[Token(Token = "0x600030E")]
		internal Type <GetPreviouslyDeclaredDataTypes>b__10_0(DataColumn column) { }

		[Address(RVA = "0x232A990", Offset = "0x2329D90", Length = "0xA")]
		[Token(Token = "0x600030F")]
		internal IEnumerable<Type> <GetPreviouslyDeclaredDataTypes>b__11_0(DataTable table) { }

	}

	[Token(Token = "0x2000020")]
	private sealed class Scope : IDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000021")]
		private sealed class <>c
		{
			[Token(Token = "0x40000D6")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x40000D7")]
			public static Func<Type, Boolean> <>9__3_0; //Field offset: 0x8

			[Address(RVA = "0x232AA10", Offset = "0x2329E10", Length = "0xBE")]
			[Token(Token = "0x6000309")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600030A")]
			public <>c() { }

			[Address(RVA = "0x20796C0", Offset = "0x2078AC0", Length = "0x30")]
			[Token(Token = "0x600030B")]
			internal bool <.ctor>b__3_0(Type type) { }

		}

		[Token(Token = "0x40000D3")]
		private static readonly HashSet<Type> s_allowedTypes; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000D4")]
		private HashSet<Type> m_allowedTypes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Nullable(2)]
		[Token(Token = "0x40000D5")]
		private readonly Scope m_previousScope; //Field offset: 0x18

		[Address(RVA = "0x2329710", Offset = "0x2328B10", Length = "0x7D8")]
		[Token(Token = "0x6000308")]
		private static Scope() { }

		[Address(RVA = "0x2329EF0", Offset = "0x23292F0", Length = "0x183")]
		[Token(Token = "0x6000304")]
		internal Scope(Scope previousScope, IEnumerable<Type> allowedTypes) { }

		[Address(RVA = "0x23292D0", Offset = "0x23286D0", Length = "0xD0")]
		[Token(Token = "0x6000305")]
		public override void Dispose() { }

		[Address(RVA = "0x23293A0", Offset = "0x23287A0", Length = "0x184")]
		[Token(Token = "0x6000306")]
		public bool IsAllowedType(Type type) { }

		[Address(RVA = "0x2329530", Offset = "0x2328930", Length = "0x1DC")]
		[Token(Token = "0x6000307")]
		private static bool IsTypeUnconditionallyAllowed(Type type) { }

	}

	[Nullable(2)]
	[ThreadStatic]
	[Token(Token = "0x40000D1")]
	private static Scope s_activeScope; //Field offset: 0x80000000
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D2")]
	private Scope m_instanceScope; //Field offset: 0x10

	[Token(Token = "0x17000070")]
	private static bool IsTypeLimitingDisabled
	{
		[Address(RVA = "0x232A900", Offset = "0x2329D00", Length = "0x62")]
		[Token(Token = "0x60002FD")]
		private get { } //Length: 98
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60002FC")]
	private TypeLimiter(Scope scope) { }

	[Address(RVA = "0x232A080", Offset = "0x2329480", Length = "0x7A")]
	[NullableContext(2)]
	[Token(Token = "0x60002FE")]
	public static TypeLimiter Capture() { }

	[Address(RVA = "0x232A100", Offset = "0x2329500", Length = "0x1EB")]
	[NullableContext(2)]
	[Token(Token = "0x60002FF")]
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter = null) { }

	[Address(RVA = "0x232A2F0", Offset = "0x23296F0", Length = "0x23C")]
	[Token(Token = "0x6000300")]
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	[Address(RVA = "0x232A530", Offset = "0x2329930", Length = "0x108")]
	[Token(Token = "0x6000301")]
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	[Address(RVA = "0x232A900", Offset = "0x2329D00", Length = "0x62")]
	[Token(Token = "0x60002FD")]
	private static bool get_IsTypeLimitingDisabled() { }

	[Address(RVA = "0x232A7A0", Offset = "0x2329BA0", Length = "0x159")]
	[Token(Token = "0x6000302")]
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	[Address(RVA = "0x232A640", Offset = "0x2329A40", Length = "0x159")]
	[Token(Token = "0x6000303")]
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet) { }

}

