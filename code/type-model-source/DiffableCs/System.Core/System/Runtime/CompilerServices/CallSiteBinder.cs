namespace System.Runtime.CompilerServices;

[Token(Token = "0x200024D")]
public abstract class CallSiteBinder
{
	[Token(Token = "0x200024E")]
	private sealed class LambdaSignature
	{
		[Token(Token = "0x4000424")]
		private static LambdaSignature<T> s_instance; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000425")]
		internal readonly ReadOnlyCollection<ParameterExpression> Parameters; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000426")]
		internal readonly LabelTarget ReturnLabel; //Field offset: 0x0

		[Token(Token = "0x1700024C")]
		internal static LambdaSignature<T> Instance
		{
			[Address(RVA = "0xAF6CB0", Offset = "0xAF60B0", Length = "0x187")]
			[Token(Token = "0x6000B42")]
			internal get { } //Length: 391
		}

		[Address(RVA = "0xAF6900", Offset = "0xAF5D00", Length = "0x3A3")]
		[Token(Token = "0x6000B43")]
		private LambdaSignature`1() { }

		[Address(RVA = "0xAF6CB0", Offset = "0xAF60B0", Length = "0x187")]
		[Token(Token = "0x6000B42")]
		internal static LambdaSignature<T> get_Instance() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x4000423")]
	private static readonly LabelTarget <UpdateLabel>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000422")]
	internal Dictionary<Type, Object> Cache; //Field offset: 0x10

	[Token(Token = "0x1700024B")]
	public static LabelTarget UpdateLabel
	{
		[Address(RVA = "0x2291CC0", Offset = "0x22910C0", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x6000B3A")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x2291C30", Offset = "0x2291030", Length = "0x86")]
	[Token(Token = "0x6000B41")]
	private static CallSiteBinder() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B39")]
	protected CallSiteBinder() { }

	[Token(Token = "0x6000B3B")]
	public abstract Expression Bind(Object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) { }

	[Address(RVA = "0x79B490", Offset = "0x79A890", Length = "0x177")]
	[Token(Token = "0x6000B3D")]
	internal T BindCore(CallSite<T> site, Object[] args) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000B3C")]
	public override T BindDelegate(CallSite<T> site, Object[] args) { }

	[Address(RVA = "0x79B620", Offset = "0x79AA20", Length = "0x62")]
	[Token(Token = "0x6000B3E")]
	protected void CacheTarget(T target) { }

	[Address(RVA = "0x2291CC0", Offset = "0x22910C0", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x6000B3A")]
	public static LabelTarget get_UpdateLabel() { }

	[Address(RVA = "0x79B690", Offset = "0x79AA90", Length = "0x263")]
	[Token(Token = "0x6000B40")]
	internal RuleCache<T> GetRuleCache() { }

	[Address(RVA = "0x79B900", Offset = "0x79AD00", Length = "0x3B9")]
	[Token(Token = "0x6000B3F")]
	private static Expression<T> Stitch(Expression binding, LambdaSignature<T> signature) { }

}

