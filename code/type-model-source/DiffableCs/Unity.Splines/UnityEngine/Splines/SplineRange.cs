namespace UnityEngine.Splines;

[DefaultMember("Item")]
[Token(Token = "0x2000056")]
public struct SplineRange : IEnumerable<Int32>, IEnumerable
{
	[Token(Token = "0x2000057")]
	internal struct SplineRangeEnumerator : IEnumerator<Int32>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014E")]
		private int m_Index; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400014F")]
		private int m_Start; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000150")]
		private int m_End; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000151")]
		private int m_Count; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000152")]
		private bool m_Reverse; //Field offset: 0x10

		[Token(Token = "0x170000BC")]
		public override int Current
		{
			[Address(RVA = "0x2E76BA0", Offset = "0x2E75FA0", Length = "0x12")]
			[Token(Token = "0x60002FC")]
			 get { } //Length: 18
		}

		[Token(Token = "0x170000BD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2E76B20", Offset = "0x2E75F20", Length = "0x30")]
			[Token(Token = "0x60002FD")]
			private get { } //Length: 48
		}

		[Address(RVA = "0x2E76B50", Offset = "0x2E75F50", Length = "0x4D")]
		[Token(Token = "0x60002FE")]
		public SplineRangeEnumerator(SplineRange range) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60002FF")]
		public override void Dispose() { }

		[Address(RVA = "0x2E76BA0", Offset = "0x2E75FA0", Length = "0x12")]
		[Token(Token = "0x60002FC")]
		public override int get_Current() { }

		[Address(RVA = "0x2E76B10", Offset = "0x2E75F10", Length = "0xB")]
		[Token(Token = "0x60002FA")]
		public override bool MoveNext() { }

		[Address(RVA = "0x292D6A0", Offset = "0x292CAA0", Length = "0x7")]
		[Token(Token = "0x60002FB")]
		public override void Reset() { }

		[Address(RVA = "0x2E76B20", Offset = "0x2E75F20", Length = "0x30")]
		[Token(Token = "0x60002FD")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400014B")]
	private int m_Start; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x400014C")]
	private int m_Count; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x400014D")]
	private SliceDirection m_Direction; //Field offset: 0x8

	[Token(Token = "0x170000B9")]
	public int Count
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60002F0")]
		 get { } //Length: 4
		[Address(RVA = "0x2E76DA0", Offset = "0x2E761A0", Length = "0xD")]
		[Token(Token = "0x60002F1")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000BA")]
	public SliceDirection Direction
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60002F2")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x60002F3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000B8")]
	public int End
	{
		[Address(RVA = "0x2E76D60", Offset = "0x2E76160", Length = "0x1B")]
		[Token(Token = "0x60002EF")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170000BB")]
	public int Item
	{
		[Address(RVA = "0x2E76D80", Offset = "0x2E76180", Length = "0x13")]
		[Token(Token = "0x60002F6")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170000B7")]
	public int Start
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60002ED")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60002EE")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x2E76D20", Offset = "0x2E76120", Length = "0x1C")]
	[Token(Token = "0x60002F4")]
	public SplineRange(int start, int count) { }

	[Address(RVA = "0x2E76D40", Offset = "0x2E76140", Length = "0x16")]
	[Token(Token = "0x60002F5")]
	public SplineRange(int start, int count, SliceDirection direction) { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60002F0")]
	public int get_Count() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60002F2")]
	public SliceDirection get_Direction() { }

	[Address(RVA = "0x2E76D60", Offset = "0x2E76160", Length = "0x1B")]
	[Token(Token = "0x60002EF")]
	public int get_End() { }

	[Address(RVA = "0x2E76D80", Offset = "0x2E76180", Length = "0x13")]
	[Token(Token = "0x60002F6")]
	public int get_Item(int index) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60002ED")]
	public int get_Start() { }

	[Address(RVA = "0x2E76BC0", Offset = "0x2E75FC0", Length = "0xB6")]
	[Token(Token = "0x60002F7")]
	public override IEnumerator<Int32> GetEnumerator() { }

	[Address(RVA = "0x2E76DA0", Offset = "0x2E761A0", Length = "0xD")]
	[Token(Token = "0x60002F1")]
	public void set_Count(int value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x60002F3")]
	public void set_Direction(SliceDirection value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x60002EE")]
	public void set_Start(int value) { }

	[Address(RVA = "0x2E76C80", Offset = "0x2E76080", Length = "0x7")]
	[Token(Token = "0x60002F8")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x2E76C90", Offset = "0x2E76090", Length = "0x90")]
	[Token(Token = "0x60002F9")]
	public virtual string ToString() { }

}

