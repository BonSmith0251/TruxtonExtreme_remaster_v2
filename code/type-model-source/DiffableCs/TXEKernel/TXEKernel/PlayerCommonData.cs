namespace TXEKernel;

[Token(Token = "0x2000045")]
public class PlayerCommonData
{
	[Token(Token = "0x4000178")]
	public const long ScoreMax = 9999999990; //Field offset: 0x0
	[Token(Token = "0x4000179")]
	public const int BomberCountMax = 10; //Field offset: 0x0
	[Token(Token = "0x400017A")]
	public const int JewelCountMax = 99999999; //Field offset: 0x0
	[Token(Token = "0x400017B")]
	private const int BonusMulMaxBase = 10; //Field offset: 0x0
	[Token(Token = "0x400017C")]
	public const float PipilCountMax = 1E+09; //Field offset: 0x0
	[Token(Token = "0x400017D")]
	public const int PlayersMax = 99; //Field offset: 0x0
	[Token(Token = "0x400017E")]
	public const int PlayersMaxDead = 999; //Field offset: 0x0
	[Token(Token = "0x400017F")]
	public const float PlaySecondsMax = 86400; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000180")]
	private ProtectInt64 _numScore; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000181")]
	private ProtectInt32 _awakenValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000182")]
	private ProtectInt32 _numBomber; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000183")]
	private int _numFirstStockBomb; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000184")]
	private int _numBonusMax; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000185")]
	private int _numBonusMul; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000186")]
	private int _numJewel; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000187")]
	private int _numItemIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000188")]
	private ProtectInt32 _numClear; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000189")]
	private ProtectInt32 _numTotalDead; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400018A")]
	private ProtectInt32 _numExtends; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400018B")]
	private float _totalPipil; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400018C")]
	private ProtectInt32 _numStock; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400018D")]
	private float _inCreditTime; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400018E")]
	private float _inCreditTimeReal; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400018F")]
	private float _inPlayerTime; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000190")]
	private float _inStageTime; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000191")]
	private float _inStageTimeReal; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000192")]
	private ExtendScores _exinfo; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000193")]
	private Dictionary<TakenLabel, Int32> _takens; //Field offset: 0x88

	[Token(Token = "0x17000076")]
	public int ArmLvMax
	{
		[Address(RVA = "0x26DE1E0", Offset = "0x26DD5E0", Length = "0x1D")]
		[Token(Token = "0x6000218")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000080")]
	public float InStageTime
	{
		[Address(RVA = "0x26DE200", Offset = "0x26DD600", Length = "0x6")]
		[Token(Token = "0x6000222")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000077")]
	public int NumBomber
	{
		[Address(RVA = "0x26DE210", Offset = "0x26DD610", Length = "0x1D")]
		[Token(Token = "0x6000219")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000078")]
	public int NumBonusMul
	{
		[Address(RVA = "0x26DE230", Offset = "0x26DD630", Length = "0x18")]
		[Token(Token = "0x600021A")]
		 get { } //Length: 24
	}

	[Token(Token = "0x1700007B")]
	public int NumClear
	{
		[Address(RVA = "0x26DE250", Offset = "0x26DD650", Length = "0x1D")]
		[Token(Token = "0x600021D")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700007D")]
	public int NumExtends
	{
		[Address(RVA = "0x26DE270", Offset = "0x26DD670", Length = "0x1D")]
		[Token(Token = "0x600021F")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700007A")]
	public int NumItemIndex
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x600021C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000079")]
	public int NumJewel
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x600021B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000075")]
	public long NumScore
	{
		[Address(RVA = "0x26DE290", Offset = "0x26DD690", Length = "0x1D")]
		[Token(Token = "0x6000217")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700007F")]
	public int NumStock
	{
		[Address(RVA = "0x26DE2B0", Offset = "0x26DD6B0", Length = "0x1D")]
		[Token(Token = "0x6000221")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700007C")]
	public int NumTotalDead
	{
		[Address(RVA = "0x26DE2D0", Offset = "0x26DD6D0", Length = "0x1D")]
		[Token(Token = "0x600021E")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000081")]
	public Dictionary<TakenLabel, Int32> Takens
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x6000223")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700007E")]
	public float TotalPipil
	{
		[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
		[Token(Token = "0x6000220")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x26DE050", Offset = "0x26DD450", Length = "0x184")]
	[Token(Token = "0x6000224")]
	public PlayerCommonData() { }

	[Address(RVA = "0x26DCCB0", Offset = "0x26DC0B0", Length = "0x76")]
	[Token(Token = "0x600020B")]
	public bool AddBomberStock(int n) { }

	[Address(RVA = "0x26DCD30", Offset = "0x26DC130", Length = "0x50")]
	[Token(Token = "0x6000208")]
	public int AddBonusMul() { }

	[Address(RVA = "0x26DCD80", Offset = "0x26DC180", Length = "0x4E")]
	[Token(Token = "0x6000204")]
	public void AddExtend(int nstep) { }

	[Address(RVA = "0x26DCDD0", Offset = "0x26DC1D0", Length = "0x27")]
	[Token(Token = "0x600020C")]
	public void AddJewel(int n) { }

	[Address(RVA = "0x26DCE00", Offset = "0x26DC200", Length = "0x13D")]
	[Token(Token = "0x6000203")]
	public void AddScore(long n) { }

	[Address(RVA = "0x26DCF40", Offset = "0x26DC340", Length = "0x10E")]
	[Token(Token = "0x6000212")]
	public void AddTakens(TakenLabel tkind, int n) { }

	[Address(RVA = "0x26DD050", Offset = "0x26DC450", Length = "0x26")]
	[Token(Token = "0x600020D")]
	public void AddTotalPipil(float n) { }

	[Address(RVA = "0x26DD080", Offset = "0x26DC480", Length = "0xFD")]
	[Token(Token = "0x60001FF")]
	public void ClearByDead() { }

	[Address(RVA = "0x26DD180", Offset = "0x26DC580", Length = "0x37")]
	[Token(Token = "0x6000200")]
	public void ClearByStage() { }

	[Address(RVA = "0x26DD1C0", Offset = "0x26DC5C0", Length = "0x3AE")]
	[Token(Token = "0x60001FD")]
	public PlayerCommonData Copy() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000216")]
	public string DebugPrint() { }

	[Address(RVA = "0x26DE1E0", Offset = "0x26DD5E0", Length = "0x1D")]
	[Token(Token = "0x6000218")]
	public int get_ArmLvMax() { }

	[Address(RVA = "0x26DE200", Offset = "0x26DD600", Length = "0x6")]
	[Token(Token = "0x6000222")]
	public float get_InStageTime() { }

	[Address(RVA = "0x26DE210", Offset = "0x26DD610", Length = "0x1D")]
	[Token(Token = "0x6000219")]
	public int get_NumBomber() { }

	[Address(RVA = "0x26DE230", Offset = "0x26DD630", Length = "0x18")]
	[Token(Token = "0x600021A")]
	public int get_NumBonusMul() { }

	[Address(RVA = "0x26DE250", Offset = "0x26DD650", Length = "0x1D")]
	[Token(Token = "0x600021D")]
	public int get_NumClear() { }

	[Address(RVA = "0x26DE270", Offset = "0x26DD670", Length = "0x1D")]
	[Token(Token = "0x600021F")]
	public int get_NumExtends() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x600021C")]
	public int get_NumItemIndex() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x600021B")]
	public int get_NumJewel() { }

	[Address(RVA = "0x26DE290", Offset = "0x26DD690", Length = "0x1D")]
	[Token(Token = "0x6000217")]
	public long get_NumScore() { }

	[Address(RVA = "0x26DE2B0", Offset = "0x26DD6B0", Length = "0x1D")]
	[Token(Token = "0x6000221")]
	public int get_NumStock() { }

	[Address(RVA = "0x26DE2D0", Offset = "0x26DD6D0", Length = "0x1D")]
	[Token(Token = "0x600021E")]
	public int get_NumTotalDead() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x6000223")]
	public Dictionary<TakenLabel, Int32> get_Takens() { }

	[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
	[Token(Token = "0x6000220")]
	public float get_TotalPipil() { }

	[Address(RVA = "0x26DD570", Offset = "0x26DC970", Length = "0x14")]
	[Token(Token = "0x6000215")]
	public float GetCreditOccupancyRate() { }

	[Address(RVA = "0x26DD590", Offset = "0x26DC990", Length = "0xEC")]
	[Token(Token = "0x6000210")]
	public int GetExtendCount(long currentScore, long addScore) { }

	[Address(RVA = "0x26DD680", Offset = "0x26DCA80", Length = "0x14")]
	[Token(Token = "0x6000214")]
	public float GetStageOccupancyRate() { }

	[Address(RVA = "0x26DD6A0", Offset = "0x26DCAA0", Length = "0x50")]
	[Token(Token = "0x60001FB")]
	public void Initialize(int awakenLv) { }

	[Address(RVA = "0x26DD700", Offset = "0x26DCB00", Length = "0x1D4")]
	[Token(Token = "0x60001FC")]
	public void Reset(int nstock, int nbomb) { }

	[Address(RVA = "0x26DD8E0", Offset = "0x26DCCE0", Length = "0x22F")]
	[Token(Token = "0x60001FE")]
	public void SetAll(PlayerCommonData td) { }

	[Address(RVA = "0x26DDB10", Offset = "0x26DCF10", Length = "0x30")]
	[Token(Token = "0x600020E")]
	public void SetBomberStock(int n) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x600020F")]
	public void SetExtend(ExtendScores es) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x6000211")]
	public void SetItemIndex(int n) { }

	[Address(RVA = "0x26DDB50", Offset = "0x26DCF50", Length = "0x9A")]
	[Token(Token = "0x6000209")]
	public void SetNumBonusMax(int nstep) { }

	[Address(RVA = "0x26DDD70", Offset = "0x26DD170", Length = "0xA6")]
	[Token(Token = "0x6000201")]
	public void SetScore(long n) { }

	[Address(RVA = "0x26DDBF0", Offset = "0x26DCFF0", Length = "0x179")]
	[Token(Token = "0x6000202")]
	public void SetScoreSub(long n) { }

	[Address(RVA = "0x26DDE20", Offset = "0x26DD220", Length = "0x30")]
	[Token(Token = "0x6000207")]
	public void SetStockCount(int n) { }

	[Address(RVA = "0x26DDE60", Offset = "0x26DD260", Length = "0x57")]
	[Token(Token = "0x6000213")]
	public void SetTakens(TakenLabel tkind) { }

	[Address(RVA = "0x26DDEC0", Offset = "0x26DD2C0", Length = "0x76")]
	[Token(Token = "0x6000206")]
	public bool StockCountUp(int n) { }

	[Address(RVA = "0x26DDF40", Offset = "0x26DD340", Length = "0xA8")]
	[Token(Token = "0x6000205")]
	public void Timepass(float playDT, float realDT) { }

	[Address(RVA = "0x26DDFF0", Offset = "0x26DD3F0", Length = "0x53")]
	[Token(Token = "0x600020A")]
	public bool UseBomber() { }

}

