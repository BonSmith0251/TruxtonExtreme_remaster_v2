namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200001D")]
internal class AssetImportStatusAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000049")]
	public string package_name; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400004A")]
	public int package_items_count; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400004B")]
	public int package_import_status; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400004C")]
	public string error_message; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400004D")]
	public int project_assets_count; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400004E")]
	public int unselected_assets_count; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400004F")]
	public int selected_new_assets_count; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000050")]
	public int selected_changed_assets_count; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000051")]
	public int unchanged_assets_count; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000052")]
	public String[] selected_asset_extensions; //Field offset: 0x60

	[Address(RVA = "0x3477B00", Offset = "0x3476F00", Length = "0x67")]
	[Token(Token = "0x6000034")]
	public AssetImportStatusAnalytic() { }

	[Address(RVA = "0x3477A60", Offset = "0x3476E60", Length = "0x92")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000035")]
	public static AssetImportStatusAnalytic CreateAssetImportStatusAnalytic() { }

}

