namespace OutGame.UI;

[Token(Token = "0x200015A")]
public class TXERSelecterNumber : UISlideSelecter
{
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000612")]
	private TXEBaseWindow _window; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000613")]
	private UITextMeshPro _labelText; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000614")]
	private int _numMax; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000615")]
	private float _multiplier; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000616")]
	private string _format; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000617")]
	private bool _isLoop; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[SerializeField]
	[Token(Token = "0x4000618")]
	private bool _isZeroStart; //Field offset: 0x61
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x4000619")]
	private bool _isSelected; //Field offset: 0x62

	[Address(RVA = "0x2206460", Offset = "0x2205860", Length = "0x63")]
	[Token(Token = "0x60008BA")]
	public TXERSelecterNumber() { }

	[Address(RVA = "0x2206110", Offset = "0x2205510", Length = "0x1A")]
	[Token(Token = "0x60008B7")]
	public float GetMultipledValue() { }

	[Address(RVA = "0x2206130", Offset = "0x2205530", Length = "0xE")]
	[Token(Token = "0x60008B6")]
	public int GetValue() { }

	[Address(RVA = "0x2206140", Offset = "0x2205540", Length = "0x3B")]
	[Token(Token = "0x60008B2")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[Token(Token = "0x60008B9")]
	public virtual bool IsLoop() { }

	[Address(RVA = "0x2206180", Offset = "0x2205580", Length = "0x89")]
	[Token(Token = "0x60008B8")]
	public virtual void Selected(bool isSelect) { }

	[Address(RVA = "0x2206210", Offset = "0x2205610", Length = "0x104")]
	[Token(Token = "0x60008B3")]
	public virtual void SetIndex(int n) { }

	[Address(RVA = "0x2206320", Offset = "0x2205720", Length = "0x111")]
	[Token(Token = "0x60008B5")]
	public void SetMultipledValue(float n) { }

	[Address(RVA = "0x2206440", Offset = "0x2205840", Length = "0x1F")]
	[Token(Token = "0x60008B4")]
	public void SetValue(int n) { }

}

