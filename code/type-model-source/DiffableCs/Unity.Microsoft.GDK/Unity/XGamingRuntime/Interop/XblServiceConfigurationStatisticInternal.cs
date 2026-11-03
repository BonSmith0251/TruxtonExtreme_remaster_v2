namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000349")]
internal struct XblServiceConfigurationStatisticInternal
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400097F")]
	internal readonly Byte[] serviceConfigurationId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000980")]
	private readonly IntPtr statistics; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000981")]
	private readonly uint statisticsCount; //Field offset: 0x10

	[Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", Length = "0x4D")]
	[Token(Token = "0x60011B5")]
	internal T[] GetStatistics(Func<XblStatisticInternal, T> ctor) { }

}

