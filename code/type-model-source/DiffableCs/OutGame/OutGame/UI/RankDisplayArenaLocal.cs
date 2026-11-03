namespace OutGame.UI;

[Token(Token = "0x200013D")]
public class RankDisplayArenaLocal : MonoBehaviour
{
	[Token(Token = "0x200013E")]
	internal class RankData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400054D")]
		public TXESpriteValue Rank; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400054E")]
		public TXESpriteValue Score; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400054F")]
		public TXESpriteValue PlayerNo; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007E1")]
		public RankData() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000548")]
	private RankData _diplayData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000549")]
	private GameObject _obj; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400054A")]
	private UIImage _bg; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400054B")]
	private bool _blinkFlg; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400054C")]
	private float blinkRate; //Field offset: 0x3C

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60007E0")]
	public RankDisplayArenaLocal() { }

	[Address(RVA = "0x22000D0", Offset = "0x21FF4D0", Length = "0x2B")]
	[Token(Token = "0x60007DF")]
	public void clear() { }

	[Address(RVA = "0x21FFF50", Offset = "0x21FF350", Length = "0x1D")]
	[Token(Token = "0x60007DD")]
	public bool IsEnable() { }

	[Address(RVA = "0x2200530", Offset = "0x21FF930", Length = "0xAB")]
	[Token(Token = "0x60007DE")]
	public void set(int rank, long score, int playerNo, bool blinkFlg) { }

	[Address(RVA = "0x22003D0", Offset = "0x21FF7D0", Length = "0x5E")]
	[Token(Token = "0x60007DB")]
	private void Start() { }

	[Address(RVA = "0x2200430", Offset = "0x21FF830", Length = "0xF3")]
	[Token(Token = "0x60007DC")]
	private void Update() { }

}

