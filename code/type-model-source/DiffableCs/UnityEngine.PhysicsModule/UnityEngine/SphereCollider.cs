namespace UnityEngine;

[NativeHeader("Modules/Physics/SphereCollider.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000021")]
public class SphereCollider : Collider
{

	[Token(Token = "0x17000050")]
	public Vector3 center
	{
		[Address(RVA = "0x3140C20", Offset = "0x3140020", Length = "0x90")]
		[Token(Token = "0x6000186")]
		 get { } //Length: 144
		[Address(RVA = "0x3140DD0", Offset = "0x31401D0", Length = "0x85")]
		[Token(Token = "0x6000187")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000051")]
	public float radius
	{
		[Address(RVA = "0x3140D00", Offset = "0x3140100", Length = "0x76")]
		[Token(Token = "0x6000188")]
		 get { } //Length: 118
		[Address(RVA = "0x3140EB0", Offset = "0x31402B0", Length = "0x35F")]
		[Token(Token = "0x6000189")]
		 set { } //Length: 863
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600018A")]
	public SphereCollider() { }

	[Address(RVA = "0x3140C20", Offset = "0x3140020", Length = "0x90")]
	[Token(Token = "0x6000186")]
	public Vector3 get_center() { }

	[Address(RVA = "0x3140BD0", Offset = "0x313FFD0", Length = "0x42")]
	[Token(Token = "0x600018B")]
	private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x3140D00", Offset = "0x3140100", Length = "0x76")]
	[Token(Token = "0x6000188")]
	public float get_radius() { }

	[Address(RVA = "0x3140CC0", Offset = "0x31400C0", Length = "0x33")]
	[Token(Token = "0x600018D")]
	private static float get_radius_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3140DD0", Offset = "0x31401D0", Length = "0x85")]
	[Token(Token = "0x6000187")]
	public void set_center(Vector3 value) { }

	[Address(RVA = "0x3140D80", Offset = "0x3140180", Length = "0x42")]
	[Token(Token = "0x600018C")]
	private static void set_center_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x3140EB0", Offset = "0x31402B0", Length = "0x35F")]
	[Token(Token = "0x6000189")]
	public void set_radius(float value) { }

	[Address(RVA = "0x3140E60", Offset = "0x3140260", Length = "0x43")]
	[Token(Token = "0x600018E")]
	private static void set_radius_Injected(IntPtr _unity_self, float value) { }

}

