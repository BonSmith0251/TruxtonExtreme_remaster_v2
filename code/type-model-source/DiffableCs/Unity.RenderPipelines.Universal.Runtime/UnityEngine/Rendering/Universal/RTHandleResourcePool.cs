namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200019B")]
internal class RTHandleResourcePool
{
	[Token(Token = "0x400090D")]
	protected static int s_CurrentStaleResourceCount; //Field offset: 0x0
	[Token(Token = "0x400090E")]
	protected static int s_StaleResourceLifetime; //Field offset: 0x4
	[Token(Token = "0x400090F")]
	protected static int s_StaleResourceMaxCapacity; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400090B")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"resource", "frameIndex"})]
	protected Dictionary<Int32, SortedList`2<Int32, ValueTuple`2<RTHandle, Int32>>> m_ResourcePool; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400090C")]
	protected List<Int32> m_RemoveList; //Field offset: 0x18

	[Token(Token = "0x1700021A")]
	internal int staleResourceCapacity
	{
		[Address(RVA = "0x2DE9D10", Offset = "0x2DE9110", Length = "0x4E")]
		[Token(Token = "0x60008E4")]
		internal get { } //Length: 78
		[Address(RVA = "0x2DE9D60", Offset = "0x2DE9160", Length = "0x87")]
		[Token(Token = "0x60008E5")]
		internal set { } //Length: 135
	}

	[Address(RVA = "0x2DE9BD0", Offset = "0x2DE8FD0", Length = "0x63")]
	[Token(Token = "0x60008EF")]
	private static RTHandleResourcePool() { }

	[Address(RVA = "0x2DE9C40", Offset = "0x2DE9040", Length = "0xC2")]
	[Token(Token = "0x60008EE")]
	public RTHandleResourcePool() { }

	[Address(RVA = "0x2DE8860", Offset = "0x2DE7C60", Length = "0x229")]
	[Token(Token = "0x60008E6")]
	internal bool AddResourceToPool(in TextureDesc texDesc, RTHandle resource, int currentFrameIndex) { }

	[Address(RVA = "0x2DE8A90", Offset = "0x2DE7E90", Length = "0x2EB")]
	[Token(Token = "0x60008E8")]
	internal void Cleanup() { }

	[Address(RVA = "0x2DE8D80", Offset = "0x2DE8180", Length = "0x142")]
	[Token(Token = "0x60008ED")]
	internal static TextureDesc CreateTextureDesc(RenderTextureDescriptor desc, TextureSizeMode textureSizeMode = 0, int anisoLevel = 1, float mipMapBias = 0, FilterMode filterMode = 0, TextureWrapMode wrapMode = 1, string name = "") { }

	[Address(RVA = "0x2DE9D10", Offset = "0x2DE9110", Length = "0x4E")]
	[Token(Token = "0x60008E4")]
	internal int get_staleResourceCapacity() { }

	[Address(RVA = "0x2DE8ED0", Offset = "0x2DE82D0", Length = "0x98")]
	[Token(Token = "0x60008EC")]
	internal int GetHashCodeWithNameHash(in TextureDesc texDesc) { }

	[Address(RVA = "0x2DE8F70", Offset = "0x2DE8370", Length = "0x607")]
	[Token(Token = "0x60008EB")]
	internal void LogDebugInfo() { }

	[Address(RVA = "0x2DE9580", Offset = "0x2DE8980", Length = "0x429")]
	[Token(Token = "0x60008EA")]
	internal void PurgeUnusedResources(int currentFrameIndex) { }

	[Address(RVA = "0x2DE9D60", Offset = "0x2DE9160", Length = "0x87")]
	[Token(Token = "0x60008E5")]
	internal void set_staleResourceCapacity(int value) { }

	[Address(RVA = "0x2DE99B0", Offset = "0x2DE8DB0", Length = "0x65")]
	[Token(Token = "0x60008E9")]
	protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex) { }

	[Address(RVA = "0x2DE9A20", Offset = "0x2DE8E20", Length = "0x1A1")]
	[Token(Token = "0x60008E7")]
	internal bool TryGetResource(in TextureDesc texDesc, out RTHandle resource, bool usepool = true) { }

}

