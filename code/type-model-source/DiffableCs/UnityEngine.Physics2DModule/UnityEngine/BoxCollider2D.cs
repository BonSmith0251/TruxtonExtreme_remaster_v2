namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/BoxCollider2D.h")]
[Token(Token = "0x2000015")]
public sealed class BoxCollider2D : Collider2D
{

	[Token(Token = "0x17000025")]
	public Vector2 size
	{
		[Address(RVA = "0x3122610", Offset = "0x3121A10", Length = "0x87")]
		[Token(Token = "0x6000085")]
		 get { } //Length: 135
		[Address(RVA = "0x31226F0", Offset = "0x3121AF0", Length = "0x80")]
		[Token(Token = "0x6000086")]
		 set { } //Length: 128
	}

	[Address(RVA = "0x3122610", Offset = "0x3121A10", Length = "0x87")]
	[Token(Token = "0x6000085")]
	public Vector2 get_size() { }

	[Address(RVA = "0x31225C0", Offset = "0x31219C0", Length = "0x42")]
	[Token(Token = "0x6000087")]
	private static void get_size_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x31226F0", Offset = "0x3121AF0", Length = "0x80")]
	[Token(Token = "0x6000086")]
	public void set_size(Vector2 value) { }

	[Address(RVA = "0x31226A0", Offset = "0x3121AA0", Length = "0x42")]
	[Token(Token = "0x6000088")]
	private static void set_size_Injected(IntPtr _unity_self, in Vector2 value) { }

}

