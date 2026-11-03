namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(True)]
[Token(Token = "0x200050F")]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly
{
	[Token(Token = "0x2000510")]
	public class ResolveEventHolder
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60023FF")]
		public ResolveEventHolder() { }

	}


	[Token(Token = "0x170004AD")]
	public override string CodeBase
	{
		[Address(RVA = "0x1F4C010", Offset = "0x1F4B410", Length = "0x3E")]
		[Token(Token = "0x60023D9")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170004AE")]
	public override string FullName
	{
		[Address(RVA = "0x1F4C050", Offset = "0x1F4B450", Length = "0x3E")]
		[Token(Token = "0x60023DA")]
		 get { } //Length: 62
	}

	[MonoTODO]
	[Token(Token = "0x170004B1")]
	public bool IsFullyTrusted
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60023F7")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170004B0")]
	public override string Location
	{
		[Address(RVA = "0x1F4C090", Offset = "0x1F4B490", Length = "0x3E")]
		[Token(Token = "0x60023DC")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170004AF")]
	internal override IntPtr MonoAssembly
	{
		[Address(RVA = "0x1F4C0D0", Offset = "0x1F4B4D0", Length = "0x3E")]
		[Token(Token = "0x60023DB")]
		internal get { } //Length: 62
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60023FE")]
	public Assembly() { }

	[Address(RVA = "0x1F4B7F0", Offset = "0x1F4ABF0", Length = "0x58")]
	[Token(Token = "0x60023F6")]
	private static Exception CreateNIE() { }

	[Address(RVA = "0x1F4B850", Offset = "0x1F4AC50", Length = "0x8")]
	[Token(Token = "0x60023F5")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1F4C010", Offset = "0x1F4B410", Length = "0x3E")]
	[Token(Token = "0x60023D9")]
	public override string get_CodeBase() { }

	[Address(RVA = "0x1F4C050", Offset = "0x1F4B450", Length = "0x3E")]
	[Token(Token = "0x60023DA")]
	public override string get_FullName() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60023F7")]
	public bool get_IsFullyTrusted() { }

	[Address(RVA = "0x1F4C090", Offset = "0x1F4B490", Length = "0x3E")]
	[Token(Token = "0x60023DC")]
	public override string get_Location() { }

	[Address(RVA = "0x1F4C0D0", Offset = "0x1F4B4D0", Length = "0x3E")]
	[Token(Token = "0x60023DB")]
	internal override IntPtr get_MonoAssembly() { }

	[Address(RVA = "0x1F4B860", Offset = "0x1F4AC60", Length = "0x9E")]
	[Token(Token = "0x60023E8")]
	public static Assembly GetAssembly(Type type) { }

	[Address(RVA = "0x1F4B900", Offset = "0x1F4AD00", Length = "0x5")]
	[Token(Token = "0x60023F1")]
	public static Assembly GetCallingAssembly() { }

	[Address(RVA = "0x1F4B950", Offset = "0x1F4AD50", Length = "0x3E")]
	[Token(Token = "0x60023DF")]
	public override Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F4B910", Offset = "0x1F4AD10", Length = "0x3E")]
	[Token(Token = "0x60023E0")]
	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F4B990", Offset = "0x1F4AD90", Length = "0x30")]
	[Token(Token = "0x60023F0")]
	public static Assembly GetExecutingAssembly() { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x60023F4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F4B9C0", Offset = "0x1F4ADC0", Length = "0x27")]
	[Token(Token = "0x60023F9")]
	public override Module GetModule(string name) { }

	[Address(RVA = "0x1F4BA30", Offset = "0x1F4AE30", Length = "0x27")]
	[Token(Token = "0x60023FB")]
	public override Module[] GetModules(bool getResourceModules) { }

	[Address(RVA = "0x1F4B9F0", Offset = "0x1F4ADF0", Length = "0x3E")]
	[Token(Token = "0x60023EF")]
	internal override Module[] GetModulesInternal() { }

	[Address(RVA = "0x1F4BA60", Offset = "0x1F4AE60", Length = "0x3E")]
	[Token(Token = "0x60023E5")]
	public override AssemblyName GetName(bool copiedName) { }

	[Address(RVA = "0x1EF5810", Offset = "0x1EF4C10", Length = "0x16")]
	[Token(Token = "0x60023E6")]
	public override AssemblyName GetName() { }

	[Address(RVA = "0x1F4BAA0", Offset = "0x1F4AEA0", Length = "0x3E")]
	[Token(Token = "0x60023DD")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F4BAE0", Offset = "0x1F4AEE0", Length = "0x221")]
	[Token(Token = "0x60023F3")]
	internal static AssemblyName[] GetReferencedAssemblies(Assembly module) { }

	[Address(RVA = "0x1F4BD10", Offset = "0x1F4B110", Length = "0x27")]
	[Token(Token = "0x60023FA")]
	public override AssemblyName[] GetReferencedAssemblies() { }

	[Address(RVA = "0x1F4BD70", Offset = "0x1F4B170", Length = "0x27")]
	[Token(Token = "0x60023F8")]
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	[Address(RVA = "0x1F4BD40", Offset = "0x1F4B140", Length = "0x28")]
	[Token(Token = "0x60023E3")]
	public override Type GetType(string name) { }

	[Address(RVA = "0x1F4BDB0", Offset = "0x1F4B1B0", Length = "0x16")]
	[Token(Token = "0x60023E2")]
	public override Type[] GetTypes() { }

	[Address(RVA = "0x1F4BDA0", Offset = "0x1F4B1A0", Length = "0x5")]
	[Token(Token = "0x60023E1")]
	internal override Type[] GetTypes(bool exportedOnly) { }

	[Address(RVA = "0x1F4BDD0", Offset = "0x1F4B1D0", Length = "0x5")]
	[Token(Token = "0x60023F2")]
	internal static IntPtr InternalGetReferencedAssemblies(Assembly module) { }

	[Address(RVA = "0x1F4BDE0", Offset = "0x1F4B1E0", Length = "0xE")]
	[Token(Token = "0x60023E4")]
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	[Address(RVA = "0x1F4BDF0", Offset = "0x1F4B1F0", Length = "0x3E")]
	[Token(Token = "0x60023DE")]
	public override bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F4BF80", Offset = "0x1F4B380", Length = "0x2D")]
	[Token(Token = "0x60023E9")]
	public static Assembly Load(string assemblyString) { }

	[Address(RVA = "0x1F4C110", Offset = "0x1F4B510", Length = "0x5")]
	[Token(Token = "0x60023EC")]
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[Address(RVA = "0x1F4BF20", Offset = "0x1F4B320", Length = "0x54")]
	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	[Token(Token = "0x60023ED")]
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	[Address(RVA = "0x1F4BE90", Offset = "0x1F4B290", Length = "0x8B")]
	[Token(Token = "0x60023EE")]
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	[Address(RVA = "0x1F4BE30", Offset = "0x1F4B230", Length = "0x56")]
	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	[Token(Token = "0x60023EB")]
	public static Assembly LoadWithPartialName(string partialName) { }

	[Address(RVA = "0x1F4C120", Offset = "0x1F4B520", Length = "0x51")]
	[Token(Token = "0x60023FC")]
	public static bool op_Equality(Assembly left, Assembly right) { }

	[Address(RVA = "0x1F4C180", Offset = "0x1F4B580", Length = "0x56")]
	[Token(Token = "0x60023FD")]
	public static bool op_Inequality(Assembly left, Assembly right) { }

	[Address(RVA = "0x1F4BFB0", Offset = "0x1F4B3B0", Length = "0x4C")]
	[Token(Token = "0x60023EA")]
	public static Assembly ReflectionOnlyLoad(string assemblyString) { }

	[Address(RVA = "0x1F4C000", Offset = "0x1F4B400", Length = "0x7")]
	[Token(Token = "0x60023E7")]
	public virtual string ToString() { }

}

