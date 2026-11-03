namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode(Optional = True)]
[Token(Token = "0x2000011")]
public class Collider2D : Behaviour
{

	[Token(Token = "0x1700001E")]
	public Rigidbody2D attachedRigidbody
	{
		[Address(RVA = "0x3123950", Offset = "0x3122D50", Length = "0x90")]
		[NativeMethod("GetAttachedRigidbody_Binding")]
		[Token(Token = "0x6000065")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000020")]
	public Bounds bounds
	{
		[Address(RVA = "0x3123A40", Offset = "0x3122E40", Length = "0x94")]
		[Token(Token = "0x600006B")]
		 get { } //Length: 148
	}

	[Token(Token = "0x1700001C")]
	public bool isTrigger
	{
		[Address(RVA = "0x3123CD0", Offset = "0x31230D0", Length = "0x86")]
		[Token(Token = "0x6000063")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700001D")]
	public Vector2 offset
	{
		[Address(RVA = "0x3123B30", Offset = "0x3122F30", Length = "0x87")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700001F")]
	public int shapeCount
	{
		[Address(RVA = "0x3123C00", Offset = "0x3123000", Length = "0x76")]
		[Token(Token = "0x6000066")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600006D")]
	public Collider2D() { }

	[Address(RVA = "0x3123950", Offset = "0x3122D50", Length = "0x90")]
	[NativeMethod("GetAttachedRigidbody_Binding")]
	[Token(Token = "0x6000065")]
	public Rigidbody2D get_attachedRigidbody() { }

	[Address(RVA = "0x3123910", Offset = "0x3122D10", Length = "0x33")]
	[Token(Token = "0x6000070")]
	private static IntPtr get_attachedRigidbody_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3123A40", Offset = "0x3122E40", Length = "0x94")]
	[Token(Token = "0x600006B")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x31239F0", Offset = "0x3122DF0", Length = "0x42")]
	[Token(Token = "0x6000075")]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[Address(RVA = "0x3123B30", Offset = "0x3122F30", Length = "0x87")]
	[Token(Token = "0x6000064")]
	public Vector2 get_offset() { }

	[Address(RVA = "0x3123AE0", Offset = "0x3122EE0", Length = "0x42")]
	[Token(Token = "0x600006F")]
	private static void get_offset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x3123C00", Offset = "0x3123000", Length = "0x76")]
	[Token(Token = "0x6000066")]
	public int get_shapeCount() { }

	[Address(RVA = "0x3123BC0", Offset = "0x3122FC0", Length = "0x33")]
	[Token(Token = "0x6000071")]
	private static int get_shapeCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3123300", Offset = "0x3122700", Length = "0x242")]
	[NativeMethod("GetShapeBounds_Binding")]
	[Token(Token = "0x600006A")]
	public Bounds GetShapeBounds(List<Bounds> bounds, bool useRadii, bool useWorldSpace) { }

	[Address(RVA = "0x3123290", Offset = "0x3122690", Length = "0x66")]
	[Token(Token = "0x6000074")]
	private static void GetShapeBounds_Injected(IntPtr _unity_self, ref BlittableListWrapper bounds, bool useRadii, bool useWorldSpace, out Bounds ret) { }

	[Address(RVA = "0x3123590", Offset = "0x3122990", Length = "0x76")]
	[NativeMethod("GetShapeHash_Binding")]
	[Token(Token = "0x6000067")]
	public uint GetShapeHash() { }

	[Address(RVA = "0x3123550", Offset = "0x3122950", Length = "0x33")]
	[Token(Token = "0x6000072")]
	private static uint GetShapeHash_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3123730", Offset = "0x3122B30", Length = "0xF8")]
	[Token(Token = "0x6000068")]
	public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup) { }

	[Address(RVA = "0x3123680", Offset = "0x3122A80", Length = "0xA7")]
	[NativeMethod("GetShapes_Binding")]
	[Token(Token = "0x6000069")]
	private int GetShapes_Internal(ref GroupState physicsShapeGroupState, int shapeIndex, int shapeCount) { }

	[Address(RVA = "0x3123610", Offset = "0x3122A10", Length = "0x62")]
	[Token(Token = "0x6000073")]
	private static int GetShapes_Internal_Injected(IntPtr _unity_self, ref GroupState physicsShapeGroupState, int shapeIndex, int shapeCount) { }

	[Address(RVA = "0x3123880", Offset = "0x3122C80", Length = "0x80")]
	[Token(Token = "0x600006C")]
	public bool OverlapPoint(Vector2 point) { }

	[Address(RVA = "0x3123830", Offset = "0x3122C30", Length = "0x42")]
	[Token(Token = "0x6000076")]
	private static bool OverlapPoint_Injected(IntPtr _unity_self, in Vector2 point) { }

	[Address(RVA = "0x3123CD0", Offset = "0x31230D0", Length = "0x86")]
	[Token(Token = "0x6000063")]
	public void set_isTrigger(bool value) { }

	[Address(RVA = "0x3123C80", Offset = "0x3123080", Length = "0x42")]
	[Token(Token = "0x600006E")]
	private static void set_isTrigger_Injected(IntPtr _unity_self, bool value) { }

}

