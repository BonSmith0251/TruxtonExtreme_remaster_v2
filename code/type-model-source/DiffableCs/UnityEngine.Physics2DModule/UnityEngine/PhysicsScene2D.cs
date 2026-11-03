namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
[Token(Token = "0x2000002")]
public struct PhysicsScene2D : IEquatable<PhysicsScene2D>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	private int m_Handle; //Field offset: 0x0

	[Address(RVA = "0x312DE00", Offset = "0x312D200", Length = "0x7F")]
	[Token(Token = "0x6000003")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x2FD0220", Offset = "0x2FCF620", Length = "0x8")]
	[Token(Token = "0x6000004")]
	public override bool Equals(PhysicsScene2D other) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6000002")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x312E100", Offset = "0x312D500", Length = "0xE0")]
	[Token(Token = "0x600000C")]
	public RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask = -5) { }

	[Address(RVA = "0x312E1E0", Offset = "0x312D5E0", Length = "0x13F")]
	[Token(Token = "0x600000D")]
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[Address(RVA = "0x312E080", Offset = "0x312D480", Length = "0x7D")]
	[NativeMethod("GetRayIntersection_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600000E")]
	private static RaycastHit2D GetRayIntersection_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[Address(RVA = "0x312E010", Offset = "0x312D410", Length = "0x62")]
	[Token(Token = "0x6000013")]
	private static void GetRayIntersection_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, out RaycastHit2D ret) { }

	[Address(RVA = "0x312DEF0", Offset = "0x312D2F0", Length = "0x11C")]
	[NativeMethod("GetRayIntersectionArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600000F")]
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	[Address(RVA = "0x312DE80", Offset = "0x312D280", Length = "0x62")]
	[Token(Token = "0x6000014")]
	private static int GetRayIntersectionArray_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, ref ManagedSpanWrapper results) { }

	[Address(RVA = "0x312E9D0", Offset = "0x312DDD0", Length = "0x170")]
	[Token(Token = "0x6000005")]
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	[Address(RVA = "0x312EB40", Offset = "0x312DF40", Length = "0xDA")]
	[Token(Token = "0x6000006")]
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[Address(RVA = "0x312E820", Offset = "0x312DC20", Length = "0x14B")]
	[Token(Token = "0x6000007")]
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[Address(RVA = "0x312E970", Offset = "0x312DD70", Length = "0x52")]
	[Token(Token = "0x6000008")]
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[Address(RVA = "0x312E7A0", Offset = "0x312DBA0", Length = "0x73")]
	[NativeMethod("Raycast_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000009")]
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[Address(RVA = "0x312E730", Offset = "0x312DB30", Length = "0x62")]
	[Token(Token = "0x6000010")]
	private static void Raycast_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	[Address(RVA = "0x312E390", Offset = "0x312D790", Length = "0x11D")]
	[NativeMethod("RaycastArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600000A")]
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[Address(RVA = "0x312E320", Offset = "0x312D720", Length = "0x62")]
	[Token(Token = "0x6000011")]
	private static int RaycastArray_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, ref ManagedSpanWrapper results) { }

	[Address(RVA = "0x312E520", Offset = "0x312D920", Length = "0x20C")]
	[NativeMethod("RaycastList_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600000B")]
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[Address(RVA = "0x312E4B0", Offset = "0x312D8B0", Length = "0x62")]
	[Token(Token = "0x6000012")]
	private static int RaycastList_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, ref BlittableListWrapper results) { }

	[Address(RVA = "0x312EC20", Offset = "0x312E020", Length = "0x54")]
	[Token(Token = "0x6000001")]
	public virtual string ToString() { }

}

