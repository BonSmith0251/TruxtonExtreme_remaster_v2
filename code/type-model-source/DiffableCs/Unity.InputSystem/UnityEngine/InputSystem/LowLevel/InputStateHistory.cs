namespace UnityEngine.InputSystem.LowLevel;

[DefaultMember("Item")]
[Token(Token = "0x20001E1")]
public class InputStateHistory : IDisposable, IEnumerable<Record>, IEnumerable, IInputStateChangeMonitor
{
	[Token(Token = "0x20001E2")]
	private struct Enumerator : IEnumerator<Record>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AE8")]
		private readonly InputStateHistory m_History; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AE9")]
		private int m_Index; //Field offset: 0x8

		[Token(Token = "0x17000526")]
		public override Record Current
		{
			[Address(RVA = "0x2A05C40", Offset = "0x2A05040", Length = "0x13A")]
			[Token(Token = "0x600120A")]
			 get { } //Length: 314
		}

		[Token(Token = "0x17000527")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2A05B90", Offset = "0x2A04F90", Length = "0x54")]
			[Token(Token = "0x600120B")]
			private get { } //Length: 84
		}

		[Address(RVA = "0xABED90", Offset = "0xABE190", Length = "0x1E")]
		[Token(Token = "0x6001207")]
		public Enumerator(InputStateHistory history) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600120C")]
		public override void Dispose() { }

		[Address(RVA = "0x2A05C40", Offset = "0x2A05040", Length = "0x13A")]
		[Token(Token = "0x600120A")]
		public override Record get_Current() { }

		[Address(RVA = "0x1995300", Offset = "0x1994700", Length = "0x2C")]
		[Token(Token = "0x6001208")]
		public override bool MoveNext() { }

		[Address(RVA = "0xABED80", Offset = "0xABE180", Length = "0x8")]
		[Token(Token = "0x6001209")]
		public override void Reset() { }

		[Address(RVA = "0x2A05B90", Offset = "0x2A04F90", Length = "0x54")]
		[Token(Token = "0x600120B")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x20001E6")]
	internal struct Record : IEquatable<Record>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF3")]
		private readonly InputStateHistory m_Owner; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AF4")]
		private readonly int m_IndexPlusOne; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000AF5")]
		private uint m_Version; //Field offset: 0xC

		[Token(Token = "0x17000531")]
		public InputControl control
		{
			[Address(RVA = "0x2A14720", Offset = "0x2A13B20", Length = "0x10D")]
			[Token(Token = "0x6001216")]
			 get { } //Length: 269
		}

		[Token(Token = "0x1700052A")]
		internal RecordHeader* header
		{
			[Address(RVA = "0x2A14830", Offset = "0x2A13C30", Length = "0x25")]
			[Token(Token = "0x600120F")]
			internal get { } //Length: 37
		}

		[Token(Token = "0x1700052F")]
		public int index
		{
			[Address(RVA = "0x2A14860", Offset = "0x2A13C60", Length = "0x3E")]
			[Token(Token = "0x6001214")]
			 get { } //Length: 62
		}

		[Token(Token = "0x17000532")]
		public Record next
		{
			[Address(RVA = "0x2A148A0", Offset = "0x2A13CA0", Length = "0xE6")]
			[Token(Token = "0x6001217")]
			 get { } //Length: 230
		}

		[Token(Token = "0x1700052E")]
		public InputStateHistory owner
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x6001213")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000533")]
		public Record previous
		{
			[Address(RVA = "0x2A14990", Offset = "0x2A13D90", Length = "0xF5")]
			[Token(Token = "0x6001218")]
			 get { } //Length: 245
		}

		[Token(Token = "0x1700052B")]
		internal int recordIndex
		{
			[Address(RVA = "0xF4D500", Offset = "0xF4C900", Length = "0x6")]
			[Token(Token = "0x6001210")]
			internal get { } //Length: 6
		}

		[Token(Token = "0x17000530")]
		public double time
		{
			[Address(RVA = "0x2A14A90", Offset = "0x2A13E90", Length = "0x39")]
			[Token(Token = "0x6001215")]
			 get { } //Length: 57
		}

		[Token(Token = "0x1700052D")]
		public bool valid
		{
			[Address(RVA = "0x2A14AD0", Offset = "0x2A13ED0", Length = "0x46")]
			[Token(Token = "0x6001212")]
			 get { } //Length: 70
		}

		[Token(Token = "0x1700052C")]
		internal uint version
		{
			[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
			[Token(Token = "0x6001211")]
			internal get { } //Length: 4
		}

		[Address(RVA = "0xF4C810", Offset = "0xF4BC10", Length = "0x46")]
		[Token(Token = "0x6001219")]
		internal Record(InputStateHistory owner, int index, RecordHeader* header) { }

		[Address(RVA = "0x2A13C00", Offset = "0x2A13000", Length = "0xCF")]
		[Token(Token = "0x6001221")]
		internal void CheckValid() { }

		[Address(RVA = "0x2A13CD0", Offset = "0x2A130D0", Length = "0x4CF")]
		[Token(Token = "0x6001220")]
		public void CopyFrom(Record record) { }

		[Address(RVA = "0xB4A000", Offset = "0xB49400", Length = "0x1D")]
		[Token(Token = "0x6001222")]
		public override bool Equals(Record other) { }

		[Address(RVA = "0x2A141A0", Offset = "0x2A135A0", Length = "0x96")]
		[Token(Token = "0x6001223")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x2A14720", Offset = "0x2A13B20", Length = "0x10D")]
		[Token(Token = "0x6001216")]
		public InputControl get_control() { }

		[Address(RVA = "0x2A14830", Offset = "0x2A13C30", Length = "0x25")]
		[Token(Token = "0x600120F")]
		internal RecordHeader* get_header() { }

		[Address(RVA = "0x2A14860", Offset = "0x2A13C60", Length = "0x3E")]
		[Token(Token = "0x6001214")]
		public int get_index() { }

		[Address(RVA = "0x2A148A0", Offset = "0x2A13CA0", Length = "0xE6")]
		[Token(Token = "0x6001217")]
		public Record get_next() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6001213")]
		public InputStateHistory get_owner() { }

		[Address(RVA = "0x2A14990", Offset = "0x2A13D90", Length = "0xF5")]
		[Token(Token = "0x6001218")]
		public Record get_previous() { }

		[Address(RVA = "0xF4D500", Offset = "0xF4C900", Length = "0x6")]
		[Token(Token = "0x6001210")]
		internal int get_recordIndex() { }

		[Address(RVA = "0x2A14A90", Offset = "0x2A13E90", Length = "0x39")]
		[Token(Token = "0x6001215")]
		public double get_time() { }

		[Address(RVA = "0x2A14AD0", Offset = "0x2A13ED0", Length = "0x46")]
		[Token(Token = "0x6001212")]
		public bool get_valid() { }

		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x6001211")]
		internal uint get_version() { }

		[Address(RVA = "0xF4B9F0", Offset = "0xF4ADF0", Length = "0x41")]
		[Token(Token = "0x6001224")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x2A14310", Offset = "0x2A13710", Length = "0x1F")]
		[Token(Token = "0x600121E")]
		public Void* GetUnsafeExtraMemoryPtr() { }

		[Address(RVA = "0x2A14240", Offset = "0x2A13640", Length = "0xCE")]
		[Token(Token = "0x600121F")]
		internal Void* GetUnsafeExtraMemoryPtrUnchecked() { }

		[Address(RVA = "0x2A14420", Offset = "0x2A13820", Length = "0x1F")]
		[Token(Token = "0x600121C")]
		public Void* GetUnsafeMemoryPtr() { }

		[Address(RVA = "0x2A14330", Offset = "0x2A13730", Length = "0xE3")]
		[Token(Token = "0x600121D")]
		internal Void* GetUnsafeMemoryPtrUnchecked() { }

		[Address(RVA = "0x9F63F0", Offset = "0x9F57F0", Length = "0xD7")]
		[Token(Token = "0x600121A")]
		public TValue ReadValue() { }

		[Address(RVA = "0x2A14440", Offset = "0x2A13840", Length = "0x1BB")]
		[Token(Token = "0x600121B")]
		public object ReadValueAsObject() { }

		[Address(RVA = "0x2A14600", Offset = "0x2A13A00", Length = "0x113")]
		[Token(Token = "0x6001225")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x20001E3")]
	private struct RecordHeader
	{
		[CompilerGenerated]
		[Token(Token = "0x20001E4")]
		[UnsafeValueType]
		internal struct <m_StateWithControlIndex>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000AF1")]
			public byte FixedElementField; //Field offset: 0x0

		}

		[CompilerGenerated]
		[Token(Token = "0x20001E5")]
		[UnsafeValueType]
		internal struct <m_StateWithoutControlIndex>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000AF2")]
			public byte FixedElementField; //Field offset: 0x0

		}

		[Token(Token = "0x4000AEF")]
		public const int kSizeWithControlIndex = 16; //Field offset: 0x0
		[Token(Token = "0x4000AF0")]
		public const int kSizeWithoutControlIndex = 12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AEA")]
		public double time; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AEB")]
		public uint version; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000AEC")]
		public int controlIndex; //Field offset: 0xC
		[FieldOffset(Offset = "0xC")]
		[FixedBuffer(typeof(byte), 1)]
		[Token(Token = "0x4000AED")]
		private <m_StateWithoutControlIndex>e__FixedBuffer m_StateWithoutControlIndex; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[FixedBuffer(typeof(byte), 1)]
		[Token(Token = "0x4000AEE")]
		private <m_StateWithControlIndex>e__FixedBuffer m_StateWithControlIndex; //Field offset: 0x10

		[Token(Token = "0x17000528")]
		public Byte* statePtrWithControlIndex
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x600120D")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000529")]
		public Byte* statePtrWithoutControlIndex
		{
			[Address(RVA = "0x2043710", Offset = "0x2042B10", Length = "0x5")]
			[Token(Token = "0x600120E")]
			 get { } //Length: 5
		}

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x600120D")]
		public Byte* get_statePtrWithControlIndex() { }

		[Address(RVA = "0x2043710", Offset = "0x2042B10", Length = "0x5")]
		[Token(Token = "0x600120E")]
		public Byte* get_statePtrWithoutControlIndex() { }

	}

	[Token(Token = "0x4000ADA")]
	private const int kDefaultHistorySize = 128; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000ADB")]
	private Action<Record> <onRecordAdded>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000ADC")]
	private Func<InputControl, Double, InputEventPtr, Boolean> <onShouldRecordStateChange>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000ADD")]
	internal InputControl[] m_Controls; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000ADE")]
	internal int m_ControlCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000ADF")]
	private NativeArray<Byte> m_RecordBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AE0")]
	private int m_StateSizeInBytes; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000AE1")]
	private int m_RecordCount; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000AE2")]
	private int m_HistoryDepth; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000AE3")]
	private int m_ExtraMemoryPerRecord; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000AE4")]
	internal int m_HeadIndex; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000AE5")]
	internal uint m_CurrentVersion; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000AE6")]
	private Nullable<InputUpdateType> m_UpdateMask; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000AE7")]
	internal readonly bool m_AddNewControls; //Field offset: 0x60

	[Token(Token = "0x17000525")]
	internal int bytesPerRecord
	{
		[Address(RVA = "0x2A10480", Offset = "0x2A0F880", Length = "0x3B")]
		[Token(Token = "0x6001206")]
		internal get { } //Length: 59
	}

	[Token(Token = "0x17000521")]
	public ReadOnlyArray<InputControl> controls
	{
		[Address(RVA = "0x2A104C0", Offset = "0x2A0F8C0", Length = "0x5F")]
		[Token(Token = "0x60011E6")]
		 get { } //Length: 95
	}

	[Token(Token = "0x1700051C")]
	public override int Count
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x60011DE")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700051F")]
	public int extraMemoryPerRecord
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x60011E2")]
		 get { } //Length: 4
		[Address(RVA = "0x2A10720", Offset = "0x2A0FB20", Length = "0xD7")]
		[Token(Token = "0x60011E3")]
		 set { } //Length: 215
	}

	[Token(Token = "0x1700051E")]
	public int historyDepth
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60011E0")]
		 get { } //Length: 4
		[Address(RVA = "0x2A10800", Offset = "0x2A0FC00", Length = "0xD7")]
		[Token(Token = "0x60011E1")]
		 set { } //Length: 215
	}

	[Token(Token = "0x17000522")]
	public Record Item
	{
		[Address(RVA = "0x2A10360", Offset = "0x2A0F760", Length = "0x118")]
		[Token(Token = "0x60011E7")]
		 get { } //Length: 280
		[Address(RVA = "0x2A105C0", Offset = "0x2A0F9C0", Length = "0x153")]
		[Token(Token = "0x60011E8")]
		 set { } //Length: 339
	}

	[Token(Token = "0x17000523")]
	public Action<Record> onRecordAdded
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011E9")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60011EA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000524")]
	public Func<InputControl, Double, InputEventPtr, Boolean> onShouldRecordStateChange
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011EB")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60011EC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000520")]
	public InputUpdateType updateMask
	{
		[Address(RVA = "0x2A10520", Offset = "0x2A0F920", Length = "0x92")]
		[Token(Token = "0x60011E4")]
		 get { } //Length: 146
		[Address(RVA = "0x2A108E0", Offset = "0x2A0FCE0", Length = "0xB9")]
		[Token(Token = "0x60011E5")]
		 set { } //Length: 185
	}

	[Token(Token = "0x1700051D")]
	public uint version
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x60011DF")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2A10070", Offset = "0x2A0F470", Length = "0x80")]
	[Token(Token = "0x60011F0")]
	public InputStateHistory(IEnumerable<InputControl> controls) { }

	[Address(RVA = "0x2A10230", Offset = "0x2A0F630", Length = "0x121")]
	[Token(Token = "0x60011EF")]
	public InputStateHistory(InputControl control) { }

	[Address(RVA = "0x2A10100", Offset = "0x2A0F500", Length = "0x124")]
	[Token(Token = "0x60011EE")]
	public InputStateHistory(string path) { }

	[Address(RVA = "0x2A0FFD0", Offset = "0x2A0F3D0", Length = "0x99")]
	[Token(Token = "0x60011ED")]
	public InputStateHistory(int maxStateSizeInBytes) { }

	[Address(RVA = "0x2A0E9D0", Offset = "0x2A0DDD0", Length = "0x96")]
	[Token(Token = "0x60011F3")]
	public Record AddRecord(Record record) { }

	[Address(RVA = "0x2A0EB50", Offset = "0x2A0DF50", Length = "0x2C8")]
	[Token(Token = "0x60011FC")]
	private void Allocate() { }

	[Address(RVA = "0x2A0EA70", Offset = "0x2A0DE70", Length = "0xD6")]
	[Token(Token = "0x6001201")]
	protected private RecordHeader* AllocateRecord(out int index) { }

	[Address(RVA = "0x2A0EE20", Offset = "0x2A0E220", Length = "0xC")]
	[Token(Token = "0x60011F2")]
	public void Clear() { }

	[Address(RVA = "0x2A0EE30", Offset = "0x2A0E230", Length = "0x55")]
	[Token(Token = "0x60011FB")]
	protected void Destroy() { }

	[Address(RVA = "0x2A0EE90", Offset = "0x2A0E290", Length = "0x99")]
	[Token(Token = "0x60011FA")]
	public override void Dispose() { }

	[Address(RVA = "0x2A0EF30", Offset = "0x2A0E330", Length = "0xDD")]
	[Token(Token = "0x60011F1")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2A10480", Offset = "0x2A0F880", Length = "0x3B")]
	[Token(Token = "0x6001206")]
	internal int get_bytesPerRecord() { }

	[Address(RVA = "0x2A104C0", Offset = "0x2A0F8C0", Length = "0x5F")]
	[Token(Token = "0x60011E6")]
	public ReadOnlyArray<InputControl> get_controls() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x60011DE")]
	public override int get_Count() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x60011E2")]
	public int get_extraMemoryPerRecord() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60011E0")]
	public int get_historyDepth() { }

	[Address(RVA = "0x2A10360", Offset = "0x2A0F760", Length = "0x118")]
	[Token(Token = "0x60011E7")]
	public Record get_Item(int index) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011E9")]
	public Action<Record> get_onRecordAdded() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011EB")]
	public Func<InputControl, Double, InputEventPtr, Boolean> get_onShouldRecordStateChange() { }

	[Address(RVA = "0x2A10520", Offset = "0x2A0F920", Length = "0x92")]
	[Token(Token = "0x60011E4")]
	public InputUpdateType get_updateMask() { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[Token(Token = "0x60011DF")]
	public uint get_version() { }

	[Address(RVA = "0x2A0F010", Offset = "0x2A0E410", Length = "0x6A")]
	[Token(Token = "0x60011F8")]
	public override IEnumerator<Record> GetEnumerator() { }

	[Address(RVA = "0x2A0F120", Offset = "0x2A0E520", Length = "0x15C")]
	[Token(Token = "0x60011FF")]
	protected private RecordHeader* GetRecord(int index) { }

	[Address(RVA = "0x2A0F080", Offset = "0x2A0E480", Length = "0x93")]
	[Token(Token = "0x6001200")]
	internal RecordHeader* GetRecordUnchecked(int index) { }

	[Address(RVA = "0x848CC0", Offset = "0x8480C0", Length = "0x277")]
	[Token(Token = "0x6001202")]
	protected TValue ReadValue(RecordHeader* data) { }

	[Address(RVA = "0x2A0F280", Offset = "0x2A0E680", Length = "0x18E")]
	[Token(Token = "0x6001203")]
	protected object ReadValueAsObject(RecordHeader* data) { }

	[Address(RVA = "0x2A0F410", Offset = "0x2A0E810", Length = "0x14")]
	[Token(Token = "0x60011FD")]
	protected private int RecordIndexToUserIndex(int index) { }

	[Address(RVA = "0x2A0F430", Offset = "0x2A0E830", Length = "0x2FE")]
	[Token(Token = "0x60011F6")]
	public Record RecordStateChange(InputControl control, InputEventPtr eventPtr) { }

	[Address(RVA = "0x2A0F730", Offset = "0x2A0EB30", Length = "0x353")]
	[Token(Token = "0x60011F7")]
	public Record RecordStateChange(InputControl control, Void* statePtr, double time) { }

	[Address(RVA = "0x2A10720", Offset = "0x2A0FB20", Length = "0xD7")]
	[Token(Token = "0x60011E3")]
	public void set_extraMemoryPerRecord(int value) { }

	[Address(RVA = "0x2A10800", Offset = "0x2A0FC00", Length = "0xD7")]
	[Token(Token = "0x60011E1")]
	public void set_historyDepth(int value) { }

	[Address(RVA = "0x2A105C0", Offset = "0x2A0F9C0", Length = "0x153")]
	[Token(Token = "0x60011E8")]
	public void set_Item(int index, Record value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60011EA")]
	public void set_onRecordAdded(Action<Record> value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60011EC")]
	public void set_onShouldRecordStateChange(Func<InputControl, Double, InputEventPtr, Boolean> value) { }

	[Address(RVA = "0x2A108E0", Offset = "0x2A0FCE0", Length = "0xB9")]
	[Token(Token = "0x60011E5")]
	public void set_updateMask(InputUpdateType value) { }

	[Address(RVA = "0x2A0FA90", Offset = "0x2A0EE90", Length = "0x188")]
	[Token(Token = "0x60011F4")]
	public void StartRecording() { }

	[Address(RVA = "0x2A0FC20", Offset = "0x2A0F020", Length = "0x239")]
	[Token(Token = "0x60011F5")]
	public void StopRecording() { }

	[Address(RVA = "0x2A0F010", Offset = "0x2A0E410", Length = "0x6A")]
	[Token(Token = "0x60011F9")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x2A0FE60", Offset = "0x2A0F260", Length = "0x151")]
	[Token(Token = "0x6001204")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001205")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) { }

	[Address(RVA = "0x2A0FFC0", Offset = "0x2A0F3C0", Length = "0xC")]
	[Token(Token = "0x60011FE")]
	protected private int UserIndexToRecordIndex(int index) { }

}

