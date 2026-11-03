namespace System.Reflection;

[Token(Token = "0x200051C")]
internal class RuntimeMethodInfo : MethodInfo, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400147B")]
	internal IntPtr mhandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400147C")]
	private string name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400147D")]
	private Type reftype; //Field offset: 0x20

	[Token(Token = "0x170004D8")]
	public virtual MethodAttributes Attributes
	{
		[Address(RVA = "0x1F64880", Offset = "0x1F63C80", Length = "0x9")]
		[Token(Token = "0x60024AE")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170004D1")]
	internal BindingFlags BindingFlags
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600248F")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170004D9")]
	public virtual CallingConventions CallingConvention
	{
		[Address(RVA = "0x1F64890", Offset = "0x1F63C90", Length = "0x28")]
		[Token(Token = "0x60024AF")]
		 get { } //Length: 40
	}

	[Token(Token = "0x170004DF")]
	public virtual bool ContainsGenericParameters
	{
		[Address(RVA = "0x1F68320", Offset = "0x1F67720", Length = "0xEA")]
		[Token(Token = "0x60024C1")]
		 get { } //Length: 234
	}

	[Token(Token = "0x170004DB")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F64900", Offset = "0x1F63D00", Length = "0x29")]
		[Token(Token = "0x60024B1")]
		 get { } //Length: 41
	}

	[Token(Token = "0x170004DE")]
	public virtual bool IsGenericMethod
	{
		[Address(RVA = "0x1F68420", Offset = "0x1F67820", Length = "0x5")]
		[Token(Token = "0x60024C0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004DD")]
	public virtual bool IsGenericMethodDefinition
	{
		[Address(RVA = "0x1F68410", Offset = "0x1F67810", Length = "0x5")]
		[Token(Token = "0x60024BF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004E0")]
	public virtual bool IsSecurityCritical
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60024C3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170004D6")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
		[Token(Token = "0x60024A5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004D7")]
	public virtual RuntimeMethodHandle MethodHandle
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60024AD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004D2")]
	public virtual Module Module
	{
		[Address(RVA = "0x1F67A90", Offset = "0x1F66E90", Length = "0x89")]
		[Token(Token = "0x6002490")]
		 get { } //Length: 137
	}

	[Token(Token = "0x170004DC")]
	public virtual string Name
	{
		[Address(RVA = "0x1F64940", Offset = "0x1F63D40", Length = "0x10")]
		[Token(Token = "0x60024B2")]
		 get { } //Length: 16
	}

	[Token(Token = "0x170004DA")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60024B0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004D3")]
	private RuntimeType ReflectedTypeInternal
	{
		[Address(RVA = "0x1F68430", Offset = "0x1F67830", Length = "0x7D")]
		[Token(Token = "0x6002491")]
		private get { } //Length: 125
	}

	[Token(Token = "0x170004D4")]
	public virtual ParameterInfo ReturnParameter
	{
		[Address(RVA = "0x1F62080", Offset = "0x1F61480", Length = "0xE3")]
		[Token(Token = "0x60024A3")]
		 get { } //Length: 227
	}

	[Token(Token = "0x170004D5")]
	public virtual Type ReturnType
	{
		[Address(RVA = "0x1F684B0", Offset = "0x1F678B0", Length = "0x29")]
		[Token(Token = "0x60024A4")]
		 get { } //Length: 41
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600249D")]
	internal RuntimeMethodInfo() { }

	[Address(RVA = "0x1F66030", Offset = "0x1F65430", Length = "0x367")]
	[Token(Token = "0x60024AC")]
	internal static void ConvertValues(Binder binder, Object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	[Address(RVA = "0x1F663A0", Offset = "0x1F657A0", Length = "0x11")]
	[Token(Token = "0x6002493")]
	public virtual Delegate CreateDelegate(Type delegateType) { }

	[Address(RVA = "0x1F663C0", Offset = "0x1F657C0", Length = "0x17")]
	[Token(Token = "0x6002494")]
	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	[Address(RVA = "0x1F663E0", Offset = "0x1F657E0", Length = "0x302")]
	[Token(Token = "0x6002492")]
	internal virtual string FormatNameAndSig(bool serialization) { }

	[Address(RVA = "0x1F64880", Offset = "0x1F63C80", Length = "0x9")]
	[Token(Token = "0x60024AE")]
	public virtual MethodAttributes get_Attributes() { }

	[Address(RVA = "0x1F684E0", Offset = "0x1F678E0", Length = "0x5")]
	[Token(Token = "0x600249F")]
	internal static RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600248F")]
	internal BindingFlags get_BindingFlags() { }

	[Address(RVA = "0x1F64890", Offset = "0x1F63C90", Length = "0x28")]
	[Token(Token = "0x60024AF")]
	public virtual CallingConventions get_CallingConvention() { }

	[Address(RVA = "0x1F68320", Offset = "0x1F67720", Length = "0xEA")]
	[Token(Token = "0x60024C1")]
	public virtual bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60024C2")]
	private static int get_core_clr_security_level() { }

	[Address(RVA = "0x1F64900", Offset = "0x1F63D00", Length = "0x29")]
	[Token(Token = "0x60024B1")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x1F68420", Offset = "0x1F67820", Length = "0x5")]
	[Token(Token = "0x60024C0")]
	public virtual bool get_IsGenericMethod() { }

	[Address(RVA = "0x1F68410", Offset = "0x1F67810", Length = "0x5")]
	[Token(Token = "0x60024BF")]
	public virtual bool get_IsGenericMethodDefinition() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60024C3")]
	public virtual bool get_IsSecurityCritical() { }

	[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
	[Token(Token = "0x60024A0")]
	internal static int get_metadata_token(RuntimeMethodInfo method) { }

	[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
	[Token(Token = "0x60024A5")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60024AD")]
	public virtual RuntimeMethodHandle get_MethodHandle() { }

	[Address(RVA = "0x1F67A90", Offset = "0x1F66E90", Length = "0x89")]
	[Token(Token = "0x6002490")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x1F684F0", Offset = "0x1F678F0", Length = "0x5")]
	[Token(Token = "0x600249E")]
	internal static string get_name(MethodBase method) { }

	[Address(RVA = "0x1F64940", Offset = "0x1F63D40", Length = "0x10")]
	[Token(Token = "0x60024B2")]
	public virtual string get_Name() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60024B0")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F68430", Offset = "0x1F67830", Length = "0x7D")]
	[Token(Token = "0x6002491")]
	private RuntimeType get_ReflectedTypeInternal() { }

	[Address(RVA = "0x1F62080", Offset = "0x1F61480", Length = "0xE3")]
	[Token(Token = "0x60024A3")]
	public virtual ParameterInfo get_ReturnParameter() { }

	[Address(RVA = "0x1F684B0", Offset = "0x1F678B0", Length = "0x29")]
	[Token(Token = "0x60024A4")]
	public virtual Type get_ReturnType() { }

	[Address(RVA = "0x1F666F0", Offset = "0x1F65AF0", Length = "0x7")]
	[Token(Token = "0x60024A1")]
	public virtual MethodInfo GetBaseDefinition() { }

	[Address(RVA = "0x1F66700", Offset = "0x1F65B00", Length = "0x7")]
	[Token(Token = "0x60024A2")]
	internal MethodInfo GetBaseMethod() { }

	[Address(RVA = "0x1F66710", Offset = "0x1F65B10", Length = "0x6B")]
	[Token(Token = "0x60024B5")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F66780", Offset = "0x1F65B80", Length = "0x59")]
	[Token(Token = "0x60024B4")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F667E0", Offset = "0x1F65BE0", Length = "0xB74")]
	[Token(Token = "0x60024B9")]
	private CustomAttributeData GetDllImportAttributeData() { }

	[Address(RVA = "0x1F67370", Offset = "0x1F66770", Length = "0x5")]
	[Token(Token = "0x60024BC")]
	public virtual Type[] GetGenericArguments() { }

	[Address(RVA = "0x1F67390", Offset = "0x1F66790", Length = "0x55")]
	[Token(Token = "0x60024BE")]
	public virtual MethodInfo GetGenericMethodDefinition() { }

	[Address(RVA = "0x1F67380", Offset = "0x1F66780", Length = "0x5")]
	[Token(Token = "0x60024BD")]
	private MethodInfo GetGenericMethodDefinition_impl() { }

	[Address(RVA = "0x1F673F0", Offset = "0x1F667F0", Length = "0x8")]
	[Token(Token = "0x600249B")]
	internal static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	[Address(RVA = "0x1F67400", Offset = "0x1F66800", Length = "0x5")]
	[Token(Token = "0x600249C")]
	private static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

	[Address(RVA = "0x1F67410", Offset = "0x1F66810", Length = "0xA")]
	[Token(Token = "0x6002499")]
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	[Address(RVA = "0x1F67420", Offset = "0x1F66820", Length = "0x8")]
	[Token(Token = "0x600249A")]
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	[Address(RVA = "0x1F640D0", Offset = "0x1F634D0", Length = "0x2D")]
	[Token(Token = "0x60024A6")]
	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	[Address(RVA = "0x1F67430", Offset = "0x1F66830", Length = "0x1C2")]
	[Token(Token = "0x6002497")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F67640", Offset = "0x1F66A40", Length = "0x89")]
	[Token(Token = "0x60024A7")]
	public virtual ParameterInfo[] GetParameters() { }

	[Address(RVA = "0x1F67610", Offset = "0x1F66A10", Length = "0x22")]
	[Token(Token = "0x60024A9")]
	internal virtual int GetParametersCount() { }

	[Address(RVA = "0x1F642B0", Offset = "0x1F636B0", Length = "0xC")]
	[Token(Token = "0x60024A8")]
	internal virtual ParameterInfo[] GetParametersInternal() { }

	[Address(RVA = "0x1F67600", Offset = "0x1F66A00", Length = "0x5")]
	[Token(Token = "0x60024B6")]
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	[Address(RVA = "0x1F678E0", Offset = "0x1F66CE0", Length = "0x1A3")]
	[Token(Token = "0x60024B7")]
	internal Object[] GetPseudoCustomAttributes() { }

	[Address(RVA = "0x1F676D0", Offset = "0x1F66AD0", Length = "0x209")]
	[Token(Token = "0x60024B8")]
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	[Address(RVA = "0x1F67A90", Offset = "0x1F66E90", Length = "0x89")]
	[Token(Token = "0x6002496")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x1F67B20", Offset = "0x1F66F20", Length = "0x5")]
	[Token(Token = "0x60024AA")]
	internal object InternalInvoke(object obj, Object[] parameters, out Exception exc) { }

	[Address(RVA = "0x1F67B30", Offset = "0x1F66F30", Length = "0x2C7")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60024AB")]
	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x1F67E00", Offset = "0x1F67200", Length = "0x6B")]
	[Token(Token = "0x60024B3")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F67E80", Offset = "0x1F67280", Length = "0x362")]
	[Token(Token = "0x60024BA")]
	public virtual MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	[Address(RVA = "0x1F67E70", Offset = "0x1F67270", Length = "0x5")]
	[Token(Token = "0x60024BB")]
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	[Address(RVA = "0x1F681F0", Offset = "0x1F675F0", Length = "0x9E")]
	[Token(Token = "0x6002498")]
	internal string SerializationToString() { }

	[Address(RVA = "0x1F68290", Offset = "0x1F67690", Length = "0x8F")]
	[Token(Token = "0x6002495")]
	public virtual string ToString() { }

}

