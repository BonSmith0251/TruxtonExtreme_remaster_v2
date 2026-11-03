namespace UnityEngine.Timeline;

[Extension]
[Token(Token = "0x2000074")]
internal static class Extrapolation
{
	[CompilerGenerated]
	[Token(Token = "0x2000075")]
	private sealed class <>c
	{
		[Token(Token = "0x4000185")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000186")]
		public static Comparison<TimelineClip> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x2F4A7B0", Offset = "0x2F49BB0", Length = "0x67")]
		[Token(Token = "0x600034A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600034B")]
		public <>c() { }

		[Address(RVA = "0x2F3EFD0", Offset = "0x2F3E3D0", Length = "0x38")]
		[Token(Token = "0x600034C")]
		internal int <SortClipsByStartTime>b__2_0(TimelineClip clip1, TimelineClip clip2) { }

	}

	[Token(Token = "0x4000184")]
	internal static readonly double kMinExtrapolationTime; //Field offset: 0x0

	[Address(RVA = "0x2F40E80", Offset = "0x2F40280", Length = "0x75")]
	[Token(Token = "0x6000349")]
	private static Extrapolation() { }

	[Address(RVA = "0x2F40730", Offset = "0x2F3FB30", Length = "0x5E0")]
	[Extension]
	[Token(Token = "0x6000347")]
	internal static void CalculateExtrapolationTimes(TrackAsset asset) { }

	[Address(RVA = "0x2F40D20", Offset = "0x2F40120", Length = "0x150")]
	[Token(Token = "0x6000348")]
	private static TimelineClip[] SortClipsByStartTime(TimelineClip[] clips) { }

}

