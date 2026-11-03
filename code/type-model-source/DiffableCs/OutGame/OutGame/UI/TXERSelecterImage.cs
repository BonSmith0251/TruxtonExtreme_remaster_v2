namespace OutGame.UI;

[Token(Token = "0x2000159")]
public class TXERSelecterImage : UISlideSelecter
{
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400060D")]
	private TXEBaseWindow _window; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400060E")]
	private Image _labelImage; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400060F")]
	private bool _isLoop; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x4000610")]
	private bool _isSelected; //Field offset: 0x51
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000611")]
	private List<Sprite> _sprites; //Field offset: 0x58

	[Address(RVA = "0x2206090", Offset = "0x2205490", Length = "0x7B")]
	[Token(Token = "0x60008B1")]
	public TXERSelecterImage() { }

	[Address(RVA = "0x2205D00", Offset = "0x2205100", Length = "0xA9")]
	[Token(Token = "0x60008AD")]
	public void AddSpritesLabel(Sprite sprites) { }

	[Address(RVA = "0x2205DB0", Offset = "0x22051B0", Length = "0x72")]
	[Token(Token = "0x60008AE")]
	public Sprite GetSpritesLabel(int tno) { }

	[Address(RVA = "0x2205E30", Offset = "0x2205230", Length = "0x74")]
	[Token(Token = "0x60008AA")]
	public virtual void Initialize() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[Token(Token = "0x60008B0")]
	public virtual bool IsLoop() { }

	[Address(RVA = "0x2205EB0", Offset = "0x22052B0", Length = "0xB3")]
	[Token(Token = "0x60008AF")]
	public void RestoreSprites(Sprite[] tsprites) { }

	[Address(RVA = "0x2205F70", Offset = "0x2205370", Length = "0x89")]
	[Token(Token = "0x60008AC")]
	public virtual void Selected(bool isSelect) { }

	[Address(RVA = "0x2206000", Offset = "0x2205400", Length = "0x86")]
	[Token(Token = "0x60008AB")]
	public virtual void SetIndex(int n) { }

}

