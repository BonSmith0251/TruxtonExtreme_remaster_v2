namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200008D")]
internal class DecalEntityManager : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x200008F")]
	private sealed class <>c
	{
		[Token(Token = "0x40002C6")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40002C7")]
		public static Comparison<CombinedChunks> <>9__26_0; //Field offset: 0x8

		[Address(RVA = "0x2D89A60", Offset = "0x2D88E60", Length = "0x67")]
		[Token(Token = "0x6000352")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000353")]
		public <>c() { }

		[Address(RVA = "0x2D89690", Offset = "0x2D88A90", Length = "0x12E")]
		[Token(Token = "0x6000354")]
		internal int <Update>b__26_0(CombinedChunks a, CombinedChunks b) { }

	}

	[Token(Token = "0x200008E")]
	private struct CombinedChunks
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C0")]
		public DecalEntityChunk entityChunk; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002C1")]
		public DecalCachedChunk cachedChunk; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002C2")]
		public DecalCulledChunk culledChunk; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002C3")]
		public DecalDrawCallChunk drawCallChunk; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002C4")]
		public int previousChunkIndex; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40002C5")]
		public bool valid; //Field offset: 0x24

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002B2")]
	public List<DecalEntityChunk> entityChunks; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002B3")]
	public List<DecalCachedChunk> cachedChunks; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002B4")]
	public List<DecalCulledChunk> culledChunks; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002B5")]
	public List<DecalDrawCallChunk> drawCallChunks; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002B6")]
	public int chunkCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002B7")]
	private ProfilingSampler m_AddDecalSampler; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002B8")]
	private ProfilingSampler m_ResizeChunks; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002B9")]
	private ProfilingSampler m_SortChunks; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002BA")]
	private DecalEntityIndexer m_DecalEntityIndexer; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002BB")]
	private Dictionary<Material, Int32> m_MaterialToChunkIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002BC")]
	private List<CombinedChunks> m_CombinedChunks; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002BD")]
	private List<Int32> m_CombinedChunkRemmap; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002BE")]
	private Material m_ErrorMaterial; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002BF")]
	private Mesh m_DecalProjectorMesh; //Field offset: 0x78

	[Token(Token = "0x170000E0")]
	public Mesh decalProjectorMesh
	{
		[Address(RVA = "0x2D7A580", Offset = "0x2D79980", Length = "0xEE")]
		[Token(Token = "0x6000348")]
		 get { } //Length: 238
	}

	[Token(Token = "0x170000DF")]
	public Material errorMaterial
	{
		[Address(RVA = "0x2D7A670", Offset = "0x2D79A70", Length = "0xBA")]
		[Token(Token = "0x6000347")]
		 get { } //Length: 186
	}

	[Address(RVA = "0x2D7A1C0", Offset = "0x2D795C0", Length = "0x3BD")]
	[Token(Token = "0x6000349")]
	public DecalEntityManager() { }

	[Address(RVA = "0x2D77650", Offset = "0x2D76A50", Length = "0x5F0")]
	[Token(Token = "0x600034C")]
	private int CreateChunkIndex(Material material) { }

	[Address(RVA = "0x2D77C50", Offset = "0x2D77050", Length = "0x585")]
	[Token(Token = "0x600034B")]
	public DecalEntity CreateDecalEntity(DecalProjector decalProjector) { }

	[Address(RVA = "0x2D781E0", Offset = "0x2D775E0", Length = "0x367")]
	[Token(Token = "0x600034F")]
	public void DestroyDecalEntity(DecalEntity decalEntity) { }

	[Address(RVA = "0x2D78550", Offset = "0x2D77950", Length = "0x97A")]
	[Token(Token = "0x6000351")]
	public override void Dispose() { }

	[Address(RVA = "0x2D7A580", Offset = "0x2D79980", Length = "0xEE")]
	[Token(Token = "0x6000348")]
	public Mesh get_decalProjectorMesh() { }

	[Address(RVA = "0x2D7A670", Offset = "0x2D79A70", Length = "0xBA")]
	[Token(Token = "0x6000347")]
	public Material get_errorMaterial() { }

	[Address(RVA = "0x2D78ED0", Offset = "0x2D782D0", Length = "0x1E")]
	[Token(Token = "0x600034A")]
	public bool IsValid(DecalEntity decalEntity) { }

	[Address(RVA = "0x2D79710", Offset = "0x2D78B10", Length = "0xAAB")]
	[Token(Token = "0x6000350")]
	public void Update() { }

	[Address(RVA = "0x2D78EF0", Offset = "0x2D782F0", Length = "0x1D8")]
	[Token(Token = "0x600034D")]
	public void UpdateAllDecalEntitiesData() { }

	[Address(RVA = "0x2D790D0", Offset = "0x2D784D0", Length = "0x635")]
	[Token(Token = "0x600034E")]
	public void UpdateDecalEntityData(DecalEntity decalEntity, DecalProjector decalProjector) { }

}

