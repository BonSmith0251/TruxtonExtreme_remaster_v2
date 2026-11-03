namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[Token(Token = "0x2000015")]
[UsedByNativeCode]
public struct AnimatorClipInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004A")]
	private int m_ClipInstanceID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400004B")]
	private float m_Weight; //Field offset: 0x4

	[Token(Token = "0x17000011")]
	public AnimationClip clip
	{
		[Address(RVA = "0x2FB4730", Offset = "0x2FB3B30", Length = "0x73")]
		[Token(Token = "0x6000065")]
		 get { } //Length: 115
	}

	[Token(Token = "0x17000012")]
	public float weight
	{
		[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
		[Token(Token = "0x6000066")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2FB4730", Offset = "0x2FB3B30", Length = "0x73")]
	[Token(Token = "0x6000065")]
	public AnimationClip get_clip() { }

	[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
	[Token(Token = "0x6000066")]
	public float get_weight() { }

	[Address(RVA = "0x2FB46D0", Offset = "0x2FB3AD0", Length = "0x5E")]
	[FreeFunction("AnimationBindings::InstanceIDToAnimationClipPPtr")]
	[Token(Token = "0x6000067")]
	private static AnimationClip InstanceIDToAnimationClipPPtr(EntityId entityId) { }

	[Address(RVA = "0x2FB4690", Offset = "0x2FB3A90", Length = "0x33")]
	[Token(Token = "0x6000068")]
	private static IntPtr InstanceIDToAnimationClipPPtr_Injected(in EntityId entityId) { }

}

