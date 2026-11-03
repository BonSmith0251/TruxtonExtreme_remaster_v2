namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x2000008")]
public class ControllerColliderHit
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000015")]
	internal CharacterController m_Controller; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000016")]
	internal Collider m_Collider; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000017")]
	internal Vector3 m_Point; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000018")]
	internal Vector3 m_Normal; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000019")]
	internal Vector3 m_MoveDirection; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400001A")]
	internal float m_MoveLength; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400001B")]
	internal int m_Push; //Field offset: 0x48

}

