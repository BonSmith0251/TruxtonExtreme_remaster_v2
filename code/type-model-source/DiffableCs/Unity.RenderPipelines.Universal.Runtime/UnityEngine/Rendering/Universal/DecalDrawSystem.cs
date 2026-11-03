namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000088")]
internal abstract class DecalDrawSystem
{
	[Token(Token = "0x40002A0")]
	internal static readonly uint MaxBatchSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A1")]
	protected DecalEntityManager m_EntityManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002A2")]
	private Matrix4x4[] m_WorldToDecals; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002A3")]
	private Matrix4x4[] m_NormalToDecals; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002A4")]
	private Single[] m_DecalLayerMasks; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002A5")]
	private ProfilingSampler m_Sampler; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002A6")]
	private Material <overrideMaterial>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x170000DE")]
	public Material overrideMaterial
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600032B")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600032C")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2D76B70", Offset = "0x2D75F70", Length = "0x39")]
	[Token(Token = "0x6000339")]
	private static DecalDrawSystem() { }

	[Address(RVA = "0x2D76BB0", Offset = "0x2D75FB0", Length = "0x14A")]
	[Token(Token = "0x600032D")]
	public DecalDrawSystem(string sampler, DecalEntityManager entityManager) { }

	[Address(RVA = "0x2D75B50", Offset = "0x2D74F50", Length = "0x2BE")]
	[Token(Token = "0x6000333")]
	private void Draw(RasterCommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex) { }

	[Address(RVA = "0x2D75E10", Offset = "0x2D75210", Length = "0x32C")]
	[Token(Token = "0x6000337")]
	private void Draw(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk) { }

	[Address(RVA = "0x2D75840", Offset = "0x2D74C40", Length = "0x300")]
	[Token(Token = "0x6000334")]
	private void DrawInstanced(RasterCommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex) { }

	[Address(RVA = "0x2D754D0", Offset = "0x2D748D0", Length = "0x368")]
	[Token(Token = "0x6000338")]
	private void DrawInstanced(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk) { }

	[Address(RVA = "0x2D76140", Offset = "0x2D75540", Length = "0xC3")]
	[Token(Token = "0x600032E")]
	public void Execute(CommandBuffer cmd) { }

	[Address(RVA = "0x2D76840", Offset = "0x2D75C40", Length = "0x32E")]
	[Token(Token = "0x600032F")]
	internal void Execute(RasterCommandBuffer cmd) { }

	[Address(RVA = "0x2D76390", Offset = "0x2D75790", Length = "0x193")]
	[Token(Token = "0x6000332")]
	private void Execute(RasterCommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count) { }

	[Address(RVA = "0x2D76530", Offset = "0x2D75930", Length = "0x30F")]
	[Token(Token = "0x6000335")]
	public void Execute(in CameraData cameraData) { }

	[Address(RVA = "0x2D76210", Offset = "0x2D75610", Length = "0x173")]
	[Token(Token = "0x6000336")]
	private void Execute(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600032B")]
	public Material get_overrideMaterial() { }

	[Address(RVA = "0x2D56D90", Offset = "0x2D56190", Length = "0x17")]
	[Token(Token = "0x6000330")]
	protected override Material GetMaterial(DecalEntityChunk decalEntityChunk) { }

	[Token(Token = "0x6000331")]
	protected abstract int GetPassIndex(DecalCachedChunk decalCachedChunk) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600032C")]
	public void set_overrideMaterial(Material value) { }

}

