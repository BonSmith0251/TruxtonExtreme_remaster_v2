namespace InGame.UI;

[Token(Token = "0x2000011")]
public class UIBGMName : MonoBehaviour
{
	[Token(Token = "0x4000035")]
	private static readonly float DelaySecond; //Field offset: 0x0
	[Token(Token = "0x4000036")]
	private static readonly float DisplaySecond; //Field offset: 0x4
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000037")]
	private TXEUIFontText _text; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000038")]
	private UIImage _icon; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000039")]
	private CanvasGroup _canvas; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400003A")]
	private Canvas _mainCanvas; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400003B")]
	private float _displaySecond; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400003C")]
	private float _effectSecond; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400003D")]
	private float _delaySecond; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400003E")]
	private bool _isDisplayMode; //Field offset: 0x4C
	[FieldOffset(Offset = "0x4D")]
	[Token(Token = "0x400003F")]
	private bool _isFadein; //Field offset: 0x4D

	[Address(RVA = "0x1DD4960", Offset = "0x1DD3D60", Length = "0x4E")]
	[Token(Token = "0x600004A")]
	private static UIBGMName() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000049")]
	public UIBGMName() { }

	[Address(RVA = "0x1DD4610", Offset = "0x1DD3A10", Length = "0x48")]
	[Token(Token = "0x6000044")]
	public void Initialize() { }

	[Address(RVA = "0x1DD4660", Offset = "0x1DD3A60", Length = "0xB1")]
	[Token(Token = "0x6000048")]
	public void Progress(float dt) { }

	[Address(RVA = "0x1DD4720", Offset = "0x1DD3B20", Length = "0x1A3")]
	[Token(Token = "0x6000046")]
	public void SetBGMName(string ttext) { }

	[Address(RVA = "0x1DD48D0", Offset = "0x1DD3CD0", Length = "0x6C")]
	[Token(Token = "0x6000047")]
	private void SetDisplay(bool isActive) { }

	[Address(RVA = "0x1DD4940", Offset = "0x1DD3D40", Length = "0x19")]
	[Token(Token = "0x6000045")]
	public void Terminate() { }

}

