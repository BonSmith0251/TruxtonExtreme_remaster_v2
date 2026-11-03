namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
[Token(Token = "0x2000090")]
public abstract class LambdaExpression : Expression, IParameterProvider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000181")]
	private readonly Expression _body; //Field offset: 0x10

	[Token(Token = "0x170000A4")]
	public Expression Body
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600041A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000A2")]
	public string Name
	{
		[Address(RVA = "0xE37F60", Offset = "0xE37360", Length = "0x14")]
		[Token(Token = "0x6000418")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000A3")]
	internal override string NameCore
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000419")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170000A1")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x1E82360", Offset = "0x1E81760", Length = "0x6")]
		[Token(Token = "0x6000417")]
		 get { } //Length: 6
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x170000A9")]
	internal override int ParameterCount
	{
		[Address(RVA = "0x2265F50", Offset = "0x2265350", Length = "0x27")]
		[Token(Token = "0x6000421")]
		internal get { } //Length: 39
	}

	[Token(Token = "0x170000A0")]
	internal abstract Type PublicType
	{
		[Token(Token = "0x6000416")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x170000A5")]
	public Type ReturnType
	{
		[Address(RVA = "0x2265F80", Offset = "0x2265380", Length = "0x83")]
		[Token(Token = "0x600041B")]
		 get { } //Length: 131
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x170000A8")]
	private override int System.Linq.Expressions.IParameterProvider.ParameterCount
	{
		[Address(RVA = "0x2265EC0", Offset = "0x22652C0", Length = "0x14")]
		[Token(Token = "0x6000420")]
		private get { } //Length: 20
	}

	[Token(Token = "0x170000A6")]
	public bool TailCall
	{
		[Address(RVA = "0xE37DF0", Offset = "0xE371F0", Length = "0x14")]
		[Token(Token = "0x600041C")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000A7")]
	internal override bool TailCallCore
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600041D")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700009E")]
	public virtual Type Type
	{
		[Address(RVA = "0x22536E0", Offset = "0x2252AE0", Length = "0x14")]
		[Token(Token = "0x6000414")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700009F")]
	internal abstract Type TypeCore
	{
		[Token(Token = "0x6000415")]
		internal get { } //Length: 0
	}

	[Address(RVA = "0x2265EE0", Offset = "0x22652E0", Length = "0x65")]
	[Token(Token = "0x6000413")]
	internal LambdaExpression(Expression body) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600041A")]
	public Expression get_Body() { }

	[Address(RVA = "0xE37F60", Offset = "0xE37360", Length = "0x14")]
	[Token(Token = "0x6000418")]
	public string get_Name() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000419")]
	internal override string get_NameCore() { }

	[Address(RVA = "0x1E82360", Offset = "0x1E81760", Length = "0x6")]
	[Token(Token = "0x6000417")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2265F50", Offset = "0x2265350", Length = "0x27")]
	[Token(Token = "0x6000421")]
	internal override int get_ParameterCount() { }

	[Token(Token = "0x6000416")]
	internal abstract Type get_PublicType() { }

	[Address(RVA = "0x2265F80", Offset = "0x2265380", Length = "0x83")]
	[Token(Token = "0x600041B")]
	public Type get_ReturnType() { }

	[Address(RVA = "0xE37DF0", Offset = "0xE371F0", Length = "0x14")]
	[Token(Token = "0x600041C")]
	public bool get_TailCall() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600041D")]
	internal override bool get_TailCallCore() { }

	[Address(RVA = "0x22536E0", Offset = "0x2252AE0", Length = "0x14")]
	[Token(Token = "0x6000414")]
	public virtual Type get_Type() { }

	[Token(Token = "0x6000415")]
	internal abstract Type get_TypeCore() { }

	[Address(RVA = "0x2265E70", Offset = "0x2265270", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x600041F")]
	internal override ParameterExpression GetParameter(int index) { }

	[Address(RVA = "0x2265EC0", Offset = "0x22652C0", Length = "0x14")]
	[Token(Token = "0x6000420")]
	private override int System.Linq.Expressions.IParameterProvider.get_ParameterCount() { }

	[Address(RVA = "0x2265EA0", Offset = "0x22652A0", Length = "0x14")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x600041E")]
	private override ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(int index) { }

}

