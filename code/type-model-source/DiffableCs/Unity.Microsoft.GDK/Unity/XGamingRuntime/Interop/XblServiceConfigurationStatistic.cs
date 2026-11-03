namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003B6")]
public struct XblServiceConfigurationStatistic
{
	[CompilerGenerated]
	[Token(Token = "0x20003B7")]
	[UnsafeValueType]
	internal struct <serviceConfigurationId>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A7C")]
		public sbyte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(sbyte), 40)]
	[Token(Token = "0x4000A79")]
	public <serviceConfigurationId>e__FixedBuffer serviceConfigurationId; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A7A")]
	public XblStatistic* statistics; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A7B")]
	public uint statisticsCount; //Field offset: 0x30

}

