namespace InGame.UI;

[Token(Token = "0x2000016")]
public class UIRuler : MonoBehaviour
{
	[Token(Token = "0x2000017")]
	private class DeadLog
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000074")]
		private float _ttime; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000075")]
		private float _tx; //Field offset: 0x14

		[Token(Token = "0x17000007")]
		public float DeadTime
		{
			[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
			[Token(Token = "0x600006C")]
			 get { } //Length: 6
		}

		[Token(Token = "0x17000006")]
		public float PosX
		{
			[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
			[Token(Token = "0x600006B")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x1DD1D40", Offset = "0x1DD1140", Length = "0x3A")]
		[Token(Token = "0x600006D")]
		public DeadLog(float tx, float ttime) { }

		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x600006C")]
		public float get_DeadTime() { }

		[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
		[Token(Token = "0x600006B")]
		public float get_PosX() { }

	}

	[Token(Token = "0x400005E")]
	private const int DeadLogMax = 10; //Field offset: 0x0
	[Token(Token = "0x400005F")]
	public const int PlayerMax = 2; //Field offset: 0x0
	[Token(Token = "0x4000060")]
	public const float ScreenHalfSize = 1920; //Field offset: 0x0
	[Token(Token = "0x4000061")]
	public const float ScreenHalfTall = 1080; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000062")]
	private GameObject _upSide; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000063")]
	private GameObject _downSide; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000064")]
	private UIImage[] _ucursorImages; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000065")]
	private UIImage[] _dcursorImages; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000066")]
	private Transform[] _ucursorTransforms; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000067")]
	private Transform[] _dcursorTransforms; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000068")]
	private GameObject _rulerPointBaseD; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000069")]
	private GameObject _rulerPointBaseU; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400006A")]
	private Vector3[] _upos; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400006B")]
	private Vector3[] _dpos; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400006C")]
	private float _currentTime; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400006D")]
	private List<DeadLog> _deadLogs; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400006E")]
	private List<UIImage> _deadLogUMarks; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400006F")]
	private List<UIImage> _deadLogDMarks; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000070")]
	private int _deadLogsCount; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000071")]
	private int _displayType; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000072")]
	private bool _isP1Dead; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x4000073")]
	private bool _isP2Dead; //Field offset: 0x99

	[Address(RVA = "0x1DD6740", Offset = "0x1DD5B40", Length = "0x1E1")]
	[Token(Token = "0x600006A")]
	public UIRuler() { }

	[Address(RVA = "0x1DD5900", Offset = "0x1DD4D00", Length = "0xBF")]
	[Token(Token = "0x6000069")]
	private void HideMarks() { }

	[Address(RVA = "0x1DD59C0", Offset = "0x1DD4DC0", Length = "0x389")]
	[Token(Token = "0x6000060")]
	public void Initialize() { }

	[Address(RVA = "0x1DD5D50", Offset = "0x1DD5150", Length = "0x38B")]
	[Token(Token = "0x6000068")]
	public void Progress() { }

	[Address(RVA = "0x1DD60E0", Offset = "0x1DD54E0", Length = "0x10")]
	[Token(Token = "0x6000061")]
	public void ReStartStage() { }

	[Address(RVA = "0x1DD60F0", Offset = "0x1DD54F0", Length = "0xD")]
	[Token(Token = "0x6000067")]
	public void SetCurrentTime(double ttime) { }

	[Address(RVA = "0x1DD6100", Offset = "0x1DD5500", Length = "0x52")]
	[Token(Token = "0x6000065")]
	public void SetDisplay(int displayType) { }

	[Address(RVA = "0x1DD6160", Offset = "0x1DD5560", Length = "0x294")]
	[Token(Token = "0x6000064")]
	public void SetMarker(float trate, int pno, bool isDeading) { }

	[Address(RVA = "0x1DD6400", Offset = "0x1DD5800", Length = "0x14F")]
	[Token(Token = "0x6000066")]
	public void SetPlayerMax(int nplayer) { }

	[Address(RVA = "0x1DD6550", Offset = "0x1DD5950", Length = "0x6D")]
	[Token(Token = "0x6000062")]
	public void StageClear() { }

	[Address(RVA = "0x1DD65C0", Offset = "0x1DD59C0", Length = "0x178")]
	[Token(Token = "0x6000063")]
	public void Terminate() { }

}

