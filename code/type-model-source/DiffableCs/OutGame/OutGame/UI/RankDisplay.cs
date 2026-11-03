namespace OutGame.UI;

[Token(Token = "0x2000139")]
public class RankDisplay : MonoBehaviour
{
	[Token(Token = "0x200013A")]
	internal class RankData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000539")]
		public TXESpriteValue Rank; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400053A")]
		public TXEUIFontText Name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400053B")]
		public TXESpriteValue Score; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007D3")]
		public RankData() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000534")]
	private RankData _diplayData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000535")]
	private GameObject _obj; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000536")]
	private UIImage _bg; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000537")]
	private bool _blinkFlg; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000538")]
	private float _blinkRate; //Field offset: 0x3C

	[Address(RVA = "0x22000C0", Offset = "0x21FF4C0", Length = "0xE")]
	[Token(Token = "0x60007D2")]
	public RankDisplay() { }

	[Address(RVA = "0x22000D0", Offset = "0x21FF4D0", Length = "0x2B")]
	[Token(Token = "0x60007D1")]
	public void clear() { }

	[Address(RVA = "0x21FFF50", Offset = "0x21FF350", Length = "0x1D")]
	[Token(Token = "0x60007CF")]
	public bool IsEnable() { }

	[Address(RVA = "0x22006E0", Offset = "0x21FFAE0", Length = "0xB7")]
	[Token(Token = "0x60007D0")]
	public void set(int rank, string name, long score, bool blinkFlg = false) { }

	[Address(RVA = "0x21FFF70", Offset = "0x21FF370", Length = "0x45")]
	[Token(Token = "0x60007CD")]
	private void Start() { }

	[Address(RVA = "0x22005E0", Offset = "0x21FF9E0", Length = "0xF3")]
	[Token(Token = "0x60007CE")]
	private void Update() { }

}

