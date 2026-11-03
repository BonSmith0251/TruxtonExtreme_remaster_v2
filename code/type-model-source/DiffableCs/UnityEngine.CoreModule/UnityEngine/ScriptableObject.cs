namespace UnityEngine;

[ExtensionOfNativeClass]
[NativeClass(null)]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
[Token(Token = "0x20001BC")]
public class ScriptableObject : object
{

	[Address(RVA = "0x30715D0", Offset = "0x30709D0", Length = "0x6E")]
	[Token(Token = "0x60013F9")]
	public ScriptableObject() { }

	[Address(RVA = "0x3071240", Offset = "0x3070640", Length = "0x9")]
	[Token(Token = "0x60013FA")]
	public static ScriptableObject CreateInstance(string className) { }

	[Address(RVA = "0x3071250", Offset = "0x3070650", Length = "0x5F")]
	[Token(Token = "0x60013FB")]
	public static ScriptableObject CreateInstance(Type type) { }

	[Address(RVA = "0x8EFBC0", Offset = "0x8EEFC0", Length = "0x9F")]
	[Token(Token = "0x60013FC")]
	public static T CreateInstance() { }

	[Address(RVA = "0x3071590", Offset = "0x3070990", Length = "0x33")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x60013FD")]
	private static void CreateScriptableObject(ScriptableObject self) { }

	[Address(RVA = "0x30712F0", Offset = "0x30706F0", Length = "0x1DA")]
	[FreeFunction("Scripting::CreateScriptableObject")]
	[Token(Token = "0x60013FE")]
	private static ScriptableObject CreateScriptableObjectInstanceFromName(string className) { }

	[Address(RVA = "0x30712B0", Offset = "0x30706B0", Length = "0x33")]
	[Token(Token = "0x6001400")]
	private static IntPtr CreateScriptableObjectInstanceFromName_Injected(ref ManagedSpanWrapper className) { }

	[Address(RVA = "0x3071520", Offset = "0x3070920", Length = "0x6C")]
	[NativeMethod(Name = "Scripting::CreateScriptableObjectWithType", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x60013FF")]
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

	[Address(RVA = "0x30714D0", Offset = "0x30708D0", Length = "0x42")]
	[Token(Token = "0x6001401")]
	private static IntPtr CreateScriptableObjectInstanceFromType_Injected(Type type, bool applyDefaultsAndReset) { }

}

