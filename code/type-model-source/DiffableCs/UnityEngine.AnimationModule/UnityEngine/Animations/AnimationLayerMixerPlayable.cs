namespace UnityEngine.Animations;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000030")]
public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable>
{
	[Token(Token = "0x40000D2")]
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D1")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x2FB0E60", Offset = "0x2FB0260", Length = "0x8D")]
	[Token(Token = "0x6000281")]
	private static AnimationLayerMixerPlayable() { }

	[Address(RVA = "0x2FB0EF0", Offset = "0x2FB02F0", Length = "0x133")]
	[Token(Token = "0x6000279")]
	internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true) { }

	[Address(RVA = "0x2FB0850", Offset = "0x2FAFC50", Length = "0x1BD")]
	[Token(Token = "0x6000277")]
	public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization) { }

	[Address(RVA = "0x2FB06F0", Offset = "0x2FAFAF0", Length = "0x152")]
	[Token(Token = "0x6000278")]
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0) { }

	[Address(RVA = "0x2FB0670", Offset = "0x2FAFA70", Length = "0x73")]
	[NativeThrows]
	[Token(Token = "0x600027E")]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FB0620", Offset = "0x2FAFA20", Length = "0x42")]
	[Token(Token = "0x6000282")]
	private static bool CreateHandleInternal_Injected(in PlayableGraph graph, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FB0A10", Offset = "0x2FAFE10", Length = "0x9A")]
	[Token(Token = "0x600027C")]
	public override bool Equals(AnimationLayerMixerPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x600027A")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x2FB1030", Offset = "0x2FB0430", Length = "0x7F")]
	[Token(Token = "0x600027B")]
	public static Playable op_Implicit(AnimationLayerMixerPlayable playable) { }

	[Address(RVA = "0x2FB0BB0", Offset = "0x2FAFFB0", Length = "0x255")]
	[Token(Token = "0x600027D")]
	public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask) { }

	[Address(RVA = "0x2FB0B00", Offset = "0x2FAFF00", Length = "0xA9")]
	[NativeThrows]
	[Token(Token = "0x6000280")]
	private static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask) { }

	[Address(RVA = "0x2FB0AB0", Offset = "0x2FAFEB0", Length = "0x50")]
	[Token(Token = "0x6000283")]
	private static void SetLayerMaskFromAvatarMaskInternal_Injected(ref PlayableHandle handle, uint layerIndex, IntPtr mask) { }

	[Address(RVA = "0x2FB0E10", Offset = "0x2FB0210", Length = "0x42")]
	[NativeThrows]
	[Token(Token = "0x600027F")]
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

}

