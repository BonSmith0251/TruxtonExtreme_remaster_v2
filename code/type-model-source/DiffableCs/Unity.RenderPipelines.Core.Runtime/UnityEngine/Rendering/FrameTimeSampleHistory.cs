namespace UnityEngine.Rendering;

[Token(Token = "0x20000CD")]
internal class FrameTimeSampleHistory
{
	[CompilerGenerated]
	[Token(Token = "0x20000CE")]
	private sealed class <>c
	{
		[Token(Token = "0x40002A7")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x2BEB930", Offset = "0x2BEAD30", Length = "0x67")]
		[Token(Token = "0x6000780")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000781")]
		public <>c() { }

		[Address(RVA = "0x2BEA8E0", Offset = "0x2BE9CE0", Length = "0x8")]
		[Token(Token = "0x6000782")]
		internal float <.cctor>b__15_0(float value, float other) { }

		[Address(RVA = "0x2BEA8F0", Offset = "0x2BE9CF0", Length = "0x10")]
		[Token(Token = "0x6000783")]
		internal float <.cctor>b__15_1(float value, float other) { }

		[Address(RVA = "0x2BEA900", Offset = "0x2BE9D00", Length = "0xA")]
		[Token(Token = "0x6000784")]
		internal float <.cctor>b__15_2(float value, float other) { }

		[Address(RVA = "0x2BEA910", Offset = "0x2BE9D10", Length = "0x14")]
		[Token(Token = "0x6000785")]
		internal float <.cctor>b__15_3(float value, float other) { }

		[Address(RVA = "0x2BEA930", Offset = "0x2BE9D30", Length = "0xC")]
		[Token(Token = "0x6000786")]
		internal float <.cctor>b__15_4(float value, float other) { }

		[Address(RVA = "0x2BEA940", Offset = "0x2BE9D40", Length = "0x10")]
		[Token(Token = "0x6000787")]
		internal float <.cctor>b__15_5(float value, float other) { }

	}

	[Token(Token = "0x40002A1")]
	private static Func<Single, Single, Single> s_SampleValueAdd; //Field offset: 0x0
	[Token(Token = "0x40002A2")]
	private static Func<Single, Single, Single> s_SampleValueMin; //Field offset: 0x8
	[Token(Token = "0x40002A3")]
	private static Func<Single, Single, Single> s_SampleValueMax; //Field offset: 0x10
	[Token(Token = "0x40002A4")]
	private static Func<Single, Single, Single> s_SampleValueCountValid; //Field offset: 0x18
	[Token(Token = "0x40002A5")]
	private static Func<Single, Single, Single> s_SampleValueEnsureValid; //Field offset: 0x20
	[Token(Token = "0x40002A6")]
	private static Func<Single, Single, Single> s_SampleValueDivide; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400029D")]
	private List<FrameTimeSample> m_Samples; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400029E")]
	internal FrameTimeSample SampleAverage; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400029F")]
	internal FrameTimeSample SampleMin; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002A0")]
	internal FrameTimeSample SampleMax; //Field offset: 0x48

	[Address(RVA = "0x2BE4700", Offset = "0x2BE3B00", Length = "0x2E9")]
	[Token(Token = "0x600077E")]
	private static FrameTimeSampleHistory() { }

	[Address(RVA = "0x2BE49F0", Offset = "0x2BE3DF0", Length = "0xAB")]
	[Token(Token = "0x6000779")]
	public FrameTimeSampleHistory(int initialCapacity) { }

	[Address(RVA = "0x2BE4610", Offset = "0x2BE3A10", Length = "0xE1")]
	[CompilerGenerated]
	[Token(Token = "0x600077F")]
	internal static void <ComputeAggregateValues>g__ForEachSampleMember|12_0(ref FrameTimeSample aggregate, FrameTimeSample sample, Func<Single, Single, Single> func) { }

	[Address(RVA = "0x2BE3B50", Offset = "0x2BE2F50", Length = "0xC8")]
	[Token(Token = "0x600077A")]
	internal void Add(FrameTimeSample sample) { }

	[Address(RVA = "0x2BE3C20", Offset = "0x2BE3020", Length = "0x43")]
	[Token(Token = "0x600077D")]
	internal void Clear() { }

	[Address(RVA = "0x2BE3C70", Offset = "0x2BE3070", Length = "0x8F5")]
	[Token(Token = "0x600077B")]
	internal void ComputeAggregateValues() { }

	[Address(RVA = "0x2BE4570", Offset = "0x2BE3970", Length = "0x93")]
	[Token(Token = "0x600077C")]
	internal void DiscardOldSamples(int sampleHistorySize) { }

}

