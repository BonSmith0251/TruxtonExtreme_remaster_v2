namespace KANAI.UI;

[Token(Token = "0x2000024")]
public class UIImage : Image
{
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40000E2")]
	private CanvasRenderer _canvas; //Field offset: 0x120

	[Address(RVA = "0x1E1FDE0", Offset = "0x1E1F1E0", Length = "0x49")]
	[Token(Token = "0x60000FB")]
	public UIImage() { }

	[Address(RVA = "0x1E1FD70", Offset = "0x1E1F170", Length = "0x4A")]
	[Token(Token = "0x60000F9")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1E1FDC0", Offset = "0x1E1F1C0", Length = "0x15")]
	[Token(Token = "0x60000FA")]
	public void SetAlpha(float talpha) { }

}

