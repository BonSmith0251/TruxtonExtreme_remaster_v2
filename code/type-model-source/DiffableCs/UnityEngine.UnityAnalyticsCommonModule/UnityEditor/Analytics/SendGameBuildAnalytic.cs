namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000013")]
public class SendGameBuildAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000038")]
	private int navmesh_count; //Field offset: 0x30

	[Address(RVA = "0x3478CE0", Offset = "0x34780E0", Length = "0x64")]
	[Token(Token = "0x6000021")]
	public SendGameBuildAnalytic() { }

	[Address(RVA = "0x3478C50", Offset = "0x3478050", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000022")]
	internal static SendGameBuildAnalytic CreateSendGameBuildAnalytic() { }

}

