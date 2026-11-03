namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000335")]
internal class ShaderRuntimeInfoAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400085F")]
	public long VariantsRequested; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000860")]
	public long VariantsRequestedMissing; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000861")]
	public long VariantsRequestedUnsupported; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000862")]
	public long VariantsRequestedCompiled; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000863")]
	public long VariantsRequestedViaWarmup; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000864")]
	public long VariantsUnused; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000865")]
	public int VariantsCompilationTimeTotal; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000866")]
	public int VariantsCompilationTimeMax; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000867")]
	public int VariantsCompilationTimeMedian; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000868")]
	public int VariantsWarmupTimeTotal; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000869")]
	public int VariantsWarmupTimeMax; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400086A")]
	public int VariantsWarmupTimeMedian; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400086B")]
	public bool UseProgressiveWarmup; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400086C")]
	public int ShaderChunkSizeMin; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400086D")]
	public int ShaderChunkSizeMax; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400086E")]
	public int ShaderChunkSizeAvg; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400086F")]
	public int ShaderChunkCountMin; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000870")]
	public int ShaderChunkCountMax; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000871")]
	public int ShaderChunkCountAvg; //Field offset: 0x90

	[Address(RVA = "0x3088C90", Offset = "0x3088090", Length = "0xD1")]
	[Token(Token = "0x60019E3")]
	private ShaderRuntimeInfoAnalytic() { }

	[Address(RVA = "0x3088B90", Offset = "0x3087F90", Length = "0xFD")]
	[RequiredByNativeCode]
	[Token(Token = "0x60019E4")]
	public static ShaderRuntimeInfoAnalytic CreateShaderRuntimeInfoAnalytic() { }

}

