namespace UnityEngine;

[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000020")]
public class Rigidbody : Component
{

	[Token(Token = "0x17000033")]
	public float angularDamping
	{
		[Address(RVA = "0x313DBB0", Offset = "0x313CFB0", Length = "0x76")]
		[Token(Token = "0x60000D2")]
		 get { } //Length: 118
		[Address(RVA = "0x313F3C0", Offset = "0x313E7C0", Length = "0x86")]
		[Token(Token = "0x60000D3")]
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use Rigidbody.angularDamping instead. (UnityUpgradable) -> angularDamping")]
	[Token(Token = "0x1700004E")]
	public float angularDrag
	{
		[Address(RVA = "0x313DBB0", Offset = "0x313CFB0", Length = "0x76")]
		[Token(Token = "0x6000134")]
		 get { } //Length: 118
		[Address(RVA = "0x313F3C0", Offset = "0x313E7C0", Length = "0x86")]
		[Token(Token = "0x6000135")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000031")]
	public Vector3 angularVelocity
	{
		[Address(RVA = "0x313DC80", Offset = "0x313D080", Length = "0x90")]
		[Token(Token = "0x60000CE")]
		 get { } //Length: 144
		[Address(RVA = "0x313F4A0", Offset = "0x313E8A0", Length = "0x85")]
		[Token(Token = "0x60000CF")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700003B")]
	public bool automaticCenterOfMass
	{
		[Address(RVA = "0x313DD60", Offset = "0x313D160", Length = "0x76")]
		[Token(Token = "0x60000E2")]
		 get { } //Length: 118
		[Address(RVA = "0x313F580", Offset = "0x313E980", Length = "0x86")]
		[Token(Token = "0x60000E3")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700003E")]
	public bool automaticInertiaTensor
	{
		[Address(RVA = "0x313DE20", Offset = "0x313D220", Length = "0x76")]
		[Token(Token = "0x60000E7")]
		 get { } //Length: 118
		[Address(RVA = "0x313F660", Offset = "0x313EA60", Length = "0x86")]
		[Token(Token = "0x60000E8")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700003C")]
	public Vector3 centerOfMass
	{
		[Address(RVA = "0x313DEF0", Offset = "0x313D2F0", Length = "0x90")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 144
		[Address(RVA = "0x313F740", Offset = "0x313EB40", Length = "0x85")]
		[Token(Token = "0x60000E5")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700003A")]
	public CollisionDetectionMode collisionDetectionMode
	{
		[Address(RVA = "0x313DFD0", Offset = "0x313D3D0", Length = "0x76")]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 118
		[Address(RVA = "0x313F810", Offset = "0x313EC10", Length = "0x83")]
		[Token(Token = "0x60000E1")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000039")]
	public RigidbodyConstraints constraints
	{
		[Address(RVA = "0x313E090", Offset = "0x313D490", Length = "0x76")]
		[Token(Token = "0x60000DE")]
		 get { } //Length: 118
		[Address(RVA = "0x313F8E0", Offset = "0x313ECE0", Length = "0x83")]
		[Token(Token = "0x60000DF")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000042")]
	public bool detectCollisions
	{
		[Address(RVA = "0x313E150", Offset = "0x313D550", Length = "0x76")]
		[Token(Token = "0x60000EE")]
		 get { } //Length: 118
		[Address(RVA = "0x313F9C0", Offset = "0x313EDC0", Length = "0x86")]
		[Token(Token = "0x60000EF")]
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use Rigidbody.linearDamping instead. (UnityUpgradable) -> linearDamping")]
	[Token(Token = "0x1700004D")]
	public float drag
	{
		[Address(RVA = "0x313E1D0", Offset = "0x313D5D0", Length = "0x76")]
		[Token(Token = "0x6000132")]
		 get { } //Length: 118
		[Address(RVA = "0x313FA50", Offset = "0x313EE50", Length = "0x86")]
		[Token(Token = "0x6000133")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700004B")]
	public LayerMask excludeLayers
	{
		[Address(RVA = "0x313E2A0", Offset = "0x313D6A0", Length = "0x87")]
		[Token(Token = "0x600010B")]
		 get { } //Length: 135
		[Address(RVA = "0x313FB30", Offset = "0x313EF30", Length = "0x7E")]
		[Token(Token = "0x600010C")]
		 set { } //Length: 126
	}

	[Token(Token = "0x17000038")]
	public bool freezeRotation
	{
		[Address(RVA = "0x313E330", Offset = "0x313D730", Length = "0x7E")]
		[Token(Token = "0x60000DC")]
		 get { } //Length: 126
		[Address(RVA = "0x313FBB0", Offset = "0x313EFB0", Length = "0x175")]
		[Token(Token = "0x60000DD")]
		 set { } //Length: 373
	}

	[Token(Token = "0x1700004C")]
	public LayerMask includeLayers
	{
		[Address(RVA = "0x313E400", Offset = "0x313D800", Length = "0x87")]
		[Token(Token = "0x600010D")]
		 get { } //Length: 135
		[Address(RVA = "0x313FD80", Offset = "0x313F180", Length = "0x7E")]
		[Token(Token = "0x600010E")]
		 set { } //Length: 126
	}

	[Token(Token = "0x17000040")]
	public Vector3 inertiaTensor
	{
		[Address(RVA = "0x313E5C0", Offset = "0x313D9C0", Length = "0x90")]
		[Token(Token = "0x60000EB")]
		 get { } //Length: 144
		[Address(RVA = "0x313FF30", Offset = "0x313F330", Length = "0x85")]
		[Token(Token = "0x60000EC")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700003F")]
	public Quaternion inertiaTensorRotation
	{
		[Address(RVA = "0x313E4E0", Offset = "0x313D8E0", Length = "0x8E")]
		[Token(Token = "0x60000E9")]
		 get { } //Length: 142
		[Address(RVA = "0x313FE50", Offset = "0x313F250", Length = "0x85")]
		[Token(Token = "0x60000EA")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000045")]
	public RigidbodyInterpolation interpolation
	{
		[Address(RVA = "0x313E6A0", Offset = "0x313DAA0", Length = "0x76")]
		[Token(Token = "0x60000F4")]
		 get { } //Length: 118
		[Address(RVA = "0x3140000", Offset = "0x313F400", Length = "0x83")]
		[Token(Token = "0x60000F5")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000037")]
	public bool isKinematic
	{
		[Address(RVA = "0x313E760", Offset = "0x313DB60", Length = "0x76")]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 118
		[Address(RVA = "0x31400E0", Offset = "0x313F4E0", Length = "0x86")]
		[Token(Token = "0x60000DB")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000032")]
	public float linearDamping
	{
		[Address(RVA = "0x313E1D0", Offset = "0x313D5D0", Length = "0x76")]
		[Token(Token = "0x60000D0")]
		 get { } //Length: 118
		[Address(RVA = "0x313FA50", Offset = "0x313EE50", Length = "0x86")]
		[Token(Token = "0x60000D1")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000030")]
	public Vector3 linearVelocity
	{
		[Address(RVA = "0x313E870", Offset = "0x313DC70", Length = "0x90")]
		[Token(Token = "0x60000CC")]
		 get { } //Length: 144
		[Address(RVA = "0x3140210", Offset = "0x313F610", Length = "0x85")]
		[Token(Token = "0x60000CD")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000034")]
	public float mass
	{
		[Address(RVA = "0x313E950", Offset = "0x313DD50", Length = "0x76")]
		[Token(Token = "0x60000D4")]
		 get { } //Length: 118
		[Address(RVA = "0x31402F0", Offset = "0x313F6F0", Length = "0x86")]
		[Token(Token = "0x60000D5")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000048")]
	public float maxAngularVelocity
	{
		[Address(RVA = "0x313EA10", Offset = "0x313DE10", Length = "0x76")]
		[Token(Token = "0x60000FA")]
		 get { } //Length: 118
		[Address(RVA = "0x31403D0", Offset = "0x313F7D0", Length = "0x86")]
		[Token(Token = "0x60000FB")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000036")]
	public float maxDepenetrationVelocity
	{
		[Address(RVA = "0x313EAD0", Offset = "0x313DED0", Length = "0x76")]
		[Token(Token = "0x60000D8")]
		 get { } //Length: 118
		[Address(RVA = "0x31404B0", Offset = "0x313F8B0", Length = "0x86")]
		[Token(Token = "0x60000D9")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000049")]
	public float maxLinearVelocity
	{
		[Address(RVA = "0x313EB90", Offset = "0x313DF90", Length = "0x76")]
		[Token(Token = "0x60000FC")]
		 get { } //Length: 118
		[Address(RVA = "0x3140590", Offset = "0x313F990", Length = "0x86")]
		[Token(Token = "0x60000FD")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000043")]
	public Vector3 position
	{
		[Address(RVA = "0x313EC60", Offset = "0x313E060", Length = "0x90")]
		[Token(Token = "0x60000F0")]
		 get { } //Length: 144
		[Address(RVA = "0x3140670", Offset = "0x313FA70", Length = "0x85")]
		[Token(Token = "0x60000F1")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000044")]
	public Quaternion rotation
	{
		[Address(RVA = "0x313ED50", Offset = "0x313E150", Length = "0x8E")]
		[Token(Token = "0x60000F2")]
		 get { } //Length: 142
		[Address(RVA = "0x3140750", Offset = "0x313FB50", Length = "0x85")]
		[Token(Token = "0x60000F3")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000047")]
	public float sleepThreshold
	{
		[Address(RVA = "0x313EE20", Offset = "0x313E220", Length = "0x76")]
		[Token(Token = "0x60000F8")]
		 get { } //Length: 118
		[Address(RVA = "0x3140830", Offset = "0x313FC30", Length = "0x86")]
		[Token(Token = "0x60000F9")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000046")]
	public int solverIterations
	{
		[Address(RVA = "0x313EEE0", Offset = "0x313E2E0", Length = "0x76")]
		[Token(Token = "0x60000F6")]
		 get { } //Length: 118
		[Address(RVA = "0x3140900", Offset = "0x313FD00", Length = "0x83")]
		[Token(Token = "0x60000F7")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700004A")]
	public int solverVelocityIterations
	{
		[Address(RVA = "0x313EFA0", Offset = "0x313E3A0", Length = "0x76")]
		[Token(Token = "0x6000108")]
		 get { } //Length: 118
		[Address(RVA = "0x31409D0", Offset = "0x313FDD0", Length = "0x83")]
		[Token(Token = "0x6000109")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000035")]
	public bool useGravity
	{
		[Address(RVA = "0x313F060", Offset = "0x313E460", Length = "0x76")]
		[Token(Token = "0x60000D6")]
		 get { } //Length: 118
		[Address(RVA = "0x3140AB0", Offset = "0x313FEB0", Length = "0x86")]
		[Token(Token = "0x60000D7")]
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use Rigidbody.linearVelocity instead. (UnityUpgradable) -> linearVelocity")]
	[Token(Token = "0x1700004F")]
	public Vector3 velocity
	{
		[Address(RVA = "0x313F0E0", Offset = "0x313E4E0", Length = "0xA6")]
		[Token(Token = "0x6000136")]
		 get { } //Length: 166
		[Address(RVA = "0x3140B40", Offset = "0x313FF40", Length = "0x8C")]
		[Token(Token = "0x6000137")]
		 set { } //Length: 140
	}

	[Token(Token = "0x1700003D")]
	public Vector3 worldCenterOfMass
	{
		[Address(RVA = "0x313F1E0", Offset = "0x313E5E0", Length = "0x90")]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000041")]
	internal Matrix4x4 worldInertiaTensorMatrix
	{
		[Address(RVA = "0x313F2D0", Offset = "0x313E6D0", Length = "0x9A")]
		[Token(Token = "0x60000ED")]
		internal get { } //Length: 154
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000139")]
	public Rigidbody() { }

	[Address(RVA = "0x313B700", Offset = "0x313AB00", Length = "0xBF")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000127")]
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius) { }

	[Address(RVA = "0x313B7C0", Offset = "0x313ABC0", Length = "0xC5")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000126")]
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	[Address(RVA = "0x313B890", Offset = "0x313AC90", Length = "0xBF")]
	[Token(Token = "0x6000125")]
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	[Address(RVA = "0x313B690", Offset = "0x313AA90", Length = "0x62")]
	[Token(Token = "0x6000182")]
	private static void AddExplosionForce_Injected(IntPtr _unity_self, float explosionForce, in Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	[Address(RVA = "0x313BD40", Offset = "0x313B140", Length = "0x8D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000116")]
	public void AddForce(float x, float y, float z) { }

	[Address(RVA = "0x313BC10", Offset = "0x313B010", Length = "0x8F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000114")]
	public void AddForce(Vector3 force) { }

	[Address(RVA = "0x313BCA0", Offset = "0x313B0A0", Length = "0x95")]
	[Token(Token = "0x6000113")]
	public void AddForce(Vector3 force, ForceMode mode) { }

	[Address(RVA = "0x313BB80", Offset = "0x313AF80", Length = "0x8F")]
	[Token(Token = "0x6000115")]
	public void AddForce(float x, float y, float z, ForceMode mode) { }

	[Address(RVA = "0x313BB20", Offset = "0x313AF20", Length = "0x52")]
	[Token(Token = "0x600017D")]
	private static void AddForce_Injected(IntPtr _unity_self, in Vector3 force, ForceMode mode) { }

	[Address(RVA = "0x313B9C0", Offset = "0x313ADC0", Length = "0xA7")]
	[Token(Token = "0x6000123")]
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	[Address(RVA = "0x313BA70", Offset = "0x313AE70", Length = "0xA7")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000124")]
	public void AddForceAtPosition(Vector3 force, Vector3 position) { }

	[Address(RVA = "0x313B950", Offset = "0x313AD50", Length = "0x62")]
	[Token(Token = "0x6000181")]
	private static void AddForceAtPosition_Injected(IntPtr _unity_self, in Vector3 force, in Vector3 position, ForceMode mode) { }

	[Address(RVA = "0x313BEC0", Offset = "0x313B2C0", Length = "0x8D")]
	[ExcludeFromDocs]
	[Token(Token = "0x600011A")]
	public void AddRelativeForce(float x, float y, float z) { }

	[Address(RVA = "0x313BF50", Offset = "0x313B350", Length = "0x95")]
	[Token(Token = "0x6000117")]
	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	[Address(RVA = "0x313BE30", Offset = "0x313B230", Length = "0x8F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000118")]
	public void AddRelativeForce(Vector3 force) { }

	[Address(RVA = "0x313BFF0", Offset = "0x313B3F0", Length = "0x8F")]
	[Token(Token = "0x6000119")]
	public void AddRelativeForce(float x, float y, float z, ForceMode mode) { }

	[Address(RVA = "0x313BDD0", Offset = "0x313B1D0", Length = "0x52")]
	[Token(Token = "0x600017E")]
	private static void AddRelativeForce_Injected(IntPtr _unity_self, in Vector3 force, ForceMode mode) { }

	[Address(RVA = "0x313C200", Offset = "0x313B600", Length = "0x95")]
	[Token(Token = "0x600011F")]
	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	[Address(RVA = "0x313C0E0", Offset = "0x313B4E0", Length = "0x8F")]
	[Token(Token = "0x6000121")]
	public void AddRelativeTorque(float x, float y, float z, ForceMode mode) { }

	[Address(RVA = "0x313C2A0", Offset = "0x313B6A0", Length = "0x8D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000122")]
	public void AddRelativeTorque(float x, float y, float z) { }

	[Address(RVA = "0x313C170", Offset = "0x313B570", Length = "0x8F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000120")]
	public void AddRelativeTorque(Vector3 torque) { }

	[Address(RVA = "0x313C080", Offset = "0x313B480", Length = "0x52")]
	[Token(Token = "0x6000180")]
	private static void AddRelativeTorque_Injected(IntPtr _unity_self, in Vector3 torque, ForceMode mode) { }

	[Address(RVA = "0x313C4C0", Offset = "0x313B8C0", Length = "0x8D")]
	[ExcludeFromDocs]
	[Token(Token = "0x600011E")]
	public void AddTorque(float x, float y, float z) { }

	[Address(RVA = "0x313C550", Offset = "0x313B950", Length = "0x8F")]
	[Token(Token = "0x600011D")]
	public void AddTorque(float x, float y, float z, ForceMode mode) { }

	[Address(RVA = "0x313C390", Offset = "0x313B790", Length = "0x8F")]
	[ExcludeFromDocs]
	[Token(Token = "0x600011C")]
	public void AddTorque(Vector3 torque) { }

	[Address(RVA = "0x313C420", Offset = "0x313B820", Length = "0x95")]
	[Token(Token = "0x600011B")]
	public void AddTorque(Vector3 torque, ForceMode mode) { }

	[Address(RVA = "0x313C330", Offset = "0x313B730", Length = "0x52")]
	[Token(Token = "0x600017F")]
	private static void AddTorque_Injected(IntPtr _unity_self, in Vector3 torque, ForceMode mode) { }

	[Address(RVA = "0x313C5E0", Offset = "0x313B9E0", Length = "0x108")]
	[Token(Token = "0x6000129")]
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	[Address(RVA = "0x313DBB0", Offset = "0x313CFB0", Length = "0x76")]
	[Token(Token = "0x60000D2")]
	public float get_angularDamping() { }

	[Address(RVA = "0x313DB70", Offset = "0x313CF70", Length = "0x33")]
	[Token(Token = "0x6000140")]
	private static float get_angularDamping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313DBB0", Offset = "0x313CFB0", Length = "0x76")]
	[Token(Token = "0x6000134")]
	public float get_angularDrag() { }

	[Address(RVA = "0x313DC80", Offset = "0x313D080", Length = "0x90")]
	[Token(Token = "0x60000CE")]
	public Vector3 get_angularVelocity() { }

	[Address(RVA = "0x313DC30", Offset = "0x313D030", Length = "0x42")]
	[Token(Token = "0x600013C")]
	private static void get_angularVelocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x313DD60", Offset = "0x313D160", Length = "0x76")]
	[Token(Token = "0x60000E2")]
	public bool get_automaticCenterOfMass() { }

	[Address(RVA = "0x313DD20", Offset = "0x313D120", Length = "0x33")]
	[Token(Token = "0x600014E")]
	private static bool get_automaticCenterOfMass_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313DE20", Offset = "0x313D220", Length = "0x76")]
	[Token(Token = "0x60000E7")]
	public bool get_automaticInertiaTensor() { }

	[Address(RVA = "0x313DDE0", Offset = "0x313D1E0", Length = "0x33")]
	[Token(Token = "0x6000153")]
	private static bool get_automaticInertiaTensor_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313DEF0", Offset = "0x313D2F0", Length = "0x90")]
	[Token(Token = "0x60000E4")]
	public Vector3 get_centerOfMass() { }

	[Address(RVA = "0x313DEA0", Offset = "0x313D2A0", Length = "0x42")]
	[Token(Token = "0x6000150")]
	private static void get_centerOfMass_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x313DFD0", Offset = "0x313D3D0", Length = "0x76")]
	[Token(Token = "0x60000E0")]
	public CollisionDetectionMode get_collisionDetectionMode() { }

	[Address(RVA = "0x313DF90", Offset = "0x313D390", Length = "0x33")]
	[Token(Token = "0x600014C")]
	private static CollisionDetectionMode get_collisionDetectionMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313E090", Offset = "0x313D490", Length = "0x76")]
	[Token(Token = "0x60000DE")]
	public RigidbodyConstraints get_constraints() { }

	[Address(RVA = "0x313E050", Offset = "0x313D450", Length = "0x33")]
	[Token(Token = "0x600014A")]
	private static RigidbodyConstraints get_constraints_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313E150", Offset = "0x313D550", Length = "0x76")]
	[Token(Token = "0x60000EE")]
	public bool get_detectCollisions() { }

	[Address(RVA = "0x313E110", Offset = "0x313D510", Length = "0x33")]
	[Token(Token = "0x600015A")]
	private static bool get_detectCollisions_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313E1D0", Offset = "0x313D5D0", Length = "0x76")]
	[Token(Token = "0x6000132")]
	public float get_drag() { }

	[Address(RVA = "0x313E2A0", Offset = "0x313D6A0", Length = "0x87")]
	[Token(Token = "0x600010B")]
	public LayerMask get_excludeLayers() { }

	[Address(RVA = "0x313E250", Offset = "0x313D650", Length = "0x42")]
	[Token(Token = "0x6000177")]
	private static void get_excludeLayers_Injected(IntPtr _unity_self, out LayerMask ret) { }

	[Address(RVA = "0x313E330", Offset = "0x313D730", Length = "0x7E")]
	[Token(Token = "0x60000DC")]
	public bool get_freezeRotation() { }

	[Address(RVA = "0x313E400", Offset = "0x313D800", Length = "0x87")]
	[Token(Token = "0x600010D")]
	public LayerMask get_includeLayers() { }

	[Address(RVA = "0x313E3B0", Offset = "0x313D7B0", Length = "0x42")]
	[Token(Token = "0x6000179")]
	private static void get_includeLayers_Injected(IntPtr _unity_self, out LayerMask ret) { }

	[Address(RVA = "0x313E5C0", Offset = "0x313D9C0", Length = "0x90")]
	[Token(Token = "0x60000EB")]
	public Vector3 get_inertiaTensor() { }

	[Address(RVA = "0x313E570", Offset = "0x313D970", Length = "0x42")]
	[Token(Token = "0x6000157")]
	private static void get_inertiaTensor_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x313E4E0", Offset = "0x313D8E0", Length = "0x8E")]
	[Token(Token = "0x60000E9")]
	public Quaternion get_inertiaTensorRotation() { }

	[Address(RVA = "0x313E490", Offset = "0x313D890", Length = "0x42")]
	[Token(Token = "0x6000155")]
	private static void get_inertiaTensorRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[Address(RVA = "0x313E6A0", Offset = "0x313DAA0", Length = "0x76")]
	[Token(Token = "0x60000F4")]
	public RigidbodyInterpolation get_interpolation() { }

	[Address(RVA = "0x313E660", Offset = "0x313DA60", Length = "0x33")]
	[Token(Token = "0x6000160")]
	private static RigidbodyInterpolation get_interpolation_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313E760", Offset = "0x313DB60", Length = "0x76")]
	[Token(Token = "0x60000DA")]
	public bool get_isKinematic() { }

	[Address(RVA = "0x313E720", Offset = "0x313DB20", Length = "0x33")]
	[Token(Token = "0x6000148")]
	private static bool get_isKinematic_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313E1D0", Offset = "0x313D5D0", Length = "0x76")]
	[Token(Token = "0x60000D0")]
	public float get_linearDamping() { }

	[Address(RVA = "0x313E7E0", Offset = "0x313DBE0", Length = "0x33")]
	[Token(Token = "0x600013E")]
	private static float get_linearDamping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313E870", Offset = "0x313DC70", Length = "0x90")]
	[Token(Token = "0x60000CC")]
	public Vector3 get_linearVelocity() { }

	[Address(RVA = "0x313E820", Offset = "0x313DC20", Length = "0x42")]
	[Token(Token = "0x600013A")]
	private static void get_linearVelocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x313E950", Offset = "0x313DD50", Length = "0x76")]
	[Token(Token = "0x60000D4")]
	public float get_mass() { }

	[Address(RVA = "0x313E910", Offset = "0x313DD10", Length = "0x33")]
	[Token(Token = "0x6000142")]
	private static float get_mass_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313EA10", Offset = "0x313DE10", Length = "0x76")]
	[Token(Token = "0x60000FA")]
	public float get_maxAngularVelocity() { }

	[Address(RVA = "0x313E9D0", Offset = "0x313DDD0", Length = "0x33")]
	[Token(Token = "0x6000166")]
	private static float get_maxAngularVelocity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313EAD0", Offset = "0x313DED0", Length = "0x76")]
	[Token(Token = "0x60000D8")]
	public float get_maxDepenetrationVelocity() { }

	[Address(RVA = "0x313EA90", Offset = "0x313DE90", Length = "0x33")]
	[Token(Token = "0x6000146")]
	private static float get_maxDepenetrationVelocity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313EB90", Offset = "0x313DF90", Length = "0x76")]
	[Token(Token = "0x60000FC")]
	public float get_maxLinearVelocity() { }

	[Address(RVA = "0x313EB50", Offset = "0x313DF50", Length = "0x33")]
	[Token(Token = "0x6000168")]
	private static float get_maxLinearVelocity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313EC60", Offset = "0x313E060", Length = "0x90")]
	[Token(Token = "0x60000F0")]
	public Vector3 get_position() { }

	[Address(RVA = "0x313EC10", Offset = "0x313E010", Length = "0x42")]
	[Token(Token = "0x600015C")]
	private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x313ED50", Offset = "0x313E150", Length = "0x8E")]
	[Token(Token = "0x60000F2")]
	public Quaternion get_rotation() { }

	[Address(RVA = "0x313ED00", Offset = "0x313E100", Length = "0x42")]
	[Token(Token = "0x600015E")]
	private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[Address(RVA = "0x313EE20", Offset = "0x313E220", Length = "0x76")]
	[Token(Token = "0x60000F8")]
	public float get_sleepThreshold() { }

	[Address(RVA = "0x313EDE0", Offset = "0x313E1E0", Length = "0x33")]
	[Token(Token = "0x6000164")]
	private static float get_sleepThreshold_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313EEE0", Offset = "0x313E2E0", Length = "0x76")]
	[Token(Token = "0x60000F6")]
	public int get_solverIterations() { }

	[Address(RVA = "0x313EEA0", Offset = "0x313E2A0", Length = "0x33")]
	[Token(Token = "0x6000162")]
	private static int get_solverIterations_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313EFA0", Offset = "0x313E3A0", Length = "0x76")]
	[Token(Token = "0x6000108")]
	public int get_solverVelocityIterations() { }

	[Address(RVA = "0x313EF60", Offset = "0x313E360", Length = "0x33")]
	[Token(Token = "0x6000174")]
	private static int get_solverVelocityIterations_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313F060", Offset = "0x313E460", Length = "0x76")]
	[Token(Token = "0x60000D6")]
	public bool get_useGravity() { }

	[Address(RVA = "0x313F020", Offset = "0x313E420", Length = "0x33")]
	[Token(Token = "0x6000144")]
	private static bool get_useGravity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313F0E0", Offset = "0x313E4E0", Length = "0xA6")]
	[Token(Token = "0x6000136")]
	public Vector3 get_velocity() { }

	[Address(RVA = "0x313F1E0", Offset = "0x313E5E0", Length = "0x90")]
	[Token(Token = "0x60000E6")]
	public Vector3 get_worldCenterOfMass() { }

	[Address(RVA = "0x313F190", Offset = "0x313E590", Length = "0x42")]
	[Token(Token = "0x6000152")]
	private static void get_worldCenterOfMass_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x313F2D0", Offset = "0x313E6D0", Length = "0x9A")]
	[Token(Token = "0x60000ED")]
	internal Matrix4x4 get_worldInertiaTensorMatrix() { }

	[Address(RVA = "0x313F280", Offset = "0x313E680", Length = "0x42")]
	[Token(Token = "0x6000159")]
	private static void get_worldInertiaTensorMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x313C800", Offset = "0x313BC00", Length = "0xC5")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000110")]
	public Vector3 GetAccumulatedForce() { }

	[Address(RVA = "0x313C750", Offset = "0x313BB50", Length = "0xA0")]
	[Token(Token = "0x600010F")]
	public Vector3 GetAccumulatedForce(float step) { }

	[Address(RVA = "0x313C6F0", Offset = "0x313BAF0", Length = "0x52")]
	[Token(Token = "0x600017B")]
	private static void GetAccumulatedForce_Injected(IntPtr _unity_self, float step, out Vector3 ret) { }

	[Address(RVA = "0x313C9E0", Offset = "0x313BDE0", Length = "0xC5")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000112")]
	public Vector3 GetAccumulatedTorque() { }

	[Address(RVA = "0x313C930", Offset = "0x313BD30", Length = "0xA0")]
	[Token(Token = "0x6000111")]
	public Vector3 GetAccumulatedTorque(float step) { }

	[Address(RVA = "0x313C8D0", Offset = "0x313BCD0", Length = "0x52")]
	[Token(Token = "0x600017C")]
	private static void GetAccumulatedTorque_Injected(IntPtr _unity_self, float step, out Vector3 ret) { }

	[Address(RVA = "0x313CB10", Offset = "0x313BF10", Length = "0xA0")]
	[Token(Token = "0x6000107")]
	public Vector3 GetPointVelocity(Vector3 worldPoint) { }

	[Address(RVA = "0x313CAB0", Offset = "0x313BEB0", Length = "0x52")]
	[Token(Token = "0x6000173")]
	private static void GetPointVelocity_Injected(IntPtr _unity_self, in Vector3 worldPoint, out Vector3 ret) { }

	[Address(RVA = "0x313CC20", Offset = "0x313C020", Length = "0xA0")]
	[Token(Token = "0x6000106")]
	public Vector3 GetRelativePointVelocity(Vector3 relativePoint) { }

	[Address(RVA = "0x313CBC0", Offset = "0x313BFC0", Length = "0x52")]
	[Token(Token = "0x6000172")]
	private static void GetRelativePointVelocity_Injected(IntPtr _unity_self, in Vector3 relativePoint, out Vector3 ret) { }

	[Address(RVA = "0x313CD40", Offset = "0x313C140", Length = "0xA7")]
	[NativeName("ClosestPointOnBounds")]
	[Token(Token = "0x6000128")]
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	[Address(RVA = "0x313CCD0", Offset = "0x313C0D0", Length = "0x62")]
	[Token(Token = "0x6000183")]
	private static void Internal_ClosestPointOnBounds_Injected(IntPtr _unity_self, in Vector3 point, ref Vector3 outPos, ref float distance) { }

	[Address(RVA = "0x313CE60", Offset = "0x313C260", Length = "0x16E")]
	[NativeName("SweepTestAll")]
	[Token(Token = "0x600012E")]
	private RaycastHit[] Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x313CDF0", Offset = "0x313C1F0", Length = "0x62")]
	[Token(Token = "0x6000185")]
	private static void Internal_SweepTestAll_Injected(IntPtr _unity_self, in Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x313D010", Offset = "0x313C410", Length = "0x76")]
	[Token(Token = "0x6000102")]
	public bool IsSleeping() { }

	[Address(RVA = "0x313CFD0", Offset = "0x313C3D0", Length = "0x33")]
	[Token(Token = "0x600016E")]
	private static bool IsSleeping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313D2B0", Offset = "0x313C6B0", Length = "0x95")]
	[Token(Token = "0x6000100")]
	public void Move(Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x313D250", Offset = "0x313C650", Length = "0x52")]
	[Token(Token = "0x600016C")]
	private static void Move_Injected(IntPtr _unity_self, in Vector3 position, in Quaternion rotation) { }

	[Address(RVA = "0x313D0E0", Offset = "0x313C4E0", Length = "0x85")]
	[Token(Token = "0x60000FE")]
	public void MovePosition(Vector3 position) { }

	[Address(RVA = "0x313D090", Offset = "0x313C490", Length = "0x42")]
	[Token(Token = "0x600016A")]
	private static void MovePosition_Injected(IntPtr _unity_self, in Vector3 position) { }

	[Address(RVA = "0x313D1C0", Offset = "0x313C5C0", Length = "0x85")]
	[Token(Token = "0x60000FF")]
	public void MoveRotation(Quaternion rotation) { }

	[Address(RVA = "0x313D170", Offset = "0x313C570", Length = "0x42")]
	[Token(Token = "0x600016B")]
	private static void MoveRotation_Injected(IntPtr _unity_self, in Quaternion rotation) { }

	[Address(RVA = "0x313D390", Offset = "0x313C790", Length = "0x76")]
	[Token(Token = "0x600010A")]
	public void PublishTransform() { }

	[Address(RVA = "0x313D350", Offset = "0x313C750", Length = "0x33")]
	[Token(Token = "0x6000176")]
	private static void PublishTransform_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313D450", Offset = "0x313C850", Length = "0x76")]
	[Token(Token = "0x6000104")]
	public void ResetCenterOfMass() { }

	[Address(RVA = "0x313D410", Offset = "0x313C810", Length = "0x33")]
	[Token(Token = "0x6000170")]
	private static void ResetCenterOfMass_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313D510", Offset = "0x313C910", Length = "0x76")]
	[Token(Token = "0x6000105")]
	public void ResetInertiaTensor() { }

	[Address(RVA = "0x313D4D0", Offset = "0x313C8D0", Length = "0x33")]
	[Token(Token = "0x6000171")]
	private static void ResetInertiaTensor_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313F3C0", Offset = "0x313E7C0", Length = "0x86")]
	[Token(Token = "0x60000D3")]
	public void set_angularDamping(float value) { }

	[Address(RVA = "0x313F370", Offset = "0x313E770", Length = "0x43")]
	[Token(Token = "0x6000141")]
	private static void set_angularDamping_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x313F3C0", Offset = "0x313E7C0", Length = "0x86")]
	[Token(Token = "0x6000135")]
	public void set_angularDrag(float value) { }

	[Address(RVA = "0x313F4A0", Offset = "0x313E8A0", Length = "0x85")]
	[Token(Token = "0x60000CF")]
	public void set_angularVelocity(Vector3 value) { }

	[Address(RVA = "0x313F450", Offset = "0x313E850", Length = "0x42")]
	[Token(Token = "0x600013D")]
	private static void set_angularVelocity_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x313F580", Offset = "0x313E980", Length = "0x86")]
	[Token(Token = "0x60000E3")]
	public void set_automaticCenterOfMass(bool value) { }

	[Address(RVA = "0x313F530", Offset = "0x313E930", Length = "0x42")]
	[Token(Token = "0x600014F")]
	private static void set_automaticCenterOfMass_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x313F660", Offset = "0x313EA60", Length = "0x86")]
	[Token(Token = "0x60000E8")]
	public void set_automaticInertiaTensor(bool value) { }

	[Address(RVA = "0x313F610", Offset = "0x313EA10", Length = "0x42")]
	[Token(Token = "0x6000154")]
	private static void set_automaticInertiaTensor_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x313F740", Offset = "0x313EB40", Length = "0x85")]
	[Token(Token = "0x60000E5")]
	public void set_centerOfMass(Vector3 value) { }

	[Address(RVA = "0x313F6F0", Offset = "0x313EAF0", Length = "0x42")]
	[Token(Token = "0x6000151")]
	private static void set_centerOfMass_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x313F810", Offset = "0x313EC10", Length = "0x83")]
	[Token(Token = "0x60000E1")]
	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	[Address(RVA = "0x313F7D0", Offset = "0x313EBD0", Length = "0x40")]
	[Token(Token = "0x600014D")]
	private static void set_collisionDetectionMode_Injected(IntPtr _unity_self, CollisionDetectionMode value) { }

	[Address(RVA = "0x313F8E0", Offset = "0x313ECE0", Length = "0x83")]
	[Token(Token = "0x60000DF")]
	public void set_constraints(RigidbodyConstraints value) { }

	[Address(RVA = "0x313F8A0", Offset = "0x313ECA0", Length = "0x40")]
	[Token(Token = "0x600014B")]
	private static void set_constraints_Injected(IntPtr _unity_self, RigidbodyConstraints value) { }

	[Address(RVA = "0x313F9C0", Offset = "0x313EDC0", Length = "0x86")]
	[Token(Token = "0x60000EF")]
	public void set_detectCollisions(bool value) { }

	[Address(RVA = "0x313F970", Offset = "0x313ED70", Length = "0x42")]
	[Token(Token = "0x600015B")]
	private static void set_detectCollisions_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x313FA50", Offset = "0x313EE50", Length = "0x86")]
	[Token(Token = "0x6000133")]
	public void set_drag(float value) { }

	[Address(RVA = "0x313FB30", Offset = "0x313EF30", Length = "0x7E")]
	[Token(Token = "0x600010C")]
	public void set_excludeLayers(LayerMask value) { }

	[Address(RVA = "0x313FAE0", Offset = "0x313EEE0", Length = "0x42")]
	[Token(Token = "0x6000178")]
	private static void set_excludeLayers_Injected(IntPtr _unity_self, in LayerMask value) { }

	[Address(RVA = "0x313FBB0", Offset = "0x313EFB0", Length = "0x175")]
	[Token(Token = "0x60000DD")]
	public void set_freezeRotation(bool value) { }

	[Address(RVA = "0x313FD80", Offset = "0x313F180", Length = "0x7E")]
	[Token(Token = "0x600010E")]
	public void set_includeLayers(LayerMask value) { }

	[Address(RVA = "0x313FD30", Offset = "0x313F130", Length = "0x42")]
	[Token(Token = "0x600017A")]
	private static void set_includeLayers_Injected(IntPtr _unity_self, in LayerMask value) { }

	[Address(RVA = "0x313FF30", Offset = "0x313F330", Length = "0x85")]
	[Token(Token = "0x60000EC")]
	public void set_inertiaTensor(Vector3 value) { }

	[Address(RVA = "0x313FEE0", Offset = "0x313F2E0", Length = "0x42")]
	[Token(Token = "0x6000158")]
	private static void set_inertiaTensor_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x313FE50", Offset = "0x313F250", Length = "0x85")]
	[Token(Token = "0x60000EA")]
	public void set_inertiaTensorRotation(Quaternion value) { }

	[Address(RVA = "0x313FE00", Offset = "0x313F200", Length = "0x42")]
	[Token(Token = "0x6000156")]
	private static void set_inertiaTensorRotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	[Address(RVA = "0x3140000", Offset = "0x313F400", Length = "0x83")]
	[Token(Token = "0x60000F5")]
	public void set_interpolation(RigidbodyInterpolation value) { }

	[Address(RVA = "0x313FFC0", Offset = "0x313F3C0", Length = "0x40")]
	[Token(Token = "0x6000161")]
	private static void set_interpolation_Injected(IntPtr _unity_self, RigidbodyInterpolation value) { }

	[Address(RVA = "0x31400E0", Offset = "0x313F4E0", Length = "0x86")]
	[Token(Token = "0x60000DB")]
	public void set_isKinematic(bool value) { }

	[Address(RVA = "0x3140090", Offset = "0x313F490", Length = "0x42")]
	[Token(Token = "0x6000149")]
	private static void set_isKinematic_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x313FA50", Offset = "0x313EE50", Length = "0x86")]
	[Token(Token = "0x60000D1")]
	public void set_linearDamping(float value) { }

	[Address(RVA = "0x3140170", Offset = "0x313F570", Length = "0x43")]
	[Token(Token = "0x600013F")]
	private static void set_linearDamping_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3140210", Offset = "0x313F610", Length = "0x85")]
	[Token(Token = "0x60000CD")]
	public void set_linearVelocity(Vector3 value) { }

	[Address(RVA = "0x31401C0", Offset = "0x313F5C0", Length = "0x42")]
	[Token(Token = "0x600013B")]
	private static void set_linearVelocity_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x31402F0", Offset = "0x313F6F0", Length = "0x86")]
	[Token(Token = "0x60000D5")]
	public void set_mass(float value) { }

	[Address(RVA = "0x31402A0", Offset = "0x313F6A0", Length = "0x43")]
	[Token(Token = "0x6000143")]
	private static void set_mass_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x31403D0", Offset = "0x313F7D0", Length = "0x86")]
	[Token(Token = "0x60000FB")]
	public void set_maxAngularVelocity(float value) { }

	[Address(RVA = "0x3140380", Offset = "0x313F780", Length = "0x43")]
	[Token(Token = "0x6000167")]
	private static void set_maxAngularVelocity_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x31404B0", Offset = "0x313F8B0", Length = "0x86")]
	[Token(Token = "0x60000D9")]
	public void set_maxDepenetrationVelocity(float value) { }

	[Address(RVA = "0x3140460", Offset = "0x313F860", Length = "0x43")]
	[Token(Token = "0x6000147")]
	private static void set_maxDepenetrationVelocity_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3140590", Offset = "0x313F990", Length = "0x86")]
	[Token(Token = "0x60000FD")]
	public void set_maxLinearVelocity(float value) { }

	[Address(RVA = "0x3140540", Offset = "0x313F940", Length = "0x43")]
	[Token(Token = "0x6000169")]
	private static void set_maxLinearVelocity_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3140670", Offset = "0x313FA70", Length = "0x85")]
	[Token(Token = "0x60000F1")]
	public void set_position(Vector3 value) { }

	[Address(RVA = "0x3140620", Offset = "0x313FA20", Length = "0x42")]
	[Token(Token = "0x600015D")]
	private static void set_position_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x3140750", Offset = "0x313FB50", Length = "0x85")]
	[Token(Token = "0x60000F3")]
	public void set_rotation(Quaternion value) { }

	[Address(RVA = "0x3140700", Offset = "0x313FB00", Length = "0x42")]
	[Token(Token = "0x600015F")]
	private static void set_rotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	[Address(RVA = "0x3140830", Offset = "0x313FC30", Length = "0x86")]
	[Token(Token = "0x60000F9")]
	public void set_sleepThreshold(float value) { }

	[Address(RVA = "0x31407E0", Offset = "0x313FBE0", Length = "0x43")]
	[Token(Token = "0x6000165")]
	private static void set_sleepThreshold_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3140900", Offset = "0x313FD00", Length = "0x83")]
	[Token(Token = "0x60000F7")]
	public void set_solverIterations(int value) { }

	[Address(RVA = "0x31408C0", Offset = "0x313FCC0", Length = "0x40")]
	[Token(Token = "0x6000163")]
	private static void set_solverIterations_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x31409D0", Offset = "0x313FDD0", Length = "0x83")]
	[Token(Token = "0x6000109")]
	public void set_solverVelocityIterations(int value) { }

	[Address(RVA = "0x3140990", Offset = "0x313FD90", Length = "0x40")]
	[Token(Token = "0x6000175")]
	private static void set_solverVelocityIterations_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3140AB0", Offset = "0x313FEB0", Length = "0x86")]
	[Token(Token = "0x60000D7")]
	public void set_useGravity(bool value) { }

	[Address(RVA = "0x3140A60", Offset = "0x313FE60", Length = "0x42")]
	[Token(Token = "0x6000145")]
	private static void set_useGravity_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3140B40", Offset = "0x313FF40", Length = "0x8C")]
	[Token(Token = "0x6000137")]
	public void set_velocity(Vector3 value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use Rigidbody.mass instead. Setting density on a Rigidbody no longer has any effect.", False)]
	[Token(Token = "0x6000138")]
	public void SetDensity(float density) { }

	[Address(RVA = "0x313D5D0", Offset = "0x313C9D0", Length = "0x76")]
	[Token(Token = "0x6000101")]
	public void Sleep() { }

	[Address(RVA = "0x313D590", Offset = "0x313C990", Length = "0x33")]
	[Token(Token = "0x600016D")]
	private static void Sleep_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x313D900", Offset = "0x313CD00", Length = "0x37")]
	[ExcludeFromDocs]
	[Token(Token = "0x600012D")]
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo) { }

	[Address(RVA = "0x313D800", Offset = "0x313CC00", Length = "0x2F")]
	[ExcludeFromDocs]
	[Token(Token = "0x600012C")]
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[Address(RVA = "0x313D830", Offset = "0x313CC30", Length = "0xCC")]
	[Token(Token = "0x600012A")]
	private RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit) { }

	[Address(RVA = "0x313D940", Offset = "0x313CD40", Length = "0x16D")]
	[Token(Token = "0x600012B")]
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x313D790", Offset = "0x313CB90", Length = "0x62")]
	[Token(Token = "0x6000184")]
	private static void SweepTest_Injected(IntPtr _unity_self, in Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret) { }

	[Address(RVA = "0x313D680", Offset = "0x313CA80", Length = "0xC7")]
	[Token(Token = "0x600012F")]
	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[Address(RVA = "0x313D750", Offset = "0x313CB50", Length = "0x38")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000131")]
	public RaycastHit[] SweepTestAll(Vector3 direction) { }

	[Address(RVA = "0x313D650", Offset = "0x313CA50", Length = "0x30")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000130")]
	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance) { }

	[Address(RVA = "0x313DAF0", Offset = "0x313CEF0", Length = "0x76")]
	[Token(Token = "0x6000103")]
	public void WakeUp() { }

	[Address(RVA = "0x313DAB0", Offset = "0x313CEB0", Length = "0x33")]
	[Token(Token = "0x600016F")]
	private static void WakeUp_Injected(IntPtr _unity_self) { }

}

