namespace System.Reflection.Emit;

[Token(Token = "0x2000530")]
public sealed class MethodBuilder : MethodInfo
{

	[Token(Token = "0x1700051D")]
	public virtual MethodAttributes Attributes
	{
		[Address(RVA = "0x1F615E0", Offset = "0x1F609E0", Length = "0x3E")]
		[Token(Token = "0x600258E")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700051E")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F61620", Offset = "0x1F60A20", Length = "0x3E")]
		[Token(Token = "0x600258F")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700051F")]
	public virtual RuntimeMethodHandle MethodHandle
	{
		[Address(RVA = "0x1F61660", Offset = "0x1F60A60", Length = "0x3E")]
		[Token(Token = "0x6002590")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000520")]
	public virtual string Name
	{
		[Address(RVA = "0x1F616A0", Offset = "0x1F60AA0", Length = "0x3E")]
		[Token(Token = "0x6002591")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000521")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x1F616E0", Offset = "0x1F60AE0", Length = "0x3E")]
		[Token(Token = "0x6002592")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x1F615E0", Offset = "0x1F609E0", Length = "0x3E")]
	[Token(Token = "0x600258E")]
	public virtual MethodAttributes get_Attributes() { }

	[Address(RVA = "0x1F61620", Offset = "0x1F60A20", Length = "0x3E")]
	[Token(Token = "0x600258F")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x1F61660", Offset = "0x1F60A60", Length = "0x3E")]
	[Token(Token = "0x6002590")]
	public virtual RuntimeMethodHandle get_MethodHandle() { }

	[Address(RVA = "0x1F616A0", Offset = "0x1F60AA0", Length = "0x3E")]
	[Token(Token = "0x6002591")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F616E0", Offset = "0x1F60AE0", Length = "0x3E")]
	[Token(Token = "0x6002592")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F61420", Offset = "0x1F60820", Length = "0x3E")]
	[Token(Token = "0x6002593")]
	public virtual MethodInfo GetBaseDefinition() { }

	[Address(RVA = "0x1F61460", Offset = "0x1F60860", Length = "0x3E")]
	[Token(Token = "0x6002594")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F614A0", Offset = "0x1F608A0", Length = "0x3E")]
	[Token(Token = "0x6002595")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F614E0", Offset = "0x1F608E0", Length = "0x3E")]
	[Token(Token = "0x6002596")]
	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	[Address(RVA = "0x1F61520", Offset = "0x1F60920", Length = "0x3E")]
	[Token(Token = "0x6002597")]
	public virtual ParameterInfo[] GetParameters() { }

	[Address(RVA = "0x1F61560", Offset = "0x1F60960", Length = "0x3E")]
	[Token(Token = "0x6002598")]
	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x1F615A0", Offset = "0x1F609A0", Length = "0x3E")]
	[Token(Token = "0x6002599")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

}

