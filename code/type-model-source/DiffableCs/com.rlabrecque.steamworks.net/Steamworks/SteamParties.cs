namespace Steamworks;

[Token(Token = "0x2000019")]
public static class SteamParties
{

	[Address(RVA = "0x5FAC40", Offset = "0x5FA040", Length = "0x60")]
	[Token(Token = "0x60002F6")]
	public static void CancelReservation(PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	[Address(RVA = "0x5FACA0", Offset = "0x5FA0A0", Length = "0x9D")]
	[Token(Token = "0x60002F7")]
	public static SteamAPICall_t ChangeNumOpenSlots(PartyBeaconID_t ulBeacon, uint unOpenSlots) { }

	[Address(RVA = "0x5FAD40", Offset = "0x5FA140", Length = "0x209")]
	[Token(Token = "0x60002F4")]
	public static SteamAPICall_t CreateBeacon(uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata) { }

	[Address(RVA = "0x5FAF50", Offset = "0x5FA350", Length = "0x51")]
	[Token(Token = "0x60002F8")]
	public static bool DestroyBeacon(PartyBeaconID_t ulBeacon) { }

	[Address(RVA = "0x5FAFB0", Offset = "0x5FA3B0", Length = "0x5F")]
	[Token(Token = "0x60002F3")]
	public static bool GetAvailableBeaconLocations(SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations) { }

	[Address(RVA = "0x5FB010", Offset = "0x5FA410", Length = "0x8D")]
	[Token(Token = "0x60002EF")]
	public static PartyBeaconID_t GetBeaconByIndex(uint unIndex) { }

	[Address(RVA = "0x5FB0A0", Offset = "0x5FA4A0", Length = "0x127")]
	[Token(Token = "0x60002F0")]
	public static bool GetBeaconDetails(PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, out string pchMetadata, int cchMetadata) { }

	[Address(RVA = "0x5FB1D0", Offset = "0x5FA5D0", Length = "0x11E")]
	[Token(Token = "0x60002F9")]
	public static bool GetBeaconLocationData(SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, out string pchDataStringOut, int cchDataStringOut) { }

	[Address(RVA = "0x5FB2F0", Offset = "0x5FA6F0", Length = "0x47")]
	[Token(Token = "0x60002EE")]
	public static uint GetNumActiveBeacons() { }

	[Address(RVA = "0x5FB340", Offset = "0x5FA740", Length = "0x51")]
	[Token(Token = "0x60002F2")]
	public static bool GetNumAvailableBeaconLocations(out uint puNumLocations) { }

	[Address(RVA = "0x5FB3A0", Offset = "0x5FA7A0", Length = "0x8F")]
	[Token(Token = "0x60002F1")]
	public static SteamAPICall_t JoinParty(PartyBeaconID_t ulBeaconID) { }

	[Address(RVA = "0x5FB430", Offset = "0x5FA830", Length = "0x60")]
	[Token(Token = "0x60002F5")]
	public static void OnReservationCompleted(PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

}

