namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableGraphExtensions.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[StaticAccessor("AudioPlayableGraphExtensionsBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200002C")]
internal static class AudioPlayableGraphExtensions
{

	[Address(RVA = "0x2FC80F0", Offset = "0x2FC74F0", Length = "0x19F")]
	[NativeThrows]
	[Token(Token = "0x60000C2")]
	internal static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle) { }

	[Address(RVA = "0x2FC8090", Offset = "0x2FC7490", Length = "0x52")]
	[Token(Token = "0x60000C3")]
	private static bool InternalCreateAudioOutput_Injected(ref PlayableGraph graph, ref ManagedSpanWrapper name, out PlayableOutputHandle handle) { }

}

