namespace TMPro;

[Token(Token = "0x200005F")]
public class TMP_FontFeatureTable
{
	[CompilerGenerated]
	[Token(Token = "0x2000060")]
	private sealed class <>c
	{
		[Token(Token = "0x400027F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000280")]
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__25_0; //Field offset: 0x8
		[Token(Token = "0x4000281")]
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__25_1; //Field offset: 0x10
		[Token(Token = "0x4000282")]
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__26_0; //Field offset: 0x18
		[Token(Token = "0x4000283")]
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__26_1; //Field offset: 0x20
		[Token(Token = "0x4000284")]
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__27_0; //Field offset: 0x28
		[Token(Token = "0x4000285")]
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__27_1; //Field offset: 0x30

		[Address(RVA = "0x2ED9960", Offset = "0x2ED8D60", Length = "0x67")]
		[Token(Token = "0x60002F6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002F7")]
		public <>c() { }

		[Address(RVA = "0x2ED97B0", Offset = "0x2ED8BB0", Length = "0x3F")]
		[Token(Token = "0x60002F8")]
		internal uint <SortGlyphPairAdjustmentRecords>b__25_0(GlyphPairAdjustmentRecord s) { }

		[Address(RVA = "0x2ED97F0", Offset = "0x2ED8BF0", Length = "0x3F")]
		[Token(Token = "0x60002F9")]
		internal uint <SortGlyphPairAdjustmentRecords>b__25_1(GlyphPairAdjustmentRecord s) { }

		[Address(RVA = "0x17D3A70", Offset = "0x17D2E70", Length = "0x3")]
		[Token(Token = "0x60002FA")]
		internal uint <SortMarkToBaseAdjustmentRecords>b__26_0(MarkToBaseAdjustmentRecord s) { }

		[Address(RVA = "0x2ED9870", Offset = "0x2ED8C70", Length = "0x4")]
		[Token(Token = "0x60002FB")]
		internal uint <SortMarkToBaseAdjustmentRecords>b__26_1(MarkToBaseAdjustmentRecord s) { }

		[Address(RVA = "0x17D3A70", Offset = "0x17D2E70", Length = "0x3")]
		[Token(Token = "0x60002FC")]
		internal uint <SortMarkToMarkAdjustmentRecords>b__27_0(MarkToMarkAdjustmentRecord s) { }

		[Address(RVA = "0x2ED9870", Offset = "0x2ED8C70", Length = "0x4")]
		[Token(Token = "0x60002FD")]
		internal uint <SortMarkToMarkAdjustmentRecords>b__27_1(MarkToMarkAdjustmentRecord s) { }

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000276")]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000277")]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000278")]
	internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000279")]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400027A")]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400027B")]
	internal Dictionary<UInt32, List`1<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400027C")]
	internal Dictionary<UInt32, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400027D")]
	internal Dictionary<UInt32, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400027E")]
	internal Dictionary<UInt32, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; //Field offset: 0x50

	[Token(Token = "0x1700008E")]
	public List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60002EC")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60002ED")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700008D")]
	public List<LigatureSubstitutionRecord> ligatureRecords
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60002EA")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60002EB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700008F")]
	public List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60002EE")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60002EF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000090")]
	public List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60002F0")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60002F1")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700008C")]
	public List<MultipleSubstitutionRecord> multipleSubstitutionRecords
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60002E8")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60002E9")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2EC7DD0", Offset = "0x2EC71D0", Length = "0x265")]
	[Token(Token = "0x60002F2")]
	public TMP_FontFeatureTable() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60002EC")]
	public List<GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60002EA")]
	public List<LigatureSubstitutionRecord> get_ligatureRecords() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60002EE")]
	public List<MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60002F0")]
	public List<MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60002E8")]
	public List<MultipleSubstitutionRecord> get_multipleSubstitutionRecords() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60002ED")]
	public void set_glyphPairAdjustmentRecords(List<GlyphPairAdjustmentRecord> value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60002EB")]
	public void set_ligatureRecords(List<LigatureSubstitutionRecord> value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60002EF")]
	public void set_MarkToBaseAdjustmentRecords(List<MarkToBaseAdjustmentRecord> value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60002F1")]
	public void set_MarkToMarkAdjustmentRecords(List<MarkToMarkAdjustmentRecord> value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60002E9")]
	public void set_multipleSubstitutionRecords(List<MultipleSubstitutionRecord> value) { }

	[Address(RVA = "0x2EC7710", Offset = "0x2EC6B10", Length = "0x23C")]
	[Token(Token = "0x60002F3")]
	public void SortGlyphPairAdjustmentRecords() { }

	[Address(RVA = "0x2EC7950", Offset = "0x2EC6D50", Length = "0x23C")]
	[Token(Token = "0x60002F4")]
	public void SortMarkToBaseAdjustmentRecords() { }

	[Address(RVA = "0x2EC7B90", Offset = "0x2EC6F90", Length = "0x23C")]
	[Token(Token = "0x60002F5")]
	public void SortMarkToMarkAdjustmentRecords() { }

}

