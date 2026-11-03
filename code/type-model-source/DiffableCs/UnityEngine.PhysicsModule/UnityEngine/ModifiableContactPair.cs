namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysXContactModification.h")]
[NativeHeader("Modules/Physics/PhysicsCollisionGeometry.h")]
[Token(Token = "0x200000D")]
public struct ModifiableContactPair
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000021")]
	private IntPtr actor; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000022")]
	private IntPtr otherActor; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000023")]
	private IntPtr shape; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000024")]
	private IntPtr otherShape; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000025")]
	public Quaternion rotation; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000026")]
	public Vector3 position; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000027")]
	public Quaternion otherRotation; //Field offset: 0x3C
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000028")]
	public Vector3 otherPosition; //Field offset: 0x4C
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000029")]
	private int numContacts; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400002A")]
	private IntPtr contacts; //Field offset: 0x60

}

