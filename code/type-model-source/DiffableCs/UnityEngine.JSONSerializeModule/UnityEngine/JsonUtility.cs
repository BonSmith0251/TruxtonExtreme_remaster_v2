namespace UnityEngine;

[NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
[Token(Token = "0x2000002")]
public static class JsonUtility
{

	[Address(RVA = "0x8506A0", Offset = "0x84FAA0", Length = "0xA9")]
	[Token(Token = "0x6000005")]
	public static T FromJson(string json) { }

	[Address(RVA = "0x3113B50", Offset = "0x3112F50", Length = "0x1CB")]
	[Token(Token = "0x6000006")]
	public static object FromJson(string json, Type type) { }

	[Address(RVA = "0x31139A0", Offset = "0x3112DA0", Length = "0x1A6")]
	[FreeFunction("FromJsonInternal", True, ThrowsException = True)]
	[ThreadSafe]
	[Token(Token = "0x6000002")]
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	[Address(RVA = "0x3113940", Offset = "0x3112D40", Length = "0x52")]
	[Token(Token = "0x6000008")]
	private static object FromJsonInternal_Injected(ref ManagedSpanWrapper json, object objectToOverwrite, Type type) { }

	[Address(RVA = "0x3113E90", Offset = "0x3113290", Length = "0x14D")]
	[Token(Token = "0x6000003")]
	public static string ToJson(object obj) { }

	[Address(RVA = "0x3113FE0", Offset = "0x31133E0", Length = "0x15F")]
	[Token(Token = "0x6000004")]
	public static string ToJson(object obj, bool prettyPrint) { }

	[Address(RVA = "0x3113D80", Offset = "0x3113180", Length = "0x101")]
	[FreeFunction("ToJsonInternal", True)]
	[ThreadSafe]
	[Token(Token = "0x6000001")]
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

	[Address(RVA = "0x3113D20", Offset = "0x3113120", Length = "0x53")]
	[Token(Token = "0x6000007")]
	private static void ToJsonInternal_Injected(object obj, bool prettyPrint, out ManagedSpanWrapper ret) { }

}

