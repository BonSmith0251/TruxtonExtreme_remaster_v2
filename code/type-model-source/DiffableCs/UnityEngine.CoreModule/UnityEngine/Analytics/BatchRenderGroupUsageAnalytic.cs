namespace UnityEngine.Analytics;

[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000333")]
internal class BatchRenderGroupUsageAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000859")]
	public int maxBRGInstance; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400085A")]
	public int maxMeshCount; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400085B")]
	public int maxMaterialCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400085C")]
	public int maxDrawCommandBatch; //Field offset: 0x3C

	[Address(RVA = "0x30781A0", Offset = "0x30775A0", Length = "0x8F")]
	[Token(Token = "0x60019DF")]
	public BatchRenderGroupUsageAnalytic() { }

	[Address(RVA = "0x30780E0", Offset = "0x30774E0", Length = "0xBB")]
	[RequiredByNativeCode]
	[Token(Token = "0x60019E0")]
	public static BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic() { }

}

