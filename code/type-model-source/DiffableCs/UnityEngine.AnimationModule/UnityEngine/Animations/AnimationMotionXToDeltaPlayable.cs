namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000032")]
internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable>
{
	[Token(Token = "0x40000D6")]
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D5")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x2FB1E60", Offset = "0x2FB1260", Length = "0x139")]
	[Token(Token = "0x6000296")]
	private static AnimationMotionXToDeltaPlayable() { }

	[Address(RVA = "0x2FB1FA0", Offset = "0x2FB13A0", Length = "0xDC")]
	[Token(Token = "0x600028F")]
	private AnimationMotionXToDeltaPlayable(PlayableHandle handle) { }

	[Address(RVA = "0x2FB1AA0", Offset = "0x2FB0EA0", Length = "0x243")]
	[Token(Token = "0x600028D")]
	public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph) { }

	[Address(RVA = "0x2FB1940", Offset = "0x2FB0D40", Length = "0x157")]
	[Token(Token = "0x600028E")]
	private static PlayableHandle CreateHandle(PlayableGraph graph) { }

	[Address(RVA = "0x2FB18C0", Offset = "0x2FB0CC0", Length = "0x73")]
	[NativeThrows]
	[Token(Token = "0x6000294")]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FB1870", Offset = "0x2FB0C70", Length = "0x42")]
	[Token(Token = "0x6000297")]
	private static bool CreateHandleInternal_Injected(in PlayableGraph graph, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FB1CF0", Offset = "0x2FB10F0", Length = "0x9A")]
	[Token(Token = "0x6000292")]
	public override bool Equals(AnimationMotionXToDeltaPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x6000290")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x2FB2080", Offset = "0x2FB1480", Length = "0x7F")]
	[Token(Token = "0x6000291")]
	public static Playable op_Implicit(AnimationMotionXToDeltaPlayable playable) { }

	[Address(RVA = "0x2FB1DE0", Offset = "0x2FB11E0", Length = "0x73")]
	[Token(Token = "0x6000293")]
	public void SetAbsoluteMotion(bool value) { }

	[Address(RVA = "0x2FB1D90", Offset = "0x2FB1190", Length = "0x42")]
	[NativeThrows]
	[Token(Token = "0x6000295")]
	private static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value) { }

}

