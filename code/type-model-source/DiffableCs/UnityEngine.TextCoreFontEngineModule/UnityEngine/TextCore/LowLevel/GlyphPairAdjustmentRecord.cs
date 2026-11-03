namespace UnityEngine.TextCore.LowLevel;

[DebuggerDisplay("First glyphIndex = {m_FirstAdjustmentRecord.m_GlyphIndex},  Second glyphIndex = {m_SecondAdjustmentRecord.m_GlyphIndex}")]
[Token(Token = "0x2000013")]
[UsedByNativeCode]
public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord>
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("firstAdjustmentRecord")]
	[SerializeField]
	[Token(Token = "0x400008A")]
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; //Field offset: 0x0
	[FieldOffset(Offset = "0x14")]
	[NativeName("secondAdjustmentRecord")]
	[SerializeField]
	[Token(Token = "0x400008B")]
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; //Field offset: 0x14
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400008C")]
	private FontFeatureLookupFlags m_FeatureLookupFlags; //Field offset: 0x28

	[Token(Token = "0x1700002C")]
	public FontFeatureLookupFlags featureLookupFlags
	{
		[Address(RVA = "0x1073730", Offset = "0x1072B30", Length = "0x6")]
		[Token(Token = "0x600009B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700002A")]
	public GlyphAdjustmentRecord firstAdjustmentRecord
	{
		[Address(RVA = "0x3171560", Offset = "0x3170960", Length = "0x10")]
		[Token(Token = "0x6000098")]
		 get { } //Length: 16
		[Address(RVA = "0x29B4FD0", Offset = "0x29B43D0", Length = "0xD")]
		[Token(Token = "0x6000099")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002B")]
	public GlyphAdjustmentRecord secondAdjustmentRecord
	{
		[Address(RVA = "0x198AFA0", Offset = "0x198A3A0", Length = "0x11")]
		[Token(Token = "0x600009A")]
		 get { } //Length: 17
	}

	[Address(RVA = "0x3171530", Offset = "0x3170930", Length = "0x23")]
	[Token(Token = "0x600009C")]
	public GlyphPairAdjustmentRecord(GlyphAdjustmentRecord firstAdjustmentRecord, GlyphAdjustmentRecord secondAdjustmentRecord) { }

	[Address(RVA = "0x3171380", Offset = "0x3170780", Length = "0x79")]
	[ExcludeFromDocs]
	[Token(Token = "0x600009E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3171400", Offset = "0x3170800", Length = "0xB9")]
	[ExcludeFromDocs]
	[Token(Token = "0x600009F")]
	public override bool Equals(GlyphPairAdjustmentRecord other) { }

	[Address(RVA = "0x1073730", Offset = "0x1072B30", Length = "0x6")]
	[Token(Token = "0x600009B")]
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	[Address(RVA = "0x3171560", Offset = "0x3170960", Length = "0x10")]
	[Token(Token = "0x6000098")]
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	[Address(RVA = "0x198AFA0", Offset = "0x198A3A0", Length = "0x11")]
	[Token(Token = "0x600009A")]
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	[Address(RVA = "0x31714C0", Offset = "0x31708C0", Length = "0x69")]
	[ExcludeFromDocs]
	[Token(Token = "0x600009D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x29B4FD0", Offset = "0x29B43D0", Length = "0xD")]
	[Token(Token = "0x6000099")]
	public void set_firstAdjustmentRecord(GlyphAdjustmentRecord value) { }

}

