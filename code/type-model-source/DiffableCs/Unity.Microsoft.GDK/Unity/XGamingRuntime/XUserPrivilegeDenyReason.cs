namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000297")]
public enum XUserPrivilegeDenyReason : uint
{
	None = 0,
	PurchaseRequired = 1,
	Restricted = 2,
	Banned = 3,
	Unknown = 4294967295,
}

