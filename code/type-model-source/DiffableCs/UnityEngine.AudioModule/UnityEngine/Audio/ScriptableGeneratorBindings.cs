namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptableProcessors/ScriptBindings/ScriptableProcessor.bindings.h")]
[Token(Token = "0x2000020")]
internal static class ScriptableGeneratorBindings
{

	[Address(RVA = "0x2FCA920", Offset = "0x2FC9D20", Length = "0x5BA")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x600009A")]
	internal static void InstantiateGeneratorFromObject(object generatorObjectDefinition, ref ControlHeader control, out GeneratorInstance runtimeHandle) { }

}

