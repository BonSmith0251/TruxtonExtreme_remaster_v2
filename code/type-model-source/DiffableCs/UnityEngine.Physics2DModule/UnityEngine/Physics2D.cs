namespace UnityEngine;

[NativeHeader("Physics2DScriptingClasses.h")]
[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType::Arrow (1))]
[Token(Token = "0x2000003")]
public class Physics2D
{
	[Token(Token = "0x4000002")]
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; //Field offset: 0x0

	[Token(Token = "0x17000001")]
	public static PhysicsScene2D defaultPhysicsScene
	{
		[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 5
	}

	[StaticAccessor("GetPhysics2DSettings()")]
	[Token(Token = "0x17000002")]
	public static bool queriesHitTriggers
	{
		[Address(RVA = "0x3128510", Offset = "0x3127910", Length = "0x2A")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x3128480", Offset = "0x3127880", Length = "0x84")]
	[Token(Token = "0x600002B")]
	private static Physics2D() { }

	[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
	[Token(Token = "0x6000015")]
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	[Address(RVA = "0x3128510", Offset = "0x3127910", Length = "0x2A")]
	[Token(Token = "0x6000016")]
	public static bool get_queriesHitTriggers() { }

	[Address(RVA = "0x31273E0", Offset = "0x31267E0", Length = "0x13A")]
	[Token(Token = "0x6000023")]
	public static RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask = -5) { }

	[Address(RVA = "0x3126D40", Offset = "0x3126140", Length = "0x9D")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000026")]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask = -5) { }

	[Address(RVA = "0x3126DE0", Offset = "0x31261E0", Length = "0x95")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000025")]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[Address(RVA = "0x3126E80", Offset = "0x3126280", Length = "0x8D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000024")]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[Address(RVA = "0x3126BF0", Offset = "0x3125FF0", Length = "0x148")]
	[NativeMethod("GetRayIntersectionAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000027")]
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[Address(RVA = "0x3126B80", Offset = "0x3125F80", Length = "0x62")]
	[Token(Token = "0x600002E")]
	private static void GetRayIntersectionAll_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3126F10", Offset = "0x3126310", Length = "0x199")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("GetRayIntersectionNonAlloc is deprecated. Please use GetRayIntersection.", False)]
	[Token(Token = "0x600002A")]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[Address(RVA = "0x3127250", Offset = "0x3126650", Length = "0x18B")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("GetRayIntersectionNonAlloc is deprecated. Please use GetRayIntersection.", False)]
	[Token(Token = "0x6000029")]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[Address(RVA = "0x31270B0", Offset = "0x31264B0", Length = "0x19E")]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x6000028")]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask = -5) { }

	[Address(RVA = "0x31279C0", Offset = "0x3126DC0", Length = "0x19F")]
	[ExcludeFromDocs]
	[Token(Token = "0x600001E")]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[Address(RVA = "0x3127800", Offset = "0x3126C00", Length = "0x1B6")]
	[Token(Token = "0x600001D")]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[Address(RVA = "0x3127EC0", Offset = "0x31272C0", Length = "0xD5")]
	[ExcludeFromDocs]
	[Token(Token = "0x600001A")]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[Address(RVA = "0x3128220", Offset = "0x3127620", Length = "0xCF")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000019")]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[Address(RVA = "0x3128060", Offset = "0x3127460", Length = "0x1B5")]
	[ExcludeFromDocs]
	[Token(Token = "0x600001C")]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	[Address(RVA = "0x3127FA0", Offset = "0x31273A0", Length = "0xBF")]
	[Token(Token = "0x6000020")]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[Address(RVA = "0x3127D20", Offset = "0x3127120", Length = "0x1A0")]
	[Token(Token = "0x600001F")]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	[Address(RVA = "0x3127B60", Offset = "0x3126F60", Length = "0x1B4")]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x600001B")]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[Address(RVA = "0x31276E0", Offset = "0x3126AE0", Length = "0x114")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000021")]
	public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[Address(RVA = "0x3127590", Offset = "0x3126990", Length = "0x142")]
	[NativeMethod("RaycastAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000022")]
	private static RaycastHit2D[] RaycastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[Address(RVA = "0x3127520", Offset = "0x3126920", Length = "0x62")]
	[Token(Token = "0x600002D")]
	private static void RaycastAll_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x31283D0", Offset = "0x31277D0", Length = "0xAF")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000017")]
	public static bool Simulate(float deltaTime) { }

	[Address(RVA = "0x3128350", Offset = "0x3127750", Length = "0x7C")]
	[NativeMethod("Simulate_Binding")]
	[Token(Token = "0x6000018")]
	internal static bool Simulate_Internal(PhysicsScene2D physicsScene, float deltaTime, int simulationLayers) { }

	[Address(RVA = "0x31282F0", Offset = "0x31276F0", Length = "0x52")]
	[Token(Token = "0x600002C")]
	private static bool Simulate_Internal_Injected(in PhysicsScene2D physicsScene, float deltaTime, int simulationLayers) { }

}

