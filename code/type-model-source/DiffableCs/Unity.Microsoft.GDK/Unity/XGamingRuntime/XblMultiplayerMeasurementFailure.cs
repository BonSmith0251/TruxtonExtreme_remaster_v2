namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000196")]
public enum XblMultiplayerMeasurementFailure : uint
{
	Unknown = 0,
	None = 1,
	Timeout = 2,
	Latency = 3,
	BandwidthUp = 4,
	BandwidthDown = 5,
	Group = 6,
	Network = 7,
	Episode = 8,
}

