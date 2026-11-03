namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200003B")]
public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable>
{
	[Token(Token = "0x40000E8")]
	private static readonly AnimatorControllerPlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E7")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x2FB4AB0", Offset = "0x2FB3EB0", Length = "0xFB")]
	[Token(Token = "0x60002C7")]
	private static AnimatorControllerPlayable() { }

	[Address(RVA = "0x2FB4BB0", Offset = "0x2FB3FB0", Length = "0x97")]
	[Token(Token = "0x60002C3")]
	internal AnimatorControllerPlayable(PlayableHandle handle) { }

	[Address(RVA = "0x2FB48C0", Offset = "0x2FB3CC0", Length = "0x9A")]
	[Token(Token = "0x60002C6")]
	public override bool Equals(AnimatorControllerPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x60002C4")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x2FB4960", Offset = "0x2FB3D60", Length = "0x148")]
	[Token(Token = "0x60002C5")]
	public void SetHandle(PlayableHandle handle) { }

}

