namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000DA")]
public class UniversalPostProcessingData : ContextItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004F4")]
	public bool isEnabled; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004F5")]
	public ColorGradingMode gradingMode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004F6")]
	public int lutSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004F7")]
	public bool useFastSRGBLinearConversion; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x40004F8")]
	public bool supportScreenSpaceLensFlare; //Field offset: 0x1D
	[FieldOffset(Offset = "0x1E")]
	[Token(Token = "0x40004F9")]
	public bool supportDataDrivenLensFlare; //Field offset: 0x1E

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60005BE")]
	public UniversalPostProcessingData() { }

	[Address(RVA = "0x2D94F90", Offset = "0x2D94390", Length = "0x12")]
	[Token(Token = "0x60005BD")]
	public virtual void Reset() { }

}

