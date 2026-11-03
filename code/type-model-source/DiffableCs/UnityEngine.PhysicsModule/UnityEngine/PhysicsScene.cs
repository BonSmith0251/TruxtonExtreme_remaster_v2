namespace UnityEngine;

[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
[NativeHeader("Modules/Physics/PhysicsQuery.h")]
[Token(Token = "0x200001C")]
public struct PhysicsScene : IEquatable<PhysicsScene>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007A")]
	private int m_index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400007B")]
	private int m_version; //Field offset: 0x4

	[Address(RVA = "0x31371B0", Offset = "0x31365B0", Length = "0xA6")]
	[Token(Token = "0x60000B0")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x3137190", Offset = "0x3136590", Length = "0x1B")]
	[Token(Token = "0x60000B1")]
	public override bool Equals(PhysicsScene other) { }

	[Address(RVA = "0x10CEDF0", Offset = "0x10CE1F0", Length = "0x8")]
	[Token(Token = "0x60000B2")]
	internal static PhysicsScene GetDefaultScene() { }

	[Address(RVA = "0x3137260", Offset = "0x3136660", Length = "0x69")]
	[Token(Token = "0x60000AF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3137590", Offset = "0x3136990", Length = "0x6C")]
	[FreeFunction("Physics::Raycast")]
	[Token(Token = "0x60000B6")]
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3137520", Offset = "0x3136920", Length = "0x62")]
	[Token(Token = "0x60000C0")]
	private static bool Internal_Raycast_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3137340", Offset = "0x3136740", Length = "0xFB")]
	[FreeFunction("Physics::RaycastNonAlloc")]
	[Token(Token = "0x60000B8")]
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x31372D0", Offset = "0x31366D0", Length = "0x62")]
	[Token(Token = "0x60000C1")]
	private static int Internal_RaycastNonAlloc_Injected(in PhysicsScene physicsScene, in Ray ray, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x31374B0", Offset = "0x31368B0", Length = "0x64")]
	[FreeFunction("Physics::RaycastTest")]
	[Token(Token = "0x60000B4")]
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3137440", Offset = "0x3136840", Length = "0x62")]
	[Token(Token = "0x60000BF")]
	private static bool Internal_RaycastTest_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3137670", Offset = "0x3136A70", Length = "0x120")]
	[FreeFunction("Physics::SphereCastNonAlloc")]
	[Token(Token = "0x60000BB")]
	private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3137600", Offset = "0x3136A00", Length = "0x62")]
	[Token(Token = "0x60000C3")]
	private static int Internal_SphereCastNonAlloc_Injected(in PhysicsScene physicsScene, in Vector3 origin, float radius, in Vector3 direction, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3075280", Offset = "0x3074680", Length = "0x15")]
	[Token(Token = "0x60000AE")]
	public static bool op_Equality(PhysicsScene lhs, PhysicsScene rhs) { }

	[Address(RVA = "0x3137880", Offset = "0x3136C80", Length = "0x9E")]
	[Token(Token = "0x60000BA")]
	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask = -1, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[Address(RVA = "0x3137800", Offset = "0x3136C00", Length = "0x7F")]
	[FreeFunction("Physics::OverlapCapsuleNonAlloc")]
	[Token(Token = "0x60000B9")]
	private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3137790", Offset = "0x3136B90", Length = "0x62")]
	[Token(Token = "0x60000C2")]
	private static int OverlapCapsuleNonAlloc_Internal_Injected(in PhysicsScene physicsScene, in Vector3 point0, in Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3137A00", Offset = "0x3136E00", Length = "0x7C")]
	[Token(Token = "0x60000BE")]
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3137990", Offset = "0x3136D90", Length = "0x6C")]
	[FreeFunction("Physics::OverlapSphereNonAlloc")]
	[Token(Token = "0x60000BD")]
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3137920", Offset = "0x3136D20", Length = "0x62")]
	[Token(Token = "0x60000C4")]
	private static int OverlapSphereNonAlloc_Internal_Injected(in PhysicsScene physicsScene, in Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3137A80", Offset = "0x3136E80", Length = "0x237")]
	[Token(Token = "0x60000B7")]
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[Address(RVA = "0x3137E20", Offset = "0x3137220", Length = "0x17C")]
	[Token(Token = "0x60000B5")]
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[Address(RVA = "0x3137CC0", Offset = "0x31370C0", Length = "0x15F")]
	[Token(Token = "0x60000B3")]
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[Address(RVA = "0x3137FA0", Offset = "0x31373A0", Length = "0x17E")]
	[Token(Token = "0x60000BC")]
	public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[Address(RVA = "0x3138120", Offset = "0x3137520", Length = "0x7B")]
	[Token(Token = "0x60000AD")]
	public virtual string ToString() { }

}

