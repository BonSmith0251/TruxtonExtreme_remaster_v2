namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001F6")]
public struct PostProcessingData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B06")]
	private ContextContainer frameData; //Field offset: 0x0

	[Token(Token = "0x17000297")]
	public ColorGradingMode gradingMode
	{
		[Address(RVA = "0x2E08070", Offset = "0x2E07470", Length = "0x4D")]
		[Token(Token = "0x6000ABC")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000298")]
	public int lutSize
	{
		[Address(RVA = "0x2E080C0", Offset = "0x2E074C0", Length = "0x4D")]
		[Token(Token = "0x6000ABD")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700029B")]
	public bool supportDataDrivenLensFlare
	{
		[Address(RVA = "0x2E08110", Offset = "0x2E07510", Length = "0x4D")]
		[Token(Token = "0x6000AC0")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700029A")]
	public bool supportScreenSpaceLensFlare
	{
		[Address(RVA = "0x2E08160", Offset = "0x2E07560", Length = "0x4D")]
		[Token(Token = "0x6000ABF")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000296")]
	internal UniversalPostProcessingData universalPostProcessingData
	{
		[Address(RVA = "0x2E081B0", Offset = "0x2E075B0", Length = "0x43")]
		[Token(Token = "0x6000ABB")]
		internal get { } //Length: 67
	}

	[Token(Token = "0x17000299")]
	public bool useFastSRGBLinearConversion
	{
		[Address(RVA = "0x2E08200", Offset = "0x2E07600", Length = "0x4D")]
		[Token(Token = "0x6000ABE")]
		 get { } //Length: 77
	}

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6000ABA")]
	internal PostProcessingData(ContextContainer frameData) { }

	[Address(RVA = "0x2E08070", Offset = "0x2E07470", Length = "0x4D")]
	[Token(Token = "0x6000ABC")]
	public ColorGradingMode get_gradingMode() { }

	[Address(RVA = "0x2E080C0", Offset = "0x2E074C0", Length = "0x4D")]
	[Token(Token = "0x6000ABD")]
	public int get_lutSize() { }

	[Address(RVA = "0x2E08110", Offset = "0x2E07510", Length = "0x4D")]
	[Token(Token = "0x6000AC0")]
	public bool get_supportDataDrivenLensFlare() { }

	[Address(RVA = "0x2E08160", Offset = "0x2E07560", Length = "0x4D")]
	[Token(Token = "0x6000ABF")]
	public bool get_supportScreenSpaceLensFlare() { }

	[Address(RVA = "0x2E081B0", Offset = "0x2E075B0", Length = "0x43")]
	[Token(Token = "0x6000ABB")]
	internal UniversalPostProcessingData get_universalPostProcessingData() { }

	[Address(RVA = "0x2E08200", Offset = "0x2E07600", Length = "0x4D")]
	[Token(Token = "0x6000ABE")]
	public bool get_useFastSRGBLinearConversion() { }

}

