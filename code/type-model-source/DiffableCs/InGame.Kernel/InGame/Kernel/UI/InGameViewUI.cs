namespace InGame.Kernel.UI;

[Token(Token = "0x20000B8")]
public class InGameViewUI : MonoBehaviour
{
	[Token(Token = "0x20000B9")]
	internal struct PlayerUI
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000591")]
		public InGameValueGauge uiPipilGauge; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000592")]
		public InGameValueLamp uiSpeedGauge; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000593")]
		public InGameValueLamp uiSpeedFrame; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000594")]
		public InGameValueLevel uiArmLevel; //Field offset: 0x18

		[Address(RVA = "0x1D3DA30", Offset = "0x1D3CE30", Length = "0x52")]
		[Token(Token = "0x60006BF")]
		public void Initialize() { }

		[Address(RVA = "0x1D3DA90", Offset = "0x1D3CE90", Length = "0x4F")]
		[Token(Token = "0x60006C2")]
		public void Progress(float dt) { }

		[Address(RVA = "0x1D3DAE0", Offset = "0x1D3CEE0", Length = "0xBC")]
		[Token(Token = "0x60006C1")]
		public void SetValue(PlayerInformation pinfo) { }

		[Address(RVA = "0x1D3DBA0", Offset = "0x1D3CFA0", Length = "0x52")]
		[Token(Token = "0x60006C0")]
		public void Terminate() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000581")]
	private PlayerUI[] _playerUI; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000582")]
	private TXESpriteValue _highScore; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000583")]
	private TXESpriteValue _nowScore; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000584")]
	private TXESpriteValue _playerStock; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000585")]
	private TXEBomberIconValue _uiBomber; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000586")]
	private UIBossGauge _bossGauge; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000587")]
	private UIClock _clockUI; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000588")]
	private UIRuler _rulerUI; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000589")]
	private UIBGMName _bgmName; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400058A")]
	private PauseWindowMenu _pauseMenu; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400058B")]
	private UITextMeshPro _inGameText; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400058C")]
	private CanvasGroup _inGameTextGroup; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x400058D")]
	private Transform _uiBind; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400058E")]
	private long _highScoreVal; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400058F")]
	private int _playerUICount; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000590")]
	private bool _isSetuped; //Field offset: 0x94

	[Token(Token = "0x17000140")]
	public long HighScore
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x60006BB")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700013E")]
	public TXESpriteValue HighScoreTSV
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60006B9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000142")]
	protected bool IsSetuped
	{
		[Address(RVA = "0x1D39570", Offset = "0x1D38970", Length = "0x8")]
		[Token(Token = "0x60006BD")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700013F")]
	public TXESpriteValue NowScoreTSV
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60006BA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700013C")]
	public PauseWindowMenu PauseMenu
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60006B7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000141")]
	public int PlayerCount
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[Token(Token = "0x60006BC")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700013D")]
	public Transform UIBindArea
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x60006B8")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60006BE")]
	public InGameViewUI() { }

	[Address(RVA = "0x1D385C0", Offset = "0x1D379C0", Length = "0x6B")]
	[Token(Token = "0x60006A7")]
	private void Awake() { }

	[Address(RVA = "0x1D38630", Offset = "0x1D37A30", Length = "0x77")]
	[Token(Token = "0x60006AA")]
	public void EntryStage() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x60006BB")]
	public long get_HighScore() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60006B9")]
	public TXESpriteValue get_HighScoreTSV() { }

	[Address(RVA = "0x1D39570", Offset = "0x1D38970", Length = "0x8")]
	[Token(Token = "0x60006BD")]
	protected bool get_IsSetuped() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60006BA")]
	public TXESpriteValue get_NowScoreTSV() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60006B7")]
	public PauseWindowMenu get_PauseMenu() { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x60006BC")]
	public int get_PlayerCount() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x60006B8")]
	public Transform get_UIBindArea() { }

	[Address(RVA = "0x1D386B0", Offset = "0x1D37AB0", Length = "0xBD")]
	[Token(Token = "0x60006B2")]
	private void HiddenLocal(bool isp1hidden) { }

	[Address(RVA = "0x1D38770", Offset = "0x1D37B70", Length = "0x3E2")]
	[Token(Token = "0x60006A8")]
	public override void Initialize(InGameManager ingm) { }

	[Address(RVA = "0x1D38B60", Offset = "0x1D37F60", Length = "0xFD")]
	[Token(Token = "0x60006B5")]
	protected override void ProgressUIItems(float dt) { }

	[Address(RVA = "0x1D38C80", Offset = "0x1D38080", Length = "0x65")]
	[Token(Token = "0x60006AC")]
	public void RemoveStage() { }

	[Address(RVA = "0x1D38C60", Offset = "0x1D38060", Length = "0x1D")]
	[Token(Token = "0x60006AB")]
	public void ReStartStage() { }

	[Address(RVA = "0x1D38CF0", Offset = "0x1D380F0", Length = "0x1E")]
	[Token(Token = "0x60006AE")]
	public void SetBGMName(string tname) { }

	[Address(RVA = "0x1D38D10", Offset = "0x1D38110", Length = "0x43")]
	[Token(Token = "0x60006AF")]
	public void SetDisplay(int rulerValue, int clockType) { }

	[Address(RVA = "0x1D38D60", Offset = "0x1D38160", Length = "0x36")]
	[Token(Token = "0x60006AD")]
	public void SetHiScore(long nscore) { }

	[Address(RVA = "0x1D38DA0", Offset = "0x1D381A0", Length = "0x3A")]
	[Token(Token = "0x60006B1")]
	public void SetPlayerRuler(int p, Vector3 ppos, float tssize, bool isDeading) { }

	[Address(RVA = "0x1D38DE0", Offset = "0x1D381E0", Length = "0x2A3")]
	[Token(Token = "0x60006A9")]
	public override void Terminate(InGameManager ingm) { }

	[Address(RVA = "0x1D39090", Offset = "0x1D38490", Length = "0x9D")]
	[Token(Token = "0x60006B6")]
	private void UpdateClock() { }

	[Address(RVA = "0x1D39130", Offset = "0x1D38530", Length = "0x1A9")]
	[Token(Token = "0x60006B0")]
	public override void UpdateParameters(InGameManager gm, float tssize, float tstall) { }

	[Address(RVA = "0x1D392E0", Offset = "0x1D386E0", Length = "0x61")]
	[Token(Token = "0x60006B3")]
	private void UpdateScore(InGameManager m) { }

	[Address(RVA = "0x1D39350", Offset = "0x1D38750", Length = "0x21D")]
	[Token(Token = "0x60006B4")]
	protected void UpdateUIItems(InGameManager m) { }

}

