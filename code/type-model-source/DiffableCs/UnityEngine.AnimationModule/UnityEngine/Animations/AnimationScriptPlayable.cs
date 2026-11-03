namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000039")]
public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable>
{
	[Token(Token = "0x40000DF")]
	private static readonly AnimationScriptPlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000DE")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x2FB4060", Offset = "0x2FB3460", Length = "0x139")]
	[Token(Token = "0x60002C2")]
	private static AnimationScriptPlayable() { }

	[Address(RVA = "0x2FB41A0", Offset = "0x2FB35A0", Length = "0xDC")]
	[Token(Token = "0x60002BF")]
	internal AnimationScriptPlayable(PlayableHandle handle) { }

	[Address(RVA = "0x2FB3FC0", Offset = "0x2FB33C0", Length = "0x9A")]
	[Token(Token = "0x60002C1")]
	public override bool Equals(AnimationScriptPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x60002C0")]
	public override PlayableHandle GetHandle() { }

}

