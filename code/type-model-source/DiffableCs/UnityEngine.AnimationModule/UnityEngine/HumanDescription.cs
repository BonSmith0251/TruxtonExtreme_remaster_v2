namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
[NativeHeader("Modules/Animation/HumanDescription.h")]
[Token(Token = "0x2000022")]
public struct HumanDescription
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("m_Human")]
	[Token(Token = "0x40000AB")]
	public HumanBone[] human; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("m_Skeleton")]
	[Token(Token = "0x40000AC")]
	public SkeletonBone[] skeleton; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AD")]
	internal float m_ArmTwist; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000AE")]
	internal float m_ForeArmTwist; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000AF")]
	internal float m_UpperLegTwist; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000B0")]
	internal float m_LegTwist; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000B1")]
	internal float m_ArmStretch; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000B2")]
	internal float m_LegStretch; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000B3")]
	internal float m_FeetSpacing; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000B4")]
	internal float m_GlobalScale; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000B5")]
	internal string m_RootMotionBoneName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000B6")]
	internal bool m_HasTranslationDoF; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x40000B7")]
	internal bool m_HasExtraRoot; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x40000B8")]
	internal bool m_SkeletonHasParents; //Field offset: 0x3A

}

