namespace UnityEngine.Animations;

[Extension]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableGraphExtensions.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationPlayableGraphExtensionsBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000035")]
internal static class AnimationPlayableGraphExtensions
{

	[Address(RVA = "0x2FB2C30", Offset = "0x2FB2030", Length = "0x19F")]
	[NativeThrows]
	[Token(Token = "0x60002A4")]
	internal static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle) { }

	[Address(RVA = "0x2FB2BD0", Offset = "0x2FB1FD0", Length = "0x52")]
	[Token(Token = "0x60002A5")]
	private static bool InternalCreateAnimationOutput_Injected(ref PlayableGraph graph, ref ManagedSpanWrapper name, out PlayableOutputHandle handle) { }

}

