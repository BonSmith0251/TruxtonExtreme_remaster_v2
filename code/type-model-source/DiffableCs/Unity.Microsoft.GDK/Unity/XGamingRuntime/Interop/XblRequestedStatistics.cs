namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003B4")]
public struct XblRequestedStatistics
{
	[CompilerGenerated]
	[Token(Token = "0x20003B5")]
	[UnsafeValueType]
	internal struct <serviceConfigurationId>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A78")]
		public sbyte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(sbyte), 40)]
	[Token(Token = "0x4000A75")]
	public <serviceConfigurationId>e__FixedBuffer serviceConfigurationId; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A76")]
	public SByte** statistics; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A77")]
	public uint statisticsCount; //Field offset: 0x30

}

