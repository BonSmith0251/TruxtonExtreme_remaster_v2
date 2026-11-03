namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Camera/ScriptableRuntimeReflectionSystem.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000420")]
public static class ScriptableRuntimeReflectionSystemSettings
{
	[Token(Token = "0x4000E13")]
	private static ScriptableRuntimeReflectionSystemWrapper s_Instance; //Field offset: 0x0

	[Token(Token = "0x170004A9")]
	private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
	{
		[Address(RVA = "0x30CB5C0", Offset = "0x30CA9C0", Length = "0x4E")]
		[RequiredByNativeCode]
		[Token(Token = "0x6001F62")]
		private get { } //Length: 78
	}

	[Token(Token = "0x170004A8")]
	private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
	{
		[Address(RVA = "0x30CB610", Offset = "0x30CAA10", Length = "0x193")]
		[RequiredByNativeCode]
		[Token(Token = "0x6001F61")]
		private set { } //Length: 403
	}

	[Address(RVA = "0x30CB540", Offset = "0x30CA940", Length = "0x73")]
	[Token(Token = "0x6001F64")]
	private static ScriptableRuntimeReflectionSystemSettings() { }

	[Address(RVA = "0x30CB5C0", Offset = "0x30CA9C0", Length = "0x4E")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001F62")]
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	[Address(RVA = "0x30CB510", Offset = "0x30CA910", Length = "0x2A")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterSceneLoad (0))]
	[StaticAccessor("ScriptableRuntimeReflectionSystem", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6001F63")]
	private static void ScriptingDirtyReflectionSystemInstance() { }

	[Address(RVA = "0x30CB610", Offset = "0x30CAA10", Length = "0x193")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001F61")]
	private static void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

}

