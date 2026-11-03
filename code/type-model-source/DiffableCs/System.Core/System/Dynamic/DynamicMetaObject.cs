namespace System.Dynamic;

[Token(Token = "0x2000264")]
public class DynamicMetaObject
{
	[Token(Token = "0x4000441")]
	public static readonly DynamicMetaObject[] EmptyMetaObjects; //Field offset: 0x0
	[Token(Token = "0x4000442")]
	private static readonly object s_noValueSentinel; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000443")]
	private readonly object _value; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000444")]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000445")]
	private readonly BindingRestrictions <Restrictions>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700025E")]
	public Expression Expression
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000BB2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000261")]
	public bool HasValue
	{
		[Address(RVA = "0x2296F00", Offset = "0x2296300", Length = "0x5C")]
		[Token(Token = "0x6000BB5")]
		 get { } //Length: 92
	}

	[Token(Token = "0x17000263")]
	public Type LimitType
	{
		[Address(RVA = "0x2296F60", Offset = "0x2296360", Length = "0xDE")]
		[Token(Token = "0x6000BB7")]
		 get { } //Length: 222
	}

	[Token(Token = "0x1700025F")]
	public BindingRestrictions Restrictions
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000BB3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000262")]
	public Type RuntimeType
	{
		[Address(RVA = "0x2297040", Offset = "0x2296440", Length = "0xCE")]
		[Token(Token = "0x6000BB6")]
		 get { } //Length: 206
	}

	[Token(Token = "0x17000260")]
	public object Value
	{
		[Address(RVA = "0x2297110", Offset = "0x2296510", Length = "0x75")]
		[Token(Token = "0x6000BB4")]
		 get { } //Length: 117
	}

	[Address(RVA = "0x2296C60", Offset = "0x2296060", Length = "0xB7")]
	[Token(Token = "0x6000BC6")]
	private static DynamicMetaObject() { }

	[Address(RVA = "0x2296E20", Offset = "0x2296220", Length = "0xE0")]
	[Token(Token = "0x6000BB0")]
	public DynamicMetaObject(Expression expression, BindingRestrictions restrictions) { }

	[Address(RVA = "0x2296D20", Offset = "0x2296120", Length = "0xFD")]
	[Token(Token = "0x6000BB1")]
	public DynamicMetaObject(Expression expression, BindingRestrictions restrictions, object value) { }

	[Address(RVA = "0x22963B0", Offset = "0x22957B0", Length = "0x85")]
	[Token(Token = "0x6000BC3")]
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	[Address(RVA = "0x2296440", Offset = "0x2295840", Length = "0x6F")]
	[Token(Token = "0x6000BB8")]
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }

	[Address(RVA = "0x22964B0", Offset = "0x22958B0", Length = "0x85")]
	[Token(Token = "0x6000BC1")]
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	[Address(RVA = "0x2296540", Offset = "0x2295940", Length = "0x85")]
	[Token(Token = "0x6000BBE")]
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	[Address(RVA = "0x22965D0", Offset = "0x22959D0", Length = "0x6F")]
	[Token(Token = "0x6000BBB")]
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	[Address(RVA = "0x2296640", Offset = "0x2295A40", Length = "0x70")]
	[Token(Token = "0x6000BBC")]
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	[Address(RVA = "0x22966C0", Offset = "0x2295AC0", Length = "0x60")]
	[Token(Token = "0x6000BB9")]
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	[Address(RVA = "0x22967B0", Offset = "0x2295BB0", Length = "0x70")]
	[Token(Token = "0x6000BC0")]
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	[Address(RVA = "0x2296730", Offset = "0x2295B30", Length = "0x70")]
	[Token(Token = "0x6000BBF")]
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	[Address(RVA = "0x2296830", Offset = "0x2295C30", Length = "0x86")]
	[Token(Token = "0x6000BBD")]
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	[Address(RVA = "0x22968C0", Offset = "0x2295CC0", Length = "0x70")]
	[Token(Token = "0x6000BBA")]
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	[Address(RVA = "0x2296940", Offset = "0x2295D40", Length = "0x60")]
	[Token(Token = "0x6000BC2")]
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	[Address(RVA = "0x22969B0", Offset = "0x2295DB0", Length = "0x272")]
	[Token(Token = "0x6000BC5")]
	public static DynamicMetaObject Create(object value, Expression expression) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000BB2")]
	public Expression get_Expression() { }

	[Address(RVA = "0x2296F00", Offset = "0x2296300", Length = "0x5C")]
	[Token(Token = "0x6000BB5")]
	public bool get_HasValue() { }

	[Address(RVA = "0x2296F60", Offset = "0x2296360", Length = "0xDE")]
	[Token(Token = "0x6000BB7")]
	public Type get_LimitType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000BB3")]
	public BindingRestrictions get_Restrictions() { }

	[Address(RVA = "0x2297040", Offset = "0x2296440", Length = "0xCE")]
	[Token(Token = "0x6000BB6")]
	public Type get_RuntimeType() { }

	[Address(RVA = "0x2297110", Offset = "0x2296510", Length = "0x75")]
	[Token(Token = "0x6000BB4")]
	public object get_Value() { }

	[Address(RVA = "0x2296C30", Offset = "0x2296030", Length = "0x30")]
	[Token(Token = "0x6000BC4")]
	public override IEnumerable<String> GetDynamicMemberNames() { }

}

