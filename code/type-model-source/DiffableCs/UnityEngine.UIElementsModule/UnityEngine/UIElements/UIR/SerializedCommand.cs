namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000579")]
internal struct SerializedCommand
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001231")]
	public SerializedCommandType type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001232")]
	public IntPtr vertexBuffer; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001233")]
	public IntPtr indexBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001234")]
	public int firstRange; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001235")]
	public int rangeCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001236")]
	public int textureName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001237")]
	public IntPtr texturePtr; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001238")]
	public int gpuDataOffset; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001239")]
	public Vector4 gpuData0; //Field offset: 0x34
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400123A")]
	public Vector4 gpuData1; //Field offset: 0x44
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400123B")]
	public MaterialPropertyBlock userProps; //Field offset: 0x58

}

