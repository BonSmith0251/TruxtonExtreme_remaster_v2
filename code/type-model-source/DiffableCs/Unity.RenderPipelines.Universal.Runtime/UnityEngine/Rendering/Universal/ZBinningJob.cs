namespace UnityEngine.Rendering.Universal;

[BurstCompile(FloatMode = FloatMode::Fast (3), DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x20001C0")]
internal struct ZBinningJob : IJobFor
{
	[Token(Token = "0x40009A5")]
	public const int batchSize = 128; //Field offset: 0x0
	[Token(Token = "0x40009A6")]
	public const int headerLength = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeDisableParallelForRestriction]
	[Token(Token = "0x40009A7")]
	public NativeArray<UInt32> bins; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x40009A8")]
	public NativeArray<float2> minMaxZs; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009A9")]
	public float zBinScale; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009AA")]
	public float zBinOffset; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009AB")]
	public int binCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40009AC")]
	public int wordsPerTile; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009AD")]
	public int lightCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40009AE")]
	public int reflectionProbeCount; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009AF")]
	public int batchCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40009B0")]
	public int viewCount; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40009B1")]
	public bool isOrthographic; //Field offset: 0x40

	[Address(RVA = "0x2DFD820", Offset = "0x2DFCC20", Length = "0x53")]
	[Token(Token = "0x600099B")]
	private static ValueTuple<UInt32, UInt32> DecodeHeader(uint zBin) { }

	[Address(RVA = "0x2DFD880", Offset = "0x2DFCC80", Length = "0x9")]
	[Token(Token = "0x600099A")]
	private static uint EncodeHeader(uint min, uint max) { }

	[Address(RVA = "0x2DFD890", Offset = "0x2DFCC90", Length = "0x126")]
	[Token(Token = "0x600099C")]
	public override void Execute(int jobIndex) { }

	[Address(RVA = "0x2DFD9C0", Offset = "0x2DFCDC0", Length = "0x1AF")]
	[Token(Token = "0x600099D")]
	private void FillZBins(int binStart, int binEnd, int itemStart, int itemEnd, int headerIndex, int itemOffset, int binOffset) { }

}

