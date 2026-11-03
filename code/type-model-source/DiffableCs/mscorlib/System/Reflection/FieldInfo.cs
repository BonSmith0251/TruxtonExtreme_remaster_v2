namespace System.Reflection;

[Token(Token = "0x20004E3")]
public abstract class FieldInfo : MemberInfo
{

	[Token(Token = "0x17000424")]
	public abstract FieldAttributes Attributes
	{
		[Token(Token = "0x6002237")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700042C")]
	public abstract RuntimeFieldHandle FieldHandle
	{
		[Token(Token = "0x600223F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000425")]
	public abstract Type FieldType
	{
		[Token(Token = "0x6002238")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000426")]
	public override bool IsInitOnly
	{
		[Address(RVA = "0x1F35A80", Offset = "0x1F34E80", Length = "0x21")]
		[Token(Token = "0x6002239")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000427")]
	public override bool IsLiteral
	{
		[Address(RVA = "0x1F35AB0", Offset = "0x1F34EB0", Length = "0x21")]
		[Token(Token = "0x600223A")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000428")]
	public override bool IsNotSerialized
	{
		[Address(RVA = "0x1F35AE0", Offset = "0x1F34EE0", Length = "0x24")]
		[Token(Token = "0x600223B")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700042A")]
	public override bool IsPrivate
	{
		[Address(RVA = "0x1F35B10", Offset = "0x1F34F10", Length = "0x23")]
		[Token(Token = "0x600223D")]
		 get { } //Length: 35
	}

	[Token(Token = "0x1700042B")]
	public override bool IsPublic
	{
		[Address(RVA = "0x1F35B40", Offset = "0x1F34F40", Length = "0x24")]
		[Token(Token = "0x600223E")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000429")]
	public override bool IsStatic
	{
		[Address(RVA = "0x1F35B70", Offset = "0x1F34F70", Length = "0x21")]
		[Token(Token = "0x600223C")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000423")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x6002236")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6002235")]
	protected FieldInfo() { }

	[Address(RVA = "0x1F338A0", Offset = "0x1F32CA0", Length = "0x8")]
	[Token(Token = "0x6002240")]
	public virtual bool Equals(object obj) { }

	[Token(Token = "0x6002237")]
	public abstract FieldAttributes get_Attributes() { }

	[Token(Token = "0x600223F")]
	public abstract RuntimeFieldHandle get_FieldHandle() { }

	[Token(Token = "0x6002238")]
	public abstract Type get_FieldType() { }

	[Address(RVA = "0x1F35A80", Offset = "0x1F34E80", Length = "0x21")]
	[Token(Token = "0x6002239")]
	public override bool get_IsInitOnly() { }

	[Address(RVA = "0x1F35AB0", Offset = "0x1F34EB0", Length = "0x21")]
	[Token(Token = "0x600223A")]
	public override bool get_IsLiteral() { }

	[Address(RVA = "0x1F35AE0", Offset = "0x1F34EE0", Length = "0x24")]
	[Token(Token = "0x600223B")]
	public override bool get_IsNotSerialized() { }

	[Address(RVA = "0x1F35B10", Offset = "0x1F34F10", Length = "0x23")]
	[Token(Token = "0x600223D")]
	public override bool get_IsPrivate() { }

	[Address(RVA = "0x1F35B40", Offset = "0x1F34F40", Length = "0x24")]
	[Token(Token = "0x600223E")]
	public override bool get_IsPublic() { }

	[Address(RVA = "0x1F35B70", Offset = "0x1F34F70", Length = "0x21")]
	[Token(Token = "0x600223C")]
	public override bool get_IsStatic() { }

	[Address(RVA = "0x1EF3600", Offset = "0x1EF2A00", Length = "0x5")]
	[Token(Token = "0x600224D")]
	private MarshalAsAttribute get_marshal_info() { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x6002236")]
	public virtual MemberTypes get_MemberType() { }

	[Address(RVA = "0x1F34F40", Offset = "0x1F34340", Length = "0xAC")]
	[ComVisible(False)]
	[Token(Token = "0x600224B")]
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	[Address(RVA = "0x1F34ED0", Offset = "0x1F342D0", Length = "0x66")]
	[Token(Token = "0x600224A")]
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[Address(RVA = "0x1F34FF0", Offset = "0x1F343F0", Length = "0x4E")]
	[Token(Token = "0x600224C")]
	internal override int GetFieldOffset() { }

	[Address(RVA = "0x1F338B0", Offset = "0x1F32CB0", Length = "0x7")]
	[Token(Token = "0x6002241")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F356D0", Offset = "0x1F34AD0", Length = "0x288")]
	[Token(Token = "0x600224E")]
	internal Object[] GetPseudoCustomAttributes() { }

	[Address(RVA = "0x1F35040", Offset = "0x1F34440", Length = "0x688")]
	[Token(Token = "0x600224F")]
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	[Address(RVA = "0x1F35960", Offset = "0x1F34D60", Length = "0x4E")]
	[Token(Token = "0x6002248")]
	public override object GetRawConstantValue() { }

	[Token(Token = "0x6002244")]
	public abstract object GetValue(object obj) { }

	[Address(RVA = "0x1F35BA0", Offset = "0x1F34FA0", Length = "0x5")]
	[Token(Token = "0x6002249")]
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	[Address(RVA = "0x1F339B0", Offset = "0x1F32DB0", Length = "0x29")]
	[Token(Token = "0x6002242")]
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	[Address(RVA = "0x1F342C0", Offset = "0x1F336C0", Length = "0x3E")]
	[Token(Token = "0x6002243")]
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

	[Token(Token = "0x6002246")]
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[Address(RVA = "0x1F35A00", Offset = "0x1F34E00", Length = "0x77")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6002245")]
	public override void SetValue(object obj, object value) { }

	[Address(RVA = "0x1F359B0", Offset = "0x1F34DB0", Length = "0x4E")]
	[CLSCompliant(False)]
	[Token(Token = "0x6002247")]
	public override void SetValueDirect(TypedReference obj, object value) { }

}

