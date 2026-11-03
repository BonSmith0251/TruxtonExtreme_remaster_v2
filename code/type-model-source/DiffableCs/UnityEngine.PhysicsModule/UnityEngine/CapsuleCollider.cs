namespace UnityEngine;

[NativeHeader("Modules/Physics/CapsuleCollider.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000007")]
public class CapsuleCollider : Collider
{

	[Token(Token = "0x1700000B")]
	public Vector3 center
	{
		[Address(RVA = "0x31349F0", Offset = "0x3133DF0", Length = "0x90")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 144
		[Address(RVA = "0x3134D20", Offset = "0x3134120", Length = "0x85")]
		[Token(Token = "0x6000016")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700000E")]
	public int direction
	{
		[Address(RVA = "0x3134AD0", Offset = "0x3133ED0", Length = "0x76")]
		[Token(Token = "0x600001B")]
		 get { } //Length: 118
		[Address(RVA = "0x3134DF0", Offset = "0x31341F0", Length = "0x83")]
		[Token(Token = "0x600001C")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700000D")]
	public float height
	{
		[Address(RVA = "0x3134B90", Offset = "0x3133F90", Length = "0x76")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 118
		[Address(RVA = "0x3134ED0", Offset = "0x31342D0", Length = "0x86")]
		[Token(Token = "0x600001A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000C")]
	public float radius
	{
		[Address(RVA = "0x3134C50", Offset = "0x3134050", Length = "0x76")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 118
		[Address(RVA = "0x3134FB0", Offset = "0x31343B0", Length = "0x86")]
		[Token(Token = "0x6000018")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600001D")]
	public CapsuleCollider() { }

	[Address(RVA = "0x31349F0", Offset = "0x3133DF0", Length = "0x90")]
	[Token(Token = "0x6000015")]
	public Vector3 get_center() { }

	[Address(RVA = "0x31349A0", Offset = "0x3133DA0", Length = "0x42")]
	[Token(Token = "0x600001E")]
	private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x3134AD0", Offset = "0x3133ED0", Length = "0x76")]
	[Token(Token = "0x600001B")]
	public int get_direction() { }

	[Address(RVA = "0x3134A90", Offset = "0x3133E90", Length = "0x33")]
	[Token(Token = "0x6000024")]
	private static int get_direction_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3134B90", Offset = "0x3133F90", Length = "0x76")]
	[Token(Token = "0x6000019")]
	public float get_height() { }

	[Address(RVA = "0x3134B50", Offset = "0x3133F50", Length = "0x33")]
	[Token(Token = "0x6000022")]
	private static float get_height_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3134C50", Offset = "0x3134050", Length = "0x76")]
	[Token(Token = "0x6000017")]
	public float get_radius() { }

	[Address(RVA = "0x3134C10", Offset = "0x3134010", Length = "0x33")]
	[Token(Token = "0x6000020")]
	private static float get_radius_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3134D20", Offset = "0x3134120", Length = "0x85")]
	[Token(Token = "0x6000016")]
	public void set_center(Vector3 value) { }

	[Address(RVA = "0x3134CD0", Offset = "0x31340D0", Length = "0x42")]
	[Token(Token = "0x600001F")]
	private static void set_center_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x3134DF0", Offset = "0x31341F0", Length = "0x83")]
	[Token(Token = "0x600001C")]
	public void set_direction(int value) { }

	[Address(RVA = "0x3134DB0", Offset = "0x31341B0", Length = "0x40")]
	[Token(Token = "0x6000025")]
	private static void set_direction_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3134ED0", Offset = "0x31342D0", Length = "0x86")]
	[Token(Token = "0x600001A")]
	public void set_height(float value) { }

	[Address(RVA = "0x3134E80", Offset = "0x3134280", Length = "0x43")]
	[Token(Token = "0x6000023")]
	private static void set_height_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3134FB0", Offset = "0x31343B0", Length = "0x86")]
	[Token(Token = "0x6000018")]
	public void set_radius(float value) { }

	[Address(RVA = "0x3134F60", Offset = "0x3134360", Length = "0x43")]
	[Token(Token = "0x6000021")]
	private static void set_radius_Injected(IntPtr _unity_self, float value) { }

}

