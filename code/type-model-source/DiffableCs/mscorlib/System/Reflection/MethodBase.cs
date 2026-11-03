namespace System.Reflection;

[Token(Token = "0x20004ED")]
public abstract class MethodBase : MemberInfo
{

	[Token(Token = "0x17000433")]
	public abstract MethodAttributes Attributes
	{
		[Token(Token = "0x600226B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000434")]
	public override CallingConventions CallingConvention
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600226D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700043D")]
	public override bool ContainsGenericParameters
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002277")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000435")]
	public override bool IsAbstract
	{
		[Address(RVA = "0x1F61050", Offset = "0x1F60450", Length = "0x24")]
		[Token(Token = "0x600226E")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000436")]
	public override bool IsConstructor
	{
		[Address(RVA = "0x1F61080", Offset = "0x1F60480", Length = "0x95")]
		[Token(Token = "0x600226F")]
		 get { } //Length: 149
	}

	[Token(Token = "0x1700043B")]
	public override bool IsGenericMethod
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002274")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700043C")]
	public override bool IsGenericMethodDefinition
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002275")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700043A")]
	public override bool IsPublic
	{
		[Address(RVA = "0x1F61120", Offset = "0x1F60520", Length = "0x24")]
		[Token(Token = "0x6002273")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700043F")]
	public override bool IsSecurityCritical
	{
		[Address(RVA = "0x1F61150", Offset = "0x1F60550", Length = "0x27")]
		[Token(Token = "0x600227B")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000437")]
	public override bool IsSpecialName
	{
		[Address(RVA = "0x1F61180", Offset = "0x1F60580", Length = "0x24")]
		[Token(Token = "0x6002270")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000438")]
	public override bool IsStatic
	{
		[Address(RVA = "0x1F611B0", Offset = "0x1F605B0", Length = "0x21")]
		[Token(Token = "0x6002271")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000439")]
	public override bool IsVirtual
	{
		[Address(RVA = "0x1F611E0", Offset = "0x1F605E0", Length = "0x21")]
		[Token(Token = "0x6002272")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700043E")]
	public abstract RuntimeMethodHandle MethodHandle
	{
		[Token(Token = "0x600227A")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002269")]
	protected MethodBase() { }

	[Address(RVA = "0x1F608B0", Offset = "0x1F5FCB0", Length = "0x1F6")]
	[Token(Token = "0x6002286")]
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	[Address(RVA = "0x1F4B850", Offset = "0x1F4AC50", Length = "0x8")]
	[Token(Token = "0x600227C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1F60AB0", Offset = "0x1F5FEB0", Length = "0x131")]
	[Token(Token = "0x6002282")]
	internal override string FormatNameAndSig(bool serialization) { }

	[Token(Token = "0x600226B")]
	public abstract MethodAttributes get_Attributes() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600226D")]
	public override CallingConventions get_CallingConvention() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002277")]
	public override bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x1F61050", Offset = "0x1F60450", Length = "0x24")]
	[Token(Token = "0x600226E")]
	public override bool get_IsAbstract() { }

	[Address(RVA = "0x1F61080", Offset = "0x1F60480", Length = "0x95")]
	[Token(Token = "0x600226F")]
	public override bool get_IsConstructor() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002274")]
	public override bool get_IsGenericMethod() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002275")]
	public override bool get_IsGenericMethodDefinition() { }

	[Address(RVA = "0x1F61120", Offset = "0x1F60520", Length = "0x24")]
	[Token(Token = "0x6002273")]
	public override bool get_IsPublic() { }

	[Address(RVA = "0x1F61150", Offset = "0x1F60550", Length = "0x27")]
	[Token(Token = "0x600227B")]
	public override bool get_IsSecurityCritical() { }

	[Address(RVA = "0x1F61180", Offset = "0x1F60580", Length = "0x24")]
	[Token(Token = "0x6002270")]
	public override bool get_IsSpecialName() { }

	[Address(RVA = "0x1F611B0", Offset = "0x1F605B0", Length = "0x21")]
	[Token(Token = "0x6002271")]
	public override bool get_IsStatic() { }

	[Address(RVA = "0x1F611E0", Offset = "0x1F605E0", Length = "0x21")]
	[Token(Token = "0x6002272")]
	public override bool get_IsVirtual() { }

	[Token(Token = "0x600227A")]
	public abstract RuntimeMethodHandle get_MethodHandle() { }

	[Address(RVA = "0x1F60BF0", Offset = "0x1F5FFF0", Length = "0x4E")]
	[Token(Token = "0x6002276")]
	public override Type[] GetGenericArguments() { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x600227D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F60C40", Offset = "0x1F60040", Length = "0x234")]
	[Token(Token = "0x6002285")]
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	[Token(Token = "0x600226C")]
	public abstract MethodImplAttributes GetMethodImplementationFlags() { }

	[Token(Token = "0x600226A")]
	public abstract ParameterInfo[] GetParameters() { }

	[Address(RVA = "0x1F60FC0", Offset = "0x1F603C0", Length = "0x29")]
	[Token(Token = "0x6002281")]
	internal override int GetParametersCount() { }

	[Address(RVA = "0x1F60FF0", Offset = "0x1F603F0", Length = "0x14")]
	[Token(Token = "0x6002280")]
	internal override ParameterInfo[] GetParametersInternal() { }

	[Address(RVA = "0x1F60FF0", Offset = "0x1F603F0", Length = "0x14")]
	[Token(Token = "0x6002284")]
	internal override ParameterInfo[] GetParametersNoCopy() { }

	[Address(RVA = "0x1F60E80", Offset = "0x1F60280", Length = "0x133")]
	[Token(Token = "0x6002283")]
	internal override Type[] GetParameterTypes() { }

	[Token(Token = "0x6002279")]
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x1F61010", Offset = "0x1F60410", Length = "0x36")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6002278")]
	public override object Invoke(object obj, Object[] parameters) { }

	[Address(RVA = "0x1F61210", Offset = "0x1F60610", Length = "0x1E9")]
	[Token(Token = "0x600227E")]
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	[Address(RVA = "0x1F61400", Offset = "0x1F60800", Length = "0x13")]
	[Token(Token = "0x600227F")]
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

}

