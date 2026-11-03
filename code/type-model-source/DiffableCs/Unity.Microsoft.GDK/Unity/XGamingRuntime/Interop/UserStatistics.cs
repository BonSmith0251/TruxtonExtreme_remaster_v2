namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003B3")]
public static class UserStatistics
{

	[Address(RVA = "0x2B9FDE0", Offset = "0x2B9F1E0", Length = "0xA0")]
	[Token(Token = "0x6001274")]
	public static int XblUserStatisticsAddStatisticChangedHandler(IntPtr xblContextHandle, XblStatisticChangedHandler handler, Void* handlerContext) { }

	[Address(RVA = "0x2B9FE80", Offset = "0x2B9F280", Length = "0x85")]
	[Token(Token = "0x6001275")]
	public static void XblUserStatisticsRemoveStatisticChangedHandler(IntPtr xblContextHandle, int context) { }

	[Address(RVA = "0x2B9FF10", Offset = "0x2B9F310", Length = "0xBF")]
	[Token(Token = "0x6001277")]
	public static int XblUserStatisticsStopTrackingStatistics(IntPtr xblContextHandle, UInt64* xboxUserIds, UIntPtr xboxUserIdsCount, SByte* serviceConfigurationId, SByte** statisticNames, UIntPtr statisticNamesCount) { }

	[Address(RVA = "0x2B9FFD0", Offset = "0x2B9F3D0", Length = "0x93")]
	[Token(Token = "0x6001278")]
	public static int XblUserStatisticsStopTrackingUsers(IntPtr xblContextHandle, UInt64* xboxUserIds, UIntPtr xboxUserIdsCount) { }

	[Address(RVA = "0x2BA0070", Offset = "0x2B9F470", Length = "0xBF")]
	[Token(Token = "0x6001276")]
	public static int XblUserStatisticsTrackStatistics(IntPtr xblContextHandle, UInt64* xboxUserIds, UIntPtr xboxUserIdsCount, SByte* serviceConfigurationId, SByte** statisticNames, UIntPtr statisticNamesCount) { }

}

