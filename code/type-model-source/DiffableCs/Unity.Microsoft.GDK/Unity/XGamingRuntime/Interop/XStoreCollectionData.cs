namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000386")]
internal struct XStoreCollectionData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A08")]
	internal long acquiredDate; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A09")]
	internal long startDate; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A0A")]
	internal long endDate; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A0B")]
	internal bool isTrial; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000A0C")]
	internal uint trialTimeRemainingInSeconds; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A0D")]
	internal uint quantity; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A0E")]
	internal string campaignId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A0F")]
	internal string developerOfferId; //Field offset: 0x30

}

