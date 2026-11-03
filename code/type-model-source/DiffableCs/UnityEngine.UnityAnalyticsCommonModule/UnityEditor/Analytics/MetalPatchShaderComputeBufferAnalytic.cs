namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000010")]
public class MetalPatchShaderComputeBufferAnalytic : AnalyticsEventBase
{

	[Address(RVA = "0x3478000", Offset = "0x3477400", Length = "0x64")]
	[Token(Token = "0x600001B")]
	public MetalPatchShaderComputeBufferAnalytic() { }

	[Address(RVA = "0x3477F70", Offset = "0x3477370", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001C")]
	internal static MetalPatchShaderComputeBufferAnalytic CreateMetalPatchShaderComputeBufferAnalytic() { }

}

