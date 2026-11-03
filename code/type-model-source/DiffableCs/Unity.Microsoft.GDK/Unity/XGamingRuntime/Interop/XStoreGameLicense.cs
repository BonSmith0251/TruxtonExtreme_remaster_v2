namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200038F")]
internal struct XStoreGameLicense
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A47")]
	internal string skuStoreId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A48")]
	internal bool isActive; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000A49")]
	internal bool isTrialOwnedByThisUser; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x4000A4A")]
	internal bool isDiscLicense; //Field offset: 0xA
	[FieldOffset(Offset = "0xB")]
	[Token(Token = "0x4000A4B")]
	internal bool isTrial; //Field offset: 0xB
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000A4C")]
	internal uint trialTimeRemainingInSeconds; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A4D")]
	internal string trialUniqueId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A4E")]
	internal long expirationDate; //Field offset: 0x18

}

