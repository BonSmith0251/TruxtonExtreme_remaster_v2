namespace OutGame.UI;

[Token(Token = "0x200015B")]
public class TXEStoryPlayerinfo : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400061A")]
	private List<Sprite> _powerTypeIcons; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400061B")]
	private UIImage _powerType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400061C")]
	private UITextMeshPro _powerLevel; //Field offset: 0x30

	[Address(RVA = "0x22069E0", Offset = "0x2205DE0", Length = "0x77")]
	[Token(Token = "0x60008BE")]
	public TXEStoryPlayerinfo() { }

	[Address(RVA = "0x2206A60", Offset = "0x2205E60", Length = "0xB9")]
	[Token(Token = "0x60008BD")]
	public void set(int weaponType, int weaponLevel) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60008BB")]
	private void Start() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60008BC")]
	private void Update() { }

}

