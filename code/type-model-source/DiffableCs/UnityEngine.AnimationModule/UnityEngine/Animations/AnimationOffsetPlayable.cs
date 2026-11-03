namespace UnityEngine.Animations;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationOffsetPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000033")]
internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable>
{
	[Token(Token = "0x40000D8")]
	private static readonly AnimationOffsetPlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D7")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x2FB26D0", Offset = "0x2FB1AD0", Length = "0x139")]
	[Token(Token = "0x600029F")]
	private static AnimationOffsetPlayable() { }

	[Address(RVA = "0x2FB2810", Offset = "0x2FB1C10", Length = "0xDC")]
	[Token(Token = "0x600029A")]
	internal AnimationOffsetPlayable(PlayableHandle handle) { }

	[Address(RVA = "0x2FB23A0", Offset = "0x2FB17A0", Length = "0x284")]
	[Token(Token = "0x6000298")]
	public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	[Address(RVA = "0x2FB2210", Offset = "0x2FB1610", Length = "0x189")]
	[Token(Token = "0x6000299")]
	private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	[Address(RVA = "0x2FB2170", Offset = "0x2FB1570", Length = "0x93")]
	[NativeThrows]
	[Token(Token = "0x600029E")]
	private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FB2100", Offset = "0x2FB1500", Length = "0x62")]
	[Token(Token = "0x60002A0")]
	private static bool CreateHandleInternal_Injected(in PlayableGraph graph, in Vector3 position, in Quaternion rotation, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FB2630", Offset = "0x2FB1A30", Length = "0x9E")]
	[Token(Token = "0x600029D")]
	public override bool Equals(AnimationOffsetPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x600029B")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x2FB28F0", Offset = "0x2FB1CF0", Length = "0x7F")]
	[Token(Token = "0x600029C")]
	public static Playable op_Implicit(AnimationOffsetPlayable playable) { }

}

