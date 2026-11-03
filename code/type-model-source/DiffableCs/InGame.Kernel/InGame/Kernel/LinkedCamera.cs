namespace InGame.Kernel;

[Token(Token = "0x200009C")]
public class LinkedCamera : CinemachineBrain
{
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40004C9")]
	private Camera _camera; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40004CA")]
	private Transform _parentTransform; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40004CB")]
	private Transform _transformCache; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x40004CC")]
	private bool _linkRotate; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1B9")]
	[SerializeField]
	[Token(Token = "0x40004CD")]
	private bool _linkTranslate; //Field offset: 0x1B9
	[FieldOffset(Offset = "0x1BA")]
	[SerializeField]
	[Token(Token = "0x40004CE")]
	private bool _linkShift; //Field offset: 0x1BA
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x40004CF")]
	private Vector2 _lensShiftValue; //Field offset: 0x1BC

	[Token(Token = "0x1700011A")]
	public bool LinkRotate
	{
		[Address(RVA = "0x1D39AB0", Offset = "0x1D38EB0", Length = "0x8")]
		[Token(Token = "0x60005C5")]
		 get { } //Length: 8
		[Address(RVA = "0x1D39AE0", Offset = "0x1D38EE0", Length = "0x7")]
		[Token(Token = "0x60005C4")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700011C")]
	public bool LinkShift
	{
		[Address(RVA = "0x1D39AC0", Offset = "0x1D38EC0", Length = "0x8")]
		[Token(Token = "0x60005C9")]
		 get { } //Length: 8
		[Address(RVA = "0x1D39AF0", Offset = "0x1D38EF0", Length = "0x7")]
		[Token(Token = "0x60005C8")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700011B")]
	public bool LinkTranslate
	{
		[Address(RVA = "0x1D39AD0", Offset = "0x1D38ED0", Length = "0x8")]
		[Token(Token = "0x60005C7")]
		 get { } //Length: 8
		[Address(RVA = "0x1D39B00", Offset = "0x1D38F00", Length = "0x7")]
		[Token(Token = "0x60005C6")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x1D39A60", Offset = "0x1D38E60", Length = "0x49")]
	[Token(Token = "0x60005CA")]
	public LinkedCamera() { }

	[Address(RVA = "0x1D398F0", Offset = "0x1D38CF0", Length = "0x78")]
	[Token(Token = "0x60005C0")]
	private void Awake() { }

	[Address(RVA = "0x1D39AB0", Offset = "0x1D38EB0", Length = "0x8")]
	[Token(Token = "0x60005C5")]
	public bool get_LinkRotate() { }

	[Address(RVA = "0x1D39AC0", Offset = "0x1D38EC0", Length = "0x8")]
	[Token(Token = "0x60005C9")]
	public bool get_LinkShift() { }

	[Address(RVA = "0x1D39AD0", Offset = "0x1D38ED0", Length = "0x8")]
	[Token(Token = "0x60005C7")]
	public bool get_LinkTranslate() { }

	[Address(RVA = "0x1D39970", Offset = "0x1D38D70", Length = "0x9B")]
	[Token(Token = "0x60005C1")]
	protected void LateUpdate() { }

	[Address(RVA = "0x1D39AE0", Offset = "0x1D38EE0", Length = "0x7")]
	[Token(Token = "0x60005C4")]
	public void set_LinkRotate(bool value) { }

	[Address(RVA = "0x1D39AF0", Offset = "0x1D38EF0", Length = "0x7")]
	[Token(Token = "0x60005C8")]
	public void set_LinkShift(bool value) { }

	[Address(RVA = "0x1D39B00", Offset = "0x1D38F00", Length = "0x7")]
	[Token(Token = "0x60005C6")]
	public void set_LinkTranslate(bool value) { }

	[Address(RVA = "0x1D39A10", Offset = "0x1D38E10", Length = "0xF")]
	[Token(Token = "0x60005C3")]
	public void SetLensShift(Vector2 v) { }

	[Address(RVA = "0x1D39A20", Offset = "0x1D38E20", Length = "0x3B")]
	[Token(Token = "0x60005C2")]
	public void SetParentCamera(Camera p) { }

}

