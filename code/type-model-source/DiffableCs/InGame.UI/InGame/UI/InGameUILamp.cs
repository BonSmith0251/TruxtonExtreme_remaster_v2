namespace InGame.UI;

[Token(Token = "0x2000005")]
public class InGameUILamp : UILamp
{
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000008")]
	private UISpriteAnime _flashLamp; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000009")]
	private bool _isFlashAnime; //Field offset: 0x58

	[Address(RVA = "0x1DD2170", Offset = "0x1DD1570", Length = "0x7")]
	[Token(Token = "0x600000A")]
	public InGameUILamp() { }

	[Address(RVA = "0x1DD2040", Offset = "0x1DD1440", Length = "0x2C")]
	[Token(Token = "0x6000006")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1DD2070", Offset = "0x1DD1470", Length = "0x57")]
	[Token(Token = "0x6000009")]
	public virtual bool OnLamp(bool v, float toTime) { }

	[Address(RVA = "0x1DD20D0", Offset = "0x1DD14D0", Length = "0x60")]
	[Token(Token = "0x6000008")]
	public virtual void ProgressLamp(float dt) { }

	[Address(RVA = "0x1DD2140", Offset = "0x1DD1540", Length = "0x2F")]
	[Token(Token = "0x6000007")]
	public virtual void Reset() { }

}

