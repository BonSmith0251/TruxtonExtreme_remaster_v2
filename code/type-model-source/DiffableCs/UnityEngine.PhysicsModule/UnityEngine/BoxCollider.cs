namespace UnityEngine;

[NativeHeader("Modules/Physics/BoxCollider.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000006")]
public class BoxCollider : Collider
{

	[Token(Token = "0x17000009")]
	public Vector3 center
	{
		[Address(RVA = "0x3134650", Offset = "0x3133A50", Length = "0x90")]
		[Token(Token = "0x600000C")]
		 get { } //Length: 144
		[Address(RVA = "0x3134830", Offset = "0x3133C30", Length = "0x85")]
		[Token(Token = "0x600000D")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700000A")]
	public Vector3 size
	{
		[Address(RVA = "0x3134740", Offset = "0x3133B40", Length = "0x90")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 144
		[Address(RVA = "0x3134910", Offset = "0x3133D10", Length = "0x85")]
		[Token(Token = "0x600000F")]
		 set { } //Length: 133
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000010")]
	public BoxCollider() { }

	[Address(RVA = "0x3134650", Offset = "0x3133A50", Length = "0x90")]
	[Token(Token = "0x600000C")]
	public Vector3 get_center() { }

	[Address(RVA = "0x3134600", Offset = "0x3133A00", Length = "0x42")]
	[Token(Token = "0x6000011")]
	private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x3134740", Offset = "0x3133B40", Length = "0x90")]
	[Token(Token = "0x600000E")]
	public Vector3 get_size() { }

	[Address(RVA = "0x31346F0", Offset = "0x3133AF0", Length = "0x42")]
	[Token(Token = "0x6000013")]
	private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x3134830", Offset = "0x3133C30", Length = "0x85")]
	[Token(Token = "0x600000D")]
	public void set_center(Vector3 value) { }

	[Address(RVA = "0x31347E0", Offset = "0x3133BE0", Length = "0x42")]
	[Token(Token = "0x6000012")]
	private static void set_center_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x3134910", Offset = "0x3133D10", Length = "0x85")]
	[Token(Token = "0x600000F")]
	public void set_size(Vector3 value) { }

	[Address(RVA = "0x31348C0", Offset = "0x3133CC0", Length = "0x42")]
	[Token(Token = "0x6000014")]
	private static void set_size_Injected(IntPtr _unity_self, in Vector3 value) { }

}

