namespace System.Reflection.Emit;

[Token(Token = "0x200052D")]
public sealed class GenericTypeParameterBuilder : TypeInfo
{

	[Token(Token = "0x17000514")]
	public virtual Assembly Assembly
	{
		[Address(RVA = "0x1F5E830", Offset = "0x1F5DC30", Length = "0x3E")]
		[Token(Token = "0x600256C")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000515")]
	public virtual string AssemblyQualifiedName
	{
		[Address(RVA = "0x1F5E7F0", Offset = "0x1F5DBF0", Length = "0x3E")]
		[Token(Token = "0x600256D")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000516")]
	public virtual Type BaseType
	{
		[Address(RVA = "0x1F5E870", Offset = "0x1F5DC70", Length = "0x3E")]
		[Token(Token = "0x600256E")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000517")]
	public virtual string FullName
	{
		[Address(RVA = "0x1F5E8B0", Offset = "0x1F5DCB0", Length = "0x3E")]
		[Token(Token = "0x600256F")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000518")]
	public virtual Guid GUID
	{
		[Address(RVA = "0x1F5E8F0", Offset = "0x1F5DCF0", Length = "0x3E")]
		[Token(Token = "0x6002570")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000519")]
	public virtual Module Module
	{
		[Address(RVA = "0x1F5E930", Offset = "0x1F5DD30", Length = "0x3E")]
		[Token(Token = "0x6002571")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700051A")]
	public virtual string Name
	{
		[Address(RVA = "0x1F5E970", Offset = "0x1F5DD70", Length = "0x3E")]
		[Token(Token = "0x6002572")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700051B")]
	public virtual string Namespace
	{
		[Address(RVA = "0x1F5E9B0", Offset = "0x1F5DDB0", Length = "0x3E")]
		[Token(Token = "0x6002573")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700051C")]
	public virtual Type UnderlyingSystemType
	{
		[Address(RVA = "0x1F5E9F0", Offset = "0x1F5DDF0", Length = "0x3E")]
		[Token(Token = "0x6002574")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x1F5E830", Offset = "0x1F5DC30", Length = "0x3E")]
	[Token(Token = "0x600256C")]
	public virtual Assembly get_Assembly() { }

	[Address(RVA = "0x1F5E7F0", Offset = "0x1F5DBF0", Length = "0x3E")]
	[Token(Token = "0x600256D")]
	public virtual string get_AssemblyQualifiedName() { }

	[Address(RVA = "0x1F5E870", Offset = "0x1F5DC70", Length = "0x3E")]
	[Token(Token = "0x600256E")]
	public virtual Type get_BaseType() { }

	[Address(RVA = "0x1F5E8B0", Offset = "0x1F5DCB0", Length = "0x3E")]
	[Token(Token = "0x600256F")]
	public virtual string get_FullName() { }

	[Address(RVA = "0x1F5E8F0", Offset = "0x1F5DCF0", Length = "0x3E")]
	[Token(Token = "0x6002570")]
	public virtual Guid get_GUID() { }

	[Address(RVA = "0x1F5E930", Offset = "0x1F5DD30", Length = "0x3E")]
	[Token(Token = "0x6002571")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x1F5E970", Offset = "0x1F5DD70", Length = "0x3E")]
	[Token(Token = "0x6002572")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F5E9B0", Offset = "0x1F5DDB0", Length = "0x3E")]
	[Token(Token = "0x6002573")]
	public virtual string get_Namespace() { }

	[Address(RVA = "0x1F5E9F0", Offset = "0x1F5DDF0", Length = "0x3E")]
	[Token(Token = "0x6002574")]
	public virtual Type get_UnderlyingSystemType() { }

	[Address(RVA = "0x1F5E1B0", Offset = "0x1F5D5B0", Length = "0x3E")]
	[Token(Token = "0x6002575")]
	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	[Address(RVA = "0x1F5E1F0", Offset = "0x1F5D5F0", Length = "0x3E")]
	[Token(Token = "0x6002576")]
	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F5E230", Offset = "0x1F5D630", Length = "0x3E")]
	[ComVisible(True)]
	[Token(Token = "0x6002577")]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5E2B0", Offset = "0x1F5D6B0", Length = "0x3E")]
	[Token(Token = "0x6002578")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F5E270", Offset = "0x1F5D670", Length = "0x3E")]
	[Token(Token = "0x6002579")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F5E2F0", Offset = "0x1F5D6F0", Length = "0x3E")]
	[Token(Token = "0x600257A")]
	public virtual Type GetElementType() { }

	[Address(RVA = "0x1F5E330", Offset = "0x1F5D730", Length = "0x3E")]
	[Token(Token = "0x600257B")]
	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5E370", Offset = "0x1F5D770", Length = "0x3E")]
	[Token(Token = "0x600257C")]
	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5E3B0", Offset = "0x1F5D7B0", Length = "0x3E")]
	[Token(Token = "0x600257D")]
	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5E3F0", Offset = "0x1F5D7F0", Length = "0x3E")]
	[Token(Token = "0x600257E")]
	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5E430", Offset = "0x1F5D830", Length = "0x3E")]
	[Token(Token = "0x600257F")]
	public virtual Type[] GetInterfaces() { }

	[Address(RVA = "0x1F5E470", Offset = "0x1F5D870", Length = "0x3E")]
	[Token(Token = "0x6002580")]
	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5E4B0", Offset = "0x1F5D8B0", Length = "0x3E")]
	[Token(Token = "0x6002581")]
	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F5E4F0", Offset = "0x1F5D8F0", Length = "0x3E")]
	[Token(Token = "0x6002582")]
	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5E530", Offset = "0x1F5D930", Length = "0x3E")]
	[Token(Token = "0x6002583")]
	public virtual Type GetNestedType(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5E570", Offset = "0x1F5D970", Length = "0x3E")]
	[Token(Token = "0x6002584")]
	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F5E5B0", Offset = "0x1F5D9B0", Length = "0x3E")]
	[Token(Token = "0x6002585")]
	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F5E5F0", Offset = "0x1F5D9F0", Length = "0x3E")]
	[Token(Token = "0x6002586")]
	protected virtual bool HasElementTypeImpl() { }

	[Address(RVA = "0x1F5E630", Offset = "0x1F5DA30", Length = "0x3E")]
	[Token(Token = "0x6002587")]
	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	[Address(RVA = "0x1F5E670", Offset = "0x1F5DA70", Length = "0x3E")]
	[Token(Token = "0x6002588")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x1F5E6B0", Offset = "0x1F5DAB0", Length = "0x3E")]
	[Token(Token = "0x6002589")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x1F5E6F0", Offset = "0x1F5DAF0", Length = "0x3E")]
	[Token(Token = "0x600258A")]
	protected virtual bool IsCOMObjectImpl() { }

	[Address(RVA = "0x1F5E730", Offset = "0x1F5DB30", Length = "0x3E")]
	[Token(Token = "0x600258B")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F5E770", Offset = "0x1F5DB70", Length = "0x3E")]
	[Token(Token = "0x600258C")]
	protected virtual bool IsPointerImpl() { }

	[Address(RVA = "0x1F5E7B0", Offset = "0x1F5DBB0", Length = "0x3E")]
	[Token(Token = "0x600258D")]
	protected virtual bool IsPrimitiveImpl() { }

}

