namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000012")]
public class ProjectSettingsInformationAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000036")]
	private int agent_types_count; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000037")]
	private int areas_count; //Field offset: 0x34

	[Address(RVA = "0x3478BE0", Offset = "0x3477FE0", Length = "0x64")]
	[Token(Token = "0x600001F")]
	public ProjectSettingsInformationAnalytic() { }

	[Address(RVA = "0x3478B50", Offset = "0x3477F50", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000020")]
	internal static ProjectSettingsInformationAnalytic CreateProjectSettingsInformationAnalytic() { }

}

