namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000348")]
internal struct XblRequestedStatisticsInternal
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400097C")]
	internal readonly Byte[] serviceConfigurationId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400097D")]
	private readonly IntPtr statistics; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400097E")]
	private readonly uint statisticsCount; //Field offset: 0x10

	[Address(RVA = "0x2BB8030", Offset = "0x2BB7430", Length = "0x265")]
	[Token(Token = "0x60011B3")]
	internal XblRequestedStatisticsInternal(XblRequestedStatistics requestedStatistics, DisposableCollection disposableCollection) { }

	[Address(RVA = "0x2BB5950", Offset = "0x2BB4D50", Length = "0x9A")]
	[Token(Token = "0x60011B4")]
	internal static bool ValidateFields(string scid) { }

}

