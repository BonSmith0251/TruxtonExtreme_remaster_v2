namespace KANAI.UI;

[RequireComponent(typeof(UIImage))]
[Token(Token = "0x2000025")]
public class UIImageColor : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E3")]
	private UIImage _image; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000E4")]
	private Color _baseColor; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40000E5")]
	private Color _targetColor; //Field offset: 0x38

	[Address(RVA = "0x1E1FD50", Offset = "0x1E1F150", Length = "0x17")]
	[Token(Token = "0x60000FE")]
	public UIImageColor() { }

	[Address(RVA = "0x1E1FC20", Offset = "0x1E1F020", Length = "0x3D")]
	[Token(Token = "0x60000FC")]
	private void Awake() { }

	[Address(RVA = "0x1E1FC60", Offset = "0x1E1F060", Length = "0xE2")]
	[Token(Token = "0x60000FD")]
	public void LerpColor(float rate) { }

}

