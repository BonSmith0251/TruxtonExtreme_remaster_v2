namespace UnityEngine.Splines;

[Token(Token = "0x2000017")]
public sealed class KnotLinkCollection
{
	[DefaultMember("Item")]
	[Token(Token = "0x2000018")]
	private sealed class KnotLink : IReadOnlyList<SplineKnotIndex>, IEnumerable<SplineKnotIndex>, IEnumerable, IReadOnlyCollection<SplineKnotIndex>
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400003A")]
		public SplineKnotIndex[] Knots; //Field offset: 0x10

		[Token(Token = "0x1700001E")]
		public override int Count
		{
			[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
			[Token(Token = "0x6000088")]
			 get { } //Length: 26
		}

		[Token(Token = "0x1700001F")]
		public override SplineKnotIndex Item
		{
			[Address(RVA = "0x2583D50", Offset = "0x2583150", Length = "0x2B")]
			[Token(Token = "0x6000089")]
			 get { } //Length: 43
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600008A")]
		public KnotLink() { }

		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6000088")]
		public override int get_Count() { }

		[Address(RVA = "0x2583D50", Offset = "0x2583150", Length = "0x2B")]
		[Token(Token = "0x6000089")]
		public override SplineKnotIndex get_Item(int index) { }

		[Address(RVA = "0x2E5B430", Offset = "0x2E5A830", Length = "0x46")]
		[Token(Token = "0x6000086")]
		public override IEnumerator<SplineKnotIndex> GetEnumerator() { }

		[Address(RVA = "0x2E5B480", Offset = "0x2E5A880", Length = "0x1D")]
		[Token(Token = "0x6000087")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000039")]
	private KnotLink[] m_KnotsLink; //Field offset: 0x10

	[Token(Token = "0x1700001D")]
	public int Count
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6000075")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x2E5B3D0", Offset = "0x2E5A7D0", Length = "0x52")]
	[Token(Token = "0x6000085")]
	public KnotLinkCollection() { }

	[Address(RVA = "0x2E5A580", Offset = "0x2E59980", Length = "0x48")]
	[Token(Token = "0x6000079")]
	public void Clear() { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x6000075")]
	public int get_Count() { }

	[Address(RVA = "0x2E5A690", Offset = "0x2E59A90", Length = "0xD2")]
	[Token(Token = "0x6000078")]
	public IReadOnlyList<SplineKnotIndex> GetKnotLinks(SplineKnotIndex knotIndex) { }

	[Address(RVA = "0x2E5A5D0", Offset = "0x2E599D0", Length = "0xB2")]
	[Token(Token = "0x6000076")]
	private KnotLink GetKnotLinksInternal(SplineKnotIndex index) { }

	[Address(RVA = "0x2E5A770", Offset = "0x2E59B70", Length = "0xD1")]
	[Token(Token = "0x600007E")]
	public void KnotIndexChanged(int splineIndex, int previousKnotIndex, int newKnotIndex) { }

	[Address(RVA = "0x2E5A850", Offset = "0x2E59C50", Length = "0x90")]
	[Token(Token = "0x600007F")]
	public void KnotIndexChanged(SplineKnotIndex previousIndex, SplineKnotIndex newIndex) { }

	[Address(RVA = "0x2E5A8E0", Offset = "0x2E59CE0", Length = "0x3B")]
	[Token(Token = "0x6000082")]
	public void KnotInserted(int splineIndex, int knotIndex) { }

	[Address(RVA = "0x2E5A920", Offset = "0x2E59D20", Length = "0xE")]
	[Token(Token = "0x6000083")]
	public void KnotInserted(SplineKnotIndex index) { }

	[Address(RVA = "0x2E5A930", Offset = "0x2E59D30", Length = "0x35")]
	[Token(Token = "0x6000080")]
	public void KnotRemoved(int splineIndex, int knotIndex) { }

	[Address(RVA = "0x2E5A970", Offset = "0x2E59D70", Length = "0xD5")]
	[Token(Token = "0x6000081")]
	public void KnotRemoved(SplineKnotIndex index) { }

	[Address(RVA = "0x2E5AA50", Offset = "0x2E59E50", Length = "0x2D2")]
	[Token(Token = "0x600007A")]
	public void Link(SplineKnotIndex knotA, SplineKnotIndex knotB) { }

	[Address(RVA = "0x2E5AD30", Offset = "0x2E5A130", Length = "0x126")]
	[Token(Token = "0x6000084")]
	public void ShiftKnotIndices(SplineKnotIndex index, int offset) { }

	[Address(RVA = "0x2E5AE60", Offset = "0x2E5A260", Length = "0x1E2")]
	[Token(Token = "0x600007D")]
	public void SplineIndexChanged(int previousIndex, int newIndex) { }

	[Address(RVA = "0x2E5B050", Offset = "0x2E5A450", Length = "0x275")]
	[Token(Token = "0x600007C")]
	public void SplineRemoved(int splineIndex) { }

	[Address(RVA = "0x2E5B2D0", Offset = "0x2E5A6D0", Length = "0x2C")]
	[Token(Token = "0x6000077")]
	public bool TryGetKnotLinks(SplineKnotIndex knotIndex, out IReadOnlyList<SplineKnotIndex>& linkedKnots) { }

	[Address(RVA = "0x2E5B300", Offset = "0x2E5A700", Length = "0xC2")]
	[Token(Token = "0x600007B")]
	public void Unlink(SplineKnotIndex knot) { }

}

