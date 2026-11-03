namespace UnityEngine.Rendering;

[Token(Token = "0x2000034")]
public struct OccluderSubviewUpdate
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A7")]
	public int subviewIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000A8")]
	public int depthSliceIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000A9")]
	public Vector2Int depthOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AA")]
	public Matrix4x4 viewMatrix; //Field offset: 0x10
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000AB")]
	public Matrix4x4 invViewMatrix; //Field offset: 0x50
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000AC")]
	public Matrix4x4 gpuProjMatrix; //Field offset: 0x90
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000AD")]
	public Vector3 viewOffsetWorldSpace; //Field offset: 0xD0

	[Address(RVA = "0x2CD37A0", Offset = "0x2CD2BA0", Length = "0x175")]
	[Token(Token = "0x600011F")]
	public OccluderSubviewUpdate(int subviewIndex) { }

}

