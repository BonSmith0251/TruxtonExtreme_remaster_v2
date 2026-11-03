namespace OutGame.UI;

[Token(Token = "0x200010F")]
public class EndingPopupContent : PopupContentBase
{
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400048B")]
	private Sprite _windowTexture; //Field offset: 0x60

	[Address(RVA = "0x21E8C30", Offset = "0x21E8030", Length = "0x7")]
	[Token(Token = "0x60006D9")]
	public EndingPopupContent() { }

	[Address(RVA = "0x21E8980", Offset = "0x21E7D80", Length = "0xCA")]
	[Token(Token = "0x60006D7")]
	public virtual void ContentUpdate() { }

	[Address(RVA = "0x21E8A50", Offset = "0x21E7E50", Length = "0x8D")]
	[Token(Token = "0x60006D5")]
	public virtual void CreatedWindow() { }

	[Address(RVA = "0x21E8AE0", Offset = "0x21E7EE0", Length = "0x60")]
	[Token(Token = "0x60006D4")]
	public virtual void Initialize() { }

	[Address(RVA = "0x21E8B50", Offset = "0x21E7F50", Length = "0xA2")]
	[Token(Token = "0x60006D6")]
	public virtual void StartActive() { }

	[Address(RVA = "0x21E8C00", Offset = "0x21E8000", Length = "0x26")]
	[Token(Token = "0x60006D8")]
	public virtual void Terminate() { }

}

