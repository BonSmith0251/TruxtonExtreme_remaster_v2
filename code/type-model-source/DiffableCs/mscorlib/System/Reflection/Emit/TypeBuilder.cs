namespace System.Reflection.Emit;

[Token(Token = "0x2000535")]
public sealed class TypeBuilder : TypeInfo
{
	[Token(Token = "0x40014A3")]
	public const int UnspecifiedTypeSize = 0; //Field offset: 0x0

	[Token(Token = "0x17000528")]
	public virtual Assembly Assembly
	{
		[Address(RVA = "0x1F6E2B0", Offset = "0x1F6D6B0", Length = "0x3E")]
		[Token(Token = "0x60025A8")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000529")]
	public virtual string AssemblyQualifiedName
	{
		[Address(RVA = "0x1F6E270", Offset = "0x1F6D670", Length = "0x3E")]
		[Token(Token = "0x60025A9")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700052A")]
	public virtual Type BaseType
	{
		[Address(RVA = "0x1F6E2F0", Offset = "0x1F6D6F0", Length = "0x3E")]
		[Token(Token = "0x60025AA")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700052B")]
	public virtual string FullName
	{
		[Address(RVA = "0x1F6E330", Offset = "0x1F6D730", Length = "0x3E")]
		[Token(Token = "0x60025AB")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700052C")]
	public virtual Guid GUID
	{
		[Address(RVA = "0x1F6E370", Offset = "0x1F6D770", Length = "0x3E")]
		[Token(Token = "0x60025AC")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700052D")]
	public virtual Module Module
	{
		[Address(RVA = "0x1F6E3B0", Offset = "0x1F6D7B0", Length = "0x3E")]
		[Token(Token = "0x60025AD")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700052E")]
	public virtual string Name
	{
		[Address(RVA = "0x1F6E3F0", Offset = "0x1F6D7F0", Length = "0x3E")]
		[Token(Token = "0x60025AE")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700052F")]
	public virtual string Namespace
	{
		[Address(RVA = "0x1F6E430", Offset = "0x1F6D830", Length = "0x3E")]
		[Token(Token = "0x60025AF")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000530")]
	public virtual Type UnderlyingSystemType
	{
		[Address(RVA = "0x1F6E470", Offset = "0x1F6D870", Length = "0x3E")]
		[Token(Token = "0x60025B0")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x1F6E2B0", Offset = "0x1F6D6B0", Length = "0x3E")]
	[Token(Token = "0x60025A8")]
	public virtual Assembly get_Assembly() { }

	[Address(RVA = "0x1F6E270", Offset = "0x1F6D670", Length = "0x3E")]
	[Token(Token = "0x60025A9")]
	public virtual string get_AssemblyQualifiedName() { }

	[Address(RVA = "0x1F6E2F0", Offset = "0x1F6D6F0", Length = "0x3E")]
	[Token(Token = "0x60025AA")]
	public virtual Type get_BaseType() { }

	[Address(RVA = "0x1F6E330", Offset = "0x1F6D730", Length = "0x3E")]
	[Token(Token = "0x60025AB")]
	public virtual string get_FullName() { }

	[Address(RVA = "0x1F6E370", Offset = "0x1F6D770", Length = "0x3E")]
	[Token(Token = "0x60025AC")]
	public virtual Guid get_GUID() { }

	[Address(RVA = "0x1F6E3B0", Offset = "0x1F6D7B0", Length = "0x3E")]
	[Token(Token = "0x60025AD")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x1F6E3F0", Offset = "0x1F6D7F0", Length = "0x3E")]
	[Token(Token = "0x60025AE")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F6E430", Offset = "0x1F6D830", Length = "0x3E")]
	[Token(Token = "0x60025AF")]
	public virtual string get_Namespace() { }

	[Address(RVA = "0x1F6E470", Offset = "0x1F6D870", Length = "0x3E")]
	[Token(Token = "0x60025B0")]
	public virtual Type get_UnderlyingSystemType() { }

	[Address(RVA = "0x1F6DC30", Offset = "0x1F6D030", Length = "0x3E")]
	[Token(Token = "0x60025B1")]
	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	[Address(RVA = "0x1F6DC70", Offset = "0x1F6D070", Length = "0x3E")]
	[Token(Token = "0x60025B2")]
	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F6DCB0", Offset = "0x1F6D0B0", Length = "0x3E")]
	[ComVisible(True)]
	[Token(Token = "0x60025B3")]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6DCF0", Offset = "0x1F6D0F0", Length = "0x3E")]
	[Token(Token = "0x60025B4")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F6DD30", Offset = "0x1F6D130", Length = "0x3E")]
	[Token(Token = "0x60025B5")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F6DD70", Offset = "0x1F6D170", Length = "0x3E")]
	[Token(Token = "0x60025B6")]
	public virtual Type GetElementType() { }

	[Address(RVA = "0x1F6DDB0", Offset = "0x1F6D1B0", Length = "0x3E")]
	[Token(Token = "0x60025B7")]
	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6DDF0", Offset = "0x1F6D1F0", Length = "0x3E")]
	[Token(Token = "0x60025B8")]
	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6DE30", Offset = "0x1F6D230", Length = "0x3E")]
	[Token(Token = "0x60025B9")]
	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6DE70", Offset = "0x1F6D270", Length = "0x3E")]
	[Token(Token = "0x60025BA")]
	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6DEB0", Offset = "0x1F6D2B0", Length = "0x3E")]
	[Token(Token = "0x60025BB")]
	public virtual Type[] GetInterfaces() { }

	[Address(RVA = "0x1F6DEF0", Offset = "0x1F6D2F0", Length = "0x3E")]
	[Token(Token = "0x60025BC")]
	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6DF30", Offset = "0x1F6D330", Length = "0x3E")]
	[Token(Token = "0x60025BD")]
	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F6DF70", Offset = "0x1F6D370", Length = "0x3E")]
	[Token(Token = "0x60025BE")]
	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6DFB0", Offset = "0x1F6D3B0", Length = "0x3E")]
	[Token(Token = "0x60025BF")]
	public virtual Type GetNestedType(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6DFF0", Offset = "0x1F6D3F0", Length = "0x3E")]
	[Token(Token = "0x60025C0")]
	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6E030", Offset = "0x1F6D430", Length = "0x3E")]
	[Token(Token = "0x60025C1")]
	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F6E070", Offset = "0x1F6D470", Length = "0x3E")]
	[Token(Token = "0x60025C2")]
	protected virtual bool HasElementTypeImpl() { }

	[Address(RVA = "0x1F6E0B0", Offset = "0x1F6D4B0", Length = "0x3E")]
	[Token(Token = "0x60025C3")]
	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	[Address(RVA = "0x1F6E0F0", Offset = "0x1F6D4F0", Length = "0x3E")]
	[Token(Token = "0x60025C4")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x1F6E130", Offset = "0x1F6D530", Length = "0x3E")]
	[Token(Token = "0x60025C5")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x1F6E170", Offset = "0x1F6D570", Length = "0x3E")]
	[Token(Token = "0x60025C6")]
	protected virtual bool IsCOMObjectImpl() { }

	[Address(RVA = "0x1F6E1B0", Offset = "0x1F6D5B0", Length = "0x3E")]
	[Token(Token = "0x60025C7")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F6E1F0", Offset = "0x1F6D5F0", Length = "0x3E")]
	[Token(Token = "0x60025C8")]
	protected virtual bool IsPointerImpl() { }

	[Address(RVA = "0x1F6E230", Offset = "0x1F6D630", Length = "0x3E")]
	[Token(Token = "0x60025C9")]
	protected virtual bool IsPrimitiveImpl() { }

}

