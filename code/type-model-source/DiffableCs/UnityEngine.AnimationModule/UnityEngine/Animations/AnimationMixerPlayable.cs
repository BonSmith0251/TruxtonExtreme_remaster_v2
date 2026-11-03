namespace UnityEngine.Animations;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000031")]
public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable>
{
	[Token(Token = "0x40000D4")]
	private static readonly AnimationMixerPlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D3")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x2FB15D0", Offset = "0x2FB09D0", Length = "0x139")]
	[Token(Token = "0x600028B")]
	private static AnimationMixerPlayable() { }

	[Address(RVA = "0x2FB1710", Offset = "0x2FB0B10", Length = "0xDC")]
	[Token(Token = "0x6000286")]
	internal AnimationMixerPlayable(PlayableHandle handle) { }

	[Address(RVA = "0x2FB12E0", Offset = "0x2FB06E0", Length = "0x24D")]
	[Token(Token = "0x6000284")]
	public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0) { }

	[Address(RVA = "0x2FB1180", Offset = "0x2FB0580", Length = "0x152")]
	[Token(Token = "0x6000285")]
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0) { }

	[Address(RVA = "0x2FB1100", Offset = "0x2FB0500", Length = "0x73")]
	[NativeThrows]
	[Token(Token = "0x600028A")]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FB10B0", Offset = "0x2FB04B0", Length = "0x42")]
	[Token(Token = "0x600028C")]
	private static bool CreateHandleInternal_Injected(in PlayableGraph graph, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FB1530", Offset = "0x2FB0930", Length = "0x9A")]
	[Token(Token = "0x6000289")]
	public override bool Equals(AnimationMixerPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x6000287")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x2FB17F0", Offset = "0x2FB0BF0", Length = "0x7F")]
	[Token(Token = "0x6000288")]
	public static Playable op_Implicit(AnimationMixerPlayable playable) { }

}

