namespace Unity.Collections;

[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(NativeSliceDebugView`1))]
[DefaultMember("Item")]
[NativeContainer]
[NativeContainerSupportsMinMaxWriteRestriction]
[Token(Token = "0x2000061")]
public struct NativeSlice : IEnumerable<T>, IEnumerable, IEquatable<NativeSlice`1<T>>
{
	[ExcludeFromDocs]
	[Token(Token = "0x2000062")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400010E")]
		private NativeSlice<T> m_Array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400010F")]
		private int m_Index; //Field offset: 0x0

		[Token(Token = "0x17000027")]
		public override T Current
		{
			[Address(RVA = "0x1964230", Offset = "0x1963630", Length = "0xDE")]
			[Token(Token = "0x600013B")]
			 get { } //Length: 222
		}

		[Token(Token = "0x17000028")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1962210", Offset = "0x1961610", Length = "0xF9")]
			[Token(Token = "0x600013C")]
			private get { } //Length: 249
		}

		[Address(RVA = "0x1962EF0", Offset = "0x19622F0", Length = "0xE")]
		[Token(Token = "0x6000137")]
		public Enumerator(ref NativeSlice<T>& array) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000138")]
		public override void Dispose() { }

		[Address(RVA = "0x1964230", Offset = "0x1963630", Length = "0xDE")]
		[Token(Token = "0x600013B")]
		public override T get_Current() { }

		[Address(RVA = "0x195DFA0", Offset = "0x195D3A0", Length = "0x4D")]
		[Token(Token = "0x6000139")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195F910", Offset = "0x195ED10", Length = "0x8")]
		[Token(Token = "0x600013A")]
		public override void Reset() { }

		[Address(RVA = "0x1962210", Offset = "0x1961610", Length = "0xF9")]
		[Token(Token = "0x600013C")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400010B")]
	internal Byte* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010C")]
	internal int m_Stride; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010D")]
	internal int m_Length; //Field offset: 0x0

	[Token(Token = "0x17000024")]
	public T Item
	{
		[Address(RVA = "0xD93D70", Offset = "0xD93170", Length = "0xEA")]
		[Token(Token = "0x600012C")]
		 get { } //Length: 234
		[Address(RVA = "0xD94260", Offset = "0xD93660", Length = "0xC8")]
		[Token(Token = "0x600012D")]
		[WriteAccessRequired]
		 set { } //Length: 200
	}

	[Token(Token = "0x17000026")]
	public int Length
	{
		[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
		[Token(Token = "0x6000130")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000025")]
	public int Stride
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x600012F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xD938F0", Offset = "0xD92CF0", Length = "0x17")]
	[Token(Token = "0x6000128")]
	public NativeSlice`1(NativeSlice<T> slice, int start, int length) { }

	[Address(RVA = "0xD93BB0", Offset = "0xD92FB0", Length = "0x6C")]
	[Token(Token = "0x6000129")]
	public NativeSlice`1(NativeArray<T> array) { }

	[Address(RVA = "0xD93C20", Offset = "0xD93020", Length = "0x66")]
	[Token(Token = "0x600012B")]
	public NativeSlice`1(NativeArray<T> array, int start, int length) { }

	[Address(RVA = "0xD93140", Offset = "0xD92540", Length = "0x113")]
	[Token(Token = "0x600012E")]
	[WriteAccessRequired]
	public void CopyFrom(NativeSlice<T> slice) { }

	[Address(RVA = "0xD936D0", Offset = "0xD92AD0", Length = "0x1D")]
	[Token(Token = "0x6000134")]
	public override bool Equals(NativeSlice<T> other) { }

	[Address(RVA = "0xD935C0", Offset = "0xD929C0", Length = "0x100")]
	[Token(Token = "0x6000135")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xD93D70", Offset = "0xD93170", Length = "0xEA")]
	[Token(Token = "0x600012C")]
	public T get_Item(int index) { }

	[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
	[Token(Token = "0x6000130")]
	public int get_Length() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x600012F")]
	public int get_Stride() { }

	[Address(RVA = "0xD936F0", Offset = "0xD92AF0", Length = "0x74")]
	[Token(Token = "0x6000131")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xD93770", Offset = "0xD92B70", Length = "0x15")]
	[Token(Token = "0x6000136")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xD94030", Offset = "0xD93430", Length = "0xA3")]
	[Token(Token = "0x600012A")]
	public static NativeSlice<T> op_Implicit(NativeArray<T> array) { }

	[Address(RVA = "0xD94260", Offset = "0xD93660", Length = "0xC8")]
	[Token(Token = "0x600012D")]
	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	[Address(RVA = "0xD93790", Offset = "0xD92B90", Length = "0x97")]
	[Token(Token = "0x6000132")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xD93830", Offset = "0xD92C30", Length = "0xBA")]
	[Token(Token = "0x6000133")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

