namespace InGame.Kernel.Player;

[Token(Token = "0x2000123")]
public class SuperFighterOptions : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000831")]
	private float _rotateSpeed; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000832")]
	private Vector3 _basePosition; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000833")]
	private float _rotateZ; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000834")]
	private Transform _transformCache; //Field offset: 0x38

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000921")]
	public SuperFighterOptions() { }

	[Address(RVA = "0x1D518D0", Offset = "0x1D50CD0", Length = "0x3F")]
	[Token(Token = "0x600091D")]
	public void InitialParams() { }

	[Address(RVA = "0x1D51910", Offset = "0x1D50D10", Length = "0x3F")]
	[Token(Token = "0x600091F")]
	public void SetRotateSpeed(float eulerSpeed, bool isInitialize, bool isDisplay) { }

	[Address(RVA = "0x1D51950", Offset = "0x1D50D50", Length = "0x205")]
	[Token(Token = "0x6000920")]
	public void UpdatePosition(Vector3 fighterPosition, Vector3 leftBottomClampPosition, Vector3 rightUpClampPosition, float dt) { }

	[Address(RVA = "0x1D51B60", Offset = "0x1D50F60", Length = "0x42")]
	[Token(Token = "0x600091E")]
	private void UpdateRotate(float dt) { }

}

