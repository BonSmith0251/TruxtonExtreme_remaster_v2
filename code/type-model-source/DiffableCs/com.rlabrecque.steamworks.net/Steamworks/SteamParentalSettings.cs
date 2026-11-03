namespace Steamworks;

[Token(Token = "0x2000020")]
public static class SteamParentalSettings
{

	[Address(RVA = "0x5FAA60", Offset = "0x5F9E60", Length = "0x4F")]
	[Token(Token = "0x600038B")]
	public static bool BIsAppBlocked(AppId_t nAppID) { }

	[Address(RVA = "0x5FAAB0", Offset = "0x5F9EB0", Length = "0x4F")]
	[Token(Token = "0x600038C")]
	public static bool BIsAppInBlockList(AppId_t nAppID) { }

	[Address(RVA = "0x5FAB00", Offset = "0x5F9F00", Length = "0x4F")]
	[Token(Token = "0x600038D")]
	public static bool BIsFeatureBlocked(EParentalFeature eFeature) { }

	[Address(RVA = "0x5FAB50", Offset = "0x5F9F50", Length = "0x4F")]
	[Token(Token = "0x600038E")]
	public static bool BIsFeatureInBlockList(EParentalFeature eFeature) { }

	[Address(RVA = "0x5FABA0", Offset = "0x5F9FA0", Length = "0x47")]
	[Token(Token = "0x6000389")]
	public static bool BIsParentalLockEnabled() { }

	[Address(RVA = "0x5FABF0", Offset = "0x5F9FF0", Length = "0x47")]
	[Token(Token = "0x600038A")]
	public static bool BIsParentalLockLocked() { }

}

