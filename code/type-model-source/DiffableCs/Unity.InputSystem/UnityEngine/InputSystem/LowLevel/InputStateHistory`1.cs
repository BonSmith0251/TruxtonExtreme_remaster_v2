namespace UnityEngine.InputSystem.LowLevel;

[DefaultMember("Item")]
[Token(Token = "0x20001E7")]
public class InputStateHistory : InputStateHistory, IReadOnlyList<Record<TValue>>, IEnumerable<Record<TValue>>, IEnumerable, IReadOnlyCollection<Record<TValue>>
{
	[Token(Token = "0x20001E8")]
	private struct Enumerator : IEnumerator<Record<TValue>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF6")]
		private readonly InputStateHistory<TValue> m_History; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF7")]
		private int m_Index; //Field offset: 0x0

		[Token(Token = "0x17000535")]
		public override Record<TValue> Current
		{
			[Address(RVA = "0x199AC90", Offset = "0x199A090", Length = "0x6D")]
			[Token(Token = "0x6001233")]
			 get { } //Length: 109
		}

		[Token(Token = "0x17000536")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x199A070", Offset = "0x1999470", Length = "0xBE")]
			[Token(Token = "0x6001234")]
			private get { } //Length: 190
		}

		[Address(RVA = "0xABED90", Offset = "0xABE190", Length = "0x1E")]
		[Token(Token = "0x6001230")]
		public Enumerator(InputStateHistory<TValue> history) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6001235")]
		public override void Dispose() { }

		[Address(RVA = "0x199AC90", Offset = "0x199A090", Length = "0x6D")]
		[Token(Token = "0x6001233")]
		public override Record<TValue> get_Current() { }

		[Address(RVA = "0x1995300", Offset = "0x1994700", Length = "0x2C")]
		[Token(Token = "0x6001231")]
		public override bool MoveNext() { }

		[Address(RVA = "0xABED80", Offset = "0xABE180", Length = "0x8")]
		[Token(Token = "0x6001232")]
		public override void Reset() { }

		[Address(RVA = "0x199A070", Offset = "0x1999470", Length = "0xBE")]
		[Token(Token = "0x6001234")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x20001E9")]
	internal struct Record : IEquatable<Record<TValue>>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF8")]
		private readonly InputStateHistory<TValue> m_Owner; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF9")]
		private readonly int m_IndexPlusOne; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AFA")]
		private uint m_Version; //Field offset: 0x0

		[Token(Token = "0x1700053D")]
		public InputControl<TValue> control
		{
			[Address(RVA = "0xF4C860", Offset = "0xF4BC60", Length = "0x244")]
			[Token(Token = "0x600123C")]
			 get { } //Length: 580
		}

		[Token(Token = "0x17000537")]
		internal RecordHeader* header
		{
			[Address(RVA = "0xF4CD10", Offset = "0xF4C110", Length = "0x46")]
			[Token(Token = "0x6001236")]
			internal get { } //Length: 70
		}

		[Token(Token = "0x1700053B")]
		public int index
		{
			[Address(RVA = "0xF4CE00", Offset = "0xF4C200", Length = "0x7B")]
			[Token(Token = "0x600123A")]
			 get { } //Length: 123
		}

		[Token(Token = "0x1700053E")]
		public Record<TValue> next
		{
			[Address(RVA = "0xF4D0F0", Offset = "0xF4C4F0", Length = "0x138")]
			[Token(Token = "0x600123D")]
			 get { } //Length: 312
		}

		[Token(Token = "0x1700053A")]
		public InputStateHistory<TValue> owner
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x6001239")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700053F")]
		public Record<TValue> previous
		{
			[Address(RVA = "0xF4D3C0", Offset = "0xF4C7C0", Length = "0x134")]
			[Token(Token = "0x600123E")]
			 get { } //Length: 308
		}

		[Token(Token = "0x17000538")]
		internal int recordIndex
		{
			[Address(RVA = "0xF4D500", Offset = "0xF4C900", Length = "0x6")]
			[Token(Token = "0x6001237")]
			internal get { } //Length: 6
		}

		[Token(Token = "0x1700053C")]
		public double time
		{
			[Address(RVA = "0xF4D5E0", Offset = "0xF4C9E0", Length = "0x9B")]
			[Token(Token = "0x600123B")]
			 get { } //Length: 155
		}

		[Token(Token = "0x17000539")]
		public bool valid
		{
			[Address(RVA = "0xF4D720", Offset = "0xF4CB20", Length = "0x8A")]
			[Token(Token = "0x6001238")]
			 get { } //Length: 138
		}

		[Address(RVA = "0xF4C7E0", Offset = "0xF4BBE0", Length = "0x30")]
		[Token(Token = "0x6001240")]
		internal Record(InputStateHistory<TValue> owner, int index) { }

		[Address(RVA = "0xF4C810", Offset = "0xF4BC10", Length = "0x46")]
		[Token(Token = "0x600123F")]
		internal Record(InputStateHistory<TValue> owner, int index, RecordHeader* header) { }

		[Address(RVA = "0xF4B180", Offset = "0xF4A580", Length = "0x10F")]
		[Token(Token = "0x6001247")]
		private void CheckValid() { }

		[Address(RVA = "0xF4B290", Offset = "0xF4A690", Length = "0x225")]
		[Token(Token = "0x6001246")]
		public void CopyFrom(Record<TValue> record) { }

		[Address(RVA = "0xF4B8D0", Offset = "0xF4ACD0", Length = "0x114")]
		[Token(Token = "0x6001249")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0xB4A000", Offset = "0xB49400", Length = "0x1D")]
		[Token(Token = "0x6001248")]
		public override bool Equals(Record<TValue> other) { }

		[Address(RVA = "0xF4C860", Offset = "0xF4BC60", Length = "0x244")]
		[Token(Token = "0x600123C")]
		public InputControl<TValue> get_control() { }

		[Address(RVA = "0xF4CD10", Offset = "0xF4C110", Length = "0x46")]
		[Token(Token = "0x6001236")]
		internal RecordHeader* get_header() { }

		[Address(RVA = "0xF4CE00", Offset = "0xF4C200", Length = "0x7B")]
		[Token(Token = "0x600123A")]
		public int get_index() { }

		[Address(RVA = "0xF4D0F0", Offset = "0xF4C4F0", Length = "0x138")]
		[Token(Token = "0x600123D")]
		public Record<TValue> get_next() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6001239")]
		public InputStateHistory<TValue> get_owner() { }

		[Address(RVA = "0xF4D3C0", Offset = "0xF4C7C0", Length = "0x134")]
		[Token(Token = "0x600123E")]
		public Record<TValue> get_previous() { }

		[Address(RVA = "0xF4D500", Offset = "0xF4C900", Length = "0x6")]
		[Token(Token = "0x6001237")]
		internal int get_recordIndex() { }

		[Address(RVA = "0xF4D5E0", Offset = "0xF4C9E0", Length = "0x9B")]
		[Token(Token = "0x600123B")]
		public double get_time() { }

		[Address(RVA = "0xF4D720", Offset = "0xF4CB20", Length = "0x8A")]
		[Token(Token = "0x6001238")]
		public bool get_valid() { }

		[Address(RVA = "0xF4B9F0", Offset = "0xF4ADF0", Length = "0x41")]
		[Token(Token = "0x600124A")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0xF4BCE0", Offset = "0xF4B0E0", Length = "0x6A")]
		[Token(Token = "0x6001244")]
		public Void* GetUnsafeExtraMemoryPtr() { }

		[Address(RVA = "0xF4BB30", Offset = "0xF4AF30", Length = "0xE3")]
		[Token(Token = "0x6001245")]
		internal Void* GetUnsafeExtraMemoryPtrUnchecked() { }

		[Address(RVA = "0xF4BFC0", Offset = "0xF4B3C0", Length = "0x6A")]
		[Token(Token = "0x6001242")]
		public Void* GetUnsafeMemoryPtr() { }

		[Address(RVA = "0xF4BE90", Offset = "0xF4B290", Length = "0x125")]
		[Token(Token = "0x6001243")]
		internal Void* GetUnsafeMemoryPtrUnchecked() { }

		[Address(RVA = "0xF4C290", Offset = "0xF4B690", Length = "0x11D")]
		[Token(Token = "0x6001241")]
		public TValue ReadValue() { }

		[Address(RVA = "0xF4C3B0", Offset = "0xF4B7B0", Length = "0x1C4")]
		[Token(Token = "0x600124B")]
		public virtual string ToString() { }

	}


	[Token(Token = "0x17000534")]
	public override Record<TValue> Item
	{
		[Address(RVA = "0x1CB9990", Offset = "0x1CB8D90", Length = "0x129")]
		[Token(Token = "0x600122E")]
		 get { } //Length: 297
		[Address(RVA = "0x1CB9C40", Offset = "0x1CB9040", Length = "0x179")]
		[Token(Token = "0x600122F")]
		 set { } //Length: 377
	}

	[Address(RVA = "0x1CB9560", Offset = "0x1CB8960", Length = "0xCC")]
	[Token(Token = "0x6001226")]
	public InputStateHistory`1(Nullable<Int32> maxStateSizeInBytes = null) { }

	[Address(RVA = "0x1CB9980", Offset = "0x1CB8D80", Length = "0x8")]
	[Token(Token = "0x6001227")]
	public InputStateHistory`1(InputControl<TValue> control) { }

	[Address(RVA = "0x1CB9210", Offset = "0x1CB8610", Length = "0x34A")]
	[Token(Token = "0x6001228")]
	public InputStateHistory`1(string path) { }

	[Address(RVA = "0x1CB8A20", Offset = "0x1CB7E20", Length = "0xAC")]
	[Token(Token = "0x600122A")]
	public Record<TValue> AddRecord(Record<TValue> record) { }

	[Address(RVA = "0x1CB8AD0", Offset = "0x1CB7ED0", Length = "0x78")]
	[Token(Token = "0x6001229")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1CB9990", Offset = "0x1CB8D90", Length = "0x129")]
	[Token(Token = "0x600122E")]
	public override Record<TValue> get_Item(int index) { }

	[Address(RVA = "0x1CB8B50", Offset = "0x1CB7F50", Length = "0x57")]
	[Token(Token = "0x600122C")]
	public override IEnumerator<Record<TValue>> GetEnumerator() { }

	[Address(RVA = "0x1CB8E30", Offset = "0x1CB8230", Length = "0x264")]
	[Token(Token = "0x600122B")]
	public Record<TValue> RecordStateChange(InputControl<TValue> control, TValue value, double time = -1) { }

	[Address(RVA = "0x1CB9C40", Offset = "0x1CB9040", Length = "0x179")]
	[Token(Token = "0x600122F")]
	public void set_Item(int index, Record<TValue> value) { }

	[Address(RVA = "0x1CB90A0", Offset = "0x1CB84A0", Length = "0x63")]
	[Token(Token = "0x600122D")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

