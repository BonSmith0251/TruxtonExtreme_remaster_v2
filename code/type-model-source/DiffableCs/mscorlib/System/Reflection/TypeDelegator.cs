namespace System.Reflection;

[Token(Token = "0x2000505")]
public class TypeDelegator : TypeInfo
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013CE")]
	protected Type typeImpl; //Field offset: 0x18

	[Token(Token = "0x1700049A")]
	public virtual Assembly Assembly
	{
		[Address(RVA = "0x1F6EAC0", Offset = "0x1F6DEC0", Length = "0x2A")]
		[Token(Token = "0x6002384")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700049F")]
	public virtual string AssemblyQualifiedName
	{
		[Address(RVA = "0x1EAA5E0", Offset = "0x1EA99E0", Length = "0x2A")]
		[Token(Token = "0x6002389")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004A0")]
	public virtual Type BaseType
	{
		[Address(RVA = "0x1F6EAF0", Offset = "0x1F6DEF0", Length = "0x2A")]
		[Token(Token = "0x600238A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700049D")]
	public virtual string FullName
	{
		[Address(RVA = "0x1F6EB20", Offset = "0x1F6DF20", Length = "0x2A")]
		[Token(Token = "0x6002387")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000497")]
	public virtual Guid GUID
	{
		[Address(RVA = "0x1F6EB50", Offset = "0x1F6DF50", Length = "0x3E")]
		[Token(Token = "0x6002380")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170004A4")]
	public virtual bool IsCollectible
	{
		[Address(RVA = "0x1F6EB90", Offset = "0x1F6DF90", Length = "0x2A")]
		[Token(Token = "0x60023A3")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004A3")]
	public virtual bool IsConstructedGenericType
	{
		[Address(RVA = "0x1EA9A10", Offset = "0x1EA8E10", Length = "0x2A")]
		[Token(Token = "0x60023A2")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004A2")]
	public virtual bool IsGenericMethodParameter
	{
		[Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", Length = "0x2A")]
		[Token(Token = "0x600239E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004A1")]
	public virtual bool IsSZArray
	{
		[Address(RVA = "0x1F6EBF0", Offset = "0x1F6DFF0", Length = "0x2A")]
		[Token(Token = "0x600239A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000498")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x1F6EC20", Offset = "0x1F6E020", Length = "0x2A")]
		[Token(Token = "0x6002381")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000499")]
	public virtual Module Module
	{
		[Address(RVA = "0x1F6EC50", Offset = "0x1F6E050", Length = "0x2A")]
		[Token(Token = "0x6002383")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700049C")]
	public virtual string Name
	{
		[Address(RVA = "0x1F6B800", Offset = "0x1F6AC00", Length = "0x2A")]
		[Token(Token = "0x6002386")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700049E")]
	public virtual string Namespace
	{
		[Address(RVA = "0x1F6B830", Offset = "0x1F6AC30", Length = "0x2A")]
		[Token(Token = "0x6002388")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700049B")]
	public virtual RuntimeTypeHandle TypeHandle
	{
		[Address(RVA = "0x1F6EC80", Offset = "0x1F6E080", Length = "0x2A")]
		[Token(Token = "0x6002385")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170004A5")]
	public virtual Type UnderlyingSystemType
	{
		[Address(RVA = "0x1F6ECB0", Offset = "0x1F6E0B0", Length = "0x2A")]
		[Token(Token = "0x60023A6")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x1F6EA00", Offset = "0x1F6DE00", Length = "0xB7")]
	[Token(Token = "0x600237F")]
	public TypeDelegator(Type delegatingType) { }

	[Address(RVA = "0x1F6EAC0", Offset = "0x1F6DEC0", Length = "0x2A")]
	[Token(Token = "0x6002384")]
	public virtual Assembly get_Assembly() { }

	[Address(RVA = "0x1EAA5E0", Offset = "0x1EA99E0", Length = "0x2A")]
	[Token(Token = "0x6002389")]
	public virtual string get_AssemblyQualifiedName() { }

	[Address(RVA = "0x1F6EAF0", Offset = "0x1F6DEF0", Length = "0x2A")]
	[Token(Token = "0x600238A")]
	public virtual Type get_BaseType() { }

	[Address(RVA = "0x1F6EB20", Offset = "0x1F6DF20", Length = "0x2A")]
	[Token(Token = "0x6002387")]
	public virtual string get_FullName() { }

	[Address(RVA = "0x1F6EB50", Offset = "0x1F6DF50", Length = "0x3E")]
	[Token(Token = "0x6002380")]
	public virtual Guid get_GUID() { }

	[Address(RVA = "0x1F6EB90", Offset = "0x1F6DF90", Length = "0x2A")]
	[Token(Token = "0x60023A3")]
	public virtual bool get_IsCollectible() { }

	[Address(RVA = "0x1EA9A10", Offset = "0x1EA8E10", Length = "0x2A")]
	[Token(Token = "0x60023A2")]
	public virtual bool get_IsConstructedGenericType() { }

	[Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", Length = "0x2A")]
	[Token(Token = "0x600239E")]
	public virtual bool get_IsGenericMethodParameter() { }

	[Address(RVA = "0x1F6EBF0", Offset = "0x1F6DFF0", Length = "0x2A")]
	[Token(Token = "0x600239A")]
	public virtual bool get_IsSZArray() { }

	[Address(RVA = "0x1F6EC20", Offset = "0x1F6E020", Length = "0x2A")]
	[Token(Token = "0x6002381")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x1F6EC50", Offset = "0x1F6E050", Length = "0x2A")]
	[Token(Token = "0x6002383")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x1F6B800", Offset = "0x1F6AC00", Length = "0x2A")]
	[Token(Token = "0x6002386")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F6B830", Offset = "0x1F6AC30", Length = "0x2A")]
	[Token(Token = "0x6002388")]
	public virtual string get_Namespace() { }

	[Address(RVA = "0x1F6EC80", Offset = "0x1F6E080", Length = "0x2A")]
	[Token(Token = "0x6002385")]
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	[Address(RVA = "0x1F6ECB0", Offset = "0x1F6E0B0", Length = "0x2A")]
	[Token(Token = "0x60023A6")]
	public virtual Type get_UnderlyingSystemType() { }

	[Address(RVA = "0x1F6E4B0", Offset = "0x1F6D8B0", Length = "0x1D")]
	[Token(Token = "0x6002399")]
	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	[Address(RVA = "0x1F6E4D0", Offset = "0x1F6D8D0", Length = "0x27")]
	[Token(Token = "0x600238B")]
	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F6E500", Offset = "0x1F6D900", Length = "0x2A")]
	[ComVisible(True)]
	[Token(Token = "0x600238C")]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6E530", Offset = "0x1F6D930", Length = "0x2A")]
	[Token(Token = "0x60023A8")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F6E560", Offset = "0x1F6D960", Length = "0x2A")]
	[Token(Token = "0x60023A7")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F6E590", Offset = "0x1F6D990", Length = "0x2A")]
	[Token(Token = "0x60023A4")]
	public virtual Type GetElementType() { }

	[Address(RVA = "0x1F6E5C0", Offset = "0x1F6D9C0", Length = "0x2A")]
	[Token(Token = "0x6002392")]
	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6E5F0", Offset = "0x1F6D9F0", Length = "0x2A")]
	[Token(Token = "0x6002395")]
	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6E620", Offset = "0x1F6DA20", Length = "0x2A")]
	[Token(Token = "0x600238F")]
	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6E650", Offset = "0x1F6DA50", Length = "0x2A")]
	[Token(Token = "0x6002390")]
	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6E680", Offset = "0x1F6DA80", Length = "0x2A")]
	[Token(Token = "0x6002391")]
	public virtual Type[] GetInterfaces() { }

	[Address(RVA = "0x1F6E6B0", Offset = "0x1F6DAB0", Length = "0x2F")]
	[Token(Token = "0x6002397")]
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6E6E0", Offset = "0x1F6DAE0", Length = "0x2A")]
	[Token(Token = "0x6002398")]
	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6E710", Offset = "0x1F6DB10", Length = "0x3D")]
	[Token(Token = "0x600238D")]
	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F6E750", Offset = "0x1F6DB50", Length = "0x2A")]
	[Token(Token = "0x600238E")]
	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6E780", Offset = "0x1F6DB80", Length = "0x2A")]
	[Token(Token = "0x6002396")]
	public virtual Type GetNestedType(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6E7B0", Offset = "0x1F6DBB0", Length = "0x2A")]
	[Token(Token = "0x6002394")]
	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6E7E0", Offset = "0x1F6DBE0", Length = "0xCB")]
	[Token(Token = "0x6002393")]
	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F6E8B0", Offset = "0x1F6DCB0", Length = "0x1D")]
	[Token(Token = "0x60023A5")]
	protected virtual bool HasElementTypeImpl() { }

	[Address(RVA = "0x1F6E8D0", Offset = "0x1F6DCD0", Length = "0x32")]
	[Token(Token = "0x6002382")]
	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	[Address(RVA = "0x1F6E910", Offset = "0x1F6DD10", Length = "0x1D")]
	[Token(Token = "0x600239B")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x1F6E930", Offset = "0x1F6DD30", Length = "0x1D")]
	[Token(Token = "0x600239D")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x1F6E950", Offset = "0x1F6DD50", Length = "0x1D")]
	[Token(Token = "0x60023A1")]
	protected virtual bool IsCOMObjectImpl() { }

	[Address(RVA = "0x1F6E970", Offset = "0x1F6DD70", Length = "0x2A")]
	[Token(Token = "0x60023A9")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F6E9A0", Offset = "0x1F6DDA0", Length = "0x1D")]
	[Token(Token = "0x600239F")]
	protected virtual bool IsPointerImpl() { }

	[Address(RVA = "0x1F6E9C0", Offset = "0x1F6DDC0", Length = "0x1D")]
	[Token(Token = "0x600239C")]
	protected virtual bool IsPrimitiveImpl() { }

	[Address(RVA = "0x1F6E9E0", Offset = "0x1F6DDE0", Length = "0x1D")]
	[Token(Token = "0x60023A0")]
	protected virtual bool IsValueTypeImpl() { }

}

