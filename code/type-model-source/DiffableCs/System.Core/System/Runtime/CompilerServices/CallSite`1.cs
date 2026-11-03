namespace System.Runtime.CompilerServices;

[Token(Token = "0x200024B")]
public class CallSite : CallSite
{
	[CompilerGenerated]
	[Token(Token = "0x200024C")]
	private sealed class <>c
	{
		[Token(Token = "0x400041E")]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Token(Token = "0x400041F")]
		public static Converter<ParameterInfo, ParameterExpression> <>9__20_0; //Field offset: 0x0
		[Token(Token = "0x4000420")]
		public static Converter<ParameterExpression, Expression> <>9__20_1; //Field offset: 0x0
		[Token(Token = "0x4000421")]
		public static Converter<ParameterInfo, ParameterExpression> <>9__21_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000B34")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B35")]
		public <>c() { }

		[Address(RVA = "0xA34AC0", Offset = "0xA33EC0", Length = "0x94")]
		[Token(Token = "0x6000B38")]
		internal ParameterExpression <CreateCustomNoMatchDelegate>b__21_0(ParameterInfo p) { }

		[Address(RVA = "0xA34B60", Offset = "0xA33F60", Length = "0x94")]
		[Token(Token = "0x6000B36")]
		internal ParameterExpression <CreateCustomUpdateDelegate>b__20_0(ParameterInfo p) { }

		[Address(RVA = "0xA34C00", Offset = "0xA34000", Length = "0x65")]
		[Token(Token = "0x6000B37")]
		internal Expression <CreateCustomUpdateDelegate>b__20_1(ParameterExpression p) { }

	}

	[Token(Token = "0x400041C")]
	private static T s_cachedUpdate; //Field offset: 0x0
	[Token(Token = "0x400041D")]
	private static T s_cachedNoMatch; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400041A")]
	public T Target; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400041B")]
	internal T[] Rules; //Field offset: 0x0

	[Token(Token = "0x1700024A")]
	public T Update
	{
		[Address(RVA = "0x16C38B0", Offset = "0x16C2CB0", Length = "0x6C")]
		[Token(Token = "0x6000B27")]
		 get { } //Length: 108
	}

	[Address(RVA = "0x16C3850", Offset = "0x16C2C50", Length = "0x49")]
	[Token(Token = "0x6000B28")]
	private CallSite`1(CallSiteBinder binder) { }

	[Address(RVA = "0x16C38A0", Offset = "0x16C2CA0", Length = "0xA")]
	[Token(Token = "0x6000B29")]
	private CallSite`1() { }

	[Address(RVA = "0x16C1800", Offset = "0x16C0C00", Length = "0x129")]
	[Token(Token = "0x6000B2E")]
	internal void AddRule(T newRule) { }

	[Address(RVA = "0x16C1930", Offset = "0x16C0D30", Length = "0xCB")]
	[Token(Token = "0x6000B33")]
	private static Expression Convert(Expression arg, Type type) { }

	[Address(RVA = "0x16C31A0", Offset = "0x16C25A0", Length = "0x18F")]
	[Token(Token = "0x6000B2B")]
	public static CallSite<T> Create(CallSiteBinder binder) { }

	[Address(RVA = "0x16C1A00", Offset = "0x16C0E00", Length = "0x363")]
	[Token(Token = "0x6000B32")]
	private T CreateCustomNoMatchDelegate(MethodInfo invoke) { }

	[Address(RVA = "0x16C1D70", Offset = "0x16C1170", Length = "0x13D0")]
	[Token(Token = "0x6000B31")]
	private T CreateCustomUpdateDelegate(MethodInfo invoke) { }

	[Address(RVA = "0x16C3150", Offset = "0x16C2550", Length = "0x46")]
	[Token(Token = "0x6000B2A")]
	internal CallSite<T> CreateMatchMaker() { }

	[Address(RVA = "0x16C38B0", Offset = "0x16C2CB0", Length = "0x6C")]
	[Token(Token = "0x6000B27")]
	public T get_Update() { }

	[Address(RVA = "0x16C3330", Offset = "0x16C2730", Length = "0x194")]
	[Token(Token = "0x6000B2C")]
	private T GetUpdateDelegate() { }

	[Address(RVA = "0x16C34D0", Offset = "0x16C28D0", Length = "0x17A")]
	[Token(Token = "0x6000B2D")]
	private T GetUpdateDelegate(ref T addr) { }

	[Address(RVA = "0x16C3650", Offset = "0x16C2A50", Length = "0x137")]
	[Token(Token = "0x6000B30")]
	internal T MakeUpdateDelegate() { }

	[Address(RVA = "0x16C3790", Offset = "0x16C2B90", Length = "0xB9")]
	[Token(Token = "0x6000B2F")]
	internal void MoveRule(int i) { }

}

