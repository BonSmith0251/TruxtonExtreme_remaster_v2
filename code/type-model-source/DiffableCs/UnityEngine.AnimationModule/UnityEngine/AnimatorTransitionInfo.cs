namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000017")]
public struct AnimatorTransitionInfo
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("fullPathHash")]
	[Token(Token = "0x4000055")]
	private int m_FullPath; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("userNameHash")]
	[Token(Token = "0x4000056")]
	private int m_UserName; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("nameHash")]
	[Token(Token = "0x4000057")]
	private int m_Name; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("hasFixedDuration")]
	[Token(Token = "0x4000058")]
	private bool m_HasFixedDuration; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("duration")]
	[Token(Token = "0x4000059")]
	private float m_Duration; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[NativeName("normalizedTime")]
	[Token(Token = "0x400005A")]
	private float m_NormalizedTime; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[NativeName("anyState")]
	[Token(Token = "0x400005B")]
	private bool m_AnyState; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("transitionType")]
	[Token(Token = "0x400005C")]
	private int m_TransitionType; //Field offset: 0x1C

}

