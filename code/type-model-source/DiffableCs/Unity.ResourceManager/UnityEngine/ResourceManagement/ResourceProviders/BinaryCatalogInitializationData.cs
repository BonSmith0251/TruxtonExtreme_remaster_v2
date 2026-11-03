namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000052")]
internal class BinaryCatalogInitializationData
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40000E6")]
	public int m_BinaryStorageBufferCacheSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40000E7")]
	public int m_CatalogLocationCacheSize; //Field offset: 0x14

	[Address(RVA = "0x2E3C100", Offset = "0x2E3B500", Length = "0xD5")]
	[Token(Token = "0x60001DE")]
	public BinaryCatalogInitializationData() { }

}

