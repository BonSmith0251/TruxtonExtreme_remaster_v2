namespace OutGame.UI;

[Token(Token = "0x200013B")]
public class RankDisplayArcade : MonoBehaviour
{
	[Token(Token = "0x200013C")]
	internal class RankDataArcade
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000541")]
		public TXESpriteValue Rank; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000542")]
		public TXEUIFontText Name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000543")]
		public TXESpriteValue Score; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000544")]
		public TXEUIFontText StageOne; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000545")]
		public TXEUIFontText StageInfinity; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000546")]
		public GameObject StageOneObj; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000547")]
		public GameObject StageInfinityObj; //Field offset: 0x40

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007DA")]
		public RankDataArcade() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400053C")]
	private RankDataArcade _diplayData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400053D")]
	private GameObject _obj; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400053E")]
	private UIImage _bg; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400053F")]
	private bool _blinkFlg; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000540")]
	private float _blinkRate; //Field offset: 0x3C

	[Address(RVA = "0x22000C0", Offset = "0x21FF4C0", Length = "0xE")]
	[Token(Token = "0x60007D9")]
	public RankDisplayArcade() { }

	[Address(RVA = "0x22000D0", Offset = "0x21FF4D0", Length = "0x2B")]
	[Token(Token = "0x60007D8")]
	public void clear() { }

	[Address(RVA = "0x21FFF50", Offset = "0x21FF350", Length = "0x1D")]
	[Token(Token = "0x60007D6")]
	public bool IsEnable() { }

	[Address(RVA = "0x2200100", Offset = "0x21FF500", Length = "0x2CF")]
	[Token(Token = "0x60007D7")]
	public void set(int rank, string name, long score, int loop, int stage, bool blinkFlg = false) { }

	[Address(RVA = "0x21FFF70", Offset = "0x21FF370", Length = "0x45")]
	[Token(Token = "0x60007D4")]
	private void Start() { }

	[Address(RVA = "0x21FFFC0", Offset = "0x21FF3C0", Length = "0xF3")]
	[Token(Token = "0x60007D5")]
	private void Update() { }

}

