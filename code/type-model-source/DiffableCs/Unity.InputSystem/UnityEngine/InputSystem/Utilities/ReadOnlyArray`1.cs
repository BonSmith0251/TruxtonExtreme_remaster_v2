namespace UnityEngine.InputSystem.Utilities;

[DefaultMember("Item")]
[Token(Token = "0x2000264")]
public struct ReadOnlyArray : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue>
{
	[Token(Token = "0x2000265")]
	internal struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CDD")]
		private readonly TValue[] m_Array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CDE")]
		private readonly int m_IndexStart; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CDF")]
		private readonly int m_IndexEnd; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CE0")]
		private int m_Index; //Field offset: 0x0

		[Token(Token = "0x1700060C")]
		public override TValue Current
		{
			[Address(RVA = "0x198B110", Offset = "0x198A510", Length = "0xCF")]
			[Token(Token = "0x6001662")]
			 get { } //Length: 207
		}

		[Token(Token = "0x1700060D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x198A060", Offset = "0x1989460", Length = "0xB5")]
			[Token(Token = "0x6001663")]
			private get { } //Length: 181
		}

		[Address(RVA = "0x198A640", Offset = "0x1989A40", Length = "0x42")]
		[Token(Token = "0x600165E")]
		internal Enumerator(TValue[] array, int index, int length) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600165F")]
		public override void Dispose() { }

		[Address(RVA = "0x198B110", Offset = "0x198A510", Length = "0xCF")]
		[Token(Token = "0x6001662")]
		public override TValue get_Current() { }

		[Address(RVA = "0x1987240", Offset = "0x1986640", Length = "0x12")]
		[Token(Token = "0x6001660")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1988010", Offset = "0x1987410", Length = "0x7")]
		[Token(Token = "0x6001661")]
		public override void Reset() { }

		[Address(RVA = "0x198A060", Offset = "0x1989460", Length = "0xB5")]
		[Token(Token = "0x6001663")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CDA")]
	internal TValue[] m_Array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CDB")]
	internal int m_StartIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CDC")]
	internal int m_Length; //Field offset: 0x0

	[Token(Token = "0x1700060A")]
	public override int Count
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x600165C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700060B")]
	public override TValue Item
	{
		[Address(RVA = "0xEA65C0", Offset = "0xEA59C0", Length = "0xAF")]
		[Token(Token = "0x600165D")]
		 get { } //Length: 175
	}

	[Address(RVA = "0xEA61D0", Offset = "0xEA55D0", Length = "0x33")]
	[Token(Token = "0x6001654")]
	public ReadOnlyArray`1(TValue[] array) { }

	[Address(RVA = "0xD0EDF0", Offset = "0xD0E1F0", Length = "0x36")]
	[Token(Token = "0x6001655")]
	public ReadOnlyArray`1(TValue[] array, int index, int length) { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x600165C")]
	public override int get_Count() { }

	[Address(RVA = "0xEA65C0", Offset = "0xEA59C0", Length = "0xAF")]
	[Token(Token = "0x600165D")]
	public override TValue get_Item(int index) { }

	[Address(RVA = "0xEA5330", Offset = "0xEA4730", Length = "0x7A")]
	[Token(Token = "0x6001658")]
	public Enumerator<TValue> GetEnumerator() { }

	[Address(RVA = "0xEA5C00", Offset = "0xEA5000", Length = "0x184")]
	[Token(Token = "0x6001657")]
	public int IndexOf(Predicate<TValue> predicate) { }

	[Address(RVA = "0xEA6950", Offset = "0xEA5D50", Length = "0x54")]
	[Token(Token = "0x600165B")]
	public static ReadOnlyArray<TValue> op_Implicit(TValue[] array) { }

	[Address(RVA = "0xEA6050", Offset = "0xEA5450", Length = "0xE2")]
	[Token(Token = "0x6001659")]
	private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	[Address(RVA = "0xEA6050", Offset = "0xEA5450", Length = "0xE2")]
	[Token(Token = "0x600165A")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xEA6140", Offset = "0xEA5540", Length = "0x83")]
	[Token(Token = "0x6001656")]
	public TValue[] ToArray() { }

}

