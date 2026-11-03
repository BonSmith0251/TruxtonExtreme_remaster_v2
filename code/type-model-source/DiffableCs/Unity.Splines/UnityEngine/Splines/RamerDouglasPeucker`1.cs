namespace UnityEngine.Splines;

[Token(Token = "0x200001F")]
internal class RamerDouglasPeucker
{
	[Token(Token = "0x2000020")]
	private struct Range
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004F")]
		public int Start; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000050")]
		public int Count; //Field offset: 0x0

		[Token(Token = "0x17000027")]
		public int End
		{
			[Address(RVA = "0xE9A6E0", Offset = "0xE99AE0", Length = "0x8")]
			[Token(Token = "0x60000AF")]
			 get { } //Length: 8
		}

		[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
		[Token(Token = "0x60000B0")]
		public Range(int start, int count) { }

		[Address(RVA = "0xE9A6E0", Offset = "0xE99AE0", Length = "0x8")]
		[Token(Token = "0x60000AF")]
		public int get_End() { }

		[Address(RVA = "0xE9A610", Offset = "0xE99A10", Length = "0xC7")]
		[Token(Token = "0x60000B1")]
		public virtual string ToString() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004B")]
	private T m_Points; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004C")]
	private Boolean[] m_Keep; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004D")]
	private float m_Epsilon; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004E")]
	private int m_KeepCount; //Field offset: 0x0

	[Address(RVA = "0xE9A4E0", Offset = "0xE998E0", Length = "0xC5")]
	[Token(Token = "0x60000A9")]
	public RamerDouglasPeucker`1(T points) { }

	[Address(RVA = "0xE99890", Offset = "0xE98C90", Length = "0x12A")]
	[Token(Token = "0x60000AC")]
	private void Discard(Range<T> range) { }

	[Address(RVA = "0xE999C0", Offset = "0xE98DC0", Length = "0x3FF")]
	[Token(Token = "0x60000AE")]
	private ValueTuple<Int32, Single> FindFarthest(Range<T> range) { }

	[Address(RVA = "0xE99DC0", Offset = "0xE991C0", Length = "0x4B")]
	[Token(Token = "0x60000AB")]
	private void Keep(int index) { }

	[Address(RVA = "0xE99E10", Offset = "0xE99210", Length = "0x590")]
	[Token(Token = "0x60000AA")]
	public void Reduce(List<float3> results, float epsilon) { }

	[Address(RVA = "0xE9A3B0", Offset = "0xE997B0", Length = "0x130")]
	[Token(Token = "0x60000AD")]
	private void Reduce(Range<T> range) { }

}

