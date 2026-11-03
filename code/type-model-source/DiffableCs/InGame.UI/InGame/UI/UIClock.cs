namespace InGame.UI;

[Token(Token = "0x2000013")]
public class UIClock : MonoBehaviour
{
	[Token(Token = "0x2000014")]
	private enum ClockType : int
	{
		None = 0,
		Hour12 = 1,
		Hour24 = 2,
	}

	[Token(Token = "0x2000015")]
	private enum NumKind : int
	{
		Hour10 = 0,
		Hour00 = 1,
		Minutes10 = 2,
		Minutes00 = 3,
		Separate = 4,
		AM = 5,
		PM = 6,
	}

	[Token(Token = "0x4000051")]
	private static readonly int ImageCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000049")]
	private Sprite[] _numSprites; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400004A")]
	private UIImage[] _images; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400004B")]
	private int _numHour; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400004C")]
	private int _numDispHour; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400004D")]
	private int _numMinutes; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400004E")]
	private int _counter; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400004F")]
	private int _clockType; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000050")]
	private bool _isDisplay; //Field offset: 0x44

	[Address(RVA = "0x1DD58C0", Offset = "0x1DD4CC0", Length = "0x39")]
	[Token(Token = "0x600005F")]
	private static UIClock() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600005E")]
	public UIClock() { }

	[Address(RVA = "0x1DD5210", Offset = "0x1DD4610", Length = "0x48")]
	[Token(Token = "0x600005D")]
	private Sprite GetSprite(int tindex) { }

	[Address(RVA = "0x1DD5260", Offset = "0x1DD4660", Length = "0x26")]
	[Token(Token = "0x6000058")]
	public void Initialize() { }

	[Address(RVA = "0x1DD5290", Offset = "0x1DD4690", Length = "0x139")]
	[Token(Token = "0x600005C")]
	public void SetCurrentDisplay(bool isDisplay) { }

	[Address(RVA = "0x1DD53D0", Offset = "0x1DD47D0", Length = "0x139")]
	[Token(Token = "0x600005B")]
	public void SetDisplay(int clockType) { }

	[Address(RVA = "0x1DD5510", Offset = "0x1DD4910", Length = "0x37A")]
	[Token(Token = "0x600005A")]
	public void SetTime(int thour, int tminutes) { }

	[Address(RVA = "0x1DD5890", Offset = "0x1DD4C90", Length = "0x26")]
	[Token(Token = "0x6000059")]
	public void Terminate() { }

}

