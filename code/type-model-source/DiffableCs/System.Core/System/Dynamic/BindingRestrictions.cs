namespace System.Dynamic;

[DebuggerDisplay("{DebugView}")]
[DebuggerTypeProxy(typeof(BindingRestrictionsProxy))]
[Token(Token = "0x2000258")]
public abstract class BindingRestrictions
{
	[Token(Token = "0x200025F")]
	private sealed class BindingRestrictionsProxy
	{

	}

	[Token(Token = "0x200025C")]
	private sealed class CustomRestriction : BindingRestrictions
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000439")]
		private readonly Expression _expression; //Field offset: 0x10

		[Address(RVA = "0x2294230", Offset = "0x2293630", Length = "0x65")]
		[Token(Token = "0x6000B95")]
		internal CustomRestriction(Expression expression) { }

		[Address(RVA = "0x22941A0", Offset = "0x22935A0", Length = "0x60")]
		[Token(Token = "0x6000B96")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000B98")]
		internal virtual Expression GetExpression() { }

		[Address(RVA = "0x2294200", Offset = "0x2293600", Length = "0x2F")]
		[Token(Token = "0x6000B97")]
		public virtual int GetHashCode() { }

	}

	[Token(Token = "0x200025E")]
	private sealed class InstanceRestriction : BindingRestrictions
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400043C")]
		private readonly Expression _expression; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400043D")]
		private readonly object _instance; //Field offset: 0x18

		[Address(RVA = "0x229ADD0", Offset = "0x229A1D0", Length = "0x82")]
		[Token(Token = "0x6000B9D")]
		internal InstanceRestriction(Expression parameter, object instance) { }

		[Address(RVA = "0x229A930", Offset = "0x2299D30", Length = "0x81")]
		[Token(Token = "0x6000B9E")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x229A9C0", Offset = "0x2299DC0", Length = "0x3B6")]
		[Token(Token = "0x6000BA0")]
		internal virtual Expression GetExpression() { }

		[Address(RVA = "0x229AD80", Offset = "0x229A180", Length = "0x4E")]
		[Token(Token = "0x6000B9F")]
		public virtual int GetHashCode() { }

	}

	[Token(Token = "0x200025B")]
	private sealed class MergedRestriction : BindingRestrictions
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000437")]
		internal readonly BindingRestrictions Left; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000438")]
		internal readonly BindingRestrictions Right; //Field offset: 0x18

		[Address(RVA = "0x229E8D0", Offset = "0x229DCD0", Length = "0x82")]
		[Token(Token = "0x6000B93")]
		internal MergedRestriction(BindingRestrictions left, BindingRestrictions right) { }

		[Address(RVA = "0x229E630", Offset = "0x229DA30", Length = "0x290")]
		[Token(Token = "0x6000B94")]
		internal virtual Expression GetExpression() { }

	}

	[Token(Token = "0x2000259")]
	private sealed class TestBuilder
	{
		[Token(Token = "0x200025A")]
		private struct AndNode
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000435")]
			internal int Depth; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000436")]
			internal Expression Node; //Field offset: 0x8

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000433")]
		private readonly HashSet<BindingRestrictions> _unique; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000434")]
		private readonly Stack<AndNode> _tests; //Field offset: 0x18

		[Address(RVA = "0x22ABA20", Offset = "0x22AAE20", Length = "0xBD")]
		[Token(Token = "0x6000B92")]
		public TestBuilder() { }

		[Address(RVA = "0x22AB620", Offset = "0x22AAA20", Length = "0x1BF")]
		[Token(Token = "0x6000B8F")]
		internal void Append(BindingRestrictions restrictions) { }

		[Address(RVA = "0x22AB7E0", Offset = "0x22AABE0", Length = "0x159")]
		[Token(Token = "0x6000B91")]
		private void Push(Expression node, int depth) { }

		[Address(RVA = "0x22AB940", Offset = "0x22AAD40", Length = "0xD6")]
		[Token(Token = "0x6000B90")]
		internal Expression ToExpression() { }

	}

	[Token(Token = "0x200025D")]
	private sealed class TypeRestriction : BindingRestrictions
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400043A")]
		private readonly Expression _expression; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400043B")]
		private readonly Type _type; //Field offset: 0x18

		[Address(RVA = "0x22AC410", Offset = "0x22AB810", Length = "0x82")]
		[Token(Token = "0x6000B99")]
		internal TypeRestriction(Expression parameter, Type type) { }

		[Address(RVA = "0x22AC2A0", Offset = "0x22AB6A0", Length = "0xAA")]
		[Token(Token = "0x6000B9A")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x22AC350", Offset = "0x22AB750", Length = "0x5E")]
		[Token(Token = "0x6000B9C")]
		internal virtual Expression GetExpression() { }

		[Address(RVA = "0x22AC3B0", Offset = "0x22AB7B0", Length = "0x5F")]
		[Token(Token = "0x6000B9B")]
		public virtual int GetHashCode() { }

	}

	[Token(Token = "0x4000432")]
	public static readonly BindingRestrictions Empty; //Field offset: 0x0

	[Address(RVA = "0x2291910", Offset = "0x2290D10", Length = "0xEA")]
	[Token(Token = "0x6000B8E")]
	private static BindingRestrictions() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B87")]
	private BindingRestrictions() { }

	[Token(Token = "0x6000B88")]
	internal abstract Expression GetExpression() { }

	[Address(RVA = "0x22912C0", Offset = "0x22906C0", Length = "0xCC")]
	[Token(Token = "0x6000B8C")]
	public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance) { }

	[Address(RVA = "0x22916B0", Offset = "0x2290AB0", Length = "0xEA")]
	[Token(Token = "0x6000B8A")]
	public static BindingRestrictions GetTypeRestriction(Expression expression, Type type) { }

	[Address(RVA = "0x2291390", Offset = "0x2290790", Length = "0x311")]
	[Token(Token = "0x6000B8B")]
	internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj) { }

	[Address(RVA = "0x22917A0", Offset = "0x2290BA0", Length = "0x145")]
	[Token(Token = "0x6000B89")]
	public BindingRestrictions Merge(BindingRestrictions restrictions) { }

	[Address(RVA = "0x22918F0", Offset = "0x2290CF0", Length = "0x14")]
	[Token(Token = "0x6000B8D")]
	public Expression ToExpression() { }

}

