namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x200001D")]
internal sealed class RadeonRaysShaders
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400008B")]
	public ComputeShader bitHistogram; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008C")]
	public ComputeShader blockReducePart; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008D")]
	public ComputeShader blockScan; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400008E")]
	public ComputeShader buildHlbvh; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400008F")]
	public ComputeShader restructureBvh; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000090")]
	public ComputeShader scatter; //Field offset: 0x38

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000037")]
	public RadeonRaysShaders() { }

}

