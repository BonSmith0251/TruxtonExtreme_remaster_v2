namespace UnityEngine.Animations;

[Extension]
[NativeHeader("Modules/Animation/AnimationClip.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationPlayableExtensions.h")]
[Token(Token = "0x2000034")]
public static class AnimationPlayableExtensions
{

	[Address(RVA = "0x7686B0", Offset = "0x767AB0", Length = "0x94")]
	[Extension]
	[Token(Token = "0x60002A1")]
	public static void SetAnimatedProperties(U playable, AnimationClip clip) { }

	[Address(RVA = "0x2FB2B50", Offset = "0x2FB1F50", Length = "0x7A")]
	[NativeThrows]
	[Token(Token = "0x60002A2")]
	internal static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties) { }

	[Address(RVA = "0x2FB2B00", Offset = "0x2FB1F00", Length = "0x42")]
	[Token(Token = "0x60002A3")]
	private static void SetAnimatedPropertiesInternal_Injected(ref PlayableHandle playable, IntPtr animatedProperties) { }

}

