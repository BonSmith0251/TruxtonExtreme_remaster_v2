namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicsManager.h")]
[NativeHeader("Modules/Physics/PhysicsQuery.h")]
[StaticAccessor("GetPhysicsManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x200000B")]
public class Physics
{
	[Token(Token = "0x200000C")]
	internal sealed class ContactEventDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1C4BC60", Offset = "0x1C4B060", Length = "0xA6")]
		[Token(Token = "0x6000074")]
		public ContactEventDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x169F5F0", Offset = "0x169E9F0", Length = "0x25")]
		[Token(Token = "0x6000075")]
		public override void Invoke(PhysicsScene scene, ReadOnly<ContactPairHeader> headerArray) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400001C")]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEvent; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400001D")]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEventCCD; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400001E")]
	private static Action<PhysicsScene, IntPtr, Int32, Boolean> GenericContactModifyEvent; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400001F")]
	private static ContactEventDelegate ContactEvent; //Field offset: 0x18
	[Token(Token = "0x4000020")]
	private static readonly Collision s_ReusableCollision; //Field offset: 0x20

	[Token(Token = "0x17000015")]
	public static PhysicsScene defaultPhysicsScene
	{
		[Address(RVA = "0x10CEDF0", Offset = "0x10CE1F0", Length = "0x8")]
		[Token(Token = "0x6000038")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000014")]
	public static bool invokeCollisionCallbacks
	{
		[Address(RVA = "0x313B560", Offset = "0x313A960", Length = "0x2A")]
		[Token(Token = "0x6000037")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000016")]
	public static bool reuseCollisionCallbacks
	{
		[Address(RVA = "0x313B590", Offset = "0x313A990", Length = "0x2A")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000013")]
	public static SimulationMode simulationMode
	{
		[Address(RVA = "0x313B5C0", Offset = "0x313A9C0", Length = "0x2A")]
		[Token(Token = "0x6000036")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x313B430", Offset = "0x313A830", Length = "0x121")]
	[Token(Token = "0x600006B")]
	private static Physics() { }

	[Address(RVA = "0x31381A0", Offset = "0x31375A0", Length = "0x226")]
	[Token(Token = "0x600005F")]
	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) { }

	[Address(RVA = "0x10CEDF0", Offset = "0x10CE1F0", Length = "0x8")]
	[Token(Token = "0x6000038")]
	public static PhysicsScene get_defaultPhysicsScene() { }

	[Address(RVA = "0x313B560", Offset = "0x313A960", Length = "0x2A")]
	[Token(Token = "0x6000037")]
	public static bool get_invokeCollisionCallbacks() { }

	[Address(RVA = "0x313B590", Offset = "0x313A990", Length = "0x2A")]
	[Token(Token = "0x600005D")]
	public static bool get_reuseCollisionCallbacks() { }

	[Address(RVA = "0x313B5C0", Offset = "0x313A9C0", Length = "0x2A")]
	[Token(Token = "0x6000036")]
	public static SimulationMode get_simulationMode() { }

	[Address(RVA = "0x3138410", Offset = "0x3137810", Length = "0x7F")]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000064")]
	internal static Component GetBodyByInstanceID(EntityId entityId) { }

	[Address(RVA = "0x31383D0", Offset = "0x31377D0", Length = "0x33")]
	[Token(Token = "0x6000070")]
	private static IntPtr GetBodyByInstanceID_Injected(in EntityId entityId) { }

	[Address(RVA = "0x31384D0", Offset = "0x31378D0", Length = "0x7F")]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000063")]
	internal static Collider GetColliderByInstanceID(EntityId entityId) { }

	[Address(RVA = "0x3138490", Offset = "0x3137890", Length = "0x33")]
	[Token(Token = "0x600006F")]
	private static IntPtr GetColliderByInstanceID_Injected(in EntityId entityId) { }

	[Address(RVA = "0x3138550", Offset = "0x3137950", Length = "0x176")]
	[Token(Token = "0x600006A")]
	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	[Address(RVA = "0x3138740", Offset = "0x3137B40", Length = "0x149")]
	[FreeFunction("Physics::RaycastAll")]
	[Token(Token = "0x6000049")]
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x31386D0", Offset = "0x3137AD0", Length = "0x62")]
	[Token(Token = "0x600006C")]
	private static void Internal_RaycastAll_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3138940", Offset = "0x3137D40", Length = "0x1A8")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000068")]
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	[Address(RVA = "0x3138890", Offset = "0x3137C90", Length = "0xA3")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000034")]
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	[Address(RVA = "0x3138AF0", Offset = "0x3137EF0", Length = "0xF5")]
	[Token(Token = "0x6000062")]
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3138BF0", Offset = "0x3137FF0", Length = "0xC8")]
	[Token(Token = "0x6000060")]
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3138CC0", Offset = "0x31380C0", Length = "0xF9")]
	[Token(Token = "0x6000035")]
	private static void PhysXOnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	[Address(RVA = "0x3138E30", Offset = "0x3138230", Length = "0x16A")]
	[FreeFunction("Physics::ComputePenetration")]
	[Token(Token = "0x600005E")]
	private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	[Address(RVA = "0x3138DC0", Offset = "0x31381C0", Length = "0x62")]
	[Token(Token = "0x600006E")]
	private static bool Query_ComputePenetration_Injected(IntPtr colliderA, in Vector3 positionA, in Quaternion rotationA, IntPtr colliderB, in Vector3 positionB, in Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	[Address(RVA = "0x3139FC0", Offset = "0x31393C0", Length = "0xCC")]
	[Token(Token = "0x6000039")]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3139D20", Offset = "0x3139120", Length = "0xC5")]
	[ExcludeFromDocs]
	[Token(Token = "0x600003A")]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[Address(RVA = "0x313A7B0", Offset = "0x3139BB0", Length = "0xBD")]
	[ExcludeFromDocs]
	[Token(Token = "0x600003B")]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[Address(RVA = "0x313A560", Offset = "0x3139960", Length = "0xA9")]
	[ExcludeFromDocs]
	[Token(Token = "0x600003C")]
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	[Address(RVA = "0x313A480", Offset = "0x3139880", Length = "0xD9")]
	[Token(Token = "0x600003D")]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x313A090", Offset = "0x3139490", Length = "0xD2")]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x600003E")]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[Address(RVA = "0x3139C50", Offset = "0x3139050", Length = "0xCF")]
	[ExcludeFromDocs]
	[Token(Token = "0x600003F")]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[Address(RVA = "0x3139DF0", Offset = "0x31391F0", Length = "0xC2")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000040")]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	[Address(RVA = "0x313A610", Offset = "0x3139A10", Length = "0xB3")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000048")]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	[Address(RVA = "0x313A2E0", Offset = "0x31396E0", Length = "0xC4")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000047")]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[Address(RVA = "0x3139EC0", Offset = "0x31392C0", Length = "0xFD")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000046")]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[Address(RVA = "0x313A6D0", Offset = "0x3139AD0", Length = "0xD3")]
	[Token(Token = "0x6000045")]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x313A870", Offset = "0x3139C70", Length = "0x9E")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000044")]
	public static bool Raycast(Ray ray) { }

	[Address(RVA = "0x313A230", Offset = "0x3139630", Length = "0xAF")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000043")]
	public static bool Raycast(Ray ray, float maxDistance) { }

	[Address(RVA = "0x313A170", Offset = "0x3139570", Length = "0xBA")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000042")]
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[Address(RVA = "0x313A3B0", Offset = "0x31397B0", Length = "0xC6")]
	[Token(Token = "0x6000041")]
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3138FA0", Offset = "0x31383A0", Length = "0x93")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000050")]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[Address(RVA = "0x3139520", Offset = "0x3138920", Length = "0x8B")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000051")]
	public static RaycastHit[] RaycastAll(Ray ray) { }

	[Address(RVA = "0x3139480", Offset = "0x3138880", Length = "0x96")]
	[ExcludeFromDocs]
	[Token(Token = "0x600004D")]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	[Address(RVA = "0x31393E0", Offset = "0x31387E0", Length = "0x9E")]
	[ExcludeFromDocs]
	[Token(Token = "0x600004C")]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[Address(RVA = "0x31390E0", Offset = "0x31384E0", Length = "0xA8")]
	[ExcludeFromDocs]
	[Token(Token = "0x600004B")]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[Address(RVA = "0x3139190", Offset = "0x3138590", Length = "0x195")]
	[Token(Token = "0x600004A")]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3139330", Offset = "0x3138730", Length = "0xAB")]
	[Token(Token = "0x600004E")]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3139040", Offset = "0x3138440", Length = "0x9C")]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x600004F")]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[Address(RVA = "0x3139740", Offset = "0x3138B40", Length = "0xCC")]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x6000053")]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[Address(RVA = "0x31398E0", Offset = "0x3138CE0", Length = "0xD2")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000057")]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[Address(RVA = "0x31399C0", Offset = "0x3138DC0", Length = "0xD3")]
	[Token(Token = "0x6000052")]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x3139B80", Offset = "0x3138F80", Length = "0xC2")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000059")]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[Address(RVA = "0x31395B0", Offset = "0x31389B0", Length = "0xC4")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000054")]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[Address(RVA = "0x3139810", Offset = "0x3138C10", Length = "0xCF")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000058")]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[Address(RVA = "0x3139680", Offset = "0x3138A80", Length = "0xB3")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000055")]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	[Address(RVA = "0x3139AA0", Offset = "0x3138EA0", Length = "0xD9")]
	[Token(Token = "0x6000056")]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x313A910", Offset = "0x3139D10", Length = "0x3F5")]
	[Token(Token = "0x6000069")]
	private static void ReportContacts(ReadOnly<ContactPairHeader> array) { }

	[Address(RVA = "0x313AD60", Offset = "0x313A160", Length = "0x9B")]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000065")]
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	[Address(RVA = "0x313AD10", Offset = "0x313A110", Length = "0x42")]
	[Token(Token = "0x6000071")]
	private static void SendOnCollisionEnter_Injected(IntPtr component, Collision collision) { }

	[Address(RVA = "0x313AE50", Offset = "0x313A250", Length = "0x9B")]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000067")]
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	[Address(RVA = "0x313AE00", Offset = "0x313A200", Length = "0x42")]
	[Token(Token = "0x6000073")]
	private static void SendOnCollisionExit_Injected(IntPtr component, Collision collision) { }

	[Address(RVA = "0x313AF40", Offset = "0x313A340", Length = "0x9B")]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000066")]
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	[Address(RVA = "0x313AEF0", Offset = "0x313A2F0", Length = "0x42")]
	[Token(Token = "0x6000072")]
	private static void SendOnCollisionStay_Injected(IntPtr component, Collision collision) { }

	[Address(RVA = "0x313B0F0", Offset = "0x313A4F0", Length = "0x13C")]
	[Token(Token = "0x600005B")]
	public static void Simulate(float step) { }

	[Address(RVA = "0x313B050", Offset = "0x313A450", Length = "0x91")]
	[NativeName("Simulate")]
	[Token(Token = "0x600005A")]
	internal static void Simulate_Internal(PhysicsScene physicsScene, float step, SimulationStage stages, SimulationOption options) { }

	[Address(RVA = "0x313AFE0", Offset = "0x313A3E0", Length = "0x66")]
	[Token(Token = "0x600006D")]
	private static void Simulate_Internal_Injected(in PhysicsScene physicsScene, float step, SimulationStage stages, SimulationOption options) { }

	[Address(RVA = "0x313B230", Offset = "0x313A630", Length = "0x1C8")]
	[Token(Token = "0x6000061")]
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x313B400", Offset = "0x313A800", Length = "0x2A")]
	[Token(Token = "0x600005C")]
	public static void SyncTransforms() { }

}

