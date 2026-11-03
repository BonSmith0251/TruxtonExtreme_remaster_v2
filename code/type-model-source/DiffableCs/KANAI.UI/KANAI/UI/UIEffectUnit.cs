namespace KANAI.UI;

[Token(Token = "0x2000018")]
public class UIEffectUnit : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400006F")]
	private Animator _animator; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000070")]
	private float _aliveTime; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000071")]
	private Camera _uiCamera; //Field offset: 0x30

	[Address(RVA = "0x1E1A230", Offset = "0x1E19630", Length = "0xCE")]
	[Token(Token = "0x600007F")]
	private bool _isAlive() { }

	[Address(RVA = "0x1E1A220", Offset = "0x1E19620", Length = "0xE")]
	[Token(Token = "0x6000080")]
	public UIEffectUnit() { }

	[Address(RVA = "0x1E1A040", Offset = "0x1E19440", Length = "0x3C")]
	[Token(Token = "0x600007C")]
	public void Initialize(Camera iCamera) { }

	[Address(RVA = "0x1E1A080", Offset = "0x1E19480", Length = "0xEC")]
	[Token(Token = "0x600007E")]
	private void LateUpdate() { }

	[Address(RVA = "0x1E1A170", Offset = "0x1E19570", Length = "0xAC")]
	[Token(Token = "0x600007D")]
	public void StartEffect(Vector3 pos) { }

}

