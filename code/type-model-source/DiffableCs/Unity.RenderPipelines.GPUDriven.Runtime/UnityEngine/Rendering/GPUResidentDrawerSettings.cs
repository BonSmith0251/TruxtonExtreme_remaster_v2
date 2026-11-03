namespace UnityEngine.Rendering;

[Token(Token = "0x2000037")]
public struct GPUResidentDrawerSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B6")]
	public GPUResidentDrawerMode mode; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x40000B7")]
	public bool supportDitheringCrossFade; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x40000B8")]
	public bool enableOcclusionCulling; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x40000B9")]
	public bool allowInEditMode; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000BA")]
	public float smallMeshScreenPercentage; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BB")]
	public Shader errorShader; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000BC")]
	public Shader loadingShader; //Field offset: 0x10

}

