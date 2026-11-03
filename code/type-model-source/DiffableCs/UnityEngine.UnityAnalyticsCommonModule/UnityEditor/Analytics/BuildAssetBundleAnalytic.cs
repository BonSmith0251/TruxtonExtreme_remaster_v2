namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200000C")]
public class BuildAssetBundleAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001F")]
	public bool success; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000020")]
	public string error; //Field offset: 0x38

	[Address(RVA = "0x3477C00", Offset = "0x3477000", Length = "0x64")]
	[Token(Token = "0x6000013")]
	public BuildAssetBundleAnalytic() { }

	[Address(RVA = "0x3477B70", Offset = "0x3476F70", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000014")]
	internal static BuildAssetBundleAnalytic CreateBuildAssetBundleAnalytic() { }

}

