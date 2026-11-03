namespace System.Reflection;

[Token(Token = "0x200051B")]
internal struct MonoMethodInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001476")]
	private Type parent; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001477")]
	private Type ret; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001478")]
	internal MethodAttributes attrs; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001479")]
	internal MethodImplAttributes iattrs; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400147A")]
	private CallingConventions callconv; //Field offset: 0x18

	[Address(RVA = "0x1F61FA0", Offset = "0x1F613A0", Length = "0x5")]
	[Token(Token = "0x6002484")]
	private static int get_method_attributes(IntPtr handle) { }

	[Address(RVA = "0x1F621A0", Offset = "0x1F615A0", Length = "0x5")]
	[Token(Token = "0x6002483")]
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	[Address(RVA = "0x1F62070", Offset = "0x1F61470", Length = "0x5")]
	[Token(Token = "0x600248B")]
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	[Address(RVA = "0x1EF3600", Offset = "0x1EF2A00", Length = "0x5")]
	[Token(Token = "0x600248D")]
	private static MarshalAsAttribute get_retval_marshal(IntPtr handle) { }

	[Address(RVA = "0x1F61FA0", Offset = "0x1F613A0", Length = "0x5")]
	[Token(Token = "0x6002488")]
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	[Address(RVA = "0x1F61FB0", Offset = "0x1F613B0", Length = "0x24")]
	[Token(Token = "0x6002489")]
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	[Address(RVA = "0x1F61FE0", Offset = "0x1F613E0", Length = "0x25")]
	[Token(Token = "0x6002486")]
	internal static Type GetDeclaringType(IntPtr handle) { }

	[Address(RVA = "0x1F62010", Offset = "0x1F61410", Length = "0x29")]
	[Token(Token = "0x600248A")]
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	[Address(RVA = "0x1F62040", Offset = "0x1F61440", Length = "0x2A")]
	[Token(Token = "0x6002485")]
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	[Address(RVA = "0x1F62070", Offset = "0x1F61470", Length = "0x5")]
	[Token(Token = "0x600248C")]
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

	[Address(RVA = "0x1F62080", Offset = "0x1F61480", Length = "0xE3")]
	[Token(Token = "0x600248E")]
	internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method) { }

	[Address(RVA = "0x1F62170", Offset = "0x1F61570", Length = "0x25")]
	[Token(Token = "0x6002487")]
	internal static Type GetReturnType(IntPtr handle) { }

}

