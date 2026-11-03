namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200001F")]
internal class AssetExportAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000055")]
	public string package_name; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000056")]
	public string error_message; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000057")]
	public int items_count; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000058")]
	public String[] asset_extensions; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000059")]
	public bool include_upm_dependencies; //Field offset: 0x50

	[Address(RVA = "0x34778F0", Offset = "0x3476CF0", Length = "0x64")]
	[Token(Token = "0x6000038")]
	public AssetExportAnalytic() { }

	[Address(RVA = "0x3477860", Offset = "0x3476C60", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000039")]
	public static AssetExportAnalytic CreateAssetExportAnalytic() { }

}

