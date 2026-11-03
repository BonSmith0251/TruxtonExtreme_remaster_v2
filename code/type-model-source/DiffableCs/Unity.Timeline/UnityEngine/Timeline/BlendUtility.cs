namespace UnityEngine.Timeline;

[Token(Token = "0x2000072")]
internal static class BlendUtility
{
	[CompilerGenerated]
	[Token(Token = "0x2000073")]
	private sealed class <>c
	{
		[Token(Token = "0x4000182")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000183")]
		public static Comparison<TimelineClip> <>9__1_0; //Field offset: 0x8

		[Address(RVA = "0x2F4A660", Offset = "0x2F49A60", Length = "0x67")]
		[Token(Token = "0x6000344")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000345")]
		public <>c() { }

		[Address(RVA = "0x2F4A4A0", Offset = "0x2F498A0", Length = "0x100")]
		[Token(Token = "0x6000346")]
		internal int <ComputeBlendsFromOverlaps>b__1_0(TimelineClip c1, TimelineClip c2) { }

	}


	[Address(RVA = "0x2F40220", Offset = "0x2F3F620", Length = "0x22D")]
	[Token(Token = "0x6000342")]
	public static void ComputeBlendsFromOverlaps(TimelineClip[] clips) { }

	[Address(RVA = "0x2F40450", Offset = "0x2F3F850", Length = "0x12D")]
	[Token(Token = "0x6000341")]
	private static bool Overlaps(TimelineClip blendOut, TimelineClip blendIn) { }

	[Address(RVA = "0x2F40580", Offset = "0x2F3F980", Length = "0x1A9")]
	[Token(Token = "0x6000343")]
	private static void UpdateClipIntersection(TimelineClip blendOutClip, TimelineClip blendInClip) { }

}

