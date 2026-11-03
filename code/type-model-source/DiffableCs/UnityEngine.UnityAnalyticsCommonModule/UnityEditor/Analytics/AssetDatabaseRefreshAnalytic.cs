namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200000B")]
public class AssetDatabaseRefreshAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400000A")]
	public bool isV2; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400000B")]
	public long Imports_Imported; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400000C")]
	public long Imports_ImportedInProcess; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400000D")]
	public long Imports_ImportedOutOfProcess; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400000E")]
	public long Imports_Refresh; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400000F")]
	public long Imports_DomainReload; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000010")]
	public long CacheServer_MetadataRequested; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000011")]
	public long CacheServer_MetadataDownloaded; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000012")]
	public long CacheServer_MetadataFailedToDownload; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000013")]
	public long CacheServer_MetadataUploaded; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000014")]
	public long CacheServer_ArtifactsFailedToUpload; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000015")]
	public long CacheServer_MetadataVersionsDownloaded; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000016")]
	public long CacheServer_MetadataMatched; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000017")]
	public long CacheServer_ArtifactsDownloaded; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000018")]
	public long CacheServer_ArtifactFilesDownloaded; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000019")]
	public long CacheServer_ArtifactFilesFailedToDownload; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x400001A")]
	public long CacheServer_ArtifactsUploaded; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x400001B")]
	public long CacheServer_ArtifactFilesUploaded; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x400001C")]
	public long CacheServer_ArtifactFilesFailedToUpload; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x400001D")]
	public long CacheServer_Connects; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x400001E")]
	public long CacheServer_Disconnects; //Field offset: 0xD0

	[Address(RVA = "0x34777F0", Offset = "0x3476BF0", Length = "0x64")]
	[Token(Token = "0x6000011")]
	public AssetDatabaseRefreshAnalytic() { }

	[Address(RVA = "0x3477760", Offset = "0x3476B60", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000012")]
	internal static AssetDatabaseRefreshAnalytic CreateAssetDatabaseRefreshAnalytic() { }

}

