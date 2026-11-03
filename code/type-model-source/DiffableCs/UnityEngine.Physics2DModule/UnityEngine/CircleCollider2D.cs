namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/CircleCollider2D.h")]
[Token(Token = "0x2000012")]
public sealed class CircleCollider2D : Collider2D
{

	[Token(Token = "0x17000021")]
	public float radius
	{
		[Address(RVA = "0x3122DC0", Offset = "0x31221C0", Length = "0x76")]
		[Token(Token = "0x6000077")]
		 get { } //Length: 118
		[Address(RVA = "0x3122E90", Offset = "0x3122290", Length = "0x86")]
		[Token(Token = "0x6000078")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x3122DC0", Offset = "0x31221C0", Length = "0x76")]
	[Token(Token = "0x6000077")]
	public float get_radius() { }

	[Address(RVA = "0x3122D80", Offset = "0x3122180", Length = "0x33")]
	[Token(Token = "0x6000079")]
	private static float get_radius_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3122E90", Offset = "0x3122290", Length = "0x86")]
	[Token(Token = "0x6000078")]
	public void set_radius(float value) { }

	[Address(RVA = "0x3122E40", Offset = "0x3122240", Length = "0x43")]
	[Token(Token = "0x600007A")]
	private static void set_radius_Injected(IntPtr _unity_self, float value) { }

}

