namespace KANAI.UI;

[Token(Token = "0x200002B")]
public class UILamp : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000143")]
	private bool _isStartOn; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000144")]
	private Image _targetSprite; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000145")]
	private bool _isOn; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000146")]
	private float _toTime; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000147")]
	private float _currnetTime; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000148")]
	private Color _color; //Field offset: 0x3C

	[Token(Token = "0x17000027")]
	public bool IsOn
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000129")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1E21F60", Offset = "0x1E21360", Length = "0x55")]
	[Token(Token = "0x6000128")]
	private void _updateLamp(float a) { }

	[Address(RVA = "0x1E21F40", Offset = "0x1E21340", Length = "0x13")]
	[Token(Token = "0x600012A")]
	public UILamp() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000129")]
	public bool get_IsOn() { }

	[Address(RVA = "0x1D214A0", Offset = "0x1D208A0", Length = "0x14")]
	[Token(Token = "0x6000124")]
	public override void Initialize() { }

	[Address(RVA = "0x1E21DC0", Offset = "0x1E211C0", Length = "0x74")]
	[Token(Token = "0x6000126")]
	public override bool OnLamp(bool v, float toTime) { }

	[Address(RVA = "0x1E21E40", Offset = "0x1E21240", Length = "0x94")]
	[Token(Token = "0x6000127")]
	public override void ProgressLamp(float dt) { }

	[Address(RVA = "0x1E21EE0", Offset = "0x1E212E0", Length = "0x56")]
	[Token(Token = "0x6000125")]
	public override void Reset() { }

}

