namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/EdgeCollider2D.h")]
[Token(Token = "0x2000014")]
public sealed class EdgeCollider2D : Collider2D
{

	[Token(Token = "0x17000024")]
	public Vector2[] points
	{
		[Address(RVA = "0x3125DB0", Offset = "0x31251B0", Length = "0x12A")]
		[Token(Token = "0x6000081")]
		 get { } //Length: 298
		[Address(RVA = "0x3125F30", Offset = "0x3125330", Length = "0x104")]
		[Token(Token = "0x6000082")]
		 set { } //Length: 260
	}

	[Address(RVA = "0x3125DB0", Offset = "0x31251B0", Length = "0x12A")]
	[Token(Token = "0x6000081")]
	public Vector2[] get_points() { }

	[Address(RVA = "0x3125D60", Offset = "0x3125160", Length = "0x42")]
	[Token(Token = "0x6000083")]
	private static void get_points_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3125F30", Offset = "0x3125330", Length = "0x104")]
	[Token(Token = "0x6000082")]
	public void set_points(Vector2[] value) { }

	[Address(RVA = "0x3125EE0", Offset = "0x31252E0", Length = "0x42")]
	[Token(Token = "0x6000084")]
	private static void set_points_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

}

