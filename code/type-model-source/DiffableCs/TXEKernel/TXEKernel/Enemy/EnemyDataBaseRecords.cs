namespace TXEKernel.Enemy;

[Token(Token = "0x200013A")]
public class EnemyDataBaseRecords : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x200013C")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000910")]
		public string tkey; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60008A1")]
		public <>c__DisplayClass10_0() { }

		[Address(RVA = "0x272B600", Offset = "0x272AA00", Length = "0x3D")]
		[Token(Token = "0x60008A2")]
		internal bool <GetData>b__0(Record p) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200013D")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000911")]
		public string tkey; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60008A3")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x1D73DE0", Offset = "0x1D731E0", Length = "0x25")]
		[Token(Token = "0x60008A4")]
		internal bool <GetDatas>b__0(Record p) { }

	}

	[Token(Token = "0x200013B")]
	internal class Record
	{
		[FieldOffset(Offset = "0x10")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x40008F7")]
		[Tooltip("暗号化済")]
		private string _targetKey; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x40008F8")]
		private string _partsName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008F9")]
		private string _originalName; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008FA")]
		public bool isBreakthrough; //Field offset: 0x28
		[FieldOffset(Offset = "0x29")]
		[Token(Token = "0x40008FB")]
		public bool isLockOn; //Field offset: 0x29
		[FieldOffset(Offset = "0x2A")]
		[Token(Token = "0x40008FC")]
		public bool isGround; //Field offset: 0x2A
		[FieldOffset(Offset = "0x2B")]
		[Token(Token = "0x40008FD")]
		public bool isRangeFire; //Field offset: 0x2B
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40008FE")]
		public bool isDamageScore; //Field offset: 0x2C
		[FieldOffset(Offset = "0x2D")]
		[Token(Token = "0x40008FF")]
		public bool isRateTarget; //Field offset: 0x2D
		[FieldOffset(Offset = "0x30")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x4000900")]
		[Tooltip("暗号化済")]
		private float _hitpoint; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x4000901")]
		[Tooltip("暗号化済")]
		private int _pipil; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x4000902")]
		[Tooltip("暗号化済")]
		private int _jewel; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x4000903")]
		[Tooltip("暗号化済")]
		private int _score; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x4000904")]
		private int _priority; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x4000905")]
		private int _galleryNo; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x4000906")]
		private string _aliasCnt; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x4000907")]
		private EnemySize _modelSize; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000908")]
		public toleType toleBlack; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000909")]
		public toleType toleBlue; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x400090A")]
		public toleType toleGreen; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400090B")]
		public toleType toleRed; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x400090C")]
		public toleType toleGold; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400090D")]
		public toleType toleSilver; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x400090E")]
		public toleType toleBomb; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400090F")]
		public toleType tolePink; //Field offset: 0x70

		[Token(Token = "0x17000257")]
		public string aliasCnt
		{
			[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
			[Token(Token = "0x600089A")]
			 get { } //Length: 5
			[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
			[Token(Token = "0x600089B")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000256")]
		public int galleryNo
		{
			[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
			[Token(Token = "0x6000898")]
			 get { } //Length: 4
			[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
			[Token(Token = "0x6000899")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000251")]
		public float hitpoint
		{
			[Address(RVA = "0x2721920", Offset = "0x2720D20", Length = "0x5E")]
			[Token(Token = "0x600088E")]
			 get { } //Length: 94
			[Address(RVA = "0x2721B80", Offset = "0x2720F80", Length = "0x62")]
			[Token(Token = "0x600088F")]
			 set { } //Length: 98
		}

		[Token(Token = "0x17000253")]
		public int jewel
		{
			[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
			[Token(Token = "0x6000892")]
			 get { } //Length: 4
			[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
			[Token(Token = "0x6000893")]
			 set { } //Length: 4
		}

		[Token(Token = "0x1700024E")]
		public string MaskedTargetKey
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000889")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000258")]
		public EnemySize ModelSize
		{
			[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
			[Token(Token = "0x600089C")]
			 get { } //Length: 4
			[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
			[Token(Token = "0x600089D")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000250")]
		public string OriginalName
		{
			[Address(RVA = "0x27217F0", Offset = "0x2720BF0", Length = "0x53")]
			[Token(Token = "0x600088C")]
			 get { } //Length: 83
			[Address(RVA = "0x2721A30", Offset = "0x2720E30", Length = "0x6B")]
			[Token(Token = "0x600088D")]
			 set { } //Length: 107
		}

		[Token(Token = "0x1700024F")]
		public string PartsName
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x600088A")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[Token(Token = "0x600088B")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000252")]
		public int pipil
		{
			[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
			[Token(Token = "0x6000890")]
			 get { } //Length: 4
			[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
			[Token(Token = "0x6000891")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000255")]
		public int priority
		{
			[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
			[Token(Token = "0x6000896")]
			 get { } //Length: 4
			[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
			[Token(Token = "0x6000897")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000254")]
		public int score
		{
			[Address(RVA = "0x2721980", Offset = "0x2720D80", Length = "0x51")]
			[Token(Token = "0x6000894")]
			 get { } //Length: 81
			[Address(RVA = "0x2721BF0", Offset = "0x2720FF0", Length = "0x5D")]
			[Token(Token = "0x6000895")]
			 set { } //Length: 93
		}

		[Token(Token = "0x1700024D")]
		public string TargetKey
		{
			[Address(RVA = "0x2721850", Offset = "0x2720C50", Length = "0x4D")]
			[Token(Token = "0x6000887")]
			 get { } //Length: 77
			[Address(RVA = "0x2721AA0", Offset = "0x2720EA0", Length = "0x65")]
			[Token(Token = "0x6000888")]
			 set { } //Length: 101
		}

		[Address(RVA = "0x2721710", Offset = "0x2720B10", Length = "0xA9")]
		[Token(Token = "0x60008A0")]
		public Record() { }

		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600089A")]
		public string get_aliasCnt() { }

		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x6000898")]
		public int get_galleryNo() { }

		[Address(RVA = "0x2721920", Offset = "0x2720D20", Length = "0x5E")]
		[Token(Token = "0x600088E")]
		public float get_hitpoint() { }

		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000892")]
		public int get_jewel() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000889")]
		public string get_MaskedTargetKey() { }

		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x600089C")]
		public EnemySize get_ModelSize() { }

		[Address(RVA = "0x27217F0", Offset = "0x2720BF0", Length = "0x53")]
		[Token(Token = "0x600088C")]
		public string get_OriginalName() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600088A")]
		public string get_PartsName() { }

		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000890")]
		public int get_pipil() { }

		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x6000896")]
		public int get_priority() { }

		[Address(RVA = "0x2721980", Offset = "0x2720D80", Length = "0x51")]
		[Token(Token = "0x6000894")]
		public int get_score() { }

		[Address(RVA = "0x2721850", Offset = "0x2720C50", Length = "0x4D")]
		[Token(Token = "0x6000887")]
		public string get_TargetKey() { }

		[Address(RVA = "0x27214A0", Offset = "0x27208A0", Length = "0x48")]
		[Token(Token = "0x600089F")]
		public toleType GetTole(attackType at) { }

		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x600089B")]
		public void set_aliasCnt(string value) { }

		[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
		[Token(Token = "0x6000899")]
		public void set_galleryNo(int value) { }

		[Address(RVA = "0x2721B80", Offset = "0x2720F80", Length = "0x62")]
		[Token(Token = "0x600088F")]
		public void set_hitpoint(float value) { }

		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x6000893")]
		public void set_jewel(int value) { }

		[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
		[Token(Token = "0x600089D")]
		public void set_ModelSize(EnemySize value) { }

		[Address(RVA = "0x2721A30", Offset = "0x2720E30", Length = "0x6B")]
		[Token(Token = "0x600088D")]
		public void set_OriginalName(string value) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600088B")]
		public void set_PartsName(string value) { }

		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[Token(Token = "0x6000891")]
		public void set_pipil(int value) { }

		[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
		[Token(Token = "0x6000897")]
		public void set_priority(int value) { }

		[Address(RVA = "0x2721BF0", Offset = "0x2720FF0", Length = "0x5D")]
		[Token(Token = "0x6000895")]
		public void set_score(int value) { }

		[Address(RVA = "0x2721AA0", Offset = "0x2720EA0", Length = "0x65")]
		[Token(Token = "0x6000888")]
		public void set_TargetKey(string value) { }

		[Address(RVA = "0x2721560", Offset = "0x2720960", Length = "0x4C")]
		[Token(Token = "0x600089E")]
		public void SetTole(attackType at, toleType tt) { }

	}

	[Token(Token = "0x40008F0")]
	private const int jseed = 225298; //Field offset: 0x0
	[Token(Token = "0x40008F1")]
	private const int sseed = 73783; //Field offset: 0x0
	[Token(Token = "0x40008F2")]
	private const int pseed = 471095; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40008F3")]
	private List<Record> palette; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40008F4")]
	private int _mScore; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40008F5")]
	private int _mJewel; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40008F6")]
	private int _mPi; //Field offset: 0x28

	[Token(Token = "0x1700024C")]
	public List<Record> GetAllData
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000885")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2720AA0", Offset = "0x271FEA0", Length = "0x77")]
	[Token(Token = "0x6000886")]
	public EnemyDataBaseRecords() { }

	[Address(RVA = "0x2720410", Offset = "0x271F810", Length = "0x322")]
	[Token(Token = "0x6000881")]
	public bool Coordinate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000880")]
	public static void CreateAsset() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000885")]
	public List<Record> get_GetAllData() { }

	[Address(RVA = "0x2720860", Offset = "0x271FC60", Length = "0x109")]
	[Token(Token = "0x6000882")]
	public Record GetData(string vstr) { }

	[Address(RVA = "0x2720970", Offset = "0x271FD70", Length = "0x124")]
	[Token(Token = "0x6000883")]
	public Record[] GetDatas(string vstr) { }

	[Address(RVA = "0x2720740", Offset = "0x271FB40", Length = "0x11A")]
	[Token(Token = "0x6000884")]
	public static string GetDBKey(string vstr) { }

}

