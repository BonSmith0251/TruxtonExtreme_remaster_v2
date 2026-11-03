namespace InGame.Kernel.Item;

[Token(Token = "0x2000147")]
public class ItemRotater : MonoBehaviour
{
	[Token(Token = "0x4000954")]
	private static readonly float RotateSpeed; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000955")]
	private Transform _transformCache; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000956")]
	private Vector3 _rotVector; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000957")]
	private Vector3 _currentRotate; //Field offset: 0x34

	[Address(RVA = "0x1D716A0", Offset = "0x1D70AA0", Length = "0x39")]
	[Token(Token = "0x6000A36")]
	private static ItemRotater() { }

	[Address(RVA = "0x1D716E0", Offset = "0x1D70AE0", Length = "0x8A")]
	[Token(Token = "0x6000A35")]
	public ItemRotater() { }

	[Address(RVA = "0x1D3B2E0", Offset = "0x1D3A6E0", Length = "0x25")]
	[Token(Token = "0x6000A33")]
	private void Start() { }

	[Address(RVA = "0x1D714D0", Offset = "0x1D708D0", Length = "0x1C2")]
	[Token(Token = "0x6000A34")]
	private void Update() { }

}

