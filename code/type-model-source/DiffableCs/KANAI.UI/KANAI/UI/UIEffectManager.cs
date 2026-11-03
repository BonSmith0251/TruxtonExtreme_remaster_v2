namespace KANAI.UI;

[Token(Token = "0x2000017")]
public class UIEffectManager : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400006B")]
	private int _touchEffectMax; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400006C")]
	private int _touchEffectIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400006D")]
	private UIEffectUnit[] _units; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400006E")]
	private Camera _uiCamera; //Field offset: 0x30

	[Address(RVA = "0x1E19F80", Offset = "0x1E19380", Length = "0xBF")]
	[Token(Token = "0x600007A")]
	private UIEffectUnit _getUnit() { }

	[Address(RVA = "0x1E19F70", Offset = "0x1E19370", Length = "0xE")]
	[Token(Token = "0x600007B")]
	public UIEffectManager() { }

	[Address(RVA = "0x1E19AF0", Offset = "0x1E18EF0", Length = "0x27D")]
	[Token(Token = "0x6000078")]
	public void Initialize(Camera uiCamera, GameObject effectPrefab) { }

	[Address(RVA = "0x1E19D70", Offset = "0x1E19170", Length = "0x1F0")]
	[Token(Token = "0x6000079")]
	private void Update() { }

}

