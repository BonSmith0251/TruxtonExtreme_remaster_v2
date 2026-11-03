//Type is in global namespace

[Token(Token = "0x2000003")]
public class SphereContact : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000001")]
	private Transform sp1t; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000002")]
	private Vector3 vel1; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000003")]
	private float r1; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000004")]
	private Transform da1; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000005")]
	private Transform da2; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000006")]
	private Transform da3; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Space]
	[Token(Token = "0x4000007")]
	private Transform sp2t; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000008")]
	private Vector3 vel2; //Field offset: 0x58
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x4000009")]
	private float r2; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400000A")]
	private Transform db1; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400000B")]
	private Transform db2; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400000C")]
	private Transform db3; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x400000D")]
	private bool oncontact; //Field offset: 0x80

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000003")]
	public SphereContact() { }

	[Address(RVA = "0x5D3D60", Offset = "0x5D3160", Length = "0x375")]
	[Token(Token = "0x6000002")]
	private void Update() { }

}

