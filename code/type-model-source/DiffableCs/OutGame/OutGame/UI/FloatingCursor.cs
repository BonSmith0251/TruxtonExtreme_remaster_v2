namespace OutGame.UI;

[Token(Token = "0x2000116")]
public class FloatingCursor : MonoBehaviour
{
	[Token(Token = "0x2000117")]
	internal enum CursorState : int
	{
		None = 0,
		Locked = 1,
		Moving = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004A1")]
	private UIImage _cursorImage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004A2")]
	private float _moveTime; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004A3")]
	private UIBlinker uIBlinker; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004A4")]
	private RectTransform targetTransform; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004A5")]
	private CursorState state; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40004A6")]
	private float nowTime; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004A7")]
	private Vector3 startPosition; //Field offset: 0x48
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40004A8")]
	private bool _hideFlg; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004A9")]
	private Vector3 _posOffset; //Field offset: 0x58

	[Token(Token = "0x1700019B")]
	public bool HideFlg
	{
		[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
		[Token(Token = "0x6000701")]
		 get { } //Length: 5
		[Address(RVA = "0x1CEB110", Offset = "0x1CEA510", Length = "0x4")]
		[Token(Token = "0x6000702")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700019C")]
	public Vector3 posOffset
	{
		[Address(RVA = "0x21EA5E0", Offset = "0x21E99E0", Length = "0x13")]
		[Token(Token = "0x6000703")]
		 get { } //Length: 19
		[Address(RVA = "0x21EA7E0", Offset = "0x21E9BE0", Length = "0x10")]
		[Token(Token = "0x6000704")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x21EA510", Offset = "0x21E9910", Length = "0xCC")]
	[Token(Token = "0x6000705")]
	public FloatingCursor() { }

	[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
	[Token(Token = "0x6000701")]
	public bool get_HideFlg() { }

	[Address(RVA = "0x21EA5E0", Offset = "0x21E99E0", Length = "0x13")]
	[Token(Token = "0x6000703")]
	public Vector3 get_posOffset() { }

	[Address(RVA = "0x21EA600", Offset = "0x21E9A00", Length = "0x24")]
	[Token(Token = "0x60006FD")]
	public void initializePosition(RectTransform target) { }

	[Address(RVA = "0x21EA630", Offset = "0x21E9A30", Length = "0x8")]
	[Token(Token = "0x60006FF")]
	public bool isMoving() { }

	[Address(RVA = "0x1CEB110", Offset = "0x1CEA510", Length = "0x4")]
	[Token(Token = "0x6000702")]
	public void set_HideFlg(bool value) { }

	[Address(RVA = "0x21EA7E0", Offset = "0x21E9BE0", Length = "0x10")]
	[Token(Token = "0x6000704")]
	public void set_posOffset(Vector3 value) { }

	[Address(RVA = "0x21EA640", Offset = "0x21E9A40", Length = "0x193")]
	[Token(Token = "0x60006FE")]
	public void setTarget(RectTransform target, bool flyFlg) { }

	[Address(RVA = "0x1BC3770", Offset = "0x1BC2B70", Length = "0x8")]
	[Token(Token = "0x60006FC")]
	private void Start() { }

	[Address(RVA = "0x21EA290", Offset = "0x21E9690", Length = "0x276")]
	[Token(Token = "0x6000700")]
	private void Update() { }

}

