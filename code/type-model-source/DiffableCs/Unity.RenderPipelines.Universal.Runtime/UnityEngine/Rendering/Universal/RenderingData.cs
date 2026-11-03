namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001EF")]
public struct RenderingData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB3")]
	internal ContextContainer frameData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000AB4")]
	public CameraData cameraData; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AB5")]
	public LightData lightData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AB6")]
	public ShadowData shadowData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AB7")]
	public PostProcessingData postProcessingData; //Field offset: 0x20

	[Token(Token = "0x1700026F")]
	public CullingResults cullResults
	{
		[Address(RVA = "0x2E08960", Offset = "0x2E07D60", Length = "0x4D")]
		[Token(Token = "0x6000A90")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000271")]
	public PerObjectData perObjectData
	{
		[Address(RVA = "0x2E089B0", Offset = "0x2E07DB0", Length = "0x4D")]
		[Token(Token = "0x6000A92")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000272")]
	public bool postProcessingEnabled
	{
		[Address(RVA = "0x2E08A00", Offset = "0x2E07E00", Length = "0x4D")]
		[Token(Token = "0x6000A93")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000270")]
	public bool supportsDynamicBatching
	{
		[Address(RVA = "0x2E08A50", Offset = "0x2E07E50", Length = "0x4D")]
		[Token(Token = "0x6000A91")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700026E")]
	internal UniversalRenderingData universalRenderingData
	{
		[Address(RVA = "0x2E08AA0", Offset = "0x2E07EA0", Length = "0x43")]
		[Token(Token = "0x6000A8F")]
		internal get { } //Length: 67
	}

	[Address(RVA = "0x2E088A0", Offset = "0x2E07CA0", Length = "0xBB")]
	[Token(Token = "0x6000A8E")]
	internal RenderingData(ContextContainer frameData) { }

	[Address(RVA = "0x2E08960", Offset = "0x2E07D60", Length = "0x4D")]
	[Token(Token = "0x6000A90")]
	public CullingResults get_cullResults() { }

	[Address(RVA = "0x2E089B0", Offset = "0x2E07DB0", Length = "0x4D")]
	[Token(Token = "0x6000A92")]
	public PerObjectData get_perObjectData() { }

	[Address(RVA = "0x2E08A00", Offset = "0x2E07E00", Length = "0x4D")]
	[Token(Token = "0x6000A93")]
	public bool get_postProcessingEnabled() { }

	[Address(RVA = "0x2E08A50", Offset = "0x2E07E50", Length = "0x4D")]
	[Token(Token = "0x6000A91")]
	public bool get_supportsDynamicBatching() { }

	[Address(RVA = "0x2E08AA0", Offset = "0x2E07EA0", Length = "0x43")]
	[Token(Token = "0x6000A8F")]
	internal UniversalRenderingData get_universalRenderingData() { }

}

