namespace OutGame.UI;

[Token(Token = "0x200013F")]
public class ServiceRecordList : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000550")]
	private RectTransform _contentTransform; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000551")]
	private ServiceRecordListOne _listOne; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000552")]
	private ServiceRecordListOne2 _listOne2; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000553")]
	private RectTransform _scrollRectTransform; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000554")]
	private ScrollRect _scrollRect; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000555")]
	private VerticalLayoutGroup _verticalLayoutGroup; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000556")]
	private RectTransform _nodeTransform; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000557")]
	private List<ServiceRecordListOne> listAll; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000558")]
	private int _topIndex; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000559")]
	private int _dispMax; //Field offset: 0x64

	[Token(Token = "0x170001C7")]
	public int Count
	{
		[Address(RVA = "0x2201020", Offset = "0x2200420", Length = "0x3C")]
		[Token(Token = "0x60007E6")]
		 get { } //Length: 60
	}

	[Token(Token = "0x170001C8")]
	public int DispMax
	{
		[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
		[Token(Token = "0x60007EB")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2200AA0", Offset = "0x21FFEA0", Length = "0x7E")]
	[Token(Token = "0x60007EC")]
	public ServiceRecordList() { }

	[Address(RVA = "0x2200D40", Offset = "0x2200140", Length = "0x140")]
	[Token(Token = "0x60007E4")]
	public void add(string labelKey, string points, string level) { }

	[Address(RVA = "0x2200E90", Offset = "0x2200290", Length = "0x18C")]
	[Token(Token = "0x60007E5")]
	public void add(int itemIndex, string points, string level) { }

	[Address(RVA = "0x2200C50", Offset = "0x2200050", Length = "0xE0")]
	[Token(Token = "0x60007E8")]
	private void addList(ServiceRecordListOne listOne, string labelKey, string points, string level) { }

	[Address(RVA = "0x2200B20", Offset = "0x21FFF20", Length = "0x12C")]
	[Token(Token = "0x60007E9")]
	private void addList(ServiceRecordListOne2 listOne2, int itemIndex, string points, string level) { }

	[Address(RVA = "0x2201020", Offset = "0x2200420", Length = "0x3C")]
	[Token(Token = "0x60007E6")]
	public int get_Count() { }

	[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
	[Token(Token = "0x60007EB")]
	public int get_DispMax() { }

	[Address(RVA = "0x2201060", Offset = "0x2200460", Length = "0x8")]
	[Token(Token = "0x60007E7")]
	public void move(int dist) { }

	[Address(RVA = "0x22008C0", Offset = "0x21FFCC0", Length = "0x1DB")]
	[Token(Token = "0x60007EA")]
	private void Scroll(int dist) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007E2")]
	private void Start() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007E3")]
	private void Update() { }

}

