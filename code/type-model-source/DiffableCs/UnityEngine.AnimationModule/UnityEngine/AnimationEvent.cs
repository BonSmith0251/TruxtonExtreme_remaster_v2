namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x200000A")]
public sealed class AnimationEvent
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000016")]
	internal float m_Time; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000017")]
	internal string m_FunctionName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000018")]
	internal string m_StringParameter; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000019")]
	internal object m_ObjectReferenceParameter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001A")]
	internal float m_FloatParameter; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400001B")]
	internal int m_IntParameter; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400001C")]
	internal int m_MessageOptions; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400001D")]
	internal AnimationEventSource m_Source; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400001E")]
	internal AnimationState m_StateSender; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400001F")]
	internal AnimatorStateInfo m_AnimatorStateInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000020")]
	internal AnimatorClipInfo m_AnimatorClipInfo; //Field offset: 0x6C

	[Address(RVA = "0x2FB0580", Offset = "0x2FAF980", Length = "0x9E")]
	[Token(Token = "0x6000028")]
	public AnimationEvent() { }

}

