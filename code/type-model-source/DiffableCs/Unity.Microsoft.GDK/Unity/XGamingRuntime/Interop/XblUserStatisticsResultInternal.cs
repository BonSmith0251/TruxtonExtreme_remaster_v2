namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200034C")]
internal struct XblUserStatisticsResultInternal
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000988")]
	internal readonly ulong xboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000989")]
	private readonly IntPtr serviceConfigStatistics; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400098A")]
	private readonly uint serviceConfigStatisticsCount; //Field offset: 0x10

	[Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", Length = "0x4D")]
	[Token(Token = "0x60011B6")]
	internal T[] GetServiceConfigStatistics(Func<XblServiceConfigurationStatisticInternal, T> ctor) { }

}

