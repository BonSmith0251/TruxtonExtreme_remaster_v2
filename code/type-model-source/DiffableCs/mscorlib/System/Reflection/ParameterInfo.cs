namespace System.Reflection;

[Token(Token = "0x20004F3")]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo
{
	[Token(Token = "0x4001392")]
	private const int MetadataToken_ParamDef = 134217728; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400138C")]
	protected ParameterAttributes AttrsImpl; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400138D")]
	protected Type ClassImpl; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400138E")]
	protected object DefaultValueImpl; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400138F")]
	protected MemberInfo MemberImpl; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001390")]
	protected string NameImpl; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001391")]
	protected int PositionImpl; //Field offset: 0x38

	[Token(Token = "0x17000447")]
	public override ParameterAttributes Attributes
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60022AB")]
		 get { } //Length: 85
	}

	[Token(Token = "0x1700044F")]
	public override object DefaultValue
	{
		[Address(RVA = "0x1F62790", Offset = "0x1F61B90", Length = "0x27")]
		[Token(Token = "0x60022B3")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700044C")]
	public bool IsIn
	{
		[Address(RVA = "0x1F627C0", Offset = "0x1F61BC0", Length = "0x1E")]
		[Token(Token = "0x60022B0")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700044D")]
	public bool IsOptional
	{
		[Address(RVA = "0x1F627E0", Offset = "0x1F61BE0", Length = "0x21")]
		[Token(Token = "0x60022B1")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700044E")]
	public bool IsOut
	{
		[Address(RVA = "0x1F62810", Offset = "0x1F61C10", Length = "0x21")]
		[Token(Token = "0x60022B2")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000448")]
	public override MemberInfo Member
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60022AC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000449")]
	public override string Name
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60022AD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700044A")]
	public override Type ParameterType
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60022AE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700044B")]
	public override int Position
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x60022AF")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60022AA")]
	protected ParameterInfo() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60022AB")]
	public override ParameterAttributes get_Attributes() { }

	[Address(RVA = "0x1F62790", Offset = "0x1F61B90", Length = "0x27")]
	[Token(Token = "0x60022B3")]
	public override object get_DefaultValue() { }

	[Address(RVA = "0x1F627C0", Offset = "0x1F61BC0", Length = "0x1E")]
	[Token(Token = "0x60022B0")]
	public bool get_IsIn() { }

	[Address(RVA = "0x1F627E0", Offset = "0x1F61BE0", Length = "0x21")]
	[Token(Token = "0x60022B1")]
	public bool get_IsOptional() { }

	[Address(RVA = "0x1F62810", Offset = "0x1F61C10", Length = "0x21")]
	[Token(Token = "0x60022B2")]
	public bool get_IsOut() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60022AC")]
	public override MemberInfo get_Member() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60022AD")]
	public override string get_Name() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60022AE")]
	public override Type get_ParameterType() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60022AF")]
	public override int get_Position() { }

	[Address(RVA = "0x1F621B0", Offset = "0x1F615B0", Length = "0x30")]
	[Token(Token = "0x60022B5")]
	public override Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F621E0", Offset = "0x1F615E0", Length = "0xA4")]
	[Token(Token = "0x60022B6")]
	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F62290", Offset = "0x1F61690", Length = "0x3E2")]
	[Token(Token = "0x60022B7")]
	public override object GetRealObject(StreamingContext context) { }

	[Address(RVA = "0x1F62680", Offset = "0x1F61A80", Length = "0x7D")]
	[Token(Token = "0x60022B4")]
	public override bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F62700", Offset = "0x1F61B00", Length = "0x8D")]
	[Token(Token = "0x60022B8")]
	public virtual string ToString() { }

}

