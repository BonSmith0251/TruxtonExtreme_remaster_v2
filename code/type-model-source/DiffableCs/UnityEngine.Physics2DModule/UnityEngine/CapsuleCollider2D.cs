namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/CapsuleCollider2D.h")]
[Token(Token = "0x2000013")]
public sealed class CapsuleCollider2D : Collider2D
{

	[Token(Token = "0x17000023")]
	public CapsuleDirection2D direction
	{
		[Address(RVA = "0x31228A0", Offset = "0x3121CA0", Length = "0x83")]
		[Token(Token = "0x600007D")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000022")]
	public Vector2 size
	{
		[Address(RVA = "0x31227D0", Offset = "0x3121BD0", Length = "0x87")]
		[Token(Token = "0x600007B")]
		 get { } //Length: 135
		[Address(RVA = "0x3122980", Offset = "0x3121D80", Length = "0x80")]
		[Token(Token = "0x600007C")]
		 set { } //Length: 128
	}

	[Address(RVA = "0x31227D0", Offset = "0x3121BD0", Length = "0x87")]
	[Token(Token = "0x600007B")]
	public Vector2 get_size() { }

	[Address(RVA = "0x3122780", Offset = "0x3121B80", Length = "0x42")]
	[Token(Token = "0x600007E")]
	private static void get_size_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x31228A0", Offset = "0x3121CA0", Length = "0x83")]
	[Token(Token = "0x600007D")]
	public void set_direction(CapsuleDirection2D value) { }

	[Address(RVA = "0x3122860", Offset = "0x3121C60", Length = "0x40")]
	[Token(Token = "0x6000080")]
	private static void set_direction_Injected(IntPtr _unity_self, CapsuleDirection2D value) { }

	[Address(RVA = "0x3122980", Offset = "0x3121D80", Length = "0x80")]
	[Token(Token = "0x600007C")]
	public void set_size(Vector2 value) { }

	[Address(RVA = "0x3122930", Offset = "0x3121D30", Length = "0x42")]
	[Token(Token = "0x600007F")]
	private static void set_size_Injected(IntPtr _unity_self, in Vector2 value) { }

}

