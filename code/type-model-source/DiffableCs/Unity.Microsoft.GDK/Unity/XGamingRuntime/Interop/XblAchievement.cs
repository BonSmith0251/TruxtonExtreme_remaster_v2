namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002D1")]
internal struct XblAchievement
{
	[CompilerGenerated]
	[Token(Token = "0x20002D2")]
	private sealed class <>c
	{
		[Token(Token = "0x40007A3")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40007A4")]
		public static Func<UTF8StringPtr, String> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x2B9F7A0", Offset = "0x2B9EBA0", Length = "0x67")]
		[Token(Token = "0x6000FB9")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000FBA")]
		public <>c() { }

		[Address(RVA = "0x2B9F320", Offset = "0x2B9E720", Length = "0x1A")]
		[Token(Token = "0x6000FBB")]
		internal string <GetPlatformsAvailableOn>b__2_0(UTF8StringPtr s) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400078C")]
	internal readonly UTF8StringPtr id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400078D")]
	internal readonly UTF8StringPtr serviceConfigurationId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400078E")]
	internal readonly UTF8StringPtr name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400078F")]
	private readonly IntPtr titleAssociations; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000790")]
	private readonly SizeT titleAssociationsCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000791")]
	internal readonly XblAchievementProgressState progressState; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000792")]
	internal readonly XblAchievementProgression progression; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000793")]
	private readonly IntPtr mediaAssets; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000794")]
	private readonly SizeT mediaAssetsCount; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000795")]
	private readonly IntPtr platformsAvailableOn; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000796")]
	private readonly SizeT platformsAvailableOnCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000797")]
	internal readonly bool isSecret; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000798")]
	internal readonly UTF8StringPtr unlockedDescription; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000799")]
	internal readonly UTF8StringPtr lockedDescription; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400079A")]
	internal readonly UTF8StringPtr productId; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400079B")]
	internal readonly XblAchievementType type; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400079C")]
	internal readonly XblAchievementParticipationType participationType; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400079D")]
	internal readonly XblAchievementTimeWindow available; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400079E")]
	private readonly IntPtr rewards; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400079F")]
	private readonly SizeT rewardsCount; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40007A0")]
	internal readonly ulong estimatedUnlockTime; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40007A1")]
	internal readonly UTF8StringPtr deepLink; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40007A2")]
	internal readonly bool isRevoked; //Field offset: 0xC0

	[Address(RVA = "0x9E6DF0", Offset = "0x9E61F0", Length = "0x4E")]
	[Token(Token = "0x6000FB6")]
	internal T[] GetMediaAssets(Func<XblAchievementMediaAsset, T> ctor) { }

	[Address(RVA = "0x2BA62C0", Offset = "0x2BA56C0", Length = "0x122")]
	[Token(Token = "0x6000FB7")]
	internal String[] GetPlatformsAvailableOn() { }

	[Address(RVA = "0x9E6EA0", Offset = "0x9E62A0", Length = "0x54")]
	[Token(Token = "0x6000FB8")]
	internal T[] GetRewards(Func<XblAchievementReward, T> ctor) { }

	[Address(RVA = "0x9E6F60", Offset = "0x9E6360", Length = "0x4E")]
	[Token(Token = "0x6000FB5")]
	internal T[] GetTitleAssociations(Func<XblAchievementTitleAssociation, T> ctor) { }

}

