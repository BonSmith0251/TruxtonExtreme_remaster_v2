namespace UnityEngine.Splines;

[Token(Token = "0x2000050")]
internal class SplinePathRef
{
	[Token(Token = "0x2000051")]
	internal class SliceRef
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x400013E")]
		public int Index; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Token(Token = "0x400013F")]
		public SplineRange Range; //Field offset: 0x14

		[Address(RVA = "0x2E75490", Offset = "0x2E74890", Length = "0x40")]
		[Token(Token = "0x60002D2")]
		public SliceRef(int splineIndex, SplineRange range) { }

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400013D")]
	public SliceRef[] Splines; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60002D0")]
	public SplinePathRef() { }

	[Address(RVA = "0x2E76A60", Offset = "0x2E75E60", Length = "0x5F")]
	[Token(Token = "0x60002D1")]
	public SplinePathRef(IEnumerable<SliceRef> slices) { }

}

