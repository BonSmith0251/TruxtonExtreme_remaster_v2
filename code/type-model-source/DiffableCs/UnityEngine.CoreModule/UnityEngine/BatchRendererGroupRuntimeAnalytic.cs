namespace UnityEngine;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x20000A5")]
internal class BatchRendererGroupRuntimeAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001E3")]
	private int brgRuntimeStatus; //Field offset: 0x30

	[Address(RVA = "0x2FCEDD0", Offset = "0x2FCE1D0", Length = "0x64")]
	[Token(Token = "0x60002DB")]
	private BatchRendererGroupRuntimeAnalytic() { }

	[Address(RVA = "0x2FCED40", Offset = "0x2FCE140", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x60002DC")]
	public static BatchRendererGroupRuntimeAnalytic CreateBatchRendererGroupRuntimeAnalytic() { }

}

