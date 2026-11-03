namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000048")]
public class AssetBundleRequestOptions : ILocationSizeData
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("m_hash")]
	[SerializeField]
	[Token(Token = "0x40000B2")]
	private string m_Hash; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("m_crc")]
	[SerializeField]
	[Token(Token = "0x40000B3")]
	private uint m_Crc; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[FormerlySerializedAs("m_timeout")]
	[SerializeField]
	[Token(Token = "0x40000B4")]
	private int m_Timeout; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_chunkedTransfer")]
	[SerializeField]
	[Token(Token = "0x40000B5")]
	private bool m_ChunkedTransfer; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("m_redirectLimit")]
	[SerializeField]
	[Token(Token = "0x40000B6")]
	private int m_RedirectLimit; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_retryCount")]
	[SerializeField]
	[Token(Token = "0x40000B7")]
	private int m_RetryCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000B8")]
	private string m_BundleName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40000B9")]
	private AssetLoadMode m_AssetLoadMode; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000BA")]
	private long m_BundleSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40000BB")]
	private bool m_UseCrcForCachedBundles; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[SerializeField]
	[Token(Token = "0x40000BC")]
	private bool m_UseUWRForLocalBundles; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[SerializeField]
	[Token(Token = "0x40000BD")]
	private bool m_ClearOtherCachedVersionsWhenLoaded; //Field offset: 0x4A

	[Token(Token = "0x1700003E")]
	public AssetLoadMode AssetLoadMode
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000198")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x6000199")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700003D")]
	public string BundleName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000196")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000197")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700003F")]
	public long BundleSize
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600019A")]
		 get { } //Length: 5
		[Address(RVA = "0x1116970", Offset = "0x1115D70", Length = "0x5")]
		[Token(Token = "0x600019B")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700003A")]
	public bool ChunkedTransfer
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6000190")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x6000191")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000042")]
	public bool ClearOtherCachedVersionsWhenLoaded
	{
		[Address(RVA = "0x24F8BD0", Offset = "0x24F7FD0", Length = "0x5")]
		[Token(Token = "0x60001A0")]
		 get { } //Length: 5
		[Address(RVA = "0x1D6E990", Offset = "0x1D6DD90", Length = "0x4")]
		[Token(Token = "0x60001A1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000038")]
	public uint Crc
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600018C")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x600018D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000037")]
	public string Hash
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600018A")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x600018B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700003B")]
	public int RedirectLimit
	{
		[Address(RVA = "0x2E37630", Offset = "0x2E36A30", Length = "0x12")]
		[Token(Token = "0x6000192")]
		 get { } //Length: 18
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x6000193")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700003C")]
	public int RetryCount
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000194")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x6000195")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000039")]
	public int Timeout
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x600018E")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x600018F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000040")]
	public bool UseCrcForCachedBundle
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[Token(Token = "0x600019C")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
		[Token(Token = "0x600019D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000041")]
	public bool UseUnityWebRequestForLocalBundles
	{
		[Address(RVA = "0x24F8BE0", Offset = "0x24F7FE0", Length = "0x5")]
		[Token(Token = "0x600019E")]
		 get { } //Length: 5
		[Address(RVA = "0x2E37650", Offset = "0x2E36A50", Length = "0x4")]
		[Token(Token = "0x600019F")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2E375D0", Offset = "0x2E369D0", Length = "0x56")]
	[Token(Token = "0x60001A3")]
	public AssetBundleRequestOptions() { }

	[Address(RVA = "0x2E37430", Offset = "0x2E36830", Length = "0x194")]
	[Token(Token = "0x60001A2")]
	public override long ComputeSize(IResourceLocation location, ResourceManager resourceManager) { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000198")]
	public AssetLoadMode get_AssetLoadMode() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000196")]
	public string get_BundleName() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600019A")]
	public long get_BundleSize() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6000190")]
	public bool get_ChunkedTransfer() { }

	[Address(RVA = "0x24F8BD0", Offset = "0x24F7FD0", Length = "0x5")]
	[Token(Token = "0x60001A0")]
	public bool get_ClearOtherCachedVersionsWhenLoaded() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600018C")]
	public uint get_Crc() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600018A")]
	public string get_Hash() { }

	[Address(RVA = "0x2E37630", Offset = "0x2E36A30", Length = "0x12")]
	[Token(Token = "0x6000192")]
	public int get_RedirectLimit() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000194")]
	public int get_RetryCount() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x600018E")]
	public int get_Timeout() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[Token(Token = "0x600019C")]
	public bool get_UseCrcForCachedBundle() { }

	[Address(RVA = "0x24F8BE0", Offset = "0x24F7FE0", Length = "0x5")]
	[Token(Token = "0x600019E")]
	public bool get_UseUnityWebRequestForLocalBundles() { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x6000199")]
	public void set_AssetLoadMode(AssetLoadMode value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000197")]
	public void set_BundleName(string value) { }

	[Address(RVA = "0x1116970", Offset = "0x1115D70", Length = "0x5")]
	[Token(Token = "0x600019B")]
	public void set_BundleSize(long value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x6000191")]
	public void set_ChunkedTransfer(bool value) { }

	[Address(RVA = "0x1D6E990", Offset = "0x1D6DD90", Length = "0x4")]
	[Token(Token = "0x60001A1")]
	public void set_ClearOtherCachedVersionsWhenLoaded(bool value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x600018D")]
	public void set_Crc(uint value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x600018B")]
	public void set_Hash(string value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x6000193")]
	public void set_RedirectLimit(int value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x6000195")]
	public void set_RetryCount(int value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x600018F")]
	public void set_Timeout(int value) { }

	[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
	[Token(Token = "0x600019D")]
	public void set_UseCrcForCachedBundle(bool value) { }

	[Address(RVA = "0x2E37650", Offset = "0x2E36A50", Length = "0x4")]
	[Token(Token = "0x600019F")]
	public void set_UseUnityWebRequestForLocalBundles(bool value) { }

}

