namespace TXEKernel.Sound;

[Token(Token = "0x200011B")]
public class SoundDataBaseRecords : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x200011E")]
	private sealed class <>c
	{
		[Token(Token = "0x40005A7")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40005A8")]
		public static Predicate<Record> <>9__6_0; //Field offset: 0x8

		[Address(RVA = "0x272B790", Offset = "0x272AB90", Length = "0x67")]
		[Token(Token = "0x6000803")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000804")]
		public <>c() { }

		[Address(RVA = "0x272B540", Offset = "0x272A940", Length = "0xB5")]
		[Token(Token = "0x6000805")]
		internal bool <SetData>b__6_0(Record t) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011F")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005A9")]
		public string v; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000806")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x272B690", Offset = "0x272AA90", Length = "0x72")]
		[Token(Token = "0x6000807")]
		internal bool <GetData>b__0(Record p) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000120")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005AA")]
		public SCType tkind; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000808")]
		public <>c__DisplayClass7_0() { }

		[Address(RVA = "0x272B770", Offset = "0x272AB70", Length = "0x1C")]
		[Token(Token = "0x6000809")]
		internal bool <GetKind>b__0(Record p) { }

	}

	[Token(Token = "0x200011C")]
	internal class Record : ICloneable
	{
		[Flags]
		[Token(Token = "0x200011D")]
		internal enum Flag : int
		{
			None = 0,
			OneShot = 1,
			DLC = 1073741824,
			Disable = -2147483648,
		}

		[FieldOffset(Offset = "0x10")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x4000598")]
		[Tooltip("暗号化済")]
		private string _targetKey; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x4000599")]
		[Tooltip("暗号化済")]
		private string _displayname; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x400059A")]
		private int _volume; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x400059B")]
		private int _priority; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x400059C")]
		private int _polyphony; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x400059D")]
		private float _guarantee; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x400059E")]
		private bool _isLoop; //Field offset: 0x30
		[FieldOffset(Offset = "0x31")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x400059F")]
		private bool _isOverwrite; //Field offset: 0x31
		[FieldOffset(Offset = "0x34")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x40005A0")]
		private Flag _flags; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Readonly]
		[SerializeField]
		[Token(Token = "0x40005A1")]
		private SCType _kind; //Field offset: 0x38

		[Token(Token = "0x17000226")]
		public private string displayName
		{
			[Address(RVA = "0x27218A0", Offset = "0x2720CA0", Length = "0x4D")]
			[Token(Token = "0x60007F6")]
			 get { } //Length: 77
			[Address(RVA = "0x2721B10", Offset = "0x2720F10", Length = "0x65")]
			[Token(Token = "0x60007F7")]
			private set { } //Length: 101
		}

		[Token(Token = "0x17000228")]
		public float fvolume
		{
			[Address(RVA = "0x27218F0", Offset = "0x2720CF0", Length = "0x11")]
			[Token(Token = "0x60007F9")]
			 get { } //Length: 17
		}

		[Token(Token = "0x1700022B")]
		public float guarantee
		{
			[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
			[Token(Token = "0x60007FC")]
			 get { } //Length: 6
		}

		[Token(Token = "0x1700022F")]
		public bool IsDisable
		{
			[Address(RVA = "0x27217D0", Offset = "0x2720BD0", Length = "0x7")]
			[Token(Token = "0x6000800")]
			 get { } //Length: 7
		}

		[Token(Token = "0x17000230")]
		public bool IsDLC
		{
			[Address(RVA = "0x27217C0", Offset = "0x2720BC0", Length = "0x9")]
			[Token(Token = "0x6000801")]
			 get { } //Length: 9
		}

		[Token(Token = "0x1700022C")]
		public bool isLoop
		{
			[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
			[Token(Token = "0x60007FD")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700022E")]
		public bool IsOneshot
		{
			[Address(RVA = "0x27217E0", Offset = "0x2720BE0", Length = "0x7")]
			[Token(Token = "0x60007FF")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700022D")]
		public bool isOverwrite
		{
			[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
			[Token(Token = "0x60007FE")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000231")]
		public SCType kind
		{
			[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
			[Token(Token = "0x6000802")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700022A")]
		public int polyphony
		{
			[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
			[Token(Token = "0x60007FB")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000229")]
		public int priority
		{
			[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
			[Token(Token = "0x60007FA")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000225")]
		public private string targetKey
		{
			[Address(RVA = "0x27219E0", Offset = "0x2720DE0", Length = "0x4D")]
			[Token(Token = "0x60007F4")]
			 get { } //Length: 77
			[Address(RVA = "0x2721C50", Offset = "0x2721050", Length = "0x65")]
			[Token(Token = "0x60007F5")]
			private set { } //Length: 101
		}

		[Token(Token = "0x17000227")]
		public int volume
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[Token(Token = "0x60007F8")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x27215D0", Offset = "0x27209D0", Length = "0x137")]
		[Token(Token = "0x60007F1")]
		public Record(string tkey, string dname, int volume, int priority, int polyphony, float guarantee, SCType kind, bool isLoop, bool isOverwrite, Flag tflag) { }

		[Address(RVA = "0x2721420", Offset = "0x2720820", Length = "0x71")]
		[Token(Token = "0x60007F2")]
		public override object Clone() { }

		[Address(RVA = "0x27218A0", Offset = "0x2720CA0", Length = "0x4D")]
		[Token(Token = "0x60007F6")]
		public string get_displayName() { }

		[Address(RVA = "0x27218F0", Offset = "0x2720CF0", Length = "0x11")]
		[Token(Token = "0x60007F9")]
		public float get_fvolume() { }

		[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
		[Token(Token = "0x60007FC")]
		public float get_guarantee() { }

		[Address(RVA = "0x27217D0", Offset = "0x2720BD0", Length = "0x7")]
		[Token(Token = "0x6000800")]
		public bool get_IsDisable() { }

		[Address(RVA = "0x27217C0", Offset = "0x2720BC0", Length = "0x9")]
		[Token(Token = "0x6000801")]
		public bool get_IsDLC() { }

		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x60007FD")]
		public bool get_isLoop() { }

		[Address(RVA = "0x27217E0", Offset = "0x2720BE0", Length = "0x7")]
		[Token(Token = "0x60007FF")]
		public bool get_IsOneshot() { }

		[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
		[Token(Token = "0x60007FE")]
		public bool get_isOverwrite() { }

		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000802")]
		public SCType get_kind() { }

		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60007FB")]
		public int get_polyphony() { }

		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60007FA")]
		public int get_priority() { }

		[Address(RVA = "0x27219E0", Offset = "0x2720DE0", Length = "0x4D")]
		[Token(Token = "0x60007F4")]
		public string get_targetKey() { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60007F8")]
		public int get_volume() { }

		[Address(RVA = "0x2721B10", Offset = "0x2720F10", Length = "0x65")]
		[Token(Token = "0x60007F7")]
		private void set_displayName(string value) { }

		[Address(RVA = "0x2721C50", Offset = "0x2721050", Length = "0x65")]
		[Token(Token = "0x60007F5")]
		private void set_targetKey(string value) { }

		[Address(RVA = "0x2721510", Offset = "0x2720910", Length = "0x47")]
		[Token(Token = "0x60007F3")]
		public void SetParam(int volume = -1, int priority = -1, int polyphony = -1, float gurantee = -1, int isLoop = -1, int isOverwrite = -1) { }

	}

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000597")]
	private List<Record> palette; //Field offset: 0x18

	[Address(RVA = "0x2722050", Offset = "0x2721450", Length = "0x77")]
	[Token(Token = "0x60007F0")]
	public SoundDataBaseRecords() { }

	[Address(RVA = "0x2721CD0", Offset = "0x27210D0", Length = "0x53")]
	[Token(Token = "0x60007EC")]
	public void AddRange(List<Record> aSheet) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007EA")]
	public static void CreateAsset() { }

	[Address(RVA = "0x2721D30", Offset = "0x2721130", Length = "0xD1")]
	[Token(Token = "0x60007ED")]
	public Record GetData(string v) { }

	[Address(RVA = "0x2721E10", Offset = "0x2721210", Length = "0xDE")]
	[Token(Token = "0x60007EF")]
	public Record[] GetKind(SCType tkind) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60007EB")]
	public List<Record> GetPalette() { }

	[Address(RVA = "0x2721EF0", Offset = "0x27212F0", Length = "0x15F")]
	[Token(Token = "0x60007EE")]
	public void SetData(Record r) { }

}

