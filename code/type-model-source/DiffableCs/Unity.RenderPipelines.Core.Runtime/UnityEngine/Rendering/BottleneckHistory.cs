namespace UnityEngine.Rendering;

[Token(Token = "0x20000CB")]
internal class BottleneckHistory
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000295")]
	private List<PerformanceBottleneck> m_Bottlenecks; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000296")]
	internal BottleneckHistogram Histogram; //Field offset: 0x18

	[Address(RVA = "0x2BD3E60", Offset = "0x2BD3260", Length = "0xAB")]
	[Token(Token = "0x6000772")]
	public BottleneckHistory(int initialCapacity) { }

	[Address(RVA = "0x2BD39E0", Offset = "0x2BD2DE0", Length = "0x13F")]
	[Token(Token = "0x6000774")]
	internal void AddBottleneckFromAveragedSample(FrameTimeSample frameHistorySampleAverage) { }

	[Address(RVA = "0x2BD3B20", Offset = "0x2BD2F20", Length = "0x4A")]
	[Token(Token = "0x6000777")]
	internal void Clear() { }

	[Address(RVA = "0x2BD3B70", Offset = "0x2BD2F70", Length = "0x17F")]
	[Token(Token = "0x6000775")]
	internal void ComputeHistogram() { }

	[Address(RVA = "0x2BD3CF0", Offset = "0x2BD30F0", Length = "0xC1")]
	[Token(Token = "0x6000776")]
	private static PerformanceBottleneck DetermineBottleneck(FrameTimeSample s) { }

	[Address(RVA = "0x2BD3DC0", Offset = "0x2BD31C0", Length = "0x93")]
	[Token(Token = "0x6000773")]
	internal void DiscardOldSamples(int historySize) { }

}

