namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003BA")]
public struct XblStatisticChangeEventArgs
{
	[CompilerGenerated]
	[Token(Token = "0x20003BB")]
	[UnsafeValueType]
	internal struct <serviceConfigurationId>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A83")]
		public sbyte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A80")]
	public ulong xboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[FixedBuffer(typeof(sbyte), 40)]
	[Token(Token = "0x4000A81")]
	public <serviceConfigurationId>e__FixedBuffer serviceConfigurationId; //Field offset: 0x8
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A82")]
	public XblStatistic latestStatistic; //Field offset: 0x30

}

