namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002D8")]
internal struct XblAchievementReward
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007B3")]
	internal readonly UTF8StringPtr name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007B4")]
	internal readonly UTF8StringPtr description; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007B5")]
	internal readonly UTF8StringPtr value; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007B6")]
	internal readonly XblAchievementRewardType rewardType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007B7")]
	internal readonly UTF8StringPtr valueType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007B8")]
	private readonly IntPtr mediaAsset; //Field offset: 0x28

	[Address(RVA = "0x9E6D40", Offset = "0x9E6140", Length = "0x4A")]
	[Token(Token = "0x6000FBD")]
	internal T GetMediaAsset(Func<XblAchievementMediaAsset, T> ctor) { }

}

