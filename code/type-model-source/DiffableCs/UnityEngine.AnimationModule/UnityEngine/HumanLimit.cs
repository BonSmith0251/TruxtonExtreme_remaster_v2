namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
[NativeHeader("Modules/Animation/HumanDescription.h")]
[NativeType(CodegenOptions::Custom (1), "MonoHumanLimit")]
[Token(Token = "0x2000020")]
public struct HumanLimit
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A3")]
	private Vector3 m_Min; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000A4")]
	private Vector3 m_Max; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A5")]
	private Vector3 m_Center; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000A6")]
	private float m_AxisLength; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A7")]
	private int m_UseDefaultValues; //Field offset: 0x28

}

