namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200014C")]
internal class PostProcessMaterialLibrary
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400077C")]
	public readonly Material stopNaN; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400077D")]
	public readonly Material subpixelMorphologicalAntialiasing; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400077E")]
	public readonly Material gaussianDepthOfField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400077F")]
	public readonly Material gaussianDepthOfFieldCoC; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000780")]
	public readonly Material bokehDepthOfField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000781")]
	public readonly Material bokehDepthOfFieldCoC; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000782")]
	public readonly Material temporalAntialiasing; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000783")]
	public readonly Material motionBlur; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000784")]
	public readonly Material paniniProjection; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000785")]
	public readonly Material bloom; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000786")]
	public readonly Material[] bloomUpsample; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000787")]
	public readonly Material lensFlareScreenSpace; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000788")]
	public readonly Material lensFlareDataDriven; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000789")]
	public readonly Material uber; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400078A")]
	public readonly Material scalingSetup; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400078B")]
	public readonly Material easu; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400078C")]
	public readonly Material finalPass; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400078D")]
	internal PostProcessData m_Resources; //Field offset: 0x98

	[Token(Token = "0x170001DA")]
	public PostProcessData resources
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x60007A9")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2DCB710", Offset = "0x2DCAB10", Length = "0x3FE")]
	[Token(Token = "0x60007AA")]
	public PostProcessMaterialLibrary(PostProcessData data) { }

	[Address(RVA = "0x2DCB4A0", Offset = "0x2DCA8A0", Length = "0x16C")]
	[Token(Token = "0x60007AC")]
	internal void Cleanup() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x60007A9")]
	public PostProcessData get_resources() { }

	[Address(RVA = "0x2DCB610", Offset = "0x2DCAA10", Length = "0xF5")]
	[Token(Token = "0x60007AB")]
	private Material Load(Shader shader) { }

}

