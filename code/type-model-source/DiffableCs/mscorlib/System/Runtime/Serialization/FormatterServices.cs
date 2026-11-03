namespace System.Runtime.Serialization;

[ComVisible(True)]
[Token(Token = "0x20003E5")]
public static class FormatterServices
{
	[CompilerGenerated]
	[Token(Token = "0x20003E6")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F40")]
		public Type type; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001DD6")]
		public <>c__DisplayClass9_0() { }

		[Address(RVA = "0x1F159C0", Offset = "0x1F14DC0", Length = "0xA3")]
		[Token(Token = "0x6001DD7")]
		internal MemberInfo[] <GetSerializableMembers>b__0(MemberHolder _) { }

	}

	[Token(Token = "0x4000F3B")]
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; //Field offset: 0x0
	[Token(Token = "0x4000F3C")]
	private static bool unsafeTypeForwardersIsEnabled; //Field offset: 0x8
	[Token(Token = "0x4000F3D")]
	private static bool unsafeTypeForwardersIsEnabledInitialized; //Field offset: 0x9
	[Token(Token = "0x4000F3E")]
	private static readonly Type[] advancedTypes; //Field offset: 0x10
	[Token(Token = "0x4000F3F")]
	private static Binder s_binder; //Field offset: 0x18

	[Address(RVA = "0x1F04A70", Offset = "0x1F03E70", Length = "0x1C5")]
	[Token(Token = "0x6001DC2")]
	private static FormatterServices() { }

	[Address(RVA = "0x1F02430", Offset = "0x1F01830", Length = "0x2B")]
	[Token(Token = "0x6001DC4")]
	private static bool CheckSerializable(RuntimeType type) { }

	[Address(RVA = "0x1F02460", Offset = "0x1F01860", Length = "0x186")]
	[Token(Token = "0x6001DD2")]
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	[Address(RVA = "0x1F02C00", Offset = "0x1F02000", Length = "0x7E")]
	[Token(Token = "0x6001DD3")]
	internal static string GetClrTypeFullName(Type type) { }

	[Address(RVA = "0x1F025F0", Offset = "0x1F019F0", Length = "0x223")]
	[Token(Token = "0x6001DD4")]
	private static string GetClrTypeFullNameForArray(Type type) { }

	[Address(RVA = "0x1F02820", Offset = "0x1F01C20", Length = "0x3D6")]
	[Token(Token = "0x6001DD5")]
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001DCA")]
	private static bool GetEnableUnsafeTypeForwarders() { }

	[Address(RVA = "0x1F02C80", Offset = "0x1F02080", Length = "0x430")]
	[Token(Token = "0x6001DCE")]
	public static Object[] GetObjectData(object obj, MemberInfo[] members) { }

	[Address(RVA = "0x1F030C0", Offset = "0x1F024C0", Length = "0x437")]
	[Token(Token = "0x6001DC6")]
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	[Address(RVA = "0x1F03500", Offset = "0x1F02900", Length = "0x1BC")]
	[Token(Token = "0x6001DC3")]
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	[Address(RVA = "0x1F036C0", Offset = "0x1F02AC0", Length = "0x2B5")]
	[Token(Token = "0x6001DC7")]
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	[Address(RVA = "0x1F03980", Offset = "0x1F02D80", Length = "0xA1")]
	[Token(Token = "0x6001DCF")]
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	[Address(RVA = "0x1F03A30", Offset = "0x1F02E30", Length = "0x1C3")]
	[Token(Token = "0x6001DC8")]
	public static object GetUninitializedObject(Type type) { }

	[Address(RVA = "0x1F03C00", Offset = "0x1F03000", Length = "0x755")]
	[Token(Token = "0x6001DC5")]
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	[Address(RVA = "0x1F043C0", Offset = "0x1F037C0", Length = "0x7")]
	[Token(Token = "0x6001DD0")]
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	[Address(RVA = "0x1F04360", Offset = "0x1F03760", Length = "0x53")]
	[Token(Token = "0x6001DD1")]
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	[Address(RVA = "0x1EF6ED0", Offset = "0x1EF62D0", Length = "0x5")]
	[Token(Token = "0x6001DC9")]
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	[Address(RVA = "0x1F043D0", Offset = "0x1F037D0", Length = "0x394")]
	[Token(Token = "0x6001DCD")]
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, Object[] data) { }

	[Address(RVA = "0x1F04770", Offset = "0x1F03B70", Length = "0x222")]
	[Token(Token = "0x6001DCC")]
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	[Address(RVA = "0x1F049A0", Offset = "0x1F03DA0", Length = "0xC6")]
	[Token(Token = "0x6001DCB")]
	internal static bool UnsafeTypeForwardersIsEnabled() { }

}

