namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200001E")]
internal class AssetImportAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000053")]
	public string package_name; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000054")]
	public int package_import_choice; //Field offset: 0x38

	[Address(RVA = "0x34779F0", Offset = "0x3476DF0", Length = "0x64")]
	[Token(Token = "0x6000036")]
	public AssetImportAnalytic() { }

	[Address(RVA = "0x3477960", Offset = "0x3476D60", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000037")]
	public static AssetImportAnalytic CreateAssetImportAnalytic() { }

}

