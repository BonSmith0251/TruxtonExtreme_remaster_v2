namespace KANAI.Kernel;

[Token(Token = "0x2000038")]
public class TimeUtility
{
	[Token(Token = "0x40000E5")]
	private static DateTime baseTime; //Field offset: 0x0
	[Token(Token = "0x40000E6")]
	private static Regex checkFormat; //Field offset: 0x8
	[Token(Token = "0x40000E7")]
	private static Regex checkW3cDTF; //Field offset: 0x10
	[Token(Token = "0x40000E8")]
	private static DateTime _startupTimeBySetServer; //Field offset: 0x18
	[Token(Token = "0x40000E9")]
	private static DateTime _serverTime; //Field offset: 0x20

	[Address(RVA = "0x1DF3260", Offset = "0x1DF2660", Length = "0x187")]
	[Token(Token = "0x60001D6")]
	private static TimeUtility() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001D5")]
	public TimeUtility() { }

	[Address(RVA = "0x1DF29A0", Offset = "0x1DF1DA0", Length = "0x9F")]
	[Token(Token = "0x60001D4")]
	public static string DeltaToString(float v) { }

	[Address(RVA = "0x1DF2A40", Offset = "0x1DF1E40", Length = "0x1E5")]
	[Token(Token = "0x60001CD")]
	public static DateTime GetDateTime(string iJsonValue, bool isLocalTime = false, Nullable<DateTime> defaultTime = null) { }

	[Address(RVA = "0x1DF2C30", Offset = "0x1DF2030", Length = "0x97")]
	[Token(Token = "0x60001CE")]
	public static string GetJsonTime(DateTime iTime) { }

	[Address(RVA = "0x1DF2CD0", Offset = "0x1DF20D0", Length = "0x225")]
	[Token(Token = "0x60001D0")]
	public static DateTime GetNowTime(bool isLocalTime = false) { }

	[Address(RVA = "0x1DF2F00", Offset = "0x1DF2300", Length = "0xFA")]
	[Token(Token = "0x60001CF")]
	public static string GetW3cDTF(DateTime iTime) { }

	[Address(RVA = "0x1DF3000", Offset = "0x1DF2400", Length = "0x66")]
	[Token(Token = "0x60001CC")]
	public static DateTime JsonTime2DateTime(string iJsonValue, Nullable<DateTime> defaultTime = null) { }

	[Address(RVA = "0x1DF3070", Offset = "0x1DF2470", Length = "0xD9")]
	[Token(Token = "0x60001D3")]
	public static string MilliToString(float v) { }

	[Address(RVA = "0x1DF3150", Offset = "0x1DF2550", Length = "0xBD")]
	[Token(Token = "0x60001D2")]
	public static void SetServerTime(DateTime iTime) { }

	[Address(RVA = "0x1DF3210", Offset = "0x1DF2610", Length = "0x4B")]
	[Token(Token = "0x60001D1")]
	public static DateTime ToLocalTime(DateTime iTime) { }

}

