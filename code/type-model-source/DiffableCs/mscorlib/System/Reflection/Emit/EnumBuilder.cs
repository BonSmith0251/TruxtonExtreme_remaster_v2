namespace System.Reflection.Emit;

[Token(Token = "0x200052A")]
public sealed class EnumBuilder : TypeInfo
{

	[Token(Token = "0x17000505")]
	public virtual Assembly Assembly
	{
		[Address(RVA = "0x1F5DC50", Offset = "0x1F5D050", Length = "0x3E")]
		[Token(Token = "0x600253F")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000506")]
	public virtual string AssemblyQualifiedName
	{
		[Address(RVA = "0x1F5DC10", Offset = "0x1F5D010", Length = "0x3E")]
		[Token(Token = "0x6002540")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000507")]
	public virtual Type BaseType
	{
		[Address(RVA = "0x1F5DC90", Offset = "0x1F5D090", Length = "0x3E")]
		[Token(Token = "0x6002541")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000508")]
	public virtual string FullName
	{
		[Address(RVA = "0x1F5DCD0", Offset = "0x1F5D0D0", Length = "0x3E")]
		[Token(Token = "0x6002542")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000509")]
	public virtual Guid GUID
	{
		[Address(RVA = "0x1F5DD10", Offset = "0x1F5D110", Length = "0x3E")]
		[Token(Token = "0x6002543")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700050A")]
	public virtual Module Module
	{
		[Address(RVA = "0x1F5DD50", Offset = "0x1F5D150", Length = "0x3E")]
		[Token(Token = "0x6002544")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700050B")]
	public virtual string Name
	{
		[Address(RVA = "0x1F5DD90", Offset = "0x1F5D190", Length = "0x3E")]
		[Token(Token = "0x6002545")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700050C")]
	public virtual string Namespace
	{
		[Address(RVA = "0x1F5DDD0", Offset = "0x1F5D1D0", Length = "0x3E")]
		[Token(Token = "0x6002546")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700050D")]
	public virtual Type UnderlyingSystemType
	{
		[Address(RVA = "0x1F5DE10", Offset = "0x1F5D210", Length = "0x3E")]
		[Token(Token = "0x6002547")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x1F5DC50", Offset = "0x1F5D050", Length = "0x3E")]
	[Token(Token = "0x600253F")]
	public virtual Assembly get_Assembly() { }

	[Address(RVA = "0x1F5DC10", Offset = "0x1F5D010", Length = "0x3E")]
	[Token(Token = "0x6002540")]
	public virtual string get_AssemblyQualifiedName() { }

	[Address(RVA = "0x1F5DC90", Offset = "0x1F5D090", Length = "0x3E")]
	[Token(Token = "0x6002541")]
	public virtual Type get_BaseType() { }

	[Address(RVA = "0x1F5DCD0", Offset = "0x1F5D0D0", Length = "0x3E")]
	[Token(Token = "0x6002542")]
	public virtual string get_FullName() { }

	[Address(RVA = "0x1F5DD10", Offset = "0x1F5D110", Length = "0x3E")]
	[Token(Token = "0x6002543")]
	public virtual Guid get_GUID() { }

	[Address(RVA = "0x1F5DD50", Offset = "0x1F5D150", Length = "0x3E")]
	[Token(Token = "0x6002544")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x1F5DD90", Offset = "0x1F5D190", Length = "0x3E")]
	[Token(Token = "0x6002545")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F5DDD0", Offset = "0x1F5D1D0", Length = "0x3E")]
	[Token(Token = "0x6002546")]
	public virtual string get_Namespace() { }

	[Address(RVA = "0x1F5DE10", Offset = "0x1F5D210", Length = "0x3E")]
	[Token(Token = "0x6002547")]
	public virtual Type get_UnderlyingSystemType() { }

	[Address(RVA = "0x1F5D5D0", Offset = "0x1F5C9D0", Length = "0x3E")]
	[Token(Token = "0x6002548")]
	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	[Address(RVA = "0x1F5D610", Offset = "0x1F5CA10", Length = "0x3E")]
	[Token(Token = "0x6002549")]
	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F5D650", Offset = "0x1F5CA50", Length = "0x3E")]
	[ComVisible(True)]
	[Token(Token = "0x600254A")]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5D6D0", Offset = "0x1F5CAD0", Length = "0x3E")]
	[Token(Token = "0x600254B")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F5D690", Offset = "0x1F5CA90", Length = "0x3E")]
	[Token(Token = "0x600254C")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F5D710", Offset = "0x1F5CB10", Length = "0x3E")]
	[Token(Token = "0x600254D")]
	public virtual Type GetElementType() { }

	[Address(RVA = "0x1F5D750", Offset = "0x1F5CB50", Length = "0x3E")]
	[Token(Token = "0x600254E")]
	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5D790", Offset = "0x1F5CB90", Length = "0x3E")]
	[Token(Token = "0x600254F")]
	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5D7D0", Offset = "0x1F5CBD0", Length = "0x3E")]
	[Token(Token = "0x6002550")]
	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5D810", Offset = "0x1F5CC10", Length = "0x3E")]
	[Token(Token = "0x6002551")]
	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5D850", Offset = "0x1F5CC50", Length = "0x3E")]
	[Token(Token = "0x6002552")]
	public virtual Type[] GetInterfaces() { }

	[Address(RVA = "0x1F5D890", Offset = "0x1F5CC90", Length = "0x3E")]
	[Token(Token = "0x6002553")]
	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5D8D0", Offset = "0x1F5CCD0", Length = "0x3E")]
	[Token(Token = "0x6002554")]
	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F5D910", Offset = "0x1F5CD10", Length = "0x3E")]
	[Token(Token = "0x6002555")]
	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5D950", Offset = "0x1F5CD50", Length = "0x3E")]
	[Token(Token = "0x6002556")]
	public virtual Type GetNestedType(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5D990", Offset = "0x1F5CD90", Length = "0x3E")]
	[Token(Token = "0x6002557")]
	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5D9D0", Offset = "0x1F5CDD0", Length = "0x3E")]
	[Token(Token = "0x6002558")]
	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F5DA10", Offset = "0x1F5CE10", Length = "0x3E")]
	[Token(Token = "0x6002559")]
	protected virtual bool HasElementTypeImpl() { }

	[Address(RVA = "0x1F5DA50", Offset = "0x1F5CE50", Length = "0x3E")]
	[Token(Token = "0x600255A")]
	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	[Address(RVA = "0x1F5DA90", Offset = "0x1F5CE90", Length = "0x3E")]
	[Token(Token = "0x600255B")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x1F5DAD0", Offset = "0x1F5CED0", Length = "0x3E")]
	[Token(Token = "0x600255C")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x1F5DB10", Offset = "0x1F5CF10", Length = "0x3E")]
	[Token(Token = "0x600255D")]
	protected virtual bool IsCOMObjectImpl() { }

	[Address(RVA = "0x1F5DB50", Offset = "0x1F5CF50", Length = "0x3E")]
	[Token(Token = "0x600255E")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F5DB90", Offset = "0x1F5CF90", Length = "0x3E")]
	[Token(Token = "0x600255F")]
	protected virtual bool IsPointerImpl() { }

	[Address(RVA = "0x1F5DBD0", Offset = "0x1F5CFD0", Length = "0x3E")]
	[Token(Token = "0x6002560")]
	protected virtual bool IsPrimitiveImpl() { }

}

