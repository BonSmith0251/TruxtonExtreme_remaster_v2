namespace UnityEngine;

[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
[Token(Token = "0x200017D")]
public sealed class Resources
{

	[Address(RVA = "0x768750", Offset = "0x767B50", Length = "0x135")]
	[Token(Token = "0x6001244")]
	internal static T[] ConvertObjects(Object[] rawObjects) { }

	[Address(RVA = "0x3070B80", Offset = "0x306FF80", Length = "0x33")]
	[FreeFunction("Resources_Bindings::DoesObjectWithInstanceIDExist", IsThreadSafe = True)]
	[Token(Token = "0x6001253")]
	public static bool EntityIdIsValid(EntityId entityId) { }

	[Address(RVA = "0x3070B40", Offset = "0x306FF40", Length = "0x33")]
	[Token(Token = "0x6001257")]
	private static bool EntityIdIsValid_Injected(in EntityId entityId) { }

	[Address(RVA = "0x3070C00", Offset = "0x3070000", Length = "0x5E")]
	[FreeFunction("Resources_Bindings::InstanceIDToObject")]
	[Token(Token = "0x6001252")]
	public static object EntityIdToObject(EntityId entityId) { }

	[Address(RVA = "0x3070BC0", Offset = "0x306FFC0", Length = "0x33")]
	[Token(Token = "0x6001256")]
	private static IntPtr EntityIdToObject_Injected(in EntityId entityId) { }

	[Address(RVA = "0x306AB50", Offset = "0x3069F50", Length = "0x6A")]
	[Token(Token = "0x6001245")]
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[Address(RVA = "0x8EF190", Offset = "0x8EE590", Length = "0x63")]
	[Token(Token = "0x6001246")]
	public static T[] FindObjectsOfTypeAll() { }

	[Address(RVA = "0x8EF200", Offset = "0x8EE600", Length = "0xA9")]
	[Token(Token = "0x600124F")]
	public static T GetBuiltinResource(string path) { }

	[Address(RVA = "0x3070CB0", Offset = "0x30700B0", Length = "0x1FE")]
	[FreeFunction("GetScriptingBuiltinResource", ThrowsException = True)]
	[Token(Token = "0x600124E")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static object GetBuiltinResource(Type type, string path) { }

	[Address(RVA = "0x3070C60", Offset = "0x3070060", Length = "0x42")]
	[Token(Token = "0x6001254")]
	private static IntPtr GetBuiltinResource_Injected(Type type, ref ManagedSpanWrapper path) { }

	[Address(RVA = "0x3071030", Offset = "0x3070430", Length = "0x67")]
	[Token(Token = "0x6001247")]
	public static object Load(string path) { }

	[Address(RVA = "0x3070FB0", Offset = "0x30703B0", Length = "0x79")]
	[Token(Token = "0x6001249")]
	public static object Load(string path, Type systemTypeInstance) { }

	[Address(RVA = "0x8EF390", Offset = "0x8EE790", Length = "0xA9")]
	[Token(Token = "0x6001248")]
	public static T Load(string path) { }

	[Address(RVA = "0x3070EB0", Offset = "0x30702B0", Length = "0x79")]
	[Token(Token = "0x600124C")]
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	[Address(RVA = "0x8EF2B0", Offset = "0x8EE6B0", Length = "0x77")]
	[Token(Token = "0x600124D")]
	public static T[] LoadAll(string path) { }

	[Address(RVA = "0x3070F30", Offset = "0x3070330", Length = "0x79")]
	[Token(Token = "0x600124B")]
	public static ResourceRequest LoadAsync(string path, Type type) { }

	[Address(RVA = "0x8EF330", Offset = "0x8EE730", Length = "0x5D")]
	[Token(Token = "0x600124A")]
	public static ResourceRequest LoadAsync(string path) { }

	[Address(RVA = "0x30710A0", Offset = "0x30704A0", Length = "0x6A")]
	[Token(Token = "0x6001250")]
	public static void UnloadAsset(object assetToUnload) { }

	[Address(RVA = "0x3071140", Offset = "0x3070540", Length = "0xA8")]
	[FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
	[Token(Token = "0x6001251")]
	public static AsyncOperation UnloadUnusedAssets() { }

	[Address(RVA = "0x3071110", Offset = "0x3070510", Length = "0x2A")]
	[Token(Token = "0x6001255")]
	private static IntPtr UnloadUnusedAssets_Injected() { }

}

