namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000238")]
public enum XNetworkingConnectivityLevelHint : uint
{
	Unknown = 0,
	None = 1,
	LocalAccess = 2,
	InternetAccess = 3,
	ConstrainedInternetAccess = 4,
}

