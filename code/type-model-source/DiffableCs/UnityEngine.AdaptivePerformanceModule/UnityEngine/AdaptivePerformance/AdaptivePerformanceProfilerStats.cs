namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200003C")]
public static class AdaptivePerformanceProfilerStats
{
	[IsReadOnly]
	[Token(Token = "0x200003D")]
	internal struct CustomProfilerMarker
	{

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60001F1")]
		public CustomProfilerMarker`1(string name, ProfilerMarkerDataUnit dataUnit) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60001F2")]
		public void Sample(T value) { }

	}

	[Token(Token = "0x200003E")]
	internal struct ScalerInfo
	{
		[CompilerGenerated]
		[Token(Token = "0x200003F")]
		[UnsafeValueType]
		internal struct <scalerName>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400011A")]
			public byte FixedElementField; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[FixedBuffer(typeof(byte), 320)]
		[Token(Token = "0x4000113")]
		public <scalerName>e__FixedBuffer scalerName; //Field offset: 0x0
		[FieldOffset(Offset = "0x140")]
		[Token(Token = "0x4000114")]
		public uint enabled; //Field offset: 0x140
		[FieldOffset(Offset = "0x144")]
		[Token(Token = "0x4000115")]
		public int overrideLevel; //Field offset: 0x144
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x4000116")]
		public int currentLevel; //Field offset: 0x148
		[FieldOffset(Offset = "0x14C")]
		[Token(Token = "0x4000117")]
		public int maxLevel; //Field offset: 0x14C
		[FieldOffset(Offset = "0x150")]
		[Token(Token = "0x4000118")]
		public float scale; //Field offset: 0x150
		[FieldOffset(Offset = "0x154")]
		[Token(Token = "0x4000119")]
		public uint applied; //Field offset: 0x154

	}

	[Token(Token = "0x4000102")]
	public static readonly ProfilerCategory AdaptivePerformanceProfilerCategory; //Field offset: 0x0
	[Token(Token = "0x4000103")]
	public static CustomProfilerMarker<Single> CurrentCPUMarker; //Field offset: 0x2
	[Token(Token = "0x4000104")]
	public static CustomProfilerMarker<Single> AvgCPUMarker; //Field offset: 0x3
	[Token(Token = "0x4000105")]
	public static CustomProfilerMarker<Single> CurrentGPUMarker; //Field offset: 0x4
	[Token(Token = "0x4000106")]
	public static CustomProfilerMarker<Single> AvgGPUMarker; //Field offset: 0x5
	[Token(Token = "0x4000107")]
	public static CustomProfilerMarker<Int32> CurrentCPULevelMarker; //Field offset: 0x6
	[Token(Token = "0x4000108")]
	public static CustomProfilerMarker<Int32> CurrentGPULevelMarker; //Field offset: 0x7
	[Token(Token = "0x4000109")]
	public static CustomProfilerMarker<Single> CurrentFrametimeMarker; //Field offset: 0x8
	[Token(Token = "0x400010A")]
	public static CustomProfilerMarker<Single> AvgFrametimeMarker; //Field offset: 0x9
	[Token(Token = "0x400010B")]
	public static CustomProfilerMarker<Int32> WarningLevelMarker; //Field offset: 0xA
	[Token(Token = "0x400010C")]
	public static CustomProfilerMarker<Single> TemperatureLevelMarker; //Field offset: 0xB
	[Token(Token = "0x400010D")]
	public static CustomProfilerMarker<Single> TemperatureTrendMarker; //Field offset: 0xC
	[Token(Token = "0x400010E")]
	public static CustomProfilerMarker<Int32> BottleneckMarker; //Field offset: 0xD
	[Token(Token = "0x400010F")]
	public static CustomProfilerMarker<Int32> PerformanceModeMarker; //Field offset: 0xE
	[Token(Token = "0x4000110")]
	public static readonly Guid kAdaptivePerformanceProfilerModuleGuid; //Field offset: 0x10
	[Token(Token = "0x4000111")]
	public static readonly int kScalerDataTag; //Field offset: 0x20
	[Token(Token = "0x4000112")]
	private static Dictionary<String, ScalerInfo> scalerInfos; //Field offset: 0x28

	[Address(RVA = "0x2F91930", Offset = "0x2F90D30", Length = "0x44E")]
	[Token(Token = "0x60001F0")]
	private static AdaptivePerformanceProfilerStats() { }

	[Address(RVA = "0x2F91840", Offset = "0x2F90C40", Length = "0xEC")]
	[Token(Token = "0x60001EF")]
	public static void FlushScalerDataToProfilerStream() { }

}

