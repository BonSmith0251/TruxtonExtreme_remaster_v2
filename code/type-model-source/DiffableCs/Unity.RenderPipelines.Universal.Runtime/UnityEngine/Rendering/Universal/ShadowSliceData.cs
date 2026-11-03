namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001AA")]
public struct ShadowSliceData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400093E")]
	public Matrix4x4 viewMatrix; //Field offset: 0x0
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400093F")]
	public Matrix4x4 projectionMatrix; //Field offset: 0x40
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000940")]
	public Matrix4x4 shadowTransform; //Field offset: 0x80
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000941")]
	public int offsetX; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000942")]
	public int offsetY; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000943")]
	public int resolution; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x4000944")]
	public ShadowSplitData splitData; //Field offset: 0xCC

	[Address(RVA = "0x2DED180", Offset = "0x2DEC580", Length = "0x10B")]
	[Token(Token = "0x6000920")]
	public void Clear() { }

}

