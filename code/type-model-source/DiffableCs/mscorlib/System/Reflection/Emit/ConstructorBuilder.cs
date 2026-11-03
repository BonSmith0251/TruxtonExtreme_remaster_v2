namespace System.Reflection.Emit;

[Token(Token = "0x2000528")]
public class ConstructorBuilder : ConstructorInfo
{

	[Token(Token = "0x170004FB")]
	public virtual MethodAttributes Attributes
	{
		[Address(RVA = "0x1F523E0", Offset = "0x1F517E0", Length = "0x3E")]
		[Token(Token = "0x6002527")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170004FC")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F52420", Offset = "0x1F51820", Length = "0x3E")]
		[Token(Token = "0x6002528")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170004FE")]
	public virtual RuntimeMethodHandle MethodHandle
	{
		[Address(RVA = "0x1F52460", Offset = "0x1F51860", Length = "0x3E")]
		[Token(Token = "0x600252C")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170004FD")]
	public virtual string Name
	{
		[Address(RVA = "0x1F524A0", Offset = "0x1F518A0", Length = "0x3E")]
		[Token(Token = "0x6002529")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170004FF")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x1F524E0", Offset = "0x1F518E0", Length = "0x3E")]
		[Token(Token = "0x6002531")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x1F523E0", Offset = "0x1F517E0", Length = "0x3E")]
	[Token(Token = "0x6002527")]
	public virtual MethodAttributes get_Attributes() { }

	[Address(RVA = "0x1F52420", Offset = "0x1F51820", Length = "0x3E")]
	[Token(Token = "0x6002528")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x1F52460", Offset = "0x1F51860", Length = "0x3E")]
	[Token(Token = "0x600252C")]
	public virtual RuntimeMethodHandle get_MethodHandle() { }

	[Address(RVA = "0x1F524A0", Offset = "0x1F518A0", Length = "0x3E")]
	[Token(Token = "0x6002529")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F524E0", Offset = "0x1F518E0", Length = "0x3E")]
	[Token(Token = "0x6002531")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F52220", Offset = "0x1F51620", Length = "0x3E")]
	[Token(Token = "0x600252F")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F52260", Offset = "0x1F51660", Length = "0x3E")]
	[Token(Token = "0x6002530")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F522A0", Offset = "0x1F516A0", Length = "0x3E")]
	[Token(Token = "0x600252B")]
	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	[Address(RVA = "0x1F522E0", Offset = "0x1F516E0", Length = "0x3E")]
	[Token(Token = "0x600252A")]
	public virtual ParameterInfo[] GetParameters() { }

	[Address(RVA = "0x1F52360", Offset = "0x1F51760", Length = "0x3E")]
	[Token(Token = "0x600252D")]
	public virtual object Invoke(BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x1F52320", Offset = "0x1F51720", Length = "0x3E")]
	[Token(Token = "0x6002532")]
	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x1F523A0", Offset = "0x1F517A0", Length = "0x3E")]
	[Token(Token = "0x600252E")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

}

