namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000021")]
public class FontFeatureTable
{
	[CompilerGenerated]
	[Token(Token = "0x2000022")]
	private sealed class <>c
	{
		[Token(Token = "0x40000C5")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000C6")]
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__24_0; //Field offset: 0x8
		[Token(Token = "0x40000C7")]
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__24_1; //Field offset: 0x10
		[Token(Token = "0x40000C8")]
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__25_0; //Field offset: 0x18
		[Token(Token = "0x40000C9")]
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__25_1; //Field offset: 0x20
		[Token(Token = "0x40000CA")]
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__26_0; //Field offset: 0x28
		[Token(Token = "0x40000CB")]
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__26_1; //Field offset: 0x30

		[Address(RVA = "0x31911C0", Offset = "0x31905C0", Length = "0x67")]
		[Token(Token = "0x6000061")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000062")]
		public <>c() { }

		[Address(RVA = "0x2ED97B0", Offset = "0x2ED8BB0", Length = "0x3F")]
		[Token(Token = "0x6000063")]
		internal uint <SortGlyphPairAdjustmentRecords>b__24_0(GlyphPairAdjustmentRecord s) { }

		[Address(RVA = "0x2ED97F0", Offset = "0x2ED8BF0", Length = "0x3F")]
		[Token(Token = "0x6000064")]
		internal uint <SortGlyphPairAdjustmentRecords>b__24_1(GlyphPairAdjustmentRecord s) { }

		[Address(RVA = "0x3191170", Offset = "0x3190570", Length = "0x13")]
		[Token(Token = "0x6000065")]
		internal uint <SortMarkToBaseAdjustmentRecords>b__25_0(MarkToBaseAdjustmentRecord s) { }

		[Address(RVA = "0x3191190", Offset = "0x3190590", Length = "0x13")]
		[Token(Token = "0x6000066")]
		internal uint <SortMarkToBaseAdjustmentRecords>b__25_1(MarkToBaseAdjustmentRecord s) { }

		[Address(RVA = "0x3191170", Offset = "0x3190570", Length = "0x13")]
		[Token(Token = "0x6000067")]
		internal uint <SortMarkToMarkAdjustmentRecords>b__26_0(MarkToMarkAdjustmentRecord s) { }

		[Address(RVA = "0x3191190", Offset = "0x3190590", Length = "0x13")]
		[Token(Token = "0x6000068")]
		internal uint <SortMarkToMarkAdjustmentRecords>b__26_1(MarkToMarkAdjustmentRecord s) { }

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40000BC")]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000BD")]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000BE")]
	private List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000BF")]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000C0")]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000C1")]
	internal Dictionary<UInt32, List`1<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000C2")]
	internal Dictionary<UInt32, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000C3")]
	internal Dictionary<UInt32, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000C4")]
	internal Dictionary<UInt32, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; //Field offset: 0x50

	[Token(Token = "0x1700000E")]
	internal List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600005A")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700000F")]
	internal List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords
	{
		[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
		[Token(Token = "0x600005B")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000010")]
	internal List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords
	{
		[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
		[Token(Token = "0x600005C")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x3181710", Offset = "0x3180B10", Length = "0x265")]
	[Token(Token = "0x600005D")]
	internal FontFeatureTable() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600005A")]
	internal List<GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
	[Token(Token = "0x600005B")]
	internal List<MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
	[Token(Token = "0x600005C")]
	internal List<MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	[Address(RVA = "0x3181050", Offset = "0x3180450", Length = "0x23C")]
	[Token(Token = "0x600005E")]
	public void SortGlyphPairAdjustmentRecords() { }

	[Address(RVA = "0x3181290", Offset = "0x3180690", Length = "0x23C")]
	[Token(Token = "0x600005F")]
	public void SortMarkToBaseAdjustmentRecords() { }

	[Address(RVA = "0x31814D0", Offset = "0x31808D0", Length = "0x23C")]
	[Token(Token = "0x6000060")]
	public void SortMarkToMarkAdjustmentRecords() { }

}

