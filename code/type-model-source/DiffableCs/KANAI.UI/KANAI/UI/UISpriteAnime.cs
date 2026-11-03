namespace KANAI.UI;

[Token(Token = "0x200003F")]
public class UISpriteAnime : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400019C")]
	private UIImage _baseImage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400019D")]
	private float _displayTime; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400019E")]
	private Sprite[] _sprites; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400019F")]
	private bool _isLoop; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x40001A0")]
	private bool _isEnd; //Field offset: 0x39
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40001A1")]
	private float _passedTime; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001A2")]
	private int _displayNo; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40001A3")]
	private int _displayMax; //Field offset: 0x44

	[Token(Token = "0x17000034")]
	public bool IsEnd
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[Token(Token = "0x60001C0")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1E276A0", Offset = "0x1E26AA0", Length = "0xAB")]
	[Token(Token = "0x60001BF")]
	private void _updateTime(float dt) { }

	[Address(RVA = "0x1E1A220", Offset = "0x1E19620", Length = "0xE")]
	[Token(Token = "0x60001C1")]
	public UISpriteAnime() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[Token(Token = "0x60001C0")]
	public bool get_IsEnd() { }

	[Address(RVA = "0x1E27570", Offset = "0x1E26970", Length = "0x3A")]
	[Token(Token = "0x60001BC")]
	public void Initialize() { }

	[Address(RVA = "0x1E275B0", Offset = "0x1E269B0", Length = "0x27")]
	[Token(Token = "0x60001BD")]
	public void Reset(bool withDisplay) { }

	[Address(RVA = "0x1E275E0", Offset = "0x1E269E0", Length = "0xB7")]
	[Token(Token = "0x60001BE")]
	public bool UpdateFrame(float dt) { }

}

