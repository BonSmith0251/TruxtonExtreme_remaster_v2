namespace System;

[ComVisible(True)]
[Token(Token = "0x20001C7")]
public struct RuntimeTypeHandle : ISerializable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000723")]
	private IntPtr value; //Field offset: 0x0

	[Token(Token = "0x17000168")]
	public IntPtr Value
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600101A")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6001017")]
	internal RuntimeTypeHandle(IntPtr val) { }

	[Address(RVA = "0x2089250", Offset = "0x2088650", Length = "0x1A")]
	[Token(Token = "0x6001018")]
	internal RuntimeTypeHandle(RuntimeType type) { }

	[Address(RVA = "0x20890B0", Offset = "0x20884B0", Length = "0x191")]
	[Token(Token = "0x6001019")]
	private RuntimeTypeHandle(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2088840", Offset = "0x2087C40", Length = "0xE")]
	[Token(Token = "0x6001039")]
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	[Address(RVA = "0x2088850", Offset = "0x2087C50", Length = "0xE1")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600101C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600101D")]
	public bool Equals(RuntimeTypeHandle handle) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x600101A")]
	public IntPtr get_Value() { }

	[Address(RVA = "0x2088940", Offset = "0x2087D40", Length = "0x5")]
	[Token(Token = "0x6001033")]
	internal static int GetArrayRank(RuntimeType type) { }

	[Address(RVA = "0x2088950", Offset = "0x2087D50", Length = "0x5")]
	[Token(Token = "0x6001034")]
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	[Address(RVA = "0x2088960", Offset = "0x2087D60", Length = "0x5")]
	[Token(Token = "0x600101F")]
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	[Address(RVA = "0x2088970", Offset = "0x2087D70", Length = "0x5")]
	[Token(Token = "0x6001038")]
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	[Address(RVA = "0x2088980", Offset = "0x2087D80", Length = "0x5")]
	[Token(Token = "0x600102A")]
	internal static CorElementType GetCorElementType(RuntimeType type) { }

	[Address(RVA = "0x2088990", Offset = "0x2087D90", Length = "0x5")]
	[Token(Token = "0x6001035")]
	internal static RuntimeType GetElementType(RuntimeType type) { }

	[Address(RVA = "0x20889A0", Offset = "0x2087DA0", Length = "0x5")]
	[Token(Token = "0x600103C")]
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

	[Address(RVA = "0x20889B0", Offset = "0x2087DB0", Length = "0x5")]
	[Token(Token = "0x6001023")]
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	[Address(RVA = "0x20889B0", Offset = "0x2087DB0", Length = "0x5")]
	[Token(Token = "0x6001022")]
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x600101E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x20889C0", Offset = "0x2087DC0", Length = "0x5")]
	[Token(Token = "0x6001020")]
	private static int GetMetadataToken(RuntimeType type) { }

	[Address(RVA = "0x20889D0", Offset = "0x2087DD0", Length = "0x5")]
	[Token(Token = "0x6001036")]
	internal static RuntimeModule GetModule(RuntimeType type) { }

	[Address(RVA = "0x20889E0", Offset = "0x2087DE0", Length = "0x173")]
	[Token(Token = "0x600101B")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20889C0", Offset = "0x2087DC0", Length = "0x5")]
	[Token(Token = "0x6001021")]
	internal static int GetToken(RuntimeType type) { }

	[Address(RVA = "0x2088B60", Offset = "0x2087F60", Length = "0x33D")]
	[Token(Token = "0x6001040")]
	internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName) { }

	[Address(RVA = "0x2088EA0", Offset = "0x20882A0", Length = "0x28")]
	[Token(Token = "0x6001029")]
	internal static bool HasElementType(RuntimeType type) { }

	[Address(RVA = "0x2088ED0", Offset = "0x20882D0", Length = "0x5")]
	[Token(Token = "0x600102B")]
	internal static bool HasInstantiation(RuntimeType type) { }

	[Address(RVA = "0x2088EE0", Offset = "0x20882E0", Length = "0x5")]
	[Token(Token = "0x600102E")]
	internal static bool HasReferences(RuntimeType type) { }

	[Address(RVA = "0x2089270", Offset = "0x2088670", Length = "0x17")]
	[Token(Token = "0x600103F")]
	private static RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly) { }

	[Address(RVA = "0x2089290", Offset = "0x2088690", Length = "0x5")]
	[Token(Token = "0x600103E")]
	internal static bool is_subclass_of(IntPtr childType, IntPtr baseType) { }

	[Address(RVA = "0x2088EF0", Offset = "0x20882F0", Length = "0x1E")]
	[Token(Token = "0x6001027")]
	internal static bool IsArray(RuntimeType type) { }

	[Address(RVA = "0x2088F10", Offset = "0x2088310", Length = "0x13")]
	[Token(Token = "0x6001025")]
	internal static bool IsByRef(RuntimeType type) { }

	[Address(RVA = "0x1E5F020", Offset = "0x1E5E420", Length = "0x5")]
	[Token(Token = "0x600102C")]
	internal static bool IsComObject(RuntimeType type) { }

	[Address(RVA = "0x2088F30", Offset = "0x2088330", Length = "0xC")]
	[Token(Token = "0x600102F")]
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	[Address(RVA = "0x2088F40", Offset = "0x2088340", Length = "0x7D")]
	[Token(Token = "0x6001030")]
	internal static bool IsContextful(RuntimeType type) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001031")]
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	[Address(RVA = "0x2088FC0", Offset = "0x20883C0", Length = "0x5")]
	[Token(Token = "0x600103B")]
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	[Address(RVA = "0x2088FD0", Offset = "0x20883D0", Length = "0x5")]
	[Token(Token = "0x6001037")]
	internal static bool IsGenericVariable(RuntimeType type) { }

	[Address(RVA = "0x2088FE0", Offset = "0x20883E0", Length = "0x5")]
	[Token(Token = "0x600102D")]
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	[Address(RVA = "0x2088FF0", Offset = "0x20883F0", Length = "0x1F")]
	[Token(Token = "0x6001032")]
	internal static bool IsInterface(RuntimeType type) { }

	[Address(RVA = "0x2089010", Offset = "0x2088410", Length = "0x13")]
	[Token(Token = "0x6001026")]
	internal static bool IsPointer(RuntimeType type) { }

	[Address(RVA = "0x2089030", Offset = "0x2088430", Length = "0x26")]
	[Token(Token = "0x6001024")]
	internal static bool IsPrimitive(RuntimeType type) { }

	[Address(RVA = "0x2089060", Offset = "0x2088460", Length = "0x24")]
	[Token(Token = "0x600103D")]
	internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType) { }

	[Address(RVA = "0x2089090", Offset = "0x2088490", Length = "0x13")]
	[Token(Token = "0x6001028")]
	internal static bool IsSzArray(RuntimeType type) { }

	[Address(RVA = "0x20892A0", Offset = "0x20886A0", Length = "0x5")]
	[Token(Token = "0x600103A")]
	private static bool type_is_assignable_from(Type a, Type b) { }

}

