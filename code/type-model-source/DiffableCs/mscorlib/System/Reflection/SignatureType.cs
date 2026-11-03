namespace System.Reflection;

[Token(Token = "0x20004FF")]
internal abstract class SignatureType : Type
{

	[Token(Token = "0x1700048B")]
	public virtual Assembly Assembly
	{
		[Address(RVA = "0x1F6D370", Offset = "0x1F6C770", Length = "0x4E")]
		[Token(Token = "0x600233B")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700048A")]
	public virtual string AssemblyQualifiedName
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002339")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700048E")]
	public virtual Type BaseType
	{
		[Address(RVA = "0x1F6D3C0", Offset = "0x1F6C7C0", Length = "0x4E")]
		[Token(Token = "0x600233E")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000481")]
	public abstract bool ContainsGenericParameters
	{
		[Token(Token = "0x6002327")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000491")]
	public virtual MethodBase DeclaringMethod
	{
		[Address(RVA = "0x1F6D410", Offset = "0x1F6C810", Length = "0x4E")]
		[Token(Token = "0x6002343")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000490")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F6D460", Offset = "0x1F6C860", Length = "0x4E")]
		[Token(Token = "0x6002342")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000485")]
	internal abstract SignatureType ElementType
	{
		[Token(Token = "0x6002334")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000489")]
	public virtual string FullName
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002338")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000492")]
	public virtual GenericParameterAttributes GenericParameterAttributes
	{
		[Address(RVA = "0x1F6D500", Offset = "0x1F6C900", Length = "0x4E")]
		[Token(Token = "0x6002345")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000484")]
	public abstract int GenericParameterPosition
	{
		[Token(Token = "0x6002333")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000483")]
	public abstract Type[] GenericTypeArguments
	{
		[Token(Token = "0x6002331")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000493")]
	public virtual Guid GUID
	{
		[Address(RVA = "0x1F6D4B0", Offset = "0x1F6C8B0", Length = "0x4E")]
		[Token(Token = "0x600234B")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700047E")]
	public abstract bool IsConstructedGenericType
	{
		[Token(Token = "0x6002324")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000494")]
	public virtual bool IsEnum
	{
		[Address(RVA = "0x1F6D550", Offset = "0x1F6C950", Length = "0x4E")]
		[Token(Token = "0x6002363")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000480")]
	public abstract bool IsGenericMethodParameter
	{
		[Token(Token = "0x6002326")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700047F")]
	public abstract bool IsGenericParameter
	{
		[Token(Token = "0x6002325")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700047C")]
	public virtual bool IsGenericType
	{
		[Address(RVA = "0x1F6D5A0", Offset = "0x1F6C9A0", Length = "0x44")]
		[Token(Token = "0x6002322")]
		 get { } //Length: 68
	}

	[Token(Token = "0x1700047D")]
	public abstract bool IsGenericTypeDefinition
	{
		[Token(Token = "0x6002323")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000495")]
	public virtual bool IsSerializable
	{
		[Address(RVA = "0x1F6D5F0", Offset = "0x1F6C9F0", Length = "0x4E")]
		[Token(Token = "0x6002367")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000479")]
	public virtual bool IsSignatureType
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600231B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700047A")]
	public abstract bool IsSZArray
	{
		[Token(Token = "0x600231E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700047B")]
	public abstract bool IsVariableBoundArray
	{
		[Token(Token = "0x600231F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000482")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
		[Token(Token = "0x6002328")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700048F")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x1F6D640", Offset = "0x1F6CA40", Length = "0x4E")]
		[Token(Token = "0x6002341")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700048C")]
	public virtual Module Module
	{
		[Address(RVA = "0x1F6D690", Offset = "0x1F6CA90", Length = "0x4E")]
		[Token(Token = "0x600233C")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000487")]
	public abstract string Name
	{
		[Token(Token = "0x6002336")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000488")]
	public abstract string Namespace
	{
		[Token(Token = "0x6002337")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700048D")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x1F6D6E0", Offset = "0x1F6CAE0", Length = "0x4E")]
		[Token(Token = "0x600233D")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000496")]
	public virtual RuntimeTypeHandle TypeHandle
	{
		[Address(RVA = "0x1F6D730", Offset = "0x1F6CB30", Length = "0x4E")]
		[Token(Token = "0x600236A")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000486")]
	public virtual Type UnderlyingSystemType
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6002335")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1F6D340", Offset = "0x1F6C740", Length = "0x2D")]
	[Token(Token = "0x600236B")]
	protected SignatureType() { }

	[Address(RVA = "0x1F6D370", Offset = "0x1F6C770", Length = "0x4E")]
	[Token(Token = "0x600233B")]
	public virtual Assembly get_Assembly() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6002339")]
	public virtual string get_AssemblyQualifiedName() { }

	[Address(RVA = "0x1F6D3C0", Offset = "0x1F6C7C0", Length = "0x4E")]
	[Token(Token = "0x600233E")]
	public virtual Type get_BaseType() { }

	[Token(Token = "0x6002327")]
	public abstract bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x1F6D410", Offset = "0x1F6C810", Length = "0x4E")]
	[Token(Token = "0x6002343")]
	public virtual MethodBase get_DeclaringMethod() { }

	[Address(RVA = "0x1F6D460", Offset = "0x1F6C860", Length = "0x4E")]
	[Token(Token = "0x6002342")]
	public virtual Type get_DeclaringType() { }

	[Token(Token = "0x6002334")]
	internal abstract SignatureType get_ElementType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6002338")]
	public virtual string get_FullName() { }

	[Address(RVA = "0x1F6D500", Offset = "0x1F6C900", Length = "0x4E")]
	[Token(Token = "0x6002345")]
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	[Token(Token = "0x6002333")]
	public abstract int get_GenericParameterPosition() { }

	[Token(Token = "0x6002331")]
	public abstract Type[] get_GenericTypeArguments() { }

	[Address(RVA = "0x1F6D4B0", Offset = "0x1F6C8B0", Length = "0x4E")]
	[Token(Token = "0x600234B")]
	public virtual Guid get_GUID() { }

	[Token(Token = "0x6002324")]
	public abstract bool get_IsConstructedGenericType() { }

	[Address(RVA = "0x1F6D550", Offset = "0x1F6C950", Length = "0x4E")]
	[Token(Token = "0x6002363")]
	public virtual bool get_IsEnum() { }

	[Token(Token = "0x6002326")]
	public abstract bool get_IsGenericMethodParameter() { }

	[Token(Token = "0x6002325")]
	public abstract bool get_IsGenericParameter() { }

	[Address(RVA = "0x1F6D5A0", Offset = "0x1F6C9A0", Length = "0x44")]
	[Token(Token = "0x6002322")]
	public virtual bool get_IsGenericType() { }

	[Token(Token = "0x6002323")]
	public abstract bool get_IsGenericTypeDefinition() { }

	[Address(RVA = "0x1F6D5F0", Offset = "0x1F6C9F0", Length = "0x4E")]
	[Token(Token = "0x6002367")]
	public virtual bool get_IsSerializable() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600231B")]
	public virtual bool get_IsSignatureType() { }

	[Token(Token = "0x600231E")]
	public abstract bool get_IsSZArray() { }

	[Token(Token = "0x600231F")]
	public abstract bool get_IsVariableBoundArray() { }

	[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
	[Token(Token = "0x6002328")]
	public virtual MemberTypes get_MemberType() { }

	[Address(RVA = "0x1F6D640", Offset = "0x1F6CA40", Length = "0x4E")]
	[Token(Token = "0x6002341")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x1F6D690", Offset = "0x1F6CA90", Length = "0x4E")]
	[Token(Token = "0x600233C")]
	public virtual Module get_Module() { }

	[Token(Token = "0x6002336")]
	public abstract string get_Name() { }

	[Token(Token = "0x6002337")]
	public abstract string get_Namespace() { }

	[Address(RVA = "0x1F6D6E0", Offset = "0x1F6CAE0", Length = "0x4E")]
	[Token(Token = "0x600233D")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F6D730", Offset = "0x1F6CB30", Length = "0x4E")]
	[Token(Token = "0x600236A")]
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002335")]
	public virtual Type get_UnderlyingSystemType() { }

	[Token(Token = "0x600232F")]
	public abstract int GetArrayRank() { }

	[Address(RVA = "0x1F6C540", Offset = "0x1F6B940", Length = "0x4E")]
	[Token(Token = "0x600234D")]
	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	[Address(RVA = "0x1F6C590", Offset = "0x1F6B990", Length = "0x4E")]
	[Token(Token = "0x600235F")]
	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F6C5E0", Offset = "0x1F6B9E0", Length = "0x4E")]
	[Token(Token = "0x600234E")]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6C630", Offset = "0x1F6BA30", Length = "0x4E")]
	[Token(Token = "0x600235C")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F6C680", Offset = "0x1F6BA80", Length = "0x4E")]
	[Token(Token = "0x600235D")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F6C6D0", Offset = "0x1F6BAD0", Length = "0x14")]
	[Token(Token = "0x600232E")]
	public virtual Type GetElementType() { }

	[Address(RVA = "0x1F6C6F0", Offset = "0x1F6BAF0", Length = "0x4E")]
	[Token(Token = "0x6002347")]
	public virtual string GetEnumName(object value) { }

	[Address(RVA = "0x1F6C740", Offset = "0x1F6BB40", Length = "0x4E")]
	[Token(Token = "0x6002348")]
	public virtual String[] GetEnumNames() { }

	[Address(RVA = "0x1F6C790", Offset = "0x1F6BB90", Length = "0x4E")]
	[Token(Token = "0x6002349")]
	public virtual Type GetEnumUnderlyingType() { }

	[Address(RVA = "0x1F6C7E0", Offset = "0x1F6BBE0", Length = "0x4E")]
	[Token(Token = "0x600234A")]
	public virtual Array GetEnumValues() { }

	[Address(RVA = "0x1F6C830", Offset = "0x1F6BC30", Length = "0x4E")]
	[Token(Token = "0x600234F")]
	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6C880", Offset = "0x1F6BC80", Length = "0x4E")]
	[Token(Token = "0x6002350")]
	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6C8D0", Offset = "0x1F6BCD0", Length = "0x4E")]
	[Token(Token = "0x6002351")]
	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6C920", Offset = "0x1F6BD20", Length = "0x4E")]
	[Token(Token = "0x6002352")]
	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[Token(Token = "0x6002332")]
	public abstract Type[] GetGenericArguments() { }

	[Address(RVA = "0x1F6C970", Offset = "0x1F6BD70", Length = "0x4E")]
	[Token(Token = "0x6002344")]
	public virtual Type[] GetGenericParameterConstraints() { }

	[Token(Token = "0x6002330")]
	public abstract Type GetGenericTypeDefinition() { }

	[Address(RVA = "0x1F6C9C0", Offset = "0x1F6BDC0", Length = "0x4E")]
	[Token(Token = "0x600233F")]
	public virtual Type[] GetInterfaces() { }

	[Address(RVA = "0x1F6CA10", Offset = "0x1F6BE10", Length = "0x4E")]
	[Token(Token = "0x600235B")]
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6CA60", Offset = "0x1F6BE60", Length = "0x4E")]
	[Token(Token = "0x600235A")]
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6CAB0", Offset = "0x1F6BEB0", Length = "0x4E")]
	[Token(Token = "0x6002353")]
	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6CB00", Offset = "0x1F6BF00", Length = "0x4E")]
	[Token(Token = "0x6002358")]
	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F6CB50", Offset = "0x1F6BF50", Length = "0x4E")]
	[Token(Token = "0x6002354")]
	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6CBA0", Offset = "0x1F6BFA0", Length = "0x4E")]
	[Token(Token = "0x6002355")]
	public virtual Type GetNestedType(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6CBF0", Offset = "0x1F6BFF0", Length = "0x4E")]
	[Token(Token = "0x6002356")]
	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[Address(RVA = "0x1F6CC40", Offset = "0x1F6C040", Length = "0x4E")]
	[Token(Token = "0x6002359")]
	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x1F6CC90", Offset = "0x1F6C090", Length = "0x4E")]
	[Token(Token = "0x600234C")]
	protected virtual TypeCode GetTypeCodeImpl() { }

	[Token(Token = "0x600231C")]
	protected abstract bool HasElementTypeImpl() { }

	[Address(RVA = "0x1F6CCE0", Offset = "0x1F6C0E0", Length = "0x4E")]
	[Token(Token = "0x6002357")]
	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	[Token(Token = "0x600231D")]
	protected abstract bool IsArrayImpl() { }

	[Address(RVA = "0x1F6CD30", Offset = "0x1F6C130", Length = "0x4E")]
	[Token(Token = "0x6002340")]
	public virtual bool IsAssignableFrom(Type c) { }

	[Token(Token = "0x6002320")]
	protected abstract bool IsByRefImpl() { }

	[Address(RVA = "0x1F6CD80", Offset = "0x1F6C180", Length = "0x4E")]
	[Token(Token = "0x6002360")]
	protected virtual bool IsCOMObjectImpl() { }

	[Address(RVA = "0x1F6CDD0", Offset = "0x1F6C1D0", Length = "0x4E")]
	[Token(Token = "0x6002362")]
	protected virtual bool IsContextfulImpl() { }

	[Address(RVA = "0x1F6CE20", Offset = "0x1F6C220", Length = "0x4E")]
	[Token(Token = "0x600235E")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F6CE70", Offset = "0x1F6C270", Length = "0x4E")]
	[Token(Token = "0x6002346")]
	public virtual bool IsEnumDefined(object value) { }

	[Address(RVA = "0x1F6CEC0", Offset = "0x1F6C2C0", Length = "0x4E")]
	[Token(Token = "0x6002364")]
	public virtual bool IsEquivalentTo(Type other) { }

	[Address(RVA = "0x1F6CF10", Offset = "0x1F6C310", Length = "0x4E")]
	[Token(Token = "0x6002365")]
	public virtual bool IsInstanceOfType(object o) { }

	[Address(RVA = "0x1F6CF60", Offset = "0x1F6C360", Length = "0x4E")]
	[Token(Token = "0x6002366")]
	protected virtual bool IsMarshalByRefImpl() { }

	[Token(Token = "0x6002321")]
	protected abstract bool IsPointerImpl() { }

	[Address(RVA = "0x1F6CFB0", Offset = "0x1F6C3B0", Length = "0x4E")]
	[Token(Token = "0x6002361")]
	protected virtual bool IsPrimitiveImpl() { }

	[Address(RVA = "0x1F6D000", Offset = "0x1F6C400", Length = "0x4E")]
	[Token(Token = "0x6002368")]
	public virtual bool IsSubclassOf(Type c) { }

	[Address(RVA = "0x1F6D050", Offset = "0x1F6C450", Length = "0x4E")]
	[Token(Token = "0x6002369")]
	protected virtual bool IsValueTypeImpl() { }

	[Address(RVA = "0x1F6D120", Offset = "0x1F6C520", Length = "0xC4")]
	[Token(Token = "0x600232A")]
	public virtual Type MakeArrayType(int rank) { }

	[Address(RVA = "0x1F6D0A0", Offset = "0x1F6C4A0", Length = "0x80")]
	[Token(Token = "0x6002329")]
	public virtual Type MakeArrayType() { }

	[Address(RVA = "0x1F6D1F0", Offset = "0x1F6C5F0", Length = "0x75")]
	[Token(Token = "0x600232B")]
	public virtual Type MakeByRefType() { }

	[Address(RVA = "0x1F6D270", Offset = "0x1F6C670", Length = "0x4E")]
	[Token(Token = "0x600232D")]
	public virtual Type MakeGenericType(Type[] typeArguments) { }

	[Address(RVA = "0x1F6D2C0", Offset = "0x1F6C6C0", Length = "0x75")]
	[Token(Token = "0x600232C")]
	public virtual Type MakePointerType() { }

	[Token(Token = "0x600233A")]
	public abstract string ToString() { }

}

