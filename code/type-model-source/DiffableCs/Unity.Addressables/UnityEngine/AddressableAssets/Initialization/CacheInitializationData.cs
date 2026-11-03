namespace UnityEngine.AddressableAssets.Initialization;

[Token(Token = "0x2000061")]
public class CacheInitializationData
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("m_compressionEnabled")]
	[SerializeField]
	[Token(Token = "0x4000153")]
	private bool m_CompressionEnabled; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("m_cacheDirectoryOverride")]
	[SerializeField]
	[Token(Token = "0x4000154")]
	private string m_CacheDirectoryOverride; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_limitCacheSize")]
	[SerializeField]
	[Token(Token = "0x4000155")]
	private bool m_LimitCacheSize; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_maximumCacheSize")]
	[SerializeField]
	[Token(Token = "0x4000156")]
	private long m_MaximumCacheSize; //Field offset: 0x28

	[Token(Token = "0x17000068")]
	public string CacheDirectoryOverride
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600025B")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600025C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000067")]
	public bool CompressionEnabled
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000259")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x600025A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000069")]
	public bool LimitCacheSize
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x600025D")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x600025E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700006A")]
	public long MaximumCacheSize
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600025F")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[Token(Token = "0x6000260")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x27B6F90", Offset = "0x27B6390", Length = "0x61")]
	[Token(Token = "0x6000261")]
	public CacheInitializationData() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600025B")]
	public string get_CacheDirectoryOverride() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000259")]
	public bool get_CompressionEnabled() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x600025D")]
	public bool get_LimitCacheSize() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600025F")]
	public long get_MaximumCacheSize() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x600025C")]
	public void set_CacheDirectoryOverride(string value) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x600025A")]
	public void set_CompressionEnabled(bool value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x600025E")]
	public void set_LimitCacheSize(bool value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[Token(Token = "0x6000260")]
	public void set_MaximumCacheSize(long value) { }

}

