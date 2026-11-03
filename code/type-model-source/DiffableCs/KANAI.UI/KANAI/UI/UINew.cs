namespace KANAI.UI;

[Token(Token = "0x200003A")]
public class UINew : UIBase
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000180")]
	private UIBlinker uIBlinker; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000181")]
	protected UIImage _image; //Field offset: 0x30

	[Token(Token = "0x17000033")]
	public bool BlinkFlg
	{
		[Address(RVA = "0x1E26240", Offset = "0x1E25640", Length = "0x1B")]
		[Token(Token = "0x6000195")]
		 get { } //Length: 27
		[Address(RVA = "0x1E263E0", Offset = "0x1E257E0", Length = "0x23")]
		[Token(Token = "0x6000196")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000032")]
	public bool Enable
	{
		[Address(RVA = "0x1E26260", Offset = "0x1E25660", Length = "0x1B")]
		[Token(Token = "0x6000193")]
		 get { } //Length: 27
		[Address(RVA = "0x1E26410", Offset = "0x1E25810", Length = "0x20")]
		[Token(Token = "0x6000194")]
		 set { } //Length: 32
	}

	[Address(RVA = "0x1E261A0", Offset = "0x1E255A0", Length = "0x92")]
	[Token(Token = "0x6000197")]
	public UINew() { }

	[Address(RVA = "0x1E26240", Offset = "0x1E25640", Length = "0x1B")]
	[Token(Token = "0x6000195")]
	public bool get_BlinkFlg() { }

	[Address(RVA = "0x1E26260", Offset = "0x1E25660", Length = "0x1B")]
	[Token(Token = "0x6000193")]
	public bool get_Enable() { }

	[Address(RVA = "0x1E263E0", Offset = "0x1E257E0", Length = "0x23")]
	[Token(Token = "0x6000196")]
	public void set_BlinkFlg(bool value) { }

	[Address(RVA = "0x1E26410", Offset = "0x1E25810", Length = "0x20")]
	[Token(Token = "0x6000194")]
	public void set_Enable(bool value) { }

	[Address(RVA = "0x1E26280", Offset = "0x1E25680", Length = "0x154")]
	[Token(Token = "0x6000192")]
	private void setCursor() { }

	[Address(RVA = "0x1E26140", Offset = "0x1E25540", Length = "0x21")]
	[Token(Token = "0x6000190")]
	private void Start() { }

	[Address(RVA = "0x1E26170", Offset = "0x1E25570", Length = "0x28")]
	[Token(Token = "0x6000191")]
	private void Update() { }

}

