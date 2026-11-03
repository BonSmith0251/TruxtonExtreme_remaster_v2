namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200002E")]
public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000CF")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x2FAD760", Offset = "0x2FACB60", Length = "0xDC")]
	[Token(Token = "0x6000269")]
	internal AnimationClipPlayable(PlayableHandle handle) { }

	[Address(RVA = "0x2FAD3B0", Offset = "0x2FAC7B0", Length = "0x1E8")]
	[Token(Token = "0x6000267")]
	public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip) { }

	[Address(RVA = "0x2FAD290", Offset = "0x2FAC690", Length = "0x11E")]
	[Token(Token = "0x6000268")]
	private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip) { }

	[Address(RVA = "0x2FAD200", Offset = "0x2FAC600", Length = "0x8A")]
	[NativeThrows]
	[Token(Token = "0x6000271")]
	private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FAD1A0", Offset = "0x2FAC5A0", Length = "0x52")]
	[Token(Token = "0x6000276")]
	private static bool CreateHandleInternal_Injected(in PlayableGraph graph, IntPtr clip, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FAD5A0", Offset = "0x2FAC9A0", Length = "0x79")]
	[Token(Token = "0x600026C")]
	public override bool Equals(AnimationClipPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x600026A")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x2FAD840", Offset = "0x2FACC40", Length = "0x3F")]
	[Token(Token = "0x600026B")]
	public static Playable op_Implicit(AnimationClipPlayable playable) { }

	[Address(RVA = "0x2FAD620", Offset = "0x2FACA20", Length = "0x42")]
	[Token(Token = "0x600026D")]
	public void SetApplyFootIK(bool value) { }

	[Address(RVA = "0x2FAD620", Offset = "0x2FACA20", Length = "0x42")]
	[NativeThrows]
	[Token(Token = "0x6000272")]
	private static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value) { }

	[Address(RVA = "0x2FAD670", Offset = "0x2FACA70", Length = "0x42")]
	[Token(Token = "0x6000270")]
	internal void SetLoopTime(bool value) { }

	[Address(RVA = "0x2FAD670", Offset = "0x2FACA70", Length = "0x42")]
	[NativeThrows]
	[Token(Token = "0x6000275")]
	private static void SetLoopTimeInternal(ref PlayableHandle handle, bool value) { }

	[Address(RVA = "0x2FAD6C0", Offset = "0x2FACAC0", Length = "0x42")]
	[Token(Token = "0x600026F")]
	internal void SetOverrideLoopTime(bool value) { }

	[Address(RVA = "0x2FAD6C0", Offset = "0x2FACAC0", Length = "0x42")]
	[NativeThrows]
	[Token(Token = "0x6000274")]
	private static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value) { }

	[Address(RVA = "0x2FAD710", Offset = "0x2FACB10", Length = "0x42")]
	[Token(Token = "0x600026E")]
	internal void SetRemoveStartOffset(bool value) { }

	[Address(RVA = "0x2FAD710", Offset = "0x2FACB10", Length = "0x42")]
	[NativeThrows]
	[Token(Token = "0x6000273")]
	private static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value) { }

}

