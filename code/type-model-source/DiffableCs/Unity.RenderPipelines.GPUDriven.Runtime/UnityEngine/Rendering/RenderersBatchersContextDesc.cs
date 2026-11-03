namespace UnityEngine.Rendering;

[Token(Token = "0x20000E2")]
internal struct RenderersBatchersContextDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400040C")]
	public InstanceNumInfo instanceNumInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400040D")]
	public bool supportDitheringCrossFade; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x400040E")]
	public bool enableBoundingSpheresInstanceData; //Field offset: 0x9
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400040F")]
	public float smallMeshScreenPercentage; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000410")]
	public bool enableCullerDebugStats; //Field offset: 0x10

	[Address(RVA = "0x2CFFE00", Offset = "0x2CFF200", Length = "0x25")]
	[Token(Token = "0x600037E")]
	public static RenderersBatchersContextDesc NewDefault() { }

}

