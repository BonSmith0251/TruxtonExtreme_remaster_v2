namespace UnityEngine.Timeline;

[Token(Token = "0x200007B")]
internal static class TimelineCreateUtilities
{
	[CompilerGenerated]
	[Token(Token = "0x200007C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000188")]
		public string name; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600036F")]
		public <>c__DisplayClass0_0() { }

		[Address(RVA = "0x2F4A620", Offset = "0x2F49A20", Length = "0x35")]
		[Token(Token = "0x6000370")]
		internal bool <GenerateUniqueActorName>b__0(ScriptableObject x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007D")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000189")]
		public string result; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000371")]
		public <>c__DisplayClass0_1() { }

		[Address(RVA = "0x2F4A620", Offset = "0x2F49A20", Length = "0x35")]
		[Token(Token = "0x6000372")]
		internal bool <GenerateUniqueActorName>b__1(ScriptableObject x) { }

	}


	[Address(RVA = "0x2F46BF0", Offset = "0x2F45FF0", Length = "0x1C5")]
	[Token(Token = "0x600036D")]
	public static AnimationClip CreateAnimationClipForTrack(string name, TrackAsset track, bool isLegacy) { }

	[Address(RVA = "0x2F46DC0", Offset = "0x2F461C0", Length = "0x2CA")]
	[Token(Token = "0x600036A")]
	public static string GenerateUniqueActorName(List<ScriptableObject> tracks, string name) { }

	[Address(RVA = "0x2F47090", Offset = "0x2F46490", Length = "0x7F")]
	[Token(Token = "0x600036C")]
	public static void RemoveAssetFromObject(object childAsset, object masterAsset) { }

	[Address(RVA = "0x2F47110", Offset = "0x2F46510", Length = "0xC7")]
	[Token(Token = "0x600036B")]
	public static void SaveAssetIntoObject(object childAsset, object masterAsset) { }

	[Address(RVA = "0x2F471E0", Offset = "0x2F465E0", Length = "0x332")]
	[Token(Token = "0x600036E")]
	public static bool ValidateParentTrack(TrackAsset parent, Type childType) { }

}

