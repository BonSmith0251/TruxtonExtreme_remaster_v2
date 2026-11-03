namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000051")]
public class BinaryCatalogInitialization : IInitializableObject
{
	[Token(Token = "0x40000E2")]
	public const int kDefaultBinaryStorageBufferCacheSize = 128; //Field offset: 0x0
	[Token(Token = "0x40000E3")]
	public const int kCatalogLocationCacheSize = 32; //Field offset: 0x0
	[Token(Token = "0x40000E4")]
	private static int s_BinaryStorageBufferCacheSize; //Field offset: 0x0
	[Token(Token = "0x40000E5")]
	private static int s_CatalogLocationCacheSize; //Field offset: 0x4

	[Token(Token = "0x17000048")]
	public static int BinaryStorageBufferCacheSize
	{
		[Address(RVA = "0x2E3C430", Offset = "0x2E3B830", Length = "0x4D")]
		[Token(Token = "0x60001D7")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000049")]
	public static int CatalogLocationCacheSize
	{
		[Address(RVA = "0x2E3C480", Offset = "0x2E3B880", Length = "0x4E")]
		[Token(Token = "0x60001D8")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x2E3C3E0", Offset = "0x2E3B7E0", Length = "0x4E")]
	[Token(Token = "0x60001DD")]
	private static BinaryCatalogInitialization() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001DC")]
	public BinaryCatalogInitialization() { }

	[Address(RVA = "0x2E3C430", Offset = "0x2E3B830", Length = "0x4D")]
	[Token(Token = "0x60001D7")]
	public static int get_BinaryStorageBufferCacheSize() { }

	[Address(RVA = "0x2E3C480", Offset = "0x2E3B880", Length = "0x4E")]
	[Token(Token = "0x60001D8")]
	public static int get_CatalogLocationCacheSize() { }

	[Address(RVA = "0x2E3C290", Offset = "0x2E3B690", Length = "0xD9")]
	[Token(Token = "0x60001DA")]
	public override bool Initialize(string id, string dataStr) { }

	[Address(RVA = "0x2E3C1E0", Offset = "0x2E3B5E0", Length = "0xA7")]
	[Token(Token = "0x60001DB")]
	public override AsyncOperationHandle<Boolean> InitializeAsync(ResourceManager resourceManager, string id, string dataStr) { }

	[Address(RVA = "0x2E3C370", Offset = "0x2E3B770", Length = "0x66")]
	[Token(Token = "0x60001D9")]
	public static void ResetToDefaults() { }

}

