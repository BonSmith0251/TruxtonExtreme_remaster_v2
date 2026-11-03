namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationPosePlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000037")]
internal struct AnimationPosePlayable : IPlayable, IEquatable<AnimationPosePlayable>
{
	[Token(Token = "0x40000DB")]
	private static readonly AnimationPosePlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000DA")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x2FB35E0", Offset = "0x2FB29E0", Length = "0x139")]
	[Token(Token = "0x60002B5")]
	private static AnimationPosePlayable() { }

	[Address(RVA = "0x2FB3720", Offset = "0x2FB2B20", Length = "0xDC")]
	[Token(Token = "0x60002B2")]
	internal AnimationPosePlayable(PlayableHandle handle) { }

	[Address(RVA = "0x2FB3540", Offset = "0x2FB2940", Length = "0x9E")]
	[Token(Token = "0x60002B4")]
	public override bool Equals(AnimationPosePlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x60002B3")]
	public override PlayableHandle GetHandle() { }

}

