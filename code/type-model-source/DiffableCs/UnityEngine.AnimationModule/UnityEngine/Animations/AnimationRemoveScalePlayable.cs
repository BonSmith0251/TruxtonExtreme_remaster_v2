namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000038")]
internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable>
{
	[Token(Token = "0x40000DD")]
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000DC")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x2FB3D20", Offset = "0x2FB3120", Length = "0x139")]
	[Token(Token = "0x60002BD")]
	private static AnimationRemoveScalePlayable() { }

	[Address(RVA = "0x2FB3E60", Offset = "0x2FB3260", Length = "0xDC")]
	[Token(Token = "0x60002B8")]
	internal AnimationRemoveScalePlayable(PlayableHandle handle) { }

	[Address(RVA = "0x2FB3A30", Offset = "0x2FB2E30", Length = "0x24D")]
	[Token(Token = "0x60002B6")]
	public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount) { }

	[Address(RVA = "0x2FB38D0", Offset = "0x2FB2CD0", Length = "0x152")]
	[Token(Token = "0x60002B7")]
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount) { }

	[Address(RVA = "0x2FB3850", Offset = "0x2FB2C50", Length = "0x73")]
	[NativeThrows]
	[Token(Token = "0x60002BC")]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FB3800", Offset = "0x2FB2C00", Length = "0x42")]
	[Token(Token = "0x60002BE")]
	private static bool CreateHandleInternal_Injected(in PlayableGraph graph, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FB3C80", Offset = "0x2FB3080", Length = "0x9E")]
	[Token(Token = "0x60002BB")]
	public override bool Equals(AnimationRemoveScalePlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x60002B9")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x2FB3F40", Offset = "0x2FB3340", Length = "0x7F")]
	[Token(Token = "0x60002BA")]
	public static Playable op_Implicit(AnimationRemoveScalePlayable playable) { }

}

