namespace TMPro;

[Token(Token = "0x200005D")]
public class TMP_GlyphPairAdjustmentRecord
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000270")]
	internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; //Field offset: 0x10
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000271")]
	internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; //Field offset: 0x24
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000272")]
	internal FontFeatureLookupFlags m_FeatureLookupFlags; //Field offset: 0x38

	[Token(Token = "0x1700008B")]
	public FontFeatureLookupFlags featureLookupFlags
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x60002E2")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x60002E3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000089")]
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord
	{
		[Address(RVA = "0x195BD50", Offset = "0x195B150", Length = "0x11")]
		[Token(Token = "0x60002DE")]
		 get { } //Length: 17
		[Address(RVA = "0x2EC88D0", Offset = "0x2EC7CD0", Length = "0xE")]
		[Token(Token = "0x60002DF")]
		 set { } //Length: 14
	}

	[Token(Token = "0x1700008A")]
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord
	{
		[Address(RVA = "0x2EC88B0", Offset = "0x2EC7CB0", Length = "0x11")]
		[Token(Token = "0x60002E0")]
		 get { } //Length: 17
		[Address(RVA = "0x2EC88E0", Offset = "0x2EC7CE0", Length = "0xE")]
		[Token(Token = "0x60002E1")]
		 set { } //Length: 14
	}

	[Address(RVA = "0x2EC86B0", Offset = "0x2EC7AB0", Length = "0x50")]
	[Token(Token = "0x60002E4")]
	public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	[Address(RVA = "0x2EC8700", Offset = "0x2EC7B00", Length = "0x1A2")]
	[Token(Token = "0x60002E5")]
	internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60002E2")]
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	[Address(RVA = "0x195BD50", Offset = "0x195B150", Length = "0x11")]
	[Token(Token = "0x60002DE")]
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	[Address(RVA = "0x2EC88B0", Offset = "0x2EC7CB0", Length = "0x11")]
	[Token(Token = "0x60002E0")]
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x60002E3")]
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	[Address(RVA = "0x2EC88D0", Offset = "0x2EC7CD0", Length = "0xE")]
	[Token(Token = "0x60002DF")]
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	[Address(RVA = "0x2EC88E0", Offset = "0x2EC7CE0", Length = "0xE")]
	[Token(Token = "0x60002E1")]
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

}

