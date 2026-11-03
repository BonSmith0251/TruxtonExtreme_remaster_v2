namespace OutGame.UI;

[Token(Token = "0x2000104")]
public class AchievementList : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000448")]
	private RectTransform _contentTransform; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000449")]
	private AchievementListOne _listOne; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400044A")]
	private RectTransform _scrollRectTransform; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400044B")]
	private ScrollRect _scrollRect; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400044C")]
	private VerticalLayoutGroup _verticalLayoutGroup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400044D")]
	private RectTransform _nodeTransform; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400044E")]
	private List<AchievementListOne> listAll; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400044F")]
	private int _topIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000450")]
	private bool prevMoveIsUp; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000451")]
	private int _dispMax; //Field offset: 0x60

	[Token(Token = "0x17000189")]
	public int Count
	{
		[Address(RVA = "0x21E72C0", Offset = "0x21E66C0", Length = "0x3C")]
		[Token(Token = "0x6000691")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x21E70C0", Offset = "0x21E64C0", Length = "0x82")]
	[Token(Token = "0x6000697")]
	public AchievementList() { }

	[Address(RVA = "0x21E7150", Offset = "0x21E6550", Length = "0x117")]
	[Token(Token = "0x6000690")]
	public bool add(ID achievementIndex) { }

	[Address(RVA = "0x21E7270", Offset = "0x21E6670", Length = "0x2C")]
	[Token(Token = "0x6000695")]
	private float calcByBottom(float nodeSize, float rate, float spacing, float viewportSize) { }

	[Address(RVA = "0x21E72A0", Offset = "0x21E66A0", Length = "0x1D")]
	[Token(Token = "0x6000694")]
	private float calcByTop(float nodeSize, float rate) { }

	[Address(RVA = "0x21E72C0", Offset = "0x21E66C0", Length = "0x3C")]
	[Token(Token = "0x6000691")]
	public int get_Count() { }

	[Address(RVA = "0x21E7300", Offset = "0x21E6700", Length = "0x8")]
	[Token(Token = "0x6000692")]
	public void move(int dist) { }

	[Address(RVA = "0x21E7310", Offset = "0x21E6710", Length = "0x186")]
	[Token(Token = "0x6000696")]
	private void scroll(int dist) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600068E")]
	private void Start() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600068F")]
	private void Update() { }

	[Address(RVA = "0x21E74A0", Offset = "0x21E68A0", Length = "0xAF")]
	[Token(Token = "0x6000693")]
	private void updateIndex(int dist) { }

}

