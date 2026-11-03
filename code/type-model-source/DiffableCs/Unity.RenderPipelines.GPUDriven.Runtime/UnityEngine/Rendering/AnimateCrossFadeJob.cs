namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x200003F")]
internal struct AnimateCrossFadeJob : IJobParallelFor
{
	[Token(Token = "0x40000D9")]
	public const int k_BatchSize = 512; //Field offset: 0x0
	[Token(Token = "0x40000DA")]
	public const byte k_MeshLODTransitionToLowerLODBit = 128; //Field offset: 0x0
	[Token(Token = "0x40000DB")]
	private const byte k_LODFadeOff = 255; //Field offset: 0x0
	[Token(Token = "0x40000DC")]
	private const float k_CrossfadeAnimationTimeS = 0.333; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40000DD")]
	public float deltaTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000DE")]
	public UnsafeList<Byte> crossFadeArray; //Field offset: 0x8

	[Address(RVA = "0x2CC11B0", Offset = "0x2CC05B0", Length = "0x7E")]
	[Token(Token = "0x600012E")]
	public override void Execute(int instanceIndex) { }

}

