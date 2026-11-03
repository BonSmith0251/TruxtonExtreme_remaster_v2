namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A4")]
internal struct ConvertMeshJobData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400139D")]
	public IntPtr vertSrc; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400139E")]
	public IntPtr vertDst; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400139F")]
	public int vertCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40013A0")]
	public Matrix4x4 transform; //Field offset: 0x14
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40013A1")]
	public Color32 xformClipPages; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40013A2")]
	public Color32 ids; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40013A3")]
	public Color32 addFlags; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40013A4")]
	public Color32 opacityPage; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40013A5")]
	public Color32 textCoreSettingsPage; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40013A6")]
	public int usesTextCoreSettings; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40013A7")]
	public float textureId; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40013A8")]
	public int gradientSettingsIndexOffset; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40013A9")]
	public IntPtr indexSrc; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40013AA")]
	public IntPtr indexDst; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40013AB")]
	public int indexCount; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40013AC")]
	public int indexOffset; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40013AD")]
	public int flipIndices; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40013AE")]
	public int forceZ; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40013AF")]
	public float positionZ; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40013B0")]
	public int remapUVs; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40013B1")]
	public Rect atlasRect; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40013B2")]
	public Vector2 layoutSize; //Field offset: 0xB0

}

