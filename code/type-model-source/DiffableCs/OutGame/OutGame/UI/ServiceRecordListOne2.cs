namespace OutGame.UI;

[Token(Token = "0x2000141")]
public class ServiceRecordListOne2 : ServiceRecordListOne
{
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400055D")]
	private Sprite[] _itemIcons; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400055E")]
	private UIImage _item; //Field offset: 0x40

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60007F2")]
	public ServiceRecordListOne2() { }

	[Address(RVA = "0x22007A0", Offset = "0x21FFBA0", Length = "0x9D")]
	[Token(Token = "0x60007F1")]
	public void set(int itemIndex, string points, string level) { }

}

