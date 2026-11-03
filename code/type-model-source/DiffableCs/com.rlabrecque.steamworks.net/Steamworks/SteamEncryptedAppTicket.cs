namespace Steamworks;

[Token(Token = "0x20001B2")]
public static class SteamEncryptedAppTicket
{

	[Address(RVA = "0x638030", Offset = "0x637430", Length = "0xE1")]
	[Token(Token = "0x600098A")]
	public static bool BDecryptTicket(Byte[] rgubTicketEncrypted, uint cubTicketEncrypted, Byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, Byte[] rgubKey, int cubKey) { }

	[Address(RVA = "0x638260", Offset = "0x637660", Length = "0xA0")]
	[Token(Token = "0x600098B")]
	public static bool BIsTicketForApp(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	[Address(RVA = "0x638300", Offset = "0x637700", Length = "0xB7")]
	[Token(Token = "0x6000992")]
	public static bool BIsTicketSigned(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, Byte[] pubRSAKey, uint cubRSAKey) { }

	[Address(RVA = "0x6383C0", Offset = "0x6377C0", Length = "0x94")]
	[Token(Token = "0x6000990")]
	public static bool BUserIsVacBanned(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	[Address(RVA = "0x638460", Offset = "0x637860", Length = "0xA0")]
	[Token(Token = "0x600098F")]
	public static bool BUserOwnsAppInTicket(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	[Address(RVA = "0x638500", Offset = "0x637900", Length = "0x8F")]
	[Token(Token = "0x600098E")]
	public static uint GetTicketAppID(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	[Address(RVA = "0x638590", Offset = "0x637990", Length = "0x8F")]
	[Token(Token = "0x600098C")]
	public static uint GetTicketIssueTime(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	[Address(RVA = "0x638620", Offset = "0x637A20", Length = "0x9B")]
	[Token(Token = "0x600098D")]
	public static void GetTicketSteamID(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID) { }

	[Address(RVA = "0x63AEF0", Offset = "0x63A2F0", Length = "0x117")]
	[Token(Token = "0x6000991")]
	public static Byte[] GetUserVariableData(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData) { }

}

