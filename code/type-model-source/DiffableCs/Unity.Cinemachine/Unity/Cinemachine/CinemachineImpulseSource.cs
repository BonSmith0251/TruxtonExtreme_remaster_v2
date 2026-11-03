namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine Impulse Source")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineImpulseSource.html")]
[SaveDuringPlay]
[Token(Token = "0x2000160")]
public class CinemachineImpulseSource : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_ImpulseDefinition")]
	[Token(Token = "0x40005E9")]
	public CinemachineImpulseDefinition ImpulseDefinition; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_DefaultVelocity")]
	[Header("Default Invocation")]
	[Token(Token = "0x40005EA")]
	[Tooltip("The default direction and force of the Impulse Signal in the absense of any specified overrides.  Overrides can be specified by calling the appropriate GenerateImpulse method in the API.")]
	public Vector3 DefaultVelocity; //Field offset: 0x28

	[Address(RVA = "0x2883260", Offset = "0x2882660", Length = "0xA0")]
	[Token(Token = "0x60006C6")]
	public CinemachineImpulseSource() { }

	[Address(RVA = "0x28830A0", Offset = "0x28824A0", Length = "0x85")]
	[Token(Token = "0x60006C2")]
	public void GenerateImpulse() { }

	[Address(RVA = "0x2883020", Offset = "0x2882420", Length = "0x7B")]
	[Token(Token = "0x60006C4")]
	public void GenerateImpulse(Vector3 velocity) { }

	[Address(RVA = "0x2882F70", Offset = "0x2882370", Length = "0xA0")]
	[Token(Token = "0x60006C5")]
	public void GenerateImpulse(float force) { }

	[Address(RVA = "0x2882F20", Offset = "0x2882320", Length = "0x4A")]
	[Token(Token = "0x60006C3")]
	public void GenerateImpulseAt(Vector3 position, Vector3 velocity) { }

	[Address(RVA = "0x2882F20", Offset = "0x2882320", Length = "0x4A")]
	[Token(Token = "0x60006BF")]
	public void GenerateImpulseAtPositionWithVelocity(Vector3 position, Vector3 velocity) { }

	[Address(RVA = "0x2882F70", Offset = "0x2882370", Length = "0xA0")]
	[Token(Token = "0x60006C1")]
	public void GenerateImpulseWithForce(float force) { }

	[Address(RVA = "0x2883020", Offset = "0x2882420", Length = "0x7B")]
	[Token(Token = "0x60006C0")]
	public void GenerateImpulseWithVelocity(Vector3 velocity) { }

	[Address(RVA = "0x2883130", Offset = "0x2882530", Length = "0x1D")]
	[Token(Token = "0x60006BD")]
	private void OnValidate() { }

	[Address(RVA = "0x2883150", Offset = "0x2882550", Length = "0x10F")]
	[Token(Token = "0x60006BE")]
	private void Reset() { }

}

