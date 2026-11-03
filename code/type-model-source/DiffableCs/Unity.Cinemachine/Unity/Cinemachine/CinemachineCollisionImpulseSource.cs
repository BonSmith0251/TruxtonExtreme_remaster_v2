namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine Collision Impulse Source")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineCollisionImpulseSource.html")]
[SaveDuringPlay]
[Token(Token = "0x200014F")]
public class CinemachineCollisionImpulseSource : CinemachineImpulseSource
{
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_LayerMask")]
	[Header("Trigger Object Filter")]
	[Token(Token = "0x4000589")]
	[Tooltip("Only collisions with objects on these layers will generate Impulse events")]
	public LayerMask LayerMask; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("m_IgnoreTag")]
	[TagField]
	[Token(Token = "0x400058A")]
	[Tooltip("No Impulse events will be generated for collisions with objects having these tags")]
	public string IgnoreTag; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("m_UseImpactDirection")]
	[Header("How To Generate The Impulse")]
	[Token(Token = "0x400058B")]
	[Tooltip("If checked, signal direction will be affected by the direction of impact")]
	public bool UseImpactDirection; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[FormerlySerializedAs("m_ScaleImpactWithMass")]
	[Token(Token = "0x400058C")]
	[Tooltip("If checked, signal amplitude will be multiplied by the mass of the impacting object")]
	public bool ScaleImpactWithMass; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[FormerlySerializedAs("m_ScaleImpactWithSpeed")]
	[Token(Token = "0x400058D")]
	[Tooltip("If checked, signal amplitude will be multiplied by the speed of the impacting object")]
	public bool ScaleImpactWithSpeed; //Field offset: 0x4A
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400058E")]
	private Rigidbody m_RigidBody; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400058F")]
	private Rigidbody2D m_RigidBody2D; //Field offset: 0x58

	[Address(RVA = "0x286B2E0", Offset = "0x286A6E0", Length = "0x45")]
	[Token(Token = "0x600068D")]
	public CinemachineCollisionImpulseSource() { }

	[Address(RVA = "0x286A940", Offset = "0x2869D40", Length = "0x21E")]
	[Token(Token = "0x6000688")]
	private void GenerateImpactEvent(Collider other, Vector3 vel) { }

	[Address(RVA = "0x286A720", Offset = "0x2869B20", Length = "0x21E")]
	[Token(Token = "0x600068C")]
	private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel) { }

	[Address(RVA = "0x286ADC0", Offset = "0x286A1C0", Length = "0x28C")]
	[Token(Token = "0x6000687")]
	private float GetMassAndVelocity(Collider other, ref Vector3 vel) { }

	[Address(RVA = "0x286AB60", Offset = "0x2869F60", Length = "0x259")]
	[Token(Token = "0x600068B")]
	private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel) { }

	[Address(RVA = "0x286B0D0", Offset = "0x286A4D0", Length = "0x70")]
	[Token(Token = "0x6000685")]
	private void OnCollisionEnter(Collision c) { }

	[Address(RVA = "0x286B050", Offset = "0x286A450", Length = "0x7C")]
	[Token(Token = "0x6000689")]
	private void OnCollisionEnter2D(Collision2D c) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000684")]
	private void OnEnable() { }

	[Address(RVA = "0x286B1C0", Offset = "0x286A5C0", Length = "0x69")]
	[Token(Token = "0x6000686")]
	private void OnTriggerEnter(Collider c) { }

	[Address(RVA = "0x286B150", Offset = "0x286A550", Length = "0x69")]
	[Token(Token = "0x600068A")]
	private void OnTriggerEnter2D(Collider2D c) { }

	[Address(RVA = "0x286B230", Offset = "0x286A630", Length = "0x46")]
	[Token(Token = "0x6000682")]
	private void Reset() { }

	[Address(RVA = "0x286B280", Offset = "0x286A680", Length = "0x5C")]
	[Token(Token = "0x6000683")]
	private void Start() { }

}

