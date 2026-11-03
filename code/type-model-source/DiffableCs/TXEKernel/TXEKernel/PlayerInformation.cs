namespace TXEKernel;

[Token(Token = "0x2000048")]
public class PlayerInformation
{
	[Token(Token = "0x40001A5")]
	public const int SpeedLevelMax = 5; //Field offset: 0x0
	[Token(Token = "0x40001A6")]
	public const int AwakenLevelValueMax = 3; //Field offset: 0x0
	[Token(Token = "0x40001A7")]
	public static readonly int NumArmsKind; //Field offset: 0x0
	[Token(Token = "0x40001B8")]
	public const float DecPipilShot = -26.666666; //Field offset: 0x0
	[Token(Token = "0x40001B7")]
	public const float MaxPipilGauge = 200; //Field offset: 0x0
	[Token(Token = "0x40001A8")]
	public static readonly int NumPlayerMuzzles; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A9")]
	private PlayerCommonData _commonData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001AA")]
	private int _numDead; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40001AB")]
	private int _numBomber; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001AC")]
	private int _numDeadInStage; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001AD")]
	private int _numUseBomberInStage; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001AE")]
	private int _numRevibe; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40001AF")]
	private int _numRevibeInStage; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001B0")]
	private ArmsKind _armKind; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40001B1")]
	private int _armLevel; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001B2")]
	private int _armSubLevel; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40001B3")]
	private bool _isArmLevelUp; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001B4")]
	private int _speedLevel; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40001B5")]
	private int _speedCapacity; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001B6")]
	private float _numPipil; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40001B9")]
	private float _numPipilScale; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001BA")]
	private float _damageMag; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40001BB")]
	private ArmsKind _darm; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001BC")]
	private int _dspeed; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40001BD")]
	private int _darmLv; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001BE")]
	private int _dbomb; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40001BF")]
	private int _awakenBody; //Field offset: 0x64

	[Token(Token = "0x17000095")]
	public int AwakenBody
	{
		[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
		[Token(Token = "0x600025B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000083")]
	public PlayerCommonData CommonData
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000248")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000094")]
	public float DamageMag
	{
		[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
		[Token(Token = "0x600025A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000082")]
	public float InStageTime
	{
		[Address(RVA = "0x26DEF20", Offset = "0x26DE320", Length = "0x15")]
		[Token(Token = "0x6000247")]
		 get { } //Length: 21
	}

	[Token(Token = "0x1700008E")]
	public bool IsArmLevelUp
	{
		[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
		[Token(Token = "0x6000254")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700008B")]
	public ArmsKind KindArm
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000251")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700008C")]
	public int LevelArm
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000252")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700008F")]
	public int LevelSpeed
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x6000255")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000086")]
	public int NumBomber
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x600024C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000085")]
	public int NumDead
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600024B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000087")]
	public int NumDeadInStage
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x600024D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000091")]
	public float NumPipil
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[Token(Token = "0x6000257")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000092")]
	public float NumPipilRate
	{
		[Address(RVA = "0x26DEF40", Offset = "0x26DE340", Length = "0x2A")]
		[Token(Token = "0x6000258")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000089")]
	public int NumRevibed
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x600024F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700008A")]
	public int NumRevibeInStage
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000250")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000084")]
	public long NumScore
	{
		[Address(RVA = "0x26DEF70", Offset = "0x26DE370", Length = "0x26")]
		[Token(Token = "0x6000249")]
		 get { } //Length: 38
	}

	[Token(Token = "0x17000093")]
	public float NumTotalPipil
	{
		[Address(RVA = "0x26DEFA0", Offset = "0x26DE3A0", Length = "0x15")]
		[Token(Token = "0x6000259")]
		 get { } //Length: 21
	}

	[Token(Token = "0x17000088")]
	public int NumUseBomberInStage
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x600024E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000090")]
	public int SpeedCapacity
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x6000256")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700008D")]
	public int SubLevelArm
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000253")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x26DEE40", Offset = "0x26DE240", Length = "0xB5")]
	[Token(Token = "0x600025D")]
	private static PlayerInformation() { }

	[Address(RVA = "0x26DEF00", Offset = "0x26DE300", Length = "0x15")]
	[Token(Token = "0x600025C")]
	public PlayerInformation() { }

	[Address(RVA = "0x26DE2F0", Offset = "0x26DD6F0", Length = "0x7C")]
	[Token(Token = "0x600023A")]
	public bool AddBomberStock(int n) { }

	[Address(RVA = "0x26DE370", Offset = "0x26DD770", Length = "0x3E")]
	[Token(Token = "0x6000237")]
	public void AddRevibed() { }

	[Address(RVA = "0x26DE3B0", Offset = "0x26DD7B0", Length = "0x46")]
	[Token(Token = "0x6000230")]
	public bool AddSpeedCapacity(int n) { }

	[Address(RVA = "0x26DE400", Offset = "0x26DD800", Length = "0x1E")]
	[Token(Token = "0x6000239")]
	public void AddTakens(TakenLabel tkind, int n = 1) { }

	[Address(RVA = "0x26DE420", Offset = "0x26DD820", Length = "0xA0")]
	[Token(Token = "0x6000241")]
	public bool ArmLevelUp(int n) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x600022D")]
	public void ChangeArm(ArmsKind tkind) { }

	[Address(RVA = "0x26DE4D0", Offset = "0x26DD8D0", Length = "0x2C")]
	[Token(Token = "0x600022E")]
	public bool ChangeSpeedLevel(int n) { }

	[Address(RVA = "0x26DE500", Offset = "0x26DD900", Length = "0x45")]
	[Token(Token = "0x600022B")]
	public void ClearByDead() { }

	[Address(RVA = "0x26DE550", Offset = "0x26DD950", Length = "0xA")]
	[Token(Token = "0x600022C")]
	public void ClearByStage() { }

	[Address(RVA = "0x26DE560", Offset = "0x26DD960", Length = "0xB5")]
	[Token(Token = "0x6000227")]
	public PlayerInformation Copy() { }

	[Address(RVA = "0x26DE620", Offset = "0x26DDA20", Length = "0x32")]
	[Token(Token = "0x6000234")]
	public bool DeadCountUp() { }

	[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
	[Token(Token = "0x600025B")]
	public int get_AwakenBody() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000248")]
	public PlayerCommonData get_CommonData() { }

	[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
	[Token(Token = "0x600025A")]
	public float get_DamageMag() { }

	[Address(RVA = "0x26DEF20", Offset = "0x26DE320", Length = "0x15")]
	[Token(Token = "0x6000247")]
	public float get_InStageTime() { }

	[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
	[Token(Token = "0x6000254")]
	public bool get_IsArmLevelUp() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000251")]
	public ArmsKind get_KindArm() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000252")]
	public int get_LevelArm() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x6000255")]
	public int get_LevelSpeed() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x600024C")]
	public int get_NumBomber() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600024B")]
	public int get_NumDead() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x600024D")]
	public int get_NumDeadInStage() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[Token(Token = "0x6000257")]
	public float get_NumPipil() { }

	[Address(RVA = "0x26DEF40", Offset = "0x26DE340", Length = "0x2A")]
	[Token(Token = "0x6000258")]
	public float get_NumPipilRate() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x600024F")]
	public int get_NumRevibed() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000250")]
	public int get_NumRevibeInStage() { }

	[Address(RVA = "0x26DEF70", Offset = "0x26DE370", Length = "0x26")]
	[Token(Token = "0x6000249")]
	public long get_NumScore() { }

	[Address(RVA = "0x26DEFA0", Offset = "0x26DE3A0", Length = "0x15")]
	[Token(Token = "0x6000259")]
	public float get_NumTotalPipil() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x600024E")]
	public int get_NumUseBomberInStage() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x6000256")]
	public int get_SpeedCapacity() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000253")]
	public int get_SubLevelArm() { }

	[Address(RVA = "0x26DE660", Offset = "0x26DDA60", Length = "0x26")]
	[Token(Token = "0x6000240")]
	public int GetArmLevelMax() { }

	[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
	[Token(Token = "0x6000232")]
	public int GetSpeedMax() { }

	[Address(RVA = "0x26DE690", Offset = "0x26DDA90", Length = "0x33")]
	[Token(Token = "0x6000225")]
	public void Initialize(ref PlayerCommonData tcommon) { }

	[Address(RVA = "0x26DE6D0", Offset = "0x26DDAD0", Length = "0x2C")]
	[Token(Token = "0x6000238")]
	public bool IsStockRemain() { }

	[Address(RVA = "0x26DE700", Offset = "0x26DDB00", Length = "0x77")]
	[Token(Token = "0x600023D")]
	public void PipilCountUp(float rsub) { }

	[Address(RVA = "0x26DE8D0", Offset = "0x26DDCD0", Length = "0x17")]
	[Token(Token = "0x600022A")]
	public void Reset() { }

	[Address(RVA = "0x26DE780", Offset = "0x26DDB80", Length = "0x148")]
	[Token(Token = "0x6000229")]
	public void ResetToDefault() { }

	[Address(RVA = "0x26DE8F0", Offset = "0x26DDCF0", Length = "0x13C")]
	[Token(Token = "0x6000228")]
	public void SetAll(PlayerInformation tval, PlayerCommonData cdata) { }

	[Address(RVA = "0x26DEA30", Offset = "0x26DDE30", Length = "0x65")]
	[Token(Token = "0x6000242")]
	public void SetArmLevel(int n) { }

	[Address(RVA = "0x26DEAA0", Offset = "0x26DDEA0", Length = "0x1D")]
	[Token(Token = "0x6000243")]
	public void SetArmSubLevel(int n) { }

	[Address(RVA = "0x26DEAC0", Offset = "0x26DDEC0", Length = "0x1D")]
	[Token(Token = "0x6000246")]
	public void SetAwaken(int tval) { }

	[Address(RVA = "0x26DEAE0", Offset = "0x26DDEE0", Length = "0x6")]
	[Token(Token = "0x6000245")]
	public void SetDamageMag(float tmag) { }

	[Address(RVA = "0x26DEAF0", Offset = "0x26DDEF0", Length = "0x13")]
	[Token(Token = "0x6000226")]
	public void SetDefaultParam(ArmsKind darm, int armLv, int speedLv, int nBomb) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000235")]
	public void SetNumDead(int n) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000236")]
	public void SetNumDeadInStage(int n) { }

	[Address(RVA = "0x26DEB20", Offset = "0x26DDF20", Length = "0x21")]
	[Token(Token = "0x600023E")]
	public void SetPipil(float r) { }

	[Address(RVA = "0x26DEB10", Offset = "0x26DDF10", Length = "0x6")]
	[Token(Token = "0x600023F")]
	public void SetPipilScale(float tscale) { }

	[Address(RVA = "0x26DEB50", Offset = "0x26DDF50", Length = "0x183")]
	[Token(Token = "0x600024A")]
	public void SetScore(long ts) { }

	[Address(RVA = "0x26DECE0", Offset = "0x26DE0E0", Length = "0x30")]
	[Token(Token = "0x6000231")]
	public void SetSpeedCapacity(int n) { }

	[Address(RVA = "0x26DED10", Offset = "0x26DE110", Length = "0x1B")]
	[Token(Token = "0x600022F")]
	public void SetSpeedLevel(int n) { }

	[Address(RVA = "0x26DED30", Offset = "0x26DE130", Length = "0x7C")]
	[Token(Token = "0x6000233")]
	public bool StockCountUp(int n) { }

	[Address(RVA = "0x26DEDB0", Offset = "0x26DE1B0", Length = "0x5")]
	[Token(Token = "0x6000244")]
	public void UpdateDone() { }

	[Address(RVA = "0x26DEDC0", Offset = "0x26DE1C0", Length = "0x70")]
	[Token(Token = "0x600023B")]
	public bool UseBomber() { }

	[Address(RVA = "0x26DEDC0", Offset = "0x26DE1C0", Length = "0x70")]
	[Token(Token = "0x600023C")]
	public bool UseRescueBomber() { }

}

