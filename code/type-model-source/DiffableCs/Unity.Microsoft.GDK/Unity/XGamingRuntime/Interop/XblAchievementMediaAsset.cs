namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002D3")]
internal struct XblAchievementMediaAsset
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007A5")]
	internal readonly UTF8StringPtr name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007A6")]
	internal readonly XblAchievementMediaAssetType mediaAssetType; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007A7")]
	internal readonly UTF8StringPtr url; //Field offset: 0x10

}

