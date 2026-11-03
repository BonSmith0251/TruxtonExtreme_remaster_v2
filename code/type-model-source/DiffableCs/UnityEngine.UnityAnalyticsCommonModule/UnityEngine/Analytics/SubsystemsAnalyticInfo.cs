namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000005")]
public class SubsystemsAnalyticInfo : SubsystemsAnalyticBase
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000002")]
	private string id; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000003")]
	private string plugin_name; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000004")]
	private string version; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000005")]
	private string library_name; //Field offset: 0x50

	[Address(RVA = "0x3479060", Offset = "0x3478460", Length = "0x80")]
	[Token(Token = "0x6000006")]
	public SubsystemsAnalyticInfo() { }

	[Address(RVA = "0x3478FB0", Offset = "0x34783B0", Length = "0xAB")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000007")]
	internal static SubsystemsAnalyticInfo CreateSubsystemsAnalyticInfo() { }

}

