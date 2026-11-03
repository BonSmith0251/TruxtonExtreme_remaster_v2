namespace KANAI.UI;

[Token(Token = "0x200003B")]
public class UIPingPong : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000182")]
	private Transform _transformCache; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000183")]
	private Vector3 _length; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Range(0, 10)]
	[SerializeField]
	[Token(Token = "0x4000184")]
	private float _pinponRate; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000185")]
	private float _pinpongSpeed; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000186")]
	private float _localTime; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000187")]
	private Vector3 _localpos; //Field offset: 0x40
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000188")]
	private Quaternion _localrot; //Field offset: 0x4C

	[Address(RVA = "0x1E26620", Offset = "0x1E25A20", Length = "0xC9")]
	[Token(Token = "0x600019E")]
	public UIPingPong() { }

	[Address(RVA = "0x1E26440", Offset = "0x1E25840", Length = "0x4A")]
	[Token(Token = "0x6000199")]
	private void FixedUpdate() { }

	[Address(RVA = "0x1D64A10", Offset = "0x1D63E10", Length = "0x2D")]
	[Token(Token = "0x600019A")]
	public void SetActive(bool isActvie) { }

	[Address(RVA = "0x1E26490", Offset = "0x1E25890", Length = "0x1E")]
	[Token(Token = "0x600019C")]
	public void SetLocalPosition(Vector3 lpos, Quaternion lrot) { }

	[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
	[Token(Token = "0x600019B")]
	public void SetSpeed(float tspeed) { }

	[Address(RVA = "0x1E264C0", Offset = "0x1E258C0", Length = "0xA0")]
	[Token(Token = "0x6000198")]
	private void Start() { }

	[Address(RVA = "0x1E26570", Offset = "0x1E25970", Length = "0xA0")]
	[Token(Token = "0x600019D")]
	private void UpdatePosition() { }

}

