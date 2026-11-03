namespace TXEKernel;

[Token(Token = "0x20000F8")]
public class TXEUIFontText : UITextMeshPro
{

	[Address(RVA = "0x2718A90", Offset = "0x2717E90", Length = "0x83")]
	[Token(Token = "0x600072C")]
	protected virtual void _Setup(string nstr) { }

	[Address(RVA = "0x2718B20", Offset = "0x2717F20", Length = "0x49")]
	[Token(Token = "0x600072E")]
	public TXEUIFontText() { }

	[Address(RVA = "0x2718A70", Offset = "0x2717E70", Length = "0x1B")]
	[Token(Token = "0x600072B")]
	public virtual void AwakeSetup() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600072D")]
	protected virtual void UpdateColors() { }

}

