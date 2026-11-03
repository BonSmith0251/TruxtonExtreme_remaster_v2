namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000398")]
internal struct XSystemRuntimeInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A5B")]
	internal XVersion runtimeVersion; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A5C")]
	internal XVersion availableVersion; //Field offset: 0x8

}

