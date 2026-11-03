namespace UnityEngine;

[NativeHeader("Modules/Physics/Collider.h")]
[Token(Token = "0x200000A")]
public class Collider : Component
{

	[Token(Token = "0x17000010")]
	public Rigidbody attachedRigidbody
	{
		[Address(RVA = "0x31353F0", Offset = "0x31347F0", Length = "0x90")]
		[NativeMethod("GetRigidbody")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000012")]
	public Bounds bounds
	{
		[Address(RVA = "0x31354E0", Offset = "0x31348E0", Length = "0x94")]
		[Token(Token = "0x600002A")]
		 get { } //Length: 148
	}

	[Token(Token = "0x1700000F")]
	public bool enabled
	{
		[Address(RVA = "0x31355C0", Offset = "0x31349C0", Length = "0x76")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000011")]
	public bool isTrigger
	{
		[Address(RVA = "0x3135690", Offset = "0x3134A90", Length = "0x86")]
		[Token(Token = "0x6000028")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600002D")]
	public Collider() { }

	[Address(RVA = "0x31350A0", Offset = "0x31344A0", Length = "0xA0")]
	[Token(Token = "0x6000029")]
	public Vector3 ClosestPoint(Vector3 position) { }

	[Address(RVA = "0x3135040", Offset = "0x3134440", Length = "0x52")]
	[Token(Token = "0x6000031")]
	private static void ClosestPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[Address(RVA = "0x31353F0", Offset = "0x31347F0", Length = "0x90")]
	[NativeMethod("GetRigidbody")]
	[Token(Token = "0x6000027")]
	public Rigidbody get_attachedRigidbody() { }

	[Address(RVA = "0x31353B0", Offset = "0x31347B0", Length = "0x33")]
	[Token(Token = "0x600002F")]
	private static IntPtr get_attachedRigidbody_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31354E0", Offset = "0x31348E0", Length = "0x94")]
	[Token(Token = "0x600002A")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x3135490", Offset = "0x3134890", Length = "0x42")]
	[Token(Token = "0x6000032")]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[Address(RVA = "0x31355C0", Offset = "0x31349C0", Length = "0x76")]
	[Token(Token = "0x6000026")]
	public bool get_enabled() { }

	[Address(RVA = "0x3135580", Offset = "0x3134980", Length = "0x33")]
	[Token(Token = "0x600002E")]
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31351C0", Offset = "0x31345C0", Length = "0xC2")]
	[Token(Token = "0x600002B")]
	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	[Address(RVA = "0x3135290", Offset = "0x3134690", Length = "0x118")]
	[Token(Token = "0x600002C")]
	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[Address(RVA = "0x3135150", Offset = "0x3134550", Length = "0x62")]
	[Token(Token = "0x6000033")]
	private static void Raycast_Injected(IntPtr _unity_self, in Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	[Address(RVA = "0x3135690", Offset = "0x3134A90", Length = "0x86")]
	[Token(Token = "0x6000028")]
	public void set_isTrigger(bool value) { }

	[Address(RVA = "0x3135640", Offset = "0x3134A40", Length = "0x42")]
	[Token(Token = "0x6000030")]
	private static void set_isTrigger_Injected(IntPtr _unity_self, bool value) { }

}

