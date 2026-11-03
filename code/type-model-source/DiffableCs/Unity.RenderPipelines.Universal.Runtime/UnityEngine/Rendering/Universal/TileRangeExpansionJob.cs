namespace UnityEngine.Rendering.Universal;

[BurstCompile(FloatMode = FloatMode::Fast (3), DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x20001BA")]
internal struct TileRangeExpansionJob : IJobFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400097C")]
	public NativeArray<InclusiveRange> tileRanges; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[NativeDisableParallelForRestriction]
	[Token(Token = "0x400097D")]
	public NativeArray<UInt32> tileMasks; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400097E")]
	public int rangesPerItem; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400097F")]
	public int itemsPerTile; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000980")]
	public int wordsPerTile; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000981")]
	public int2 tileResolution; //Field offset: 0x2C

	[Address(RVA = "0x2DF38A0", Offset = "0x2DF2CA0", Length = "0x207")]
	[Token(Token = "0x6000980")]
	public override void Execute(int jobIndex) { }

}

