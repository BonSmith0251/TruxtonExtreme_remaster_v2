namespace System.Reflection.Emit;

[Token(Token = "0x2000529")]
public sealed class DynamicMethod : MethodInfo
{

	[Token(Token = "0x17000500")]
	public virtual MethodAttributes Attributes
	{
		[Address(RVA = "0x1F5D490", Offset = "0x1F5C890", Length = "0x3E")]
		[Token(Token = "0x6002533")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000501")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F5D4D0", Offset = "0x1F5C8D0", Length = "0x3E")]
		[Token(Token = "0x6002534")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000503")]
	public virtual RuntimeMethodHandle MethodHandle
	{
		[Address(RVA = "0x1F5D510", Offset = "0x1F5C910", Length = "0x3E")]
		[Token(Token = "0x6002537")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000502")]
	public virtual string Name
	{
		[Address(RVA = "0x1F5D550", Offset = "0x1F5C950", Length = "0x3E")]
		[Token(Token = "0x6002535")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000504")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x1F5D590", Offset = "0x1F5C990", Length = "0x3E")]
		[Token(Token = "0x6002538")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x1F5D490", Offset = "0x1F5C890", Length = "0x3E")]
	[Token(Token = "0x6002533")]
	public virtual MethodAttributes get_Attributes() { }

	[Address(RVA = "0x1F5D4D0", Offset = "0x1F5C8D0", Length = "0x3E")]
	[Token(Token = "0x6002534")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x1F5D510", Offset = "0x1F5C910", Length = "0x3E")]
	[Token(Token = "0x6002537")]
	public virtual RuntimeMethodHandle get_MethodHandle() { }

	[Address(RVA = "0x1F5D550", Offset = "0x1F5C950", Length = "0x3E")]
	[Token(Token = "0x6002535")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F5D590", Offset = "0x1F5C990", Length = "0x3E")]
	[Token(Token = "0x6002538")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F5D2D0", Offset = "0x1F5C6D0", Length = "0x3E")]
	[Token(Token = "0x600253C")]
	public virtual MethodInfo GetBaseDefinition() { }

	[Address(RVA = "0x1F5D350", Offset = "0x1F5C750", Length = "0x3E")]
	[Token(Token = "0x6002539")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F5D310", Offset = "0x1F5C710", Length = "0x3E")]
	[Token(Token = "0x600253A")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F5D390", Offset = "0x1F5C790", Length = "0x3E")]
	[Token(Token = "0x600253B")]
	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	[Address(RVA = "0x1F5D3D0", Offset = "0x1F5C7D0", Length = "0x3E")]
	[Token(Token = "0x6002536")]
	public virtual ParameterInfo[] GetParameters() { }

	[Address(RVA = "0x1F5D410", Offset = "0x1F5C810", Length = "0x3E")]
	[Token(Token = "0x600253D")]
	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x1F5D450", Offset = "0x1F5C850", Length = "0x3E")]
	[Token(Token = "0x600253E")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

}

