namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptableProcessors/ScriptBindings/ScriptableProcessor.bindings.h")]
[Token(Token = "0x2000024")]
internal static class ScriptableProcessorBindings
{

	[Address(RVA = "0x2FCAF80", Offset = "0x2FCA380", Length = "0xC8")]
	[Token(Token = "0x600009B")]
	public static bool CheckProcessorExists(Handle handle, ControlHeader* control) { }

	[Address(RVA = "0x2FCAF30", Offset = "0x2FCA330", Length = "0x42")]
	[NativeMethod(Name = "audio::CheckProcessorExists", IsFreeFunction = True)]
	[Token(Token = "0x600009C")]
	private static bool CheckProcessorExistsInternal(Handle handle, Void* control) { }

	[Address(RVA = "0x2FCAEE0", Offset = "0x2FCA2E0", Length = "0x42")]
	[Token(Token = "0x600009D")]
	private static bool CheckProcessorExistsInternal_Injected(in Handle handle, Void* control) { }

}

