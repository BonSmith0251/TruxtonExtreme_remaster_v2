namespace System.Dynamic;

[Token(Token = "0x2000265")]
public abstract class DynamicMetaObjectBinder : CallSiteBinder
{

	[Token(Token = "0x17000265")]
	internal override bool IsStandardBinder
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BCD")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000264")]
	public override Type ReturnType
	{
		[Address(RVA = "0x217A900", Offset = "0x2179D00", Length = "0x32")]
		[Token(Token = "0x6000BC8")]
		 get { } //Length: 50
	}

	[Address(RVA = "0x2296360", Offset = "0x2295760", Length = "0x49")]
	[Token(Token = "0x6000BC7")]
	protected DynamicMetaObjectBinder() { }

	[Address(RVA = "0x22958A0", Offset = "0x2294CA0", Length = "0x859")]
	[Token(Token = "0x6000BC9")]
	public virtual Expression Bind(Object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) { }

	[Token(Token = "0x6000BCB")]
	public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Address(RVA = "0x2296100", Offset = "0x2295500", Length = "0x194")]
	[Token(Token = "0x6000BCA")]
	private static DynamicMetaObject[] CreateArgumentMetaObjects(Object[] args, ReadOnlyCollection<ParameterExpression> parameters) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BCD")]
	internal override bool get_IsStandardBinder() { }

	[Address(RVA = "0x217A900", Offset = "0x2179D00", Length = "0x32")]
	[Token(Token = "0x6000BC8")]
	public override Type get_ReturnType() { }

	[Address(RVA = "0x22962A0", Offset = "0x22956A0", Length = "0xB9")]
	[Token(Token = "0x6000BCC")]
	public Expression GetUpdateExpression(Type type) { }

}

