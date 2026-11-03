namespace TMPro;

[Token(Token = "0x2000053")]
public class KerningTable
{
	[CompilerGenerated]
	[Token(Token = "0x2000054")]
	private sealed class <>c
	{
		[Token(Token = "0x400025A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400025B")]
		public static Func<KerningPair, UInt32> <>9__7_0; //Field offset: 0x8
		[Token(Token = "0x400025C")]
		public static Func<KerningPair, UInt32> <>9__7_1; //Field offset: 0x10

		[Address(RVA = "0x2ED99D0", Offset = "0x2ED8DD0", Length = "0x67")]
		[Token(Token = "0x60002B2")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002B3")]
		public <>c() { }

		[Address(RVA = "0x1D47750", Offset = "0x1D46B50", Length = "0x16")]
		[Token(Token = "0x60002B4")]
		internal uint <SortKerningPairs>b__7_0(KerningPair s) { }

		[Address(RVA = "0x2ED9850", Offset = "0x2ED8C50", Length = "0x16")]
		[Token(Token = "0x60002B5")]
		internal uint <SortKerningPairs>b__7_1(KerningPair s) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000055")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400025D")]
		public uint first; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400025E")]
		public uint second; //Field offset: 0x14

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002B6")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x2ED9880", Offset = "0x2ED8C80", Length = "0x2B")]
		[Token(Token = "0x60002B7")]
		internal bool <AddKerningPair>b__0(KerningPair item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000056")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400025F")]
		public uint first; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000260")]
		public uint second; //Field offset: 0x14

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002B8")]
		public <>c__DisplayClass4_0() { }

		[Address(RVA = "0x2ED9880", Offset = "0x2ED8C80", Length = "0x2B")]
		[Token(Token = "0x60002B9")]
		internal bool <AddGlyphPairAdjustmentRecord>b__0(KerningPair item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000057")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000261")]
		public int left; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000262")]
		public int right; //Field offset: 0x14

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002BA")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x2ED98B0", Offset = "0x2ED8CB0", Length = "0x36")]
		[Token(Token = "0x60002BB")]
		internal bool <RemoveKerningPair>b__0(KerningPair item) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000259")]
	public List<KerningPair> kerningPairs; //Field offset: 0x10

	[Address(RVA = "0x2EC60B0", Offset = "0x2EC54B0", Length = "0x77")]
	[Token(Token = "0x60002AB")]
	public KerningTable() { }

	[Address(RVA = "0x2EC58E0", Offset = "0x2EC4CE0", Length = "0x16A")]
	[Token(Token = "0x60002AE")]
	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	[Address(RVA = "0x2EC5BB0", Offset = "0x2EC4FB0", Length = "0x14F")]
	[Token(Token = "0x60002AC")]
	public void AddKerningPair() { }

	[Address(RVA = "0x2EC5A50", Offset = "0x2EC4E50", Length = "0x155")]
	[Token(Token = "0x60002AD")]
	public int AddKerningPair(uint first, uint second, float offset) { }

	[Address(RVA = "0x2EC5D00", Offset = "0x2EC5100", Length = "0x101")]
	[Token(Token = "0x60002AF")]
	public void RemoveKerningPair(int left, int right) { }

	[Address(RVA = "0x2EC5E10", Offset = "0x2EC5210", Length = "0x51")]
	[Token(Token = "0x60002B0")]
	public void RemoveKerningPair(int index) { }

	[Address(RVA = "0x2EC5E70", Offset = "0x2EC5270", Length = "0x23C")]
	[Token(Token = "0x60002B1")]
	public void SortKerningPairs() { }

}

