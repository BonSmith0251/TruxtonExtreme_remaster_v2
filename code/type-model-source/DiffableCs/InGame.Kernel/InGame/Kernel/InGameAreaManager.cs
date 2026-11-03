namespace InGame.Kernel;

[Token(Token = "0x2000008")]
public class InGameAreaManager
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000025")]
	private List<AreaInformation> _areaClips; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000026")]
	private int _areaCountMax; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000027")]
	private int _currentAreaIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000028")]
	private int _restartAreaIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000029")]
	private bool _isBreakArea; //Field offset: 0x24
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x400002A")]
	private bool _isAreaTerminate; //Field offset: 0x25
	[FieldOffset(Offset = "0x26")]
	[Token(Token = "0x400002B")]
	private bool _isAreaDelayStop; //Field offset: 0x26
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002C")]
	private Int32[] _destroyCounter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400002D")]
	private Int32[] _emitterCounter; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400002E")]
	private Int32[] _restartCounter; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400002F")]
	private Int32[] _bomberCounter; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000030")]
	private Int32[] _setPCounter; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000031")]
	private Int32[] _getPCounter; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000032")]
	private double _timelineTime; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000033")]
	private double _realpassTime; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000034")]
	private float _currentDT; //Field offset: 0x68

	[Token(Token = "0x17000011")]
	public Int32[] BombCounter
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000051")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000E")]
	public int CurrentAreaIndex
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x600004E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000013")]
	public float CurrentDT
	{
		[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
		[Token(Token = "0x6000053")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700000F")]
	public bool IsAreaDelayStop
	{
		[Address(RVA = "0x1CC8820", Offset = "0x1CC7C20", Length = "0x5")]
		[Token(Token = "0x600004F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000010")]
	public Int32[] RestartCounter
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000050")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000012")]
	public double TimelineTime
	{
		[Address(RVA = "0x1CC8830", Offset = "0x1CC7C30", Length = "0x6")]
		[Token(Token = "0x6000052")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1CC8810", Offset = "0x1CC7C10", Length = "0xE")]
	[Token(Token = "0x6000054")]
	public InGameAreaManager() { }

	[Address(RVA = "0x1CC7440", Offset = "0x1CC6840", Length = "0x39")]
	[Token(Token = "0x600003C")]
	public void BomberCountup() { }

	[Address(RVA = "0x1CC7480", Offset = "0x1CC6880", Length = "0x2F")]
	[Token(Token = "0x600003B")]
	public void DestroyCountup(int tindex) { }

	[Address(RVA = "0x1CC74B0", Offset = "0x1CC68B0", Length = "0x2F")]
	[Token(Token = "0x600003A")]
	public void EmitterCountup(int tindex) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000051")]
	public Int32[] get_BombCounter() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x600004E")]
	public int get_CurrentAreaIndex() { }

	[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
	[Token(Token = "0x6000053")]
	public float get_CurrentDT() { }

	[Address(RVA = "0x1CC8820", Offset = "0x1CC7C20", Length = "0x5")]
	[Token(Token = "0x600004F")]
	public bool get_IsAreaDelayStop() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000050")]
	public Int32[] get_RestartCounter() { }

	[Address(RVA = "0x1CC8830", Offset = "0x1CC7C30", Length = "0x6")]
	[Token(Token = "0x6000052")]
	public double get_TimelineTime() { }

	[Address(RVA = "0x1CC7660", Offset = "0x1CC6A60", Length = "0xC7")]
	[Token(Token = "0x600003E")]
	public int GetAreaIndex(string areaName) { }

	[Address(RVA = "0x1CC74E0", Offset = "0x1CC68E0", Length = "0x17F")]
	[Token(Token = "0x600003F")]
	public int GetAreaIndex(double ttime) { }

	[Address(RVA = "0x1CC7730", Offset = "0x1CC6B30", Length = "0x16E")]
	[Token(Token = "0x6000040")]
	public List<Int32> GetAreaIndexs(double tstart, double tend) { }

	[Address(RVA = "0x1CC78A0", Offset = "0x1CC6CA0", Length = "0x85")]
	[Token(Token = "0x600003D")]
	public AreaInformation GetAreaInfo(int tindex) { }

	[Address(RVA = "0x1CC7930", Offset = "0x1CC6D30", Length = "0x10F")]
	[Token(Token = "0x6000049")]
	public List<String> GetAreaNames() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x600004A")]
	public string GetCurrentAreaName() { }

	[Address(RVA = "0x1CC7A40", Offset = "0x1CC6E40", Length = "0x58")]
	[Token(Token = "0x6000047")]
	public int GetCurrentRestartCount() { }

	[Address(RVA = "0x1CC7AA0", Offset = "0x1CC6EA0", Length = "0x110")]
	[Token(Token = "0x6000043")]
	public float GetDestructionRate(int sarea, int earea) { }

	[Address(RVA = "0x1CC7BC0", Offset = "0x1CC6FC0", Length = "0xE3")]
	[Token(Token = "0x6000042")]
	public float GetDestructionRate(int tarea = -1) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x600004B")]
	public string GetLog() { }

	[Address(RVA = "0x1CC7CB0", Offset = "0x1CC70B0", Length = "0xDD")]
	[Token(Token = "0x6000044")]
	public float GetPipilRate(int tarea = -1) { }

	[Address(RVA = "0x1CC7D90", Offset = "0x1CC7190", Length = "0x55")]
	[Token(Token = "0x6000046")]
	public int GetRestartCount() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x6000045")]
	public float GetSecretBonusRate() { }

	[Address(RVA = "0x1CC7DF0", Offset = "0x1CC71F0", Length = "0x219")]
	[Token(Token = "0x6000032")]
	public void Initialize(PlayableDirector _director) { }

	[Address(RVA = "0x1CC8010", Offset = "0x1CC7410", Length = "0x45")]
	[Token(Token = "0x6000035")]
	public bool IsAreaData() { }

	[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
	[Token(Token = "0x6000041")]
	public void IsBreakArea(bool v) { }

	[Address(RVA = "0x1CC8070", Offset = "0x1CC7470", Length = "0x22")]
	[Token(Token = "0x6000048")]
	public bool IsLoopArea() { }

	[Address(RVA = "0x1CC80A0", Offset = "0x1CC74A0", Length = "0x312")]
	[Token(Token = "0x6000038")]
	public bool ProgressTimeline(float dt) { }

	[Address(RVA = "0x1CC83C0", Offset = "0x1CC77C0", Length = "0x115")]
	[Token(Token = "0x600004D")]
	private void ResetCounter(int nstartArea, bool isFirst) { }

	[Address(RVA = "0x1CC84E0", Offset = "0x1CC78E0", Length = "0x10")]
	[Token(Token = "0x6000036")]
	public void ResetFlags(int sindex) { }

	[Address(RVA = "0x1CC84F0", Offset = "0x1CC78F0", Length = "0xCC")]
	[Token(Token = "0x6000037")]
	public double RestartArea(int tindex) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600004C")]
	private void SetLog(string s) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000034")]
	public void SetRestartAreaIndex(int tindex) { }

	[Address(RVA = "0x1CC85C0", Offset = "0x1CC79C0", Length = "0xCF")]
	[Token(Token = "0x6000033")]
	public void Terminate() { }

	[Address(RVA = "0x1CC8690", Offset = "0x1CC7A90", Length = "0x171")]
	[Token(Token = "0x6000039")]
	private double UpdateAreaIndex(int tindex, double ttime) { }

}

