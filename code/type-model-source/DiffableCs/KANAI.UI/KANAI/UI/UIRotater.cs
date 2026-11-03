namespace KANAI.UI;

[Token(Token = "0x200003C")]
public class UIRotater : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000189")]
	private Transform _transformCache; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400018A")]
	private Quaternion _rotation; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400018B")]
	private Vector3 _eulerAngle; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400018C")]
	private float _step; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400018D")]
	private float _tnow; //Field offset: 0x48

	[Address(RVA = "0x1E26950", Offset = "0x1E25D50", Length = "0x82")]
	[Token(Token = "0x60001A1")]
	public UIRotater() { }

	[Address(RVA = "0x1E266F0", Offset = "0x1E25AF0", Length = "0x7C")]
	[Token(Token = "0x600019F")]
	private void Awake() { }

	[Address(RVA = "0x1E26770", Offset = "0x1E25B70", Length = "0x1DF")]
	[Token(Token = "0x60001A0")]
	public void ProgressRotate(float dt) { }

}

